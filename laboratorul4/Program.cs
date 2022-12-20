using System;

namespace laboratorul4
{
    class Program
    {
        static void Main(string[] args)
        {
            //Ex1();
            //Ex2();
            //Ex3(); // incomplet
            //Ex4();
            //Ex5();

        }

        static void Ex1()
        {
            /*  Scrieti un program care va citi un vector de intregi de dimensiune n de la tastaura.
                Scrieti o functie care va inversa elementele vectorului, apelati-o si afisati-I rezultatul
             */


            Console.WriteLine("Introduceti numarul de elementele ale vectorului.");
            int contor = int.Parse(Console.ReadLine());
            int[] vector = PopulareVector(contor);
            int[] vectorInversat = InversareVector(vector);

            ImprimaVector(vectorInversat);

            static int[] PopulareVector(int contor)
            {
                int[] newVector = new int[contor];
                for (int i = 0; i < contor; i++)
                {
                    int num = int.Parse(Console.ReadLine());
                    newVector[i] = num;
                }
                return newVector;
            }

            static int[] InversareVector(int[] vector)
            {
                int contor = vector.Length;
                int[] newVector = new int[contor];
                int j = 0;

                for (int i = contor - 1; i >= 0; i--)
                {
                    int numar = vector[i];
                    newVector[j] = numar;
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
        }

        static void Ex3()
        {
            /*  Cititi de la tastatura continutul a doua matrici de intregi cu 2 dimensiuni avand lungimile n
                m, respectiv n,m. Lungimile celor doua dimensiuni ale matricilor, m si n, vor fi citite de la
                tastaura. Scrieti o functie care va calcula produsul celor doua matrici, apelati-o si afisati-I
                rezultatul.
            */


            Console.WriteLine("Introduceti numarul de linii.");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("Introduceti numarul de coloane.");
            int m = int.Parse(Console.ReadLine());

            int[,] mat1 = CitireMatrice(n, m);
            AfisareMatrice(mat1);
            int[,] mat2 = CitireMatrice(n, m);
            AfisareMatrice(mat2);

            int[,] rezultatImultire = Inmultire(mat1, mat2);


            static int[,] CitireMatrice(int n, int m)
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
                        Console.Write(matrice[x,y] + " ");
                    }
                    Console.WriteLine();
                }
            }
            static int[,] Inmultire(int[,] mat1, int[,] mat2)
            {
                int linieMatrice1 = mat1.GetLength(0);
                int coloanaMatrice1 = mat1.GetLength(1);
                int coloanaMatrice2 = mat2.GetLength(1);

                int[,] mat3 = new int[linieMatrice1, coloanaMatrice2];

                for (int x = 0; x < linieMatrice1; x++)
                {
                    for (int y = 0; y < coloanaMatrice2; y++)
                    {
                        mat3[x, y] = 0;
                        for(int z = 0; z < coloanaMatrice1; z++)
                        {
                            mat3[x, y] = mat3[x, y] + mat1[x, z] * mat2[z, y];
                        }
                     
                    }

                }
                    return mat3;
            }
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

            static int SumaCifrelor(int n)
            {
                if (n <= 1)
                {
                    return 1;
                }

                return n + SumaCifrelor(n - 1);
            }
        }
    }
}
