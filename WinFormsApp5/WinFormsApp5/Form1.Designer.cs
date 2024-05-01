namespace WinFormsApp5
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
            button1=new Button();
            button2=new Button();
            button3=new Button();
            pictureBox1=new PictureBox();
            pictureBox2=new PictureBox();
            pictureBox3=new PictureBox();
            openFileDialog1=new OpenFileDialog();
            saveFileDialog1=new SaveFileDialog();
            textBox1=new TextBox();
            hScrollBar1=new HScrollBar();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location=new Point(1019, 103);
            button1.Name="button1";
            button1.Size=new Size(115, 55);
            button1.TabIndex=0;
            button1.Text="Choose Image";
            button1.TextImageRelation=TextImageRelation.ImageAboveText;
            button1.UseVisualStyleBackColor=true;
            button1.Click+=button1_Click;
            // 
            // button2
            // 
            button2.Location=new Point(1019, 420);
            button2.Name="button2";
            button2.Size=new Size(115, 54);
            button2.TabIndex=1;
            button2.Text="Brightness";
            button2.UseVisualStyleBackColor=true;
            button2.Click+=button2_Click;
            // 
            // button3
            // 
            button3.Location=new Point(1019, 164);
            button3.Name="button3";
            button3.Size=new Size(115, 53);
            button3.TabIndex=2;
            button3.Text="RGB";
            button3.UseVisualStyleBackColor=true;
            button3.Click+=button3_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Location=new Point(23, 12);
            pictureBox1.Name="pictureBox1";
            pictureBox1.Size=new Size(380, 295);
            pictureBox1.TabIndex=3;
            pictureBox1.TabStop=false;
            // 
            // pictureBox2
            // 
            pictureBox2.Location=new Point(419, 313);
            pictureBox2.Name="pictureBox2";
            pictureBox2.Size=new Size(359, 308);
            pictureBox2.TabIndex=4;
            pictureBox2.TabStop=false;
            // 
            // pictureBox3
            // 
            pictureBox3.Location=new Point(23, 313);
            pictureBox3.Name="pictureBox3";
            pictureBox3.Size=new Size(380, 308);
            pictureBox3.TabIndex=5;
            pictureBox3.TabStop=false;
            pictureBox3.Click+=pictureBox3_Click;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName="openFileDialog1";
            // 
            // textBox1
            // 
            textBox1.Location=new Point(977, 391);
            textBox1.Name="textBox1";
            textBox1.Size=new Size(36, 27);
            textBox1.TabIndex=8;
            // 
            // hScrollBar1
            // 
            hScrollBar1.Location=new Point(1019, 391);
            hScrollBar1.Maximum=19;
            hScrollBar1.Name="hScrollBar1";
            hScrollBar1.Size=new Size(115, 26);
            hScrollBar1.TabIndex=9;
            hScrollBar1.Scroll+=hScrollBar1_Scroll;
            // 
            // Form1
            // 
            AutoScaleDimensions=new SizeF(8F, 20F);
            AutoScaleMode=AutoScaleMode.Font;
            ClientSize=new Size(1231, 723);
            Controls.Add(hScrollBar1);
            Controls.Add(textBox1);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Name="Form1";
            Text="Form1";
            Load+=Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button button2;
        private Button button3;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private OpenFileDialog openFileDialog1;
        private SaveFileDialog saveFileDialog1;
        private TextBox textBox1;
        private HScrollBar hScrollBar1;
    }
}