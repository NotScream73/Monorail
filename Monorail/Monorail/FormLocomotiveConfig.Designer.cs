namespace Monorail
{
    partial class FormLocomotiveConfig
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
            this.groupBoxConfig = new System.Windows.Forms.GroupBox();
            this.labelModifiedObject = new System.Windows.Forms.Label();
            this.labelSimpleObject = new System.Windows.Forms.Label();
            this.groupBoxColors = new System.Windows.Forms.GroupBox();
            this.panelPurple = new System.Windows.Forms.Panel();
            this.panelYellow = new System.Windows.Forms.Panel();
            this.panelBlack = new System.Windows.Forms.Panel();
            this.panelBlue = new System.Windows.Forms.Panel();
            this.panelGray = new System.Windows.Forms.Panel();
            this.panelGreen = new System.Windows.Forms.Panel();
            this.panelWhite = new System.Windows.Forms.Panel();
            this.panelRed = new System.Windows.Forms.Panel();
            this.checkBoxMagneticRail = new System.Windows.Forms.CheckBox();
            this.checkBoxSecondCabin = new System.Windows.Forms.CheckBox();
            this.numericUpDownWeight = new System.Windows.Forms.NumericUpDown();
            this.labelWeight = new System.Windows.Forms.Label();
            this.numericUpDownSpeed = new System.Windows.Forms.NumericUpDown();
            this.labelSpeed = new System.Windows.Forms.Label();
            this.panelObject = new System.Windows.Forms.Panel();
            this.labelDopColor = new System.Windows.Forms.Label();
            this.labelBaseColor = new System.Windows.Forms.Label();
            this.pictureBoxObject = new System.Windows.Forms.PictureBox();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonOk = new System.Windows.Forms.Button();
            this.groupBoxConfig.SuspendLayout();
            this.groupBoxColors.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownWeight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSpeed)).BeginInit();
            this.panelObject.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxObject)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxConfig
            // 
            this.groupBoxConfig.Controls.Add(this.labelModifiedObject);
            this.groupBoxConfig.Controls.Add(this.labelSimpleObject);
            this.groupBoxConfig.Controls.Add(this.groupBoxColors);
            this.groupBoxConfig.Controls.Add(this.checkBoxMagneticRail);
            this.groupBoxConfig.Controls.Add(this.checkBoxSecondCabin);
            this.groupBoxConfig.Controls.Add(this.numericUpDownWeight);
            this.groupBoxConfig.Controls.Add(this.labelWeight);
            this.groupBoxConfig.Controls.Add(this.numericUpDownSpeed);
            this.groupBoxConfig.Controls.Add(this.labelSpeed);
            this.groupBoxConfig.Location = new System.Drawing.Point(12, 12);
            this.groupBoxConfig.Name = "groupBoxConfig";
            this.groupBoxConfig.Size = new System.Drawing.Size(520, 220);
            this.groupBoxConfig.TabIndex = 0;
            this.groupBoxConfig.TabStop = false;
            this.groupBoxConfig.Text = "Параметры";
            // 
            // labelModifiedObject
            // 
            this.labelModifiedObject.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelModifiedObject.Location = new System.Drawing.Point(394, 162);
            this.labelModifiedObject.Name = "labelModifiedObject";
            this.labelModifiedObject.Size = new System.Drawing.Size(97, 38);
            this.labelModifiedObject.TabIndex = 16;
            this.labelModifiedObject.Text = "Продвинутый";
            this.labelModifiedObject.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelModifiedObject.MouseDown += new System.Windows.Forms.MouseEventHandler(this.LabelObject_MouseDown);
            // 
            // labelSimpleObject
            // 
            this.labelSimpleObject.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelSimpleObject.Location = new System.Drawing.Point(282, 162);
            this.labelSimpleObject.Name = "labelSimpleObject";
            this.labelSimpleObject.Size = new System.Drawing.Size(97, 38);
            this.labelSimpleObject.TabIndex = 15;
            this.labelSimpleObject.Text = "Простой";
            this.labelSimpleObject.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelSimpleObject.MouseDown += new System.Windows.Forms.MouseEventHandler(this.LabelObject_MouseDown);
            // 
            // groupBoxColors
            // 
            this.groupBoxColors.Controls.Add(this.panelPurple);
            this.groupBoxColors.Controls.Add(this.panelYellow);
            this.groupBoxColors.Controls.Add(this.panelBlack);
            this.groupBoxColors.Controls.Add(this.panelBlue);
            this.groupBoxColors.Controls.Add(this.panelGray);
            this.groupBoxColors.Controls.Add(this.panelGreen);
            this.groupBoxColors.Controls.Add(this.panelWhite);
            this.groupBoxColors.Controls.Add(this.panelRed);
            this.groupBoxColors.Location = new System.Drawing.Point(267, 22);
            this.groupBoxColors.Name = "groupBoxColors";
            this.groupBoxColors.Size = new System.Drawing.Size(241, 127);
            this.groupBoxColors.TabIndex = 14;
            this.groupBoxColors.TabStop = false;
            this.groupBoxColors.Text = "Цвета";
            // 
            // panelPurple
            // 
            this.panelPurple.BackColor = System.Drawing.Color.Purple;
            this.panelPurple.Location = new System.Drawing.Point(184, 73);
            this.panelPurple.Name = "panelPurple";
            this.panelPurple.Size = new System.Drawing.Size(40, 40);
            this.panelPurple.TabIndex = 3;
            // 
            // panelYellow
            // 
            this.panelYellow.BackColor = System.Drawing.Color.Yellow;
            this.panelYellow.Location = new System.Drawing.Point(184, 22);
            this.panelYellow.Name = "panelYellow";
            this.panelYellow.Size = new System.Drawing.Size(40, 40);
            this.panelYellow.TabIndex = 1;
            // 
            // panelBlack
            // 
            this.panelBlack.BackColor = System.Drawing.Color.Black;
            this.panelBlack.Location = new System.Drawing.Point(127, 73);
            this.panelBlack.Name = "panelBlack";
            this.panelBlack.Size = new System.Drawing.Size(40, 40);
            this.panelBlack.TabIndex = 4;
            // 
            // panelBlue
            // 
            this.panelBlue.BackColor = System.Drawing.Color.Blue;
            this.panelBlue.Location = new System.Drawing.Point(127, 22);
            this.panelBlue.Name = "panelBlue";
            this.panelBlue.Size = new System.Drawing.Size(40, 40);
            this.panelBlue.TabIndex = 1;
            // 
            // panelGray
            // 
            this.panelGray.BackColor = System.Drawing.Color.Gray;
            this.panelGray.Location = new System.Drawing.Point(72, 73);
            this.panelGray.Name = "panelGray";
            this.panelGray.Size = new System.Drawing.Size(40, 40);
            this.panelGray.TabIndex = 5;
            // 
            // panelGreen
            // 
            this.panelGreen.BackColor = System.Drawing.Color.Green;
            this.panelGreen.Location = new System.Drawing.Point(72, 22);
            this.panelGreen.Name = "panelGreen";
            this.panelGreen.Size = new System.Drawing.Size(40, 40);
            this.panelGreen.TabIndex = 1;
            // 
            // panelWhite
            // 
            this.panelWhite.BackColor = System.Drawing.Color.White;
            this.panelWhite.Location = new System.Drawing.Point(15, 73);
            this.panelWhite.Name = "panelWhite";
            this.panelWhite.Size = new System.Drawing.Size(40, 40);
            this.panelWhite.TabIndex = 2;
            // 
            // panelRed
            // 
            this.panelRed.BackColor = System.Drawing.Color.Red;
            this.panelRed.Location = new System.Drawing.Point(15, 22);
            this.panelRed.Name = "panelRed";
            this.panelRed.Size = new System.Drawing.Size(40, 40);
            this.panelRed.TabIndex = 0;
            // 
            // checkBoxMagneticRail
            // 
            this.checkBoxMagneticRail.AutoSize = true;
            this.checkBoxMagneticRail.Location = new System.Drawing.Point(22, 115);
            this.checkBoxMagneticRail.Name = "checkBoxMagneticRail";
            this.checkBoxMagneticRail.Size = new System.Drawing.Size(230, 19);
            this.checkBoxMagneticRail.TabIndex = 11;
            this.checkBoxMagneticRail.Text = "Признак наличия магнитной рельсы";
            this.checkBoxMagneticRail.UseVisualStyleBackColor = true;
            // 
            // checkBoxSecondCabin
            // 
            this.checkBoxSecondCabin.AutoSize = true;
            this.checkBoxSecondCabin.Location = new System.Drawing.Point(22, 149);
            this.checkBoxSecondCabin.Name = "checkBoxSecondCabin";
            this.checkBoxSecondCabin.Size = new System.Drawing.Size(210, 19);
            this.checkBoxSecondCabin.TabIndex = 12;
            this.checkBoxSecondCabin.Text = "Признак наличия второй кабины";
            this.checkBoxSecondCabin.UseVisualStyleBackColor = true;
            // 
            // numericUpDownWeight
            // 
            this.numericUpDownWeight.Location = new System.Drawing.Point(90, 72);
            this.numericUpDownWeight.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericUpDownWeight.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.numericUpDownWeight.Name = "numericUpDownWeight";
            this.numericUpDownWeight.Size = new System.Drawing.Size(79, 23);
            this.numericUpDownWeight.TabIndex = 10;
            this.numericUpDownWeight.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // labelWeight
            // 
            this.labelWeight.AutoSize = true;
            this.labelWeight.Location = new System.Drawing.Point(22, 74);
            this.labelWeight.Name = "labelWeight";
            this.labelWeight.Size = new System.Drawing.Size(29, 15);
            this.labelWeight.TabIndex = 9;
            this.labelWeight.Text = "Вес:";
            // 
            // numericUpDownSpeed
            // 
            this.numericUpDownSpeed.Location = new System.Drawing.Point(90, 30);
            this.numericUpDownSpeed.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericUpDownSpeed.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.numericUpDownSpeed.Name = "numericUpDownSpeed";
            this.numericUpDownSpeed.Size = new System.Drawing.Size(79, 23);
            this.numericUpDownSpeed.TabIndex = 8;
            this.numericUpDownSpeed.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // labelSpeed
            // 
            this.labelSpeed.AutoSize = true;
            this.labelSpeed.Location = new System.Drawing.Point(22, 32);
            this.labelSpeed.Name = "labelSpeed";
            this.labelSpeed.Size = new System.Drawing.Size(62, 15);
            this.labelSpeed.TabIndex = 7;
            this.labelSpeed.Text = "Скорость:";
            // 
            // panelObject
            // 
            this.panelObject.AllowDrop = true;
            this.panelObject.Controls.Add(this.labelDopColor);
            this.panelObject.Controls.Add(this.labelBaseColor);
            this.panelObject.Controls.Add(this.pictureBoxObject);
            this.panelObject.Location = new System.Drawing.Point(538, 12);
            this.panelObject.Name = "panelObject";
            this.panelObject.Size = new System.Drawing.Size(262, 184);
            this.panelObject.TabIndex = 2;
            this.panelObject.DragDrop += new System.Windows.Forms.DragEventHandler(this.PanelObject_DragDrop);
            this.panelObject.DragEnter += new System.Windows.Forms.DragEventHandler(this.PanelObject_DragEnter);
            // 
            // labelDopColor
            // 
            this.labelDopColor.AllowDrop = true;
            this.labelDopColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelDopColor.Location = new System.Drawing.Point(141, 9);
            this.labelDopColor.Name = "labelDopColor";
            this.labelDopColor.Size = new System.Drawing.Size(104, 32);
            this.labelDopColor.TabIndex = 2;
            this.labelDopColor.Text = "Доп. цвет";
            this.labelDopColor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelDopColor.DragDrop += new System.Windows.Forms.DragEventHandler(this.LabelDopColor_DragDrop);
            this.labelDopColor.DragEnter += new System.Windows.Forms.DragEventHandler(this.LabelColor_DragEnter);
            // 
            // labelBaseColor
            // 
            this.labelBaseColor.AllowDrop = true;
            this.labelBaseColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelBaseColor.Location = new System.Drawing.Point(20, 9);
            this.labelBaseColor.Name = "labelBaseColor";
            this.labelBaseColor.Size = new System.Drawing.Size(104, 32);
            this.labelBaseColor.TabIndex = 1;
            this.labelBaseColor.Text = "Цвет";
            this.labelBaseColor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelBaseColor.DragDrop += new System.Windows.Forms.DragEventHandler(this.LabelBaseColor_DragDrop);
            this.labelBaseColor.DragEnter += new System.Windows.Forms.DragEventHandler(this.LabelColor_DragEnter);
            // 
            // pictureBoxObject
            // 
            this.pictureBoxObject.Location = new System.Drawing.Point(20, 44);
            this.pictureBoxObject.Name = "pictureBoxObject";
            this.pictureBoxObject.Size = new System.Drawing.Size(225, 125);
            this.pictureBoxObject.TabIndex = 0;
            this.pictureBoxObject.TabStop = false;
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(679, 202);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(104, 30);
            this.buttonCancel.TabIndex = 5;
            this.buttonCancel.Text = "Отмена";
            this.buttonCancel.UseVisualStyleBackColor = true;
            // 
            // buttonOk
            // 
            this.buttonOk.Location = new System.Drawing.Point(558, 202);
            this.buttonOk.Name = "buttonOk";
            this.buttonOk.Size = new System.Drawing.Size(104, 30);
            this.buttonOk.TabIndex = 4;
            this.buttonOk.Text = "Добавить";
            this.buttonOk.UseVisualStyleBackColor = true;
            this.buttonOk.Click += new System.EventHandler(this.ButtonOk_Click);
            // 
            // FormLocomotiveConfig
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(810, 242);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonOk);
            this.Controls.Add(this.panelObject);
            this.Controls.Add(this.groupBoxConfig);
            this.Name = "FormLocomotiveConfig";
            this.Text = "Создание объекта";
            this.groupBoxConfig.ResumeLayout(false);
            this.groupBoxConfig.PerformLayout();
            this.groupBoxColors.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownWeight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSpeed)).EndInit();
            this.panelObject.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxObject)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox groupBoxConfig;
        private CheckBox checkBoxSecondCabin;
        private CheckBox checkBoxMagneticRail;
        private NumericUpDown numericUpDownWeight;
        private Label labelWeight;
        private NumericUpDown numericUpDownSpeed;
        private Label labelSpeed;
        private Label labelModifiedObject;
        private Label labelSimpleObject;
        private GroupBox groupBoxColors;
        private Panel panelPurple;
        private Panel panelYellow;
        private Panel panelBlack;
        private Panel panelBlue;
        private Panel panelGray;
        private Panel panelGreen;
        private Panel panelWhite;
        private Panel panelRed;
        private Panel panelObject;
        private Label labelDopColor;
        private Label labelBaseColor;
        private PictureBox pictureBoxObject;
        private Button buttonCancel;
        private Button buttonOk;
    }
}