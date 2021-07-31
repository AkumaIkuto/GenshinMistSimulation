
namespace SwordVisu
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.textBoxDMGbon = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Attacktimer = new System.Windows.Forms.Timer(this.components);
            this.Bursttimer = new System.Windows.Forms.Timer(this.components);
            this.Energytimer = new System.Windows.Forms.Timer(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxEnergy = new System.Windows.Forms.TextBox();
            this.textBoxAttackTimer = new System.Windows.Forms.TextBox();
            this.textBoxBurstTimer = new System.Windows.Forms.TextBox();
            this.UpdateTimer = new System.Windows.Forms.Timer(this.components);
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(135, 323);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(127, 82);
            this.button1.TabIndex = 0;
            this.button1.Text = "Attack";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(437, 323);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(145, 82);
            this.button2.TabIndex = 1;
            this.button2.Text = "Burst";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // textBoxDMGbon
            // 
            this.textBoxDMGbon.BackColor = System.Drawing.SystemColors.Window;
            this.textBoxDMGbon.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F);
            this.textBoxDMGbon.Location = new System.Drawing.Point(455, 37);
            this.textBoxDMGbon.Name = "textBoxDMGbon";
            this.textBoxDMGbon.ReadOnly = true;
            this.textBoxDMGbon.Size = new System.Drawing.Size(147, 45);
            this.textBoxDMGbon.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(185, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(264, 31);
            this.label1.TabIndex = 3;
            this.label1.Text = "Current DMG bonus:";
            // 
            // Attacktimer
            // 
            this.Attacktimer.Enabled = true;
            this.Attacktimer.Tick += new System.EventHandler(this.Attacktimer_Tick);
            // 
            // Bursttimer
            // 
            this.Bursttimer.Enabled = true;
            this.Bursttimer.Tick += new System.EventHandler(this.Bursttimer_Tick);
            // 
            // Energytimer
            // 
            this.Energytimer.Enabled = true;
            this.Energytimer.Tick += new System.EventHandler(this.Energytimer_Tick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(437, 148);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(150, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "Current Energy:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(454, 192);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(128, 25);
            this.label3.TabIndex = 5;
            this.label3.Text = "Attack Timer:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(460, 232);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(118, 25);
            this.label4.TabIndex = 6;
            this.label4.Text = "Burst Timer:";
            // 
            // textBoxEnergy
            // 
            this.textBoxEnergy.Location = new System.Drawing.Point(595, 150);
            this.textBoxEnergy.Name = "textBoxEnergy";
            this.textBoxEnergy.ReadOnly = true;
            this.textBoxEnergy.Size = new System.Drawing.Size(142, 20);
            this.textBoxEnergy.TabIndex = 8;
            // 
            // textBoxAttackTimer
            // 
            this.textBoxAttackTimer.Location = new System.Drawing.Point(595, 194);
            this.textBoxAttackTimer.Name = "textBoxAttackTimer";
            this.textBoxAttackTimer.ReadOnly = true;
            this.textBoxAttackTimer.Size = new System.Drawing.Size(142, 20);
            this.textBoxAttackTimer.TabIndex = 9;
            // 
            // textBoxBurstTimer
            // 
            this.textBoxBurstTimer.Location = new System.Drawing.Point(595, 237);
            this.textBoxBurstTimer.Name = "textBoxBurstTimer";
            this.textBoxBurstTimer.ReadOnly = true;
            this.textBoxBurstTimer.Size = new System.Drawing.Size(142, 20);
            this.textBoxBurstTimer.TabIndex = 10;
            // 
            // UpdateTimer
            // 
            this.UpdateTimer.Enabled = true;
            this.UpdateTimer.Tick += new System.EventHandler(this.UpdateTimer_Tick);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(43, 166);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(182, 103);
            this.richTextBox1.TabIndex = 11;
            this.richTextBox1.Text = "";
            this.richTextBox1.Visible = false;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(12, 421);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(114, 17);
            this.checkBox1.TabIndex = 12;
            this.checkBox1.Text = "Show Buff Tokens";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackgroundImage = global::SwordVisu.Properties.Resources._1615468048_youloveit_com_wallpaper_genshin_impact29;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.textBoxBurstTimer);
            this.Controls.Add(this.textBoxAttackTimer);
            this.Controls.Add(this.textBoxEnergy);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxDMGbon);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Sword Simulation";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textBoxDMGbon;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer Attacktimer;
        private System.Windows.Forms.Timer Bursttimer;
        private System.Windows.Forms.Timer Energytimer;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxEnergy;
        private System.Windows.Forms.TextBox textBoxAttackTimer;
        private System.Windows.Forms.TextBox textBoxBurstTimer;
        private System.Windows.Forms.Timer UpdateTimer;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.CheckBox checkBox1;
    }
}

