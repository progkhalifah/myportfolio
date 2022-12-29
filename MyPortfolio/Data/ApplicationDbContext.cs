using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using MyPortfolio.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyPortfolio.Data
{
    public class ApplicationDbContext : IdentityDbContext<RegistrationUsers>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
    }
}
