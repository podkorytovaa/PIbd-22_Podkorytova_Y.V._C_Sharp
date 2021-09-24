using System;
using System.Drawing;
using System.Windows.Forms;

namespace WindowsFormsCatamaran
{
	public partial class FormCatamaran : Form
	{
		private Catamaran catamaran;

		// Конструктор
		public FormCatamaran()
		{
			InitializeComponent();
		}

		// Метод отрисовки катамарана
		private void Draw()
		{
			Bitmap bmp = new Bitmap(pictureBoxCatamaran.Width, pictureBoxCatamaran.Height);
			Graphics gr = Graphics.FromImage(bmp);
			catamaran.DrawTransport(gr);
			pictureBoxCatamaran.Image = bmp;
		}

		// Обработка нажатия кнопки "Создать"
		private void buttonCreate_Click(object sender, EventArgs e)
		{
			Random rnd = new Random();
			catamaran = new Catamaran();
			catamaran.Init(rnd.Next(100, 300), rnd.Next(1000, 2000), Color.Blue, Color.White, true, true, true, true); catamaran.SetPosition(rnd.Next(10, 100), rnd.Next(10, 100), pictureBoxCatamaran.Width, pictureBoxCatamaran.Height);
			Draw();
		}

		// Обработка нажатия кнопок управления
		private void buttonMove_Click(object sender, EventArgs e)
		{
			string name = (sender as Button).Name;
			switch (name)
			{
				case "buttonUp":
					catamaran.MoveTransport(Direction.Up);
					break;
				case "buttonDown":
					catamaran.MoveTransport(Direction.Down);
					break;
				case "buttonLeft":
					catamaran.MoveTransport(Direction.Left);
					break;
				case "buttonRight":
					catamaran.MoveTransport(Direction.Right);
					break;
			}
			Draw();
		}
	}
}
