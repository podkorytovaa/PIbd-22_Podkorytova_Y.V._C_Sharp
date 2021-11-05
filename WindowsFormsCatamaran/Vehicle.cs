using System.Drawing;

namespace WindowsFormsCatamaran
{
	public abstract class Vehicle : ITransport
	{
		protected float _startPosX; // Левая координата отрисовки лодки
		protected float _startPosY; // Правая кооридната отрисовки лодки
		protected int _pictureWidth; // Ширина окна отрисовки
		protected int _pictureHeight; // Высота окна отрисовки
		public int MaxSpeed { protected set; get; } // Максимальная скорость
		public float Weight { protected set; get; } // Вес лодки
		public Color MainColor { protected set; get; } // Основной цвет
		public void SetPosition(int x, int y, int width, int height)
		{
			_startPosX = x;
			_startPosY = y;
			_pictureWidth = width;
			_pictureHeight = height;
		}
		public void SetMainColor(Color color)
		{
			MainColor = color;
		}
		public abstract void DrawTransport(Graphics g);
		public abstract void MoveTransport(Direction direction);
	}
}
