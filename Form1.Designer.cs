namespace BandManagerApp
{
    partial class BandManager
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.panel1 = new System.Windows.Forms.Panel();
            this.roleTextBox = new System.Windows.Forms.TextBox();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.addbutton = new System.Windows.Forms.Button();
            this.bandlistBox = new System.Windows.Forms.ListBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.deletebutton = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.concertlistBox = new System.Windows.Forms.ListBox();
            this.registerbutton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.concertCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.panel3 = new System.Windows.Forms.Panel();
            this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.numericUpDown3 = new System.Windows.Forms.NumericUpDown();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.button4 = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panel5 = new System.Windows.Forms.Panel();
            this.button6 = new System.Windows.Forms.Button();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.panel6 = new System.Windows.Forms.Panel();
            this.labelBandManager = new System.Windows.Forms.Label();
            this.membersBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.databaseDataSet1 = new BandManagerApp.DatabaseDataSet1();
            this.membersTableAdapter1 = new BandManagerApp.DatabaseDataSet1TableAdapters.MembersTableAdapter();
            this.tableAdapterManager1 = new BandManagerApp.DatabaseDataSet1TableAdapters.TableAdapterManager();
            this.bandlistBox2 = new System.Windows.Forms.ListBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.membersBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.AntiqueWhite;
            this.panel1.Controls.Add(this.bandlistBox2);
            this.panel1.Controls.Add(this.roleTextBox);
            this.panel1.Controls.Add(this.nameTextBox);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.addbutton);
            this.panel1.Controls.Add(this.bandlistBox);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(369, 205);
            this.panel1.TabIndex = 0;
            // 
            // roleTextBox
            // 
            this.roleTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.membersBindingSource1, "Role", true));
            this.roleTextBox.Location = new System.Drawing.Point(179, 179);
            this.roleTextBox.Name = "roleTextBox";
            this.roleTextBox.Size = new System.Drawing.Size(100, 20);
            this.roleTextBox.TabIndex = 8;
            // 
            // nameTextBox
            // 
            this.nameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.membersBindingSource1, "Name", true));
            this.nameTextBox.Location = new System.Drawing.Point(5, 179);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(169, 20);
            this.nameTextBox.TabIndex = 7;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Tan;
            this.button3.Font = new System.Drawing.Font("BIZ UDPGothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.Red;
            this.button3.Location = new System.Drawing.Point(285, 4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 6;
            this.button3.Text = "Usuń";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("BIZ UDPGothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(177, 165);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 11);
            this.label2.TabIndex = 5;
            this.label2.Text = "Rola:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("BIZ UDPGothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 165);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 11);
            this.label1.TabIndex = 4;
            this.label1.Text = "Imię i Nazwisko";
            // 
            // addbutton
            // 
            this.addbutton.BackColor = System.Drawing.Color.Tan;
            this.addbutton.Font = new System.Drawing.Font("BIZ UDPGothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addbutton.Location = new System.Drawing.Point(285, 178);
            this.addbutton.Name = "addbutton";
            this.addbutton.Size = new System.Drawing.Size(75, 21);
            this.addbutton.TabIndex = 3;
            this.addbutton.Text = "Dodaj";
            this.addbutton.UseVisualStyleBackColor = false;
            this.addbutton.Click += new System.EventHandler(this.addbutton_Click);
            // 
            // bandlistBox
            // 
            this.bandlistBox.BackColor = System.Drawing.Color.AntiqueWhite;
            this.bandlistBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.bandlistBox.Font = new System.Drawing.Font("BIZ UDPGothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bandlistBox.FormattingEnabled = true;
            this.bandlistBox.ItemHeight = 11;
            this.bandlistBox.Location = new System.Drawing.Point(4, 4);
            this.bandlistBox.Name = "bandlistBox";
            this.bandlistBox.Size = new System.Drawing.Size(150, 143);
            this.bandlistBox.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Wheat;
            this.panel2.Controls.Add(this.comboBox1);
            this.panel2.Controls.Add(this.deletebutton);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.textBox2);
            this.panel2.Controls.Add(this.concertlistBox);
            this.panel2.Controls.Add(this.registerbutton);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.textBox1);
            this.panel2.Controls.Add(this.concertCalendar1);
            this.panel2.Location = new System.Drawing.Point(14, 223);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(550, 376);
            this.panel2.TabIndex = 1;
            // 
            // comboBox1
            // 
            this.comboBox1.BackColor = System.Drawing.Color.FloralWhite;
            this.comboBox1.Font = new System.Drawing.Font("BIZ UDPGothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(290, 86);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(99, 19);
            this.comboBox1.TabIndex = 11;
            // 
            // deletebutton
            // 
            this.deletebutton.BackColor = System.Drawing.Color.Tan;
            this.deletebutton.Font = new System.Drawing.Font("BIZ UDPGothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deletebutton.ForeColor = System.Drawing.Color.Red;
            this.deletebutton.Location = new System.Drawing.Point(444, 172);
            this.deletebutton.Name = "deletebutton";
            this.deletebutton.Size = new System.Drawing.Size(96, 25);
            this.deletebutton.TabIndex = 10;
            this.deletebutton.Text = "Usuń";
            this.deletebutton.UseVisualStyleBackColor = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("BIZ UDPGothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(288, 71);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 11);
            this.label5.TabIndex = 9;
            this.label5.Text = "Godzina";
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.Color.FloralWhite;
            this.textBox2.Font = new System.Drawing.Font("BIZ UDPGothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(396, 43);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 18);
            this.textBox2.TabIndex = 7;
            // 
            // concertlistBox
            // 
            this.concertlistBox.BackColor = System.Drawing.Color.OldLace;
            this.concertlistBox.Font = new System.Drawing.Font("BIZ UDPGothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.concertlistBox.FormattingEnabled = true;
            this.concertlistBox.ItemHeight = 11;
            this.concertlistBox.Location = new System.Drawing.Point(9, 203);
            this.concertlistBox.Name = "concertlistBox";
            this.concertlistBox.Size = new System.Drawing.Size(531, 158);
            this.concertlistBox.TabIndex = 6;
            // 
            // registerbutton
            // 
            this.registerbutton.BackColor = System.Drawing.Color.Tan;
            this.registerbutton.Font = new System.Drawing.Font("BIZ UDPGothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.registerbutton.Location = new System.Drawing.Point(396, 71);
            this.registerbutton.Name = "registerbutton";
            this.registerbutton.Size = new System.Drawing.Size(100, 36);
            this.registerbutton.TabIndex = 5;
            this.registerbutton.Text = "Zarejestruj";
            this.registerbutton.UseVisualStyleBackColor = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("BIZ UDPGothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(394, 29);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 11);
            this.label4.TabIndex = 4;
            this.label4.Text = "Miasto:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("BIZ UDPGothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(288, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 11);
            this.label3.TabIndex = 3;
            this.label3.Text = "Kraj:";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.FloralWhite;
            this.textBox1.Font = new System.Drawing.Font("BIZ UDPGothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(290, 43);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 18);
            this.textBox1.TabIndex = 2;
            // 
            // concertCalendar1
            // 
            this.concertCalendar1.BackColor = System.Drawing.Color.SandyBrown;
            this.concertCalendar1.Font = new System.Drawing.Font("BIZ UDPGothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.concertCalendar1.Location = new System.Drawing.Point(9, 9);
            this.concertCalendar1.Name = "concertCalendar1";
            this.concertCalendar1.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.NavajoWhite;
            this.panel3.Controls.Add(this.numericUpDown2);
            this.panel3.Controls.Add(this.numericUpDown1);
            this.panel3.Controls.Add(this.label8);
            this.panel3.Controls.Add(this.button2);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.button1);
            this.panel3.Controls.Add(this.textBox3);
            this.panel3.Controls.Add(this.listBox1);
            this.panel3.Location = new System.Drawing.Point(382, 12);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(385, 205);
            this.panel3.TabIndex = 2;
            // 
            // numericUpDown2
            // 
            this.numericUpDown2.BackColor = System.Drawing.Color.FloralWhite;
            this.numericUpDown2.Font = new System.Drawing.Font("BIZ UDPGothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDown2.Location = new System.Drawing.Point(150, 170);
            this.numericUpDown2.Name = "numericUpDown2";
            this.numericUpDown2.Size = new System.Drawing.Size(85, 18);
            this.numericUpDown2.TabIndex = 9;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.BackColor = System.Drawing.Color.FloralWhite;
            this.numericUpDown1.Font = new System.Drawing.Font("BIZ UDPGothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDown1.Location = new System.Drawing.Point(241, 170);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(48, 18);
            this.numericUpDown1.TabIndex = 2;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("BIZ UDPGothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(239, 156);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(47, 11);
            this.label8.TabIndex = 8;
            this.label8.Text = "Liczba:";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Tan;
            this.button2.Font = new System.Drawing.Font("BIZ UDPGothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(307, 153);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 5;
            this.button2.Text = "Dodaj";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("BIZ UDPGothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(148, 156);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(40, 11);
            this.label7.TabIndex = 4;
            this.label7.Text = "Cena:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("BIZ UDPGothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(3, 156);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 11);
            this.label6.TabIndex = 3;
            this.label6.Text = "Produkt:";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Tan;
            this.button1.Font = new System.Drawing.Font("BIZ UDPGothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Red;
            this.button1.Location = new System.Drawing.Point(307, 179);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Usuń";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // textBox3
            // 
            this.textBox3.BackColor = System.Drawing.Color.FloralWhite;
            this.textBox3.Font = new System.Drawing.Font("BIZ UDPGothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox3.Location = new System.Drawing.Point(5, 170);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(141, 18);
            this.textBox3.TabIndex = 1;
            // 
            // listBox1
            // 
            this.listBox1.BackColor = System.Drawing.Color.FloralWhite;
            this.listBox1.Font = new System.Drawing.Font("BIZ UDPGothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 11;
            this.listBox1.Location = new System.Drawing.Point(3, 3);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(379, 147);
            this.listBox1.TabIndex = 0;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Cornsilk;
            this.panel4.Controls.Add(this.numericUpDown3);
            this.panel4.Controls.Add(this.comboBox3);
            this.panel4.Controls.Add(this.label11);
            this.panel4.Controls.Add(this.button5);
            this.panel4.Controls.Add(this.label10);
            this.panel4.Controls.Add(this.comboBox2);
            this.panel4.Controls.Add(this.button4);
            this.panel4.Controls.Add(this.label9);
            this.panel4.Controls.Add(this.chart1);
            this.panel4.Location = new System.Drawing.Point(773, 12);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(399, 307);
            this.panel4.TabIndex = 3;
            // 
            // numericUpDown3
            // 
            this.numericUpDown3.BackColor = System.Drawing.Color.FloralWhite;
            this.numericUpDown3.Font = new System.Drawing.Font("BIZ UDPGothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDown3.Location = new System.Drawing.Point(123, 283);
            this.numericUpDown3.Name = "numericUpDown3";
            this.numericUpDown3.Size = new System.Drawing.Size(59, 18);
            this.numericUpDown3.TabIndex = 10;
            // 
            // comboBox3
            // 
            this.comboBox3.BackColor = System.Drawing.Color.FloralWhite;
            this.comboBox3.Font = new System.Drawing.Font("BIZ UDPGothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(188, 282);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(121, 19);
            this.comboBox3.TabIndex = 9;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("BIZ UDPGothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(188, 268);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(55, 11);
            this.label11.TabIndex = 8;
            this.label11.Text = "Miesiąc:";
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.Tan;
            this.button5.Font = new System.Drawing.Font("BIZ UDPGothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.Location = new System.Drawing.Point(6, 220);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(390, 39);
            this.button5.TabIndex = 7;
            this.button5.Text = "Generuj";
            this.button5.UseVisualStyleBackColor = false;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("BIZ UDPGothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(123, 268);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(47, 11);
            this.label10.TabIndex = 6;
            this.label10.Text = "Liczba:";
            // 
            // comboBox2
            // 
            this.comboBox2.BackColor = System.Drawing.Color.FloralWhite;
            this.comboBox2.Font = new System.Drawing.Font("BIZ UDPGothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(3, 282);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(114, 19);
            this.comboBox2.TabIndex = 4;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Tan;
            this.button4.Font = new System.Drawing.Font("BIZ UDPGothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(315, 265);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(81, 39);
            this.button4.TabIndex = 3;
            this.button4.Text = "Sprzedaż";
            this.button4.UseVisualStyleBackColor = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("BIZ UDPGothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(3, 267);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(56, 11);
            this.label9.TabIndex = 2;
            this.label9.Text = "Produkt:";
            // 
            // chart1
            // 
            this.chart1.BackColor = System.Drawing.Color.BurlyWood;
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.BackColor = System.Drawing.Color.PeachPuff;
            legend1.Font = new System.Drawing.Font("BIZ UDPGothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            legend1.IsTextAutoFit = false;
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(3, 4);
            this.chart1.Name = "chart1";
            this.chart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Chocolate;
            series1.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.DiagonalRight;
            series1.BackSecondaryColor = System.Drawing.Color.AntiqueWhite;
            series1.BorderColor = System.Drawing.Color.Black;
            series1.ChartArea = "ChartArea1";
            series1.Color = System.Drawing.Color.SaddleBrown;
            series1.Font = new System.Drawing.Font("BIZ UDPGothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            series1.Legend = "Legend1";
            series1.Name = "Dochody";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(393, 210);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.Peru;
            this.panel5.Controls.Add(this.button6);
            this.panel5.Controls.Add(this.textBox7);
            this.panel5.Location = new System.Drawing.Point(570, 325);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(602, 274);
            this.panel5.TabIndex = 4;
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.Tan;
            this.button6.Font = new System.Drawing.Font("BIZ UDPGothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.Location = new System.Drawing.Point(428, 240);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(170, 31);
            this.button6.TabIndex = 1;
            this.button6.Text = "Zapisz";
            this.button6.UseVisualStyleBackColor = false;
            // 
            // textBox7
            // 
            this.textBox7.BackColor = System.Drawing.Color.PapayaWhip;
            this.textBox7.Font = new System.Drawing.Font("BIZ UDPGothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox7.Location = new System.Drawing.Point(3, 3);
            this.textBox7.Multiline = true;
            this.textBox7.Name = "textBox7";
            this.textBox7.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox7.Size = new System.Drawing.Size(595, 231);
            this.textBox7.TabIndex = 0;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.panel6.Controls.Add(this.labelBandManager);
            this.panel6.Location = new System.Drawing.Point(570, 223);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(197, 96);
            this.panel6.TabIndex = 5;
            // 
            // labelBandManager
            // 
            this.labelBandManager.AutoSize = true;
            this.labelBandManager.Font = new System.Drawing.Font("BIZ UDPGothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBandManager.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.labelBandManager.Location = new System.Drawing.Point(18, 40);
            this.labelBandManager.Name = "labelBandManager";
            this.labelBandManager.Size = new System.Drawing.Size(159, 19);
            this.labelBandManager.TabIndex = 0;
            this.labelBandManager.Text = "Band Manager";
            // 
            // membersBindingSource1
            // 
            this.membersBindingSource1.DataMember = "Members";
            this.membersBindingSource1.DataSource = this.databaseDataSet1;
            // 
            // databaseDataSet1
            // 
            this.databaseDataSet1.DataSetName = "DatabaseDataSet1";
            this.databaseDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // membersTableAdapter1
            // 
            this.membersTableAdapter1.ClearBeforeFill = true;
            // 
            // tableAdapterManager1
            // 
            this.tableAdapterManager1.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager1.MembersTableAdapter = this.membersTableAdapter1;
            this.tableAdapterManager1.UpdateOrder = BandManagerApp.DatabaseDataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // bandlistBox2
            // 
            this.bandlistBox2.BackColor = System.Drawing.Color.AntiqueWhite;
            this.bandlistBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.bandlistBox2.Font = new System.Drawing.Font("BIZ UDPGothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bandlistBox2.FormattingEnabled = true;
            this.bandlistBox2.ItemHeight = 11;
            this.bandlistBox2.Location = new System.Drawing.Point(160, 4);
            this.bandlistBox2.Name = "bandlistBox2";
            this.bandlistBox2.Size = new System.Drawing.Size(120, 143);
            this.bandlistBox2.TabIndex = 9;
            // 
            // BandManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 611);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.Name = "BandManager";
            this.Text = "BandManager";
            this.Load += new System.EventHandler(this.BandManager_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.membersBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseDataSet1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label labelBandManager;
        private System.Windows.Forms.ListBox bandlistBox;
        private System.Windows.Forms.Button addbutton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox concertlistBox;
        private System.Windows.Forms.Button registerbutton;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button deletebutton;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.NumericUpDown numericUpDown2;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.NumericUpDown numericUpDown3;
        private System.Windows.Forms.MonthCalendar concertCalendar1;
        private DatabaseDataSet1 databaseDataSet1;
        private System.Windows.Forms.BindingSource membersBindingSource1;
        private DatabaseDataSet1TableAdapters.MembersTableAdapter membersTableAdapter1;
        private DatabaseDataSet1TableAdapters.TableAdapterManager tableAdapterManager1;
        private System.Windows.Forms.TextBox roleTextBox;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.ListBox bandlistBox2;
    }
}

