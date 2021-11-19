using System;
using System.Collections.Generic;

namespace CD_Store
{
    public interface IStoreitem
    {
        public double Price
        {
            get;
            set;
        }
        public double DiscountPrice(int temp)
        {
            return Price * temp;
        }
    }
    class Disk : IStoreitem
    {

        protected string name;
        protected string genre;
        protected int burnCount;
        public Disk(string name, string genre)
        {
            this.name = name;
            this.genre = genre;

        }
        public virtual double DiskSize
        {
            get;
            set;
        }
        public virtual void Burn(params string[] values) { }

        public double DiscountPrice(int temp)
        {
            return Price * temp;

        }
    }
    class Audio : Disk
    {
        protected string artist;
        protected string recordingStudio;
        protected int songsNumber;

        public Audio(string artist, string recordingStudio, string name, string genre) : base(name, genre)
        {
            this.artist = artist;
            this.recordingStudio = recordingStudio;

        }
        public double DiskSize()
        {
            return songsNumber * 8;


        }
        public string Name
        {
            get
            {
                return name;
            }
        }
        public override void Burn(params string[] values)
        {

            artist = values[0];
            recordingStudio = values[1];
            songsNumber = int.Parse(values[2]);
            name = values[3];
            genre = values[4];
            burnCount++;
        }
        public void ToString()
        {
            string str = Convert.ToString(songsNumber);
            string str2 = Convert.ToString(burnCount);
            Console.WriteLine(name + " " + genre + " " + artist + " " + recordingStudio + " " + str + " " + str2);
        }

    }
    class DVD : Disk
    {
        protected string producer;
        protected string filmCompany;
        protected int minutesCount;

        public DVD(string producer, string film, int minutes, string name, string genre) : base(name, genre)
        {
            this.producer = producer;
            this.filmCompany = film;
            this.minutesCount = minutes;

        }

        public string Name
        {
            get
            {
                return name;
            }
        }
        public double DiskSize()
        {
            minutesCount /= 64;
            minutesCount *= 2;
            return minutesCount;
        }
        public override void Burn(params string[] values)
        {

            producer = values[0];
            filmCompany = values[1];
            minutesCount = int.Parse(values[2]);
            name = values[3];
            genre = values[4];
            burnCount++;

        }
        public void ToString()
        {
            string str = Convert.ToString(minutesCount);
            string str2 = Convert.ToString(burnCount);
            Console.WriteLine(name + " " + producer + " " + filmCompany + " " + str + " " + str2);
        }
    }
    class Store
    {
        protected string storeName;
        protected string adress;
        public List<Audio> audios = new List<Audio>();
        public List<DVD> dvds = new List<DVD>();

        public Store(string storeName, string adress)
        {
            this.storeName = storeName;
            this.adress = adress;
        }
        public void ToString()
        {

            for (int i = 0; i < audios.Count; i++)
            {
                Console.WriteLine("Audios");
                Console.Write(audios[i] + " ");
                Console.WriteLine();
            }
            for (int i = 0; i < dvds.Count; i++)
            {
                Console.WriteLine("DVDs");
                Console.Write(dvds[i] + " ");
                Console.WriteLine();
            }


        }
        public List<Audio> GetAudios
        {
            get { return audios; }
            set { audios = value; }
        }
        public List<DVD> GetDVDs
        {
            get { return dvds; }
            set { dvds = value; }
        }
        public static List<DVD> operator +(Store store, DVD temp)
        {
            List<DVD> output = new List<DVD>();
            output.AddRange(store.dvds);
            output.Add(temp);

            return output;
        }
        public static List<DVD> operator -(Store store, DVD temp)
        {
            List<DVD> output = new List<DVD>();
            output.AddRange(store.dvds);
            output.Remove(temp);

            return output;
        }
        public static List<Audio> operator +(Store store, Audio temp)
        {
            List<Audio> output = new List<Audio>();
            output.AddRange(store.audios);
            output.Add(temp);

            return output;
        }
        public static List<Audio> operator -(Store store, Audio temp)
        {
            List<Audio> output = new List<Audio>();
            output.AddRange(store.audios);
            output.Remove(temp);

            return output;
        }
    }



    class Program
    {
        static void Main(string[] args)
        {
            Store store = new Store("nazvanie", "adress");

            store += new Audio("billy", "timmy", "Joe Biden", "Clone");
            store += new Audio("tommy", "timmy", "Joe Biden", "Clone");
            store += new DVD("tommy", "timmy", "Joe Biden", "Clone");
            store += new DVD("ben", "timmy", "Joe Biden", "Clone");
            int Length = store.LengthforAudio(Audio);
            Console.WriteLine(store.ToString());
            DVD.Burn(new string[] { "da", "chto", "3", "net", "maybe" });


            foreach (Audio i in store.GetAudios)
            {
                Console.WriteLine(i.Name + i.DiskSize);
            }
            foreach (DVD i in store.GetDVDs)
            {
                Console.WriteLine(i.Name + i.DiskSize);
            }
        }
    }
}