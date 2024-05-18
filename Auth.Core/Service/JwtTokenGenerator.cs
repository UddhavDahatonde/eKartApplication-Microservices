using Auth.Core.Domain.Entities;
using Auth.Core.ServiceContract;
using Contracts;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace Auth.Core.Service
{
    public class JwtTokenGenerator : IJwtTokenGenerator
    {
        private readonly JwtOptions _jwtOptions;
        private readonly ILoggerManager _loggerManager;
        public JwtTokenGenerator(IOptions<JwtOptions> jwtOptions, ILoggerManager logger)
        {
            _jwtOptions = jwtOptions.Value;
            _loggerManager = logger;
        }

        public string GenerateToken(ApplicationUser applicationUser, IEnumerable<string> roles)
        {
            try
            {
                var tokenHandler = new JwtSecurityTokenHandler();
                var key = Encoding.ASCII.GetBytes(_jwtOptions.Secret);

                var claimList = new List<Claim>
                {
                new Claim(JwtRegisteredClaimNames.Email,applicationUser.Email),
                new Claim(JwtRegisteredClaimNames.Sub,Convert.ToString(applicationUser.Id)),
                new Claim(JwtRegisteredClaimNames.Name,applicationUser.UserName)
                };

                claimList.AddRange(roles.Select(role => new Claim(ClaimTypes.Role, role)));

                var tokenDescriptor = new SecurityTokenDescriptor
                {
                    Audience = _jwtOptions.Audience,
                    Issuer = _jwtOptions.Issuer,
                    Subject = new ClaimsIdentity(claimList),
                    Expires = DateTime.UtcNow.AddDays(7),
                    SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(key), SecurityAlgorithms.HmacSha256Signature)
                };
                var token = tokenHandler.CreateToken(tokenDescriptor);
                return tokenHandler.WriteToken(token);
            }
            catch (Exception exception)
            {
                _loggerManager.LogError($"Error Occurred in [GenerateToken] of JwtTokenGenerator, Error Details: {exception.Message}");
                return $"Error Occurred in [GenerateToken] of JwtTokenGenerator, Error Details: {exception.Message}";
            }


        }
    }
}
