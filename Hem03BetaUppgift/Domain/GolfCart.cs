using System;
using System.Collections.Generic;
using System.Text;

namespace Hem03BetaUppgift.Domain
{
    class GolfCart : Vehicle
    {
        public GolfCart(string brand, int registration, bool cupHolder, Engine engine, Commander commander, string color) : base(brand, registration, cupHolder, engine, commander, color)
        {
            
        }
    }
}
