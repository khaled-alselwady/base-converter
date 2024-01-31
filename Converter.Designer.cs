namespace BinaryConverter
{
    partial class Converter
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
            this.btnReset = new Guna.UI2.WinForms.Guna2GradientButton();
            this.lblTitle = new System.Windows.Forms.Label();
            this.tcConverter = new Guna.UI2.WinForms.Guna2TabControl();
            this.tpBinaryConverter = new System.Windows.Forms.TabPage();
            this.btnConvertForBinary = new Guna.UI2.WinForms.Guna2GradientButton();
            this.lblOctalForBinary = new System.Windows.Forms.Label();
            this.lblHexaForBinary = new System.Windows.Forms.Label();
            this.lblDecimalForBinary = new System.Windows.Forms.Label();
            this.txtBinary = new Guna.UI2.WinForms.Guna2TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tpDecimalConverter = new System.Windows.Forms.TabPage();
            this.btnConvertForDecimal = new Guna.UI2.WinForms.Guna2GradientButton();
            this.lblOctalForDecimal = new System.Windows.Forms.Label();
            this.lblHexaForDecimal = new System.Windows.Forms.Label();
            this.lblBinaryForDecimal = new System.Windows.Forms.Label();
            this.txtDecimal = new Guna.UI2.WinForms.Guna2TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.tpHexaConverter = new System.Windows.Forms.TabPage();
            this.btnConvertForHexa = new Guna.UI2.WinForms.Guna2GradientButton();
            this.lblOctalForHexa = new System.Windows.Forms.Label();
            this.lblDecimalForHexa = new System.Windows.Forms.Label();
            this.lblBinaryForHexa = new System.Windows.Forms.Label();
            this.txtHexadecimal = new Guna.UI2.WinForms.Guna2TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.tpOctalConverter = new System.Windows.Forms.TabPage();
            this.btnConvertForOctal = new Guna.UI2.WinForms.Guna2GradientButton();
            this.lblHexaForOctal = new System.Windows.Forms.Label();
            this.lblDecimalForOctal = new System.Windows.Forms.Label();
            this.lblBinaryForOctal = new System.Windows.Forms.Label();
            this.txtOctal = new Guna.UI2.WinForms.Guna2TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.tcConverter.SuspendLayout();
            this.tpBinaryConverter.SuspendLayout();
            this.tpDecimalConverter.SuspendLayout();
            this.tpHexaConverter.SuspendLayout();
            this.tpOctalConverter.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnReset
            // 
            this.btnReset.Animated = true;
            this.btnReset.BorderColor = System.Drawing.Color.Transparent;
            this.btnReset.BorderRadius = 17;
            this.btnReset.BorderThickness = 1;
            this.btnReset.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnReset.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnReset.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnReset.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnReset.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnReset.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold);
            this.btnReset.ForeColor = System.Drawing.Color.White;
            this.btnReset.Location = new System.Drawing.Point(567, 419);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(123, 45);
            this.btnReset.TabIndex = 8;
            this.btnReset.Text = "Reset";
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblTitle.Location = new System.Drawing.Point(3, 2);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(687, 47);
            this.lblTitle.TabIndex = 10;
            this.lblTitle.Text = "Binary Convert";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tcConverter
            // 
            this.tcConverter.Alignment = System.Windows.Forms.TabAlignment.Left;
            this.tcConverter.Controls.Add(this.tpBinaryConverter);
            this.tcConverter.Controls.Add(this.tpDecimalConverter);
            this.tcConverter.Controls.Add(this.tpHexaConverter);
            this.tcConverter.Controls.Add(this.tpOctalConverter);
            this.tcConverter.ItemSize = new System.Drawing.Size(180, 40);
            this.tcConverter.Location = new System.Drawing.Point(12, 76);
            this.tcConverter.Name = "tcConverter";
            this.tcConverter.SelectedIndex = 0;
            this.tcConverter.Size = new System.Drawing.Size(669, 337);
            this.tcConverter.TabButtonHoverState.BorderColor = System.Drawing.Color.Empty;
            this.tcConverter.TabButtonHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(52)))), ((int)(((byte)(70)))));
            this.tcConverter.TabButtonHoverState.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.tcConverter.TabButtonHoverState.ForeColor = System.Drawing.Color.White;
            this.tcConverter.TabButtonHoverState.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(52)))), ((int)(((byte)(70)))));
            this.tcConverter.TabButtonIdleState.BorderColor = System.Drawing.Color.Empty;
            this.tcConverter.TabButtonIdleState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(42)))), ((int)(((byte)(57)))));
            this.tcConverter.TabButtonIdleState.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.tcConverter.TabButtonIdleState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(160)))), ((int)(((byte)(167)))));
            this.tcConverter.TabButtonIdleState.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(42)))), ((int)(((byte)(57)))));
            this.tcConverter.TabButtonSelectedState.BorderColor = System.Drawing.Color.Empty;
            this.tcConverter.TabButtonSelectedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(37)))), ((int)(((byte)(49)))));
            this.tcConverter.TabButtonSelectedState.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.tcConverter.TabButtonSelectedState.ForeColor = System.Drawing.Color.White;
            this.tcConverter.TabButtonSelectedState.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(132)))), ((int)(((byte)(255)))));
            this.tcConverter.TabButtonSize = new System.Drawing.Size(180, 40);
            this.tcConverter.TabIndex = 11;
            this.tcConverter.TabMenuBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(42)))), ((int)(((byte)(57)))));
            this.tcConverter.SelectedIndexChanged += new System.EventHandler(this.guna2TabControl1_SelectedIndexChanged);
            // 
            // tpBinaryConverter
            // 
            this.tpBinaryConverter.BackColor = System.Drawing.Color.White;
            this.tpBinaryConverter.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tpBinaryConverter.Controls.Add(this.btnConvertForBinary);
            this.tpBinaryConverter.Controls.Add(this.lblOctalForBinary);
            this.tpBinaryConverter.Controls.Add(this.lblHexaForBinary);
            this.tpBinaryConverter.Controls.Add(this.lblDecimalForBinary);
            this.tpBinaryConverter.Controls.Add(this.txtBinary);
            this.tpBinaryConverter.Controls.Add(this.label4);
            this.tpBinaryConverter.Controls.Add(this.label3);
            this.tpBinaryConverter.Controls.Add(this.label2);
            this.tpBinaryConverter.Controls.Add(this.label1);
            this.tpBinaryConverter.Location = new System.Drawing.Point(184, 4);
            this.tpBinaryConverter.Name = "tpBinaryConverter";
            this.tpBinaryConverter.Padding = new System.Windows.Forms.Padding(3);
            this.tpBinaryConverter.Size = new System.Drawing.Size(481, 329);
            this.tpBinaryConverter.TabIndex = 0;
            this.tpBinaryConverter.Text = "Binary Converter";
            // 
            // btnConvertForBinary
            // 
            this.btnConvertForBinary.Animated = true;
            this.btnConvertForBinary.BorderColor = System.Drawing.Color.Transparent;
            this.btnConvertForBinary.BorderRadius = 17;
            this.btnConvertForBinary.BorderThickness = 1;
            this.btnConvertForBinary.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnConvertForBinary.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnConvertForBinary.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnConvertForBinary.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnConvertForBinary.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnConvertForBinary.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold);
            this.btnConvertForBinary.ForeColor = System.Drawing.Color.White;
            this.btnConvertForBinary.Location = new System.Drawing.Point(205, 89);
            this.btnConvertForBinary.Name = "btnConvertForBinary";
            this.btnConvertForBinary.Size = new System.Drawing.Size(172, 45);
            this.btnConvertForBinary.TabIndex = 18;
            this.btnConvertForBinary.Text = "Convert";
            this.btnConvertForBinary.Click += new System.EventHandler(this.btnConvertForBinary_Click);
            // 
            // lblOctalForBinary
            // 
            this.lblOctalForBinary.AutoSize = true;
            this.lblOctalForBinary.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOctalForBinary.ForeColor = System.Drawing.Color.Black;
            this.lblOctalForBinary.Location = new System.Drawing.Point(165, 269);
            this.lblOctalForBinary.Name = "lblOctalForBinary";
            this.lblOctalForBinary.Size = new System.Drawing.Size(56, 25);
            this.lblOctalForBinary.TabIndex = 17;
            this.lblOctalForBinary.Text = "[????]";
            // 
            // lblHexaForBinary
            // 
            this.lblHexaForBinary.AutoSize = true;
            this.lblHexaForBinary.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHexaForBinary.ForeColor = System.Drawing.Color.Black;
            this.lblHexaForBinary.Location = new System.Drawing.Point(165, 213);
            this.lblHexaForBinary.Name = "lblHexaForBinary";
            this.lblHexaForBinary.Size = new System.Drawing.Size(56, 25);
            this.lblHexaForBinary.TabIndex = 16;
            this.lblHexaForBinary.Text = "[????]";
            // 
            // lblDecimalForBinary
            // 
            this.lblDecimalForBinary.AutoSize = true;
            this.lblDecimalForBinary.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDecimalForBinary.ForeColor = System.Drawing.Color.Black;
            this.lblDecimalForBinary.Location = new System.Drawing.Point(165, 155);
            this.lblDecimalForBinary.Name = "lblDecimalForBinary";
            this.lblDecimalForBinary.Size = new System.Drawing.Size(56, 25);
            this.lblDecimalForBinary.TabIndex = 15;
            this.lblDecimalForBinary.Text = "[????]";
            // 
            // txtBinary
            // 
            this.txtBinary.Animated = true;
            this.txtBinary.BorderColor = System.Drawing.Color.Gray;
            this.txtBinary.BorderRadius = 17;
            this.txtBinary.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtBinary.DefaultText = "";
            this.txtBinary.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtBinary.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtBinary.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtBinary.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtBinary.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtBinary.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold);
            this.txtBinary.ForeColor = System.Drawing.Color.Black;
            this.txtBinary.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtBinary.Location = new System.Drawing.Point(165, 35);
            this.txtBinary.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.txtBinary.Name = "txtBinary";
            this.txtBinary.PasswordChar = '\0';
            this.txtBinary.PlaceholderText = "";
            this.txtBinary.SelectedText = "";
            this.txtBinary.Size = new System.Drawing.Size(284, 41);
            this.txtBinary.TabIndex = 14;
            this.txtBinary.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBinary_KeyPress_1);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(32, 269);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 25);
            this.label4.TabIndex = 13;
            this.label4.Text = "Octal:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(32, 213);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(128, 25);
            this.label3.TabIndex = 12;
            this.label3.Text = "Hexadecimal:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(32, 155);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 25);
            this.label2.TabIndex = 11;
            this.label2.Text = "Decimal:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(32, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 25);
            this.label1.TabIndex = 10;
            this.label1.Text = "Binary:";
            // 
            // tpDecimalConverter
            // 
            this.tpDecimalConverter.BackColor = System.Drawing.Color.White;
            this.tpDecimalConverter.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tpDecimalConverter.Controls.Add(this.btnConvertForDecimal);
            this.tpDecimalConverter.Controls.Add(this.lblOctalForDecimal);
            this.tpDecimalConverter.Controls.Add(this.lblHexaForDecimal);
            this.tpDecimalConverter.Controls.Add(this.lblBinaryForDecimal);
            this.tpDecimalConverter.Controls.Add(this.txtDecimal);
            this.tpDecimalConverter.Controls.Add(this.label9);
            this.tpDecimalConverter.Controls.Add(this.label10);
            this.tpDecimalConverter.Controls.Add(this.label11);
            this.tpDecimalConverter.Controls.Add(this.label12);
            this.tpDecimalConverter.Location = new System.Drawing.Point(184, 4);
            this.tpDecimalConverter.Name = "tpDecimalConverter";
            this.tpDecimalConverter.Padding = new System.Windows.Forms.Padding(3);
            this.tpDecimalConverter.Size = new System.Drawing.Size(481, 329);
            this.tpDecimalConverter.TabIndex = 1;
            this.tpDecimalConverter.Text = "Decimal Converter";
            // 
            // btnConvertForDecimal
            // 
            this.btnConvertForDecimal.Animated = true;
            this.btnConvertForDecimal.BorderColor = System.Drawing.Color.Transparent;
            this.btnConvertForDecimal.BorderRadius = 17;
            this.btnConvertForDecimal.BorderThickness = 1;
            this.btnConvertForDecimal.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnConvertForDecimal.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnConvertForDecimal.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnConvertForDecimal.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnConvertForDecimal.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnConvertForDecimal.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold);
            this.btnConvertForDecimal.ForeColor = System.Drawing.Color.White;
            this.btnConvertForDecimal.Location = new System.Drawing.Point(205, 89);
            this.btnConvertForDecimal.Name = "btnConvertForDecimal";
            this.btnConvertForDecimal.Size = new System.Drawing.Size(172, 45);
            this.btnConvertForDecimal.TabIndex = 27;
            this.btnConvertForDecimal.Text = "Convert";
            this.btnConvertForDecimal.Click += new System.EventHandler(this.btnConvertForDecimal_Click);
            // 
            // lblOctalForDecimal
            // 
            this.lblOctalForDecimal.AutoSize = true;
            this.lblOctalForDecimal.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOctalForDecimal.ForeColor = System.Drawing.Color.Black;
            this.lblOctalForDecimal.Location = new System.Drawing.Point(165, 269);
            this.lblOctalForDecimal.Name = "lblOctalForDecimal";
            this.lblOctalForDecimal.Size = new System.Drawing.Size(56, 25);
            this.lblOctalForDecimal.TabIndex = 26;
            this.lblOctalForDecimal.Text = "[????]";
            // 
            // lblHexaForDecimal
            // 
            this.lblHexaForDecimal.AutoSize = true;
            this.lblHexaForDecimal.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHexaForDecimal.ForeColor = System.Drawing.Color.Black;
            this.lblHexaForDecimal.Location = new System.Drawing.Point(165, 213);
            this.lblHexaForDecimal.Name = "lblHexaForDecimal";
            this.lblHexaForDecimal.Size = new System.Drawing.Size(56, 25);
            this.lblHexaForDecimal.TabIndex = 25;
            this.lblHexaForDecimal.Text = "[????]";
            // 
            // lblBinaryForDecimal
            // 
            this.lblBinaryForDecimal.AutoSize = true;
            this.lblBinaryForDecimal.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBinaryForDecimal.ForeColor = System.Drawing.Color.Black;
            this.lblBinaryForDecimal.Location = new System.Drawing.Point(165, 155);
            this.lblBinaryForDecimal.Name = "lblBinaryForDecimal";
            this.lblBinaryForDecimal.Size = new System.Drawing.Size(56, 25);
            this.lblBinaryForDecimal.TabIndex = 24;
            this.lblBinaryForDecimal.Text = "[????]";
            // 
            // txtDecimal
            // 
            this.txtDecimal.Animated = true;
            this.txtDecimal.BorderColor = System.Drawing.Color.Gray;
            this.txtDecimal.BorderRadius = 17;
            this.txtDecimal.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtDecimal.DefaultText = "";
            this.txtDecimal.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtDecimal.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtDecimal.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtDecimal.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtDecimal.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtDecimal.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold);
            this.txtDecimal.ForeColor = System.Drawing.Color.Black;
            this.txtDecimal.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtDecimal.Location = new System.Drawing.Point(165, 35);
            this.txtDecimal.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.txtDecimal.Name = "txtDecimal";
            this.txtDecimal.PasswordChar = '\0';
            this.txtDecimal.PlaceholderText = "";
            this.txtDecimal.SelectedText = "";
            this.txtDecimal.Size = new System.Drawing.Size(284, 41);
            this.txtDecimal.TabIndex = 23;
            this.txtDecimal.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDecimal_KeyPress);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(32, 269);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(62, 25);
            this.label9.TabIndex = 22;
            this.label9.Text = "Octal:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Location = new System.Drawing.Point(32, 213);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(128, 25);
            this.label10.TabIndex = 21;
            this.label10.Text = "Hexadecimal:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Black;
            this.label11.Location = new System.Drawing.Point(32, 155);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(72, 25);
            this.label11.TabIndex = 20;
            this.label11.Text = "Binary:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.Black;
            this.label12.Location = new System.Drawing.Point(32, 36);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(87, 25);
            this.label12.TabIndex = 19;
            this.label12.Text = "Decimal:";
            // 
            // tpHexaConverter
            // 
            this.tpHexaConverter.BackColor = System.Drawing.Color.White;
            this.tpHexaConverter.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tpHexaConverter.Controls.Add(this.btnConvertForHexa);
            this.tpHexaConverter.Controls.Add(this.lblOctalForHexa);
            this.tpHexaConverter.Controls.Add(this.lblDecimalForHexa);
            this.tpHexaConverter.Controls.Add(this.lblBinaryForHexa);
            this.tpHexaConverter.Controls.Add(this.txtHexadecimal);
            this.tpHexaConverter.Controls.Add(this.label13);
            this.tpHexaConverter.Controls.Add(this.label14);
            this.tpHexaConverter.Controls.Add(this.label15);
            this.tpHexaConverter.Controls.Add(this.label16);
            this.tpHexaConverter.Location = new System.Drawing.Point(184, 4);
            this.tpHexaConverter.Name = "tpHexaConverter";
            this.tpHexaConverter.Padding = new System.Windows.Forms.Padding(3);
            this.tpHexaConverter.Size = new System.Drawing.Size(481, 329);
            this.tpHexaConverter.TabIndex = 2;
            this.tpHexaConverter.Text = "Hexadecimal Converter";
            // 
            // btnConvertForHexa
            // 
            this.btnConvertForHexa.Animated = true;
            this.btnConvertForHexa.BorderColor = System.Drawing.Color.Transparent;
            this.btnConvertForHexa.BorderRadius = 17;
            this.btnConvertForHexa.BorderThickness = 1;
            this.btnConvertForHexa.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnConvertForHexa.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnConvertForHexa.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnConvertForHexa.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnConvertForHexa.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnConvertForHexa.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold);
            this.btnConvertForHexa.ForeColor = System.Drawing.Color.White;
            this.btnConvertForHexa.Location = new System.Drawing.Point(205, 89);
            this.btnConvertForHexa.Name = "btnConvertForHexa";
            this.btnConvertForHexa.Size = new System.Drawing.Size(172, 45);
            this.btnConvertForHexa.TabIndex = 36;
            this.btnConvertForHexa.Text = "Convert";
            this.btnConvertForHexa.Click += new System.EventHandler(this.btnConvertForHexa_Click);
            // 
            // lblOctalForHexa
            // 
            this.lblOctalForHexa.AutoSize = true;
            this.lblOctalForHexa.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOctalForHexa.ForeColor = System.Drawing.Color.Black;
            this.lblOctalForHexa.Location = new System.Drawing.Point(165, 269);
            this.lblOctalForHexa.Name = "lblOctalForHexa";
            this.lblOctalForHexa.Size = new System.Drawing.Size(56, 25);
            this.lblOctalForHexa.TabIndex = 35;
            this.lblOctalForHexa.Text = "[????]";
            // 
            // lblDecimalForHexa
            // 
            this.lblDecimalForHexa.AutoSize = true;
            this.lblDecimalForHexa.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDecimalForHexa.ForeColor = System.Drawing.Color.Black;
            this.lblDecimalForHexa.Location = new System.Drawing.Point(165, 213);
            this.lblDecimalForHexa.Name = "lblDecimalForHexa";
            this.lblDecimalForHexa.Size = new System.Drawing.Size(56, 25);
            this.lblDecimalForHexa.TabIndex = 34;
            this.lblDecimalForHexa.Text = "[????]";
            // 
            // lblBinaryForHexa
            // 
            this.lblBinaryForHexa.AutoSize = true;
            this.lblBinaryForHexa.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBinaryForHexa.ForeColor = System.Drawing.Color.Black;
            this.lblBinaryForHexa.Location = new System.Drawing.Point(165, 155);
            this.lblBinaryForHexa.Name = "lblBinaryForHexa";
            this.lblBinaryForHexa.Size = new System.Drawing.Size(56, 25);
            this.lblBinaryForHexa.TabIndex = 33;
            this.lblBinaryForHexa.Text = "[????]";
            // 
            // txtHexadecimal
            // 
            this.txtHexadecimal.Animated = true;
            this.txtHexadecimal.BorderColor = System.Drawing.Color.Gray;
            this.txtHexadecimal.BorderRadius = 17;
            this.txtHexadecimal.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtHexadecimal.DefaultText = "";
            this.txtHexadecimal.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtHexadecimal.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtHexadecimal.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtHexadecimal.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtHexadecimal.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtHexadecimal.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold);
            this.txtHexadecimal.ForeColor = System.Drawing.Color.Black;
            this.txtHexadecimal.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtHexadecimal.Location = new System.Drawing.Point(165, 35);
            this.txtHexadecimal.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.txtHexadecimal.Name = "txtHexadecimal";
            this.txtHexadecimal.PasswordChar = '\0';
            this.txtHexadecimal.PlaceholderText = "";
            this.txtHexadecimal.SelectedText = "";
            this.txtHexadecimal.Size = new System.Drawing.Size(284, 41);
            this.txtHexadecimal.TabIndex = 32;
            this.txtHexadecimal.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtHexadecimal_KeyPress);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.Black;
            this.label13.Location = new System.Drawing.Point(32, 269);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(62, 25);
            this.label13.TabIndex = 31;
            this.label13.Text = "Octal:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.Black;
            this.label14.Location = new System.Drawing.Point(32, 213);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(87, 25);
            this.label14.TabIndex = 30;
            this.label14.Text = "Decimal:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.Black;
            this.label15.Location = new System.Drawing.Point(32, 155);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(72, 25);
            this.label15.TabIndex = 29;
            this.label15.Text = "Binary:";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.Color.Black;
            this.label16.Location = new System.Drawing.Point(32, 36);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(128, 25);
            this.label16.TabIndex = 28;
            this.label16.Text = "Hexadecimal:";
            // 
            // tpOctalConverter
            // 
            this.tpOctalConverter.BackColor = System.Drawing.Color.White;
            this.tpOctalConverter.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tpOctalConverter.Controls.Add(this.btnConvertForOctal);
            this.tpOctalConverter.Controls.Add(this.lblHexaForOctal);
            this.tpOctalConverter.Controls.Add(this.lblDecimalForOctal);
            this.tpOctalConverter.Controls.Add(this.lblBinaryForOctal);
            this.tpOctalConverter.Controls.Add(this.txtOctal);
            this.tpOctalConverter.Controls.Add(this.label17);
            this.tpOctalConverter.Controls.Add(this.label18);
            this.tpOctalConverter.Controls.Add(this.label19);
            this.tpOctalConverter.Controls.Add(this.label20);
            this.tpOctalConverter.Location = new System.Drawing.Point(184, 4);
            this.tpOctalConverter.Name = "tpOctalConverter";
            this.tpOctalConverter.Padding = new System.Windows.Forms.Padding(3);
            this.tpOctalConverter.Size = new System.Drawing.Size(481, 329);
            this.tpOctalConverter.TabIndex = 3;
            this.tpOctalConverter.Text = "Octal Converter";
            // 
            // btnConvertForOctal
            // 
            this.btnConvertForOctal.Animated = true;
            this.btnConvertForOctal.BorderColor = System.Drawing.Color.Transparent;
            this.btnConvertForOctal.BorderRadius = 17;
            this.btnConvertForOctal.BorderThickness = 1;
            this.btnConvertForOctal.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnConvertForOctal.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnConvertForOctal.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnConvertForOctal.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnConvertForOctal.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnConvertForOctal.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold);
            this.btnConvertForOctal.ForeColor = System.Drawing.Color.White;
            this.btnConvertForOctal.Location = new System.Drawing.Point(205, 89);
            this.btnConvertForOctal.Name = "btnConvertForOctal";
            this.btnConvertForOctal.Size = new System.Drawing.Size(172, 45);
            this.btnConvertForOctal.TabIndex = 45;
            this.btnConvertForOctal.Text = "Convert";
            this.btnConvertForOctal.Click += new System.EventHandler(this.btnConvertForOctal_Click);
            // 
            // lblHexaForOctal
            // 
            this.lblHexaForOctal.AutoSize = true;
            this.lblHexaForOctal.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHexaForOctal.ForeColor = System.Drawing.Color.Black;
            this.lblHexaForOctal.Location = new System.Drawing.Point(165, 269);
            this.lblHexaForOctal.Name = "lblHexaForOctal";
            this.lblHexaForOctal.Size = new System.Drawing.Size(56, 25);
            this.lblHexaForOctal.TabIndex = 44;
            this.lblHexaForOctal.Text = "[????]";
            // 
            // lblDecimalForOctal
            // 
            this.lblDecimalForOctal.AutoSize = true;
            this.lblDecimalForOctal.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDecimalForOctal.ForeColor = System.Drawing.Color.Black;
            this.lblDecimalForOctal.Location = new System.Drawing.Point(165, 213);
            this.lblDecimalForOctal.Name = "lblDecimalForOctal";
            this.lblDecimalForOctal.Size = new System.Drawing.Size(56, 25);
            this.lblDecimalForOctal.TabIndex = 43;
            this.lblDecimalForOctal.Text = "[????]";
            // 
            // lblBinaryForOctal
            // 
            this.lblBinaryForOctal.AutoSize = true;
            this.lblBinaryForOctal.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBinaryForOctal.ForeColor = System.Drawing.Color.Black;
            this.lblBinaryForOctal.Location = new System.Drawing.Point(165, 155);
            this.lblBinaryForOctal.Name = "lblBinaryForOctal";
            this.lblBinaryForOctal.Size = new System.Drawing.Size(56, 25);
            this.lblBinaryForOctal.TabIndex = 42;
            this.lblBinaryForOctal.Text = "[????]";
            // 
            // txtOctal
            // 
            this.txtOctal.Animated = true;
            this.txtOctal.BorderColor = System.Drawing.Color.Gray;
            this.txtOctal.BorderRadius = 17;
            this.txtOctal.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtOctal.DefaultText = "";
            this.txtOctal.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtOctal.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtOctal.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtOctal.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtOctal.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtOctal.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold);
            this.txtOctal.ForeColor = System.Drawing.Color.Black;
            this.txtOctal.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtOctal.Location = new System.Drawing.Point(165, 35);
            this.txtOctal.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.txtOctal.Name = "txtOctal";
            this.txtOctal.PasswordChar = '\0';
            this.txtOctal.PlaceholderText = "";
            this.txtOctal.SelectedText = "";
            this.txtOctal.Size = new System.Drawing.Size(284, 41);
            this.txtOctal.TabIndex = 41;
            this.txtOctal.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtOctal_KeyPress);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ForeColor = System.Drawing.Color.Black;
            this.label17.Location = new System.Drawing.Point(32, 269);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(128, 25);
            this.label17.TabIndex = 40;
            this.label17.Text = "Hexadecimal:";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.ForeColor = System.Drawing.Color.Black;
            this.label18.Location = new System.Drawing.Point(32, 213);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(87, 25);
            this.label18.TabIndex = 39;
            this.label18.Text = "Decimal:";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.ForeColor = System.Drawing.Color.Black;
            this.label19.Location = new System.Drawing.Point(32, 155);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(72, 25);
            this.label19.TabIndex = 38;
            this.label19.Text = "Binary:";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.ForeColor = System.Drawing.Color.Black;
            this.label20.Location = new System.Drawing.Point(32, 36);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(62, 25);
            this.label20.TabIndex = 37;
            this.label20.Text = "Octal:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(702, 466);
            this.Controls.Add(this.tcConverter);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.btnReset);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Converter";
            this.tcConverter.ResumeLayout(false);
            this.tpBinaryConverter.ResumeLayout(false);
            this.tpBinaryConverter.PerformLayout();
            this.tpDecimalConverter.ResumeLayout(false);
            this.tpDecimalConverter.PerformLayout();
            this.tpHexaConverter.ResumeLayout(false);
            this.tpHexaConverter.PerformLayout();
            this.tpOctalConverter.ResumeLayout(false);
            this.tpOctalConverter.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI2.WinForms.Guna2GradientButton btnReset;
        private System.Windows.Forms.Label lblTitle;
        private Guna.UI2.WinForms.Guna2TabControl tcConverter;
        private System.Windows.Forms.TabPage tpBinaryConverter;
        private Guna.UI2.WinForms.Guna2GradientButton btnConvertForBinary;
        private System.Windows.Forms.Label lblOctalForBinary;
        private System.Windows.Forms.Label lblHexaForBinary;
        private System.Windows.Forms.Label lblDecimalForBinary;
        private Guna.UI2.WinForms.Guna2TextBox txtBinary;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tpDecimalConverter;
        private System.Windows.Forms.TabPage tpHexaConverter;
        private System.Windows.Forms.TabPage tpOctalConverter;
        private Guna.UI2.WinForms.Guna2GradientButton btnConvertForDecimal;
        private System.Windows.Forms.Label lblOctalForDecimal;
        private System.Windows.Forms.Label lblHexaForDecimal;
        private System.Windows.Forms.Label lblBinaryForDecimal;
        private Guna.UI2.WinForms.Guna2TextBox txtDecimal;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private Guna.UI2.WinForms.Guna2GradientButton btnConvertForHexa;
        private System.Windows.Forms.Label lblOctalForHexa;
        private System.Windows.Forms.Label lblDecimalForHexa;
        private System.Windows.Forms.Label lblBinaryForHexa;
        private Guna.UI2.WinForms.Guna2TextBox txtHexadecimal;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private Guna.UI2.WinForms.Guna2GradientButton btnConvertForOctal;
        private System.Windows.Forms.Label lblHexaForOctal;
        private System.Windows.Forms.Label lblDecimalForOctal;
        private System.Windows.Forms.Label lblBinaryForOctal;
        private Guna.UI2.WinForms.Guna2TextBox txtOctal;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
    }
}

