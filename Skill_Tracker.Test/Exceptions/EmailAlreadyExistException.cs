using System;
using System.Collections.Generic;
using System.Text;

namespace Skill_Tracker.Test.Exceptions
{
    public class EmailAlreadyExistException:Exception
    {
        public string Messages = "Email Already Exist  ";

        public EmailAlreadyExistException(string message)
        {
            Messages = message;
        }
    }
}
