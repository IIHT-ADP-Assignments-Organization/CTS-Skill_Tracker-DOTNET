using NSubstitute;
using Skill_Tracker.BusinessLayer.Services;
using Skill_Tracker.DataLayer.NHibernateConfiguration;
using Skill_Tracker.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace Skill_Tracker.Test.TestCases
{
    public class FunctionalTest
    {
        private readonly AssociateServices _AssociateServices;
       
        private readonly IMapperSession _session = Substitute.For<IMapperSession>();
        public FunctionalTest()
        {
            _AssociateServices = new AssociateServices(_session);
           
        }

        [Fact]
        public void Test_for_SearchAssociate()
        {
            Associate associate = new Associate()
            {
                  AssociateId=1,
                  Level1="a",
                  Level2="aa",
                  Level3="aa",
                  Email="A@gmail.com",
                  StatusBlue="s",
                  StatusGreen="s",
                  StatusRed="s",
                  Strength="ss",
                  MobileNumber="111111111",
                  Name="ss",
                  Pic="aa",
                  Remark="ss",
                  Weekness="xx"
                  
            };

            var Result = _AssociateServices.SearchAssociate(associate);
            var GetAssociate = _AssociateServices.GetAssociate(associate);

            Assert.Equal(GetAssociate, Result);
        }

        [Fact]
        public void Test_for_AddAssociate()
        {
            Associate associate = new Associate()
            {
                AssociateId = 1,
                Level1 = "a",
                Level2 = "aa",
                Level3 = "aa",
                Email = "A@gmail.com",
                StatusBlue = "s",
                StatusGreen = "s",
                StatusRed = "s",
                Strength = "ss",
                MobileNumber = "111111111",
                Name = "ss",
                Pic = "aa",
                Remark = "ss",
                Weekness = "xx"

            };

            AssociateSkills associateSkills = new AssociateSkills()
            {
                AssociateId = 1,
                Ratting=4,
                SkillId=1
            };
            var Result = _AssociateServices.AddAssociate(associate, associateSkills);
            var GetAssociate = Result.ToString();

            Assert.NotNull(GetAssociate);
        }


        [Fact]
        public void Test_for_EditAssociate()
        {
            Associate associate = new Associate()
            {
                AssociateId = 1,
                Level1 = "a",
                Level2 = "aa",
                Level3 = "aa",
                Email = "A@gmail.com",
                StatusBlue = "s",
                StatusGreen = "s",
                StatusRed = "s",
                Strength = "ss",
                MobileNumber = "111111111",
                Name = "ss",
                Pic = "aa",
                Remark = "ss",
                Weekness = "xx"

            };

            AssociateSkills associateSkills = new AssociateSkills()
            {
                AssociateId = 1,
                Ratting = 4,
                SkillId = 1
            };
            var Result = _AssociateServices.EditAssociate(associate);
            var GetAssociate = _AssociateServices.GetAssociate(associate);

            Assert.Equal(GetAssociate, Result);
        }

        [Fact]
        public void Test_for_DeleteAssociate()
        {
            Associate associate = new Associate()
            {
                AssociateId = 1,
                

            };

          
            var Result = _AssociateServices.DeleteAssociate(associate.AssociateId);
           
            Assert.True( Result);
        }

        [Fact]
        public void Test_for_AddSkills()
        {
            Skills skills = new Skills()
            {
                SkillId = 1,
                SkillName = "ss"
            };

           
            var Result = _AssociateServices.AddSkills(skills);
            var GetSkills = Result.ToString();

            Assert.NotNull(GetSkills);
        }
    }
}
