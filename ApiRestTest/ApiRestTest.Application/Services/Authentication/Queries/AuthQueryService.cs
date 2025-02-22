using ApiRestTest.Application.Common.Errors;
using ApiRestTest.Application.Common.Interfaces.Authentication;
using ApiRestTest.Application.Common.Interfaces.Persistence;
using ApiRestTest.Application.Services.Authentication.Common;
using ApiRestTest.Domain.Entities;


namespace ApiRestTest.Application.Services.Authentication.Queries
{
    internal class AuthQueryService: IAuthQueryService
    {
        private readonly IJwtTokenGenerator _jwtTokenGenerator;
        private readonly IUserRepository _userRepository;

        public AuthQueryService(IJwtTokenGenerator jwtTokenGenerator, IUserRepository userRepository)
        {
            _jwtTokenGenerator = jwtTokenGenerator;
            _userRepository = userRepository;
        }
        public async Task<AuthResult> Login(string email, string password)
        {
            if (await _userRepository.GetUserByEmail(email) is not User user)
            {
                throw new DuplicateEmailException();
            }

            if (user.Password != password)
            {
                throw new EmailInvalidException();
            }

            var token = _jwtTokenGenerator.GenerateToken(user);

            return new AuthResult(
                user,
                token
            );
        }
    }
}
