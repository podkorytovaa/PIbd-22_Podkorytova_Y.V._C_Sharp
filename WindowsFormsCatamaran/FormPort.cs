using System;
using System.Drawing;
using System.Windows.Forms;

namespace WindowsFormsCatamaran
{
	public partial class FormPort : Form
	{
		private readonly PortCollection portCollection; // Объект от класса-коллекции гаваней

		public FormPort()
		{
			InitializeComponent();
			portCollection = new PortCollection(pictureBoxPort.Width, pictureBoxPort.Height);
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
			portCollection.AddParking(textBoxNewLevelName.Text); 
			ReloadLevels();
		}

		// Обработка нажатия кнопки "Удалить парковку"
		private void buttonDelPort_Click(object sender, EventArgs e)
		{
			if (listBoxPort.SelectedIndex > -1) 
			{ 
				if (MessageBox.Show($"Удалить гавань {listBoxPort.SelectedItem.ToString()}?", "Удаление", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes) 
				{ 
					portCollection.DelParking(listBoxPort.SelectedItem.ToString()); 
					ReloadLevels();
					Draw();
				} 
			}
		}

		// Обработка нажатия кнопки "Забрать"
		private void buttonTakeBoat_Click(object sender, EventArgs e)
		{
			if (listBoxPort.SelectedIndex > -1 && maskedTextBox.Text != "")
			{
				var boat = portCollection[listBoxPort.SelectedItem.ToString()] - Convert.ToInt32(maskedTextBox.Text);
				if (boat != null)
				{
					FormCatamaran form = new FormCatamaran();
					form.SetBoat(boat);
					form.ShowDialog();
				}
				Draw();
			}
		}

		// Метод обработки выбора элемента на listBoxLevels
		private void listBoxPort_SelectedIndexChanged(object sender, EventArgs e) 
		{ 
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
				if ((portCollection[listBoxPort.SelectedItem.ToString()] + boat) > - 1) 
				{ 
					Draw(); 
				} 
				else 
				{ 
					MessageBox.Show("Лодку не удалось поставить"); 
				} 
			} 
		}

		// Обработка нажатия пункта меню "Сохранить" 
		private void сохранитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
			if (saveFileDialog.ShowDialog() == DialogResult.OK) 
			{ 
				if (portCollection.SaveData(saveFileDialog.FileName)) 
				{ 
					MessageBox.Show("Сохранение прошло успешно", "Результат", MessageBoxButtons.OK, MessageBoxIcon.Information); 
				} 
				else 
				{ 
					MessageBox.Show("Не сохранилось", "Результат", MessageBoxButtons.OK, MessageBoxIcon.Error); 
				} 
			}
		}

		// Обработка нажатия пункта меню "Загрузить"
		private void загрузитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
			if (openFileDialog.ShowDialog() == DialogResult.OK) 
			{ 
				if (portCollection.LoadData(openFileDialog.FileName)) 
				{ 
					MessageBox.Show("Загрузили", "Результат", MessageBoxButtons.OK, MessageBoxIcon.Information); 
					ReloadLevels(); 
					Draw(); 
				} 
				else 
				{ 
					MessageBox.Show("Не загрузили", "Результат", MessageBoxButtons.OK, MessageBoxIcon.Error); 
				} 
			}
		}
    }
}
