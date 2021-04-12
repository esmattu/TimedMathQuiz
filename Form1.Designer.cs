
namespace TimedMathQuiz
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
            this.components = new System.ComponentModel.Container();
            this.timeLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.plusLeftLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.plusRightLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.sum = new System.Windows.Forms.NumericUpDown();
            this.minusLeftLabel = new System.Windows.Forms.Label();
            this.minusRightlabel = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.minus = new System.Windows.Forms.NumericUpDown();
            this.multiplicationLeftLabel = new System.Windows.Forms.Label();
            this.multiplicationRightLabel = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.multiplication = new System.Windows.Forms.NumericUpDown();
            this.divisionLeftLabel = new System.Windows.Forms.Label();
            this.divisionRightLabel = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.division = new System.Windows.Forms.NumericUpDown();
            this.startTheQuizButton = new System.Windows.Forms.Button();
            this.quizTimer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.sum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.minus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.multiplication)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.division)).BeginInit();
            this.SuspendLayout();
            // 
            // timeLabel
            // 
            this.timeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.timeLabel.Location = new System.Drawing.Point(314, 9);
            this.timeLabel.Name = "timeLabel";
            this.timeLabel.Size = new System.Drawing.Size(158, 23);
            this.timeLabel.TabIndex = 0;
            this.timeLabel.Text = "0.00";
            this.timeLabel.Click += new System.EventHandler(this.TimeLabel_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(208, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "Time Left";
            // 
            // plusLeftLabel
            // 
            this.plusLeftLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.plusLeftLabel.Location = new System.Drawing.Point(50, 75);
            this.plusLeftLabel.Name = "plusLeftLabel";
            this.plusLeftLabel.Size = new System.Drawing.Size(60, 50);
            this.plusLeftLabel.TabIndex = 2;
            this.plusLeftLabel.Text = "?";
            this.plusLeftLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.plusLeftLabel.Click += new System.EventHandler(this.PlusLeftLabel_Click);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(116, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 50);
            this.label2.TabIndex = 2;
            this.label2.Text = "+";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // plusRightLabel
            // 
            this.plusRightLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.plusRightLabel.Location = new System.Drawing.Point(182, 75);
            this.plusRightLabel.Name = "plusRightLabel";
            this.plusRightLabel.Size = new System.Drawing.Size(60, 50);
            this.plusRightLabel.TabIndex = 2;
            this.plusRightLabel.Text = "?";
            this.plusRightLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.plusRightLabel.Click += new System.EventHandler(this.PlusRightLabel_Click);
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(248, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 50);
            this.label3.TabIndex = 2;
            this.label3.Text = "=";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // sum
            // 
            this.sum.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.sum.Location = new System.Drawing.Point(314, 84);
            this.sum.Name = "sum";
            this.sum.Size = new System.Drawing.Size(120, 35);
            this.sum.TabIndex = 1;
            this.sum.ValueChanged += new System.EventHandler(this.SumUpDown_ValueChanged);
            this.sum.Enter += new System.EventHandler(this.answer_Enter);
            // 
            // minusLeftLabel
            // 
            this.minusLeftLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.minusLeftLabel.Location = new System.Drawing.Point(50, 125);
            this.minusLeftLabel.Name = "minusLeftLabel";
            this.minusLeftLabel.Size = new System.Drawing.Size(60, 50);
            this.minusLeftLabel.TabIndex = 2;
            this.minusLeftLabel.Text = "?";
            this.minusLeftLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.minusLeftLabel.Click += new System.EventHandler(this.PlusLeftLabel_Click);
            // 
            // minusRightlabel
            // 
            this.minusRightlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.minusRightlabel.Location = new System.Drawing.Point(182, 125);
            this.minusRightlabel.Name = "minusRightlabel";
            this.minusRightlabel.Size = new System.Drawing.Size(60, 50);
            this.minusRightlabel.TabIndex = 2;
            this.minusRightlabel.Text = "?";
            this.minusRightlabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.minusRightlabel.Click += new System.EventHandler(this.PlusRightLabel_Click);
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(116, 125);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 50);
            this.label6.TabIndex = 2;
            this.label6.Text = "-";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(248, 125);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(60, 50);
            this.label7.TabIndex = 2;
            this.label7.Text = "=";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // minus
            // 
            this.minus.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.minus.Location = new System.Drawing.Point(314, 134);
            this.minus.Name = "minus";
            this.minus.Size = new System.Drawing.Size(120, 35);
            this.minus.TabIndex = 2;
            this.minus.ValueChanged += new System.EventHandler(this.SumUpDown_ValueChanged);
            this.minus.Enter += new System.EventHandler(this.answer_Enter);
            // 
            // multiplicationLeftLabel
            // 
            this.multiplicationLeftLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.multiplicationLeftLabel.Location = new System.Drawing.Point(50, 175);
            this.multiplicationLeftLabel.Name = "multiplicationLeftLabel";
            this.multiplicationLeftLabel.Size = new System.Drawing.Size(60, 50);
            this.multiplicationLeftLabel.TabIndex = 2;
            this.multiplicationLeftLabel.Text = "?";
            this.multiplicationLeftLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.multiplicationLeftLabel.Click += new System.EventHandler(this.PlusLeftLabel_Click);
            // 
            // multiplicationRightLabel
            // 
            this.multiplicationRightLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.multiplicationRightLabel.Location = new System.Drawing.Point(182, 175);
            this.multiplicationRightLabel.Name = "multiplicationRightLabel";
            this.multiplicationRightLabel.Size = new System.Drawing.Size(60, 50);
            this.multiplicationRightLabel.TabIndex = 2;
            this.multiplicationRightLabel.Text = "?";
            this.multiplicationRightLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.multiplicationRightLabel.Click += new System.EventHandler(this.PlusRightLabel_Click);
            // 
            // label10
            // 
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label10.Location = new System.Drawing.Point(116, 175);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(60, 50);
            this.label10.TabIndex = 2;
            this.label10.Text = "x";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label11
            // 
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label11.Location = new System.Drawing.Point(248, 175);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(60, 50);
            this.label11.TabIndex = 2;
            this.label11.Text = "=";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // multiplication
            // 
            this.multiplication.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.multiplication.Location = new System.Drawing.Point(314, 184);
            this.multiplication.Name = "multiplication";
            this.multiplication.Size = new System.Drawing.Size(120, 35);
            this.multiplication.TabIndex = 3;
            this.multiplication.ValueChanged += new System.EventHandler(this.SumUpDown_ValueChanged);
            this.multiplication.Enter += new System.EventHandler(this.answer_Enter);
            // 
            // divisionLeftLabel
            // 
            this.divisionLeftLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.divisionLeftLabel.Location = new System.Drawing.Point(50, 225);
            this.divisionLeftLabel.Name = "divisionLeftLabel";
            this.divisionLeftLabel.Size = new System.Drawing.Size(60, 50);
            this.divisionLeftLabel.TabIndex = 2;
            this.divisionLeftLabel.Text = "?";
            this.divisionLeftLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.divisionLeftLabel.Click += new System.EventHandler(this.PlusLeftLabel_Click);
            // 
            // divisionRightLabel
            // 
            this.divisionRightLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.divisionRightLabel.Location = new System.Drawing.Point(182, 225);
            this.divisionRightLabel.Name = "divisionRightLabel";
            this.divisionRightLabel.Size = new System.Drawing.Size(60, 50);
            this.divisionRightLabel.TabIndex = 2;
            this.divisionRightLabel.Text = "?";
            this.divisionRightLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.divisionRightLabel.Click += new System.EventHandler(this.PlusRightLabel_Click);
            // 
            // label14
            // 
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label14.Location = new System.Drawing.Point(116, 225);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(60, 50);
            this.label14.TabIndex = 2;
            this.label14.Text = "÷";
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label15
            // 
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label15.Location = new System.Drawing.Point(248, 225);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(60, 50);
            this.label15.TabIndex = 2;
            this.label15.Text = "=";
            this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // division
            // 
            this.division.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.division.Location = new System.Drawing.Point(314, 234);
            this.division.Name = "division";
            this.division.Size = new System.Drawing.Size(120, 35);
            this.division.TabIndex = 4;
            this.division.ValueChanged += new System.EventHandler(this.SumUpDown_ValueChanged);
            this.division.Enter += new System.EventHandler(this.answer_Enter);
            // 
            // startTheQuizButton
            // 
            this.startTheQuizButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.startTheQuizButton.Location = new System.Drawing.Point(150, 300);
            this.startTheQuizButton.Name = "startTheQuizButton";
            this.startTheQuizButton.Size = new System.Drawing.Size(160, 40);
            this.startTheQuizButton.TabIndex = 5;
            this.startTheQuizButton.Text = "Start the Quiz!";
            this.startTheQuizButton.UseVisualStyleBackColor = true;
            this.startTheQuizButton.Click += new System.EventHandler(this.startTheQuizButton_Click);
            // 
            // quizTimer
            // 
            this.quizTimer.Interval = 1000;
            this.quizTimer.Tick += new System.EventHandler(this.quizTimer_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(480, 357);
            this.Controls.Add(this.startTheQuizButton);
            this.Controls.Add(this.division);
            this.Controls.Add(this.multiplication);
            this.Controls.Add(this.minus);
            this.Controls.Add(this.sum);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.divisionRightLabel);
            this.Controls.Add(this.multiplicationRightLabel);
            this.Controls.Add(this.minusRightlabel);
            this.Controls.Add(this.plusRightLabel);
            this.Controls.Add(this.divisionLeftLabel);
            this.Controls.Add(this.multiplicationLeftLabel);
            this.Controls.Add(this.minusLeftLabel);
            this.Controls.Add(this.plusLeftLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.timeLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Form1";
            this.Text = "Math Quiz";
            this.Enter += new System.EventHandler(this.answer_Enter);
            ((System.ComponentModel.ISupportInitialize)(this.sum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.minus)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.multiplication)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.division)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label timeLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label plusLeftLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label plusRightLabel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown sum;
        private System.Windows.Forms.Label minusLeftLabel;
        private System.Windows.Forms.Label minusRightlabel;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown minus;
        private System.Windows.Forms.Label multiplicationLeftLabel;
        private System.Windows.Forms.Label multiplicationRightLabel;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.NumericUpDown multiplication;
        private System.Windows.Forms.Label divisionLeftLabel;
        private System.Windows.Forms.Label divisionRightLabel;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.NumericUpDown division;
        private System.Windows.Forms.Button startTheQuizButton;
        private System.Windows.Forms.Timer quizTimer;
    }
}

