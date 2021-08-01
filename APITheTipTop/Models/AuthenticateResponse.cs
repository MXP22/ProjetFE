using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APITheTipTop.Models
{
    public class AuthenticateResponse
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Username { get; set; }
        public string Token { get; set; }
        public AuthenticateResponse(Tuser user, string token)
        {
            Id = user.Iduser;
            FirstName = user.Nom;
            LastName = user.Prenom;
            Username = user.Email;
            Token = token;
        }
    }
}
