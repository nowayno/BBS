using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BBS.Models.Roles;

namespace BBS.DBContext
{
    public class DBcontext : DbContext
    {
        public DBcontext(DbContextOptions<DBcontext> options) : base(options) { }

        public DbSet<Role> roles { get; set; }
    }
}
