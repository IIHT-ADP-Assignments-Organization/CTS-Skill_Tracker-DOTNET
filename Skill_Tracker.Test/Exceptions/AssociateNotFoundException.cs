using System;
using System.Collections.Generic;
using System.Text;

namespace Skill_Tracker.Test.Exceptions
{
    public class AssociateNotFoundException:Exception
    {
        public string Messages = "Associate Not Found";

        public AssociateNotFoundException(string message)
        {
            Messages = message;
        }
    }
}
