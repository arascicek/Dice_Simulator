namespace Dice_Simulator
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            picDie1 = new PictureBox();
            picDie2 = new PictureBox();
            btnRoll = new Button();
            label1 = new Label();
            lblResult = new Label();
            label2 = new Label();
            lblRolls = new Label();
            ((System.ComponentModel.ISupportInitialize)picDie1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picDie2).BeginInit();
            SuspendLayout();
            // 
            // picDie1
            // 
            picDie1.Image = (Image)resources.GetObject("picDie1.Image");
            picDie1.Location = new Point(81, 62);
            picDie1.Name = "picDie1";
            picDie1.Size = new Size(104, 104);
            picDie1.SizeMode = PictureBoxSizeMode.AutoSize;
            picDie1.TabIndex = 0;
            picDie1.TabStop = false;
            // 
            // picDie2
            // 
            picDie2.Image = Properties.Resources.Die1;
            picDie2.Location = new Point(258, 62);
            picDie2.Name = "picDie2";
            picDie2.Size = new Size(104, 104);
            picDie2.SizeMode = PictureBoxSizeMode.AutoSize;
            picDie2.TabIndex = 1;
            picDie2.TabStop = false;
            // 
            // btnRoll
            // 
            btnRoll.Location = new Point(184, 258);
            btnRoll.Name = "btnRoll";
            btnRoll.Size = new Size(94, 29);
            btnRoll.TabIndex = 2;
            btnRoll.Text = "Roll";
            btnRoll.UseVisualStyleBackColor = true;
            btnRoll.Click += btnRoll_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(27, 213);
            label1.Name = "label1";
            label1.Size = new Size(54, 20);
            label1.TabIndex = 3;
            label1.Text = "Values:";
            // 
            // lblResult
            // 
            lblResult.BorderStyle = BorderStyle.FixedSingle;
            lblResult.Location = new Point(92, 211);
            lblResult.Name = "lblResult";
            lblResult.Size = new Size(126, 25);
            lblResult.TabIndex = 4;
            lblResult.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(234, 213);
            label2.Name = "label2";
            label2.Size = new Size(44, 20);
            label2.TabIndex = 5;
            label2.Text = "Rolls:";
            // 
            // lblRolls
            // 
            lblRolls.BorderStyle = BorderStyle.FixedSingle;
            lblRolls.Location = new Point(284, 211);
            lblRolls.Name = "lblRolls";
            lblRolls.Size = new Size(126, 25);
            lblRolls.TabIndex = 6;
            lblRolls.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(435, 299);
            Controls.Add(lblRolls);
            Controls.Add(label2);
            Controls.Add(lblResult);
            Controls.Add(label1);
            Controls.Add(btnRoll);
            Controls.Add(picDie2);
            Controls.Add(picDie1);
            Name = "Form1";
            Text = "Dice Simulator";
            ((System.ComponentModel.ISupportInitialize)picDie1).EndInit();
            ((System.ComponentModel.ISupportInitialize)picDie2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox picDie1;
        private PictureBox picDie2;
        private Button btnRoll;
        private Label label1;
        private Label lblResult;
        private Label label2;
        private Label lblRolls;
    }
}
