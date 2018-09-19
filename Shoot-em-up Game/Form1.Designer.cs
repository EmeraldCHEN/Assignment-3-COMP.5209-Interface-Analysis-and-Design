namespace Shoot_em_up_Game
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.picTarget = new System.Windows.Forms.PictureBox();
            this.timer4Target = new System.Windows.Forms.Timer(this.components);
            this.picAvatar = new System.Windows.Forms.PictureBox();
            this.picWeapon = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.picShootAtT = new System.Windows.Forms.PictureBox();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            ((System.ComponentModel.ISupportInitialize)(this.picTarget)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picAvatar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picWeapon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picShootAtT)).BeginInit();
            this.SuspendLayout();
            // 
            // picTarget
            // 
            this.picTarget.Image = ((System.Drawing.Image)(resources.GetObject("picTarget.Image")));
            this.picTarget.Location = new System.Drawing.Point(12, 67);
            this.picTarget.Name = "picTarget";
            this.picTarget.Size = new System.Drawing.Size(152, 99);
            this.picTarget.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picTarget.TabIndex = 0;
            this.picTarget.TabStop = false;
            this.picTarget.Click += new System.EventHandler(this.picTarget_Click);
            // 
            // timer4Target
            // 
            this.timer4Target.Interval = 200;
            this.timer4Target.Tick += new System.EventHandler(this.timer4Target_Tick);
            // 
            // picAvatar
            // 
            this.picAvatar.BackColor = System.Drawing.Color.Transparent;
            this.picAvatar.Image = global::Shoot_em_up_Game.Properties.Resources.Peppa_Pigpig;
            this.picAvatar.Location = new System.Drawing.Point(564, 534);
            this.picAvatar.Name = "picAvatar";
            this.picAvatar.Size = new System.Drawing.Size(155, 163);
            this.picAvatar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picAvatar.TabIndex = 1;
            this.picAvatar.TabStop = false;
            this.picAvatar.Click += new System.EventHandler(this.picAvatar_Click);
            // 
            // picWeapon
            // 
            this.picWeapon.Image = ((System.Drawing.Image)(resources.GetObject("picWeapon.Image")));
            this.picWeapon.Location = new System.Drawing.Point(564, 162);
            this.picWeapon.Name = "picWeapon";
            this.picWeapon.Size = new System.Drawing.Size(91, 98);
            this.picWeapon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picWeapon.TabIndex = 2;
            this.picWeapon.TabStop = false;
            this.picWeapon.Visible = false;
            this.picWeapon.Click += new System.EventHandler(this.picWeapon_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(196, 263);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(947, 125);
            this.label1.TabIndex = 3;
            this.label1.Text = "1. Press ENTER to start\r\n\r\n2. Use LEFT / RIGHT / UP / DOWN arrows on the keyboard" +
    " to move Avatar side to side / up & down\r\n\r\n3. Press SPACE BAR to shoot the Targ" +
    "et";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // picShootAtT
            // 
            this.picShootAtT.Image = ((System.Drawing.Image)(resources.GetObject("picShootAtT.Image")));
            this.picShootAtT.Location = new System.Drawing.Point(752, 242);
            this.picShootAtT.Name = "picShootAtT";
            this.picShootAtT.Size = new System.Drawing.Size(100, 106);
            this.picShootAtT.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picShootAtT.TabIndex = 4;
            this.picShootAtT.TabStop = false;
            this.picShootAtT.Visible = false;
            this.picShootAtT.Click += new System.EventHandler(this.picShootAtT_Click);
            // 
            // progressBar
            // 
            this.progressBar.BackColor = System.Drawing.Color.White;
            this.progressBar.ForeColor = System.Drawing.Color.Yellow;
            this.progressBar.Location = new System.Drawing.Point(16, 11);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(470, 26);
            this.progressBar.TabIndex = 5;
            this.progressBar.Value = 100;
            this.progressBar.Click += new System.EventHandler(this.progressBar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(18F, 33F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1370, 749);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.picShootAtT);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.picWeapon);
            this.Controls.Add(this.picAvatar);
            this.Controls.Add(this.picTarget);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(9, 8, 9, 8);
            this.MaximumSize = new System.Drawing.Size(3000, 2222);
            this.Name = "Form1";
            this.Text = "Funny Shooting Game";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Form1_KeyPress);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.picTarget)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picAvatar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picWeapon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picShootAtT)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picTarget;
        private System.Windows.Forms.Timer timer4Target;
        private System.Windows.Forms.PictureBox picAvatar;
        private System.Windows.Forms.PictureBox picWeapon;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox picShootAtT;
        private System.Windows.Forms.ProgressBar progressBar;
    }
}

