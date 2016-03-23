using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animal_shelter_2
{
    public abstract class Animal
    {
        #region fields
        private string name;
        private Gender gender;
        private bool isReserved;
        private ReservatieForm RF;
        #endregion

        #region properties
        public string Name
        {
            get { return name; }
        }

        public Gender Gender
        {
            get { return gender; }
            set { gender = value; }
        }

        public bool IsReserved
        {
            get { return isReserved; }
            set { isReserved = value; }
        }
        #endregion

        //
        public abstract string MakeNoise();

        #region constructor
        public Animal(string name, Gender gender)
        {
            this.name = name;
            this.gender = gender;
            isReserved = false;
        }
        #endregion

        #region methode
        public override string ToString()
        {
            string nameString;
            if (name == null || name == "")
            {
                nameString = "noname";
            }
            else
            {
                nameString = name;
            }

            string genderString = "";
            if (gender == Gender.Male)
            {
                genderString = "male";
            }
            else if (gender == Gender.Female)
            {
                genderString = "female";
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

            string info = nameString
                + ", " + genderString
                + ", " + IsReservedString;

            return info;
        }
        #endregion
    }
}
