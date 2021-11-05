using System.Drawing;

namespace WindowsFormsCatamaran
{
	public interface ITransport
	{
		void SetPosition(int x, int y, int width, int height); // Установка позиции
		void MoveTransport(Direction direction); // Изменение направления пермещения
		void DrawTransport(Graphics g); // Отрисовка
		void SetMainColor(Color color); // Смена основного цвета
	}
}
