using System;

namespace Dreamteam
{
    public class William : ITeammate
    {
        public string Speciality { get; set; } = "SQL";
        public string FirstName { get; set; } = "William";
        public string LastName { get; set; } = "Kimball";
        
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