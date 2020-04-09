using Skill_Tracker.BusinessLayer.Interfaces;
using Skill_Tracker.DataLayer.NHibernateConfiguration;
using Skill_Tracker.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Skill_Tracker.BusinessLayer.Services
{
    public class AssociateServices : IAssociateServices
    {
        private readonly IMapperSession _session;

        public AssociateServices(IMapperSession session)
        {
            _session = session;
        }
        public int AddAssociate(Associate associate, AssociateSkills associateSkills)
        {
            Associate Objassociate = new Associate();
            var AssociateId = Objassociate.AssociateId;
            return AssociateId;
        }

        public int AddSkills(Skills skills)
        {
            Skills skill = new Skills();
            var SkillId = skill.SkillId;
            return SkillId;
        }

        public bool DeleteAssociate(int AssociateId)
        {
            return true;
        }

        public Associate EditAssociate(Associate associate)
        {
            Associate ObjAssociate = new Associate();
            return ObjAssociate;
        }

        public Associate GetAssociate(Associate associate)
        {
            Associate ObjAssociate = new Associate();
            return ObjAssociate;
        }

        public Associate SearchAssociate(Associate associate)
        {
            Associate ObjAssociate = new Associate();
            return ObjAssociate;
        }

        public Associate ViewAssociate()
        {
            Associate ObjAssociate = new Associate();
            return ObjAssociate;
        }
    }
}
