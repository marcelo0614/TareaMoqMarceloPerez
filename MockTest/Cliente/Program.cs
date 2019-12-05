using Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cliente
{
    class Program
    {
        static void Main(string[] args)
        {
            String state = "";
            Console.WriteLine("********************************");
            IServicio serv = new Servicio();
            Admin admin = new Admin("marcelo", "12345", serv);
            try
            {
                List<Alumno> ListaNota = admin.GetNotas();
                foreach (var item in ListaNota)
                {
                    int nota = item.Nota;

                    if (item.CI == 500)
                        nota = 0;

                    if (nota >= 51)
                        state = "Aprobado";
                    else
                        state = "Reprobado";

                    Console.WriteLine("CI: {0} - Nombre: {1} - Nota: {2} - Estado: {3}", item.CI, item.Nombre, nota, state);
                }
               
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            Console.WriteLine("********************************");
            Console.ReadKey();
        }
    }
}
