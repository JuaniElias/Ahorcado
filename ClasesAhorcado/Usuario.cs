﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasesAhorcado
{
    public class Usuario
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Password { get; set; }
        List<Juego> JuegoList { get; set; }
        public static int C = 0;
        public DateTime fechaCreacion { get; set; }
        public DateTime fechaEliminacion { get; set; }

        public Usuario()
        {
            Id= genId();
            JuegoList=new List<Juego>();
            fechaCreacion = DateTime.Today;
        }
        
        public Usuario(string n, string p):base()
        {
            Password=p;
            Name=n;
        }
        
        private static int genId()
        {
            C+=1;
            return C;
        }
    }
}