using System;
using Xunit;
using Berk.Repositories;
using Berk.Controllers;
using Berk.Models;


namespace XUnitTestBerk
{
    public class MessageTest
    {
        // Tests whether a message is added when the ContactPage View is called
        [Fact]
        public void ContactPageAddMessageTest()
        {
            // Arrange 
            var mRepo = new FakeMessageRepository();
            var messageController = new MessageController(mRepo, new FakeAdminMessageRepository());

            // Act
            messageController.ContactPage("Lewis Carroll",
                    "This place is super weird, but I may write a book about it...",
                    new DateTime(2019, 11, 21, 11, 49, 03));

            // Assert
            Assert.Equal("Lewis Carroll",
                mRepo.Messages[mRepo.Messages.Count - 1].MemberName);
        }

        // Tests the message repository's GetBySender method
        [Fact]
        public void GetMessageBySenderMemberRepoTest()
        {
            // Arrange 
            var mRepo = new FakeMessageRepository();
            var message = new Message();

            // Act
            message = mRepo.GetMessageBySender("Lisa Beau");

            //Assert
            Assert.Equal("Lisa Beau", message.MemberName);
        }

        // Tets the message repository's GetMessageByTime method
        [Fact]
        public void GetMessageByTimeMemberTest()
        {
            // Arrange 
            var mRepo = new FakeMessageRepository();
            var message = new Message();

            // Act
            message = mRepo.GetMessageByTime(new DateTime(2019, 10, 16, 11, 00, 12));

            //Assert
            Assert.Equal("Travis Luthern", message.MemberName);
        }

        // Testst the message repository's Sort
        [Fact]
        public void MessageSortTest()
        {
            // Arrange
            var mRepo = new FakeMessageRepository();
            var controller = new MessageController(mRepo, new AdminMessageRepository());

            // Act
            mRepo.AddTestData();
            controller.ContactPage();

            // Assert
            Assert.Equal(new DateTime(2019, 10, 16, 11, 00, 12), mRepo.Messages[1].Sent);
        }
    }
}
