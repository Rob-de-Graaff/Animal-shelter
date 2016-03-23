using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Animal_shelter_2
{
    public partial class ReservatieForm : Form
    {
        #region fields
        private Gender gender;
        string datum;
        private Animal animal;
        private Administration admin;
        #endregion

        public ReservatieForm()
        {
            InitializeComponent();
        }

        #region methodes
        private void createAnimalButton_Click(object sender, EventArgs e)
        {
            if (tbDay.Text != "" && tbMonth.Text != "" && tbYear.Text != "")
            {
                datum = tbDay.Text + "-" + tbMonth.Text + "-" + tbYear.Text;
                    DateTime lastWalkDate = DateTime.Parse(datum);
                string error = "";
                if(cbGender.Checked == true)
                {
                    gender = Gender.Male;
                    if (animalTypeComboBox.SelectedItem.ToString() == "Dog")
                    {
                        animal = new Dog(tbNaam.Text, gender, lastWalkDate, "woef");
                    }
                    else if (animalTypeComboBox.SelectedItem.ToString() == "Cat")
                    {
                        animal = new Cat(tbNaam.Text, gender, tbGedrag.Text, "miauw");
                    }
                }
                else
                {
                    gender = Gender.Female;
                    if (animalTypeComboBox.SelectedItem.ToString() == "Dog")
                    {
                        animal = new Dog(tbNaam.Text, gender, lastWalkDate, "woef");
                    }
                    else if (animalTypeComboBox.SelectedItem.ToString() == "Cat")
                    {
                        animal = new Cat(tbNaam.Text, gender, tbGedrag.Text, "miauw");
                    }
                }
                if (!admin.Add(animal, out error))
                {
                    MessageBox.Show(error);
                    //lbReserved.Items.Clear();
                }
                else
                {
                    admin.Add(animal, out error);
                    udButtons();
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

        }

        private void btnReserve_Click(object sender, EventArgs e)
        {

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {

        }

        private void showInfoButton_Click(object sender, EventArgs e)
        {

        }

        private void udButtons()
        {
            if (/*!admin.Animals.Any()*/admin.Animals.Count == 0)
            {
                showInfoButton.Enabled = false;
                btnSearch.Enabled = false;
                btnDelete.Enabled = false;
            }
            else
            {
                showInfoButton.Enabled = true;
                btnSearch.Enabled = true;
                btnDelete.Enabled = true;
            }
        }

        public void Updater()
        {
            lbReserved.Items.Clear();
            lbNotReserved.Items.Clear();
            foreach (Animal animal in admin.Animals)
            {
                if (animal.IsReserved)
                {
                    if (animal is Cat)
                    {
                        Cat cat = animal as Cat;
                        lbReserved.Items.Add(cat.ToString());
                    }
                    else if (animal is Dog)
                    {
                        Dog dog = animal as Dog;
                        lbReserved.Items.Add(dog.ToString());
                    }
                }
                else if (!animal.IsReserved)
                {
                    if (animal is Cat)
                    {
                        Cat cat = animal as Cat;
                        lbNotReserved.Items.Add(cat.ToString());
                    }
                    else if (animal is Dog)
                    {
                        Dog dog = animal as Dog;
                        lbNotReserved.Items.Add(dog.ToString());
                    }
                }
            }
        }
        #endregion
    }
}
