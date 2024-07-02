using Newtonsoft.Json;
using System;
using System.Drawing;

namespace Draw
{
	/// <summary>
	/// Класът правоъгълник е основен примитив, който е наследник на базовия Shape.
	/// </summary>
	public class RectangleShape : Shape
	{
		#region Constructor
		[JsonConstructor]
		public RectangleShape(RectangleF rect) : base(rect)
		{
		}
		
		public RectangleShape(RectangleShape rectangle) : base(rectangle)
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
			if (base.Contains(point))
				// Проверка дали е в обекта само, ако точката е в обхващащия правоъгълник.
				// В случая на правоъгълник - директно връщаме true
				return true;
			else
				// Ако не е в обхващащия правоъгълник, то неможе да е в обекта и => false
				return false;
		}
		
		/// <summary>
		/// Частта, визуализираща конкретния примитив.
		/// </summary>
		public override void DrawSelf(Graphics grfx)
		{
			base.DrawSelf(grfx);
			
			grfx.FillRectangle(new SolidBrush(FillColor),Rectangle.X, Rectangle.Y, Rectangle.Width, Rectangle.Height);
			grfx.DrawRectangle(new Pen(StrokeColor, Stroke), Rectangle.X, Rectangle.Y, Rectangle.Width, Rectangle.Height);
			
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
