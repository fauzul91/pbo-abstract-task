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
                    Console.WriteLine("Energi harus lebih dari 0.");
                }
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

        public void Serang(Robot target)
        {
            int damage = Math.Max(0, Serangan - target.Armor);
            target.Energi -= damage;
            Console.WriteLine($"{Nama} menyerang {target.Nama} dan memberikan {damage} kerusakan!");
        }

        public abstract void GunakanKemampuan(IKemampuan kemampuan, Robot target);
        public abstract void GunakanKemampuan(IKemampuan kemampuan);
        public void CetakInformasi()
        {
            Console.WriteLine($"Nama Robot: {Nama}\nEnergi: {Energi}\nArmor: {Armor}\nSerangan: {Serangan}");
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
