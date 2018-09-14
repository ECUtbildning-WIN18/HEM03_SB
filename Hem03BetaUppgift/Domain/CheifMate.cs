using System;
using System.Collections.Generic;
using System.Text;

namespace Hem03BetaUppgift.Domain
{
    class CheifMate : Person
    {
        public CheifMate(string firstName, string lastName, string favoritColor) : base (firstName, lastName, favoritColor)
        {
            Rank = "Cheif Mate";
        }

        public void Turning()
        {
            Console.WriteLine("The ship is turning");
        }
    }
}
