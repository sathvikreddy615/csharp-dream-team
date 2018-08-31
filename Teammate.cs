using System;
using System.Collections.Generic;

namespace Dreamteam
{
    public interface ITeammate
    {
        string Speciality { get; set; }
        string FirstName { get; set; }
        string LastName { get; set; }

        string Name(string FirstName, string LastName);

        string Work();
    }
}