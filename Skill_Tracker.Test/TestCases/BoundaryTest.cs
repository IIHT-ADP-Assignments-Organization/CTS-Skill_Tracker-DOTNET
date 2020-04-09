using Skill_Tracker.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace Skill_Tracker.Test.TestCases
{
    public class BoundaryTest
    {
        [Fact]
        public void BoundaryTest_ForRating()
        {

            AssociateSkills associateskills = new AssociateSkills()
            {
                Ratting = 15
            };
            var MinValue = 1;
            var MaxValue = 20;

            //Action
            var actualValue = associateskills.Ratting;


            //Assert
            Assert.InRange(actualValue, MinValue, MaxValue);
        }
        [Fact]
        public void BoundaryTest_ForPhoneNo_Length()
        {
            Associate associate = new Associate()
            {
                MobileNumber = "981114564"
            };
            var MinLength = 10;
            var MaxLength = 10;

            //Action
            var actualLength = associate.MobileNumber.ToString().Length;

            //Assert
            Assert.InRange(actualLength, MinLength, MaxLength);
        }
        [Fact]
        public void BoundaryTest_ForRemark_Length()
        {
            Associate associate = new Associate()
            {
                Remark = "good"
            };
            var MinLength = 0;
            var MaxLength = 100;

            //Action
            var actualLength = associate.Remark.Length;

            //Assert
            Assert.InRange(actualLength, MinLength, MaxLength);
        }
        [Fact]
        public void BoundaryTest_ForStrength_Length()
        {
            Associate associate = new Associate()
            {
                Strength = ""
            };
            var MinLength = 0;
            var MaxLength = 100;

            //Action
            var actualLength = associate.Strength.Length;

            //Assert
            Assert.InRange(actualLength, MinLength, MaxLength);
        }
    }
}
