using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using SocialNetwork.BLL.Models;

namespace SocialNetwork.Tests
{
    [TestFixture]
    public class SocialNetworkTests
    {
        [Test]
        public void UserRegistrationDataPassword_MustThrowException()
        {
            var test1 = new UserRegistrationData();
            Assert.Throws<ArgumentNullException>(() => test1.Password = "12345");
        }
    }
}