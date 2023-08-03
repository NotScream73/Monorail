namespace Monorail
{
    partial class FormLocomotive
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
            this.pictureBoxLocomotive = new System.Windows.Forms.PictureBox();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabelSpeed = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabelWeight = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabelBodyColor = new System.Windows.Forms.ToolStripStatusLabel();
            this.buttonCreate = new System.Windows.Forms.Button();
            this.buttonUp = new System.Windows.Forms.Button();
            this.buttonLeft = new System.Windows.Forms.Button();
            this.buttonRight = new System.Windows.Forms.Button();
            this.buttonDown = new System.Windows.Forms.Button();
            this.buttonCreateModif = new System.Windows.Forms.Button();
            this.buttonSelectLocomotive = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLocomotive)).BeginInit();
            this.statusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBoxLocomotive
            // 
            this.pictureBoxLocomotive.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBoxLocomotive.Location = new System.Drawing.Point(0, 0);
            this.pictureBoxLocomotive.Name = "pictureBoxLocomotive";
            this.pictureBoxLocomotive.Size = new System.Drawing.Size(800, 428);
            this.pictureBoxLocomotive.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBoxLocomotive.TabIndex = 0;
            this.pictureBoxLocomotive.TabStop = false;
            this.pictureBoxLocomotive.Resize += new System.EventHandler(this.PictureBoxLocomotive_Resize);
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabelSpeed,
            this.toolStripStatusLabelWeight,
            this.toolStripStatusLabelBodyColor});
            this.statusStrip.Location = new System.Drawing.Point(0, 428);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(800, 22);
            this.statusStrip.TabIndex = 1;
            // 
            // toolStripStatusLabelSpeed
            // 
            this.toolStripStatusLabelSpeed.Name = "toolStripStatusLabelSpeed";
            this.toolStripStatusLabelSpeed.Size = new System.Drawing.Size(62, 17);
            this.toolStripStatusLabelSpeed.Text = "Скорость:";
            // 
            // toolStripStatusLabelWeight
            // 
            this.toolStripStatusLabelWeight.Name = "toolStripStatusLabelWeight";
            this.toolStripStatusLabelWeight.Size = new System.Drawing.Size(29, 17);
            this.toolStripStatusLabelWeight.Text = "Вес:";
            // 
            // toolStripStatusLabelBodyColor
            // 
            this.toolStripStatusLabelBodyColor.Name = "toolStripStatusLabelBodyColor";
            this.toolStripStatusLabelBodyColor.Size = new System.Drawing.Size(36, 17);
            this.toolStripStatusLabelBodyColor.Text = "Цвет:";
            // 
            // buttonCreate
            // 
            this.buttonCreate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonCreate.Location = new System.Drawing.Point(12, 392);
            this.buttonCreate.Name = "buttonCreate";
            this.buttonCreate.Size = new System.Drawing.Size(75, 23);
            this.buttonCreate.TabIndex = 2;
            this.buttonCreate.Text = "Создать";
            this.buttonCreate.UseVisualStyleBackColor = true;
            this.buttonCreate.Click += new System.EventHandler(this.ButtonCreate_Click);
            // 
            // buttonUp
            // 
            this.buttonUp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonUp.BackgroundImage = global::Monorail.Properties.Resources.arrowUp;
            this.buttonUp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonUp.Location = new System.Drawing.Point(723, 350);
            this.buttonUp.Name = "buttonUp";
            this.buttonUp.Size = new System.Drawing.Size(30, 30);
            this.buttonUp.TabIndex = 3;
            this.buttonUp.Text = " ";
            this.buttonUp.UseVisualStyleBackColor = true;
            this.buttonUp.Click += new System.EventHandler(this.ButtonMove_Click);
            // 
            // buttonLeft
            // 
            this.buttonLeft.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonLeft.BackgroundImage = global::Monorail.Properties.Resources.arrowLeft;
            this.buttonLeft.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonLeft.Location = new System.Drawing.Point(687, 385);
            this.buttonLeft.Name = "buttonLeft";
            this.buttonLeft.Size = new System.Drawing.Size(30, 30);
            this.buttonLeft.TabIndex = 4;
            this.buttonLeft.Text = " ";
            this.buttonLeft.UseVisualStyleBackColor = true;
            this.buttonLeft.Click += new System.EventHandler(this.ButtonMove_Click);
            // 
            // buttonRight
            // 
            this.buttonRight.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonRight.BackgroundImage = global::Monorail.Properties.Resources.arrowRight;
            this.buttonRight.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonRight.Location = new System.Drawing.Point(759, 385);
            this.buttonRight.Name = "buttonRight";
            this.buttonRight.Size = new System.Drawing.Size(30, 30);
            this.buttonRight.TabIndex = 5;
            this.buttonRight.Text = " ";
            this.buttonRight.UseVisualStyleBackColor = true;
            this.buttonRight.Click += new System.EventHandler(this.ButtonMove_Click);
            // 
            // buttonDown
            // 
            this.buttonDown.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonDown.BackgroundImage = global::Monorail.Properties.Resources.arrowDown;
            this.buttonDown.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonDown.Location = new System.Drawing.Point(723, 385);
            this.buttonDown.Name = "buttonDown";
            this.buttonDown.Size = new System.Drawing.Size(30, 30);
            this.buttonDown.TabIndex = 6;
            this.buttonDown.Text = " ";
            this.buttonDown.UseVisualStyleBackColor = true;
            this.buttonDown.Click += new System.EventHandler(this.ButtonMove_Click);
            // 
            // buttonCreateModif
            // 
            this.buttonCreateModif.Location = new System.Drawing.Point(107, 392);
            this.buttonCreateModif.Name = "buttonCreateModif";
            this.buttonCreateModif.Size = new System.Drawing.Size(110, 23);
            this.buttonCreateModif.TabIndex = 7;
            this.buttonCreateModif.Text = "Модификация";
            this.buttonCreateModif.UseVisualStyleBackColor = true;
            this.buttonCreateModif.Click += new System.EventHandler(this.ButtonCreateModif_Click);
            // 
            // buttonSelectLocomotive
            // 
            this.buttonSelectLocomotive.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonSelectLocomotive.Location = new System.Drawing.Point(577, 390);
            this.buttonSelectLocomotive.Name = "buttonSelectLocomotive";
            this.buttonSelectLocomotive.Size = new System.Drawing.Size(75, 23);
            this.buttonSelectLocomotive.TabIndex = 8;
            this.buttonSelectLocomotive.Text = "Выбрать";
            this.buttonSelectLocomotive.UseVisualStyleBackColor = true;
            this.buttonSelectLocomotive.Click += new System.EventHandler(this.ButtonSelectLocomotive_Click);
            // 
            // FormLocomotive
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonSelectLocomotive);
            this.Controls.Add(this.buttonCreateModif);
            this.Controls.Add(this.buttonDown);
            this.Controls.Add(this.buttonRight);
            this.Controls.Add(this.buttonLeft);
            this.Controls.Add(this.buttonUp);
            this.Controls.Add(this.buttonCreate);
            this.Controls.Add(this.pictureBoxLocomotive);
            this.Controls.Add(this.statusStrip);
            this.Name = "FormLocomotive";
            this.Text = "Локомотив";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLocomotive)).EndInit();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureBox pictureBoxLocomotive;
        private StatusStrip statusStrip;
        private ToolStripStatusLabel toolStripStatusLabelSpeed;
        private ToolStripStatusLabel toolStripStatusLabelWeight;
        private ToolStripStatusLabel toolStripStatusLabelBodyColor;
        private Button buttonCreate;
        private Button buttonUp;
        private Button buttonLeft;
        private Button buttonRight;
        private Button buttonDown;
        private Button buttonCreateModif;
        private Button buttonSelectLocomotive;
    }
}