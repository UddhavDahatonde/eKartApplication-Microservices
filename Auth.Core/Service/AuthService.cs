using Auth.Core.Domain.Entities;
using Auth.Core.Domain.RepositeryContract;
using Auth.Core.Dto;
using Auth.Core.ServiceContract;
using Contracts;
using Microsoft.AspNetCore.Identity;

namespace Auth.Core.Service
{
    public class AuthService : IAuthService
    {
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly RoleManager<ApplicationRole> _roleManager;
        private readonly ILoggerManager _loggerManager;
        private readonly IAuthRepositery _authRepositery;
        private readonly IJwtTokenGenerator _jwtTokenGenerator;

        public AuthService(UserManager<ApplicationUser> userManager, ILoggerManager loggerManager, IAuthRepositery authRepositery, IJwtTokenGenerator jwtTokenGenerator, RoleManager<ApplicationRole> roleManager)
        {
            _userManager = userManager;
            _loggerManager = loggerManager;
            _authRepositery = authRepositery;
            _jwtTokenGenerator = jwtTokenGenerator;
            _roleManager = roleManager;
        }
        public async Task<bool> AssignRole(string email, string roleName)
        {
            try
            {
                var user = await _authRepositery.FirstOrDefaultAsync(u => u.Email.ToLower() == email.ToLower());
                if (user != null)
                {
                    if (!_roleManager.RoleExistsAsync(roleName).GetAwaiter().GetResult())
                    {
                        //create role if it does not exist
                        _roleManager.CreateAsync(new ApplicationRole(roleName)).GetAwaiter().GetResult();
                    }
                    await _userManager.AddToRoleAsync(user, roleName);
                    return true;
                }
            }
            catch (Exception exception)
            {
                _loggerManager.LogError($"Error Occurred in [AssignRole] of AuthService, Error Details: {exception.Message}");
            }

            return false;

        }
        public async Task<LoginResponseDto> Login(LoginRequestDto? loginRequestDto)
        {
            if (loginRequestDto == null)
            {
                throw new ArgumentNullException(nameof(loginRequestDto));
            }
            try
            {
                var user = await _authRepositery.FirstOrDefaultAsync(user => user.Email == loginRequestDto.UserName);
                bool isValid = false;
                if (user != null && loginRequestDto.Password != null)
                {
                    isValid = await _userManager.CheckPasswordAsync(user, loginRequestDto.Password);
                }
                if (isValid)
                {
                    //if user was found , Generate JWT Token
                    var roles = await _userManager.GetRolesAsync(user);
                    var token = _jwtTokenGenerator.GenerateToken(user, roles);

                    UserDto userDTO = new()
                    {
                        Email = user.Email,
                        UserId = user.Id,
                        Name = user.Name,
                        PhoneNumber = user.PhoneNumber
                    };

                    LoginResponseDto loginResponseDto = new LoginResponseDto()
                    {
                        User = userDTO,
                        Token = token
                    };
                    return loginResponseDto;
                }
            }
            catch (Exception exception)
            {
                _loggerManager.LogError($"Error occurred in [Login] of [AuthService] Error Detail:{exception.Message}");
            }
            return new LoginResponseDto();
        }

        public async Task<string> Register(RegistrationRequestDto? registrationRequestDto)
        {

            try
            {
                if (registrationRequestDto == null)
                {
                    throw new ArgumentNullException(nameof(registrationRequestDto));
                }
                ApplicationUser user = new ApplicationUser()
                {
                    Name = registrationRequestDto.UserName.ToLower(),
                    Email = registrationRequestDto.Email,
                    NormalizedEmail = registrationRequestDto.Email.ToUpper(),
                    PhoneNumber = registrationRequestDto.PhoneNumber,
                    UserName = registrationRequestDto.Email
                };

                var isUserExists = await _userManager.FindByEmailAsync(user.Email);
                if (isUserExists == null)
                {
                    IdentityResult identityResult = await _userManager.CreateAsync(user, registrationRequestDto.Password);
                    if (identityResult.Succeeded)
                    {
                    }
                    else
                    {
                        return identityResult.Errors.FirstOrDefault().Description;
                    }
                }
                else
                {
                    return "User with this email already exists.";
                }


            }
            catch (Exception exception)
            {
                _loggerManager.LogError($"Error occurred in [Register] of [AuthService] Error Detail:{exception.Message}");
            }
            return "";
        }
    }
}
