using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animal_shelter_2
{
    abstract class Animal
    {
        private string name;
        private SimpleDate dateOfBirth;
        private bool isReserved;
        private Gender gender;

        public SimpleDate DateOfBirth
        {
            get { return dateOfBirth; }
        }

        public string Name
        {
            get { return name; }
        }

        public bool IsReserved
        {
            get { return isReserved; }
            set { isReserved = value; }
        }

        public Gender Gender
        {
            get { return gender; }
            set { gender = value; }
        }

        public Animal(string name, SimpleDate dateOfBirth, Gender gender)
        { 
            if (animalGenderComboBox.SelectedItem.Value = "Male")
            {
                this.gender = gender;
            }
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
