﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencia
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Persona > Lider > Developer > Tester
            Persona p1 = new Persona();
            Developer d1 = new Developer();
            Lider l1 = new Lider();
            Tester t1 = new Tester();

            Lider.algo();
        }
    }
}
