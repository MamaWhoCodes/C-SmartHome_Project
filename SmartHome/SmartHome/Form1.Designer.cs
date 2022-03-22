//Author: Sharon Mutugi
//Date  July 8th  2021

/* This Windows app, demonstrates the  use of Windows Forms
    by simulating smart home lighting controls. */

using System;

namespace SmartHome
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
            this.Porch = new System.Windows.Forms.PictureBox();
            this.FrontYard = new System.Windows.Forms.PictureBox();
            this.BackYard = new System.Windows.Forms.PictureBox();
            this.Bedroom = new System.Windows.Forms.PictureBox();
            this.Kitchen = new System.Windows.Forms.PictureBox();
            this.LightOnPicture = new System.Windows.Forms.PictureBox();
            this.LightOffPicture = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.AllOnButton = new System.Windows.Forms.Button();
            this.AllOffButton = new System.Windows.Forms.Button();
            this.OutsideOnButton = new System.Windows.Forms.Button();
            this.OutsideOffButton = new System.Windows.Forms.Button();
            this.InsideOnButton = new System.Windows.Forms.Button();
            this.InsideOffButton = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.ToggleOn = new System.Windows.Forms.PictureBox();
            this.ToggleOff = new System.Windows.Forms.PictureBox();
            this.FrontYdToggle = new System.Windows.Forms.Button();
            this.PorchToggleButton = new System.Windows.Forms.Button();
            this.BackYdToggle = new System.Windows.Forms.Button();
            this.BedroomToggle = new System.Windows.Forms.Button();
            this.KitchenToggle = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Porch)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FrontYard)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BackYard)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Bedroom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Kitchen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LightOnPicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LightOffPicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ToggleOn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ToggleOff)).BeginInit();
            this.SuspendLayout();
            // 
            // Porch
            // 
            this.Porch.Image = global::SmartHome.Properties.Resources.LightOn;
            this.Porch.Location = new System.Drawing.Point(30, 40);
            this.Porch.Name = "Porch";
            this.Porch.Size = new System.Drawing.Size(64, 60);
            this.Porch.TabIndex = 0;
            this.Porch.TabStop = false;
            // 
            // FrontYard
            // 
            this.FrontYard.Image = global::SmartHome.Properties.Resources.LightOn;
            this.FrontYard.Location = new System.Drawing.Point(30, 120);
            this.FrontYard.Name = "FrontYard";
            this.FrontYard.Size = new System.Drawing.Size(64, 60);
            this.FrontYard.TabIndex = 1;
            this.FrontYard.TabStop = false;
            // 
            // BackYard
            // 
            this.BackYard.Image = global::SmartHome.Properties.Resources.LightOn;
            this.BackYard.Location = new System.Drawing.Point(30, 200);
            this.BackYard.Name = "BackYard";
            this.BackYard.Size = new System.Drawing.Size(64, 60);
            this.BackYard.TabIndex = 2;
            this.BackYard.TabStop = false;
            // 
            // Bedroom
            // 
            this.Bedroom.Image = global::SmartHome.Properties.Resources.LightOn;
            this.Bedroom.Location = new System.Drawing.Point(30, 280);
            this.Bedroom.Name = "Bedroom";
            this.Bedroom.Size = new System.Drawing.Size(64, 61);
            this.Bedroom.TabIndex = 3;
            this.Bedroom.TabStop = false;
            // 
            // Kitchen
            // 
            this.Kitchen.Image = global::SmartHome.Properties.Resources.LightOn;
            this.Kitchen.Location = new System.Drawing.Point(30, 360);
            this.Kitchen.Name = "Kitchen";
            this.Kitchen.Size = new System.Drawing.Size(64, 60);
            this.Kitchen.TabIndex = 4;
            this.Kitchen.TabStop = false;
            // 
            // LightOnPicture
            // 
            this.LightOnPicture.Image = global::SmartHome.Properties.Resources.LightOn;
            this.LightOnPicture.Location = new System.Drawing.Point(30, 441);
            this.LightOnPicture.Name = "LightOnPicture";
            this.LightOnPicture.Size = new System.Drawing.Size(64, 60);
            this.LightOnPicture.TabIndex = 5;
            this.LightOnPicture.TabStop = false;
            this.LightOnPicture.Visible = false;
            // 
            // LightOffPicture
            // 
            this.LightOffPicture.Image = global::SmartHome.Properties.Resources.LightOff;
            this.LightOffPicture.Location = new System.Drawing.Point(117, 441);
            this.LightOffPicture.Name = "LightOffPicture";
            this.LightOffPicture.Size = new System.Drawing.Size(64, 60);
            this.LightOffPicture.TabIndex = 6;
            this.LightOffPicture.TabStop = false;
            this.LightOffPicture.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(100, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 20);
            this.label1.TabIndex = 7;
            this.label1.Text = "Porch Lights";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(100, 129);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(155, 20);
            this.label2.TabIndex = 8;
            this.label2.Text = "Front Yard Lights";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(100, 219);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(153, 20);
            this.label3.TabIndex = 9;
            this.label3.Text = "Back Yard Lights";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(100, 299);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(142, 20);
            this.label4.TabIndex = 10;
            this.label4.Text = "Bedroom Lights";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(100, 375);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(130, 20);
            this.label5.TabIndex = 11;
            this.label5.Text = "Kitchen Lights";
            // 
            // AllOnButton
            // 
            this.AllOnButton.Image = global::SmartHome.Properties.Resources.Run;
            this.AllOnButton.Location = new System.Drawing.Point(456, 44);
            this.AllOnButton.Name = "AllOnButton";
            this.AllOnButton.Size = new System.Drawing.Size(50, 45);
            this.AllOnButton.TabIndex = 12;
            this.AllOnButton.UseVisualStyleBackColor = true;
            this.AllOnButton.Click += new System.EventHandler(this.AllOnButton_Click);
            // 
            // AllOffButton
            // 
            this.AllOffButton.Image = global::SmartHome.Properties.Resources.Run;
            this.AllOffButton.Location = new System.Drawing.Point(456, 120);
            this.AllOffButton.Name = "AllOffButton";
            this.AllOffButton.Size = new System.Drawing.Size(50, 45);
            this.AllOffButton.TabIndex = 13;
            this.AllOffButton.UseVisualStyleBackColor = true;
            this.AllOffButton.Click += new System.EventHandler(this.AllOffButton_Click);
            // 
            // OutsideOnButton
            // 
            this.OutsideOnButton.Image = global::SmartHome.Properties.Resources.Run;
            this.OutsideOnButton.Location = new System.Drawing.Point(456, 200);
            this.OutsideOnButton.Name = "OutsideOnButton";
            this.OutsideOnButton.Size = new System.Drawing.Size(50, 45);
            this.OutsideOnButton.TabIndex = 14;
            this.OutsideOnButton.UseVisualStyleBackColor = true;
            this.OutsideOnButton.Click += new System.EventHandler(this.OutsideOnButton_Click);
            // 
            // OutsideOffButton
            // 
            this.OutsideOffButton.Image = global::SmartHome.Properties.Resources.Run;
            this.OutsideOffButton.Location = new System.Drawing.Point(456, 285);
            this.OutsideOffButton.Name = "OutsideOffButton";
            this.OutsideOffButton.Size = new System.Drawing.Size(50, 45);
            this.OutsideOffButton.TabIndex = 15;
            this.OutsideOffButton.UseVisualStyleBackColor = true;
            this.OutsideOffButton.Click += new System.EventHandler(this.OutsideOffButton_Click);
            // 
            // InsideOnButton
            // 
            this.InsideOnButton.Image = global::SmartHome.Properties.Resources.Run;
            this.InsideOnButton.Location = new System.Drawing.Point(456, 361);
            this.InsideOnButton.Name = "InsideOnButton";
            this.InsideOnButton.Size = new System.Drawing.Size(50, 45);
            this.InsideOnButton.TabIndex = 16;
            this.InsideOnButton.UseVisualStyleBackColor = true;
            this.InsideOnButton.Click += new System.EventHandler(this.InsideOnButton_Click);
            // 
            // InsideOffButton
            // 
            this.InsideOffButton.Image = global::SmartHome.Properties.Resources.Run;
            this.InsideOffButton.Location = new System.Drawing.Point(456, 441);
            this.InsideOffButton.Name = "InsideOffButton";
            this.InsideOffButton.Size = new System.Drawing.Size(50, 45);
            this.InsideOffButton.TabIndex = 17;
            this.InsideOffButton.UseVisualStyleBackColor = true;
            this.InsideOffButton.Click += new System.EventHandler(this.InsideOffButton_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(538, 58);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(254, 24);
            this.label6.TabIndex = 18;
            this.label6.Text = "All On (Turns on all lights)";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(538, 133);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(243, 24);
            this.label7.TabIndex = 19;
            this.label7.Text = "All Off (Tuns off all lights)";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(538, 214);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(382, 24);
            this.label8.TabIndex = 20;
            this.label8.Text = "Outside On (Turns on all outside lights) ";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(538, 299);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(390, 24);
            this.label9.TabIndex = 21;
            this.label9.Text = "Outside Off (Tunrns off all outside lights) ";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(538, 375);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(354, 24);
            this.label10.TabIndex = 22;
            this.label10.Text = "Inside On (Turns on all inside lights) ";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(538, 455);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(350, 24);
            this.label11.TabIndex = 23;
            this.label11.Text = "Inside Off (Turns off all inside lights) ";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(556, 13);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(100, 29);
            this.label12.TabIndex = 24;
            this.label12.Text = "Scenes";
            // 
            // ToggleOn
            // 
            this.ToggleOn.Image = global::SmartHome.Properties.Resources.ToggleOn;
            this.ToggleOn.Location = new System.Drawing.Point(199, 441);
            this.ToggleOn.Name = "ToggleOn";
            this.ToggleOn.Size = new System.Drawing.Size(70, 60);
            this.ToggleOn.TabIndex = 26;
            this.ToggleOn.TabStop = false;
            this.ToggleOn.Visible = false;
            // 
            // ToggleOff
            // 
            this.ToggleOff.Image = global::SmartHome.Properties.Resources.ToggleOff;
            this.ToggleOff.Location = new System.Drawing.Point(285, 441);
            this.ToggleOff.Name = "ToggleOff";
            this.ToggleOff.Size = new System.Drawing.Size(70, 60);
            this.ToggleOff.TabIndex = 27;
            this.ToggleOff.TabStop = false;
            this.ToggleOff.Visible = false;
            // 
            // FrontYdToggle
            // 
            this.FrontYdToggle.Image = global::SmartHome.Properties.Resources.ToggleOn;
            this.FrontYdToggle.Location = new System.Drawing.Point(285, 103);
            this.FrontYdToggle.Name = "FrontYdToggle";
            this.FrontYdToggle.Size = new System.Drawing.Size(80, 75);
            this.FrontYdToggle.TabIndex = 28;
            this.FrontYdToggle.UseVisualStyleBackColor = true;
            this.FrontYdToggle.Click += new System.EventHandler(this.FrontYdToggle_Click);
            // 
            // PorchToggleButton
            // 
            this.PorchToggleButton.Image = global::SmartHome.Properties.Resources.ToggleOn;
            this.PorchToggleButton.Location = new System.Drawing.Point(285, 22);
            this.PorchToggleButton.Name = "PorchToggleButton";
            this.PorchToggleButton.Size = new System.Drawing.Size(80, 75);
            this.PorchToggleButton.TabIndex = 29;
            this.PorchToggleButton.UseVisualStyleBackColor = true;
            this.PorchToggleButton.Click += new System.EventHandler(this.PorchToggleButton_Click);
            // 
            // BackYdToggle
            // 
            this.BackYdToggle.Image = global::SmartHome.Properties.Resources.ToggleOn;
            this.BackYdToggle.Location = new System.Drawing.Point(285, 185);
            this.BackYdToggle.Name = "BackYdToggle";
            this.BackYdToggle.Size = new System.Drawing.Size(80, 75);
            this.BackYdToggle.TabIndex = 30;
            this.BackYdToggle.UseVisualStyleBackColor = true;
            this.BackYdToggle.Click += new System.EventHandler(this.BackYdToggle_Click);
            // 
            // BedroomToggle
            // 
            this.BedroomToggle.Image = global::SmartHome.Properties.Resources.ToggleOn;
            this.BedroomToggle.Location = new System.Drawing.Point(285, 275);
            this.BedroomToggle.Name = "BedroomToggle";
            this.BedroomToggle.Size = new System.Drawing.Size(80, 75);
            this.BedroomToggle.TabIndex = 31;
            this.BedroomToggle.UseVisualStyleBackColor = true;
            this.BedroomToggle.Click += new System.EventHandler(this.BedroomToggle_Click);
            // 
            // KitchenToggle
            // 
            this.KitchenToggle.Image = global::SmartHome.Properties.Resources.ToggleOn;
            this.KitchenToggle.Location = new System.Drawing.Point(285, 360);
            this.KitchenToggle.Name = "KitchenToggle";
            this.KitchenToggle.Size = new System.Drawing.Size(80, 75);
            this.KitchenToggle.TabIndex = 32;
            this.KitchenToggle.UseVisualStyleBackColor = true;
            this.KitchenToggle.Click += new System.EventHandler(this.KitchenToggle_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(925, 519);
            this.Controls.Add(this.KitchenToggle);
            this.Controls.Add(this.BedroomToggle);
            this.Controls.Add(this.BackYdToggle);
            this.Controls.Add(this.PorchToggleButton);
            this.Controls.Add(this.FrontYdToggle);
            this.Controls.Add(this.ToggleOff);
            this.Controls.Add(this.ToggleOn);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.InsideOffButton);
            this.Controls.Add(this.InsideOnButton);
            this.Controls.Add(this.OutsideOffButton);
            this.Controls.Add(this.OutsideOnButton);
            this.Controls.Add(this.AllOffButton);
            this.Controls.Add(this.AllOnButton);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LightOffPicture);
            this.Controls.Add(this.LightOnPicture);
            this.Controls.Add(this.Kitchen);
            this.Controls.Add(this.Bedroom);
            this.Controls.Add(this.BackYard);
            this.Controls.Add(this.FrontYard);
            this.Controls.Add(this.Porch);
            this.Name = "Form1";
            this.Text = "SmartHome";
            ((System.ComponentModel.ISupportInitialize)(this.Porch)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FrontYard)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BackYard)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Bedroom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Kitchen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LightOnPicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LightOffPicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ToggleOn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ToggleOff)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
      

        #endregion

        private System.Windows.Forms.PictureBox Porch;
        private System.Windows.Forms.PictureBox FrontYard;
        private System.Windows.Forms.PictureBox BackYard;
        private System.Windows.Forms.PictureBox Bedroom;
        private System.Windows.Forms.PictureBox Kitchen;
        private System.Windows.Forms.PictureBox LightOnPicture;
        private System.Windows.Forms.PictureBox LightOffPicture;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button AllOnButton;
        private System.Windows.Forms.Button AllOffButton;
        private System.Windows.Forms.Button OutsideOnButton;
        private System.Windows.Forms.Button OutsideOffButton;
        private System.Windows.Forms.Button InsideOnButton;
        private System.Windows.Forms.Button InsideOffButton;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.PictureBox ToggleOn;
        private System.Windows.Forms.PictureBox ToggleOff;
        private System.Windows.Forms.Button FrontYdToggle;
        private System.Windows.Forms.Button PorchToggleButton;
        private System.Windows.Forms.Button BackYdToggle;
        private System.Windows.Forms.Button BedroomToggle;
        private System.Windows.Forms.Button KitchenToggle;
    }
}

