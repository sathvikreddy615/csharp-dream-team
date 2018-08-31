using System;

namespace Dreamteam
{
    public class Aaron : ITeammate
    {
        public string Speciality { get; set; } = "CSS3";
        public string FirstName { get; set; } = "Aaron";
        public string LastName { get; set; } = "Miller";
        
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