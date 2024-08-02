using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TesteLogica
{
    public class Program
    {
        public static void Main()
        {
            try
            {

                Rede rede = new Rede(9);
                rede.Conectar(1, 2);
                rede.Conectar(6, 2);
                rede.Conectar(2, 4);
                rede.Conectar(5, 8);

                Console.WriteLine(rede.Consultar(1, 6));  // Deve retornar True
                Console.WriteLine(rede.Consultar(5, 8));  // Deve retornar True
                Console.WriteLine(rede.Consultar(5, 3));  // Deve retornar False
                Console.WriteLine(rede.Consultar(1, 8));  // Deve retornar False
                Console.ReadKey();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }
    }
}
