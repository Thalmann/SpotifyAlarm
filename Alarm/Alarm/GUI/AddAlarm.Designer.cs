namespace Alarm.GUI
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
            this.SuspendLayout();
            // 
            // addAlarmButton
            // 
            this.addAlarmButton.Location = new System.Drawing.Point(209, 3);
            this.addAlarmButton.Name = "addAlarmButton";
            this.addAlarmButton.Size = new System.Drawing.Size(75, 23);
            this.addAlarmButton.TabIndex = 0;
            this.addAlarmButton.Text = "Add";
            this.addAlarmButton.UseVisualStyleBackColor = true;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(3, 5);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 1;
            // 
            // AddAlarm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.addAlarmButton);
            this.Name = "AddAlarm";
            this.Size = new System.Drawing.Size(287, 28);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button addAlarmButton;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
    }
}
