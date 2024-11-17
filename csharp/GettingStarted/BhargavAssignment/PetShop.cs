using System;
using System.Collections.Generic;

namespace RajProject
{
    // Represents a Course for Training
    public class Training
    {
        public string TrainingName { get; set; }
        public string Trainer { get; set; }
        public int Duration { get; set; }
        public DateTime FromDate { get; set; }
        public DateTime EndDate { get; set; }
        public int Participants { get; set; }
        public List<string> Topics { get; set; }
        public List<string> ToolsUsed { get; set; }
        public List<string> ParticipantsList { get; set; }

        public Training(string trainingName, string trainer, int duration, DateTime fromDate, DateTime endDate, int participants, List<string> topics, List<string> toolsUsed, List<string> participantsList)
        {
            TrainingName = trainingName;
            Trainer = trainer;
            Duration = duration;
            FromDate = fromDate;
            EndDate = endDate;
            Participants = participants;
            Topics = topics;
            ToolsUsed = toolsUsed;
            ParticipantsList = participantsList;
        }

        public void DisplayTrainingDetails()
        {
            Console.WriteLine($"Training Name: {TrainingName}");
            Console.WriteLine($"Trainer: {Trainer}");
            Console.WriteLine($"Duration: {Duration} Days");
            Console.WriteLine($"From Date: {FromDate:dd - MMMM}");
            Console.WriteLine($"End Date: {EndDate:dd - MMMM}");
            Console.WriteLine($"Participants: {Participants}");
            Console.WriteLine($"Topics: {string.Join(", ", Topics)}");
            Console.WriteLine($"Tools Used: {string.Join(", ", ToolsUsed)}");
            Console.WriteLine($"Participants List: {string.Join(", ", ParticipantsList)}");
        }
    }

    // Represents the Category of the Pet
    public class Category
    {
        public string Name { get; set; }

        public Category(string name)
        {
            Name = name;
        }
    }

    // Represents an Entity in the Pet Store
    public class Pet
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Category Category { get; set; }
        public double Price { get; set; }

        public Pet(int id, string name, Category category, double price)
        {
            Id = id;
            Name = name;
            Category = category;
            Price = price;
        }

        public void DisplayPetDetails()
        {
            Console.WriteLine($"Pet ID: {Id}");
            Console.WriteLine($"Pet Name: {Name}");
            Console.WriteLine($"Category: {Category.Name}");
            Console.WriteLine($"Price: {Price:C}");
        }
    }

    // Represents a Store for Pets
    public class PetShop
    {
        static void Main(string[] args)
        {
            // Sample Training Data
            var training = new Training(
                "C# Basics / Web Development / Cloud",
                "Suresh Nanjan",
                16,
                new DateTime(2024, 2, 15),
                new DateTime(2024, 3, 9),
                30,
                new List<string> { "C#", "Docker", "Jenkins", "WebDriver" },
                new List<string> { "MS Teams", "Google Classroom" },
                new List<string> { "John", "Jane", "David" }
            );

            training.DisplayTrainingDetails();

            // Sample Pet Data from PetStore
            Console.WriteLine("\nPet Details:");
            var dogCategory = new Category("Dog");
            var catCategory = new Category("Cat");

            var pet1 = new Pet(1, "Buddy", dogCategory, 50.00);
            var pet2 = new Pet(2, "Mittens", catCategory, 30.00);

            pet1.DisplayPetDetails();
            pet2.DisplayPetDetails();
        }
    }
}
