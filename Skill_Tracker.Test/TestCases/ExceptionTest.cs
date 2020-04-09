using NSubstitute;
using Skill_Tracker.BusinessLayer.Services;
using Skill_Tracker.DataLayer.NHibernateConfiguration;
using Skill_Tracker.Entities;
using Skill_Tracker.Test.Exceptions;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace Skill_Tracker.Test.TestCases
{
    public  class ExceptionTest
    {
        private readonly AssociateServices _AssociateServices;

        private readonly IMapperSession _session = Substitute.For<IMapperSession>();
        public ExceptionTest()
        {
            _AssociateServices = new AssociateServices(_session);

        }
        [Fact]
        public void ExceptionTestFor_EmailAlreadyExist()
        {
            Associate associate = new Associate()
            {
                Email = "example@gmail.com"
            };
            AssociateSkills associateSkills = new AssociateSkills()
            {
                AssociateId = 1,
                Ratting = 4,
                SkillId = 1
            };
            //Assert
            var ex = Assert.Throws<EmailAlreadyExistException>(() => _AssociateServices.AddAssociate(associate, associateSkills));
            Assert.Equal("Email Already Exist ", ex.Messages);
        }

        [Fact]
        public void ExceptionTestFor_SkillNameAlreadyExist()
        {

            Skills skills = new Skills()
            {

                SkillName = "CSS"

            };
            //Assert
            var ex = Assert.Throws<SkillAlreadyExistException>(() => _AssociateServices.AddSkills(skills));
            Assert.Equal("Skill Already Exist ", ex.Messages);
        }
        [Fact]
        public void ExceptionTestFor_AssociateNotFound()
        {
            Associate associate = new Associate()
            {
                AssociateId = 2,
                Name = "dd",
                Email = "example@gmail.com",
                MobileNumber = "64575",
                Pic = "",
                StatusGreen = "",
                StatusBlue = "",
                StatusRed = "",
                Level1 = "",
                Level2 = "",
                Level3 = "",
                Remark = "",
                Strength = "",
                Weekness = ""
            };
            //Assert
            var ex = Assert.Throws<AssociateNotFoundException>(() => _AssociateServices.SearchAssociate(associate));
            Assert.Equal("Associate Not Found ", ex.Messages);
        }
        [Fact]
        public void ExceptionTestFor_AssociateFieldsCannotblank()
        {
            Associate associate = new Associate()
            {
                AssociateId = 2,
                Name = "dd",
                Email = "example@gmail.com",
                MobileNumber = "64575",
                Pic = "",
                StatusGreen = "",
                StatusBlue = "",
                StatusRed = "",
                Level1 = "",
                Level2 = "",
                Level3 = "",
                Remark = "",
                Strength = "",
                Weekness = ""

            };
            AssociateSkills associateSkills = new AssociateSkills()
            {
                AssociateId = 1,
                Ratting = 4,
                SkillId = 1
            };
            //Assert
            var ex = Assert.Throws<FieldscannotEmptyException>(() => _AssociateServices.AddAssociate(associate, associateSkills));
            Assert.Equal("Fields can not be blank ", ex.Messages);
        }
        [Fact]
        public void ExceptionTestFor_SkillsFieldsCannotblank()
        {
            Skills skills = new Skills()
            {
                SkillId = 2,
                SkillName = "CSS"

            };
            //Assert
            var ex = Assert.Throws<FieldscannotEmptyException>(() => _AssociateServices.AddSkills(skills));
            Assert.Equal("Fields can not be blank ", ex.Messages);
        }
    }
}
