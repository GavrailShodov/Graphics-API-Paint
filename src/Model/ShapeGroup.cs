using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace Draw.src.Model
{
    public class ShapeGroup : Shape
    {
        public List<Shape> Shapes { get; private set; }

        public ShapeGroup()
        {
            Shapes = new List<Shape>();
        }

        public ShapeGroup(List<Shape> shapes)
        {
            Shapes = shapes;
            UpdateBoundingRectangle();
        }

        private Color fillColor;
        public override Color FillColor
        {
            get { return fillColor; }
            set
            {
                foreach (var shape in Shapes)
                {
                    shape.FillColor = value;
                }
            }
        }
        private Color strokeColor;
        public override Color StrokeColor
        {
            get { return strokeColor; }
            set
            {
                foreach (var shape in Shapes)
                {
                    shape.StrokeColor = value;
                }
            }
        }

        private float Stoke;

        public override float Stroke
        {
            get { return Stoke; }
            set
            {
                foreach (var shape in Shapes)
                {
                    shape.Stroke = value;
                }
            }
        }

        private void UpdateBoundingRectangle()
        {
            if (Shapes.Count == 0)
                return;

            float left = float.MaxValue, top = float.MaxValue, right = float.MinValue, bottom = float.MinValue;

            foreach (var shape in Shapes)
            {
                if (shape.Rectangle.Left < left) left = shape.Rectangle.Left;
                if (shape.Rectangle.Top < top) top = shape.Rectangle.Top;
                if (shape.Rectangle.Right > right) right = shape.Rectangle.Right;
                if (shape.Rectangle.Bottom > bottom) bottom = shape.Rectangle.Bottom;
            }

            Rectangle = new RectangleF(left, top, right - left, bottom - top);
        }

        public void AddShape(Shape shape)
        {
            Shapes.Add(shape);
            UpdateBoundingRectangle();
        }

        public void RemoveShape(Shape shape)
        {
            Shapes.Remove(shape);
            UpdateBoundingRectangle();
        }

        public override bool Contains(PointF point)
        {
            foreach (var shape in Shapes)
            {
                if (shape.Contains(point))
                    return true;
            }
            return false;
        }

        public override void DrawSelf(Graphics grfx)
        {
            foreach (var shape in Shapes)
            {
                shape.DrawSelf(grfx);
            }
        }

        public override void Rotate()
        {
            foreach (var shape in Shapes)
            {
                shape.Rotate();
            }
            UpdateBoundingRectangle();
        }

        //public void drag(pointf newlocation, dictionary<shape, pointf> initialoffsets)
        //{
        //    foreach (shape shape in shapes)
        //    {
        //        var offset = initialoffsets[shape];
        //        shape.location = new pointf(newlocation.x + offset.x, newlocation.y + offset.y);
        //    }
        //    updateboundingrectangle();
        //}
    }
}



