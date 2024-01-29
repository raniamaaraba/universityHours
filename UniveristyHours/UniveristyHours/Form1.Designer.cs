namespace UniveristyHours
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.studentLearningButton = new System.Windows.Forms.Button();
            this.financialAidButton = new System.Windows.Forms.Button();
            this.counsellingButton = new System.Windows.Forms.Button();
            this.bookstoreButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.messageLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // studentLearningButton
            // 
            this.studentLearningButton.Location = new System.Drawing.Point(134, 113);
            this.studentLearningButton.Name = "studentLearningButton";
            this.studentLearningButton.Size = new System.Drawing.Size(110, 45);
            this.studentLearningButton.TabIndex = 0;
            this.studentLearningButton.Text = "Student Learning ";
            this.studentLearningButton.UseVisualStyleBackColor = true;
            this.studentLearningButton.Click += new System.EventHandler(this.studentLearningButton_Click);
            // 
            // financialAidButton
            // 
            this.financialAidButton.Location = new System.Drawing.Point(134, 164);
            this.financialAidButton.Name = "financialAidButton";
            this.financialAidButton.Size = new System.Drawing.Size(110, 45);
            this.financialAidButton.TabIndex = 1;
            this.financialAidButton.Text = "Financial Aid";
            this.financialAidButton.UseVisualStyleBackColor = true;
            this.financialAidButton.Click += new System.EventHandler(this.financialAidButton_Click);
            // 
            // counsellingButton
            // 
            this.counsellingButton.Location = new System.Drawing.Point(134, 215);
            this.counsellingButton.Name = "counsellingButton";
            this.counsellingButton.Size = new System.Drawing.Size(110, 45);
            this.counsellingButton.TabIndex = 2;
            this.counsellingButton.Text = "Counselling";
            this.counsellingButton.UseVisualStyleBackColor = true;
            this.counsellingButton.Click += new System.EventHandler(this.counsellingButton_Click);
            // 
            // bookstoreButton
            // 
            this.bookstoreButton.Location = new System.Drawing.Point(134, 266);
            this.bookstoreButton.Name = "bookstoreButton";
            this.bookstoreButton.Size = new System.Drawing.Size(110, 45);
            this.bookstoreButton.TabIndex = 3;
            this.bookstoreButton.Text = "Bookstore";
            this.bookstoreButton.UseVisualStyleBackColor = true;
            this.bookstoreButton.Click += new System.EventHandler(this.bookstoreButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(134, 317);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(110, 45);
            this.exitButton.TabIndex = 4;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // messageLabel
            // 
            this.messageLabel.AutoSize = true;
            this.messageLabel.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.messageLabel.Location = new System.Drawing.Point(356, 128);
            this.messageLabel.Name = "messageLabel";
            this.messageLabel.Size = new System.Drawing.Size(0, 30);
            this.messageLabel.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(664, 426);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 15);
            this.label1.TabIndex = 6;
            this.label1.Text = "by Rania Maaraba";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.messageLabel);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.bookstoreButton);
            this.Controls.Add(this.counsellingButton);
            this.Controls.Add(this.financialAidButton);
            this.Controls.Add(this.studentLearningButton);
            this.Name = "Form1";
            this.Text = "University Hours";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button studentLearningButton;
        private Button financialAidButton;
        private Button counsellingButton;
        private Button bookstoreButton;
        private Button exitButton;
        private Label messageLabel;
        private Label label1;
    }
}