namespace SampleCalendar
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
            this.Calendar = new Pabo.Calendar.MonthCalendar();
            this.button1 = new System.Windows.Forms.Button();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dt_From = new System.Windows.Forms.DateTimePicker();
            this.dt_To = new System.Windows.Forms.DateTimePicker();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Calendar
            // 
            this.Calendar.ActiveMonth.Month = 7;
            this.Calendar.ActiveMonth.Year = 2016;
            this.Calendar.Culture = new System.Globalization.CultureInfo("en-US");
            this.Calendar.Footer.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.Calendar.Header.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.Calendar.Header.TextColor = System.Drawing.Color.White;
            this.Calendar.ImageList = null;
            this.Calendar.Location = new System.Drawing.Point(20, 36);
            this.Calendar.MaxDate = new System.DateTime(2026, 7, 6, 22, 43, 37, 80);
            this.Calendar.MinDate = new System.DateTime(2006, 7, 6, 22, 43, 37, 80);
            this.Calendar.Month.BackgroundImage = null;
            this.Calendar.Month.DateFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.Calendar.Month.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.Calendar.Name = "Calendar";
            this.Calendar.ShowFooter = false;
            this.Calendar.Size = new System.Drawing.Size(260, 202);
            this.Calendar.TabIndex = 0;
            this.Calendar.Weekdays.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.Calendar.Weeknumbers.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.Calendar.DaySelected += new Pabo.Calendar.DaySelectedEventHandler(this.Calendar_DaySelected);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(205, 277);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Choose";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(17, 265);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "From";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.Location = new System.Drawing.Point(17, 295);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(21, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "To";
            // 
            // dt_From
            // 
            this.dt_From.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dt_From.Location = new System.Drawing.Point(59, 265);
            this.dt_From.Name = "dt_From";
            this.dt_From.Size = new System.Drawing.Size(124, 20);
            this.dt_From.TabIndex = 6;
            // 
            // dt_To
            // 
            this.dt_To.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dt_To.Location = new System.Drawing.Point(59, 295);
            this.dt_To.Name = "dt_To";
            this.dt_To.Size = new System.Drawing.Size(124, 20);
            this.dt_To.TabIndex = 7;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(299, 24);
            this.menuStrip1.TabIndex = 8;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(299, 325);
            this.Controls.Add(this.dt_To);
            this.Controls.Add(this.dt_From);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Calendar);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Calendar";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Pabo.Calendar.MonthCalendar Calendar;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dt_From;
        private System.Windows.Forms.DateTimePicker dt_To;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
    }
}

