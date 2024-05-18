using Auth.Core.Dto;
using Auth.Core.ServiceContract;
using Microsoft.AspNetCore.Mvc;

namespace Auth.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private readonly IAuthService _authService;
        private ResponseDto _responseDto;

        public AuthController(IAuthService authService)
        {
            _authService = authService;
            _responseDto = new ResponseDto();
        }
        [HttpPost, Route("/Register")]
        public async Task<ResponseDto> Register(RegistrationRequestDto registrationRequest)
        {
            string errorMessage = await _authService.Register(registrationRequest);
            if (!string.IsNullOrEmpty(errorMessage))
            {
                _responseDto.Message = errorMessage;
                _responseDto.Status = false;
            }
            else
            {
                _responseDto.Result = registrationRequest;
            }
            return _responseDto;
        }
        [HttpPost("login")]
        public async Task<ResponseDto> Login([FromBody] LoginRequestDto model)
        {
            var loginResponse = await _authService.Login(model);
            if (loginResponse.User == null)
            {
                _responseDto.Status = false;
                _responseDto.Message = "Username or password is incorrect";
                return _responseDto;
            }
            _responseDto.Result = loginResponse;
            return _responseDto;

        }

        [HttpPost("AssignRole")]
        public async Task<ResponseDto> AssignRole([FromBody] RegistrationRequestDto model)
        {
            var assignRoleSuccessful = await _authService.AssignRole(model.Email, model.Role.ToUpper());
            if (!assignRoleSuccessful)
            {
                _responseDto.Status = false;
                _responseDto.Message = "Error encountered";
                return _responseDto;
            }
            return _responseDto;

        }
    }
}
