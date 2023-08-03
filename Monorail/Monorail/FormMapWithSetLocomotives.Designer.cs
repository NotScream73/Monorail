namespace Monorail
{
    partial class FormMapWithSetLocomotives
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
            this.groupBoxTools = new System.Windows.Forms.GroupBox();
            this.buttonSortByColor = new System.Windows.Forms.Button();
            this.buttonSortByType = new System.Windows.Forms.Button();
            this.groupBoxMaps = new System.Windows.Forms.GroupBox();
            this.buttonAddMap = new System.Windows.Forms.Button();
            this.buttonDeleteMap = new System.Windows.Forms.Button();
            this.listBoxMaps = new System.Windows.Forms.ListBox();
            this.textBoxNewMapName = new System.Windows.Forms.TextBox();
            this.comboBoxSelectorMap = new System.Windows.Forms.ComboBox();
            this.maskedTextBoxPosition = new System.Windows.Forms.MaskedTextBox();
            this.buttonRemoveLocomotive = new System.Windows.Forms.Button();
            this.buttonShowStorage = new System.Windows.Forms.Button();
            this.buttonDown = new System.Windows.Forms.Button();
            this.buttonRight = new System.Windows.Forms.Button();
            this.buttonLeft = new System.Windows.Forms.Button();
            this.buttonUp = new System.Windows.Forms.Button();
            this.buttonShowOnMap = new System.Windows.Forms.Button();
            this.buttonAddLocomotive = new System.Windows.Forms.Button();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SaveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.LoadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.groupBoxTools.SuspendLayout();
            this.groupBoxMaps.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxTools
            // 
            this.groupBoxTools.Controls.Add(this.buttonSortByColor);
            this.groupBoxTools.Controls.Add(this.buttonSortByType);
            this.groupBoxTools.Controls.Add(this.groupBoxMaps);
            this.groupBoxTools.Controls.Add(this.maskedTextBoxPosition);
            this.groupBoxTools.Controls.Add(this.buttonRemoveLocomotive);
            this.groupBoxTools.Controls.Add(this.buttonShowStorage);
            this.groupBoxTools.Controls.Add(this.buttonDown);
            this.groupBoxTools.Controls.Add(this.buttonRight);
            this.groupBoxTools.Controls.Add(this.buttonLeft);
            this.groupBoxTools.Controls.Add(this.buttonUp);
            this.groupBoxTools.Controls.Add(this.buttonShowOnMap);
            this.groupBoxTools.Controls.Add(this.buttonAddLocomotive);
            this.groupBoxTools.Dock = System.Windows.Forms.DockStyle.Right;
            this.groupBoxTools.Location = new System.Drawing.Point(811, 24);
            this.groupBoxTools.Name = "groupBoxTools";
            this.groupBoxTools.Size = new System.Drawing.Size(204, 673);
            this.groupBoxTools.TabIndex = 0;
            this.groupBoxTools.TabStop = false;
            this.groupBoxTools.Text = "Инструменты";
            // 
            // buttonSortByColor
            // 
            this.buttonSortByColor.Location = new System.Drawing.Point(17, 319);
            this.buttonSortByColor.Name = "buttonSortByColor";
            this.buttonSortByColor.Size = new System.Drawing.Size(175, 28);
            this.buttonSortByColor.TabIndex = 12;
            this.buttonSortByColor.Text = "Сортировать по цвету";
            this.buttonSortByColor.UseVisualStyleBackColor = true;
            this.buttonSortByColor.Click += new System.EventHandler(this.ButtonSortByColor_Click);
            // 
            // buttonSortByType
            // 
            this.buttonSortByType.Location = new System.Drawing.Point(17, 276);
            this.buttonSortByType.Name = "buttonSortByType";
            this.buttonSortByType.Size = new System.Drawing.Size(175, 28);
            this.buttonSortByType.TabIndex = 11;
            this.buttonSortByType.Text = "Сортировать по типу";
            this.buttonSortByType.UseVisualStyleBackColor = true;
            this.buttonSortByType.Click += new System.EventHandler(this.ButtonSortByType_Click);
            // 
            // groupBoxMaps
            // 
            this.groupBoxMaps.Controls.Add(this.buttonAddMap);
            this.groupBoxMaps.Controls.Add(this.buttonDeleteMap);
            this.groupBoxMaps.Controls.Add(this.listBoxMaps);
            this.groupBoxMaps.Controls.Add(this.textBoxNewMapName);
            this.groupBoxMaps.Controls.Add(this.comboBoxSelectorMap);
            this.groupBoxMaps.Location = new System.Drawing.Point(6, 22);
            this.groupBoxMaps.Name = "groupBoxMaps";
            this.groupBoxMaps.Size = new System.Drawing.Size(192, 248);
            this.groupBoxMaps.TabIndex = 0;
            this.groupBoxMaps.TabStop = false;
            this.groupBoxMaps.Text = "Карты";
            // 
            // buttonAddMap
            // 
            this.buttonAddMap.Location = new System.Drawing.Point(11, 80);
            this.buttonAddMap.Name = "buttonAddMap";
            this.buttonAddMap.Size = new System.Drawing.Size(175, 35);
            this.buttonAddMap.TabIndex = 2;
            this.buttonAddMap.Text = "Добавить карту";
            this.buttonAddMap.UseVisualStyleBackColor = true;
            this.buttonAddMap.Click += new System.EventHandler(this.ButtonAddMap_Click);
            // 
            // buttonDeleteMap
            // 
            this.buttonDeleteMap.Location = new System.Drawing.Point(11, 206);
            this.buttonDeleteMap.Name = "buttonDeleteMap";
            this.buttonDeleteMap.Size = new System.Drawing.Size(175, 35);
            this.buttonDeleteMap.TabIndex = 4;
            this.buttonDeleteMap.Text = "Удалить карту";
            this.buttonDeleteMap.UseVisualStyleBackColor = true;
            this.buttonDeleteMap.Click += new System.EventHandler(this.ButtonDeleteMap_Click);
            // 
            // listBoxMaps
            // 
            this.listBoxMaps.FormattingEnabled = true;
            this.listBoxMaps.ItemHeight = 15;
            this.listBoxMaps.Location = new System.Drawing.Point(11, 121);
            this.listBoxMaps.Name = "listBoxMaps";
            this.listBoxMaps.Size = new System.Drawing.Size(175, 79);
            this.listBoxMaps.TabIndex = 3;
            this.listBoxMaps.SelectedIndexChanged += new System.EventHandler(this.ListBoxMaps_SelectedIndexChanged);
            // 
            // textBoxNewMapName
            // 
            this.textBoxNewMapName.Location = new System.Drawing.Point(11, 22);
            this.textBoxNewMapName.Name = "textBoxNewMapName";
            this.textBoxNewMapName.Size = new System.Drawing.Size(175, 23);
            this.textBoxNewMapName.TabIndex = 0;
            // 
            // comboBoxSelectorMap
            // 
            this.comboBoxSelectorMap.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxSelectorMap.FormattingEnabled = true;
            this.comboBoxSelectorMap.Items.AddRange(new object[] {
            "Простая карта"});
            this.comboBoxSelectorMap.Location = new System.Drawing.Point(11, 51);
            this.comboBoxSelectorMap.Name = "comboBoxSelectorMap";
            this.comboBoxSelectorMap.Size = new System.Drawing.Size(175, 23);
            this.comboBoxSelectorMap.TabIndex = 1;
            // 
            // maskedTextBoxPosition
            // 
            this.maskedTextBoxPosition.Location = new System.Drawing.Point(17, 404);
            this.maskedTextBoxPosition.Mask = "00";
            this.maskedTextBoxPosition.Name = "maskedTextBoxPosition";
            this.maskedTextBoxPosition.Size = new System.Drawing.Size(175, 23);
            this.maskedTextBoxPosition.TabIndex = 2;
            this.maskedTextBoxPosition.ValidatingType = typeof(int);
            // 
            // buttonRemoveLocomotive
            // 
            this.buttonRemoveLocomotive.Location = new System.Drawing.Point(17, 433);
            this.buttonRemoveLocomotive.Name = "buttonRemoveLocomotive";
            this.buttonRemoveLocomotive.Size = new System.Drawing.Size(175, 35);
            this.buttonRemoveLocomotive.TabIndex = 3;
            this.buttonRemoveLocomotive.Text = "Удалить локомотив";
            this.buttonRemoveLocomotive.UseVisualStyleBackColor = true;
            this.buttonRemoveLocomotive.Click += new System.EventHandler(this.ButtonRemoveLocomotive_Click);
            // 
            // buttonShowStorage
            // 
            this.buttonShowStorage.Location = new System.Drawing.Point(17, 486);
            this.buttonShowStorage.Name = "buttonShowStorage";
            this.buttonShowStorage.Size = new System.Drawing.Size(175, 35);
            this.buttonShowStorage.TabIndex = 4;
            this.buttonShowStorage.Text = "Посмотреть хранилище";
            this.buttonShowStorage.UseVisualStyleBackColor = true;
            this.buttonShowStorage.Click += new System.EventHandler(this.ButtonShowStorage_Click);
            // 
            // buttonDown
            // 
            this.buttonDown.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonDown.BackgroundImage = global::Monorail.Properties.Resources.arrowDown;
            this.buttonDown.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonDown.Location = new System.Drawing.Point(91, 623);
            this.buttonDown.Name = "buttonDown";
            this.buttonDown.Size = new System.Drawing.Size(30, 30);
            this.buttonDown.TabIndex = 10;
            this.buttonDown.UseVisualStyleBackColor = true;
            this.buttonDown.Click += new System.EventHandler(this.ButtonMove_Click);
            // 
            // buttonRight
            // 
            this.buttonRight.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonRight.BackgroundImage = global::Monorail.Properties.Resources.arrowRight;
            this.buttonRight.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonRight.Location = new System.Drawing.Point(127, 623);
            this.buttonRight.Name = "buttonRight";
            this.buttonRight.Size = new System.Drawing.Size(30, 30);
            this.buttonRight.TabIndex = 9;
            this.buttonRight.UseVisualStyleBackColor = true;
            this.buttonRight.Click += new System.EventHandler(this.ButtonMove_Click);
            // 
            // buttonLeft
            // 
            this.buttonLeft.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonLeft.BackgroundImage = global::Monorail.Properties.Resources.arrowLeft;
            this.buttonLeft.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonLeft.Location = new System.Drawing.Point(55, 623);
            this.buttonLeft.Name = "buttonLeft";
            this.buttonLeft.Size = new System.Drawing.Size(30, 30);
            this.buttonLeft.TabIndex = 8;
            this.buttonLeft.UseVisualStyleBackColor = true;
            this.buttonLeft.Click += new System.EventHandler(this.ButtonMove_Click);
            // 
            // buttonUp
            // 
            this.buttonUp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonUp.BackgroundImage = global::Monorail.Properties.Resources.arrowUp;
            this.buttonUp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonUp.Location = new System.Drawing.Point(91, 587);
            this.buttonUp.Name = "buttonUp";
            this.buttonUp.Size = new System.Drawing.Size(30, 30);
            this.buttonUp.TabIndex = 7;
            this.buttonUp.UseVisualStyleBackColor = true;
            this.buttonUp.Click += new System.EventHandler(this.ButtonMove_Click);
            // 
            // buttonShowOnMap
            // 
            this.buttonShowOnMap.Location = new System.Drawing.Point(17, 536);
            this.buttonShowOnMap.Name = "buttonShowOnMap";
            this.buttonShowOnMap.Size = new System.Drawing.Size(175, 35);
            this.buttonShowOnMap.TabIndex = 5;
            this.buttonShowOnMap.Text = "Посмотреть карту";
            this.buttonShowOnMap.UseVisualStyleBackColor = true;
            this.buttonShowOnMap.Click += new System.EventHandler(this.ButtonShowOnMap_Click);
            // 
            // buttonAddLocomotive
            // 
            this.buttonAddLocomotive.Location = new System.Drawing.Point(17, 363);
            this.buttonAddLocomotive.Name = "buttonAddLocomotive";
            this.buttonAddLocomotive.Size = new System.Drawing.Size(175, 35);
            this.buttonAddLocomotive.TabIndex = 1;
            this.buttonAddLocomotive.Text = "Добавить локомотив";
            this.buttonAddLocomotive.UseVisualStyleBackColor = true;
            this.buttonAddLocomotive.Click += new System.EventHandler(this.ButtonAddLocomotive_Click);
            // 
            // pictureBox
            // 
            this.pictureBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox.Location = new System.Drawing.Point(0, 24);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(811, 673);
            this.pictureBox.TabIndex = 1;
            this.pictureBox.TabStop = false;
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(1015, 24);
            this.menuStrip.TabIndex = 2;
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SaveToolStripMenuItem,
            this.LoadToolStripMenuItem});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // SaveToolStripMenuItem
            // 
            this.SaveToolStripMenuItem.Name = "SaveToolStripMenuItem";
            this.SaveToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
            this.SaveToolStripMenuItem.Text = "Сохранение";
            this.SaveToolStripMenuItem.Click += new System.EventHandler(this.SaveToolStripMenuItem_Click);
            // 
            // LoadToolStripMenuItem
            // 
            this.LoadToolStripMenuItem.Name = "LoadToolStripMenuItem";
            this.LoadToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
            this.LoadToolStripMenuItem.Text = "Загрузка";
            this.LoadToolStripMenuItem.Click += new System.EventHandler(this.LoadToolStripMenuItem_Click);
            // 
            // openFileDialog
            // 
            this.openFileDialog.Filter = "txt file | *.txt";
            // 
            // saveFileDialog
            // 
            this.saveFileDialog.Filter = "txt file | *.txt";
            // 
            // FormMapWithSetLocomotives
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1015, 697);
            this.Controls.Add(this.pictureBox);
            this.Controls.Add(this.groupBoxTools);
            this.Controls.Add(this.menuStrip);
            this.MainMenuStrip = this.menuStrip;
            this.Name = "FormMapWithSetLocomotives";
            this.Text = "Карта с набором объектов";
            this.groupBoxTools.ResumeLayout(false);
            this.groupBoxTools.PerformLayout();
            this.groupBoxMaps.ResumeLayout(false);
            this.groupBoxMaps.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private GroupBox groupBoxTools;
        private PictureBox pictureBox;
        private ComboBox comboBoxSelectorMap;
        private Button buttonShowOnMap;
        private Button buttonAddLocomotive;
        private Button buttonDown;
        private Button buttonRight;
        private Button buttonLeft;
        private Button buttonUp;
        private Button buttonShowStorage;
        private Button buttonRemoveLocomotive;
        private MaskedTextBox maskedTextBoxPosition;
        private GroupBox groupBoxMaps;
        private Button buttonDeleteMap;
        private ListBox listBoxMaps;
        private TextBox textBoxNewMapName;
        private Button buttonAddMap;
        private MenuStrip menuStrip;
        private ToolStripMenuItem файлToolStripMenuItem;
        private ToolStripMenuItem SaveToolStripMenuItem;
        private ToolStripMenuItem LoadToolStripMenuItem;
        private OpenFileDialog openFileDialog;
        private SaveFileDialog saveFileDialog;
        private Button buttonSortByColor;
        private Button buttonSortByType;
    }
}