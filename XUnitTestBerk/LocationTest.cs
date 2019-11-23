using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using Berk.Repositories;
using Berk.Controllers;
using Berk.Models;

namespace BerkxUnit.Tests
{
    public class LocationTest
    {
        // Tests AddLocation
        [Fact]
        public void AddLocation()
        {
            // Arrange 
            var repo = new FakeLocationRepository();
            var place = new Location()
            {
                Name = "Chief's House",
                Description = "Hiccup Horrendous Haddock III's house is a marvel. It's withstood a " +
                "multitude of dragon and viking attacks, and looms over all other houses.",
            };

            // Act
            repo.AddLocation(place);

            // Assert
            Assert.Equal("Chief's House",
                repo.Locations[repo.Locations.Count - 1].Name);
        }

        // Tests the message repository's GetBySender method
        [Fact]
        public void GetLocationByNameTest()
        {
            // Arrange 
            var repo = new FakeLocationRepository();
            var location = new Location();

            // Act
            location = repo.GetLocationByName("Isle of Berk");

            //Assert
            Assert.Equal(location.Name, repo.Locations[1].Name);
        }

        // Testst the location repository's Sort
        [Fact]
        public void LocationSortTest()
        {
            // Arrange
            var repo = new FakeLocationRepository();
            var controller = new BerkController(repo, new FakePeopleRepository());

            // Act
            repo.AddLocationData();
            controller.Locations();

            // Assert
            Assert.Equal("Berk Forest", repo.Locations[0].Name);
        }
    }
}
