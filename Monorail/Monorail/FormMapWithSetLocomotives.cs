using Microsoft.Extensions.Logging;
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
    public partial class FormMapWithSetLocomotives : Form
    {
        /// <summary>
        /// Словарь для выпадающего списка
        /// </summary>
        private readonly Dictionary<string, AbstractMap> _mapsDict = new()
        {
            { "Простая карта", new SimpleMap() },
            { "Пустыня", new DesertMap() },
            { "Газон", new LawnMap() }
        };
        /// <summary>
        /// Объект от коллекции карт
        /// </summary>
        private readonly MapsCollection _mapsCollection;
        /// <summary>
        /// Логер
        /// </summary>
        private readonly ILogger _logger;
        /// <summary>
        /// Конструктор
        /// </summary>
        public FormMapWithSetLocomotives(ILogger<FormMapWithSetLocomotives> logger)
        {
            InitializeComponent();
            _logger = logger;
            _mapsCollection = new MapsCollection(pictureBox.Width, pictureBox.Height);
            comboBoxSelectorMap.Items.Clear();
            foreach (var elem in _mapsDict)
            {
                comboBoxSelectorMap.Items.Add(elem.Key);
            }
        }
        /// <summary>
        /// Заполнение listBoxMaps
        /// </summary>
        private void ReloadMaps()
        {
            int index = listBoxMaps.SelectedIndex;

            listBoxMaps.Items.Clear();
            for (int i = 0; i < _mapsCollection.Keys.Count; i++)
            {
                listBoxMaps.Items.Add(_mapsCollection.Keys[i]);
            }

            if (listBoxMaps.Items.Count > 0 && (index == -1 || index >= listBoxMaps.Items.Count))
            {
                listBoxMaps.SelectedIndex = 0;
            }
            else if (listBoxMaps.Items.Count > 0 && index > -1 && index < listBoxMaps.Items.Count)
            {
                listBoxMaps.SelectedIndex = index;
            }
        }
        /// <summary>
        /// Добавление карты
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonAddMap_Click(object sender, EventArgs e)
        {
            if (comboBoxSelectorMap.SelectedIndex == -1 || string.IsNullOrEmpty(textBoxNewMapName.Text))
            {
                MessageBox.Show("Не все данные заполнены", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                _logger.LogWarning("При попытке добавления карты были заполнены не все данные");
                return;
            }
            if (!_mapsDict.ContainsKey(comboBoxSelectorMap.Text))
            {
                MessageBox.Show("Нет такой карты", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                _logger.LogWarning($"Отсутствует карта с названием {comboBoxSelectorMap.Text}");
                return;
            }
            _mapsCollection.AddMap(textBoxNewMapName.Text, _mapsDict[comboBoxSelectorMap.Text]);
            ReloadMaps();
            _logger.LogInformation($"Добавлена карта {textBoxNewMapName.Text}");
        }
        /// <summary>
        /// Выбор карты
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ListBoxMaps_SelectedIndexChanged(object sender, EventArgs e)
        {
            pictureBox.Image = _mapsCollection[listBoxMaps.SelectedItem?.ToString() ?? string.Empty].ShowSet();
            _logger.LogInformation($"Переход на карту: {listBoxMaps.SelectedItem?.ToString() ?? string.Empty}");
        }
        /// <summary>
        /// Удаление карты
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonDeleteMap_Click(object sender, EventArgs e)
        {
            if (listBoxMaps.SelectedIndex == -1)
            {
                return;
            }

            if (MessageBox.Show($"Удалить карту {listBoxMaps.SelectedItem}?", "Удаление", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                _mapsCollection.DelMap(listBoxMaps.SelectedItem?.ToString() ?? string.Empty);
                ReloadMaps();
                _logger.LogInformation($"Удалена карта {listBoxMaps.SelectedItem?.ToString() ?? string.Empty}");
            }
        }
        /// <summary>
        /// Добавление объекта
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonAddLocomotive_Click(object sender, EventArgs e)
        {
            var formLocomotiveConfig = new FormLocomotiveConfig();
            formLocomotiveConfig.AddEvent(AddLocomotive);
            formLocomotiveConfig.Show();
        }
        private void AddLocomotive(DrawningLocomotive drawningLocomotive)
        {
            if (listBoxMaps.SelectedIndex == -1)
            {
                return;
            }
            DrawningObjectLocomotive locomotive = new DrawningObjectLocomotive(drawningLocomotive);
            try
            {
                if (_mapsCollection[listBoxMaps.SelectedItem?.ToString() ?? string.Empty] + locomotive != -1)
                {
                    _logger.LogInformation($"Добавление объекта {locomotive}");
                    MessageBox.Show("Объект добавлен");
                    pictureBox.Image = _mapsCollection[listBoxMaps.SelectedItem?.ToString() ?? string.Empty].ShowSet();
                }
                else
                {
                    _logger.LogWarning("Не удалось добавить объект");
                    MessageBox.Show("Не удалось добавить объект");
                }
            }
            catch (StorageOverflowException ex)
            {
                _logger.LogWarning($"Ошибка переполнения хранилища: {ex.Message}");
                MessageBox.Show($"Ошибка переполнения хранилища: {ex.Message}", "Результат", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        /// <summary>
        /// Удаление объекта
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonRemoveLocomotive_Click(object sender, EventArgs e)
        {
            if (listBoxMaps.SelectedIndex == -1)
            {
                return;
            }
            if (string.IsNullOrEmpty(maskedTextBoxPosition.Text))
            {
                return;
            }
            if (MessageBox.Show("Удалить объект?", "Удаление", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                return;
            }
            int pos = Convert.ToInt32(maskedTextBoxPosition.Text);
            try
            {
                var deletedLocomotive = _mapsCollection[listBoxMaps.SelectedItem?.ToString() ?? string.Empty] - pos;
                if (deletedLocomotive != null)
                {
                    _logger.LogInformation($"Объект {deletedLocomotive} удалён");
                    MessageBox.Show("Объект удален");
                    pictureBox.Image = _mapsCollection[listBoxMaps.SelectedItem?.ToString() ?? string.Empty].ShowSet();
                }
                else
                {
                    _logger.LogWarning($"Не удалось удалить объект по позиции {pos}");
                    MessageBox.Show("Не удалось удалить объект");
                }
            }
            catch (LocomotiveNotFoundException ex)
            {
                _logger.LogWarning($"Ошибка удаления: {ex.Message}");
                MessageBox.Show($"Ошибка удаления: {ex.Message}");
            }
        }
        /// <summary>
        /// Вывод набора
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonShowStorage_Click(object sender, EventArgs e)
        {
            if (listBoxMaps.SelectedIndex == -1)
            {
                return;
            }
            pictureBox.Image = _mapsCollection[listBoxMaps.SelectedItem?.ToString() ?? string.Empty].ShowSet();
        }
        /// <summary>
        /// Вывод карты
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonShowOnMap_Click(object sender, EventArgs e)
        {
            if (listBoxMaps.SelectedIndex == -1)
            {
                return;
            }
            pictureBox.Image = _mapsCollection[listBoxMaps.SelectedItem?.ToString() ?? string.Empty].ShowOnMap();
        }
        /// <summary>
        /// Перемещение
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonMove_Click(object sender, EventArgs e)
        {
            if (listBoxMaps.SelectedIndex == -1)
            {
                return;
            }
            //получаем имя кнопки
            string name = ((Button)sender)?.Name ?? string.Empty;
            Direction dir = Direction.None;
            switch (name)
            {
                case "buttonUp":
                    dir = Direction.Up;
                    break;
                case "buttonDown":
                    dir = Direction.Down;
                    break;
                case "buttonLeft":
                    dir = Direction.Left;
                    break;
                case "buttonRight":
                    dir = Direction.Right;
                    break;
            }
            pictureBox.Image = _mapsCollection[listBoxMaps.SelectedItem?.ToString() ?? string.Empty].MoveObject(dir);
        }
        /// <summary>
        /// Обработка нажатия "Сохранение"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SaveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    _mapsCollection.SaveData(saveFileDialog.FileName);
                    _logger.LogInformation($"Успешное сохранение по пути {saveFileDialog.FileName}");
                    MessageBox.Show("Сохранение прошло успешно", "Результат", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch(Exception ex)
                {
                    _logger.LogWarning($"Не удалось сохранить данные. Ошибка - {ex.Message}");
                    MessageBox.Show($"Не сохранилось: {ex.Message}", "Результат", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        /// <summary>
        /// Обработка нажатия "Загрузка"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void LoadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    _mapsCollection.LoadData(openFileDialog.FileName);
                    MessageBox.Show("Открытие прошло успешно", "Результат", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    _logger.LogInformation($"Успешная загрузка по пути {openFileDialog.FileName}");
                    ReloadMaps();
                }
                catch(Exception ex)
                {
                    _logger.LogWarning($"Не удалось загрузить данные. Ошибка - {ex.Message}");
                    MessageBox.Show($"Не удалось открыть: {ex.Message}", "Результат", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        /// <summary>
        /// Сортировка по типу
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonSortByType_Click(object sender, EventArgs e)
        {
            if (listBoxMaps.SelectedIndex == -1)
            {
                return;
            }
            _mapsCollection[listBoxMaps.SelectedItem?.ToString() ?? string.Empty].Sort(new LocomotiveCompareByType());
            pictureBox.Image = _mapsCollection[listBoxMaps.SelectedItem?.ToString() ?? string.Empty].ShowSet();
        }
        /// <summary>
        /// Сортировка по цвету
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonSortByColor_Click(object sender, EventArgs e)
        {
            if (listBoxMaps.SelectedIndex == -1)
            {
                return;
            }
            _mapsCollection[listBoxMaps.SelectedItem?.ToString() ?? string.Empty].Sort(new LocomotiveCompareByColor());
            pictureBox.Image = _mapsCollection[listBoxMaps.SelectedItem?.ToString() ?? string.Empty].ShowSet();
        }
    }
}
