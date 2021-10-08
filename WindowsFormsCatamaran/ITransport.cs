using System.Drawing;

namespace WindowsFormsCatamaran
{
	public interface ITransport
	{
		// Установка позиции
		/// <param name="x">Координата X</param>
		/// <param name="y">Координата Y</param>
		/// <param name="width">Ширина картинки</param>
		/// <param name="height">Высота картинки</param>
		void SetPosition(int x, int y, int width, int height);

		// Изменение направления пермещения
		/// <param name="direction">Направление</param>
		void MoveTransport(Direction direction);

		// Отрисовка
		void DrawTransport(Graphics g);
	}
}
