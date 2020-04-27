using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormUI
{
    public partial class Dashboard : Form
    {
        List<Person> people = new List<Person>();

        public Dashboard()
        {
            InitializeComponent();

            UpdateBinding();
        }

        private void UpdateBinding()
        {
            peopleFoundListbox.DataSource = people;
            peopleFoundListbox.DisplayMember = "FullInfo";
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            string text = "Nu exista persoana cautata";
            DataAccess db = new DataAccess();

            people = db.GetPeople(lastNameText.Text);

            if (people.Count() != 0)
            {
                UpdateBinding();
                textSearch.Text = "Persoanele gasite sunt:";
            }
            else
            {
                textSearch.Text = text;
                UpdateBinding();
            }
        }

        private void insertRecordButton_Click(object sender, EventArgs e)
        {
            DataAccess db = new DataAccess();

            db.InsertPerson(firstNameInsText.Text, lastNameInsText.Text, emailAddressInsText.Text, phoneNumberInsText.Text,CNPInsText.Text);

            firstNameInsText.Text ="";
            lastNameInsText.Text = "";
            emailAddressInsText.Text = "";
            phoneNumberInsText.Text = "";
            CNPInsText.Text = "";
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void Delete_Click(object sender, EventArgs e)
        {

            DataAccess db = new DataAccess();
            people=db.DeletePerson(CNPStergText.Text);

            if (people.Count() == 0) textBoxStergText.Text = "Nu exista persoana dorita";
            else
            {
                Person p = people.First();
                textBoxStergText.Text = ($"S-a sters persoana cu numele'{p.LastName}'"); 
            }
                CNPStergText.Text = "";
          
        }

        private void Update_Click(object sender, EventArgs e)
        {
            DataAccess db = new DataAccess();
            db.UpdatePerson(CNPUpdateText.Text,lastNameUpdateText.Text, firstNameUpdateText.Text, emailAddressUpdateText.Text, phoneNumberUpdateText.Text);
            CNPUpdateText.Text = "";
            firstNameUpdateText.Text = "";
            lastNameUpdateText.Text = "";
            emailAddressUpdateText.Text = "";
            phoneNumberUpdateText.Text = "";
        }


        private void Stergere_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void phoneNumberStergText_TextChanged(object sender, EventArgs e)
        {

        }

        private void lastNameStergText_TextChanged(object sender, EventArgs e)
        {

        }

        private void firstNameStergText_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataAccess db = new DataAccess();
            people = db.UpdatePerson(CNPUpdateText.Text,lastNameUpdateText.Text, firstNameUpdateText.Text, emailAddressUpdateText.Text, phoneNumberUpdateText.Text);
            if (people.Count() == 0) { textBoxUpdateText.Text = "nu exista persoana cu CNP-ul dat"; }
            else textBoxUpdateText.Text = ($"S-a actualizat persoana cu CNP-ul '{CNPUpdateText.Text}'");
            CNPUpdateText.Text = "";
            firstNameUpdateText.Text = "";
            lastNameUpdateText.Text = "";
            emailAddressUpdateText.Text = "";
            phoneNumberUpdateText.Text = "";

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void lastNameUpdateText_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void peopleFoundListbox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
