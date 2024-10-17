using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Robot_Project.Classes
{
    public class PertahananSuper : IKemampuan
    {
        public int Cooldown { get; set; }
        public int MaxCooldown { get; } = 7;  
        public void Gunakan(Robot pengguna, Robot target) { }

        public void Gunakan(Robot pengguna)
        {
            Console.WriteLine($"{pengguna.Nama} menggunakan Pertahanan Super!");
            pengguna.Armor += 10;
            Console.WriteLine($"{pengguna.Nama} meningkatkan armor! Armor sekarang: {pengguna.Armor}");
        }
    }
}
