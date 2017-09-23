using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization.Formatters;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;
using System.Runtime.Serialization.Formatters.Soap;

namespace Streaming_Serialisation
{
    class Program
    {
        static void Main(string[] args)
        {

            Save();
            Load();


            SaveSoap();
            LoadSoap();
           



        }

        static void Load()
        {
            IFormatter formatter = new BinaryFormatter();
            Stream stream1 = new FileStream("MyFile.bin",FileMode.Open,FileAccess.Read,FileShare.Read);
            Person pers = (Person) formatter.Deserialize(stream1);
            stream1.Close();
            Console.WriteLine("The persons have been read from file");
            Console.WriteLine("First name: {0}", pers.FirstName);
            Console.WriteLine("Last name: {0}", pers.LastName);
            Console.WriteLine("SSN: {0}", pers.Ssn);
            Console.ReadKey();
        }


        static void Save()
        {
            Person person = new Person();
            person.FirstName = "Bogdan";
            person.LastName = "Mitrache";
            person.Ssn = 123;

            IFormatter formatter = new BinaryFormatter();
            Stream stream = new FileStream("MyFile.bin", FileMode.Create, FileAccess.Write, FileShare.Write);
            formatter.Serialize(stream, person);
            stream.Close();
        }



        static void LoadSoap()
        {
            IFormatter formatter = new SoapFormatter();
            Stream stream1 = new FileStream("MyFile.bin", FileMode.Open, FileAccess.Read, FileShare.Read);
            Person pers = (Person)formatter.Deserialize(stream1);
            stream1.Close();
            Console.WriteLine("The persons have been read from file");
            Console.WriteLine("First name: {0}", pers.FirstName);
            Console.WriteLine("Last name: {0}", pers.LastName);
            Console.WriteLine("SSN: {0}", pers.Ssn);
            Console.ReadKey();
        }


        static void SaveSoap()
        {
            Person person = new Person();
            person.FirstName = "Bogdan";
            person.LastName = "Mitrache";
            person.Ssn = 123;

            IFormatter formatter = new SoapFormatter();
            Stream stream = new FileStream("MyFile.bin", FileMode.Create, FileAccess.Write, FileShare.Write);
            formatter.Serialize(stream, person);
            stream.Close();
        }







    }
}
