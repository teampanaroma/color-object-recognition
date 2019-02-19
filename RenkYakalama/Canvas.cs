using System.Collections.Generic;
using System.Drawing;

namespace RenkYakalama
{
    class Canvas
    {
        private int width, height;
        private int xPanelu, y1Panelu, y2Panelu, y3Panelu;
        private Picture picture;
        private readonly Pen redLine = new Pen(Color.Red, 3.0f);
        private readonly Pen whiteLine = new Pen(Color.White, 2.0f); 
        private readonly Bod[] bodyPanel;
        private int intVal = 60;
        private Color colorStatus = Color.Red;
        private readonly static Image cross = Properties.Resources.cross;
        private static Point crossPoint;

        private IList<Bod> body = new List<Bod>(); 

        public Canvas(Picture picture)
        {
            this.width = picture.width;
            this.height = picture.height;
            this.picture = picture;

            this.xPanelu = width - width / 6;
            this.y1Panelu = height / 4;
            this.y2Panelu = y1Panelu * 2;
            this.y3Panelu = y1Panelu * 3;
            int xBoduPanelu = (width - xPanelu)/2 + xPanelu;
            int yPosunBoduPanelu = y1Panelu / 2;
            crossPoint = new Point(xBoduPanelu - 40, y3Panelu + yPosunBoduPanelu - 40);
            this.bodyPanel = new Bod[] {
                new Bod(xBoduPanelu, yPosunBoduPanelu, intVal, Color.Red),
                new Bod(xBoduPanelu, y1Panelu+yPosunBoduPanelu, intVal, Color.Green),
                new Bod(xBoduPanelu, y2Panelu+yPosunBoduPanelu, intVal, Color.Blue)
            };
        }

        public void render(Graphics g)
        {
            foreach (Bod b in body)
            {
                b.render(g);
            }

            renderPanel(g);

            Object o = picture.getObject();
            if (o != null) 
            {
                intVal = o.getWidth() > o.getHeight() ? o.getHeight() : o.getWidth();

                if (o.getStredX()+ intVal / 2 < xPanelu)
                {
                    Bod b = new Bod(o.getStredX(), o.getStredY(), intVal, colorStatus);
                    b.render(g);
                    body.Add(b);
                }
                else
                {
                    if (o.getStredY() < y1Panelu)
                    {

                        setBrushColors(Color.Red);
                    }
                    else if (o.getStredY() < y2Panelu)
                    {
                        setBrushColors(Color.Green);
                    }
                    else if (o.getStredY() < y3Panelu)
                    {
                        setBrushColors(Color.Blue);
                    }
                    else
                    {
                        Clean();
                    }
                }
                g.DrawEllipse(whiteLine, o.getStredX() - intVal / 2 - 2, o.getStredY() - intVal / 2 - 2, intVal + 4, intVal + 4);
                
            }

            
        }

        public void Clean()
        {
            body.Clear();
        }
        public void setBrushColors(Color newColor)
        {
            colorStatus = newColor;
        }
        public Color getBrushColors()
        {
            return colorStatus;
        }

        private void renderPanel(Graphics g)
        {
            foreach (Bod b in bodyPanel)
            {
                b.render(g);
            }

            if (colorStatus == Color.Red)
                bodyPanel[0].highLight(whiteLine, g);
            else if (colorStatus == Color.Green)
                bodyPanel[1].highLight(whiteLine, g);
            else if (colorStatus == Color.Blue)
                bodyPanel[2].highLight(whiteLine, g);

            g.DrawImage(cross, crossPoint);
        }
    }

    class Bod
    {
        int x, y, width;
        Brush b;

        public Bod(int x, int y, int width, Color color)
        {
            this.x = x;
            this.y = y;
            this.width = width;
            b = new SolidBrush(color);
        }

        public void render(Graphics g)
        {
            g.FillEllipse(b, x-width/2, y-width/2, width, width);
        }
        public void highLight(Pen burn, Graphics g)
        {
            g.DrawEllipse(burn, x - width / 2 - 2, y - width / 2 - 2, width + 4, width + 4);
        }
    }
}
