using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Web;

namespace GDIInterface.Models.Entities.Response
{
    public class LoginResult
    {
        public bool success;
        public Claim[] claims;

        public LoginResult(bool success, Claim[] claims)
        {
            this.success = success;
            this.claims = claims;
        }
    }
}