namespace MusicAlarm.GUI
{
    partial class AddAlarm
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.addAlarmButton = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.textBoxHour = new System.Windows.Forms.TextBox();
            this.textBoxMinute = new System.Windows.Forms.TextBox();
            this.listBox = new System.Windows.Forms.ListBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // addAlarmButton
            // 
            this.addAlarmButton.Location = new System.Drawing.Point(399, 2);
            this.addAlarmButton.Name = "addAlarmButton";
            this.addAlarmButton.Size = new System.Drawing.Size(75, 23);
            this.addAlarmButton.TabIndex = 0;
            this.addAlarmButton.Text = "Add";
            this.addAlarmButton.UseVisualStyleBackColor = true;
            this.addAlarmButton.Click += new System.EventHandler(this.addAlarmButton_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(3, 5);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 1;
            // 
            // textBoxHour
            // 
            this.textBoxHour.Location = new System.Drawing.Point(209, 5);
            this.textBoxHour.Name = "textBoxHour";
            this.textBoxHour.Size = new System.Drawing.Size(25, 20);
            this.textBoxHour.TabIndex = 2;
            this.textBoxHour.Text = "12";
            // 
            // textBoxMinute
            // 
            this.textBoxMinute.Location = new System.Drawing.Point(240, 5);
            this.textBoxMinute.Name = "textBoxMinute";
            this.textBoxMinute.Size = new System.Drawing.Size(25, 20);
            this.textBoxMinute.TabIndex = 3;
            this.textBoxMinute.Text = "00";
            // 
            // listBox
            // 
            this.listBox.FormattingEnabled = true;
            this.listBox.Location = new System.Drawing.Point(1, 31);
            this.listBox.Name = "listBox";
            this.listBox.Size = new System.Drawing.Size(473, 160);
            this.listBox.TabIndex = 4;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(272, 3);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 5;
            // 
            // AddAlarm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.listBox);
            this.Controls.Add(this.textBoxMinute);
            this.Controls.Add(this.textBoxHour);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.addAlarmButton);
            this.Name = "AddAlarm";
            this.Size = new System.Drawing.Size(483, 198);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button addAlarmButton;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox textBoxHour;
        private System.Windows.Forms.TextBox textBoxMinute;
        private System.Windows.Forms.ListBox listBox;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}
