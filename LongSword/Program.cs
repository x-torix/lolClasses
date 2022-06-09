// See https://aka.ms/new-console-template for more information
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LolClasses
{
    public class Kindlegen : Item
    {
        public Kindlegen()
        {
            name = "Kindlegen";

            price = 350;

            AddStat(Stat.AD, 10);
        }

    }
}

