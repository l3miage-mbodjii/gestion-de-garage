﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gestionGarage
{
    internal class Option
    {
        private static int inrement;
        private int id;
        private string nom;
        private decimal prix;


        public Option( string nom, decimal prix)
        {
        
            this.nom = nom;
            this.prix = prix;
        }
        

    }
}