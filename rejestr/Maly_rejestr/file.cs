using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;


namespace Maly_rejestr
{
        interface IFile
        {
            void Save();
            void Clear();
            void Load();
        }

    class Filee : IFile
    {
        public static string[,] tab = new string[1000, 1000];
        public static int position = 1;
        public static int count = 1;

        public void Load()
        {
            if (!File.Exists("plik.txt"))
            {
                Backup();
                DialogResult result = MessageBox.Show("Brak danych wejściowych !", "Błąd krytyczny - włącz ponownie aplikację", MessageBoxButtons.AbortRetryIgnore, MessageBoxIcon.Warning);

                if (result == DialogResult.Abort)
                {
                    MessageBox.Show("Wyłącz aplikację !");
                }
                else if(result == DialogResult.Retry) 
                {
                    MessageBox.Show("Włącz ponownie aplikację !");
                }
                else if (result == DialogResult.Ignore)
                {
                    MessageBox.Show("Włącz ponownie aplikację !");
                }
            }
            else
            {
                foreach (string line in File.ReadLines("plik.txt"))
                {
                    tab[position, count] = line;
                    if (count == 9)
                    {
                        position++;
                        count = 0;
                    }
                    count++;
                }
            }          
        }
        public static void Backup()
        {
            string[,] tab_crush = new string[4,9]{ { "Anna", "Nowak", "23", "Kobieta", "53098", "Poznan", "Poznanska", "23A", "60",}, { "Krzysztof", "Nowak", "44", "Mezczyzna", "98798", "Warszawa", "Warszawska", "43", "66G", },{ "Pawel", "Da", "12", "Mezczyzna", "09809", "Gdansk", "Gdanska", "44", "44h", }, { "Zosia", "Iksinska", "88", "Kobieta", "35435", "Wroclaw", "Wroclawska", "77", "brak", } };
            using (FileStream filee = File.Create("plik.txt"))
            using (StreamWriter writer = new StreamWriter(filee))
            {
                foreach (string elem in tab_crush)
                {
                    if (elem != null)
                    {
                        writer.WriteLine(elem);
                    }
                }
            }
        }
        public  void Save()
        {
            using (FileStream filee = File.Create("plik.txt"))
            using (StreamWriter writer = new StreamWriter(filee))
            {
                foreach (string elem in tab)
                {
                    if (elem != null)
                    {
                        writer.WriteLine(elem);
                    }
                }
            }
        }
        public  void Clear()
        {
            for (int i =0; i <1000; i++)
            {
                for (int j = 0;j <1000; j++)
                {
                    tab[i, j] = null;
                }
            }
            position = 1;
            count = 1;
        }

        public static void Refresh()
        {
            IFile obj_s = new Filee();
            obj_s.Save();
            IFile obj_c = new Filee();
            obj_c.Clear();
            IFile obj_l = new Filee();
            obj_l.Load();          
        }

        public static int How_much()
        {
            int how = 0;
            for (int i = 0; i < 1000; i++)
            {
                for (int j = 0; j < 1000; j++)
                {
                    if (tab[i, j] != null)
                    {
                        how++;                   
                    }
                }
            }
            return how = how / 9;
        }

        public static void New_user(string name,string surname, string age,string sex, string code, string city,string street, string home, string apartment)
        {
            tab[position, 1] = name;
            tab[position, 2] = surname;
            tab[position, 3] = age;
            tab[position, 4] = sex;
            tab[position, 5] = code;
            tab[position, 6] = city;
            tab[position, 7] = street;
            tab[position, 8] = home;
            tab[position, 9] = apartment;
            position++;
            Refresh();
        }

        public static void Modify(string name, string surname, string age, string sex, string code, string city, string street, string home, string apartment, int lr)
        {
                tab[lr, 1] = name;
                tab[lr, 2] = surname;
                tab[lr, 3] = age;
                tab[lr, 4] = sex;
                tab[lr, 5] = code;
                tab[lr, 6] = city;
                tab[lr, 7] = street;
                tab[lr, 8] = home;
                tab[lr, 9] = apartment;
                Refresh();
                MessageBox.Show("Zmodyfikowano dane");            
        }
        public static void Delete(int lr)
        {
            
                tab[lr, 1] = null;
                tab[lr, 2] = null;
                tab[lr, 3] = null;
                tab[lr, 4] = null;
                tab[lr, 5] = null;
                tab[lr, 6] = null;
                tab[lr, 7] = null;
                tab[lr, 8] = null;
                tab[lr, 9] = null;
                Refresh();
                MessageBox.Show("Usunięto dane");           
        }
    }
}
