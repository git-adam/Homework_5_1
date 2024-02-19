
using System.Linq;

namespace Homework_5_1
{
    partial class AddEditStudent
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
            this.lbId = new System.Windows.Forms.Label();
            this.tbId = new System.Windows.Forms.TextBox();
            this.tbFirstName = new System.Windows.Forms.TextBox();
            this.lbFirstName = new System.Windows.Forms.Label();
            this.tbLastName = new System.Windows.Forms.TextBox();
            this.lbLastName = new System.Windows.Forms.Label();
            this.tbMath = new System.Windows.Forms.TextBox();
            this.lbMath = new System.Windows.Forms.Label();
            this.tbTechnology = new System.Windows.Forms.TextBox();
            this.lbTechnology = new System.Windows.Forms.Label();
            this.tbPhysics = new System.Windows.Forms.TextBox();
            this.lbPhysics = new System.Windows.Forms.Label();
            this.tbPolishLanguage = new System.Windows.Forms.TextBox();
            this.lbPolishLanguague = new System.Windows.Forms.Label();
            this.tbForeignLanguage = new System.Windows.Forms.TextBox();
            this.lbForeignLanguage = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.rtbComments = new System.Windows.Forms.RichTextBox();
            this.lbComments = new System.Windows.Forms.Label();
            this.cbAreExtraActivities = new System.Windows.Forms.CheckBox();
            this.cbGroup = new System.Windows.Forms.ComboBox();
            this.lbGroupId = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbId
            // 
            this.lbId.AutoSize = true;
            this.lbId.Location = new System.Drawing.Point(26, 40);
            this.lbId.Name = "lbId";
            this.lbId.Size = new System.Drawing.Size(19, 13);
            this.lbId.TabIndex = 0;
            this.lbId.Text = "Id:";
            // 
            // tbId
            // 
            this.tbId.Location = new System.Drawing.Point(99, 37);
            this.tbId.Name = "tbId";
            this.tbId.ReadOnly = true;
            this.tbId.Size = new System.Drawing.Size(200, 20);
            this.tbId.TabIndex = 1;
            // 
            // tbFirstName
            // 
            this.tbFirstName.Location = new System.Drawing.Point(99, 63);
            this.tbFirstName.Name = "tbFirstName";
            this.tbFirstName.Size = new System.Drawing.Size(200, 20);
            this.tbFirstName.TabIndex = 3;
            // 
            // lbFirstName
            // 
            this.lbFirstName.AutoSize = true;
            this.lbFirstName.Location = new System.Drawing.Point(26, 66);
            this.lbFirstName.Name = "lbFirstName";
            this.lbFirstName.Size = new System.Drawing.Size(29, 13);
            this.lbFirstName.TabIndex = 2;
            this.lbFirstName.Text = "Imię:";
            // 
            // tbLastName
            // 
            this.tbLastName.Location = new System.Drawing.Point(99, 89);
            this.tbLastName.Name = "tbLastName";
            this.tbLastName.Size = new System.Drawing.Size(200, 20);
            this.tbLastName.TabIndex = 5;
            // 
            // lbLastName
            // 
            this.lbLastName.AutoSize = true;
            this.lbLastName.Location = new System.Drawing.Point(26, 92);
            this.lbLastName.Name = "lbLastName";
            this.lbLastName.Size = new System.Drawing.Size(56, 13);
            this.lbLastName.TabIndex = 4;
            this.lbLastName.Text = "Nazwisko:";
            // 
            // tbMath
            // 
            this.tbMath.Location = new System.Drawing.Point(99, 143);
            this.tbMath.Name = "tbMath";
            this.tbMath.Size = new System.Drawing.Size(200, 20);
            this.tbMath.TabIndex = 7;
            // 
            // lbMath
            // 
            this.lbMath.AutoSize = true;
            this.lbMath.Location = new System.Drawing.Point(26, 146);
            this.lbMath.Name = "lbMath";
            this.lbMath.Size = new System.Drawing.Size(68, 13);
            this.lbMath.TabIndex = 6;
            this.lbMath.Text = "Matematyka:";
            // 
            // tbTechnology
            // 
            this.tbTechnology.Location = new System.Drawing.Point(99, 169);
            this.tbTechnology.Name = "tbTechnology";
            this.tbTechnology.Size = new System.Drawing.Size(200, 20);
            this.tbTechnology.TabIndex = 9;
            // 
            // lbTechnology
            // 
            this.lbTechnology.AutoSize = true;
            this.lbTechnology.Location = new System.Drawing.Point(26, 172);
            this.lbTechnology.Name = "lbTechnology";
            this.lbTechnology.Size = new System.Drawing.Size(69, 13);
            this.lbTechnology.TabIndex = 8;
            this.lbTechnology.Text = "Technologia:";
            // 
            // tbPhysics
            // 
            this.tbPhysics.Location = new System.Drawing.Point(99, 195);
            this.tbPhysics.Name = "tbPhysics";
            this.tbPhysics.Size = new System.Drawing.Size(200, 20);
            this.tbPhysics.TabIndex = 11;
            // 
            // lbPhysics
            // 
            this.lbPhysics.AutoSize = true;
            this.lbPhysics.Location = new System.Drawing.Point(26, 198);
            this.lbPhysics.Name = "lbPhysics";
            this.lbPhysics.Size = new System.Drawing.Size(40, 13);
            this.lbPhysics.TabIndex = 10;
            this.lbPhysics.Text = "Fizyka:";
            // 
            // tbPolishLanguage
            // 
            this.tbPolishLanguage.Location = new System.Drawing.Point(99, 221);
            this.tbPolishLanguage.Name = "tbPolishLanguage";
            this.tbPolishLanguage.Size = new System.Drawing.Size(200, 20);
            this.tbPolishLanguage.TabIndex = 13;
            // 
            // lbPolishLanguague
            // 
            this.lbPolishLanguague.AutoSize = true;
            this.lbPolishLanguague.Location = new System.Drawing.Point(26, 224);
            this.lbPolishLanguague.Name = "lbPolishLanguague";
            this.lbPolishLanguague.Size = new System.Drawing.Size(67, 13);
            this.lbPolishLanguague.TabIndex = 12;
            this.lbPolishLanguague.Text = "Język polski:";
            // 
            // tbForeignLanguage
            // 
            this.tbForeignLanguage.Location = new System.Drawing.Point(99, 247);
            this.tbForeignLanguage.Name = "tbForeignLanguage";
            this.tbForeignLanguage.Size = new System.Drawing.Size(200, 20);
            this.tbForeignLanguage.TabIndex = 15;
            // 
            // lbForeignLanguage
            // 
            this.lbForeignLanguage.AutoSize = true;
            this.lbForeignLanguage.Location = new System.Drawing.Point(26, 250);
            this.lbForeignLanguage.Name = "lbForeignLanguage";
            this.lbForeignLanguage.Size = new System.Drawing.Size(63, 13);
            this.lbForeignLanguage.TabIndex = 14;
            this.lbForeignLanguage.Text = "Język obcy:";
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(143, 377);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 16;
            this.btnCancel.Text = "Anuluj";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnConfirm
            // 
            this.btnConfirm.Location = new System.Drawing.Point(224, 377);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(75, 23);
            this.btnConfirm.TabIndex = 17;
            this.btnConfirm.Text = "Zatwierdź";
            this.btnConfirm.UseVisualStyleBackColor = true;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // rtbComments
            // 
            this.rtbComments.Location = new System.Drawing.Point(99, 273);
            this.rtbComments.Name = "rtbComments";
            this.rtbComments.Size = new System.Drawing.Size(200, 96);
            this.rtbComments.TabIndex = 18;
            this.rtbComments.Text = "";
            // 
            // lbComments
            // 
            this.lbComments.AutoSize = true;
            this.lbComments.Location = new System.Drawing.Point(26, 273);
            this.lbComments.Name = "lbComments";
            this.lbComments.Size = new System.Drawing.Size(40, 13);
            this.lbComments.TabIndex = 19;
            this.lbComments.Text = "Uwagi:";
            // 
            // cbAreExtraActivities
            // 
            this.cbAreExtraActivities.AutoSize = true;
            this.cbAreExtraActivities.Location = new System.Drawing.Point(184, 117);
            this.cbAreExtraActivities.Name = "cbAreExtraActivities";
            this.cbAreExtraActivities.Size = new System.Drawing.Size(117, 17);
            this.cbAreExtraActivities.TabIndex = 20;
            this.cbAreExtraActivities.Text = "Zajęcia dodatkowe";
            this.cbAreExtraActivities.UseVisualStyleBackColor = true;
            // 
            // cbGroup
            // 
            this.cbGroup.FormattingEnabled = true;
            this.cbGroup.Location = new System.Drawing.Point(99, 115);
            this.cbGroup.Name = "cbGroup";
            this.cbGroup.Size = new System.Drawing.Size(79, 21);
            this.cbGroup.TabIndex = 21;
            // 
            // lbGroupId
            // 
            this.lbGroupId.AutoSize = true;
            this.lbGroupId.Location = new System.Drawing.Point(26, 117);
            this.lbGroupId.Name = "lbGroupId";
            this.lbGroupId.Size = new System.Drawing.Size(36, 13);
            this.lbGroupId.TabIndex = 22;
            this.lbGroupId.Text = "Klasa:";
            // 
            // AddEditStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(344, 432);
            this.Controls.Add(this.lbGroupId);
            this.Controls.Add(this.cbGroup);
            this.Controls.Add(this.cbAreExtraActivities);
            this.Controls.Add(this.lbComments);
            this.Controls.Add(this.rtbComments);
            this.Controls.Add(this.btnConfirm);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.tbForeignLanguage);
            this.Controls.Add(this.lbForeignLanguage);
            this.Controls.Add(this.tbPolishLanguage);
            this.Controls.Add(this.lbPolishLanguague);
            this.Controls.Add(this.tbPhysics);
            this.Controls.Add(this.lbPhysics);
            this.Controls.Add(this.tbTechnology);
            this.Controls.Add(this.lbTechnology);
            this.Controls.Add(this.tbMath);
            this.Controls.Add(this.lbMath);
            this.Controls.Add(this.tbLastName);
            this.Controls.Add(this.lbLastName);
            this.Controls.Add(this.tbFirstName);
            this.Controls.Add(this.lbFirstName);
            this.Controls.Add(this.tbId);
            this.Controls.Add(this.lbId);
            this.Name = "AddEditStudent";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dodawanie nowego ucznia";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbId;
        private System.Windows.Forms.TextBox tbId;
        private System.Windows.Forms.TextBox tbFirstName;
        private System.Windows.Forms.Label lbFirstName;
        private System.Windows.Forms.TextBox tbLastName;
        private System.Windows.Forms.Label lbLastName;
        private System.Windows.Forms.TextBox tbMath;
        private System.Windows.Forms.Label lbMath;
        private System.Windows.Forms.TextBox tbTechnology;
        private System.Windows.Forms.Label lbTechnology;
        private System.Windows.Forms.TextBox tbPhysics;
        private System.Windows.Forms.Label lbPhysics;
        private System.Windows.Forms.TextBox tbPolishLanguage;
        private System.Windows.Forms.Label lbPolishLanguague;
        private System.Windows.Forms.TextBox tbForeignLanguage;
        private System.Windows.Forms.Label lbForeignLanguage;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.RichTextBox rtbComments;
        private System.Windows.Forms.Label lbComments;
        private System.Windows.Forms.CheckBox cbAreExtraActivities;
        private System.Windows.Forms.ComboBox cbGroup;
        private System.Windows.Forms.Label lbGroupId;
    }
}