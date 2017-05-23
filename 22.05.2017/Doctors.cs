using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _22._05._2017
{
    class Doctors:Grafik
    {
        public string fullName;
        public int id;
        public Dictionary<int, string> meetingList = new Dictionary<int, string>();
        public Doctors(string name,int id)
        {
            this.fullName = name;
            this.id=id;
        }

        public bool setMeeting(int index,string pasient)
        {
            if (meetingList.ContainsKey(index))
            {
                Console.WriteLine("Bu saat mesguldur");
                return false;
            } 
            else
            {
                Console.WriteLine("Hormetli {0} , siz qeydiyyata alindiniz", pasient);
                meetingList.Add(index, pasient);
                return true;
            }
            
        }
        public Dictionary<int,string> getSeance()
        {
            Dictionary<int, string> list = new Dictionary<int, string>();
            for (int i = 0; i < this.hours.Count; i++)
            {
                if (meetingList.ContainsKey(i))
                {
                    list.Add(i, this.hours[i] + " doludur");
                }
                else
                {
                    list.Add(i, this.hours[i] + " bosdur");
                }
            }
            return list;
        }
    }
}
