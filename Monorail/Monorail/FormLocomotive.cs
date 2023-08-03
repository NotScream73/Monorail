namespace Monorail
{
    public partial class FormLocomotive : Form
    {
        private DrawningLocomotive _locomotive;
        /// <summary>
        /// Выбранный объект
        /// </summary>
        public DrawningLocomotive SelectedLocomotive { get; private set; }
        public FormLocomotive()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Метод прорисовки локомотива
        /// </summary>
        private void Draw()
        {
            Bitmap bmp = new(pictureBoxLocomotive.Width, pictureBoxLocomotive.Height);
            Graphics gr = Graphics.FromImage(bmp);
            _locomotive?.DrawTransport(gr);
            pictureBoxLocomotive.Image = bmp;            
        }

        /// <summary>
        /// Метод установки данных
        /// </summary>
        private void SetData()
        {
            Random rnd = new();
            _locomotive.SetPosition(rnd.Next(10, 100), rnd.Next(10, 100), pictureBoxLocomotive.Width, pictureBoxLocomotive.Height);
            toolStripStatusLabelSpeed.Text = $"Скорость: {_locomotive.Locomotive.Speed}";
            toolStripStatusLabelWeight.Text = $"Вес: {_locomotive.Locomotive.Weight}";
            toolStripStatusLabelBodyColor.Text = $"Цвет: {_locomotive.Locomotive.BodyColor.Name}";
        }
        /// <summary>
        /// Обработка нажатия кнопки "Создать"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonCreate_Click(object sender, EventArgs e)
        {
            Random rnd = new();
            Color color = Color.FromArgb(rnd.Next(0, 256), rnd.Next(0, 256), rnd.Next(0, 256));
            ColorDialog dialog = new();
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                color = dialog.Color;
            }
            _locomotive = new DrawningLocomotive(rnd.Next(100, 300), rnd.Next(1000, 2000), color);
            SetData();
            Draw();
        }
        /// <summary>
        /// Определение направления перемещения
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonMove_Click(object sender, EventArgs e)
        {
            //получаем имя кнопки
            string name = ((Button)sender)?.Name ?? string.Empty;
            switch (name)
            {
                case "buttonUp":
                    _locomotive?.MoveTransport(Direction.Up);
                    break;
                case "buttonDown":
                    _locomotive?.MoveTransport(Direction.Down);
                    break;
                case "buttonLeft":
                    _locomotive?.MoveTransport(Direction.Left);
                    break;
                case "buttonRight":
                    _locomotive?.MoveTransport(Direction.Right);
                    break;
            }
            Draw();
        }
        /// <summary>
        /// Изменение размеров формы
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PictureBoxLocomotive_Resize(object sender, EventArgs e)
        {
            _locomotive?.ChangeBorders(pictureBoxLocomotive.Width, pictureBoxLocomotive.Height);
            Draw();
        }
        /// <summary>
        /// Обработка нажатия кнопки "Модификация"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonCreateModif_Click(object sender, EventArgs e)
        {
            Random rnd = new();
            Color color = Color.FromArgb(rnd.Next(0, 256), rnd.Next(0, 256), rnd.Next(0, 256));
            ColorDialog dialog = new();
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                color = dialog.Color;
            }
            Color dopColor = Color.FromArgb(rnd.Next(0, 256), rnd.Next(0, 256), rnd.Next(0, 256));
            ColorDialog dialogDop = new();
            if (dialogDop.ShowDialog() == DialogResult.OK)
            {
                dopColor = dialogDop.Color;
            }
            _locomotive = new DrawningMonorail(rnd.Next(100, 300), rnd.Next(1000, 2000), color, dopColor,
                Convert.ToBoolean(rnd.Next(0, 2)), Convert.ToBoolean(rnd.Next(0, 2)));
            SetData();
            Draw();
        }
        /// <summary>
        /// Обработка нажатия кнопки "Выбрать"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonSelectLocomotive_Click(object sender, EventArgs e)
        {
            SelectedLocomotive = _locomotive;
            DialogResult = DialogResult.OK;
        }
    }
}