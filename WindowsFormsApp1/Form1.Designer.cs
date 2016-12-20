namespace WindowsFormsApp1
{
    partial class Form1
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
            this.costLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.healthyBox = new System.Windows.Forms.CheckBox();
            this.fancyBox = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.numOfPeopleUpDwn = new System.Windows.Forms.NumericUpDown();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.D = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.birthdayCost = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cakeWriting = new System.Windows.Forms.TextBox();
            this.tooLongLabel = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.fancyBirthday = new System.Windows.Forms.CheckBox();
            this.numberBirthday = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numOfPeopleUpDwn)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.D.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numberBirthday)).BeginInit();
            this.SuspendLayout();
            // 
            // costLabel
            // 
            this.costLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.costLabel.Location = new System.Drawing.Point(103, 143);
            this.costLabel.Name = "costLabel";
            this.costLabel.Size = new System.Drawing.Size(80, 22);
            this.costLabel.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(65, 144);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Cost";
            // 
            // healthyBox
            // 
            this.healthyBox.AutoSize = true;
            this.healthyBox.Location = new System.Drawing.Point(68, 103);
            this.healthyBox.Name = "healthyBox";
            this.healthyBox.Size = new System.Drawing.Size(96, 17);
            this.healthyBox.TabIndex = 9;
            this.healthyBox.Text = "Healthy Option";
            this.healthyBox.UseVisualStyleBackColor = true;
            this.healthyBox.CheckedChanged += new System.EventHandler(this.healthyBox_CheckedChanged);
            // 
            // fancyBox
            // 
            this.fancyBox.AutoSize = true;
            this.fancyBox.Checked = true;
            this.fancyBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.fancyBox.Location = new System.Drawing.Point(68, 79);
            this.fancyBox.Name = "fancyBox";
            this.fancyBox.Size = new System.Drawing.Size(115, 17);
            this.fancyBox.TabIndex = 8;
            this.fancyBox.Text = "Fancy Decorations";
            this.fancyBox.UseVisualStyleBackColor = true;
            this.fancyBox.CheckedChanged += new System.EventHandler(this.fancyBox_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(65, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Number of People";
            // 
            // numOfPeopleUpDwn
            // 
            this.numOfPeopleUpDwn.Location = new System.Drawing.Point(68, 53);
            this.numOfPeopleUpDwn.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.numOfPeopleUpDwn.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numOfPeopleUpDwn.Name = "numOfPeopleUpDwn";
            this.numOfPeopleUpDwn.Size = new System.Drawing.Size(120, 20);
            this.numOfPeopleUpDwn.TabIndex = 6;
            this.numOfPeopleUpDwn.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numOfPeopleUpDwn.ValueChanged += new System.EventHandler(this.numOfPeopleUpDwn_ValueChanged);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.D);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(260, 247);
            this.tabControl1.TabIndex = 12;
            // 
            // D
            // 
            this.D.Controls.Add(this.costLabel);
            this.D.Controls.Add(this.numOfPeopleUpDwn);
            this.D.Controls.Add(this.label2);
            this.D.Controls.Add(this.label1);
            this.D.Controls.Add(this.healthyBox);
            this.D.Controls.Add(this.fancyBox);
            this.D.Location = new System.Drawing.Point(4, 22);
            this.D.Name = "D";
            this.D.Padding = new System.Windows.Forms.Padding(3);
            this.D.Size = new System.Drawing.Size(252, 221);
            this.D.TabIndex = 0;
            this.D.Text = "Dinner Party";
            this.D.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.birthdayCost);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.cakeWriting);
            this.tabPage2.Controls.Add(this.tooLongLabel);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.fancyBirthday);
            this.tabPage2.Controls.Add(this.numberBirthday);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(252, 221);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Birthday Party";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // birthdayCost
            // 
            this.birthdayCost.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.birthdayCost.Location = new System.Drawing.Point(90, 145);
            this.birthdayCost.Name = "birthdayCost";
            this.birthdayCost.Size = new System.Drawing.Size(76, 20);
            this.birthdayCost.TabIndex = 7;
            this.birthdayCost.Text = "$";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(52, 148);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(32, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Cost";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // cakeWriting
            // 
            this.cakeWriting.Location = new System.Drawing.Point(52, 121);
            this.cakeWriting.Name = "cakeWriting";
            this.cakeWriting.Size = new System.Drawing.Size(134, 20);
            this.cakeWriting.TabIndex = 5;
            this.cakeWriting.Text = "Happy Birthday";
            this.cakeWriting.TextChanged += new System.EventHandler(this.cakeWriting_TextChanged);
            // 
            // tooLongLabel
            // 
            this.tooLongLabel.AutoSize = true;
            this.tooLongLabel.BackColor = System.Drawing.Color.Red;
            this.tooLongLabel.Location = new System.Drawing.Point(123, 105);
            this.tooLongLabel.Name = "tooLongLabel";
            this.tooLongLabel.Size = new System.Drawing.Size(63, 13);
            this.tooLongLabel.TabIndex = 4;
            this.tooLongLabel.Text = "TOO LONG";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(49, 105);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Cake Writing";
            // 
            // fancyBirthday
            // 
            this.fancyBirthday.AutoSize = true;
            this.fancyBirthday.Location = new System.Drawing.Point(52, 85);
            this.fancyBirthday.Name = "fancyBirthday";
            this.fancyBirthday.Size = new System.Drawing.Size(115, 17);
            this.fancyBirthday.TabIndex = 2;
            this.fancyBirthday.Text = "Fancy Decorations";
            this.fancyBirthday.UseVisualStyleBackColor = true;
            this.fancyBirthday.CheckedChanged += new System.EventHandler(this.fancyBirthday_CheckedChanged);
            // 
            // numberBirthday
            // 
            this.numberBirthday.Location = new System.Drawing.Point(52, 58);
            this.numberBirthday.Name = "numberBirthday";
            this.numberBirthday.Size = new System.Drawing.Size(89, 20);
            this.numberBirthday.TabIndex = 1;
            this.numberBirthday.ValueChanged += new System.EventHandler(this.numberBirthday_ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(49, 41);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Number of People";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(282, 266);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numOfPeopleUpDwn)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.D.ResumeLayout(false);
            this.D.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numberBirthday)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label costLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox healthyBox;
        private System.Windows.Forms.CheckBox fancyBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numOfPeopleUpDwn;
        private System.Windows.Forms.TabControl tabControl1;
        public System.Windows.Forms.TabPage D;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox cakeWriting;
        private System.Windows.Forms.Label tooLongLabel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox fancyBirthday;
        private System.Windows.Forms.NumericUpDown numberBirthday;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox birthdayCost;
    }
}

