using APITheTipTop.Models;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace APITheTipTop
{
    public interface IUserService
    {
        AuthenticateResponse Authenticate(AuthenticateRequest model);
        IEnumerable<Tuser> GetAll();
        Tuser GetById(int id);
    }
    public class UserService:IUserService
    {
        private readonly thetiptoptestContext thetiptoptestContext;
        public UserService(thetiptoptestContext thetiptoptestContext)
        {
            this.thetiptoptestContext = thetiptoptestContext;


        }
    
        

        private readonly AppSettings _appSettings;

        public UserService(IOptions<AppSettings> appSettings)
        {
            _appSettings = appSettings.Value;
        }

        public AuthenticateResponse Authenticate(AuthenticateRequest model)
        {
            List<Tuser> _users = thetiptoptestContext.Tusers.ToList();
            var user = _users.SingleOrDefault(x => x.Email == model.Username && x.MotDepasse == model.Password);

            // return null if user not found
            if (user == null) return null;

            // authentication successful so generate jwt token
            var token = generateJwtToken(user);

            return new AuthenticateResponse(user, token);
        }

        public IEnumerable<Tuser> GetAll()
        {
            return thetiptoptestContext.Tusers.ToList();
        }

        public Tuser GetById(int id)
        {
            return thetiptoptestContext.Tusers.ToList().FirstOrDefault(x => x.Iduser == id);
        }

        // helper methods

        private string generateJwtToken(Tuser user)
        {
            // generate token that is valid for 7 days
            var tokenHandler = new JwtSecurityTokenHandler();
            var key = Encoding.ASCII.GetBytes(_appSettings.Secret);
            var tokenDescriptor = new SecurityTokenDescriptor
            {
                Subject = new ClaimsIdentity(new[] { new Claim("id", user.Iduser.ToString()) }),
                Expires = DateTime.UtcNow.AddDays(7),
                SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(key), SecurityAlgorithms.HmacSha256Signature)
            };
            var token = tokenHandler.CreateToken(tokenDescriptor);
            return tokenHandler.WriteToken(token);
        }
    }
}
