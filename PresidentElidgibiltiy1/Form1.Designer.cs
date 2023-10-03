namespace PresidentElidgibiltiy1
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
            this.naturalBorn = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.age = new System.Windows.Forms.TextBox();
            this.terms = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.checkPresident = new System.Windows.Forms.Button();
            this.rebel = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // naturalBorn
            // 
            this.naturalBorn.AutoSize = true;
            this.naturalBorn.Location = new System.Drawing.Point(40, 37);
            this.naturalBorn.Name = "naturalBorn";
            this.naturalBorn.Size = new System.Drawing.Size(119, 17);
            this.naturalBorn.TabIndex = 1;
            this.naturalBorn.Text = "Natural Born Citizen";
            this.naturalBorn.UseVisualStyleBackColor = true;
            this.naturalBorn.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 100);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "How old are you?";
            // 
            // age
            // 
            this.age.Location = new System.Drawing.Point(136, 100);
            this.age.Name = "age";
            this.age.Size = new System.Drawing.Size(56, 20);
            this.age.TabIndex = 4;
            this.age.TextChanged += new System.EventHandler(this.age_TextChanged);
            // 
            // terms
            // 
            this.terms.Location = new System.Drawing.Point(220, 143);
            this.terms.Name = "terms";
            this.terms.Size = new System.Drawing.Size(56, 20);
            this.terms.TabIndex = 6;
            this.terms.TextChanged += new System.EventHandler(this.terms_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(41, 146);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(173, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "How many terms have you served?";
            // 
            // checkPresident
            // 
            this.checkPresident.Location = new System.Drawing.Point(136, 200);
            this.checkPresident.Name = "checkPresident";
            this.checkPresident.Size = new System.Drawing.Size(83, 41);
            this.checkPresident.TabIndex = 9;
            this.checkPresident.Text = "Check Elidgibility";
            this.checkPresident.UseVisualStyleBackColor = true;
            this.checkPresident.Click += new System.EventHandler(this.checkPresident_Click);
            // 
            // rebel
            // 
            this.rebel.AutoSize = true;
            this.rebel.Location = new System.Drawing.Point(40, 60);
            this.rebel.Name = "rebel";
            this.rebel.Size = new System.Drawing.Size(179, 17);
            this.rebel.TabIndex = 10;
            this.rebel.Text = "I have rebelled against the USA.";
            this.rebel.UseVisualStyleBackColor = true;
            this.rebel.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(387, 325);
            this.Controls.Add(this.rebel);
            this.Controls.Add(this.checkPresident);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.terms);
            this.Controls.Add(this.age);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.naturalBorn);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.CheckBox naturalBorn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox age;
        private System.Windows.Forms.TextBox terms;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button checkPresident;
        private System.Windows.Forms.CheckBox rebel;
    }
}

