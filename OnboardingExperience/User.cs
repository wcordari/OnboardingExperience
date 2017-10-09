using System;
using System.Collections.Generic;
using System.Text;

namespace OnboardingExperience
{
    public class User
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public bool IsAccountOwner { get; set; }
        public string PinNumber { get; set; }

        public string FullName;
    }
}
