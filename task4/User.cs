using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task4
{
    internal class User
    {
        private static int id;
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string NotRobotCode { get; set; }
        public Month RegistrationMonth { get; set; }



        public User(string name, string surname, string notRobotCode, Month registrationMonth)
        {
            Name = name;
            Surname = surname;
            id++;
            Id = id;
            NotRobotCode = notRobotCode;
            RegistrationMonth = registrationMonth;
        }



        public string GetDetails()
        {
            if (NotRobotCode.CheckNotRobotCode())
            {
                return $"id:{Id} name:{Name} surname:{Surname} RegistrationMonth:{RegistrationMonth} Notrobotcode:{NotRobotCode} ";

            }
            else
            {
                return $"id:{Id} name:{Name} surname:{Surname} RegistrationMonth:{RegistrationMonth} NOt Correct ";
            }
        }

    }
    public enum Month
    {
        January = 1,
        February,
        March,
        April,
        May,
        June,
        July,
        August,
        September,
        October,
        November,
        December,

    }


}