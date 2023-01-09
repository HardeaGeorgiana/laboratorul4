using System;

namespace laboratorul4
{
    class Program
    {
        static void Main(string[] args)
        {
            //Ex1();
            //Ex2();
            //Ex3();
            //Ex4();
            //Ex5();
            //Ex6(); 
            //Ex7();

        }

        static void Ex1()
        {
            /*  Scrieti un program care va citi un vector de intregi de dimensiune n de la tastaura.
                Scrieti o functie care va inversa elementele vectorului, apelati-o si afisati-I rezultatul
             */


            Console.WriteLine("Introduceti numarul de elementele ale vectorului.");
            int lungimeSir = int.Parse(Console.ReadLine());
            int[] vector = PopulareVector(lungimeSir);
            int[] vectorInversat = InversareVector(vector);

            ImprimaVector(vectorInversat);
        }

        static void Ex2()
        {
            /*  Cititi de la tastatura continutul unei matrici de intregi cu 3 dimensiuni avand lungimile n, m
                k. Lungimile celor trei dimensiuni ale matricii, n, m si k, vor fi citite de la tastaura.
                Scrieti o functie care va calcula suma elementelor unei astfel de matrici , apelati-o si afisati-i
                rezultatul.
                Scrieti o functie care va determina elementul cu valoare maxima, apelati-o si afisati-i
                rezultatul.
            */


            Console.WriteLine("Introduceti numarul de linii.");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("Introduceti numarul de coloane.");
            int m = int.Parse(Console.ReadLine());
            Console.WriteLine("Introduceti numarul de elemente.");
            int k = int.Parse(Console.ReadLine());

            Console.WriteLine("Introduceti elementele vectorului.");
            int[,,] vector3D = CitireMatrice(n, m, k);

            int suma = Suma(vector3D);
            int celMaiMare = CelMaiMare(vector3D);

            Console.WriteLine($"Suma elementelor vectorului este: {suma}");
            Console.WriteLine($"Cel mai mare element al vectorului este: {celMaiMare}");
        }

        static void Ex3()
        {
            /*  Cititi de la tastatura continutul a doua matrici de intregi cu 2 dimensiuni avand lungimile n
                m, respectiv n,m. Lungimile celor doua dimensiuni ale matricilor, m si n, vor fi citite de la
                tastaura. Scrieti o functie care va calcula produsul celor doua matrici, apelati-o si afisati-I
                rezultatul.
            */


            Console.WriteLine("Introduceti numarul de linii.");
            int n = 0;
            int aux = ValidareDimensiune();

            if (aux > 1)
            {
                n = aux;
            }
            else
            {
                return;
            }

            Console.WriteLine("Introduceti numarul de coloane.");
            int m = 0;
            aux = ValidareDimensiune();

            if (aux > 1)
            {
                m = aux;
            }
            else
            {
                return;
            }

            Console.WriteLine("Introduceti matricea 1");
            int[,] mat1 = CitireMatriceEx3(n, m);
            AfisareMatrice(mat1);
            Console.WriteLine("Introduceti matricea 2");
            int[,] mat2 = CitireMatriceEx3(n, m);
            AfisareMatrice(mat2);

            int[,] rezultatImultire = ProdusMatrici(mat1, mat2);
            Console.WriteLine("Produsul matricilor este:");
            AfisareMatrice(rezultatImultire);
        }

        static void Ex4()
        {
            /*  Scrieti o functie recursiva care va afisa 
                in ordine elementele unui vector de intregi.
             */


            Console.WriteLine("Cate elementele are vectorul?");
            int contor = int.Parse(Console.ReadLine());

            Console.WriteLine("Populati vectorul.");
            int[] vector = PopulateVector(contor);
            AfisareInOrdine(vector.Length, vector);
        }

        static void Ex5()
        {
            /*  Scrieti o functie recursiva care va calcula suma numerelor de la 1 pana la n,
                apelati-o si afisati-i rezultatul.
            */


            Console.WriteLine("Introduceti un numar");
            int n = int.Parse(Console.ReadLine());
            int suma = SumaCifrelor(n);
            Console.WriteLine($"Suma este: {suma}");
        }

        static void Ex6()
        {
            /*  Scrieti o functie recursiva care va calcula al n-lea element din sirul lui
                Fibonacci, n fiind citit de la tastatura, apelati-o si afisati-I rezultatul.
            */
            Console.WriteLine("Introduceti un numar pentru a afla valoare lui in sirul Fibonaci.");
            int numar = int.Parse(Console.ReadLine());
            
            Fibonacci(numar);
            Console.WriteLine($"Numarul din sirul Fibonacci in pozitia aleasa este {Fibonacci(numar - 1) + Fibonacci(numar - 2)}");
        }

        static void Ex7()
        {
            /*   Scrieti o functie recursiva care pentru un numar “n” primit ca parametru, va
                 afisa urmatoarea piramida a numerelor:
                 1
                 2 2
                 3 3 3
                 4 4 4 4
                 …
                 n n n …..n
            */

            Console.WriteLine("Introduceti numarul de coloane.");
            int numar = int.Parse(Console.ReadLine());

            //AfisarePiramida(numar);
            PiramidaNumerelor(numar, 1);
        }


        static int[] PopulareVector(int contor)
        {
            int[] newVector = new int[contor];
            for (int i = 0; i < contor; i++)
            {
                newVector[i] = int.Parse(Console.ReadLine());
            }
            return newVector;
        }

        static int[] InversareVector(int[] vector)
        {
            int[] newVector = new int[vector.Length];
            int j = 0;

            for (int i = vector.Length - 1; i >= 0; i--)
            {
                newVector[j] = vector[i];
                j++;
            }
            return newVector;
        } 

        static void ImprimaVector(int[] vector)
        {
            for (int i = 0; i < vector.Length; i++)
            {
                Console.Write($"{vector[i]}, ");
            }
        }

        static int[,,] CitireMatrice(int n, int m, int k)
        {
            int[,,] rezultat = new int[n, m, k];

            for (int x = 0; x < n; x++)
            {
                for (int y = 0; y < m; y++)
                {
                    for (int z = 0; z < k; z++)
                    {
                        rezultat[x, y, z] = int.Parse(Console.ReadLine());
                    }
                }
            }
            return rezultat;
        }

        static int Suma(int[,,] vector3D)
        {
            int suma = 0;
            int n = vector3D.GetLength(0);
            int m = vector3D.GetLength(1);
            int k = vector3D.GetLength(2);


            for (int x = 0; x < n; x++)
            {
                for (int y = 0; y < m; y++)
                {
                    for (int z = 0; z < k; z++)
                    {
                        suma += vector3D[x, y, z];
                    }
                }
            }
            return suma;
        }

        static int CelMaiMare(int[,,] vector3D)
        {
            int celMaiMare = vector3D[0, 0, 0];
            int n = vector3D.GetLength(0);
            int m = vector3D.GetLength(1);
            int k = vector3D.GetLength(2);


            for (int x = 0; x < n; x++)
            {
                for (int y = 0; y < m; y++)
                {
                    for (int z = 0; z < k; z++)
                    {
                        if (celMaiMare < vector3D[x, y, z])
                        {
                            celMaiMare = vector3D[x, y, z];
                        }
                    }
                }
            }
            return celMaiMare;
        }

        static int[] PopulateVector(int contor)
        {
            int[] newVector = new int[contor];

            for (int i = 0; i < contor; i++)
            {
                int num = int.Parse(Console.ReadLine());
                newVector[i] = num;
            }
            return newVector;
        }

        static void AfisareInOrdine(int contor, int[] vector) 
        {
            if (contor - 1 < 0)
            {
                return;
            }
            AfisareInOrdine(contor - 1, vector);
            Console.WriteLine(vector[contor - 1]);
            return;
        }

        static int SumaCifrelor(int n)
        {
            if (n <= 1)
            {
                return 1;
            }

            return n + SumaCifrelor(n - 1);
        }

        static int ValidareDimensiune()
        {
            int numar = int.Parse(Console.ReadLine());

            if (numar < 2)
            {
                Console.WriteLine("Numarul trebuie sa fie mai mare decat 1.");
                return 0;
            }
            else
            {
                return numar;
            }
        }

        static int[,] CitireMatriceEx3(int n, int m)
        {
            int[,] rezultat = new int[n, m];

            for (int x = 0; x < n; x++)
            {
                for (int y = 0; y < m; y++)
                {
                    rezultat[x, y] = int.Parse(Console.ReadLine());
                }
            }
            return rezultat;
        }

        static void AfisareMatrice(int[,] matrice)
        {
            int n = matrice.GetLength(0);
            int m = matrice.GetLength(1);
            for (int x = 0; x < n; x++)
            {
                for (int y = 0; y < m; y++)
                {
                    Console.Write(matrice[x, y] + " ");
                }
                Console.WriteLine();
            }
        }

        static int[,] ProdusMatrici(int[,] matrice1, int[,] matrice2)
        {
            int m1Linie = matrice1.GetLength(0);
            int m1Coloana = matrice1.GetLength(1);
            int m2Coloana = matrice2.GetLength(1);

            int aux;

            int[,] produsMatrice = new int[m1Linie, m2Coloana];

            for (int i = 0; i < m1Linie; i++)
            {
                for (int j = 0; j < m2Coloana; j++)
                {
                    aux = 0;

                    for (int k = 0; k < m1Coloana; k++)
                    {
                        aux += matrice1[i, k] * matrice2[k, j];
                    }
                    produsMatrice[i, j] = aux;
                }
            }
            return produsMatrice;
        }

        static int Fibonacci(int n)
        {
            if (n <= 0)
            {
                return 0;
            }
            else if (n == 1)
            {
                return 1;
            }
            else
            {
                return Fibonacci(n - 1) + Fibonacci(n - 2);
            }
        }

        static void Afisare(int numar, int index)
        {
            if (index <= 0)
            {
                return;
            }

            Afisare(numar, index - 1);
            Console.Write(numar);
        }

        static void PiramidaNumerelor(int numar, int index)
        {
            if (numar <= 0)
                return;

            Afisare(index, index);

            Console.WriteLine();

            PiramidaNumerelor(numar - 1, index + 1);
        }
    }
}
