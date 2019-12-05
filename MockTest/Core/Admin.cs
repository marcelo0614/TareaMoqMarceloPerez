﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core
{
    public class Admin
    {
        List<Alumno> ListaAlumnos;
        string token;
        IServicio serv;
        public Admin(string user, string password, IServicio serv)
        {
            if (user == "marcelo" && password == "12345")
            {
                token = "Token Valido";
            }
            serv.Validar(token);
            this.serv = serv;
        }

        public List<Alumno> GetNotas()
        {
            
            ListaAlumnos = serv.GetAlumnos();
            foreach (var alumno in ListaAlumnos)
            {
                alumno.Nota = serv.GetNota(alumno.CI);
            }
            return ListaAlumnos;
        }

        
    }
}
