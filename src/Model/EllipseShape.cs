using Newtonsoft.Json;
using System;
using System.Drawing;

namespace Draw
{
	/// <summary>
	/// Класът правоъгълник е основен примитив, който е наследник на базовия Shape.
	/// </summary>
	public class EllipseShape : Shape
	{
		#region Constructor
		[JsonConstructor]
		public EllipseShape(RectangleF rect) : base(rect)
		{
		}

		public EllipseShape(RectangleShape rectangle) : base(rectangle)
		{
		}

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

			double cx = Location.X + base.Width / 2;
			double cy = Location.Y + base.Height / 2;
			double a = base.Width / 2;
			double b = base.Height / 2;
			double x = (point.X - cx) / a;
			double y = (point.Y - cy) / b;

			// формула: (x-cx)^2 / a^2 + (y-cy)^2 / b^2 <= 1


			if ((x * x + y * y) <= 1)
				// Проверка дали е в обекта само, ако точката е в обхващащия правоъгълник.
				return true;
			else
				return false;
		}

		/// <summary>
		/// Частта, визуализираща конкретния примитив.
		/// </summary>
		public override void DrawSelf(Graphics grfx)
		{
			base.DrawSelf(grfx);

			grfx.FillEllipse(new SolidBrush(FillColor), Rectangle.X, Rectangle.Y, Rectangle.Width, Rectangle.Height);
			grfx.DrawEllipse(new Pen(StrokeColor, Stroke), Rectangle.X, Rectangle.Y, Rectangle.Width, Rectangle.Height);

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
