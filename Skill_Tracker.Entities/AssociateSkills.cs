using System;
using System.Collections.Generic;
using System.Text;

namespace Skill_Tracker.Entities
{
   public class AssociateSkills
    {
        public virtual int AssociateId { get; set; }
        public virtual int SkillId { get; set; }
        public virtual int Ratting { get; set; }


    }
}
