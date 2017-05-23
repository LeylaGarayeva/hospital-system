using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _22._05._2017
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, Departments> depats = new Dictionary<int, Departments>();

            depats.Add(1, new Departments("kardilogiya"));
            depats.Add(2, new Departments("Lor"));
            depats.Add(3, new Departments("Radiologiya"));
            depats.Add(4, new Departments("ginekologiya"));

            Dictionary<int, Doctors> doctors = new Dictionary<int, Doctors>();

            doctors.Add(1, new Doctors("Behruz Aydinli",1));
            doctors.Add(2, new Doctors("Leyla Qarayeva",2));
            doctors.Add(3, new Doctors("Ramil Memmedov",3));
            doctors.Add(4, new Doctors("Edile Ismayilova",4));

            depats[1].setDoctor(doctors[1]);
            depats[1].setDoctor(doctors[2]);
            depats[1].setDoctor(doctors[3]);
            depats[2].setDoctor(doctors[4]);

//            bool added = doctors[4].setMeeting(2, "Yolchu Nasib");
  //          doctors[4].setMeeting(3, "Samir Karimov");
    //        doctors[2].setMeeting(4, "Bla bla");

            /*foreach(KeyValuePair<int,string> seance in doctors[4].getSeance())
            {
                Console.WriteLine(seance.Value);
            }*/
            int b=0;
            do
            {

                Console.WriteLine("Adinizi daxil edin:");
                string ad = Console.ReadLine();
                Console.WriteLine("Shobeni secin:");

                foreach (KeyValuePair<int, Departments> dep in depats)
                {

                    Console.WriteLine(dep.Key + " - " + dep.Value.name);
                }
                //  Console.WriteLine("hekim secin");

                int select_department = int.Parse(Console.ReadLine());
                if (select_department != null)
                {
                    Console.WriteLine("Hekimi secin:");
                }
                foreach (Doctors doctor in depats[select_department].listOfDoctors)
                {
                    Console.WriteLine(doctor.id + " - " + doctor.fullName);
                }

                int select_doctor = int.Parse(Console.ReadLine());

                if (select_department != null)
                {
                    Console.WriteLine("Qrafiki secin:");
                }
                foreach (KeyValuePair<int, string> seance in doctors[select_doctor].getSeance())
                {
                    Console.WriteLine(seance.Key + " " + seance.Value);

                }
                int a = Convert.ToInt32(Console.ReadLine());
                doctors[select_doctor].setMeeting(a, ad);
                b++;
            } while (b < 50);
            
     
        }
    }
}
