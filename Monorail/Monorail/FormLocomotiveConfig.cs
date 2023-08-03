using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Monorail
{
    /// <summary>
    /// Форма создания объекта
    /// </summary>
    public partial class FormLocomotiveConfig : Form
    {
        /// <summary>
        /// Переменный-выбранный локомотив
        /// </summary>
        DrawningLocomotive _locomotive = null;
        /// <summary>
        /// Событие
        /// </summary>
        private event Action<DrawningLocomotive> EventAddLocomotive;
        /// <summary>
        /// Конструктор
        /// </summary>
        public FormLocomotiveConfig()
        {
            InitializeComponent();
            panelBlack.MouseDown += PanelColor_MouseDown;
            panelPurple.MouseDown += PanelColor_MouseDown;
            panelGray.MouseDown += PanelColor_MouseDown;
            panelGreen.MouseDown += PanelColor_MouseDown;
            panelRed.MouseDown += PanelColor_MouseDown;
            panelWhite.MouseDown += PanelColor_MouseDown;
            panelYellow.MouseDown += PanelColor_MouseDown;
            panelBlue.MouseDown += PanelColor_MouseDown;
            buttonCancel.Click += (sender, e) => Close();
        }
        /// <summary>
        /// Отрисовать локомотив
        /// </summary>
        private void DrawLocomotive()
        {
            Bitmap bmp = new(pictureBoxObject.Width, pictureBoxObject.Height);
            Graphics gr = Graphics.FromImage(bmp);
            _locomotive?.SetPosition(5, 5, pictureBoxObject.Width, pictureBoxObject.Height);
            _locomotive?.DrawTransport(gr);
            pictureBoxObject.Image = bmp;
        }
        /// <summary>
        /// Добавление события
        /// </summary>
        /// <param name="ev"></param>
        public void AddEvent(Action<DrawningLocomotive> ev)
        {
            if (EventAddLocomotive == null)
            {
                EventAddLocomotive = new Action<DrawningLocomotive>(ev);
            }
            else
            {
                EventAddLocomotive += ev;
            }
        }
        /// <summary>
        /// Передаем информацию при нажатии на Label
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void LabelObject_MouseDown(object sender, MouseEventArgs e)
        {
            (sender as Label).DoDragDrop((sender as Label).Name, DragDropEffects.Move | DragDropEffects.Copy);
        }
        /// <summary>
        /// Проверка получаемой информации (ее типа на соответствие требуемому)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PanelObject_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.Text))
            {
                e.Effect = DragDropEffects.Copy;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }
        /// <summary>
        /// Действия при приеме перетаскиваемой информации
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PanelObject_DragDrop(object sender, DragEventArgs e)
        {
            switch (e.Data.GetData(DataFormats.Text).ToString())
            {
                case "labelSimpleObject":
                    _locomotive = new DrawningLocomotive((int)numericUpDownSpeed.Value, (int)numericUpDownWeight.Value, Color.White);
                    break;
                case "labelModifiedObject":
                    _locomotive = new DrawningMonorail((int)numericUpDownSpeed.Value, (int)numericUpDownWeight.Value, Color.White, Color.Black,
                        checkBoxMagneticRail.Checked, checkBoxSecondCabin.Checked);
                    break;
            }
            DrawLocomotive();
        }
        /// <summary>
        /// Отправляем цвет с панели
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PanelColor_MouseDown(object sender, MouseEventArgs e)
        {
            (sender as Control).DoDragDrop((sender as Control).BackColor, DragDropEffects.Move | DragDropEffects.Copy);
        }
        /// <summary>
        /// Проверка получаемой информации (ее типа на соответствие требуемому)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void LabelColor_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(typeof(Color)))
            {
                e.Effect = DragDropEffects.Copy;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }
        /// <summary>
        /// Принимаем основной цвет
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void LabelBaseColor_DragDrop(object sender, DragEventArgs e)
        {
            if (_locomotive != null)
            {
                _locomotive.Locomotive.ChangeColor((Color)e.Data.GetData(typeof(Color)));
                DrawLocomotive();
            }
        }
        /// <summary>
        /// Принимаем дополнительный цвет
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void LabelDopColor_DragDrop(object sender, DragEventArgs e)
        {
            if (_locomotive != null && _locomotive.Locomotive is EntityMonorail entityMonorail)
            {
                entityMonorail.ChangeDopColor((Color)e.Data.GetData(typeof(Color)));
                DrawLocomotive();
            }
        }
        /// <summary>
        /// Добавление локомотива
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonOk_Click(object sender, EventArgs e)
        {
            EventAddLocomotive?.Invoke(_locomotive);
            Close();
        }
    }
}
