using System.Drawing;

namespace WindowsFormsCatamaran
{
	// Параметризованный класс для хранения набора объектов от интерфейса ITransport
	public class Port<T> where T : class, ITransport
	{
		private readonly T[] _places; // Массив объектов, которые храним
		private readonly int pictureWidth; // Ширина окна отрисовки
		private readonly int pictureHeight; // Высота окна отрисовки		
		private readonly int _placeSizeWidth = 220; // Ширина парковочного места
		private readonly int _placeSizeHeight = 90; // Высота парковочного места

		// Конструктор
		public Port(int picWidth, int picHeight)
		{
			int width = picWidth / _placeSizeWidth;
			int height = picHeight / _placeSizeHeight;
			_places = new T[width * height];
			pictureWidth = picWidth;
			pictureHeight = picHeight;
		}

		// Перегрузка оператора сложения
		public static int operator +(Port<T> p, T boat)
		{
			int i, j;
			i = 0;
			while (i < p.pictureHeight / p._placeSizeHeight)
			{
				j = 0;
				while (j < p.pictureWidth / p._placeSizeWidth)
				{
					if (p._places[i * (p.pictureWidth / p._placeSizeWidth) + j] == null)
					{
						p._places[i * (p.pictureWidth / p._placeSizeWidth) + j] = boat;
						boat.SetPosition(p._placeSizeWidth * j + 5, p._placeSizeHeight * i + 5, p.pictureHeight, p.pictureWidth);
						return (i * (p.pictureWidth / p._placeSizeWidth) + j);
					}
					j++;
				}
				i++;
			}
			return -1;
		}

		// Перегрузка оператора вычитания
		public static T operator -(Port<T> p, int index)
		{
			if (index < 0 || index >= p._places.Length) return null;
			else
			{
				T temp = p._places[index];
				p._places[index] = null;
				return temp;
			}
			return null;
		}

		// Метод отрисовки гавани
		public void Draw(Graphics g)
		{
			DrawMarking(g);
			for (int i = 0; i < _places.Length; i++)
			{
				_places[i]?.DrawTransport(g);
			}
		}

		// Метод отрисовки разметки парковочных мест
		private void DrawMarking(Graphics g)
		{
			Pen pen = new Pen(Color.Black, 3);
			for (int i = 0; i < pictureWidth / _placeSizeWidth; i++)
			{
				for (int j = 0; j < pictureHeight / _placeSizeHeight + 1; ++j)
				{
					g.DrawLine(pen, i * _placeSizeWidth, j * _placeSizeHeight, i * _placeSizeWidth + _placeSizeWidth / 2, j * _placeSizeHeight);
				}
				g.DrawLine(pen, i * _placeSizeWidth, 0, i * _placeSizeWidth, (pictureHeight / _placeSizeHeight) * _placeSizeHeight);
			}
		}
	}
}