using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TesteLogica
{
    public class Rede
    {
        private int[,] lista;
        private int numeroelementos; 

        //Makeset
        public Rede(int n)
        {
            if (n <= 0)
            {
                throw new ArgumentException("A quantidade de elementos deve ser um número inteiro e positivo.");
            }
            numeroelementos = n;
            lista = new int[n, 2];
            for (int i = 0; i < n; i++)
            {
                lista[i, 0] = i;
                lista[i, 1] = 1;
            }
        }

        //Findset
        private int Buscar(int z)
        {
            if (z < 0 || z >= numeroelementos)
            {
                throw new ArgumentException("Elemento fora do limite informado anteriormente.");
            }
            return lista[z, 0];
        }

        //Union
        public void Conectar(int x, int y)
        {
            if (x <= 0 || x >= numeroelementos || y <= 0 || y >= numeroelementos)
            {
                throw new ArgumentException("Elemento fora do limite informado anteriormente.");
            }

            x = Buscar(x);
            y = Buscar(y);
                        
            if (lista[x, 1] < lista[y, 1])
            {
                for (int i = 0; i < numeroelementos; i++)
                {
                   if (lista[i, 0] == x)
                    {
                        lista[i, 0] = y;
                        lista[y, 1] += lista[i, 1];
                        lista[i, 1] = 0;
                    }          
                }
            }
            else
            {
                for (int i = 0; i < numeroelementos; i++)
                {
                    if (lista[i, 0] == y)
                    {
                        lista[i, 0] = x;
                        lista[x, 1] += lista[i, 1];
                        lista[i, 1] = 0;
                    }
                }
            }
        }

        public bool Consultar(int x, int y)
        {
            if (x < 0 || x >= numeroelementos || y < 0 || y >= numeroelementos)
            {
                throw new ArgumentException("Elemento fora do limite informado anteriormente.");
            }
            return Buscar(x) == Buscar(y);
        }
    }
}
