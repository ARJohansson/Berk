using System;
using System.Collections.Generic;
using System.Text;
using Berk.Controllers;
using Berk.Models;
using Berk.Repositories;
using Xunit;

namespace BerkxUnit.Tests
{
    public class AdminMessageTest
    {

        // Tests whether an admin message is added when the MessageBoard View is called
        [Fact]
        public void MessageBoardAddMessageTest()
        {
            // Arrange 
            var aRepo = new FakeAdminMessageRepository();
            var messageController = new MessageController(new FakeMessageRepository(), aRepo);

            // Act
            messageController.MessageBoard("Lewis Carroll",
                    "This place is super weird, but I may write a book about it...",
                    new DateTime(2019, 11, 21, 11, 49, 03));

            // Assert
            Assert.Equal("Lewis Carroll",
                aRepo.Messages[aRepo.Messages.Count - 1].MemberName);
        }

        // Tests the admin message repository's GetBySender method
        [Fact]
        public void GetMessageBySenderAdminRepoTest()
        {
            // Arrange 
            var aRepo = new FakeAdminMessageRepository();
            var message = new Message();

            // Act
            message = aRepo.GetMessageBySender("Travis Luthern");

            //Assert
            Assert.Equal("Travis Luthern", message.MemberName);
        }

        // Tests the admin message repository's GetByTime method
        [Fact]
        public void GetMessageByTimeAdminTest()
        {
            // Arrange 
            var aRepo = new FakeAdminMessageRepository();
            var message = new Message();

            // Act
            message = aRepo.GetMessageByTime(new DateTime(2019, 10, 16, 8, 00, 42));

            //Assert
            Assert.Equal("Ulfric Stormheart", message.MemberName);
        }

        // Testst the admin message repository's Sort
        [Fact]
        public void AdminMessageSortTest()
        {
            // Arrange
            var aRepo = new FakeAdminMessageRepository();
            var controller = new MessageController(new FakeMessageRepository(), aRepo);

            // Act
            aRepo.AddTestData();
            controller.ContactPage();

            // Assert
            Assert.Equal(new DateTime(2019, 10, 16, 10, 45, 32), aRepo.Messages[0].Sent);
        }
    }
}
