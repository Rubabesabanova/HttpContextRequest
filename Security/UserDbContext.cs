using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using HttpContextRequest.Models;

namespace HttpContextRequest.Security
{
    public class UserDbContext : DbContext
    {
        public UserDbContext() : base("request") { }
        public DbSet<User> Users { get; set; }
    }
}