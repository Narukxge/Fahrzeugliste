using FahrzeugListe.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FahrzeugListe.Data
{
    public class DbInitiazlier
    {
        public static void Initialize(AutoContext context)
        {
            context.Database.EnsureCreated();

            if (context.Autos.Any())
            {
                return;
            } // Ist dafür da das wenn man es nochmal startet das es nicht nochmal in die Liste reinkommt 

            var autos = new Auto[]
            {
                new Auto{Fahrzeug="Audi",Kennzeichen="BVG2012",Standort="Berlin"},
                new Auto{Fahrzeug="BMW",Kennzeichen="DS3212",Standort="Berlin"},
                new Auto{Fahrzeug="Volvo",Kennzeichen="KID420",Standort="Berlin"}
            };
            foreach(Auto a in autos)
            {
                context.Autos.Add(a);
            }
            context.SaveChanges();
        }
    }
}
