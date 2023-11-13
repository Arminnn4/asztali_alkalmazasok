using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace epitmenyado
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int aSav = 0, bSav = 0, cSav = 0;
            int telekSzam = 0;



            try
            {
                using (StreamReader sr = new StreamReader("utca.txt"))
                {
                    
                    string elsoSor = sr.ReadLine();
                    string[] adosavok = elsoSor.Split(' ');
                    aSav = int.Parse(adosavok[0]);
                    bSav = int.Parse(adosavok[1]);
                    cSav = int.Parse(adosavok[2]);



                    
                    while (!sr.EndOfStream)
                    {
                        string sor = sr.ReadLine();
                        string[] adatok = sor.Split(' ');



                        string adoSzam = adatok[0];
                        string utca = adatok[1];
                        string hazszam = adatok[2];
                        string adosav = adatok[3];
                        int alapterulet = int.Parse(adatok[4]);



                        telekSzam++;



                        if (adosav == "A" && alapterulet * aSav >= 10000)
                        {
                            Console.WriteLine($"{utca} {hazszam} {alapterulet} m2");
                        }
                        else if (adosav == "B" && alapterulet * bSav >= 10000)
                        {
                            Console.WriteLine($"{utca} {hazszam} {alapterulet} m2");
                        }
                        else if (adosav == "C" && alapterulet * cSav >= 10000)
                        {
                            Console.WriteLine($"{utca} {hazszam} {alapterulet} m2");
                        }
                    }
                }



                Console.WriteLine($" A telek adatok száma: {telekSzam}");

                Console.Write(" Kérem adja meg a tulajdonos adószámát: ");
                string adoszam = Console.ReadLine();



                
                using (StreamReader sr = new StreamReader("utca.txt"))
                {
                    sr.ReadLine(); 
                    while (!sr.EndOfStream)
                    {
                        string sor = sr.ReadLine();
                        string[] adatok = sor.Split(' ');



                        if (adatok[0] == adoszam)
                        {
                            Console.WriteLine($"Az építmény adatai: {adatok[1]} {adatok[2]} {adatok[4]} m2");
                            return; 
                        }
                    }



                    Console.WriteLine("Nem szerepel az adatállományban.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Hiba történt az állomány olvasása során: {ex.Message}");
            }
        }
    }
    }

