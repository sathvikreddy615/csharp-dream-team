using System;

namespace Dreamteam
{
    public class Sathvik : ITeammate
    {
        public string Speciality { get; set; } = "ReactJS";
        public string FirstName { get; set; } = "Sathvik";
        public string LastName { get; set; } = "Reddy";
        
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