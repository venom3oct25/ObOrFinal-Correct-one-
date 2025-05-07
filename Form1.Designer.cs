namespace ObOrFinal
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
            this.nascarbutton = new System.Windows.Forms.Button();
            this.footballbutton = new System.Windows.Forms.Button();
            this.baseballbutton = new System.Windows.Forms.Button();
            this.pastfilebutton = new System.Windows.Forms.Button();
            this.hidegoodcheck = new System.Windows.Forms.CheckBox();
            this.Programtitle = new System.Windows.Forms.Label();
            this.inputbox = new System.Windows.Forms.TextBox();
            this.pastdatabox = new System.Windows.Forms.TextBox();
            this.curdatabox = new System.Windows.Forms.TextBox();
            this.Changes = new System.Windows.Forms.TextBox();
            this.textboxlabel = new System.Windows.Forms.Label();
            this.savebut = new System.Windows.Forms.Button();
            this.thebigone = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // nascarbutton
            // 
            this.nascarbutton.Location = new System.Drawing.Point(37, 102);
            this.nascarbutton.Margin = new System.Windows.Forms.Padding(2);
            this.nascarbutton.Name = "nascarbutton";
            this.nascarbutton.Size = new System.Drawing.Size(90, 52);
            this.nascarbutton.TabIndex = 0;
            this.nascarbutton.Text = "NASCAR";
            this.nascarbutton.UseVisualStyleBackColor = true;
            this.nascarbutton.Click += new System.EventHandler(this.nascarbutton_Click);
            // 
            // footballbutton
            // 
            this.footballbutton.Location = new System.Drawing.Point(37, 165);
            this.footballbutton.Margin = new System.Windows.Forms.Padding(2);
            this.footballbutton.Name = "footballbutton";
            this.footballbutton.Size = new System.Drawing.Size(90, 52);
            this.footballbutton.TabIndex = 1;
            this.footballbutton.Text = "Football";
            this.footballbutton.UseVisualStyleBackColor = true;
            this.footballbutton.Click += new System.EventHandler(this.footballbutton_Click);
            // 
            // baseballbutton
            // 
            this.baseballbutton.Location = new System.Drawing.Point(37, 233);
            this.baseballbutton.Margin = new System.Windows.Forms.Padding(2);
            this.baseballbutton.Name = "baseballbutton";
            this.baseballbutton.Size = new System.Drawing.Size(90, 52);
            this.baseballbutton.TabIndex = 2;
            this.baseballbutton.Text = "Baseball";
            this.baseballbutton.UseVisualStyleBackColor = true;
            this.baseballbutton.Click += new System.EventHandler(this.baseballbutton_Click);
            // 
            // pastfilebutton
            // 
            this.pastfilebutton.Location = new System.Drawing.Point(37, 354);
            this.pastfilebutton.Margin = new System.Windows.Forms.Padding(2);
            this.pastfilebutton.Name = "pastfilebutton";
            this.pastfilebutton.Size = new System.Drawing.Size(90, 20);
            this.pastfilebutton.TabIndex = 4;
            this.pastfilebutton.Text = "Print Past File";
            this.pastfilebutton.UseVisualStyleBackColor = true;
            this.pastfilebutton.Click += new System.EventHandler(this.pastfilebutton_Click);
            // 
            // hidegoodcheck
            // 
            this.hidegoodcheck.AutoSize = true;
            this.hidegoodcheck.Location = new System.Drawing.Point(37, 333);
            this.hidegoodcheck.Margin = new System.Windows.Forms.Padding(2);
            this.hidegoodcheck.Name = "hidegoodcheck";
            this.hidegoodcheck.Size = new System.Drawing.Size(137, 17);
            this.hidegoodcheck.TabIndex = 5;
            this.hidegoodcheck.Text = "Hide Postive Changes?";
            this.hidegoodcheck.UseVisualStyleBackColor = true;
            // 
            // Programtitle
            // 
            this.Programtitle.AutoSize = true;
            this.Programtitle.Location = new System.Drawing.Point(34, 15);
            this.Programtitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Programtitle.Name = "Programtitle";
            this.Programtitle.Size = new System.Drawing.Size(143, 13);
            this.Programtitle.TabIndex = 6;
            this.Programtitle.Text = "I Hate This Guy Stat Tracker";
            this.Programtitle.Click += new System.EventHandler(this.label1_Click);
            // 
            // inputbox
            // 
            this.inputbox.Location = new System.Drawing.Point(37, 53);
            this.inputbox.Margin = new System.Windows.Forms.Padding(2);
            this.inputbox.Name = "inputbox";
            this.inputbox.Size = new System.Drawing.Size(188, 20);
            this.inputbox.TabIndex = 7;
            this.inputbox.TextChanged += new System.EventHandler(this.inputbox_TextChanged);
            // 
            // pastdatabox
            // 
            this.pastdatabox.BackColor = System.Drawing.SystemColors.MenuText;
            this.pastdatabox.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.pastdatabox.Location = new System.Drawing.Point(291, 15);
            this.pastdatabox.Margin = new System.Windows.Forms.Padding(2);
            this.pastdatabox.Multiline = true;
            this.pastdatabox.Name = "pastdatabox";
            this.pastdatabox.ReadOnly = true;
            this.pastdatabox.Size = new System.Drawing.Size(222, 106);
            this.pastdatabox.TabIndex = 8;
            this.pastdatabox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // curdatabox
            // 
            this.curdatabox.BackColor = System.Drawing.SystemColors.MenuText;
            this.curdatabox.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.curdatabox.Location = new System.Drawing.Point(291, 142);
            this.curdatabox.Margin = new System.Windows.Forms.Padding(2);
            this.curdatabox.Multiline = true;
            this.curdatabox.Name = "curdatabox";
            this.curdatabox.ReadOnly = true;
            this.curdatabox.Size = new System.Drawing.Size(222, 106);
            this.curdatabox.TabIndex = 9;
            this.curdatabox.TextChanged += new System.EventHandler(this.curdatabox_TextChanged);
            // 
            // Changes
            // 
            this.Changes.BackColor = System.Drawing.SystemColors.MenuText;
            this.Changes.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.Changes.Location = new System.Drawing.Point(291, 271);
            this.Changes.Margin = new System.Windows.Forms.Padding(2);
            this.Changes.Multiline = true;
            this.Changes.Name = "Changes";
            this.Changes.ReadOnly = true;
            this.Changes.Size = new System.Drawing.Size(222, 106);
            this.Changes.TabIndex = 10;
            // 
            // textboxlabel
            // 
            this.textboxlabel.AutoSize = true;
            this.textboxlabel.Location = new System.Drawing.Point(36, 38);
            this.textboxlabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.textboxlabel.Name = "textboxlabel";
            this.textboxlabel.Size = new System.Drawing.Size(91, 13);
            this.textboxlabel.TabIndex = 11;
            this.textboxlabel.Text = "Input player name";
            // 
            // savebut
            // 
            this.savebut.Location = new System.Drawing.Point(160, 354);
            this.savebut.Margin = new System.Windows.Forms.Padding(2);
            this.savebut.Name = "savebut";
            this.savebut.Size = new System.Drawing.Size(90, 20);
            this.savebut.TabIndex = 12;
            this.savebut.Text = "Save data";
            this.savebut.UseVisualStyleBackColor = true;
            this.savebut.Click += new System.EventHandler(this.savebut_Click);
            // 
            // thebigone
            // 
            this.thebigone.BackColor = System.Drawing.SystemColors.MenuText;
            this.thebigone.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.thebigone.Location = new System.Drawing.Point(537, 11);
            this.thebigone.Margin = new System.Windows.Forms.Padding(2);
            this.thebigone.Multiline = true;
            this.thebigone.Name = "thebigone";
            this.thebigone.ReadOnly = true;
            this.thebigone.Size = new System.Drawing.Size(371, 366);
            this.thebigone.TabIndex = 13;
            this.thebigone.TextChanged += new System.EventHandler(this.textBox1_TextChanged_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(910, 385);
            this.Controls.Add(this.thebigone);
            this.Controls.Add(this.savebut);
            this.Controls.Add(this.textboxlabel);
            this.Controls.Add(this.Changes);
            this.Controls.Add(this.curdatabox);
            this.Controls.Add(this.pastdatabox);
            this.Controls.Add(this.inputbox);
            this.Controls.Add(this.Programtitle);
            this.Controls.Add(this.hidegoodcheck);
            this.Controls.Add(this.pastfilebutton);
            this.Controls.Add(this.baseballbutton);
            this.Controls.Add(this.footballbutton);
            this.Controls.Add(this.nascarbutton);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button nascarbutton;
        private System.Windows.Forms.Button footballbutton;
        private System.Windows.Forms.Button baseballbutton;
        private System.Windows.Forms.Button pastfilebutton;
        private System.Windows.Forms.CheckBox hidegoodcheck;
        private System.Windows.Forms.Label Programtitle;
        private System.Windows.Forms.TextBox inputbox;
        private System.Windows.Forms.TextBox pastdatabox;
        private System.Windows.Forms.TextBox curdatabox;
        private System.Windows.Forms.TextBox Changes;
        private System.Windows.Forms.Label textboxlabel;
        private System.Windows.Forms.Button savebut;
        private System.Windows.Forms.TextBox thebigone;
    }
}

