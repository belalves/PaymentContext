using Microsoft.VisualStudio.TestTools.UnitTesting;
using PaymentContext.Domain.Commands;
using System;
using System.Collections.Generic;
using System.Text;

namespace PaymentContext.Tests.Commands
{
    [TestClass]
    public class CreateCredCardSubscriptionCommandTests
    {
        [TestMethod]
        public void ShouldReturnErrorNameIsInvalid()
        {
            var command = new CreateCredCardSubscriptionCommand();
            command.FirstName = "";

            command.Validate();
            Assert.AreEqual(false, command.Valid);
        }

    }
}
