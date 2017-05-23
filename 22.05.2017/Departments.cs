using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _22._05._2017
{
    class Departments
    {
        public string name;
        public List<Doctors> listOfDoctors = new List<Doctors>();
        public Departments(string name)
        {
            this.name = name;
        }

        public void setDoctor(Doctors doctor)
        {
            listOfDoctors.Add(doctor);
        }
    }
}
