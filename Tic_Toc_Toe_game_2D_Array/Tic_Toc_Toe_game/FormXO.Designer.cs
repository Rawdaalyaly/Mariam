namespace Tic_Toc_Toe_game
{
    partial class FormXO
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
            a1 = new Button();
            a2 = new Button();
            a3 = new Button();
            b1 = new Button();
            b2 = new Button();
            b3 = new Button();
            c1 = new Button();
            c2 = new Button();
            c3 = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // a1
            // 
            a1.Font = new Font("Segoe UI Semibold", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            a1.ForeColor = SystemColors.MenuHighlight;
            a1.Location = new Point(53, 99);
            a1.Name = "a1";
            a1.Size = new Size(111, 87);
            a1.TabIndex = 0;
            a1.UseVisualStyleBackColor = true;
            a1.Click += button1_Click;
            // 
            // a2
            // 
            a2.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            a2.ForeColor = SystemColors.Highlight;
            a2.Location = new Point(209, 99);
            a2.Name = "a2";
            a2.Size = new Size(111, 87);
            a2.TabIndex = 1;
            a2.UseVisualStyleBackColor = true;
            a2.Click += a2_Click;
            // 
            // a3
            // 
            a3.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            a3.ForeColor = SystemColors.Highlight;
            a3.Location = new Point(359, 99);
            a3.Name = "a3";
            a3.Size = new Size(111, 87);
            a3.TabIndex = 2;
            a3.UseVisualStyleBackColor = true;
            a3.Click += a3_Click;
            // 
            // b1
            // 
            b1.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            b1.ForeColor = SystemColors.Highlight;
            b1.Location = new Point(53, 224);
            b1.Name = "b1";
            b1.Size = new Size(111, 87);
            b1.TabIndex = 3;
            b1.UseVisualStyleBackColor = true;
            b1.Click += b1_Click;
            // 
            // b2
            // 
            b2.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            b2.ForeColor = SystemColors.Highlight;
            b2.Location = new Point(209, 224);
            b2.Name = "b2";
            b2.Size = new Size(111, 87);
            b2.TabIndex = 4;
            b2.UseVisualStyleBackColor = true;
            b2.Click += b2_Click;
            // 
            // b3
            // 
            b3.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            b3.ForeColor = SystemColors.Highlight;
            b3.Location = new Point(359, 224);
            b3.Name = "b3";
            b3.Size = new Size(111, 87);
            b3.TabIndex = 5;
            b3.UseVisualStyleBackColor = true;
            b3.Click += b3_Click;
            // 
            // c1
            // 
            c1.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            c1.ForeColor = SystemColors.Highlight;
            c1.Location = new Point(53, 353);
            c1.Name = "c1";
            c1.Size = new Size(111, 87);
            c1.TabIndex = 6;
            c1.UseVisualStyleBackColor = true;
            c1.Click += c1_Click;
            // 
            // c2
            // 
            c2.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            c2.ForeColor = SystemColors.Highlight;
            c2.Location = new Point(209, 353);
            c2.Name = "c2";
            c2.Size = new Size(111, 87);
            c2.TabIndex = 7;
            c2.UseVisualStyleBackColor = true;
            c2.Click += c2_Click;
            // 
            // c3
            // 
            c3.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            c3.ForeColor = SystemColors.Highlight;
            c3.Location = new Point(359, 353);
            c3.Name = "c3";
            c3.Size = new Size(111, 87);
            c3.TabIndex = 8;
            c3.UseVisualStyleBackColor = true;
            c3.Click += c3_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.DarkOrange;
            label1.Location = new Point(115, 23);
            label1.Name = "label1";
            label1.Size = new Size(294, 46);
            label1.TabIndex = 9;
            label1.Text = "Tic Toc Toe Game";
            // 
            // FormXO
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLightLight;
            BackgroundImageLayout = ImageLayout.Center;
            ClientSize = new Size(537, 506);
            Controls.Add(label1);
            Controls.Add(c3);
            Controls.Add(c2);
            Controls.Add(c1);
            Controls.Add(b3);
            Controls.Add(b2);
            Controls.Add(b1);
            Controls.Add(a3);
            Controls.Add(a2);
            Controls.Add(a1);
            Name = "FormXO";
            Text = "XO";
            FormClosed += FormXO_FormClosed;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button a1;
        private Button a2;
        private Button a3;
        private Button b1;
        private Button b2;
        private Button b3;
        private Button c1;
        private Button c2;
        private Button c3;
        private Label label1;
    }
}