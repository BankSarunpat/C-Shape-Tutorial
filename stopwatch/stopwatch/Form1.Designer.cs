namespace stopwatch
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
            label1 = new Label();
            StartBTN = new Button();
            stopBTN = new Button();
            resetBTN = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("SquareType B", 80F);
            label1.ForeColor = Color.White;
            label1.Location = new Point(19, 40);
            label1.Name = "label1";
            label1.Size = new Size(736, 121);
            label1.TabIndex = 0;
            label1.Text = "00:00:00:00";
            // 
            // StartBTN
            // 
            StartBTN.BackColor = Color.FromArgb(0, 205, 151);
            StartBTN.FlatStyle = FlatStyle.Popup;
            StartBTN.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold);
            StartBTN.ForeColor = Color.White;
            StartBTN.Location = new Point(90, 220);
            StartBTN.Name = "StartBTN";
            StartBTN.Size = new Size(160, 60);
            StartBTN.TabIndex = 1;
            StartBTN.Text = "Start";
            StartBTN.UseVisualStyleBackColor = false;
            StartBTN.Click += StartBTN_Click;
            // 
            // stopBTN
            // 
            stopBTN.BackColor = Color.FromArgb(247, 86, 91);
            stopBTN.FlatStyle = FlatStyle.Popup;
            stopBTN.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold);
            stopBTN.ForeColor = Color.White;
            stopBTN.Location = new Point(303, 220);
            stopBTN.Name = "stopBTN";
            stopBTN.Size = new Size(160, 60);
            stopBTN.TabIndex = 1;
            stopBTN.Text = "Stop";
            stopBTN.UseVisualStyleBackColor = false;
            stopBTN.Click += stopBTN_Click;
            // 
            // resetBTN
            // 
            resetBTN.BackColor = Color.FromArgb(25, 130, 196);
            resetBTN.FlatStyle = FlatStyle.Popup;
            resetBTN.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold);
            resetBTN.ForeColor = Color.White;
            resetBTN.Location = new Point(517, 220);
            resetBTN.Name = "resetBTN";
            resetBTN.Size = new Size(160, 60);
            resetBTN.TabIndex = 1;
            resetBTN.Text = "Reset";
            resetBTN.UseVisualStyleBackColor = false;
            resetBTN.Click += resetBTN_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(29, 38, 48);
            ClientSize = new Size(767, 293);
            Controls.Add(resetBTN);
            Controls.Add(stopBTN);
            Controls.Add(StartBTN);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button StartBTN;
        private Button stopBTN;
        private Button resetBTN;
    }
}
