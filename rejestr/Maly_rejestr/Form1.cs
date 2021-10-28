using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;


namespace Maly_rejestr
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
            IFile objl = new Filee();
            objl.Load();
            user_look.LoadFile("plik.txt", RichTextBoxStreamType.PlainText);
            label1.Text = "Wczytano dane";
            label3.Text = Convert.ToString(Filee.How_much());
            Show_user(1);
        }

        public static int move = 1;
        public static int how_search = 0;

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        public void wyjdźToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show("Czy chcesz wyjść z aplikacji ?", "Komunikat", buttons);
            if (result == DialogResult.Yes)
                this.Close();
        }

        private void new_user_Click(object sender, EventArgs e)
        {
            string sex;
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show("Czy chcesz dodać użytkownika ?", "Komunikat", buttons);
            if (result == DialogResult.Yes)
            {
                if (male.Checked)
                {
                    sex = "Mezczyzna";
                    add_user();

                }
                else if (female.Checked)
                {
                    sex = "Kobieta";
                    add_user();
                }
                else
                    MessageBox.Show("Brak płci");
                 void add_user() 
                {
                    if ((name.Text == "") || (surname.Text == "") || (age.Text == "") || (code.Text == "") || (city.Text == "") || (street.Text == "") || (home.Text == ""))
                    {
                        MessageBox.Show("Brak kompletu danych");
                    }
                    else
                    {
                        Filee.New_user(name.Text, surname.Text, age.Text, sex, code.Text, city.Text, street.Text, home.Text, apartment.Text);
                        MessageBox.Show("Zapisane dane");
                        user_look.LoadFile("plik.txt", RichTextBoxStreamType.PlainText);
                        label3.Text = Convert.ToString(Filee.How_much());
                        move = 1;
                        Show_user(1);

                        name.Text = "";
                        surname.Text = "";
                        age.Text = "";
                        male.Checked = false;
                        female.Checked = false;
                        code.Text = "";
                        city.Text = "";
                        street.Text = "";
                        home.Text = "";
                        apartment.Text = "brak";
                        apartment.Visible = false;
                    }
                }
            }
        }

        private void go_left_Click(object sender, EventArgs e)
        {
            if (move <= 0)
            {
                Show_user(1);
                move = 1;
            }
            else if (move == 1)
            {
                Show_user(move);
            }
            else if (move > 1)
            {
                move--;
                Show_user(move);
            }
        }

        private void go_right_Click(object sender, EventArgs e)
        {
            if (move <= 0)
            {
                Show_user(1);
                move = 1;
            }
            else if (move == 1)
            {
                move++;
                Show_user(move);
            }
            else if (move > 1)
            {
                move++;
                Show_user(move);
            }
        }
        public void Show_user(int lr)
        {
            Color_user("Blue");
            name_look.Text = Filee.tab[lr, 1];
            surname_look.Text = Filee.tab[lr, 2];
            age_look.Text = Filee.tab[lr, 3];
            if (Filee.tab[lr, 4] == "Mezczyzna")
            {
                male_show.Checked = true;
                male_show.Enabled = true;
                female_show.Checked = false;
            }
            else if (Filee.tab[lr, 4] == "Kobieta")
            {
                female_show.Checked = true;
                female_show.Enabled = true;
                male_show.Checked = false;
            }
            else
            {
                if (Filee.tab[lr - 1, 4] == "Kobieta")
                {
                    female_show.Checked = false;
                    female_show.Enabled = false;
                    male_show.Checked = false;
                    male_show.Enabled = false;
                }
                else
                {
                    male_show.Checked = false;
                    male_show.Enabled = false;
                    female_show.Checked = false;
                    female_show.Enabled = false;
                }
            }
            code_look.Text = Filee.tab[lr, 5];
            city_look.Text = Filee.tab[lr, 6];
            street_look.Text = Filee.tab[lr, 7];
            home_look.Text = Filee.tab[lr, 8];
            apartment_look.Text = Filee.tab[lr, 9];
            if (Filee.tab[lr, 1] != null)
            {
                mode.Enabled = true;
                delete_user.Enabled = true;
                user_number.Text = ("Użytkownik nr: ");
                user_number_search.Text = (lr.ToString());
            }
            else
            {
                mode.Enabled = false;
                delete_user.Enabled = false;
                user_number.Text = ("Brak użytkownika");
                user_number_search.Text = ("");
                Color_user("Red");
            }
        }
        public void Color_user(string color)
        {
            if (color == "Blue")
            {
                user_number_search.BackColor = SystemColors.ActiveCaption;
                name_look.BackColor = SystemColors.ActiveCaption;
                surname_look.BackColor = SystemColors.ActiveCaption;
                age_look.BackColor = SystemColors.ActiveCaption;
                code_look.BackColor = SystemColors.ActiveCaption;
                city_look.BackColor = SystemColors.ActiveCaption;
                street_look.BackColor = SystemColors.ActiveCaption;
                home_look.BackColor = SystemColors.ActiveCaption;
                apartment_look.BackColor = SystemColors.ActiveCaption;
            }
            else if (color == "Red")
            {
                user_number_search.BackColor = Color.Red;
                name_look.BackColor = Color.Red;
                surname_look.BackColor = Color.Red;
                age_look.BackColor = Color.Red;
                code_look.BackColor = Color.Red;
                city_look.BackColor = Color.Red;
                street_look.BackColor = Color.Red;
                home_look.BackColor = Color.Red;
                apartment_look.BackColor = Color.Red;
            }
        }

        public static void Search_user(string item)
        {
            string s2;
            how_search = 0;
            bool b = true;
            for (int i = 0; i < 1000; i++)
            {
                for (int j = 0; j < 1000; j++)
                {
                    if ((Filee.tab[i, j] != null) && (b == Filee.tab[i, j].ToLower().Contains(item.ToLower())))
                    {
                        s2 = ("Wyszukano użytkownika: \n\n" +
                              "Numer użytkownika: " + i + "\n" +
                              "Imię: " + Filee.tab[i, 1] + "\n" +
                              "Nazwisko: " + Filee.tab[i, 2] + "\n" +
                              "Wiek: " + Filee.tab[i, 3] + "\n" +
                              "Płeć: " + Filee.tab[i, 4] + "\n" +
                              "Kod pocztowy: " + Filee.tab[i, 5] + "\n" +
                              "Miasto: " + Filee.tab[i, 6] + "\n" +
                              "Ulica: " + Filee.tab[i, 7] + "\n" +
                              "Numer domu: " + Filee.tab[i, 8] + "\n" +
                              "Numer mieszkania: " + Filee.tab[i, 9] + "\n");
                        MessageBox.Show(s2);
                        how_search++;
                    }

                }
            }
        }
        private void mode_Click(object sender, EventArgs e)
        {
            string sex_look;
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show("Czy chcesz zmodyfikować dane ?", "Komunikat", buttons);
            if (result == DialogResult.Yes)
            {
                if (male_show.Checked)
                {
                    sex_look = "Mezczyzna";
                    mode_user();

                }
                else if (female_show.Checked)
                {
                    sex_look = "Kobieta";
                    mode_user();
                }
                else
                    MessageBox.Show("Brak płci");
                void mode_user()
                {
                    if ((name_look.Text == "") || (surname_look.Text == "") || (age_look.Text == "") || (code_look.Text == "") || (city_look.Text == "") || (street_look.Text == "") || (home_look.Text == ""))
                    {
                        MessageBox.Show("Brak kompletu danych");
                    }
                    else
                        Filee.Modify(name_look.Text, surname_look.Text, age_look.Text, sex_look, code_look.Text, city_look.Text, street_look.Text, home_look.Text, apartment_look.Text, move);
                    user_look.LoadFile("plik.txt", RichTextBoxStreamType.PlainText);
                }
            }
        }
        private void delete_user_Click(object sender, EventArgs e)
        {
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show("Czy chcesz usunąć dane ?", "Komunikat", buttons);
            if (result == DialogResult.Yes)
            {
                Filee.Delete(move);
                MessageBox.Show("Zapisane dane");
                user_look.LoadFile("plik.txt", RichTextBoxStreamType.PlainText);
                label3.Text = Convert.ToString(Filee.How_much());
                move = 1;
                Show_user(1);
            }
        }
        private void search_Click(object sender, EventArgs e)
        {
            if (show_search.Text == "")
                MessageBox.Show("Wpisz dane do wyszukania");
            else
                Search_user(show_search.Text);
            if (how_search != 1)
                search_info.Text = ("Wyszukano: \n" + how_search + " użytkowników");
            else
                search_info.Text = ("Wyszukano: \n" + how_search + " użytkownika");

            show_search.Text = "";
        }
        
        private void code_TextChanged(object sender, EventArgs e)
        {            
            if (System.Text.RegularExpressions.Regex.IsMatch(code.Text, "[^0-9]"))
            {
                if (code.Text != "")
                {
                    MessageBox.Show("Użyj cyfr w formacie : 00000");
                    code.Text = code.Text.Remove(code.Text.Length - 1);
                }
            }
        }
        private void name_TextChanged(object sender, EventArgs e)
        {
            if (!System.Text.RegularExpressions.Regex.IsMatch(name.Text, "^[a-zA-Z ]"))
            {
                if (name.Text != "")
                {
                    MessageBox.Show("Użyj tylko liter");
                    name.Text = name.Text.Remove(name.Text.Length - 1);
                }
            }
        }
        private void surname_TextChanged(object sender, EventArgs e)
        {
            if (!System.Text.RegularExpressions.Regex.IsMatch(surname.Text, "^[a-zA-Z ]"))
            {
                if (surname.Text != "")
                {
                    MessageBox.Show("Użyj tylko liter");
                    surname.Text = surname.Text.Remove(surname.Text.Length - 1);
                }
            }
        }
        private void age_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(age.Text, "[^0-9]"))
            {
                if (age.Text != "")
                {
                    MessageBox.Show("Użyj tylko cyfr");
                    age.Text = age.Text.Remove(age.Text.Length - 1);
                }
            }
        }
        private void city_TextChanged(object sender, EventArgs e)
        {
            if (!System.Text.RegularExpressions.Regex.IsMatch(city.Text, "^[a-zA-Z ]"))
            {
                if (city.Text != "")
                {
                    MessageBox.Show("Użyj tylko liter");
                    city.Text = city.Text.Remove(city.Text.Length - 1);
                }
            }
        }
        private void home_TextChanged(object sender, EventArgs e)
        {
            if (home.Text != "")
            {
                Num_apart.Visible = true;
                apartment.Visible = true;
            }
        }
        public void name_look_TextChanged(object sender, EventArgs e)
        {
            if (!System.Text.RegularExpressions.Regex.IsMatch(name_look.Text, "^[a-zA-Z ]"))
            {
                if (name_look.Text != "")
                {
                    MessageBox.Show("Użyj tylko liter");
                    name_look.Text = name_look.Text.Remove(name_look.Text.Length - 1);
                }
            }
        }
        private void surname_look_TextChanged(object sender, EventArgs e)
        {
            if (!System.Text.RegularExpressions.Regex.IsMatch(surname_look.Text, "^[a-zA-Z ]"))
            {
                if (surname_look.Text != "")
                {
                    MessageBox.Show("Użyj tylko liter");
                    surname_look.Text = surname_look.Text.Remove(surname_look.Text.Length - 1);
                }
            }
        }
        private void age_look_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(age_look.Text, "[^0-9]"))
            {
                if (age_look.Text != "")
                {
                    MessageBox.Show("Użyj tylko cyfr");
                    age_look.Text = age_look.Text.Remove(age_look.Text.Length - 1);
                }
            }
        }
        private void code_look_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(code_look.Text, "[^0-9]"))
            {
                if (code_look.Text != "")
                {
                    MessageBox.Show("Użyj cyfr w formacie : 00000");
                    code_look.Text = code_look.Text.Remove(code_look.Text.Length - 1);
                }
            }
        }
        private void city_look_TextChanged(object sender, EventArgs e)
        {
            if (!System.Text.RegularExpressions.Regex.IsMatch(city_look.Text, "^[a-zA-Z ]"))
            {
                if (city_look.Text != "")
                {
                    MessageBox.Show("Użyj tylko liter");
                    city_look.Text = city_look.Text.Remove(city_look.Text.Length - 1);
                }
            }
        }
        private void male_CheckedChanged(object sender, EventArgs e)
        {
            if (male.Checked == true)
                female.Enabled = false;
            else
                female.Enabled = true;                
        }
        private void female_CheckedChanged(object sender, EventArgs e)
        {
            if (female.Checked == true)
                male.Enabled = false;
            else
                male.Enabled = true;
        }
        private void male_show_CheckedChanged(object sender, EventArgs e)
        {
            if (male_show.Checked == true)
                female_show.Enabled = false;
            else
                female_show.Enabled = true;
        }
        private void female_show_CheckedChanged(object sender, EventArgs e)
        {
            if (female_show.Checked == true)
                male_show.Enabled = false;
            else
                male_show.Enabled = true;
        }
        private void user_number_search_TextChanged(object sender, EventArgs e)
        {
            if (user_number_search.Text != "")
            {
                try
                {
                    int numVal = Int32.Parse(user_number_search.Text);
                    Show_user(numVal);
                    move = numVal;
                }
                catch (FormatException)
                {
                    MessageBox.Show("Wpisz poprawnie numer użytkonika");
                }
            }
        }

        private void dodajDaneToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
        private void user_look_TextChanged(object sender, EventArgs e)
        {

        }
        private void label3_Click(object sender, EventArgs e)
        {
        }
        private void sex_TextChanged(object sender, EventArgs e)
        {

        }
        private void street_TextChanged(object sender, EventArgs e)
        {
        }
        private void apartment_TextChanged(object sender, EventArgs e)
        {

        }
        private void sex_look_TextChanged(object sender, EventArgs e)
        {

        }
        private void street_look_TextChanged(object sender, EventArgs e)
        {

        }
        private void home_look_TextChanged(object sender, EventArgs e)
        {

        }
        private void apartment_look_TextChanged(object sender, EventArgs e)
        {

        }
        public void user_number_Click(object sender, EventArgs e)
        {

        }
        private void show_search_TextChanged(object sender, EventArgs e)
        {

        }
        public void search_info_Click(object sender, EventArgs e)
        {
        }
        private void label7_Click(object sender, EventArgs e)
        {

        }
        private void Num_apart_Click(object sender, EventArgs e)
        {

        }
        private void label23_Click(object sender, EventArgs e)
        {

        }

    }
}

