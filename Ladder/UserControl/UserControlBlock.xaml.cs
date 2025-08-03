using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApp1
{
    /// <summary>
    /// Interação lógica para UserControlblck.xam
    /// </summary>
    public partial class UserControlblck : UserControl
    {

        bool Selected = false;
        bool Focus = false;

        enum GraphObjectsType 
        { LINE,
            SQUARE,
        };

        abstract class ClassObjectPrimitive
        { 
        
            public Color Color { get; set; }
        
        }

        class LineObject : ClassObjectPrimitive
        {
            public Point Start;
            public Point End;
        
        }
        class SquareObject : ClassObjectPrimitive
        {
            public Point Start;
            public Size Size { get; set; }
            public int Lenght;
            public int top;

        }

        class CircleObject : ClassObjectPrimitive
        {
            public Point Start;
            public int  Radius;

        }

  
            List<ClassObjectPrimitive> GraphObjects;
       

        public UserControlblck()
        {
            InitializeComponent();
            GraphObjects = new List<ClassObjectPrimitive>();
             

            GraphObjects.Add(new CircleObject() { Start = new Point(50, 50), Radius = 20});
            GraphObjects.Add(new LineObject() { Start = new Point(10, 10),End = new Point(90,90) });
            GraphObjects.Add(new SquareObject() { Start = new Point(10,10), Size = new Size(90, 90) });
           
        }

        public double xt = 100;

        public double yt = 100;
        public bool Moving = false;

        protected override void OnMouseLeftButtonDown(MouseButtonEventArgs e)
        {   
            xt = Mouse.GetPosition(this).X;
            yt = Mouse.GetPosition(this).Y;
            Moving = true;
          //  Selected = true;
          //  this.InvalidateVisual();
          //  base.OnMouseLeftButtonDown(e);
            base.OnPreviewMouseLeftButtonDown(e);
        }

        protected override void OnMouseLeftButtonUp(MouseButtonEventArgs e)
        {
           
            Moving = false;
            base.OnMouseLeftButtonDown(e);
        }

        protected override void OnMouseEnter(MouseEventArgs e)
        {
            Selected = true;
            this.InvalidateVisual();
            base.OnMouseEnter(e);
        }
        protected override void OnMouseLeave(MouseEventArgs e)
        {
            Selected = false;
            this.InvalidateVisual();
            base.OnMouseLeave(e);
        }

        protected override void OnRender(DrawingContext drawingContext)
        {
        
        

            if (Selected == true)
            {
                drawingContext.DrawRectangle(new SolidColorBrush(Colors.Blue) {Opacity =0.2 }, new Pen(Brushes.Black, 2), new System.Windows.Rect(1, 1, 100, 100));
            }
            else
            {   
                drawingContext.DrawRectangle( new SolidColorBrush(Colors.Transparent), new Pen(Brushes.Black, 2), new System.Windows.Rect(1,1,100,100));
            }

            if (GraphObjects != null)
            {
                foreach (ClassObjectPrimitive O in GraphObjects)
                {
                    if (O is SquareObject)
                    {
                        System.Windows.Rect r = new System.Windows.Rect(((SquareObject)O).Start, ((SquareObject)O).Size);
                        drawingContext.DrawRectangle(null, new Pen(Brushes.Black, 2), r);
                    }
                    else if (O is CircleObject)
                    {
                        drawingContext.DrawEllipse(null, new Pen(Brushes.Black, 2), ((CircleObject)O).Start, 10, 10);
                    }
                    else if (O is LineObject)
                    {
                        drawingContext.DrawLine(new Pen(Brushes.Black, 2), ((LineObject)O).Start, ((LineObject)O).End);
                    }
                    else
                    {

                    }
                }
            }

    base.OnRender(drawingContext);

        }
    }
}
