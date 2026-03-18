using System;
using System.Collections.Generic;
using System.Text;

namespace Blackjack_Dealer_Training.GameLogic
{
    public class Player
    {
        public static Random rng = new Random();

        public string name { get; private set; }

        public Hand hand;

        int money;

        int currentBet;

        public Player() { 
            hand = new Hand();
            name = GenerateName();
            money = rng.Next(100, 10000);
        }

        public Player(Hand hand)
        {
            this.hand = hand;
            name = GenerateName();
            money = rng.Next(100, 10000);
        }

        public void hit()
        {
            hand.hit();
        }

        public void stand()
        {
            hand.stand();
        }

        public void reset()
        {
            currentBet = 0;
        }

        public void placeRandomBet()
        {
            int betAmount = rng.Next(1, money);
            placeBet(betAmount);
        }

        public void placeBet(int amount)
        {
            if (amount > money)
            {
                throw new Exception("Not enough money to place bet");
            }
            money -= amount;
            currentBet += amount;
        }

        public static string GenerateFirstName()
        {
            string[] firstNames = { "John", "Emma", "Michael", "Olivia", "William", "Ava", "James", "Sophia", "Benjamin", "Isabella",
  "Charlotte", "Elijah", "Mia", "Lucas", "Amelia", "Mason", "Harper", "Ethan", "Evelyn", "Alexander",
  "Abigail", "Henry", "Emily", "Sebastian", "Elizabeth", "Jack", "Mila", "Daniel", "Ella", "Owen",
  "Scarlett", "Samuel", "Grace", "Matthew", "Chloe", "Joseph", "Victoria", "Liam", "Riley", "David",
  "Aria", "Carter", "Zoey", "Wyatt", "Nora", "Julian", "Lily", "Luke", "Eleanor", "Grayson",
  "Hannah", "Isaac", "Lillian", "Lincoln", "Addison", "Anthony", "Aubrey", "Christopher", "Ellie", "Andrew",
  "Stella", "Theodore", "Natalie", "Caleb", "Zoe", "Ryan", "Leah", "Nathan", "Hazel", "Adrian",
  "Violet", "Christian", "Aurora", "Josiah", "Savannah", "Hunter", "Audrey", "Connor", "Brooklyn", "Eli",
  "Bella", "Jonathan", "Claire", "Nolan", "Skylar", "Easton", "Lucy", "Colton", "Paisley", "Carson",
  "Everly", "Cameron", "Anna", "Levi", "Caroline", "Isaiah", "Genesis", "Jordan", "Aaliyah", "Robert",
  "Elena", "Aaron", "Sophie", "Charles", "Naomi", "Thomas", "Alice", "Nicholas", "Maya", "Jeremiah",
  "Willow", "Hudson", "Alexa", "Leo", "Ariana", "Landon", "Quinn", "Dylan", "Eva", "Xavier",
  "Piper", "Joshua", "Ruby", "Ezra", "Serenity", "Jaxon", "Penelope", "Brayden", "Peyton", "Gavin" };
            int index = rng.Next(firstNames.Length);
            return firstNames[index];
        }

        public static string GenerateLastName()
        {
            string[] lastNames = { "Smith", "Johnson", "Williams", "Jones", "Brown", "Davis", "Miller", "Wilson", "Moore", "Taylor",
  "Anderson", "Thomas", "Jackson", "White", "Harris", "Martin", "Thompson", "Garcia", "Martinez", "Robinson",
  "Clark", "Rodriguez", "Lewis", "Lee", "Walker", "Hall", "Allen", "Young", "Hernandez", "King",
  "Wright", "Lopez", "Hill", "Scott", "Green", "Adams", "Baker", "Gonzalez", "Nelson", "Carter",
  "Mitchell", "Perez", "Roberts", "Turner", "Phillips", "Campbell", "Parker", "Evans", "Edwards", "Collins",
  "Stewart", "Sanchez", "Morris", "Rogers", "Reed", "Cook", "Morgan", "Bell", "Murphy", "Bailey",
  "Rivera", "Cooper", "Richardson", "Cox", "Howard", "Ward", "Torres", "Peterson", "Gray", "Ramirez",
  "James", "Watson", "Brooks", "Kelly", "Sanders", "Price", "Bennett", "Wood", "Barnes", "Ross",
  "Henderson", "Coleman", "Jenkins", "Perry", "Powell", "Long", "Patterson", "Hughes", "Flores", "Washington",
  "Butler", "Simmons", "Foster", "Gonzales", "Bryant", "Alexander", "Russell", "Griffin", "Diaz", "Hayes",
  "Myers", "Ford", "Hamilton", "Graham", "Sullivan", "Wallace", "Woods", "Cole", "West", "Jordan",
  "Owens", "Reynolds", "Fisher", "Ellis", "Harrison", "Gibson", "Mcdonald", "Cruz", "Marshall", "Ortiz",
  "Gomez", "Murray", "Freeman", "Wells", "Webb", "Simpson", "Stevens", "Tucker", "Porter", "Hunter",
  "Hicks", "Crawford", "Henry", "Boyd", "Mason", "Morales", "Kennedy", "Warren", "Dixon", "Ramos" };
            int index = rng.Next(lastNames.Length);
            return lastNames[index];
        }

        public static string GenerateName()
        {
            string firstName = GenerateFirstName();
            string lastName = GenerateLastName();
            return $"{firstName} {lastName}";
        }


    }
}
