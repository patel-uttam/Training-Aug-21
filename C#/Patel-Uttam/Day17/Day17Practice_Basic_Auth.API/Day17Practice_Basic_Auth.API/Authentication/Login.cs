using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

using Microsoft.EntityFrameworkCore;

namespace Day17Practice_Basic_Auth.API.Authentication
{
    public class Login
    {
        [Required (ErrorMessage = "Email Required")]
        public string UserName { set; get; }

        [Required (ErrorMessage = "Password Required")]
        public string Password { set; get; }

    }
}
