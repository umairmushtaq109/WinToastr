namespace WinToastr
{
    partial class Toast
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Toast));
            label1 = new Label();
            pictureBox1 = new PictureBox();
            timer = new System.Windows.Forms.Timer(components);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.Font = new Font("Lato", 13.7999992F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.DarkBlue;
            label1.Location = new Point(27, 44);
            label1.Name = "label1";
            label1.Size = new Size(379, 33);
            label1.TabIndex = 0;
            label1.Text = "Connected to iPhone 12";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(429, 28);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(64, 64);
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // timer
            // 
            timer.Interval = 2000;
            timer.Tick += timer_Tick;
            // 
            // Toast
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.GhostWhite;
            ClientSize = new Size(520, 120);
            ControlBox = false;
            Controls.Add(pictureBox1);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            MaximizeBox = false;
            MaximumSize = new Size(520, 120);
            MinimizeBox = false;
            MinimumSize = new Size(520, 120);
            Name = "Toast";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Toast";
            TransparencyKey = Color.Transparent;
            Load += Toast_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private PictureBox pictureBox1;
        private System.Windows.Forms.Timer timer;
    }
}