using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animal_shelter_2
{
    public abstract class Animal : ISellable
    {
        #region fields
        private string name;
        private Gender gender;
        private bool isReserved;
        private decimal prijs;
        //private ReservatieForm RF;
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

        public decimal Prijs
        {
            get { return prijs;}
            set { prijs = value;}
        }

        public abstract string MakeNoise();

        public abstract int price();

        #endregion
        
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
