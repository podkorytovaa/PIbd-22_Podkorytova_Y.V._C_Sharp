using System;
using System.Drawing;

namespace WindowsFormsCatamaran
{
    // Класс отрисовки катамарана
    public class Catamaran : Boat, IEquatable<Catamaran>
    {
        public Color DopColor { private set; get; } // Дополнительный цвет
        public bool Body { private set; get; } // Признак наличия корпуса
        public bool LeftCorpus { private set; get; } // Признак наличия левого бокового корпуса
        public bool RightCorpus { private set; get; } // Признак наличия правого бокового корпуса
        public bool Seat { private set; get; } // Признак наличия сидения

        // Конструктор
        public Catamaran(int maxSpeed, float weight, Color mainColor, Color dopColor, bool body, bool leftCorpus, bool rightCorpus, bool seat) : base(maxSpeed, weight, mainColor, 105, 80)
        {
            DopColor = dopColor;
            Body = body;
            LeftCorpus = leftCorpus;
            RightCorpus = rightCorpus;
            Seat = seat;
        }

        // Конструктор для загрузки с файла
        public Catamaran(string info) : base(info)
        {
            string[] strs = info.Split(separator);
            if (strs.Length == 8)
            {
                MaxSpeed = Convert.ToInt32(strs[0]);
                Weight = Convert.ToInt32(strs[1]);
                MainColor = Color.FromName(strs[2]);
                DopColor = Color.FromName(strs[3]);
                Body = Convert.ToBoolean(strs[4]);
                LeftCorpus = Convert.ToBoolean(strs[5]);
                RightCorpus = Convert.ToBoolean(strs[6]);
                Seat = Convert.ToBoolean(strs[7]);
            }
        }

        // Отрисовка катамарана
        public override void DrawTransport(Graphics g)
        {
            // основной корпус
            base.DrawTransport(g);

            // и боковые корпуса
            Pen pen2 = new Pen(Color.Black);
            Brush corpus = new SolidBrush(DopColor);
            Brush balk = new SolidBrush(Color.Black);
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

                g.FillRectangle(balk, _startPosX + 10, _startPosY + 10, 5, 20);
                g.FillRectangle(balk, _startPosX + 60, _startPosY + 10, 5, 20);
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

                g.FillRectangle(balk, _startPosX + 10, _startPosY + 51, 5, 20);
                g.FillRectangle(balk, _startPosX + 60, _startPosY + 51, 5, 20);
            }

            // теперь отрисуем балки
            if (Seat)
            {
                g.FillRectangle(balk, _startPosX + 30, _startPosY + 30, 10, 20);
            }
        }

        // Смена дополнительного цвета 
        public void SetDopColor(Color color)
        {
            DopColor = color;
        }

        public override string ToString()
        {
            return $"{base.ToString()}{separator}{DopColor.Name}{separator}{Body}{separator}{LeftCorpus}{separator}{RightCorpus}{separator}{Seat}";
        }

        // Метод интерфейса IEquatable для класса Catamaran
        public bool Equals(Catamaran other)
        {
            if (base.Equals(other))
            {
                if (DopColor != other.DopColor)
                {
                    return false;
                }
                if (Body != other.Body)
                {
                    return false;
                }
                if (LeftCorpus != other.LeftCorpus)
                {
                    return false;
                }
                if (RightCorpus != other.RightCorpus)
                {
                    return false;
                }
                if (Seat != other.Seat)
                {
                    return false;
                }
                return true;
            }
            return false;
        }

        // Перегрузка метода от object 
        public override bool Equals(Object obj)
        {
            if (obj == null)
            {
                return false;
            }
            if (!(obj is Catamaran catamaranObj))
            {
                return false;
            }
            else
            {
                return Equals(catamaranObj);
            }
        }
    }
}