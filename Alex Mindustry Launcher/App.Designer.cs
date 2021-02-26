namespace Alex_Mindustry_Launcher
{
    partial class App
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.credit = new System.Windows.Forms.Button();
            this.exptoax = new System.Windows.Forms.Button();
            this.discord = new System.Windows.Forms.Button();
            this.github = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Green;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.checkedListBox1);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(164, 385);
            this.panel1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Audiowide", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.label2.Location = new System.Drawing.Point(1, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Server list";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.BackColor = System.Drawing.Color.Green;
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Location = new System.Drawing.Point(1, 75);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(163, 310);
            this.checkedListBox1.TabIndex = 0;
            this.checkedListBox1.SelectedIndexChanged += new System.EventHandler(this.checkedListBox1_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.button1.Font = new System.Drawing.Font("Audiowide", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button1.Location = new System.Drawing.Point(277, 331);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(258, 66);
            this.button1.TabIndex = 1;
            this.button1.Text = "Run Mindustry";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.credit);
            this.panel2.Controls.Add(this.exptoax);
            this.panel2.Controls.Add(this.discord);
            this.panel2.Controls.Add(this.github);
            this.panel2.Location = new System.Drawing.Point(624, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(164, 385);
            this.panel2.TabIndex = 0;
            // 
            // credit
            // 
            this.credit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.credit.Font = new System.Drawing.Font("Audiowide", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.credit.Location = new System.Drawing.Point(0, 133);
            this.credit.Name = "credit";
            this.credit.Size = new System.Drawing.Size(164, 23);
            this.credit.TabIndex = 0;
            this.credit.Text = "Credits";
            this.credit.UseVisualStyleBackColor = false;
            this.credit.Click += new System.EventHandler(this.credit_Click);
            // 
            // exptoax
            // 
            this.exptoax.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.exptoax.Font = new System.Drawing.Font("Audiowide", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.exptoax.Location = new System.Drawing.Point(0, 104);
            this.exptoax.Name = "exptoax";
            this.exptoax.Size = new System.Drawing.Size(164, 23);
            this.exptoax.TabIndex = 0;
            this.exptoax.Text = "EXP to Ax Convert";
            this.exptoax.UseVisualStyleBackColor = false;
            // 
            // discord
            // 
            this.discord.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.discord.Font = new System.Drawing.Font("Audiowide", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.discord.Location = new System.Drawing.Point(0, 75);
            this.discord.Name = "discord";
            this.discord.Size = new System.Drawing.Size(164, 23);
            this.discord.TabIndex = 0;
            this.discord.Text = "Discord";
            this.discord.UseVisualStyleBackColor = false;
            this.discord.Click += new System.EventHandler(this.discord_Click);
            // 
            // github
            // 
            this.github.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.github.Font = new System.Drawing.Font("Audiowide", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.github.Location = new System.Drawing.Point(0, 46);
            this.github.Name = "github";
            this.github.Size = new System.Drawing.Size(164, 23);
            this.github.TabIndex = 0;
            this.github.Text = "Github";
            this.github.UseVisualStyleBackColor = false;
            this.github.Click += new System.EventHandler(this.github_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(277, 229);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(258, 23);
            this.textBox1.TabIndex = 2;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Audiowide", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(277, 200);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 21);
            this.label1.TabIndex = 3;
            this.label1.Text = "Mindustry Path";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // App
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Green;
            this.ClientSize = new System.Drawing.Size(800, 409);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "App";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button discord;
        private System.Windows.Forms.Button github;
        private System.Windows.Forms.Button exptoax;
        private System.Windows.Forms.Button credit;
    }
}