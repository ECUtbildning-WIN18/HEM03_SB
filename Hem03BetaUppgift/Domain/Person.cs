using System;
using System.Collections.Generic;
using System.Text;

namespace Hem03BetaUppgift.Domain
{
    class Person 
    {
        public string FirstName { get; private set; }
        public string LastName { get; private set; }
        public string FavoritColor { get; }
        public string Rank { get; private set; }

        public Person(string firstName, string lastName, string favoritColor, string rank)
        {
            FirstName = firstName;
            LastName = lastName;
            FavoritColor = favoritColor;
            Rank = rank;
        }

        public void ChangeFirstName(string firstName)
        {
            FirstName = firstName;
        }

        public void ChangeLastName(string lastName)
        {
            LastName = lastName;
        }
    }
}
