using System;
using System.Collections.Generic;
using System.Text;

namespace Skill_Tracker.Test.Exceptions
{
  public  class SkillAlreadyExistException:Exception
    {
        public string Messages = "Skill Already Exist ";

        public SkillAlreadyExistException(string message)
        {
            Messages = message;
        }
    }
}
