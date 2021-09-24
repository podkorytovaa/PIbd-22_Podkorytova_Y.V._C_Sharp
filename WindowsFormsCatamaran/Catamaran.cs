using System.Drawing;

namespace WindowsFormsCatamaran
{
    // Класс отрисовки катамарана
    public class Catamaran
    {
        private float _startPosX; // Левая координата отрисовки катамарана
        private float _startPosY; // Правая кооридната отрисовки катамарана
        private int _pictureWidth; // Ширина окна отрисовки
        private int _pictureHeight; // Высота окна отрисовки
        private readonly int catamaranWidth = 105; // Ширина отрисовки катамарана
        private readonly int catamaranHeight = 80; // Высота отрисовки катамарана
        public int MaxSpeed { private set; get; } // Максимальная скорость
        public float Weight { private set; get; } // Вес катамарана
        public Color MainColor { private set; get; } // Основной цвет
        public Color DopColor { private set; get; } // Дополнительный цвет
        public bool Body { private set; get; } // Признак наличия корпуса
        public bool LeftCorpus { private set; get; } // Признак наличия левого бокового корпуса
        public bool RightCorpus { private set; get; } // Признак наличия правого бокового корпуса
        public bool Balks { private set; get; } // Признак наличия балок

        // Инициализация свойств
        /// <param name="maxSpeed">Максимальная скорость</param>
        /// <param name="weight">Вес катамарана</param>
        /// <param name="mainColor">Основной цвет</param>
        /// <param name="dopColor">Дополнительный цвет</param>
        /// <param name="body">Признак наличия корпуса</param>
        /// <param name="leftCorpus">Признак наличия левого бокового корпуса</param>
        /// <param name="rightCorpus">Признак наличия правого бокового корпуса</param>
        /// <param name="balks">Признак наличия балок</param>
        public void Init(int maxSpeed, float weight, Color mainColor, Color dopColor, bool body, bool leftCorpus, bool rightCorpus, bool balks)
        {
            MaxSpeed = maxSpeed;
            Weight = weight;
            MainColor = mainColor;
            DopColor = dopColor;
            Body = body;
            LeftCorpus = leftCorpus;
            RightCorpus = rightCorpus;
            Balks = balks;
        }

        // Установка позиции катамарана
        /// <param name="x">Координата X</param>
        /// <param name="y">Координата Y</param>
        /// <param name="width">Ширина картинки</param>
        /// <param name="height">Высота картинки</param>
        public void SetPosition(int x, int y, int width, int height)
        {
            _startPosX = x; 
            _startPosY = y; 
            _pictureWidth = width; 
            _pictureHeight = height;
        }

        // Изменение направления пермещения
        /// <param name="direction">Направление</param>
        public void MoveTransport(Direction direction)
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

        // Отрисовка катамарана
        public void DrawTransport(Graphics g)
        {
            Pen pen = new Pen(Color.Black);
            // основной корпус
            if (Body)
            {
                Brush body_catamaran = new SolidBrush(MainColor);
                PointF p1 = new PointF(_startPosX, _startPosY + 25);
                PointF p2 = new PointF(_startPosX + 80, _startPosY + 25);
                PointF p3 = new PointF(_startPosX + 105, _startPosY + 40);
                PointF p4 = new PointF(_startPosX + 80, _startPosY + 55);
                PointF p5 = new PointF(_startPosX, _startPosY + 55);
                PointF[] points = {p1, p2, p3, p4, p5};
                g.FillPolygon(body_catamaran, points);
                g.DrawPolygon(pen, points);

                Brush floor = new SolidBrush(DopColor);
                g.DrawEllipse(pen, _startPosX + 5, _startPosY + 30, 75, 20);
                g.FillEllipse(floor, _startPosX + 5, _startPosY + 30, 75, 20);
            }

            // боковые корпуса
            Pen pen2 = new Pen(Color.Blue);
            Brush corpus = new SolidBrush(DopColor);
            if (LeftCorpus)
            {
                PointF p1_1 = new PointF(_startPosX, _startPosY);
                PointF p1_2 = new PointF(_startPosX + 80, _startPosY);
                PointF p1_3 = new PointF(_startPosX + 105, _startPosY + 7);
                PointF p1_4 = new PointF(_startPosX + 80, _startPosY + 14);
                PointF p1_5 = new PointF(_startPosX, _startPosY + 14);
                PointF[] points2 = { p1_1, p1_2, p1_3, p1_4, p1_5 };
                g.FillPolygon(corpus, points2);
                g.DrawPolygon(pen2, points2);
            }
            if (RightCorpus)
            {
                PointF p2_1 = new PointF(_startPosX, _startPosY + 66);
                PointF p2_2 = new PointF(_startPosX + 80, _startPosY + 66);
                PointF p2_3 = new PointF(_startPosX + 105, _startPosY + 73);
                PointF p2_4 = new PointF(_startPosX + 80, _startPosY + 80);
                PointF p2_5 = new PointF(_startPosX, _startPosY + 80);
                PointF[] points3 = { p2_1, p2_2, p2_3, p2_4, p2_5 };
                g.FillPolygon(corpus, points3);
                g.DrawPolygon(pen2, points3);
            }

            // балки
            if (Balks)
            {
                Brush balk = new SolidBrush(Color.Black);
                g.FillRectangle(balk, _startPosX + 10, _startPosY + 10, 5, 20);
                g.FillRectangle(balk, _startPosX + 10, _startPosY + 51, 5, 20);
                g.FillRectangle(balk, _startPosX + 60, _startPosY + 10, 5, 20);
                g.FillRectangle(balk, _startPosX + 60, _startPosY + 51, 5, 20);
            }
        }
    }
}