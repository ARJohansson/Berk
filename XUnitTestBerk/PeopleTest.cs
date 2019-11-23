using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using Berk.Controllers;
using Berk.Models;
using Berk.Repositories;

namespace BerkxUnit.Tests
{
    public class PeopleTest
    {
        // Tests AddLocation
        [Fact]
        public void AddPersonTest()
        {
            // Arrange 
            var repo = new FakePeopleRepository();
            var person = new VIP()
            {
                Name = "Spitelout Jorgenson",
                Reason = "Spitelout is Snotlout's loud and demanding father. But he was also " +
                "a trusted advisor of Stoick the Vast, making sure to keep Stoick's ego from " +
                "getting as big as his stomach.",
            };

            // Act
            repo.AddPeople(person);

            // Assert
            Assert.Equal("Spitelout Jorgenson",
                repo.VIPs[repo.VIPs.Count - 1].Name);
        }

        // Tests the message repository's GetBySender method
        [Fact]
        public void GetPersonByNameTest()
        {
            // Arrange 
            var repo = new FakePeopleRepository();
            var person = new VIP();

            // Act
            person = repo.GetPersonByName("Astrid Hofferson");

            //Assert
            Assert.Equal(person.Name, repo.VIPs[1].Name);
        }

        // Testst the location repository's Sort
        [Fact]
        public void LocationSortTest()
        {
            // Arrange
            var repo = new FakePeopleRepository();
            var controller = new BerkController(new FakeLocationRepository(), repo);

            // Act
            repo.AddPeopleInfo();
            controller.VIP();

            // Assert
            Assert.Equal("Astrid Hofferson", repo.VIPs[0].Name);
        }
    }
}
