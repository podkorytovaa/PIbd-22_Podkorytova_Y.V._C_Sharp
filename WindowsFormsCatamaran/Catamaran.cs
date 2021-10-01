using System.Drawing;

namespace WindowsFormsCatamaran
{
    // Класс отрисовки катамарана
    public class Catamaran : Boat
    {
        public Color DopColor { private set; get; } // Дополнительный цвет
        public bool Body { private set; get; } // Признак наличия корпуса
        public bool LeftCorpus { private set; get; } // Признак наличия левого бокового корпуса
        public bool RightCorpus { private set; get; } // Признак наличия правого бокового корпуса
        public bool Balks { private set; get; } // Признак наличия балок

        // Конструктор
        /// <param name="maxSpeed">Максимальная скорость</param>
        /// <param name="weight">Вес катамарана</param>
        /// <param name="mainColor">Основной цвет</param>
        /// <param name="dopColor">Дополнительный цвет</param>
        /// <param name="body">Признак наличия корпуса</param>
        /// <param name="leftCorpus">Признак наличия левого бокового корпуса</param>
        /// <param name="rightCorpus">Признак наличия правого бокового корпуса</param>
        /// <param name="balks">Признак наличия балок</param>
        public Catamaran(int maxSpeed, float weight, Color mainColor, Color dopColor, bool body, bool leftCorpus, bool rightCorpus, bool balks) : base(maxSpeed, weight, mainColor, 105, 80)
        {
            DopColor = dopColor;
            Body = body;
            LeftCorpus = leftCorpus;
            RightCorpus = rightCorpus;
            Balks = balks;
        }

        // Отрисовка катамарана
        public override void DrawTransport(Graphics g)
        {
            // основной корпус
            base.DrawTransport(g);

            // и боковые корпуса
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

            // теперь отрисуем балки
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