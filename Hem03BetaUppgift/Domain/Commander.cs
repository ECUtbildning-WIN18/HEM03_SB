using System;
using System.Collections.Generic;
using System.Text;

namespace Hem03BetaUppgift.Domain
{
    class Commander:Person
    {
        public Commander(string firstName, string lastName, string favoritColor, string rank) : base (firstName, lastName, favoritColor, rank)
        {
            
        }

        public void Drinking()
        {
            Console.WriteLine("A wiskey by day makes the body happy");
        }
    }
}
