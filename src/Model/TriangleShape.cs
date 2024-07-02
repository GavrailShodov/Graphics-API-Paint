using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace Draw
{
	public class TriangleShape : Shape
	{
		#region Constructor
        [JsonConstructor]
		public TriangleShape(RectangleF rect) : base(rect)
		{
        }

		public TriangleShape(RectangleShape rectangle) : base(rectangle)
		{
		}

		#endregion

		/// <summary>
		/// Проверка за принадлежност на точка point към правоъгълника.
		/// </summary>
		public override bool Contains(PointF point)
		{
			PointF v1 = new PointF(Rectangle.Left + Rectangle.Width / 2, Rectangle.Top);
			PointF v2 = new PointF(Rectangle.Left, Rectangle.Bottom);
			PointF v3 = new PointF(Rectangle.Right, Rectangle.Bottom);

            PointF[] points = { v1, v2, v3 };

            PointF center = new PointF(Rectangle.Left + Rectangle.Width / 2, Rectangle.Top + Rectangle.Height / 2);
            Matrix matrix = new Matrix();
            matrix.RotateAt(-RotationAngle, center);
            PointF[] pointArray = { point };
            matrix.TransformPoints(pointArray);
            point = pointArray[0];

            float b1, b2, b3;
			b1 = Formula(point, v1, v2);
			b2 = Formula(point, v2, v3);
			b3 = Formula(point, v3, v1);
			if (b1 < 0 && b2 < 0 && b3 < 0)
			{
				return true;
			}
			else
			{
				return false;
			}
		}
		private float Formula(PointF p1, PointF p2, PointF p3)
		{
			return (p1.X - p3.X) * (p2.Y - p3.Y) - (p2.X - p3.X) * (p1.Y - p3.Y);
		}

        /// <summary>
        /// Частта, визуализираща конкретния примитив.
        /// </summary>
        public override void DrawSelf(Graphics grfx)
        {
            base.DrawSelf(grfx);

            PointF v1 = new PointF(Rectangle.Left + Rectangle.Width / 2, Rectangle.Top);
            PointF v2 = new PointF(Rectangle.Left, Rectangle.Bottom);
            PointF v3 = new PointF(Rectangle.Right, Rectangle.Bottom);

            PointF[] points = { v1, v2, v3 };

            GraphicsState state = grfx.Save();

            Rotate(grfx);

            grfx.FillPolygon(new SolidBrush(FillColor), points);
            grfx.DrawPolygon(new Pen(StrokeColor, Stroke), points);

            grfx.Restore(state);
        }

        private float rotationAngle;
        public float RotationAngle
        {
            get { return rotationAngle; }
            set { rotationAngle = value; }
        }

        /// <summary>
        /// </summary>
        public override void Rotate()
        {
            RotationAngle += 90;
            if (RotationAngle >= 360)
            {
                RotationAngle -= 360;
            }
        }

        /// <summary>
        /// </summary>
        private void Rotate(Graphics grfx)
        {
            PointF center = new PointF(Rectangle.Left + Rectangle.Width / 2, Rectangle.Top + Rectangle.Height / 2);

            grfx.TranslateTransform(center.X, center.Y);
            grfx.RotateTransform(RotationAngle);
            grfx.TranslateTransform(-center.X, -center.Y);
        }
    }
}
