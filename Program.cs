using System;

namespace Hometusk
{
    internal class Program
    {
        //static void TextSuper(string q, string w, string a, int x, string f, int e, string b, string u, string i, string o, ConsoleColor textsuper)
       // {
        //    Console.ForegroundColor = textsuper;
        //    Console.Write(q + w + a + x + f + e + b + u + i + o);
        //    Console.ForegroundColor = ConsoleColor.Green;
       // }
        //    void Color(string str, ConsoleColor color)
        //  {
        //      Console.ForegroundColor = color;
        //      Console.Write(str);
        //      Console.ForegroundColor = ConsoleColor.White;
        //  }

        static void Main(string[] args)

        {
            IronMan ironMan = new IronMan("Человек", 185, 3, "деньги", "пушка, ракеты, лазер");
            Spiderman spiderMan = new Spiderman("Человек", 183, 1, "радиоактивная", "паутина");
            Thor thor = new Thor("Асгардец", 201, 5, "инопланетная", "молот");
            Hulk hulk = new Hulk("Человек", 244, 2, "радиоактивная", "мускулы");
            CaptainAmerica captainAmerica = new CaptainAmerica("Человек", 187, 4, "радиоактивная", "щит");
            Grigoriy grigoriy = new Grigoriy("Человек", 167, 33546556, "божья", "обзывательства");

            Superhero[] superheroes = { spiderMan, hulk, thor, captainAmerica, grigoriy, ironMan };
            for (int i = 0; i < superheroes.Length; i++)
            {
                var superhero = superheroes[i];

                if (superhero is Spiderman)
                    Console.WriteLine( "Вид:" + ((Spiderman)superhero).Species + "\nРост:" + spiderMan.Hight + "cm\nКрутость:" + spiderMan.Power + "\nПрирода силы:" + spiderMan.NatureOfSuperpower + "\nОружие:" + spiderMan.Gun);
                             
                if (superhero is IronMan)                   
                    Console.WriteLine("Вид:" + ((IronMan)superhero).Species + "\n" + "Рост:" + ironMan.Hight + "cm" + "\n" + "Крутость:" + ironMan.Power + "\n" + "Природа силы:" + ironMan.NatureOfSuperpower + "\n" + "Оружие:" + ironMan.Gun);               
                
                if (superhero is Hulk)
                    Console.WriteLine("Вид:" + ((Hulk)superhero).Species + "\nРост:" + hulk.Hight + "cm\nКрутость:" + hulk.Power + "\nПрирода силы:" + hulk.NatureOfSuperpower + "\nОружие:" + hulk.Gun);
               
                if (superhero is Thor)                    
                    Console.WriteLine("Вид:" + ((Thor)superhero).Species + "\n" + "Рост:" + thor.Hight + "cm\nКрутость:" + thor.Power + "\nПрирода силы:" + thor.NatureOfSuperpower + "\n" + "Оружие:" + thor.Gun);
          
                if (superhero is CaptainAmerica)
                    Console.WriteLine("Вид:", ((CaptainAmerica)superhero).Species, "\nРост:", captainAmerica.Hight, "cm\nКрутость:", captainAmerica.Power, "\nПрирода силы:", captainAmerica.NatureOfSuperpower, "\nОружие:", captainAmerica.Gun);               
                
                if (superhero is Grigoriy)
                    Console.WriteLine("Вид:" + ((Grigoriy)superhero).Species + "\nРост:" + grigoriy.Hight + "cm\nКрутость:" + grigoriy.Power + "\nПрирода силы:" + grigoriy.NatureOfSuperpower + "\n" + "Оружие:" + grigoriy.Gun);
                

                superhero.Fire();
            }
        }
    }
    //radioactive  radioactive    money      scientific   alien      god
    //  Spiderman,    Hulk,      IronMan, CaptainAmerica, Thor    Griroriy
    //     1             2          3          4           5       175678



     
    public class Superhero
    {
        public string Species { get; set; }
        public int Hight { get; set; }
        public int Power { get; set; }
        public string NatureOfSuperpower { get; set; }
        public string Gun { get; set; }


        public Superhero(string species, int hight, int power, string natureofsuperpower, string gun)
        {
            Species = species;
            Hight = hight;
            Power = power;
            NatureOfSuperpower = natureofsuperpower;
            Gun = gun;

        }
        public virtual void Fire()
        {
            Console.WriteLine("Attack");
        }
    }
    public class Spiderman : Superhero
    {
        public Spiderman(string species, int hight, int power, string natureofsuperpower, string gun) : base(species, hight, power, natureofsuperpower, gun)
        {
        }
        public override void Fire()
        {
            Console.WriteLine("Человек Паук: пустил паутину");
        }
    }
    public class Hulk : Superhero
    {
        public Hulk(string species, int hight, int power, string natureofsuperpower, string gun) : base(species, hight, power, natureofsuperpower, gun)
        {
        }
        public override void Fire()
        {
            Console.WriteLine("Халк: удар кулаком");
        }
    }
    public class IronMan : Superhero
    {
        public IronMan(string species, int hight, int power, string natureofsuperpower, string gun) : base(species, hight, power, natureofsuperpower, gun)
        {
        }
        public override void Fire()
        {
            Console.WriteLine("Железный человек: пуск ракеты");
        }
    }
    public class CaptainAmerica : Superhero
    {
        public CaptainAmerica(string species, int hight, int power, string natureofsuperpower, string gun) : base(species, hight, power, natureofsuperpower, gun)
        {
        }
        public override void Fire()
        {
            Console.WriteLine("Капитан Америка: метание щита");
        }
    }
    public class Thor : Superhero
    {
        public Thor(string species, int hight, int power, string natureofsuperpower, string gun) : base(species, hight, power, natureofsuperpower, gun)
        {
        }
        public override void Fire()
        {
            Console.WriteLine("Тор: удар молота");
        }
    }
    public class Grigoriy : Superhero
    {
        public Grigoriy(string species, int hight, int power, string natureofsuperpower, string gun) : base(species, hight, power, natureofsuperpower, gun)
        {
        }
        public override void Fire()
        {
            Console.WriteLine("Григорий: \"Фуфлыга!!!\"");
        }
    }
}

