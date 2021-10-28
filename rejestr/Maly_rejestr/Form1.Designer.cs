
namespace Maly_rejestr
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.wyjdźToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.user_look = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.new_user = new System.Windows.Forms.Button();
            this.name = new System.Windows.Forms.TextBox();
            this.surname = new System.Windows.Forms.TextBox();
            this.age = new System.Windows.Forms.TextBox();
            this.city = new System.Windows.Forms.TextBox();
            this.apartment = new System.Windows.Forms.TextBox();
            this.home = new System.Windows.Forms.TextBox();
            this.code = new System.Windows.Forms.TextBox();
            this.street = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.street_look = new System.Windows.Forms.TextBox();
            this.code_look = new System.Windows.Forms.TextBox();
            this.home_look = new System.Windows.Forms.TextBox();
            this.apartment_look = new System.Windows.Forms.TextBox();
            this.city_look = new System.Windows.Forms.TextBox();
            this.age_look = new System.Windows.Forms.TextBox();
            this.surname_look = new System.Windows.Forms.TextBox();
            this.name_look = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.go_left = new System.Windows.Forms.Button();
            this.go_right = new System.Windows.Forms.Button();
            this.user_number = new System.Windows.Forms.Label();
            this.mode = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.delete_user = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.show_search = new System.Windows.Forms.TextBox();
            this.search = new System.Windows.Forms.Button();
            this.search_info = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.male = new System.Windows.Forms.CheckBox();
            this.female = new System.Windows.Forms.CheckBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.Num_apart = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.female_show = new System.Windows.Forms.CheckBox();
            this.male_show = new System.Windows.Forms.CheckBox();
            this.label23 = new System.Windows.Forms.Label();
            this.user_number_search = new System.Windows.Forms.TextBox();
            this.fileBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fileBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.wyjdźToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1193, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // wyjdźToolStripMenuItem
            // 
            this.wyjdźToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.wyjdźToolStripMenuItem.Name = "wyjdźToolStripMenuItem";
            this.wyjdźToolStripMenuItem.Size = new System.Drawing.Size(64, 24);
            this.wyjdźToolStripMenuItem.Text = "Wyjdź";
            this.wyjdźToolStripMenuItem.Click += new System.EventHandler(this.wyjdźToolStripMenuItem_Click);
            // 
            // user_look
            // 
            this.user_look.Location = new System.Drawing.Point(1064, 36);
            this.user_look.Name = "user_look";
            this.user_look.Size = new System.Drawing.Size(126, 362);
            this.user_look.TabIndex = 3;
            this.user_look.Text = "";
            this.user_look.TextChanged += new System.EventHandler(this.user_look_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(934, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 17);
            this.label1.TabIndex = 4;
            // 
            // new_user
            // 
            this.new_user.Location = new System.Drawing.Point(22, 50);
            this.new_user.Name = "new_user";
            this.new_user.Size = new System.Drawing.Size(283, 47);
            this.new_user.TabIndex = 5;
            this.new_user.Text = "Wprowadź użytkownika";
            this.new_user.UseVisualStyleBackColor = true;
            this.new_user.Click += new System.EventHandler(this.new_user_Click);
            // 
            // name
            // 
            this.name.Location = new System.Drawing.Point(22, 117);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(126, 22);
            this.name.TabIndex = 6;
            this.name.TextChanged += new System.EventHandler(this.name_TextChanged);
            // 
            // surname
            // 
            this.surname.Location = new System.Drawing.Point(22, 165);
            this.surname.Name = "surname";
            this.surname.Size = new System.Drawing.Size(126, 22);
            this.surname.TabIndex = 7;
            this.surname.TextChanged += new System.EventHandler(this.surname_TextChanged);
            // 
            // age
            // 
            this.age.Location = new System.Drawing.Point(22, 210);
            this.age.MaxLength = 3;
            this.age.Name = "age";
            this.age.Size = new System.Drawing.Size(126, 22);
            this.age.TabIndex = 8;
            this.age.TextChanged += new System.EventHandler(this.age_TextChanged);
            // 
            // city
            // 
            this.city.Location = new System.Drawing.Point(179, 165);
            this.city.Name = "city";
            this.city.Size = new System.Drawing.Size(126, 22);
            this.city.TabIndex = 10;
            this.city.TextChanged += new System.EventHandler(this.city_TextChanged);
            // 
            // apartment
            // 
            this.apartment.Location = new System.Drawing.Point(179, 317);
            this.apartment.Name = "apartment";
            this.apartment.Size = new System.Drawing.Size(126, 22);
            this.apartment.TabIndex = 11;
            this.apartment.Text = "brak";
            this.apartment.Visible = false;
            this.apartment.TextChanged += new System.EventHandler(this.apartment_TextChanged);
            // 
            // home
            // 
            this.home.Location = new System.Drawing.Point(179, 256);
            this.home.Name = "home";
            this.home.Size = new System.Drawing.Size(126, 22);
            this.home.TabIndex = 12;
            this.home.TextChanged += new System.EventHandler(this.home_TextChanged);
            // 
            // code
            // 
            this.code.Location = new System.Drawing.Point(179, 117);
            this.code.MaxLength = 5;
            this.code.Name = "code";
            this.code.Size = new System.Drawing.Size(126, 22);
            this.code.TabIndex = 13;
            this.code.TextChanged += new System.EventHandler(this.code_TextChanged);
            // 
            // street
            // 
            this.street.Location = new System.Drawing.Point(179, 210);
            this.street.Name = "street";
            this.street.Size = new System.Drawing.Size(126, 22);
            this.street.TabIndex = 14;
            this.street.TextChanged += new System.EventHandler(this.street_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(821, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 17);
            this.label3.TabIndex = 16;
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // street_look
            // 
            this.street_look.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.street_look.Location = new System.Drawing.Point(499, 314);
            this.street_look.Name = "street_look";
            this.street_look.Size = new System.Drawing.Size(146, 22);
            this.street_look.TabIndex = 25;
            this.street_look.Text = "Ulica";
            this.street_look.TextChanged += new System.EventHandler(this.street_look_TextChanged);
            // 
            // code_look
            // 
            this.code_look.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.code_look.Location = new System.Drawing.Point(499, 258);
            this.code_look.MaxLength = 5;
            this.code_look.Name = "code_look";
            this.code_look.Size = new System.Drawing.Size(146, 22);
            this.code_look.TabIndex = 24;
            this.code_look.Text = "Kod pocztowy";
            this.code_look.TextChanged += new System.EventHandler(this.code_look_TextChanged);
            // 
            // home_look
            // 
            this.home_look.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.home_look.Location = new System.Drawing.Point(499, 342);
            this.home_look.Name = "home_look";
            this.home_look.Size = new System.Drawing.Size(146, 22);
            this.home_look.TabIndex = 23;
            this.home_look.Text = "Nr domu";
            this.home_look.TextChanged += new System.EventHandler(this.home_look_TextChanged);
            // 
            // apartment_look
            // 
            this.apartment_look.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.apartment_look.Location = new System.Drawing.Point(499, 370);
            this.apartment_look.Name = "apartment_look";
            this.apartment_look.Size = new System.Drawing.Size(146, 22);
            this.apartment_look.TabIndex = 22;
            this.apartment_look.Text = "Nr mieszkania";
            this.apartment_look.TextChanged += new System.EventHandler(this.apartment_look_TextChanged);
            // 
            // city_look
            // 
            this.city_look.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.city_look.Location = new System.Drawing.Point(499, 286);
            this.city_look.Name = "city_look";
            this.city_look.Size = new System.Drawing.Size(146, 22);
            this.city_look.TabIndex = 21;
            this.city_look.Text = "Miasto";
            this.city_look.TextChanged += new System.EventHandler(this.city_look_TextChanged);
            // 
            // age_look
            // 
            this.age_look.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.age_look.Location = new System.Drawing.Point(499, 173);
            this.age_look.MaxLength = 3;
            this.age_look.Name = "age_look";
            this.age_look.Size = new System.Drawing.Size(146, 22);
            this.age_look.TabIndex = 19;
            this.age_look.Text = "Wiek";
            this.age_look.TextChanged += new System.EventHandler(this.age_look_TextChanged);
            // 
            // surname_look
            // 
            this.surname_look.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.surname_look.Location = new System.Drawing.Point(499, 145);
            this.surname_look.Name = "surname_look";
            this.surname_look.Size = new System.Drawing.Size(146, 22);
            this.surname_look.TabIndex = 18;
            this.surname_look.Text = "Nazwisko";
            this.surname_look.TextChanged += new System.EventHandler(this.surname_look_TextChanged);
            // 
            // name_look
            // 
            this.name_look.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.name_look.Location = new System.Drawing.Point(499, 117);
            this.name_look.Name = "name_look";
            this.name_look.Size = new System.Drawing.Size(146, 22);
            this.name_look.TabIndex = 17;
            this.name_look.Text = "Imie";
            this.name_look.TextChanged += new System.EventHandler(this.name_look_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label4.Location = new System.Drawing.Point(499, 36);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(151, 19);
            this.label4.TabIndex = 26;
            this.label4.Text = "Podgląd użytkowników";
            // 
            // go_left
            // 
            this.go_left.Location = new System.Drawing.Point(499, 60);
            this.go_left.Name = "go_left";
            this.go_left.Size = new System.Drawing.Size(75, 23);
            this.go_left.TabIndex = 27;
            this.go_left.Text = "<=";
            this.go_left.UseVisualStyleBackColor = true;
            this.go_left.Click += new System.EventHandler(this.go_left_Click);
            // 
            // go_right
            // 
            this.go_right.Location = new System.Drawing.Point(570, 60);
            this.go_right.Name = "go_right";
            this.go_right.Size = new System.Drawing.Size(75, 23);
            this.go_right.TabIndex = 28;
            this.go_right.Text = "=>";
            this.go_right.UseVisualStyleBackColor = true;
            this.go_right.Click += new System.EventHandler(this.go_right_Click);
            // 
            // user_number
            // 
            this.user_number.AutoSize = true;
            this.user_number.Location = new System.Drawing.Point(496, 91);
            this.user_number.Name = "user_number";
            this.user_number.Size = new System.Drawing.Size(103, 17);
            this.user_number.TabIndex = 29;
            this.user_number.Text = "Użytkownik nr: ";
            this.user_number.Click += new System.EventHandler(this.user_number_Click);
            // 
            // mode
            // 
            this.mode.Location = new System.Drawing.Point(689, 117);
            this.mode.Name = "mode";
            this.mode.Size = new System.Drawing.Size(193, 50);
            this.mode.TabIndex = 30;
            this.mode.Text = "Zmodyfikuj dane użytkownika";
            this.mode.UseVisualStyleBackColor = true;
            this.mode.Click += new System.EventHandler(this.mode_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(659, 134);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(24, 17);
            this.label5.TabIndex = 31;
            this.label5.Text = "<=";
            // 
            // delete_user
            // 
            this.delete_user.Location = new System.Drawing.Point(689, 187);
            this.delete_user.Name = "delete_user";
            this.delete_user.Size = new System.Drawing.Size(193, 50);
            this.delete_user.TabIndex = 32;
            this.delete_user.Text = "Usuń użytkownika";
            this.delete_user.UseVisualStyleBackColor = true;
            this.delete_user.Click += new System.EventHandler(this.delete_user_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(659, 201);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(24, 17);
            this.label6.TabIndex = 33;
            this.label6.Text = "<=";
            // 
            // show_search
            // 
            this.show_search.Location = new System.Drawing.Point(707, 324);
            this.show_search.Name = "show_search";
            this.show_search.Size = new System.Drawing.Size(160, 22);
            this.show_search.TabIndex = 34;
            this.show_search.TextChanged += new System.EventHandler(this.show_search_TextChanged);
            // 
            // search
            // 
            this.search.Location = new System.Drawing.Point(689, 271);
            this.search.Name = "search";
            this.search.Size = new System.Drawing.Size(193, 47);
            this.search.TabIndex = 35;
            this.search.Text = "Wyszukaj użytkownika";
            this.search.UseVisualStyleBackColor = true;
            this.search.Click += new System.EventHandler(this.search_Click);
            // 
            // search_info
            // 
            this.search_info.AutoSize = true;
            this.search_info.Location = new System.Drawing.Point(704, 349);
            this.search_info.Name = "search_info";
            this.search_info.Size = new System.Drawing.Size(89, 17);
            this.search_info.TabIndex = 37;
            this.search_info.Text = "Wyszukano :";
            this.search_info.Click += new System.EventHandler(this.search_info_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(686, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 17);
            this.label2.TabIndex = 15;
            this.label2.Text = "Ilość użytkowników:";
            // 
            // male
            // 
            this.male.AutoSize = true;
            this.male.Location = new System.Drawing.Point(22, 239);
            this.male.Name = "male";
            this.male.Size = new System.Drawing.Size(100, 21);
            this.male.TabIndex = 38;
            this.male.Text = "Mężczyzna";
            this.male.UseVisualStyleBackColor = true;
            this.male.CheckedChanged += new System.EventHandler(this.male_CheckedChanged);
            // 
            // female
            // 
            this.female.AutoSize = true;
            this.female.Location = new System.Drawing.Point(22, 266);
            this.female.Name = "female";
            this.female.Size = new System.Drawing.Size(78, 21);
            this.female.TabIndex = 39;
            this.female.Text = "Kobieta";
            this.female.UseVisualStyleBackColor = true;
            this.female.CheckedChanged += new System.EventHandler(this.female_CheckedChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(19, 190);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(43, 17);
            this.label7.TabIndex = 40;
            this.label7.Text = "Wiek:";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(19, 97);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(37, 17);
            this.label8.TabIndex = 41;
            this.label8.Text = "Imię:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(19, 145);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(71, 17);
            this.label9.TabIndex = 42;
            this.label9.Text = "Nazwisko:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(176, 97);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(99, 17);
            this.label10.TabIndex = 43;
            this.label10.Text = "Kod pocztowy:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(176, 145);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(53, 17);
            this.label11.TabIndex = 44;
            this.label11.Text = "Miasto:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(176, 190);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(43, 17);
            this.label12.TabIndex = 45;
            this.label12.Text = "Ulica:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(176, 236);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(93, 17);
            this.label13.TabIndex = 46;
            this.label13.Text = "Numer domu:";
            // 
            // Num_apart
            // 
            this.Num_apart.AutoSize = true;
            this.Num_apart.Location = new System.Drawing.Point(176, 281);
            this.Num_apart.Name = "Num_apart";
            this.Num_apart.Size = new System.Drawing.Size(132, 34);
            this.Num_apart.TabIndex = 47;
            this.Num_apart.Text = "Numer mieszkania: \n (opcjonalne)";
            this.Num_apart.Visible = false;
            this.Num_apart.Click += new System.EventHandler(this.Num_apart_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(361, 120);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(37, 17);
            this.label14.TabIndex = 48;
            this.label14.Text = "Imię:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(361, 148);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(71, 17);
            this.label15.TabIndex = 49;
            this.label15.Text = "Nazwisko:";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(361, 176);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(43, 17);
            this.label16.TabIndex = 50;
            this.label16.Text = "Wiek:";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(361, 204);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(39, 17);
            this.label17.TabIndex = 51;
            this.label17.Text = "Płeć:";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(361, 261);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(99, 17);
            this.label18.TabIndex = 52;
            this.label18.Text = "Kod pocztowy:";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(361, 289);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(53, 17);
            this.label19.TabIndex = 53;
            this.label19.Text = "Miasto:";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(361, 317);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(43, 17);
            this.label20.TabIndex = 54;
            this.label20.Text = "Ulica:";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(361, 345);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(93, 17);
            this.label21.TabIndex = 55;
            this.label21.Text = "Numer domu:";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(361, 373);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(132, 17);
            this.label22.TabIndex = 56;
            this.label22.Text = "Numer mieszkania: ";
            // 
            // female_show
            // 
            this.female_show.AutoSize = true;
            this.female_show.Location = new System.Drawing.Point(499, 231);
            this.female_show.Name = "female_show";
            this.female_show.Size = new System.Drawing.Size(78, 21);
            this.female_show.TabIndex = 58;
            this.female_show.Text = "Kobieta";
            this.female_show.UseVisualStyleBackColor = true;
            this.female_show.CheckedChanged += new System.EventHandler(this.female_show_CheckedChanged);
            // 
            // male_show
            // 
            this.male_show.AutoSize = true;
            this.male_show.Location = new System.Drawing.Point(499, 204);
            this.male_show.Name = "male_show";
            this.male_show.Size = new System.Drawing.Size(100, 21);
            this.male_show.TabIndex = 57;
            this.male_show.Text = "Mężczyzna";
            this.male_show.UseVisualStyleBackColor = true;
            this.male_show.CheckedChanged += new System.EventHandler(this.male_show_CheckedChanged);
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(934, 67);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(122, 17);
            this.label23.TabIndex = 59;
            this.label23.Text = "Podgląd w plik  =>";
            this.label23.Click += new System.EventHandler(this.label23_Click);
            // 
            // user_number_search
            // 
            this.user_number_search.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.user_number_search.Location = new System.Drawing.Point(616, 88);
            this.user_number_search.Name = "user_number_search";
            this.user_number_search.Size = new System.Drawing.Size(29, 22);
            this.user_number_search.TabIndex = 60;
            this.user_number_search.TextChanged += new System.EventHandler(this.user_number_search_TextChanged);
            // 
            // fileBindingSource
            // 
            //this.fileBindingSource.DataSource = typeof(Maly_rejestr.Filee);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1193, 420);
            this.Controls.Add(this.user_number_search);
            this.Controls.Add(this.label23);
            this.Controls.Add(this.female_show);
            this.Controls.Add(this.male_show);
            this.Controls.Add(this.label22);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.Num_apart);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.female);
            this.Controls.Add(this.male);
            this.Controls.Add(this.search_info);
            this.Controls.Add(this.search);
            this.Controls.Add(this.show_search);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.delete_user);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.mode);
            this.Controls.Add(this.user_number);
            this.Controls.Add(this.go_right);
            this.Controls.Add(this.go_left);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.street_look);
            this.Controls.Add(this.code_look);
            this.Controls.Add(this.home_look);
            this.Controls.Add(this.apartment_look);
            this.Controls.Add(this.city_look);
            this.Controls.Add(this.age_look);
            this.Controls.Add(this.surname_look);
            this.Controls.Add(this.name_look);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.street);
            this.Controls.Add(this.code);
            this.Controls.Add(this.home);
            this.Controls.Add(this.apartment);
            this.Controls.Add(this.city);
            this.Controls.Add(this.age);
            this.Controls.Add(this.surname);
            this.Controls.Add(this.name);
            this.Controls.Add(this.new_user);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.user_look);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fileBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem wyjdźToolStripMenuItem;
        private System.Windows.Forms.RichTextBox user_look;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button new_user;
        private System.Windows.Forms.TextBox name;
        private System.Windows.Forms.TextBox surname;
        private System.Windows.Forms.TextBox age;
        private System.Windows.Forms.TextBox city;
        private System.Windows.Forms.TextBox apartment;
        private System.Windows.Forms.TextBox home;
        private System.Windows.Forms.TextBox code;
        private System.Windows.Forms.TextBox street;
        private System.Windows.Forms.BindingSource fileBindingSource;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox street_look;
        private System.Windows.Forms.TextBox code_look;
        private System.Windows.Forms.TextBox home_look;
        private System.Windows.Forms.TextBox apartment_look;
        private System.Windows.Forms.TextBox city_look;
        private System.Windows.Forms.TextBox age_look;
        private System.Windows.Forms.TextBox surname_look;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button go_left;
        private System.Windows.Forms.Button go_right;
        public System.Windows.Forms.TextBox name_look;
        public System.Windows.Forms.Label user_number;
        private System.Windows.Forms.Button mode;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button delete_user;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox show_search;
        private System.Windows.Forms.Button search;
        private System.Windows.Forms.Label search_info;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox male;
        private System.Windows.Forms.CheckBox female;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label Num_apart;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.CheckBox female_show;
        private System.Windows.Forms.CheckBox male_show;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.TextBox user_number_search;
    }
}

