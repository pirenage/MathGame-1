namespace MathGame
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
            this.lblScore = new System.Windows.Forms.Label();
            this.lblNumA = new System.Windows.Forms.Label();
            this.lblSymbol = new System.Windows.Forms.Label();
            this.lblNumB = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtAnswer = new System.Windows.Forms.TextBox();
            this.CheckButtonClickEven = new System.Windows.Forms.Button();
            this.lblAnswer = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblScore
            // 
            this.lblScore.AutoSize = true;
            this.lblScore.Font = new System.Drawing.Font("Montserrat ExtraBold", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScore.Location = new System.Drawing.Point(13, 13);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(97, 37);
            this.lblScore.TabIndex = 0;
            this.lblScore.Text = "Score";
            this.lblScore.Click += new System.EventHandler(this.IbIScore_Click);
            // 
            // lblNumA
            // 
            this.lblNumA.AutoSize = true;
            this.lblNumA.Font = new System.Drawing.Font("Montserrat ExtraBold", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumA.Location = new System.Drawing.Point(13, 88);
            this.lblNumA.Name = "lblNumA";
            this.lblNumA.Size = new System.Drawing.Size(97, 37);
            this.lblNumA.TabIndex = 1;
            this.lblNumA.Text = "Score";
            this.lblNumA.Click += new System.EventHandler(this.IbINumA_Click);
            // 
            // lblSymbol
            // 
            this.lblSymbol.AutoSize = true;
            this.lblSymbol.Font = new System.Drawing.Font("Montserrat ExtraBold", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSymbol.Location = new System.Drawing.Point(142, 88);
            this.lblSymbol.Name = "lblSymbol";
            this.lblSymbol.Size = new System.Drawing.Size(33, 37);
            this.lblSymbol.TabIndex = 2;
            this.lblSymbol.Text = "+";
            // 
            // lblNumB
            // 
            this.lblNumB.AutoSize = true;
            this.lblNumB.Font = new System.Drawing.Font("Montserrat ExtraBold", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumB.Location = new System.Drawing.Point(224, 88);
            this.lblNumB.Name = "lblNumB";
            this.lblNumB.Size = new System.Drawing.Size(97, 37);
            this.lblNumB.TabIndex = 3;
            this.lblNumB.Text = "Score";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Montserrat ExtraBold", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(370, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 37);
            this.label1.TabIndex = 4;
            this.label1.Text = "=";
            // 
            // txtAnswer
            // 
            this.txtAnswer.Location = new System.Drawing.Point(444, 104);
            this.txtAnswer.Margin = new System.Windows.Forms.Padding(10);
            this.txtAnswer.Name = "txtAnswer";
            this.txtAnswer.Size = new System.Drawing.Size(113, 20);
            this.txtAnswer.TabIndex = 5;
            this.txtAnswer.TextChanged += new System.EventHandler(this.CheckAnswer);
            // 
            // CheckButtonClickEven
            // 
            this.CheckButtonClickEven.Location = new System.Drawing.Point(622, 96);
            this.CheckButtonClickEven.Name = "CheckButtonClickEven";
            this.CheckButtonClickEven.Size = new System.Drawing.Size(95, 35);
            this.CheckButtonClickEven.TabIndex = 6;
            this.CheckButtonClickEven.Text = "Cek Jawaban\r\n";
            this.CheckButtonClickEven.UseVisualStyleBackColor = true;
            this.CheckButtonClickEven.Click += new System.EventHandler(this.CheckButtonClickEvent);
            // 
            // lblAnswer
            // 
            this.lblAnswer.AutoSize = true;
            this.lblAnswer.Font = new System.Drawing.Font("Montserrat ExtraBold", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAnswer.Location = new System.Drawing.Point(13, 168);
            this.lblAnswer.Name = "lblAnswer";
            this.lblAnswer.Size = new System.Drawing.Size(97, 37);
            this.lblAnswer.TabIndex = 7;
            this.lblAnswer.Text = "Score";
            this.lblAnswer.Click += new System.EventHandler(this.lbAnswer_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(745, 229);
            this.Controls.Add(this.lblAnswer);
            this.Controls.Add(this.CheckButtonClickEven);
            this.Controls.Add(this.txtAnswer);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblNumB);
            this.Controls.Add(this.lblSymbol);
            this.Controls.Add(this.lblNumA);
            this.Controls.Add(this.lblScore);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblScore;
        private System.Windows.Forms.Label lblNumA;
        private System.Windows.Forms.Label lblSymbol;
        private System.Windows.Forms.Label lblNumB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtAnswer;
        private System.Windows.Forms.Button CheckButtonClickEven;
        private System.Windows.Forms.Label lblAnswer;
    }
}

