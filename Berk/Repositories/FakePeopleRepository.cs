using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Berk.Models;

namespace Berk.Repositories
{
    public class FakePeopleRepository : IPeopleRepository
    {
        private static List<VIP> people = new List<VIP>();

        public List<VIP> VIPs { get { return people; } }

        public FakePeopleRepository()
        {
            AddPeopleInfo();
        }

        public void AddPeople(VIP vip)
        {
            people.Add(vip);
        }

        public VIP GetPersonByName(string name)
        {
            VIP vip = people.Find(p => p.Name == name);
            return vip;
        }

        public void AddPeopleInfo()
        {
            VIP person = new VIP()
            {
                Name = "Hiccup Horrendous Haddock III",
                Reason = "Legendary Dragon Conquerer and Berk's current chief. He defeated the Red Death, Alvin the Treacherous, " +
                        "devestated the dragon trappers, and ultimately saved all of dragon-kind. The hero of Berk: Hiccup took " +
                        "over as chief after his father's death in a fateful battle with Drago Bludvist, and has surpassed all " +
                        "expectations. Toothless is Hiccup's dragon, a Night Fury and the last of his kind. The two are inseparable.",
                Link = "https://howtotrainyourdragon.fandom.com/wiki/Hiccup_Horrendous_Haddock_III_(Franchise)",
                IsAlive = true
            };
            people.Add(person);

            person = new VIP()
            {
                Name = "Astrid Hofferson",
                Reason = "Easily the best warrior of her age, Astrid Hofferson proved herself to be just as talented as Hiccup in the " +
                        "dragon ring. She was the first to discover Hiccup's secret and the second Berkian to ride a dragon. Her feisty " +
                        "spirit and steadfastness balance Hiccup's brains and wild ideas. She keeps him grounded and stops his head from " +
                        "growing too big. Astrid's dragon is called Stormfly and she's one of the fastest dragons, especially if she eats chicken.",
                Link = "https://howtotrainyourdragon.fandom.com/wiki/Astrid_Hofferson",
                IsAlive = true
            };
            people.Add(person);

            person = new VIP()
            {
                Name = "Stoick the Vast",
                Reason = "Father of Hiccup, he was Berk's chief for at least 30 years. He led the Berkians to the shores of Dragon Island " +
                        "in an attempt to defeat the Red Death. He died five years later with honor and received a proper viking funeral " +
                        "from his lost wife, beloved son, and close friends. He always had faith in Hiccup, even when others did not. He will " +
                        "be remembered as one of Berk's strongest chieftans. Stoick was one of the last Berkian's to acquire a dragon, wanting " +
                        "to do things the 'Viking' way, until he encountered Skull Crusher, a dragon whose stubborness revealed that the dragon " +
                        "way could still be the Viking way.",
                Link = "https://howtotrainyourdragon.fandom.com/wiki/Stoick_the_Vast_(Franchise)",
                IsAlive = false
            };
            people.Add(person);

            person = new VIP()
            {
                Name = "Valka Haddock",
                Reason = "Wife of Stoick and mother of Hiccup, Valka is a strong viking and friend to dragons. When Hiccup was just a babe " +
                        "she was taken by a dragon and wasn't to be seen for 20 years. 20 years later she was reunited with her son and " +
                        "husband, only to lose Stoick after a single night. She returned with Hiccup to Berk to help groom him to be the " +
                        "next chief. Cloudjumper was the Stormcutter dragon that kidnapped Valka all those years ago, the two formed a deep bond" +
                        " because Valka knew that dragons were no different from vikings and Cloudjumper had never intended to harm her.",
                Link = "https://howtotrainyourdragon.fandom.com/wiki/Valka",
                IsAlive = true
            };
            people.Add(person);

            person = new VIP()
            {
                Name = "Gobber the Belch",
                Reason = "Gobber is Berk's resident blacksmith and dragon dentis. His job was originally to design weapons to kill dragons " +
                        "but after the Berkians accepted the dragons, he had to find something else to do. He does still make weapons, but more" +
                        " often than not, he can be found making a dragon saddle or fixing a dragon's teeth. He was Stoick's closest friend and " +
                        "advisor and Hiccup's trainer. He's missing a hand and a leg from a dragon attack, but he accepted dragons more readily " +
                        "than others. His own dragon, Grump, helps him tend to the forge.",
                Link = "https://howtotrainyourdragon.fandom.com/wiki/Gobber_the_Belch_(Franchise)",
                IsAlive = true
            };
            people.Add(person);

            person = new VIP()
            {
                Name = "Snotlout Jorgenson",
                Reason = "Snotlout was the third viking to bond with a dragon and part of the original team of teens to race off to Dragon Island " +
                        "to save their parents. His stubborness and typical Viking demeanor lead him to butt heads with Hiccup at every turn. " +
                        "He claims to be the true leader of the Dragon Riders, but when it comes down to it he trusts Hiccup and is loyal to the" +
                        " team. Hookfang is his Monstrous Nightmare, and his personality matches almost perfectly with Snotlout's, making them a " +
                        "formidable team, though Hookfang also enjoys throwing Snotlout around.",
                Link = "https://howtotrainyourdragon.fandom.com/wiki/Snotlout_Jorgenson",
                IsAlive = true
            };
            people.Add(person);

            person = new VIP()
            {
                Name = "Fishlegs Ingerman",
                Reason = "Timid and stout, Fishlegs looks like a classic Viking, but he is terrified of almost everything. Despite this he " +
                        "was among the original Dragon Riders and fought bravely among them. His almost perfect knowledge of all of the dragon " +
                        "species has saved the team countless times. Fishlegs is Hiccup's best friend and one of his closest advisors. His dragon " +
                        "Meatlug is a Gronckle and not the fastest or smartest dragon, but she is one of the toughest and most loyal.",
                Link = "https://howtotrainyourdragon.fandom.com/wiki/Fishlegs_Ingerman",
                IsAlive = true
            };
            people.Add(person);

            person = new VIP()
            {
                Name = "Ruffnut Eugene Thorston",
                Reason = "Twin of Tuffnut Thorston, from a long line of Thorston's, she was one of the original members of the Dragon Riders. She shares " +
                         "just about everything with her brother, including their two-headed Zippleback, Barf(her dragon) and Belch. She is not the " +
                         "brightest member of the group, but she has her moments. While a bit crazy, and not wonderful at following orders, you don't " +
                         "want to have her as your enemy. ",
                Link = "https://howtotrainyourdragon.fandom.com/wiki/Ruffnut_Thorston",
                IsAlive = true
            };
            people.Add(person);

            person = new VIP()
            {
                Name = "Tuffnut LaVerne Thorston",
                Reason = "Twin of Ruffnut Thorston, from a long line of Thorston's, he was one of the original members of the Dragon Riders. He shares " +
                         "just about everything with his sister, including their two-headed Zippleback, Barf and Belch (His dragon). He and his sister" +
                         " follow the will of Loki and go about the village pranking everyone, not really caring if the pranks are dangerous. He claims " +
                         "to hate his sister but really the two of them are inseparable and are willing to kill for each other.",
                Link = "https://howtotrainyourdragon.fandom.com/wiki/Tuffnut_Thorston",
                IsAlive = true
            };
            people.Add(person);
        }
    }
}
