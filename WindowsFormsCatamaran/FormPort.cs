using System;
using System.Drawing;
using System.Windows.Forms;

namespace WindowsFormsCatamaran
{
	public partial class FormPort : Form
	{
		private readonly Port<Boat> port; /// Объект от класса-гавань

		public FormPort()
		{
			InitializeComponent();
			port = new Port<Boat>(pictureBoxPort.Width, pictureBoxPort.Height);
			Draw();
		}

		// Метод отрисовки гавани
		private void Draw()
		{
			Bitmap bmp = new Bitmap(pictureBoxPort.Width, pictureBoxPort.Height);
			Graphics gr = Graphics.FromImage(bmp);
			port.Draw(gr);
			pictureBoxPort.Image = bmp;
		}

		// Обработка нажатия кнопки "Пришвартовать лодку"
		private void buttonSetBoat_Click(object sender, EventArgs e)
		{
			ColorDialog dialog = new ColorDialog();
			if (dialog.ShowDialog() == DialogResult.OK)
			{
				var boat = new Boat(100, 1000, dialog.Color);
				if (port + boat >= 0)
				{
					Draw();
				}
				else
				{
					MessageBox.Show("Гавань переполнена");
				}
			}
		}

		// Обработка нажатия кнопки "Пришвартовать катамаран"
		private void buttonSetCatamaran_Click(object sender, EventArgs e)
		{
			ColorDialog dialog = new ColorDialog();
			if (dialog.ShowDialog() == DialogResult.OK)
			{
				ColorDialog dialogDop = new ColorDialog();
				if (dialogDop.ShowDialog() == DialogResult.OK)
				{
					var catamaran = new Catamaran(100, 1000, dialog.Color, dialogDop.Color, true, true, true, true);
					if (port + catamaran >= 0)
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

		// Обработка нажатия кнопки "Забрать"
		private void buttonTakeBoat_Click(object sender, EventArgs e)
		{
			if (maskedTextBox.Text != "")
			{
				var boat = port - Convert.ToInt32(maskedTextBox.Text);
				if (boat != null)
				{
					FormCatamaran form = new FormCatamaran();
					form.SetBoat(boat);
					form.ShowDialog();
				}
				Draw();
			}
		}
	}
}
