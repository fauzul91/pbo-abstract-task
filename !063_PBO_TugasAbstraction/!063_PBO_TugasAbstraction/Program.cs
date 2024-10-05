class Program
{
    static void Main(string[] args)
    {
        
    }

    //static Robot TambahkanRobot()
    //{
    //    string nama  = InputString("Masukkan nama robot: ");
    //    int energi   = InputAngka("Masukkan energi robot: ");
    //    int armor    = InputAngka("Masukkan armor robot: ");
    //    int serangan = InputAngka("Masukkan serangan robot: ");

    //    if (!string.IsNullOrEmpty(nama) && energi > 0 && armor >= 0 && serangan > 0)
    //    {

    //    } 
    //}
    //static string InputString(string input)
    //{
    //    Console.Write(input);
    //    return Console.ReadLine();
    //}
    //static int InputAngka(string input)    
    //{
    //    Console.Write(input);
    //    int angka;
    //    if (int.TryParse(input, out angka))
    //    {
    //        return angka;
    //    }
    //    else
    //    {
    //        Console.WriteLine("Input harus berupa angka");
    //        return -1;
    //    }
    //}
}

public abstract class Robot
{
    private string nama;
    private int energi, armor, serangan;

    public string Nama
    {
        get { return nama; }
        set
        {
            if (!string.IsNullOrEmpty(nama))
            {
                nama = value;
            }
            else
            {
                Console.WriteLine("Nama robot harus ada!");
            }
        }
    }

    public int Energi
    {
        get { return energi; }
        set
        {
            if (energi > 0)
            {
                energi = value;
            }
            else
            {
                Console.WriteLine("Energi robot harus terisi, sarapan dulu dek");
            }
        }
    }

    public int Armor
    {
        get { return armor; }
        set
        {
            if (armor >= 0)
            {
                armor = value;
            }
            else
            {
                Console.WriteLine("Armor robot tidak boleh negatif");
            }
        }
    }

    public int Serangan
    {
        get { return serangan; }
        set
        {
            if (serangan > 0)
            {
                serangan = value;
            }
            else
            {
                Console.WriteLine("Serangan robot tidak boleh negatif bre!");
            }
        }
    }

    public void Serang(Robot target)
    {

    }

    public void GunakanKemampuan(IKemampuan kemampuan)
    {

    }

    public Robot(string nama, int energi, int armor, int serangan)
    {
        this.nama = nama;
        this.energi = energi;
        this.armor = armor;
        this.serangan = serangan;
    }
        
    public void cetakInformasi()
    {
        Console.WriteLine($"Nama Robot: {Nama}\nEnergiRobot: {Energi}\nArmor Robot: {Armor}\nSerangan Robot: {Serangan}");
    }
}
public class BosRobot : Robot
{
    private int Pertahanan;
    public BosRobot(string nama, int energi, int pertahanan, int armor, int serangan) : base(nama, energi, armor, serangan)
    {
        this.pertahanan = Pertahanan;
    }
    public void TampilkanInfo()
    {
        Console.WriteLine($"Nama Bos Robot: {Nama}, Energi: {Energi}, Pertahanan: {pertahanan}, Armor: {Armor}, Serangan: {Serangan}");
    }
}

public interface IKemampuan
{
    
}