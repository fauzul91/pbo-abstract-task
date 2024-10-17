using System;

namespace Robot_Project.Classes
{
    public abstract class Robot
    {
        private string nama;
        private int energi, armor, serangan;

        public string Nama
        {
            get
            {
                return nama;
            }
            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    nama = value;
                }
                else
                {
                    Console.WriteLine("Nama tidak boleh kosong atau null.");
                }
            }
        }

        public int Energi
        {
            get
            {
                return energi;
            }
            set
            {
                if (value > 0)
                {
                    energi = value;
                }
                else
                {
                    Console.WriteLine("Energi harus lebih dari 0.");           }
            }
        }

        public int Armor
        {
            get
            {
                return armor;
            }
            set
            {
                if (value > 0)
                {
                    armor = value;
                }
                else
                {
                    Console.WriteLine("Armor harus lebih dari 0.");
                }
            }
        }

        public int Serangan
        {
            get
            {
                return serangan;
            }
            set
            {
                if (value > 0)
                {
                    serangan = value;
                }
                else
                {
                    Console.WriteLine("Serangan harus lebih dari 0.");
                }
            }
        }

        public virtual void Serang(Robot target)
        {
            int serangan_yangdiberikan = Serangan;
            if (target.Armor > 0)
            {
                if (serangan_yangdiberikan >= target.Armor) 
                {
                    serangan_yangdiberikan -= target.Armor; 
                    target.Armor = 0; 
                    Console.WriteLine($"{Nama} menghancurkan armor {target.Nama}.");
                }
                else
                {
                    target.Armor -= serangan_yangdiberikan;
                    serangan_yangdiberikan = 0; 
                    Console.WriteLine($"{Nama} mengurangi armor {target.Nama} sebanyak {Serangan}.");
                }
            }

            if (serangan_yangdiberikan > 0)
            {
                target.Energi -= serangan_yangdiberikan;
                if (target.Energi < 0)
                {
                    target.Energi = 0;
                }
                Console.WriteLine($"{Nama} menyerang {target.Nama}, mengurangi energi sebanyak {serangan_yangdiberikan}.");
            }

            if (target.Energi <= 0)
            {
                Console.WriteLine($"Robot {target.Nama} telah mati.");
            }
        }

        public abstract void GunakanKemampuan(IKemampuan kemampuan, Robot target);

        public void CetakInformasi()
        {
            Console.WriteLine($"Nama Robot\t: {Nama}\nEnergi\t\t: {Energi}\nArmor\t\t: {Armor}\nSerangan\t: {Serangan}");
        }

        public Robot(string nama, int energi, int armor, int serangan)
        {
            Nama = nama;       
            Energi = energi;
            Armor = armor;
            Serangan = serangan;
        }
    }
}
