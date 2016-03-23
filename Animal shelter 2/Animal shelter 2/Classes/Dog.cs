using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animal_shelter_2
{
    public class Dog : Animal
    {
        #region fields
        private Gender gender;
        private DateTime lastWalkDate;
        private string noise;
        #endregion

        #region properties
        public DateTime LastWalkDate
        {
            get { return lastWalkDate; }
            set { lastWalkDate = value; }
        }
        #endregion

        #region constructor
        public Dog(string name, Gender gender, DateTime lastWalkDater, string noise)
            : base(name, gender)
        {
            this.LastWalkDate = lastWalkDate;
        }
        #endregion 

        #region methodes
        public override string MakeNoise()
        {
            string noise = "woef";
            return noise;
        }

        public override string ToString()
        {
            string nameString;
            if (Name == null || Name == "")
            {
                nameString = "noname";
            }
            else
            {
                nameString = Name;
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
            if (IsReserved)
            {
                IsReservedString = "reserved";
            }
            else
            {
                IsReservedString = "not reserved";
            }

            string lastWalkDateString;
            if (LastWalkDate == null)
            {
                lastWalkDateString = "00-00-0000";
            }
            else
            {
                lastWalkDateString = LastWalkDate.ToString();
            }

            string info = nameString
                + ", " + genderString
                + ", " + IsReservedString
                + ", " + lastWalkDateString;

            return info;
        }
        #endregion
    }
}