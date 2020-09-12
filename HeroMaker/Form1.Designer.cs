namespace HeroMaker
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
            this.label1 = new System.Windows.Forms.Label();
            this.txt_name = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chk_fly = new System.Windows.Forms.CheckBox();
            this.chk_fire = new System.Windows.Forms.CheckBox();
            this.chk_laser = new System.Windows.Forms.CheckBox();
            this.chk_time = new System.Windows.Forms.CheckBox();
            this.chk_speed = new System.Windows.Forms.CheckBox();
            this.chk_strength = new System.Windows.Forms.CheckBox();
            this.chk_invis = new System.Windows.Forms.CheckBox();
            this.chk_animals = new System.Windows.Forms.CheckBox();
            this.chk_teleki = new System.Windows.Forms.CheckBox();
            this.chk_water = new System.Windows.Forms.CheckBox();
            this.btn_create = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Hero\'s Name :";
            // 
            // txt_name
            // 
            this.txt_name.Location = new System.Drawing.Point(93, 12);
            this.txt_name.Name = "txt_name";
            this.txt_name.Size = new System.Drawing.Size(226, 20);
            this.txt_name.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.chk_water);
            this.groupBox1.Controls.Add(this.chk_teleki);
            this.groupBox1.Controls.Add(this.chk_animals);
            this.groupBox1.Controls.Add(this.chk_invis);
            this.groupBox1.Controls.Add(this.chk_strength);
            this.groupBox1.Controls.Add(this.chk_speed);
            this.groupBox1.Controls.Add(this.chk_time);
            this.groupBox1.Controls.Add(this.chk_laser);
            this.groupBox1.Controls.Add(this.chk_fire);
            this.groupBox1.Controls.Add(this.chk_fly);
            this.groupBox1.Location = new System.Drawing.Point(16, 47);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(303, 149);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Special Abilites";
            // 
            // chk_fly
            // 
            this.chk_fly.AutoSize = true;
            this.chk_fly.Location = new System.Drawing.Point(7, 20);
            this.chk_fly.Name = "chk_fly";
            this.chk_fly.Size = new System.Drawing.Size(58, 17);
            this.chk_fly.TabIndex = 0;
            this.chk_fly.Text = "Can fly";
            this.chk_fly.UseVisualStyleBackColor = true;
            // 
            // chk_fire
            // 
            this.chk_fire.AutoSize = true;
            this.chk_fire.Location = new System.Drawing.Point(7, 44);
            this.chk_fire.Name = "chk_fire";
            this.chk_fire.Size = new System.Drawing.Size(77, 17);
            this.chk_fire.TabIndex = 1;
            this.chk_fire.Text = "Fire Breath";
            this.chk_fire.UseVisualStyleBackColor = true;
            // 
            // chk_laser
            // 
            this.chk_laser.AutoSize = true;
            this.chk_laser.Location = new System.Drawing.Point(7, 68);
            this.chk_laser.Name = "chk_laser";
            this.chk_laser.Size = new System.Drawing.Size(73, 17);
            this.chk_laser.TabIndex = 2;
            this.chk_laser.Text = "Laser Eye";
            this.chk_laser.UseVisualStyleBackColor = true;
            // 
            // chk_time
            // 
            this.chk_time.AutoSize = true;
            this.chk_time.Location = new System.Drawing.Point(7, 92);
            this.chk_time.Name = "chk_time";
            this.chk_time.Size = new System.Drawing.Size(82, 17);
            this.chk_time.TabIndex = 3;
            this.chk_time.Text = "Time Travel";
            this.chk_time.UseVisualStyleBackColor = true;
            // 
            // chk_speed
            // 
            this.chk_speed.AutoSize = true;
            this.chk_speed.Location = new System.Drawing.Point(7, 116);
            this.chk_speed.Name = "chk_speed";
            this.chk_speed.Size = new System.Drawing.Size(88, 17);
            this.chk_speed.TabIndex = 4;
            this.chk_speed.Text = "Super Speed";
            this.chk_speed.UseVisualStyleBackColor = true;
            // 
            // chk_strength
            // 
            this.chk_strength.AutoSize = true;
            this.chk_strength.Location = new System.Drawing.Point(134, 20);
            this.chk_strength.Name = "chk_strength";
            this.chk_strength.Size = new System.Drawing.Size(97, 17);
            this.chk_strength.TabIndex = 5;
            this.chk_strength.Text = "Super Strength";
            this.chk_strength.UseVisualStyleBackColor = true;
            // 
            // chk_invis
            // 
            this.chk_invis.AutoSize = true;
            this.chk_invis.Location = new System.Drawing.Point(134, 44);
            this.chk_invis.Name = "chk_invis";
            this.chk_invis.Size = new System.Drawing.Size(70, 17);
            this.chk_invis.TabIndex = 6;
            this.chk_invis.Text = "Invisibility";
            this.chk_invis.UseVisualStyleBackColor = true;
            // 
            // chk_animals
            // 
            this.chk_animals.AutoSize = true;
            this.chk_animals.Location = new System.Drawing.Point(134, 68);
            this.chk_animals.Name = "chk_animals";
            this.chk_animals.Size = new System.Drawing.Size(100, 17);
            this.chk_animals.TabIndex = 7;
            this.chk_animals.Text = "Tallk to Animals";
            this.chk_animals.UseVisualStyleBackColor = true;
            // 
            // chk_teleki
            // 
            this.chk_teleki.AutoSize = true;
            this.chk_teleki.Location = new System.Drawing.Point(134, 92);
            this.chk_teleki.Name = "chk_teleki";
            this.chk_teleki.Size = new System.Drawing.Size(79, 17);
            this.chk_teleki.TabIndex = 8;
            this.chk_teleki.Text = "Telekinesis";
            this.chk_teleki.UseVisualStyleBackColor = true;
            // 
            // chk_water
            // 
            this.chk_water.AutoSize = true;
            this.chk_water.Location = new System.Drawing.Point(134, 116);
            this.chk_water.Name = "chk_water";
            this.chk_water.Size = new System.Drawing.Size(103, 17);
            this.chk_water.TabIndex = 9;
            this.chk_water.Text = "Water Breathing";
            this.chk_water.UseVisualStyleBackColor = true;
            // 
            // btn_create
            // 
            this.btn_create.Location = new System.Drawing.Point(671, 415);
            this.btn_create.Name = "btn_create";
            this.btn_create.Size = new System.Drawing.Size(75, 23);
            this.btn_create.TabIndex = 3;
            this.btn_create.Text = "Create Hero";
            this.btn_create.UseVisualStyleBackColor = true;
            this.btn_create.Click += new System.EventHandler(this.btn_create_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_create);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txt_name);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_name;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox chk_water;
        private System.Windows.Forms.CheckBox chk_teleki;
        private System.Windows.Forms.CheckBox chk_animals;
        private System.Windows.Forms.CheckBox chk_invis;
        private System.Windows.Forms.CheckBox chk_strength;
        private System.Windows.Forms.CheckBox chk_speed;
        private System.Windows.Forms.CheckBox chk_time;
        private System.Windows.Forms.CheckBox chk_laser;
        private System.Windows.Forms.CheckBox chk_fire;
        private System.Windows.Forms.CheckBox chk_fly;
        private System.Windows.Forms.Button btn_create;
    }
}

