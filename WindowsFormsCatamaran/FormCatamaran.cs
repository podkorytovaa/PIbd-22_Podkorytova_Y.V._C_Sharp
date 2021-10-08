using System;
using System.Drawing;
using System.Windows.Forms;

namespace WindowsFormsCatamaran
{
	public partial class FormCatamaran : Form
	{
		private ITransport boat;

		// Конструктор
		public FormCatamaran()
		{
			InitializeComponent();
		}

		// Передача лодки на форму
		public void SetBoat(ITransport boat)
		{
			this.boat = boat;
			Draw();
		}

		// Метод отрисовки катамарана
		private void Draw()
		{
			Bitmap bmp = new Bitmap(pictureBoxCatamaran.Width, pictureBoxCatamaran.Height);
			Graphics gr = Graphics.FromImage(bmp);
			boat.DrawTransport(gr);
			pictureBoxCatamaran.Image = bmp;
		}

		// Обработка нажатия кнопки "Создать лодку"
		private void buttonCreateBoat_Click(object sender, EventArgs e)
		{
			Random rnd = new Random();
			boat = new Boat(rnd.Next(100, 300), rnd.Next(1000, 2000), Color.Blue);
			boat.SetPosition(rnd.Next(10, 100), rnd.Next(10, 100), pictureBoxCatamaran.Width, pictureBoxCatamaran.Height);
			Draw();
		}

		// Обработка нажатия кнопки "Создать катамаран"
		private void buttonCreateCatamaran_Click(object sender, EventArgs e)
		{
			Random rnd = new Random();
			boat = new Catamaran(rnd.Next(100, 300), rnd.Next(1000, 2000), Color.Blue, Color.White, true, true, true, true);
			boat.SetPosition(rnd.Next(10, 100), rnd.Next(10, 100), pictureBoxCatamaran.Width, pictureBoxCatamaran.Height);
			Draw();
		}

		// Обработка нажатия кнопок управления
		private void buttonMove_Click(object sender, EventArgs e)
		{
			string name = (sender as Button).Name;
			switch (name)
			{
				case "buttonUp":
					boat?.MoveTransport(Direction.Up);
					break;
				case "buttonDown":
					boat?.MoveTransport(Direction.Down);
					break;
				case "buttonLeft":
					boat?.MoveTransport(Direction.Left);
					break;
				case "buttonRight":
					boat?.MoveTransport(Direction.Right);
					break;
			}
			Draw();
		}
	}
}
