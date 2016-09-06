using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace VeracodeExamples.Models
{
   
    public class UserViewModel
    {
        public string UserId { get; set; }
        public UserModel user { get; set; }
    }
    public class UserModel
    {
        public string UserId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Signature { get; set; }
    }
    
}