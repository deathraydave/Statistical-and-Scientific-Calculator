namespace Project2
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.scientificGroupBox = new System.Windows.Forms.GroupBox();
            this.fibonacciButton = new System.Windows.Forms.Button();
            this.sumSquaresButton = new System.Windows.Forms.Button();
            this.primeButton = new System.Windows.Forms.Button();
            this.reciprocalButton = new System.Windows.Forms.Button();
            this.powerButton = new System.Windows.Forms.Button();
            this.factorialButton = new System.Windows.Forms.Button();
            this.statisticalGroupBox = new System.Windows.Forms.GroupBox();
            this.minButton = new System.Windows.Forms.Button();
            this.modeButton = new System.Windows.Forms.Button();
            this.sumButton = new System.Windows.Forms.Button();
            this.maxButton = new System.Windows.Forms.Button();
            this.medianButton = new System.Windows.Forms.Button();
            this.stdButton = new System.Windows.Forms.Button();
            this.rangeButton = new System.Windows.Forms.Button();
            this.meanButton = new System.Windows.Forms.Button();
            this.countButton = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.ceButton = new System.Windows.Forms.Button();
            this.cButton = new System.Windows.Forms.Button();
            this.zeroButton = new System.Windows.Forms.Button();
            this.threeButton = new System.Windows.Forms.Button();
            this.twoButton = new System.Windows.Forms.Button();
            this.oneButton = new System.Windows.Forms.Button();
            this.sixButton = new System.Windows.Forms.Button();
            this.fiveButton = new System.Windows.Forms.Button();
            this.fourButton = new System.Windows.Forms.Button();
            this.nineButton = new System.Windows.Forms.Button();
            this.eightButton = new System.Windows.Forms.Button();
            this.sevenButton = new System.Windows.Forms.Button();
            this.yTextBox = new System.Windows.Forms.TextBox();
            this.xTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.yCheckBox = new System.Windows.Forms.CheckBox();
            this.exitButton = new System.Windows.Forms.Button();
            this.clearListBoxButton = new System.Windows.Forms.Button();
            this.displayFileButton = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.displayListBox = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.scientificGroupBox.SuspendLayout();
            this.statisticalGroupBox.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.scientificGroupBox);
            this.panel1.Controls.Add(this.statisticalGroupBox);
            this.panel1.Location = new System.Drawing.Point(12, 256);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(516, 451);
            this.panel1.TabIndex = 2;
            // 
            // scientificGroupBox
            // 
            this.scientificGroupBox.Controls.Add(this.fibonacciButton);
            this.scientificGroupBox.Controls.Add(this.sumSquaresButton);
            this.scientificGroupBox.Controls.Add(this.primeButton);
            this.scientificGroupBox.Controls.Add(this.reciprocalButton);
            this.scientificGroupBox.Controls.Add(this.powerButton);
            this.scientificGroupBox.Controls.Add(this.factorialButton);
            this.scientificGroupBox.Location = new System.Drawing.Point(11, 262);
            this.scientificGroupBox.Name = "scientificGroupBox";
            this.scientificGroupBox.Size = new System.Drawing.Size(490, 186);
            this.scientificGroupBox.TabIndex = 1;
            this.scientificGroupBox.TabStop = false;
            this.scientificGroupBox.Text = "Scientific Calculator";
            // 
            // fibonacciButton
            // 
            this.fibonacciButton.BackColor = System.Drawing.Color.Gainsboro;
            this.fibonacciButton.Location = new System.Drawing.Point(331, 93);
            this.fibonacciButton.Name = "fibonacciButton";
            this.fibonacciButton.Size = new System.Drawing.Size(130, 65);
            this.fibonacciButton.TabIndex = 5;
            this.fibonacciButton.Text = "&Fibonacci (x)";
            this.fibonacciButton.UseVisualStyleBackColor = false;
            this.fibonacciButton.Click += new System.EventHandler(this.fibonacciButton_Click);
            this.fibonacciButton.MouseLeave += new System.EventHandler(this.fibonacciButton_MouseLeave);
            this.fibonacciButton.MouseHover += new System.EventHandler(this.fibonacciButton_MouseHover);
            // 
            // sumSquaresButton
            // 
            this.sumSquaresButton.BackColor = System.Drawing.Color.Gainsboro;
            this.sumSquaresButton.Location = new System.Drawing.Point(167, 93);
            this.sumSquaresButton.Name = "sumSquaresButton";
            this.sumSquaresButton.Size = new System.Drawing.Size(130, 65);
            this.sumSquaresButton.TabIndex = 4;
            this.sumSquaresButton.Text = "S&um of Squares (x..y)";
            this.sumSquaresButton.UseVisualStyleBackColor = false;
            this.sumSquaresButton.Click += new System.EventHandler(this.sumSquaresButton_Click);
            this.sumSquaresButton.MouseLeave += new System.EventHandler(this.sumSquaresButton_MouseLeave);
            this.sumSquaresButton.MouseHover += new System.EventHandler(this.sumSquaresButton_MouseHover);
            // 
            // primeButton
            // 
            this.primeButton.BackColor = System.Drawing.Color.Gainsboro;
            this.primeButton.Location = new System.Drawing.Point(6, 93);
            this.primeButton.Name = "primeButton";
            this.primeButton.Size = new System.Drawing.Size(130, 65);
            this.primeButton.TabIndex = 3;
            this.primeButton.Text = "&Prime (x..y)";
            this.primeButton.UseVisualStyleBackColor = false;
            this.primeButton.Click += new System.EventHandler(this.primeButton_Click);
            this.primeButton.MouseLeave += new System.EventHandler(this.primeButton_MouseLeave);
            this.primeButton.MouseHover += new System.EventHandler(this.primeButton_MouseHover);
            // 
            // reciprocalButton
            // 
            this.reciprocalButton.BackColor = System.Drawing.Color.Gainsboro;
            this.reciprocalButton.Location = new System.Drawing.Point(331, 22);
            this.reciprocalButton.Name = "reciprocalButton";
            this.reciprocalButton.Size = new System.Drawing.Size(130, 65);
            this.reciprocalButton.TabIndex = 2;
            this.reciprocalButton.Text = "1&/x";
            this.reciprocalButton.UseVisualStyleBackColor = false;
            this.reciprocalButton.Click += new System.EventHandler(this.reciprocalButton_Click);
            this.reciprocalButton.MouseLeave += new System.EventHandler(this.reciprocalButton_MouseLeave);
            this.reciprocalButton.MouseHover += new System.EventHandler(this.reciprocalButton_MouseHover);
            // 
            // powerButton
            // 
            this.powerButton.BackColor = System.Drawing.Color.Gainsboro;
            this.powerButton.Location = new System.Drawing.Point(167, 22);
            this.powerButton.Name = "powerButton";
            this.powerButton.Size = new System.Drawing.Size(130, 65);
            this.powerButton.TabIndex = 1;
            this.powerButton.Text = "x&^y";
            this.powerButton.UseVisualStyleBackColor = false;
            this.powerButton.Click += new System.EventHandler(this.powerButton_Click);
            this.powerButton.MouseLeave += new System.EventHandler(this.powerButton_MouseLeave);
            this.powerButton.MouseHover += new System.EventHandler(this.powerButton_MouseHover);
            // 
            // factorialButton
            // 
            this.factorialButton.BackColor = System.Drawing.Color.Gainsboro;
            this.factorialButton.Location = new System.Drawing.Point(6, 22);
            this.factorialButton.Name = "factorialButton";
            this.factorialButton.Size = new System.Drawing.Size(130, 65);
            this.factorialButton.TabIndex = 0;
            this.factorialButton.Text = "x&!";
            this.factorialButton.UseVisualStyleBackColor = false;
            this.factorialButton.Click += new System.EventHandler(this.factorialButton_Click);
            this.factorialButton.MouseLeave += new System.EventHandler(this.factorialButton_MouseLeave);
            this.factorialButton.MouseHover += new System.EventHandler(this.factorialButton_MouseHover);
            // 
            // statisticalGroupBox
            // 
            this.statisticalGroupBox.Controls.Add(this.minButton);
            this.statisticalGroupBox.Controls.Add(this.modeButton);
            this.statisticalGroupBox.Controls.Add(this.sumButton);
            this.statisticalGroupBox.Controls.Add(this.maxButton);
            this.statisticalGroupBox.Controls.Add(this.medianButton);
            this.statisticalGroupBox.Controls.Add(this.stdButton);
            this.statisticalGroupBox.Controls.Add(this.rangeButton);
            this.statisticalGroupBox.Controls.Add(this.meanButton);
            this.statisticalGroupBox.Controls.Add(this.countButton);
            this.statisticalGroupBox.Location = new System.Drawing.Point(11, 19);
            this.statisticalGroupBox.Name = "statisticalGroupBox";
            this.statisticalGroupBox.Size = new System.Drawing.Size(490, 237);
            this.statisticalGroupBox.TabIndex = 0;
            this.statisticalGroupBox.TabStop = false;
            this.statisticalGroupBox.Text = "Statistical Calculator";
            // 
            // minButton
            // 
            this.minButton.BackColor = System.Drawing.Color.Gainsboro;
            this.minButton.Location = new System.Drawing.Point(6, 164);
            this.minButton.Name = "minButton";
            this.minButton.Size = new System.Drawing.Size(130, 65);
            this.minButton.TabIndex = 6;
            this.minButton.Text = "M&in";
            this.minButton.UseVisualStyleBackColor = false;
            this.minButton.Click += new System.EventHandler(this.minButton_Click);
            this.minButton.MouseLeave += new System.EventHandler(this.minButton_MouseLeave);
            this.minButton.MouseHover += new System.EventHandler(this.minButton_MouseHover);
            // 
            // modeButton
            // 
            this.modeButton.BackColor = System.Drawing.Color.Gainsboro;
            this.modeButton.Location = new System.Drawing.Point(167, 164);
            this.modeButton.Name = "modeButton";
            this.modeButton.Size = new System.Drawing.Size(130, 65);
            this.modeButton.TabIndex = 7;
            this.modeButton.Text = "M&ode";
            this.modeButton.UseVisualStyleBackColor = false;
            this.modeButton.Click += new System.EventHandler(this.modeButton_Click);
            this.modeButton.MouseLeave += new System.EventHandler(this.modeButton_MouseLeave);
            this.modeButton.MouseHover += new System.EventHandler(this.modeButton_MouseHover);
            // 
            // sumButton
            // 
            this.sumButton.BackColor = System.Drawing.Color.Gainsboro;
            this.sumButton.Location = new System.Drawing.Point(331, 164);
            this.sumButton.Name = "sumButton";
            this.sumButton.Size = new System.Drawing.Size(130, 65);
            this.sumButton.TabIndex = 8;
            this.sumButton.Text = "S&um";
            this.sumButton.UseVisualStyleBackColor = false;
            this.sumButton.Click += new System.EventHandler(this.sumButton_Click);
            this.sumButton.MouseLeave += new System.EventHandler(this.sumButton_MouseLeave);
            this.sumButton.MouseHover += new System.EventHandler(this.sumButton_MouseHover);
            // 
            // maxButton
            // 
            this.maxButton.BackColor = System.Drawing.Color.Gainsboro;
            this.maxButton.Location = new System.Drawing.Point(331, 93);
            this.maxButton.Name = "maxButton";
            this.maxButton.Size = new System.Drawing.Size(130, 65);
            this.maxButton.TabIndex = 5;
            this.maxButton.Text = "M&ax";
            this.maxButton.UseVisualStyleBackColor = false;
            this.maxButton.Click += new System.EventHandler(this.maxButton_Click);
            this.maxButton.MouseLeave += new System.EventHandler(this.maxButton_MouseLeave);
            this.maxButton.MouseHover += new System.EventHandler(this.maxButton_MouseHover);
            // 
            // medianButton
            // 
            this.medianButton.BackColor = System.Drawing.Color.Gainsboro;
            this.medianButton.Location = new System.Drawing.Point(167, 93);
            this.medianButton.Name = "medianButton";
            this.medianButton.Size = new System.Drawing.Size(130, 65);
            this.medianButton.TabIndex = 4;
            this.medianButton.Text = "M&edian";
            this.medianButton.UseVisualStyleBackColor = false;
            this.medianButton.Click += new System.EventHandler(this.medianButton_Click);
            this.medianButton.MouseLeave += new System.EventHandler(this.medianButton_MouseLeave);
            this.medianButton.MouseHover += new System.EventHandler(this.medianButton_MouseHover);
            // 
            // stdButton
            // 
            this.stdButton.BackColor = System.Drawing.Color.Gainsboro;
            this.stdButton.Location = new System.Drawing.Point(6, 93);
            this.stdButton.Name = "stdButton";
            this.stdButton.Size = new System.Drawing.Size(130, 65);
            this.stdButton.TabIndex = 3;
            this.stdButton.Text = "S&tandard Deviation";
            this.stdButton.UseVisualStyleBackColor = false;
            this.stdButton.Click += new System.EventHandler(this.stdButton_Click);
            this.stdButton.MouseLeave += new System.EventHandler(this.stdButton_MouseLeave);
            this.stdButton.MouseHover += new System.EventHandler(this.stdButton_MouseHover);
            // 
            // rangeButton
            // 
            this.rangeButton.BackColor = System.Drawing.Color.Gainsboro;
            this.rangeButton.Location = new System.Drawing.Point(331, 22);
            this.rangeButton.Name = "rangeButton";
            this.rangeButton.Size = new System.Drawing.Size(130, 65);
            this.rangeButton.TabIndex = 2;
            this.rangeButton.Text = "&Range";
            this.rangeButton.UseVisualStyleBackColor = false;
            this.rangeButton.Click += new System.EventHandler(this.rangeButton_Click);
            this.rangeButton.MouseLeave += new System.EventHandler(this.rangeButton_MouseLeave);
            this.rangeButton.MouseHover += new System.EventHandler(this.rangeButton_MouseHover);
            // 
            // meanButton
            // 
            this.meanButton.BackColor = System.Drawing.Color.Gainsboro;
            this.meanButton.Location = new System.Drawing.Point(167, 22);
            this.meanButton.Name = "meanButton";
            this.meanButton.Size = new System.Drawing.Size(130, 65);
            this.meanButton.TabIndex = 1;
            this.meanButton.Text = "&Mean";
            this.meanButton.UseVisualStyleBackColor = false;
            this.meanButton.Click += new System.EventHandler(this.meanButton_Click);
            this.meanButton.MouseLeave += new System.EventHandler(this.meanButton_MouseLeave);
            this.meanButton.MouseHover += new System.EventHandler(this.meanButton_MouseHover);
            // 
            // countButton
            // 
            this.countButton.BackColor = System.Drawing.Color.Gainsboro;
            this.countButton.Location = new System.Drawing.Point(6, 22);
            this.countButton.Name = "countButton";
            this.countButton.Size = new System.Drawing.Size(130, 65);
            this.countButton.TabIndex = 0;
            this.countButton.Text = "Cou&nt";
            this.countButton.UseVisualStyleBackColor = false;
            this.countButton.Click += new System.EventHandler(this.countButton_Click);
            this.countButton.MouseLeave += new System.EventHandler(this.countButton_MouseLeave);
            this.countButton.MouseHover += new System.EventHandler(this.countButton_MouseHover);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.ceButton);
            this.panel2.Controls.Add(this.cButton);
            this.panel2.Controls.Add(this.zeroButton);
            this.panel2.Controls.Add(this.threeButton);
            this.panel2.Controls.Add(this.twoButton);
            this.panel2.Controls.Add(this.oneButton);
            this.panel2.Controls.Add(this.sixButton);
            this.panel2.Controls.Add(this.fiveButton);
            this.panel2.Controls.Add(this.fourButton);
            this.panel2.Controls.Add(this.nineButton);
            this.panel2.Controls.Add(this.eightButton);
            this.panel2.Controls.Add(this.sevenButton);
            this.panel2.Controls.Add(this.yTextBox);
            this.panel2.Controls.Add(this.xTextBox);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.yCheckBox);
            this.panel2.Controls.Add(this.exitButton);
            this.panel2.Controls.Add(this.clearListBoxButton);
            this.panel2.Controls.Add(this.displayFileButton);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Location = new System.Drawing.Point(534, 11);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(357, 696);
            this.panel2.TabIndex = 0;
            // 
            // ceButton
            // 
            this.ceButton.BackColor = System.Drawing.Color.DarkRed;
            this.ceButton.ForeColor = System.Drawing.Color.White;
            this.ceButton.Location = new System.Drawing.Point(241, 321);
            this.ceButton.Name = "ceButton";
            this.ceButton.Size = new System.Drawing.Size(109, 77);
            this.ceButton.TabIndex = 11;
            this.ceButton.Text = "CE";
            this.ceButton.UseVisualStyleBackColor = false;
            this.ceButton.Click += new System.EventHandler(this.ceButton_Click);
            this.ceButton.MouseLeave += new System.EventHandler(this.ceButton_MouseLeave);
            this.ceButton.MouseHover += new System.EventHandler(this.ceButton_MouseHover);
            // 
            // cButton
            // 
            this.cButton.BackColor = System.Drawing.Color.DarkRed;
            this.cButton.ForeColor = System.Drawing.Color.White;
            this.cButton.Location = new System.Drawing.Point(6, 321);
            this.cButton.Name = "cButton";
            this.cButton.Size = new System.Drawing.Size(109, 77);
            this.cButton.TabIndex = 9;
            this.cButton.Text = "C";
            this.cButton.UseVisualStyleBackColor = false;
            this.cButton.Click += new System.EventHandler(this.cButton_Click);
            this.cButton.MouseLeave += new System.EventHandler(this.cButton_MouseLeave);
            this.cButton.MouseHover += new System.EventHandler(this.cButton_MouseHover);
            // 
            // zeroButton
            // 
            this.zeroButton.BackColor = System.Drawing.Color.Black;
            this.zeroButton.ForeColor = System.Drawing.Color.White;
            this.zeroButton.Location = new System.Drawing.Point(126, 321);
            this.zeroButton.Name = "zeroButton";
            this.zeroButton.Size = new System.Drawing.Size(109, 77);
            this.zeroButton.TabIndex = 10;
            this.zeroButton.Text = "0";
            this.zeroButton.UseVisualStyleBackColor = false;
            this.zeroButton.Click += new System.EventHandler(this.zeroButton_Click);
            this.zeroButton.MouseLeave += new System.EventHandler(this.zeroButton_MouseLeave);
            this.zeroButton.MouseHover += new System.EventHandler(this.zeroButton_MouseHover);
            // 
            // threeButton
            // 
            this.threeButton.BackColor = System.Drawing.Color.Black;
            this.threeButton.ForeColor = System.Drawing.Color.White;
            this.threeButton.Location = new System.Drawing.Point(241, 238);
            this.threeButton.Name = "threeButton";
            this.threeButton.Size = new System.Drawing.Size(109, 77);
            this.threeButton.TabIndex = 8;
            this.threeButton.Text = "3";
            this.threeButton.UseVisualStyleBackColor = false;
            this.threeButton.Click += new System.EventHandler(this.threeButton_Click);
            this.threeButton.MouseLeave += new System.EventHandler(this.threeButton_MouseLeave);
            this.threeButton.MouseHover += new System.EventHandler(this.threeButton_MouseHover);
            // 
            // twoButton
            // 
            this.twoButton.BackColor = System.Drawing.Color.Black;
            this.twoButton.ForeColor = System.Drawing.Color.White;
            this.twoButton.Location = new System.Drawing.Point(126, 238);
            this.twoButton.Name = "twoButton";
            this.twoButton.Size = new System.Drawing.Size(109, 77);
            this.twoButton.TabIndex = 7;
            this.twoButton.Text = "2";
            this.twoButton.UseVisualStyleBackColor = false;
            this.twoButton.Click += new System.EventHandler(this.twoButton_Click);
            this.twoButton.MouseLeave += new System.EventHandler(this.twoButton_MouseLeave);
            this.twoButton.MouseHover += new System.EventHandler(this.twoButton_MouseHover);
            // 
            // oneButton
            // 
            this.oneButton.BackColor = System.Drawing.Color.Black;
            this.oneButton.ForeColor = System.Drawing.Color.White;
            this.oneButton.Location = new System.Drawing.Point(6, 238);
            this.oneButton.Name = "oneButton";
            this.oneButton.Size = new System.Drawing.Size(109, 77);
            this.oneButton.TabIndex = 6;
            this.oneButton.Text = "1";
            this.oneButton.UseVisualStyleBackColor = false;
            this.oneButton.Click += new System.EventHandler(this.oneButton_Click);
            this.oneButton.MouseLeave += new System.EventHandler(this.oneButton_MouseLeave);
            this.oneButton.MouseHover += new System.EventHandler(this.oneButton_MouseHover);
            // 
            // sixButton
            // 
            this.sixButton.BackColor = System.Drawing.Color.Black;
            this.sixButton.ForeColor = System.Drawing.Color.White;
            this.sixButton.Location = new System.Drawing.Point(241, 155);
            this.sixButton.Name = "sixButton";
            this.sixButton.Size = new System.Drawing.Size(109, 77);
            this.sixButton.TabIndex = 5;
            this.sixButton.Text = "6";
            this.sixButton.UseVisualStyleBackColor = false;
            this.sixButton.Click += new System.EventHandler(this.sixButton_Click);
            this.sixButton.MouseLeave += new System.EventHandler(this.sixButton_MouseLeave);
            this.sixButton.MouseHover += new System.EventHandler(this.sixButton_MouseHover);
            // 
            // fiveButton
            // 
            this.fiveButton.BackColor = System.Drawing.Color.Black;
            this.fiveButton.ForeColor = System.Drawing.Color.White;
            this.fiveButton.Location = new System.Drawing.Point(126, 155);
            this.fiveButton.Name = "fiveButton";
            this.fiveButton.Size = new System.Drawing.Size(109, 77);
            this.fiveButton.TabIndex = 4;
            this.fiveButton.Text = "5";
            this.fiveButton.UseVisualStyleBackColor = false;
            this.fiveButton.Click += new System.EventHandler(this.fiveButton_Click);
            this.fiveButton.MouseLeave += new System.EventHandler(this.fiveButton_MouseLeave);
            this.fiveButton.MouseHover += new System.EventHandler(this.fiveButton_MouseHover);
            // 
            // fourButton
            // 
            this.fourButton.BackColor = System.Drawing.Color.Black;
            this.fourButton.ForeColor = System.Drawing.Color.White;
            this.fourButton.Location = new System.Drawing.Point(6, 155);
            this.fourButton.Name = "fourButton";
            this.fourButton.Size = new System.Drawing.Size(109, 77);
            this.fourButton.TabIndex = 3;
            this.fourButton.Text = "4";
            this.fourButton.UseVisualStyleBackColor = false;
            this.fourButton.Click += new System.EventHandler(this.fourButton_Click);
            this.fourButton.MouseLeave += new System.EventHandler(this.fourButton_MouseLeave);
            this.fourButton.MouseHover += new System.EventHandler(this.fourButton_MouseHover);
            // 
            // nineButton
            // 
            this.nineButton.BackColor = System.Drawing.Color.Black;
            this.nineButton.ForeColor = System.Drawing.Color.White;
            this.nineButton.Location = new System.Drawing.Point(241, 72);
            this.nineButton.Name = "nineButton";
            this.nineButton.Size = new System.Drawing.Size(109, 77);
            this.nineButton.TabIndex = 2;
            this.nineButton.Text = "9";
            this.nineButton.UseVisualStyleBackColor = false;
            this.nineButton.Click += new System.EventHandler(this.nineButton_Click);
            this.nineButton.MouseLeave += new System.EventHandler(this.nineButton_MouseLeave);
            this.nineButton.MouseHover += new System.EventHandler(this.nineButton_MouseHover);
            // 
            // eightButton
            // 
            this.eightButton.BackColor = System.Drawing.Color.Black;
            this.eightButton.ForeColor = System.Drawing.Color.White;
            this.eightButton.Location = new System.Drawing.Point(126, 72);
            this.eightButton.Name = "eightButton";
            this.eightButton.Size = new System.Drawing.Size(109, 77);
            this.eightButton.TabIndex = 1;
            this.eightButton.Text = "8";
            this.eightButton.UseVisualStyleBackColor = false;
            this.eightButton.Click += new System.EventHandler(this.eightButton_Click);
            this.eightButton.MouseLeave += new System.EventHandler(this.eightButton_MouseLeave);
            this.eightButton.MouseHover += new System.EventHandler(this.eightButton_MouseHover);
            // 
            // sevenButton
            // 
            this.sevenButton.BackColor = System.Drawing.Color.Black;
            this.sevenButton.ForeColor = System.Drawing.Color.White;
            this.sevenButton.Location = new System.Drawing.Point(6, 72);
            this.sevenButton.Name = "sevenButton";
            this.sevenButton.Size = new System.Drawing.Size(109, 77);
            this.sevenButton.TabIndex = 0;
            this.sevenButton.Text = "7";
            this.sevenButton.UseVisualStyleBackColor = false;
            this.sevenButton.Click += new System.EventHandler(this.sevenButton_Click);
            this.sevenButton.MouseLeave += new System.EventHandler(this.sevenButton_MouseLeave);
            this.sevenButton.MouseHover += new System.EventHandler(this.sevenButton_MouseHover);
            // 
            // yTextBox
            // 
            this.yTextBox.Location = new System.Drawing.Point(126, 471);
            this.yTextBox.Name = "yTextBox";
            this.yTextBox.Size = new System.Drawing.Size(109, 23);
            this.yTextBox.TabIndex = 16;
            this.yTextBox.Click += new System.EventHandler(this.yTextBox_Click);
            this.yTextBox.TextChanged += new System.EventHandler(this.yTextBox_TextChanged);
            this.yTextBox.Enter += new System.EventHandler(this.yTextBox_Enter);
            this.yTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.yTextBox_KeyPress);
            // 
            // xTextBox
            // 
            this.xTextBox.Location = new System.Drawing.Point(126, 428);
            this.xTextBox.Name = "xTextBox";
            this.xTextBox.Size = new System.Drawing.Size(109, 23);
            this.xTextBox.TabIndex = 13;
            this.xTextBox.Click += new System.EventHandler(this.xTextBox_Click);
            this.xTextBox.TextChanged += new System.EventHandler(this.xTextBox_TextChanged);
            this.xTextBox.Enter += new System.EventHandler(this.xTextBox_Enter);
            this.xTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.xTextBox_KeyPress);
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(99, 475);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 15);
            this.label3.TabIndex = 15;
            this.label3.Text = "y:";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(99, 428);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 15);
            this.label2.TabIndex = 12;
            this.label2.Text = "x:";
            // 
            // yCheckBox
            // 
            this.yCheckBox.AutoSize = true;
            this.yCheckBox.Location = new System.Drawing.Point(67, 471);
            this.yCheckBox.Name = "yCheckBox";
            this.yCheckBox.Size = new System.Drawing.Size(15, 14);
            this.yCheckBox.TabIndex = 14;
            this.yCheckBox.UseVisualStyleBackColor = true;
            // 
            // exitButton
            // 
            this.exitButton.BackColor = System.Drawing.Color.Gainsboro;
            this.exitButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.exitButton.Location = new System.Drawing.Point(6, 616);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(351, 49);
            this.exitButton.TabIndex = 19;
            this.exitButton.Text = "E&xit";
            this.exitButton.UseVisualStyleBackColor = false;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            this.exitButton.MouseLeave += new System.EventHandler(this.exitButton_MouseLeave);
            this.exitButton.MouseHover += new System.EventHandler(this.exitButton_MouseHover);
            // 
            // clearListBoxButton
            // 
            this.clearListBoxButton.BackColor = System.Drawing.Color.Gainsboro;
            this.clearListBoxButton.Location = new System.Drawing.Point(6, 561);
            this.clearListBoxButton.Name = "clearListBoxButton";
            this.clearListBoxButton.Size = new System.Drawing.Size(351, 49);
            this.clearListBoxButton.TabIndex = 18;
            this.clearListBoxButton.Text = "&Clear";
            this.clearListBoxButton.UseVisualStyleBackColor = false;
            this.clearListBoxButton.Click += new System.EventHandler(this.clearListBoxButton_Click);
            this.clearListBoxButton.MouseLeave += new System.EventHandler(this.clearListBoxButton_MouseLeave);
            this.clearListBoxButton.MouseHover += new System.EventHandler(this.clearListBoxButton_MouseHover);
            // 
            // displayFileButton
            // 
            this.displayFileButton.BackColor = System.Drawing.Color.Gainsboro;
            this.displayFileButton.Location = new System.Drawing.Point(6, 507);
            this.displayFileButton.Name = "displayFileButton";
            this.displayFileButton.Size = new System.Drawing.Size(351, 49);
            this.displayFileButton.TabIndex = 17;
            this.displayFileButton.Text = "&Display File Values";
            this.displayFileButton.UseVisualStyleBackColor = false;
            this.displayFileButton.Click += new System.EventHandler(this.displayFileButton_Click);
            this.displayFileButton.MouseLeave += new System.EventHandler(this.displayFileButton_MouseLeave);
            this.displayFileButton.MouseHover += new System.EventHandler(this.displayFileButton_MouseHover);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(126, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(109, 63);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // displayListBox
            // 
            this.displayListBox.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.displayListBox.FormattingEnabled = true;
            this.displayListBox.HorizontalScrollbar = true;
            this.displayListBox.ItemHeight = 15;
            this.displayListBox.Location = new System.Drawing.Point(12, 74);
            this.displayListBox.Name = "displayListBox";
            this.displayListBox.Size = new System.Drawing.Size(516, 169);
            this.displayListBox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.LightGray;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 39.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.label1.Location = new System.Drawing.Point(12, -1);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(516, 72);
            this.label1.TabIndex = 0;
            this.label1.Text = "Calculator App";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // MainForm
            // 
            this.AcceptButton = this.displayFileButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.CancelButton = this.exitButton;
            this.ClientSize = new System.Drawing.Size(903, 717);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.displayListBox);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.panel1.ResumeLayout(false);
            this.scientificGroupBox.ResumeLayout(false);
            this.statisticalGroupBox.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ListBox displayListBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox scientificGroupBox;
        private System.Windows.Forms.GroupBox statisticalGroupBox;
        private System.Windows.Forms.Button minButton;
        private System.Windows.Forms.Button modeButton;
        private System.Windows.Forms.Button sumButton;
        private System.Windows.Forms.Button maxButton;
        private System.Windows.Forms.Button medianButton;
        private System.Windows.Forms.Button stdButton;
        private System.Windows.Forms.Button rangeButton;
        private System.Windows.Forms.Button meanButton;
        private System.Windows.Forms.Button countButton;
        private System.Windows.Forms.Button fibonacciButton;
        private System.Windows.Forms.Button sumSquaresButton;
        private System.Windows.Forms.Button primeButton;
        private System.Windows.Forms.Button reciprocalButton;
        private System.Windows.Forms.Button powerButton;
        private System.Windows.Forms.Button factorialButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Button clearListBoxButton;
        private System.Windows.Forms.Button displayFileButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox yCheckBox;
        private System.Windows.Forms.TextBox yTextBox;
        private System.Windows.Forms.TextBox xTextBox;
        private System.Windows.Forms.Button zeroButton;
        private System.Windows.Forms.Button threeButton;
        private System.Windows.Forms.Button twoButton;
        private System.Windows.Forms.Button oneButton;
        private System.Windows.Forms.Button sixButton;
        private System.Windows.Forms.Button fiveButton;
        private System.Windows.Forms.Button fourButton;
        private System.Windows.Forms.Button nineButton;
        private System.Windows.Forms.Button eightButton;
        private System.Windows.Forms.Button sevenButton;
        private System.Windows.Forms.Button ceButton;
        private System.Windows.Forms.Button cButton;
    }
}

