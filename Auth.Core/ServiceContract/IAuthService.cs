using Auth.Core.Dto;

namespace Auth.Core.ServiceContract
{
    public interface IAuthService
    {
        Task<string> Register(RegistrationRequestDto? requestDto);
        Task<LoginResponseDto> Login(LoginRequestDto? loginRequestDto);
        Task<bool> AssignRole(string email, string roleName);
    }
}
