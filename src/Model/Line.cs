using Newtonsoft.Json;
using System;
using System.Drawing;
using System.Net;

namespace Draw
{
    public class Line : Shape
    {
        #region Constructor
        [JsonConstructor]
        public Line(RectangleF Line) : base(Line)
        {
        }

        public Line(Line Line) : base(Line)
        {
        }

        public Line(PointF FirstPoint, PointF SecondPoint)
        {
            this.Location = FirstPoint;
            this.secondPoint = SecondPoint; 
        }


       
        public override PointF Location { get; set; }
        public PointF secondPoint { get; set; }


        #endregion

        /// <summary>
        /// Проверка за принадлежност на точка point към правоъгълника.
        /// В случая на правоъгълник този метод може да не бъде пренаписван, защото
        /// Реализацията съвпада с тази на абстрактния клас Shape, който проверява
        /// дали точката е в обхващащия правоъгълник на елемента (а той съвпада с
        /// елемента в този случай).
        /// </summary>
        public override bool Contains(PointF point)
        {
            var epsilon = 10;
            // y = mx + c
            float m = (secondPoint.Y - Location.Y) / (secondPoint.X - Location.X);
            float c = secondPoint.Y - (m * secondPoint.X);
            return point.X >= Math.Min(Location.X, secondPoint.X)
                && point.X <= Math.Max(Location.X, secondPoint.X)
                && point.Y >= Math.Min(Location.Y, secondPoint.Y)
                && point.Y <= Math.Max(Location.Y, secondPoint.Y)
                && Math.Abs(Math.Abs(point.Y) - Math.Abs((m * point.X) + c)) < epsilon; //with relax rules
                                                                                //&& (p.Y == (m*p.X)+c); // strict version

        }
        
        /// <summary>
        /// Частта, визуализираща конкретния примитив.
        /// </summary>
        public override void DrawSelf(Graphics grfx)
        {
            base.DrawSelf(grfx);

            //grfx.FillRectangle(new SolidBrush(FillColor), Rectangle.X, Rectangle.Y, Rectangle.Width, Rectangle.Height);
            //grfx.DrawRectangle(new Pen(StrokeColor, Stroke), Rectangle.X, Rectangle.Y, Rectangle.Width, Rectangle.Height);
            grfx.DrawLine(new Pen(StrokeColor, Stroke), Location, secondPoint);
        }
        public override void Rotate()
        {
            float temp = base.Width;
            base.Width = Rectangle.Height;
            base.Height = temp;

            float centerX = Location.X + base.Height / 2;
            float centerY = Location.Y + base.Width / 2;

            Location = new PointF(centerX - base.Width / 2, centerY - base.Height / 2);
        }
    }
}

