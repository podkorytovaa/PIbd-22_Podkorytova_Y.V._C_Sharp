using NLog;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace WindowsFormsCatamaran
{
	public partial class FormPort : Form
	{
		private readonly PortCollection portCollection; // Объект от класса-коллекции гаваней
		private readonly Logger logger; // Логгер

		public FormPort()
		{
			InitializeComponent();
			portCollection = new PortCollection(pictureBoxPort.Width, pictureBoxPort.Height);
			logger = LogManager.GetCurrentClassLogger();
		}

		// Заполнение listBoxLevels
		private void ReloadLevels()
		{
			int index = listBoxPort.SelectedIndex;

			listBoxPort.Items.Clear();
			for (int i = 0; i < portCollection.Keys.Count; i++)
			{
				listBoxPort.Items.Add(portCollection.Keys[i]);
			} 
 
            if(listBoxPort.Items.Count > 0 && (index == -1 || index >= listBoxPort.Items.Count))
			{ 
				listBoxPort.SelectedIndex = 0;
			}
			else if (listBoxPort.Items.Count > 0 && index > -1 && index < listBoxPort.Items.Count)
			{ 
				listBoxPort.SelectedIndex = index; 
			}         
		} 

		// Метод отрисовки гавани
		private void Draw()
		{
			if (listBoxPort.SelectedIndex > -1)
			{
				Bitmap bmp = new Bitmap(pictureBoxPort.Width, pictureBoxPort.Height);
				Graphics gr = Graphics.FromImage(bmp);
				portCollection[listBoxPort.SelectedItem.ToString()].Draw(gr);
				pictureBoxPort.Image = bmp;
			}
			else
			{
				Bitmap bmp = new Bitmap(pictureBoxPort.Width, pictureBoxPort.Height);
				Graphics gr = Graphics.FromImage(bmp);
				pictureBoxPort.Image = bmp;
			}
		}

		// Обработка нажатия кнопки "Добавить парковку"
		private void buttonAddPort_Click(object sender, EventArgs e)
		{
			if (string.IsNullOrEmpty(textBoxNewLevelName.Text)) 
			{ 
				MessageBox.Show("Введите название гавани", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error); 
				return; 
			}
			logger.Info($"Добавили гавань {textBoxNewLevelName.Text}");
			portCollection.AddPort(textBoxNewLevelName.Text); 
			ReloadLevels();
		}

		// Обработка нажатия кнопки "Удалить парковку"
		private void buttonDelPort_Click(object sender, EventArgs e)
		{
			if (listBoxPort.SelectedIndex > -1) 
			{ 
				if (MessageBox.Show($"Удалить гавань {listBoxPort.SelectedItem.ToString()}?", "Удаление", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes) 
				{
					logger.Info($"Удалили гавань {listBoxPort.SelectedItem.ToString()}"); 
					portCollection.DelPort(listBoxPort.SelectedItem.ToString()); 
					ReloadLevels();
				}
				Draw();
			}
		}

		// Обработка нажатия кнопки "Забрать"
		private void buttonTakeBoat_Click(object sender, EventArgs e)
		{
			if (listBoxPort.SelectedIndex > -1 && maskedTextBox.Text != "")
			{
				try
				{
					var boat = portCollection[listBoxPort.SelectedItem.ToString()] - Convert.ToInt32(maskedTextBox.Text);
					if (boat != null)
					{
						FormCatamaran form = new FormCatamaran();
						form.SetBoat(boat);
						form.ShowDialog();
						logger.Info($"Изъята лодка {boat} с места {maskedTextBox.Text}");
					}
					Draw();
				}
				catch (PortNotFoundException ex) 
				{
					logger.Warn("Попытка забрать лодку с незанятого места");
					MessageBox.Show(ex.Message, "Не найдено", MessageBoxButtons.OK, MessageBoxIcon.Error); 
				}
				catch (Exception ex) 
				{
					logger.Warn("Неизвестная ошибка при попытке удалить лодку");
					MessageBox.Show(ex.Message, "Неизвестная ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error); 
				}
			}
		}

		// Метод обработки выбора элемента на listBoxLevels
		private void listBoxPort_SelectedIndexChanged(object sender, EventArgs e) 
		{
			logger.Info($"Перешли в гавань {listBoxPort.SelectedItem.ToString()}");
			Draw(); 
		}

		// Обработка нажатия кнопки "Добавить лодку"
		private void buttonAddBoat_Click(object sender, EventArgs e)
        {
			if (listBoxPort.SelectedIndex > -1)
			{
				var formCatamaranConfig = new FormCatamaranConfig();
				formCatamaranConfig.AddEvent(AddBoat);
				formCatamaranConfig.Show();
			}
		}

		// Метод добавления
		private void AddBoat(Vehicle boat) 
		{ 
			if (boat != null && listBoxPort.SelectedIndex > -1) 
			{
				try
				{
					if ((portCollection[listBoxPort.SelectedItem.ToString()] + boat) > -1)
					{
						Draw();
						logger.Info($"Добавлена лодка {boat}");
					}
					else
					{
						MessageBox.Show("Лодку не удалось пришвартовать");
					}
				}
				catch (PortOverflowException ex)
				{
					logger.Warn("Гавань переполнена, невозможно добавить лодку");
					MessageBox.Show(ex.Message, "Переполнение", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
				catch (PortAlreadyHaveException ex)
				{
					logger.Warn("Дублирование лодки");
					MessageBox.Show(ex.Message, "Дублирование", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
				catch (Exception ex)
				{
					logger.Warn("Неизвестная ошибка при попытке добавить лодку");
					MessageBox.Show(ex.Message, "Неизвестная ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
			} 
		}

		// Обработка нажатия пункта меню "Сохранить" 
		private void сохранитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
			if (saveFileDialog.ShowDialog() == DialogResult.OK) 
			{
				try
				{
					portCollection.SaveData(saveFileDialog.FileName);
					MessageBox.Show("Сохранение прошло успешно", "Результат", MessageBoxButtons.OK, MessageBoxIcon.Information);
					logger.Info("Сохранено в файл " + saveFileDialog.FileName);
				}
				catch (Exception ex) 
				{
					logger.Warn("Ошибка при сохранении");
					MessageBox.Show(ex.Message, "Неизвестная ошибка при сохранении", MessageBoxButtons.OK, MessageBoxIcon.Error); 
				}
			}
		}

		// Обработка нажатия пункта меню "Загрузить"
		private void загрузитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
			if (openFileDialog.ShowDialog() == DialogResult.OK) 
			{
				try
				{
					portCollection.LoadData(openFileDialog.FileName);
					MessageBox.Show("Загрузили", "Результат", MessageBoxButtons.OK, MessageBoxIcon.Information);
					logger.Info("Загружено из файла " + openFileDialog.FileName); 
					ReloadLevels();
					Draw();
				}
				catch (PortOverflowException ex) 
				{
					logger.Warn("Гавань переполнена");
					MessageBox.Show(ex.Message, "Занятое место", MessageBoxButtons.OK, MessageBoxIcon.Error); 
				}
				catch (Exception ex) 
				{
					logger.Warn("Ошибка при загрузке");
					MessageBox.Show(ex.Message, "Неизвестная ошибка при загрузке", MessageBoxButtons.OK, MessageBoxIcon.Error); 
				}
			}
		}

		// Обработка нажатия кнопки "Сортировка" 
		private void buttonSort_Click(object sender, EventArgs e)
        {
			if (listBoxPort.SelectedIndex > -1) 
			{ 
				portCollection[listBoxPort.SelectedItem.ToString()].Sort(); 
				Draw(); 
				logger.Info("Сортировка уровней"); 
			}
		}
    }
}
