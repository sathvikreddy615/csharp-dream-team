using System;

namespace Dreamteam
{
    public class Leah : ITeammate
    {
        public string Speciality { get; set; } = "C#";
        public string FirstName { get; set; } = "Leah";
        public string LastName { get; set; } = "Gwin";
        
        public string Name(string firstName, string lastName) {
            this.FirstName = firstName;
            this.LastName = lastName;
            return $"{firstName} {lastName}";
        }

        public string Work() {
            return $"I love {this.Speciality}";
        }
    }
}