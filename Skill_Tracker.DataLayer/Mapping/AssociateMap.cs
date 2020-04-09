using FluentNHibernate.Mapping;
using Skill_Tracker.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Skill_Tracker.DataLayer.Mapping
{
    public class AssociateMap : ClassMap<Associate>
    {
        public AssociateMap()
        {
            Id(x => x.AssociateId);

            Map(x => x.Name);

            Map(x => x.Email);
            Map(x => x.MobileNumber);
            Map(x => x.Pic);
            Map(x => x.StatusGreen);
            Map(x => x.StatusRed);
            Map(x => x.StatusBlue);
            Map(x => x.Level1);
            Map(x => x.Level2);
            Map(x => x.Level3);
            Map(x => x.Remark);
            Map(x => x.Strength);
            Map(x => x.Weekness);
            Table("associate");

        }

    }

}
