using Draw.src.Model;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Windows.Forms;

namespace Draw
{
	/// <summary>
	/// Върху главната форма е поставен потребителски контрол,
	/// в който се осъществява визуализацията
	/// </summary>
	public partial class MainForm : Form
	{
		/// <summary>
		/// Агрегирания диалогов процесор във формата улеснява манипулацията на модела.
		/// </summary>
		private DialogProcessor dialogProcessor = new DialogProcessor();
        Point firstPoint = new Point();
        PointF secondPoint = new PointF();
		
        public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			toolStripStatusLabel2.Text = "Брой избрани примитиви: 0";
			

			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}

		/// <summary>
		/// Изход от програмата. Затваря главната форма, а с това и програмата.
		/// </summary>
		void ExitToolStripMenuItemClick(object sender, EventArgs e)
		{
			Close();
		}
		/// <summary>
		/// Събитието, което се прихваща, за да се превизуализира при изменение на модела.
		/// </summary>
		void ViewPortPaint(object sender, PaintEventArgs e)
		{
			dialogProcessor.ReDraw(sender, e);
		}

		/// <summary>
		/// Бутон, който поставя на произволно място правоъгълник със зададените размери.
		/// Променя се лентата със състоянието и се инвалидира контрола, в който визуализираме.
		/// </summary>
		void DrawRectangleSpeedButtonClick(object sender, EventArgs e)
		{
			dialogProcessor.AddRandomRectangle();
			//dialogProcessor.AddRandomLine();

			//statusBar.Items[0].Text = "Последно действие: Рисуване на правоъгълник";

			viewPort.Invalidate();
		}

		int counter = 0;
        private Shape sel;

        /// <summary>
        /// Прихващане на координатите при натискането на бутон на мишката и проверка (в обратен ред) дали не е
        /// щракнато върху елемент. Ако е така то той се отбелязва като селектиран и започва процес на "влачене".
        /// Промяна на статуса и инвалидиране на контрола, в който визуализираме.
        /// Реализацията се диалогът с потребителя, при който се избира "най-горния" елемент от екрана.
        /// </summary>
        void ViewPortMouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			if (selectButton.Checked)
			{
				Shape sel = dialogProcessor.ContainsPoint(e.Location);
				if (sel != null)
				{
					if (dialogProcessor.Selection.Contains(sel))
					{
						dialogProcessor.Selection.Remove(sel);
						counter--;
						toolStripStatusLabel2.Text = "Брой избрани примитиви: " + counter;

					}
					else
					{
						dialogProcessor.Selection.Add(sel);
						counter++;
						toolStripStatusLabel2.Text = "Брой избрани примитиви: " + counter;
					}
				}

				if (dialogProcessor.Selection.Count > 0)
				{
					//statusBar.Items[0].Text = "Последно действие: Селекция на примитив";
					dialogProcessor.StartDragging(e.Location);  // Start dragging multiple shapes
					viewPort.Invalidate();
				}
			}
			else if(deleteButton.Checked)
			{
				Shape sel = dialogProcessor.ContainsPoint(e.Location);
				if (sel != null)
                {
					dialogProcessor.ShapeList.Remove(sel);
                    if (dialogProcessor.Selection.Contains(sel))
                    {
                        dialogProcessor.Selection.Remove(sel);
                        counter--;
                        toolStripStatusLabel2.Text = "Брой избрани примитиви: " + counter;
                    }
                   

                    viewPort.Invalidate();
                }

			}
			else if(editButton.Checked)
            {
				sel = dialogProcessor.ContainsPoint(e.Location);
				if (sel != null)
				{
					if(sel is Line)
					{

                        BorderSize.Visible = true;
                        BorderText.Visible = true;
                        BorderText.Text = sel.Stroke.ToString();
                        toolStripButton5.Visible = true;
                    }
					else
					{
                        toolStripButton5.Visible = true;
                        widthLabel.Visible = true;
                        widthBox.Visible = true;
                        widthBox.Text = sel.Width.ToString();

                        heightLabel.Visible = true;
                        heightBox.Visible = true;
                        heightBox.Text = sel.Height.ToString();

                        BorderSize.Visible = true;
                        BorderText.Visible = true;
                        BorderText.Text = sel.Stroke.ToString();

                      
                    }
                    MoveUpButton.Visible = true;
                    MoveDownButton.Visible = true;

                }
			}
			else if(Line.Checked)
			{
				firstPoint = e.Location;
			}
		}

		/// <summary>
		/// Прихващане на преместването на мишката.
		/// Ако сме в режм на "влачене", то избрания елемент се транслира.
		/// </summary>
		void ViewPortMouseMove(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			if (dialogProcessor.IsDragging)
			{
				dialogProcessor.TranslateTo(e.Location);
				//statusBar.Items[0].Text = "Последно действие: Влачене";
				viewPort.Invalidate();
			}
		}

		/// <summary>
		/// Прихващане на отпускането на бутона на мишката.
		/// Излизаме от режим "влачене".
		/// </summary>
		void ViewPortMouseUp(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			dialogProcessor.StopDragging();
			if(firstPoint != null && Line.Checked)
			{
				secondPoint = e.Location;
                dialogProcessor.AddRandomLine(firstPoint,secondPoint);
								
				viewPort.Invalidate();
            }
		}

		private void toolStripButton1_Click(object sender, EventArgs e)
		{
			dialogProcessor.AddRandomEllipse();

			//statusBar.Items[0].Text = "Последно действие: Рисуване на елипса";

			viewPort.Invalidate();
		}

		private void toolStripButton2_Click(object sender, EventArgs e)
		{
			if (colorDialog1.ShowDialog() == DialogResult.OK)
			{
				foreach (Shape item in dialogProcessor.Selection)
				{
					item.FillColor = colorDialog1.Color;
					viewPort.Invalidate();
				}

			}
		}

		private void pickUpSpeedButton_Click(object sender, EventArgs e)
		{
			deleteButton.Checked = false;
			editButton.Checked = false; 
			Line.Checked = false;
		}

		private void toolStripStatusLabel2_Click(object sender, EventArgs e)
		{

		}

		private void toolStripStatusLabel1_Click(object sender, EventArgs e)
		{

		}

		private void toolStripButton3_Click(object sender, EventArgs e)
		{
			dialogProcessor.AddRandomTriangle();

			//statusBar.Items[0].Text = "Последно действие: Рисуване на триъгълник";

			viewPort.Invalidate();
		}

		private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
		{
			saveFile();
		}

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
			foreach (Shape item in dialogProcessor.Selection)
			{
				item.Rotate();			
			}
			viewPort.Invalidate();
		}

        private void toolStripButton5_Click(object sender, EventArgs e)
        {
			selectButton.Checked = false;
			editButton.Checked = false;
			Line.Checked = false;
		}
		public void SaveShapesToFile(List<Shape> shapes, string filePath)
		{
			var settings = new JsonSerializerSettings { TypeNameHandling = TypeNameHandling.All };
			var json = JsonConvert.SerializeObject(shapes, settings);
			File.WriteAllText(filePath, json);
		}

		private List<Shape> LoadShapesFromFile(string filePath)
		{
			var settings = new JsonSerializerSettings { TypeNameHandling = TypeNameHandling.All };
			var json = File.ReadAllText(filePath);
			var shapes = JsonConvert.DeserializeObject<List<Shape>>(json, settings);
			return shapes;
		}

		
        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
			openFile();
		}

        private void toolStripButton5_Click_1(object sender, EventArgs e)
        {
			deleteButton.Checked = false;
			selectButton.Checked = false;
			Line.Checked = false;
        }

        private void toolStripLabel1_Click(object sender, EventArgs e)
        {

        }

        private void toolStripButton5_Click_2(object sender, EventArgs e)
        {
			try
			{
				if(sel is Line)
				{
                    sel.Stroke = float.Parse(BorderText.Text);
                    BorderSize.Visible = false;
                    BorderText.Visible = false;
                    BorderText.Text = "";
                    toolStripButton5.Visible = false;
                    MoveUpButton.Visible = false;
                    MoveDownButton.Visible = false;
                    viewPort.Invalidate();
                    sel = null;
                }
				else
				{
                    sel.Width = float.Parse(widthBox.Text);
                    sel.Height = float.Parse(heightBox.Text);
                    sel.Stroke = float.Parse(BorderText.Text);

                    widthLabel.Visible = false;
                    widthBox.Visible = false;
                    widthBox.Text = "";
                    heightLabel.Visible = false;
                    heightBox.Visible = false;
                    heightBox.Text = "";
                    BorderSize.Visible = false;
                    BorderText.Visible = false;
                    BorderText.Text = "";
                    toolStripButton5.Visible = false;
                    MoveUpButton.Visible = false;
                    MoveDownButton.Visible = false;
                    viewPort.Invalidate();
                    sel = null;

                }
                
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}

        private void toolStripButton7_Click(object sender, EventArgs e)
        {

        }

        private void toolStripLabel1_Click_1(object sender, EventArgs e)
        {

        }

        private void widthBox_Click(object sender, EventArgs e)
        {

        }

        private void ColorText_Click(object sender, EventArgs e)
        {

        }

        private void BorderColor_Click(object sender, EventArgs e)
        {

		}

        private void BorderPalete_Click(object sender, EventArgs e)
        {
			if (colorDialog2.ShowDialog() == DialogResult.OK)
			{
				foreach (Shape item in dialogProcessor.Selection)
				{
					item.StrokeColor = colorDialog2.Color;
					viewPort.Invalidate();
				}
			}
		}

        private void MainForm_KeyDown(object sender, KeyEventArgs e)
        {
			if (e.Modifiers == Keys.Control && e.KeyCode == Keys.S)
			{
				saveFile();
			}
			if (e.Modifiers == Keys.Control && e.KeyCode == Keys.O)
			{
				openFile();
			}
			if (e.Modifiers == Keys.Control && e.KeyCode == Keys.X)
			{
				Close();
			}
		}
		private void saveFile()
		{
			SaveFileDialog saveFileDialog = new SaveFileDialog();
			saveFileDialog.Filter = "JPG(.JPG)|.jpg |JSON files (.json)|.json";

			if (saveFileDialog.ShowDialog() == DialogResult.OK)
			{
				if (saveFileDialog.FilterIndex == 1)
				{
					Bitmap bmp = new Bitmap(viewPort.Width, viewPort.Height);

					using (Graphics g = Graphics.FromImage(bmp))
					{
						g.SmoothingMode = SmoothingMode.AntiAlias;
						dialogProcessor.Draw(g);

					}


					bmp.Save(saveFileDialog.FileName, System.Drawing.Imaging.ImageFormat.Png);
				}
				else if (saveFileDialog.FilterIndex == 2)
				{
					SaveShapesToFile(dialogProcessor.ShapeList, saveFileDialog.FileName);
				}

			}
		}
		private void openFile()
		{
			OpenFileDialog openFileDialog = new OpenFileDialog();
			openFileDialog.Filter = "All files (*.*)|*.*";
			if (openFileDialog.ShowDialog() == DialogResult.OK)
			{
				dialogProcessor.ShapeList = LoadShapesFromFile(openFileDialog.FileName);
				viewPort.Invalidate();
			}
		}

        private void toolStripButton6_Click(object sender, EventArgs e)
        {
			int a = dialogProcessor.ShapeList.IndexOf(sel)+1;

			if (a != dialogProcessor.ShapeList.Count) 
			{
				if (dialogProcessor.ShapeList.Contains(sel)) {
					int i = dialogProcessor.ShapeList.IndexOf(sel) + 1;
					dialogProcessor.ShapeList.Remove(sel);
					dialogProcessor.ShapeList.Insert(i, sel);
					viewPort.Invalidate();
				}
			}
        }

        private void MoveDownButton_Click(object sender, EventArgs e)
        {
			int a = dialogProcessor.ShapeList.IndexOf(sel);

			if (a != 0)
				{
				if (dialogProcessor.ShapeList.Contains(sel))
				{
					int i = dialogProcessor.ShapeList.IndexOf(sel) - 1;
					dialogProcessor.ShapeList.Remove(sel);
					dialogProcessor.ShapeList.Insert(i, sel);
					viewPort.Invalidate();
				}
			}
		}

        private void GroupButton_Click(object sender, EventArgs e)
        {
			if (selectButton.Checked)
            {
                ShapeGroup grp = new ShapeGroup();
				foreach(Shape shape in dialogProcessor.Selection)
				{
					if (shape is ShapeGroup)
					{
						var group = (ShapeGroup)shape;
						grp.Shapes.AddRange(group.Shapes);
					}
					grp.Shapes.Add(shape);
				}

				dialogProcessor.ShapeList.Add(grp);
				foreach (Shape s in grp.Shapes)
				{
					dialogProcessor.ShapeList.Remove(s);
				}
				dialogProcessor.Selection.Clear();
				toolStripStatusLabel2.Text = "Брой избрани примитиви: " + dialogProcessor.Selection.Count;
				counter = 0;

            }

        }

        private void Line_Click(object sender, EventArgs e)
        {
            deleteButton.Checked = false;
            selectButton.Checked = false;
			editButton.Checked = false;
        }

        private void UngroupButton_Click(object sender, EventArgs e)
        {
			if(dialogProcessor.Selection.Count > 1) 
			{
				if (!(dialogProcessor.Selection[0] is ShapeGroup))
				{
					MessageBox.Show("Селектирай само групата която искаш да разгрупираш");
				}
				
            }
            else if (dialogProcessor.Selection.Count == 1 && (dialogProcessor.Selection[0] is ShapeGroup))
			{
				var grp = dialogProcessor.Selection[0];
				var group = (ShapeGroup)grp;
				
				dialogProcessor.ShapeList.AddRange(group.Shapes);
				group.Shapes.Clear();

				dialogProcessor.Selection.Clear();
				counter = 0;
                toolStripStatusLabel2.Text = "Брой избрани примитиви: " + dialogProcessor.Selection.Count;


            }
        }

        private void toolStripButton6_Click_1(object sender, EventArgs e)
        {
			dialogProcessor.AddFigure();
			viewPort.Invalidate();
        }
    }
}
