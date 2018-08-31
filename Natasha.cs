using System;

namespace Dreamteam
{
    public class Natasha : ITeammate
    {
        public string Speciality { get; set; } = "JavaScript";
        public string FirstName { get; set; } = "Natasha";
        public string LastName { get; set; } = "Cox";
        
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