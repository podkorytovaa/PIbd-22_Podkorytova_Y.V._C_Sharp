using System.Drawing;

namespace WindowsFormsCatamaran
{
	public class Boat : Vehicle
	{
		protected readonly int catamaranWidth = 105; // Ширина отрисовки лодки
		protected readonly int catamaranHeight = 55; // Высота отрисовки лодки

		// Конструктор

		/// <param name="maxSpeed">Максимальная скорость</param>
		/// <param name="weight">Вес лодки</param>
		/// <param name="mainColor">Основной цвет</param>
		public Boat(int maxSpeed, float weight, Color mainColor)
		{
			MaxSpeed = maxSpeed;
			Weight = weight;
			MainColor = mainColor;
		}

		// Конструктор с изменением размеров лодки
		/// <param name="maxSpeed">Максимальная скорость</param>
		/// <param name="weight">Вес лодки</param>
		/// <param name="mainColor">Основной цвет</param>
		/// <param name="catamaranWidth">Ширина отрисовки лодки</param>
		/// <param name="catamaranHeight">Высота отрисовки лодки</param>
		protected Boat(int maxSpeed, float weight, Color mainColor, int catamaranWidth, int catamaranHeight)
		{
			MaxSpeed = maxSpeed;
			Weight = weight;
			MainColor = mainColor;
			this.catamaranWidth = catamaranWidth;
			this.catamaranHeight = catamaranHeight;
		}
		public override void MoveTransport(Direction direction)
		{
			float step = MaxSpeed * 100 / Weight;
			switch (direction)
			{
				// вправо
				case Direction.Right:
					if (_startPosX + step < _pictureWidth - catamaranWidth)
					{
						_startPosX += step;
					}
					break;
				//влево
				case Direction.Left:
					if (_startPosX - step > 0)
					{
						_startPosX -= step;
					}
					break;
				//вверх
				case Direction.Up:
					if (_startPosY - step > 0)
					{
						_startPosY -= step;
					}
					break;
				//вниз
				case Direction.Down:
					if (_startPosY + step < _pictureHeight - catamaranHeight)
					{
						_startPosY += step;
					}
					break;
			}
		}
		public override void DrawTransport(Graphics g)
		{
			Pen pen = new Pen(Color.Black);
			Brush body_catamaran = new SolidBrush(MainColor);
			PointF p1 = new PointF(_startPosX, _startPosY + 25);
			PointF p2 = new PointF(_startPosX + 80, _startPosY + 25);
			PointF p3 = new PointF(_startPosX + 105, _startPosY + 40);
			PointF p4 = new PointF(_startPosX + 80, _startPosY + 55);
			PointF p5 = new PointF(_startPosX, _startPosY + 55);
			PointF[] points = { p1, p2, p3, p4, p5 };
			g.FillPolygon(body_catamaran, points);
			g.DrawPolygon(pen, points);

			Brush floor = new SolidBrush(Color.White);
			g.DrawEllipse(pen, _startPosX + 5, _startPosY + 30, 75, 20);
			g.FillEllipse(floor, _startPosX + 5, _startPosY + 30, 75, 20);
		}
	}
}