using System;
using System.Collections.Generic;
using System.Text;

namespace Skill_Tracker.Entities
{
   public class Associate
   {
        public virtual int AssociateId { get; set; }
        public virtual string Name { get; set; }
        public virtual string Email { get; set; }
        public virtual string MobileNumber { get; set; }
        public virtual string Pic { get; set; }
        public virtual string StatusGreen { get; set; }
        public virtual string StatusRed { get; set; }
        public virtual string StatusBlue { get; set; }
        public virtual string Level1 { get; set; }
        public virtual string Level2 { get; set; }
        public virtual string Level3 { get; set; }
        public virtual string Remark { get; set; }
        public virtual string Strength { get; set; }
        public virtual string Weekness { get; set; }

   }
}
