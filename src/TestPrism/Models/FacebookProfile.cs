using System;
namespace TestPrism.Models
{
    public class FacebookProfile
    {
        public FacebookProfile()
        {
        }

        public Guid UserId { get; set; }

        public string Email { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }
    }
}
