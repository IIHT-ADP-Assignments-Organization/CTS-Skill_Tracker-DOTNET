using Skill_Tracker.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Skill_Tracker.BusinessLayer.Interfaces
{
    public interface IAssociateServices
    {
        Associate SearchAssociate(Associate associate);
        int AddAssociate(Associate associate, AssociateSkills associateSkills);
        Associate GetAssociate(Associate associate);
        Associate EditAssociate(Associate associate);
        bool DeleteAssociate(int AssociateId);
        Associate ViewAssociate();
        int AddSkills(Skills skills);
    }
}
