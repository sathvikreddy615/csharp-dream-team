using System;

namespace Dreamteam
{
    public class Seth : ITeammate
    {
        public string Speciality { get; set; } = ".NET";
        public string FirstName { get; set; } = "Seth";
        public string LastName { get; set; } = "Dana";
        
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