using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace labStudent
{
    class Student
    {
        public event EventHandler ChangeAge;

        private int _age;

        public int Age
        {
            get
            {
                return _age;
            }
            set
            {
                if (value > _age)
                {
                    _age = value;
                    if (ChangeAge != null)
                        ChangeAge(this, EventArgs.Empty);
                }
            }
        }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string GetFullName()
        {
            return Name + " " + Surname + " (" + Age + ")";
        }
     
    }
}
