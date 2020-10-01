//get, set
// constructor, subclass, derived class
// base class, superclass, access Modijens(private, public, protected)
using System;

namespace access_modijiens
{
    class Phone
    {
        public int RAM;
        public string HDH;
        public int cost;
        protected string namephone;
        private string maker = "No information";
        public string Maker
        {
            get{ return maker;}
            set{ maker = value;}
        }
        public Phone(int RAM, string HDH, int cost, string namephone )
        {
            this.RAM = RAM;
            this.HDH = HDH;
            this.cost = cost;
            this.namephone = namephone;
        }
        public Phone()
        {
            RAM = 8;
            HDH = "Android";
            cost = 10000000;
            namephone = "No information";
        }
        public void Info()
        {
            Console.WriteLine("Day la dien thoai: "+namephone);
            Console.WriteLine("Nha san xuat: " + maker);
            Console.WriteLine("RAM: "+ RAM +",HDH: "+HDH);
            Console.WriteLine("Gia: " + cost);

        }


    }
    class Samsung: Phone
    {
        public Samsung()
        {
            RAM = 16;
            HDH = "Android";
            cost = 2000000;
            namephone = "No information";
        }

        public Samsung(int RAM, string HDH, int cost, string namephone): base(RAM, HDH, cost, namephone)
        {
            this.RAM = RAM;
            this.HDH = HDH;
            this.cost = cost;
            this.namephone = namephone;
        }
        public void Info()
        {
            Console.WriteLine("Day la dien thoai: "+namephone);
            Console.WriteLine("Nha san xuat: SamSung");
            Console.WriteLine("RAM: "+ RAM +",HDH: "+HDH);
            Console.WriteLine("Gia: " + cost);
        }
    }
    class Iphone: Phone
    {
        public Iphone()
        {
            RAM = 16;
            HDH = "IOS";
            cost = 3000000;
            namephone = "No information";
        }
        public Iphone(int RAM, string HDH, int cost, string namephone): base(RAM, HDH, cost, namephone)
        {
            this.RAM = RAM;
            this.HDH = HDH;
            this.cost = cost;
            this.namephone = namephone;
        }

        public void Info()
        {
            Console.WriteLine("Day la dien thoai: "+namephone);
            Console.WriteLine("Nha san xuat: Apple");
            Console.WriteLine("RAM: "+ RAM +",HDH: "+HDH);
            Console.WriteLine("Gia: " + cost);
        }
    }
    class Iphone12: Iphone
    {
        public Iphone12()
        {
            RAM = 16;
            HDH = "IOS";
            cost = 99000000;
        }
        public void Info()
        {
            Console.WriteLine("Day la dien thoai: Iphone12");
            Console.WriteLine("Nha san xuat: Apple");
            Console.WriteLine("RAM: "+ RAM +",HDH: "+HDH);
            Console.WriteLine("Gia: " + cost);
        }
    }

    
    class Program
    {
        static void Main(string[] args)
        {
            Phone phone1 = new Phone();
            Iphone phone2 = new Iphone();
            Samsung phone3 = new Samsung();
            Iphone12 phone4 = new Iphone12();
            Phone phone5 = new Iphone(8, "ISO", 50000000, "phone11 pro max");
            Phone phone6 = new Iphone12();
            Console.WriteLine("phone1:");
            phone1.Info();
            Console.WriteLine("phone2:");
            phone2.Info();
            Console.WriteLine("phone3:");
            phone3.Info();
            Console.WriteLine("phone4:");
            phone4.Info();
            Console.WriteLine("phone5:");
            phone5.Info();
            Console.WriteLine("phone6:");
            phone6.Info();
            phone1.Maker = "Vinsmart";
            Console.WriteLine("phone1:");
            phone1.Info();
        }
    }
}
