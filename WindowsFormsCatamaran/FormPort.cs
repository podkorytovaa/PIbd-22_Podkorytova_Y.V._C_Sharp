using System;
using System.Drawing;
using System.Windows.Forms;

namespace WindowsFormsCatamaran
{
	public partial class FormPort : Form
	{
		private readonly PortCollection portCollection; /// Объект от класса-коллекции гаваней

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
					portCollection.DelParking(textBoxNewLevelName.Text); 
					ReloadLevels(); 
				} 
			}
		}

		// Обработка нажатия кнопки "Пришвартовать лодку"
		private void buttonSetBoat_Click(object sender, EventArgs e)
		{
			if (listBoxPort.SelectedIndex > -1)
			{
				ColorDialog dialog = new ColorDialog();
				if (dialog.ShowDialog() == DialogResult.OK)
				{
					var boat = new Boat(100, 1000, dialog.Color);
					if (portCollection[listBoxPort.SelectedItem.ToString()] + boat >= 0)
					{
						Draw();
					}
					else
					{
						MessageBox.Show("Гавань переполнена");
					}
				}
			}
		}

		// Обработка нажатия кнопки "Пришвартовать катамаран"
		private void buttonSetCatamaran_Click(object sender, EventArgs e)
		{
			if (listBoxPort.SelectedIndex > -1)
			{
				ColorDialog dialog = new ColorDialog();
				if (dialog.ShowDialog() == DialogResult.OK)
				{
					ColorDialog dialogDop = new ColorDialog();
					if (dialogDop.ShowDialog() == DialogResult.OK)
					{
						var catamaran = new Catamaran(100, 1000, dialog.Color, dialogDop.Color, true, true, true, true);
						if (portCollection[listBoxPort.SelectedItem.ToString()] + catamaran >= 0)
						{
							Draw();
						}
						else
						{
							MessageBox.Show("Гавань переполнена");
						}
					}
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
	}
}
