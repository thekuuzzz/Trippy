using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;

namespace WebApplication2.Models
{
        public class AppUser : IdentityUser
        {
            public override string Email { get; set; }
            public override string UserName { get; set; }

        }
    }