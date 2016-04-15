using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
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
        FileStream fs;

        string Filename = @"C:\ASUS bu\FHICT\SE\S2\Animalshelter_Filestream\test.txt";
        #endregion

        public ReservatieForm()
        {
            InitializeComponent();
            admin = new Administration();
            if (admin.Animals.Count != 0)
            {
                Readfile();
            }
            animal = null;
            udButtons();
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
            string Reserve = "";
            if (lbNotReserved.SelectedIndex > -1)
            {
                Reserve = lbNotReserved.SelectedItem.ToString();
            }
            else if (lbReserved.SelectedIndex > -1)
            {
                Reserve = lbReserved.SelectedItem.ToString();
            }

            foreach (Animal animal in admin.Animals)
            {
                if (Reserve == animal.ToString())
                {
                    admin.Animals.Remove(animal);
                    break;
                }
            }
            Updater();
            udButtons();
        }

        private void btnReserve_Click(object sender, EventArgs e)
        {
            string reserve = "";
            if (lbNotReserved.SelectedIndex > -1)
            {
                reserve = lbNotReserved.SelectedItem.ToString();
            }
            else if (lbReserved.SelectedIndex > -1)
            {
                reserve = lbReserved.SelectedItem.ToString();
            }

            foreach (Animal animal in admin.Animals)
            {
                if (reserve == animal.ToString())
                    animal.IsReserved = true;
            }
            Updater();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            string Res = "";
            if (lbReserved.SelectedIndex > -1)
            {
                Res = lbReserved.SelectedItem.ToString();
            }
            else if (lbNotReserved.SelectedIndex > -1)
            {
                Res = lbNotReserved.SelectedItem.ToString();
            }

            foreach (Animal animal in admin.Animals)
            {
                if (Res == animal.ToString())
                    animal.IsReserved = false;
            }
            Updater();
        }

        private void showInfoButton_Click(object sender, EventArgs e)
        {
            string anals = "";
            foreach (Animal anal in admin.Animals)
            {
                if (anals == "") anals = anal.ToString();
                else anals += "\n" + anal.ToString();
            }
            MessageBox.Show(anals);
            udButtons();
        }

        private void btnStream_Click(object sender, EventArgs e)
        {
            Stream stream = new FileStream(Filename, FileMode.OpenOrCreate, FileAccess.Write);
            StreamWriter SW = new StreamWriter(stream);
            SW.AutoFlush = true;
            string WriteAnimal = null;
            foreach (Animal anal in admin.Animals)
            {
                if (anal is Cat)
                {
                    Cat cat = anal as Cat;
                    WriteAnimal = cat.Name + "," + cat.Gender.ToString() + "," + cat.BadHabits + "," + cat.MakeNoise() + ",Cat";
                }
                else if (anal is Dog)
                {
                    Dog dog = anal as Dog;
                    WriteAnimal = dog.Name + "," + dog.Gender.ToString() + "," + dog.LastWalkDate.ToString() + "," + dog.MakeNoise() + ",Dog";
                }
                SW.WriteLine(WriteAnimal);
            }
            SW.Close();
        }

        private void udButtons()
        {
            if (!admin.Animals.Any()/*admin.Animals.Count == 0*/)
            {
                showInfoButton.Enabled = false;
                btnDelete.Enabled = false;
            }
            else
            {
                showInfoButton.Enabled = true;
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

        public void Readfile()
        {
            string error = "";
            try
            {
                Stream Fs = new FileStream(Filename, FileMode.Open, FileAccess.Read);
                StreamReader SR = new StreamReader(Fs);
                while (!SR.EndOfStream)
                {
                    var gen = Gender.Male;
                    string line = SR.ReadLine();
                    string[] animals = line.Split(',');
                    if (animals[5].ToString() == "Cat")
                    {
                        if (animals[2] == "Male")
                        {
                            gen = Gender.Male;
                        }
                        else
                        {
                            gen = Gender.Female;
                        }
                        Cat cat = new Cat(animals[1], gen, animals[3], animals[4]);
                        admin.Add(cat, out error);
                    }
                    else if (animals[5] == "Dog")
                    {
                        if (animals[2] == "Male")
                        {
                            gen = Gender.Male;
                        }
                        else
                        {
                            gen = Gender.Female;
                        }
                        string[] date = animals[3].Split('-');
                        var datetime = new DateTime(Convert.ToInt32(date[1]), Convert.ToInt32(date[2]), Convert.ToInt32(date[3]));
                        Dog dog = new Dog(animals[1], gen, datetime, animals[4]);
                        admin.Add(dog, out error);
                    }
                }
            }
            catch (IOException ioex)
            {
                MessageBox.Show(ioex.Message);
            }
            finally
            {
                if (fs != null)
                {
                    fs.Close();
                }
            }
        }
        #endregion
    }
}
