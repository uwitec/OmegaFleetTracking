﻿namespace Wil
{
    partial class frmTripManagerMenu
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
            this.buttonHome = new System.Windows.Forms.Button();
            this.buttonScheduleTrip = new System.Windows.Forms.Button();
            this.buttonIncidence = new System.Windows.Forms.Button();
            this.buttonTripCompleted = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonHome
            // 
            this.buttonHome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonHome.Location = new System.Drawing.Point(64, 21);
            this.buttonHome.Name = "buttonHome";
            this.buttonHome.Size = new System.Drawing.Size(160, 148);
            this.buttonHome.TabIndex = 0;
            this.buttonHome.Text = "Home";
            this.buttonHome.UseVisualStyleBackColor = true;
            this.buttonHome.Click += new System.EventHandler(this.buttonHome_Click);
            // 
            // buttonScheduleTrip
            // 
            this.buttonScheduleTrip.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonScheduleTrip.Location = new System.Drawing.Point(64, 176);
            this.buttonScheduleTrip.Name = "buttonScheduleTrip";
            this.buttonScheduleTrip.Size = new System.Drawing.Size(160, 148);
            this.buttonScheduleTrip.TabIndex = 1;
            this.buttonScheduleTrip.Text = "Schedule Trip";
            this.buttonScheduleTrip.UseVisualStyleBackColor = true;
            this.buttonScheduleTrip.Click += new System.EventHandler(this.buttonScheduleTrip_Click);
            // 
            // buttonIncidence
            // 
            this.buttonIncidence.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonIncidence.Location = new System.Drawing.Point(64, 331);
            this.buttonIncidence.Name = "buttonIncidence";
            this.buttonIncidence.Size = new System.Drawing.Size(160, 148);
            this.buttonIncidence.TabIndex = 2;
            this.buttonIncidence.Text = "Incidence";
            this.buttonIncidence.UseVisualStyleBackColor = true;
            this.buttonIncidence.Click += new System.EventHandler(this.buttonIncidence_Click);
            // 
            // buttonTripCompleted
            // 
            this.buttonTripCompleted.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonTripCompleted.Location = new System.Drawing.Point(64, 486);
            this.buttonTripCompleted.Name = "buttonTripCompleted";
            this.buttonTripCompleted.Size = new System.Drawing.Size(160, 148);
            this.buttonTripCompleted.TabIndex = 3;
            this.buttonTripCompleted.Text = "Trip Completed";
            this.buttonTripCompleted.UseVisualStyleBackColor = true;
            this.buttonTripCompleted.Click += new System.EventHandler(this.buttonTripCompleted_Click);
            // 
            // frmTripManagerMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.buttonTripCompleted);
            this.Controls.Add(this.buttonIncidence);
            this.Controls.Add(this.buttonScheduleTrip);
            this.Controls.Add(this.buttonHome);
            this.Name = "frmTripManagerMenu";
            this.Size = new System.Drawing.Size(289, 807);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonHome;
        private System.Windows.Forms.Button buttonScheduleTrip;
        private System.Windows.Forms.Button buttonIncidence;
        private System.Windows.Forms.Button buttonTripCompleted;
    }
}