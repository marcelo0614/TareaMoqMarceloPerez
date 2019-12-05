using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core
{
    public class Servicio : IServicio
    {
        Random rnd = new Random();
        public List<Alumno> GetAlumnos()
        {
            //throw new NotImplementedException();
            List<Alumno> result = new List<Alumno>();
            result.Add(new Alumno() { CI = GetCI(), Nombre = "Maria Lopez" });
            result.Add(new Alumno() { CI = GetCI(), Nombre = "Juan Rivera" });
            result.Add(new Alumno() { CI = GetCI(), Nombre = "Antonio Quezada" });
            result.Add(new Alumno() { CI = GetCI(), Nombre = "Juan Torrez" });
            result.Add(new Alumno() { CI = GetCI(), Nombre = "Lucia Antezana" });
            return result;
        }

        public int GetCI()
        {
            int ci = rnd.Next(498, 501);
            return ci;

        }

        public int GetNota(int CI)
        {
            //throw new NotImplementedException();
            int nota = rnd.Next(1, 100);
            return nota;

        }

        public void Validar(string token)
        {
            //throw new NotImplementedException();
            if (String.IsNullOrEmpty(token))
            throw new Exception("token invalido");
        }
    }
}
