using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using GDIInterface.Models.Entities.Core;

namespace GDIInterface.Models.Entities.Data
{
    public class LoginModel
    {
        public string username { get; set; }
        public string password { get; set; }

        public LoginModel(Login dto)
        {
            username = dto.username;
            password = dto.password;
        }
    }
}