using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animal_shelter_2
{
    public class Cat : Animal
    {
        #region fields
        private Gender gender;
        private string badHabits;
        private string noise;
        #endregion

        #region properties
        public string BadHabits
        {
            get { return badHabits; }
            set { badHabits = value; }
        }
        #endregion

        #region constructor
        public Cat(string name, Gender gender, string badHabbits, string noise)
            : base(name, gender)
        {
            this.BadHabits = badHabits;
        }
        #endregion

        #region methodes
        public override string MakeNoise()
        {
            noise = "miauw";
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

            string badHabitString;
            if (BadHabits == null || BadHabits == "")
            {
                badHabitString = "NoBadHabbits";
            }
            else
            {
                badHabitString = BadHabits;
            }


            string info = nameString
                + ", " + genderString
                + ", " + IsReservedString
                + ", " + badHabitString
                + ", " + MakeNoise();

            return info;
        }
        #endregion
    }
}
