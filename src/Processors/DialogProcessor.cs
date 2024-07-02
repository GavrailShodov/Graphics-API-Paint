using System;
using System.Drawing;
using System.Collections.Generic;
using Draw.src.Model;

namespace Draw
{
	/// <summary>
	/// Класът, който ще бъде използван при управляване на диалога.
	/// </summary>
	public class DialogProcessor : DisplayProcessor
	{
		#region Constructor
		
		public DialogProcessor()
		{
		}

		#endregion

		#region Properties

		private Dictionary<Shape, PointF> initialOffsets = new Dictionary<Shape, PointF>();
		public void StartDragging(PointF startPoint)
		{
			initialOffsets.Clear();
			foreach (Shape shape in Selection)
			{
				if (shape is ShapeGroup)
				{
					// Calculate the offset of each selected shape relative to the start point
					var shapeGrp = (ShapeGroup)shape;

					foreach (Shape item in shapeGrp.Shapes)
					{
						initialOffsets[item] = new PointF(item.Location.X - startPoint.X, item.Location.Y - startPoint.Y);
					}
				}
                initialOffsets[shape] = new PointF(shape.Location.X - startPoint.X, shape.Location.Y - startPoint.Y);
			}
			lastLocation = startPoint;
			IsDragging = true;
		}
		public void StopDragging()
		{
			IsDragging = false;
			initialOffsets.Clear();
		}

		/// <summary>
		/// Избран елемент.
		/// </summary>
		private List<Shape> selection = new List<Shape>();
		public List<Shape> Selection {
			get { return selection; }
			set { selection = value; }
		}
		
		/// <summary>
		/// Дали в момента диалога е в състояние на "влачене" на избрания елемент.
		/// </summary>
		private bool isDragging;
		public bool IsDragging {
			get { return isDragging; }
			set { isDragging = value; }
		}
		
		/// <summary>
		/// Последна позиция на мишката при "влачене".
		/// Използва се за определяне на вектора на транслация.
		/// </summary>
		private PointF lastLocation;
		public PointF LastLocation {
			get { return lastLocation; }
			set { lastLocation = value; }
		}
		
		#endregion
		
		/// <summary>
		/// Добавя примитив - правоъгълник на произволно място върху клиентската област.
		/// </summary>
		public void AddRandomRectangle()
		{
			Random rnd = new Random();
			int x = rnd.Next(100,1000);
			int y = rnd.Next(100,600);
			
			RectangleShape rect = new RectangleShape(new Rectangle(x,y,100,200));
			rect.FillColor = Color.White;
			rect.StrokeColor = Color.Green;
			rect.Stroke = 1;
			ShapeList.Add(rect);
		}

        public void AddRandomLine(PointF firstPoint,PointF secondPoint)
        {
            
			
			Line line = new Line(firstPoint, secondPoint);

			

            line.FillColor = Color.White;
            line.StrokeColor = Color.Green;
            line.Stroke = 1;
			ShapeList.Add(line);
			
        }

        public void AddRandomEllipse()
		{
			Random rnd = new Random();
			int x = rnd.Next(100, 1000);
			int y = rnd.Next(100, 600);

			EllipseShape ellipse = new EllipseShape(new Rectangle(x, y, 100, 200));
			ellipse.FillColor = Color.White;
			ellipse.StrokeColor = Color.Green;
			ellipse.Stroke = 1;

			ShapeList.Add(ellipse);
		}
		public void AddRandomTriangle()
		{
			Random rnd = new Random();
			int x = rnd.Next(100, 1000);
			int y = rnd.Next(100, 600);

			TriangleShape triangle = new TriangleShape(new Rectangle(x, y, 100, 200));
			triangle.FillColor = Color.White;
			triangle.StrokeColor = Color.Green;
			triangle.Stroke = 1;

			ShapeList.Add(triangle);
		}
        public void AddFigure()
        {
            Random rnd = new Random();
            int x = rnd.Next(100, 1000);
            int y = rnd.Next(100, 600);

           
            

            
            EllipseShape ellipse = new EllipseShape(new Rectangle(x, y, 100, 100));
            ellipse.FillColor = Color.White;
            ellipse.StrokeColor = Color.Black;
            ellipse.Stroke = 1;

            //ShapeList.Add(ellipse);

            PointF firstPoint = new PointF(x, y);
			firstPoint.X = x;
			firstPoint.Y = y+50;
            PointF secondPoint = new PointF(x, y);
            secondPoint.X = x +100;
			secondPoint.Y = y+50;
            Line line = new Line(firstPoint, secondPoint);
            line.FillColor = Color.White;
            line.StrokeColor = Color.Green;
            line.Stroke = 1;
            //ShapeList.Add(line);

            firstPoint = new PointF(x, y);
            firstPoint.X = x+50;
            firstPoint.Y = y;
            secondPoint = new PointF(x, y);
            secondPoint.X = x +50;
            secondPoint.Y = y +100;
            Line line2 = new Line(firstPoint, secondPoint);
            line2.FillColor = Color.White;
            line2.StrokeColor = Color.Green;
            line2.Stroke = 1;
            //ShapeList.Add(line2);

            firstPoint = new PointF(x, y);
            firstPoint.X = x+8;
            firstPoint.Y = y + 25;
             secondPoint = new PointF(x, y);
            secondPoint.X = x + 92;
            secondPoint.Y = y + 25;
            Line line3 = new Line(firstPoint, secondPoint);
            line3.FillColor = Color.White;
            line3.StrokeColor = Color.Green;
            line3.Stroke = 1;
           // ShapeList.Add(line3);

            firstPoint = new PointF(x, y);
            firstPoint.X = x + 8;
			firstPoint.Y = y + 75;
            secondPoint = new PointF(x, y);
            secondPoint.X = x + 92;
            secondPoint.Y = y + 75;
            Line line4 = new Line(firstPoint, secondPoint);
            line4.FillColor = Color.White;
            line4.StrokeColor = Color.Green;
            line4.Stroke = 1;
            //ShapeList.Add(line4);

			ShapeGroup group = new ShapeGroup();
			group.Shapes.Add(ellipse);
			group.Shapes.Add(line);
			group.Shapes.Add(line3);
			group.Shapes.Add(line4);
			group.Shapes.Add(line2);
            ShapeList.Add(group);

        }


        /// <summary>
        /// Проверява дали дадена точка е в елемента.
        /// Обхожда в ред обратен на визуализацията с цел намиране на
        /// "най-горния" елемент т.е. този който виждаме под мишката.
        /// </summary>
        /// <param name="point">Указана точка</param>
        /// <returns>Елемента на изображението, на който принадлежи дадената точка.</returns>
        public Shape ContainsPoint(PointF point)
		{
			for(int i = ShapeList.Count - 1; i >= 0; i--){
				if (ShapeList[i].Contains(point)){
					

					return ShapeList[i];
				}	
			}
			return null;
		}
		
		/// <summary>
		/// Транслация на избраният елемент на вектор определен от <paramref name="p>p</paramref>
		/// </summary>
		/// <param name="p">Вектор на транслация.</param>
		public void TranslateTo(PointF currentPoint)
		{
           if (!IsDragging) return;

        foreach (Shape shape in Selection)
        {
            PointF initialOffset = initialOffsets[shape];
				if(shape is ShapeGroup)
				{
					var shapeGrp = (ShapeGroup)shape;
					foreach(Shape item in shapeGrp.Shapes)
					{
                        initialOffset = initialOffsets[item];
                        item.Location = new PointF(currentPoint.X + initialOffset.X, currentPoint.Y + initialOffset.Y);
                    }
				}
            shape.Location = new PointF(currentPoint.X + initialOffset.X, currentPoint.Y + initialOffset.Y);
        }

        lastLocation = currentPoint;
		}
	}
}
