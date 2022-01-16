
namespace BasicMinesWeeper
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
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnStart = new System.Windows.Forms.Button();
            this.lblScoreTxt = new System.Windows.Forms.Label();
            this.lblBoomTxt = new System.Windows.Forms.Label();
            this.lblScore = new System.Windows.Forms.Label();
            this.lblBoom = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Location = new System.Drawing.Point(12, 12);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(312, 281);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(390, 233);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(89, 44);
            this.btnStart.TabIndex = 1;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // lblScoreTxt
            // 
            this.lblScoreTxt.AutoSize = true;
            this.lblScoreTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScoreTxt.Location = new System.Drawing.Point(382, 109);
            this.lblScoreTxt.Name = "lblScoreTxt";
            this.lblScoreTxt.Size = new System.Drawing.Size(53, 20);
            this.lblScoreTxt.TabIndex = 2;
            this.lblScoreTxt.Text = "Score";
            // 
            // lblBoomTxt
            // 
            this.lblBoomTxt.AutoSize = true;
            this.lblBoomTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBoomTxt.Location = new System.Drawing.Point(382, 147);
            this.lblBoomTxt.Name = "lblBoomTxt";
            this.lblBoomTxt.Size = new System.Drawing.Size(58, 20);
            this.lblBoomTxt.TabIndex = 2;
            this.lblBoomTxt.Text = "Boom!";
            // 
            // lblScore
            // 
            this.lblScore.AutoSize = true;
            this.lblScore.BackColor = System.Drawing.Color.Green;
            this.lblScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScore.ForeColor = System.Drawing.Color.White;
            this.lblScore.Location = new System.Drawing.Point(458, 109);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(18, 20);
            this.lblScore.TabIndex = 3;
            this.lblScore.Text = "0";
            // 
            // lblBoom
            // 
            this.lblBoom.AutoSize = true;
            this.lblBoom.BackColor = System.Drawing.Color.Red;
            this.lblBoom.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBoom.ForeColor = System.Drawing.Color.White;
            this.lblBoom.Location = new System.Drawing.Point(458, 147);
            this.lblBoom.Name = "lblBoom";
            this.lblBoom.Size = new System.Drawing.Size(18, 20);
            this.lblBoom.TabIndex = 3;
            this.lblBoom.Text = "0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(549, 312);
            this.Controls.Add(this.lblBoom);
            this.Controls.Add(this.lblScore);
            this.Controls.Add(this.lblBoomTxt);
            this.Controls.Add(this.lblScoreTxt);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.flowLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Minesweeper";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Label lblScoreTxt;
        private System.Windows.Forms.Label lblBoomTxt;
        private System.Windows.Forms.Label lblScore;
        private System.Windows.Forms.Label lblBoom;
    }
}

