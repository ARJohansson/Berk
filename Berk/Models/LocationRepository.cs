using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Berk.Models
{
    public class LocationRepository
    {
        private static List<Location> locations = new List<Location>();

        public static List<Location> Locations { get { return locations; } }

        static LocationRepository()
        {
            AddLocationData();
        }

        public static void AddLocation(Location place)
        {
            locations.Add(place);
        }

        public static Location GetLocationByName(String name)
        {
            Location location = locations.Find(l => l.Name == name);
            return location;
        }

        static void AddLocationData()
        {
            Location place = new Location()
            {
                Name = "Berk's Dragon Training Academy",
                Description = "While the Dragon Academy started as a place for vikings to learn how to kill dragons, it has since " +
                               "become a place of learning, and training. Each new Dragon Rider comes here to learn how to bond with their " +
                               "dragon and become a better team.",
                Link = "https://howtotrainyourdragon.fandom.com/wiki/Berk_Dragon_Training_Academy"
            };
            locations.Add(place);

            place = new Location()
            {
                Name = "Isle of Berk",
                Description = "Generations of vikings have lived and died on these shores in order to make it a proper home. Once man and " +
                               "dragon were vicious enemies, but now they live together in peace. Each making the world a better place for " +
                               "the other. There are beautiful shores, deep caverns, and incredible flora(not to mention the fauna.)",
                Link = "https://howtotrainyourdragon.fandom.com/wiki/Isle_of_Berk_(Franchise)"
            };
            locations.Add(place);

            place = new Location()
            {
                Name = "Dragon Island",
                Description = "Ever since vikings first settled on Berk they've been searching for the Dragons' Nest: Dragon Island. With " +
                              "the help of Toothless Stoic the Vast was finally able to discover it and put an end to the Red Death's reign. " +
                              "These days the shores are a lot more pleasant, though you'll want to watch out for some of the more wild dragons.",
                Link = "https://howtotrainyourdragon.fandom.com/wiki/Dragon_Island"
            };
            locations.Add(place);

            place = new Location()
            {
                Name = "Berk Forest",
                Description = "If you're looking for beautiful landscapes with a hint of adventure then dive into Berk's forests. Filled with all " +
                              "manner of wild animal it's a perfect destination for a hardy viking! It's also a great place to clear your head " +
                              "away from society. It's said that the great Dragon Conquerer Hiccup Horrendous Haddock III trained the mighty " +
                              "Night Fury(more commonly referred to as 'Toothless') in these trees.",
                Link = "https://howtotrainyourdragon.fandom.com/wiki/Berk_Forest"
            };
            locations.Add(place);

            place = new Location()
            {
                Name = "The Great Hall",
                Description = "Berk's Great Hall can hold every member of Berk inside it's sturdy walls. Or it used to, until the dragons " +
                              "became Berkians, now there's barely room to eat. But if you visit outside of mealtimes you can see the history" +
                              "of the building. All of Berk's chieftans have their shield portraits hanging along the wall. And if that's not " +
                              "tempting enough, during mealtimes you get to eat with your favorite dragon. (Whether you like it or not!)",
                Link = "https://howtotrainyourdragon.fandom.com/wiki/Great_Hall"
            };
            locations.Add(place);
        } 
    }
}
