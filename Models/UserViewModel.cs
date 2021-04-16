using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HttpContextRequest.Models
{
    public class UserViewModel
    {
        public List<User> Users { get; set; }
        public Dictionary<string, string> Requests { get; set; }
    }
}