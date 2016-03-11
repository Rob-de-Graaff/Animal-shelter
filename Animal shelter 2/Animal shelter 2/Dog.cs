using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animal_shelter_2
{
    public class Dog : Animal
    {
        private SimpleDate lastWalkDate;

        public SimpleDate LastWalkDate
        {
            get { return lastWalkDate; }
            set { lastWalkDate = value; }
        }

        public Dog(string name, SimpleDate dateOfBirth, Gender gender)
            : base(name, dateOfBirth, gender)
        {
            this.lastWalkDate = lastWalkDate;
        }

        public override string ToString()
        {
            string dateOfBirthString;
            if (dateOfBirth == null)
            {
                dateOfBirthString = "00-00-0000";
            }
            else
            {
                dateOfBirthString = dateOfBirth.ToString();
            }

            string nameString;
            if (name == null || name == "")
            {
                nameString = "noname";
            }
            else
            {
                nameString = name;
            }

            string IsReservedString;
            if (isReserved)
            {
                IsReservedString = "reserved";
            }
            else
            {
                IsReservedString = "not reserved";
            }

            string info = dateOfBirthString
                + ", " + nameString
                + ", " + IsReservedString;

            return info;
        }
    }
}
