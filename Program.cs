using System;
using System.Collections.Generic;

namespace Dreamteam
{
    class Program
    {
        static void Main(string[] args)
        {

            // initiating classes for each teammate

            ITeammate Sathvik = new Sathvik();
            
            ITeammate Seth = new Seth();

            ITeammate Natasha = new Natasha();

            ITeammate Aaron = new Aaron();

            ITeammate Leah = new Leah();

            ITeammate William = new William();

            // creating a list for clientSide

            List<ITeammate> clientSide = new List<ITeammate>();

            clientSide.Add(Sathvik);
            clientSide.Add(Natasha);
            clientSide.Add(Aaron);

            foreach (ITeammate person in clientSide)
            {
                Console.WriteLine(person.Work());                
            }

            // creating a list for serverSide

            List<ITeammate> serverSide = new List<ITeammate>();

            serverSide.Add(Leah);
            serverSide.Add(Seth);
            serverSide.Add(William);

            foreach (ITeammate person in serverSide)
            {
                Console.WriteLine(person.Work());
            }
        }
    }
}
