using System;
using System.Collections.Generic;
using System.Drawing;


namespace DrawingPolygons
{
    [Serializable]
    public class Scene
    {
        List<Polygon> Polygons { set; get; } = new List<Polygon>();

        Polygon CurrentPolygon { get; set; } = new Polygon();

        public Scene()
        {
            Polygons = new List<Polygon>();
        }

        public void AddPoint(Point p)
        {
            CurrentPolygon.AddPoint(p);
            if (CurrentPolygon.IsClosed)
            {
                Polygons.Add(CurrentPolygon);
                CurrentPolygon = new Polygon();
            }
        }

        public void UpdateCursor(Point p)
        {
            CurrentPolygon.UpdateCursor(p);
        }

        public void Draw(Graphics g)
        {
            CurrentPolygon.Draw(g);
            foreach (Polygon p in Polygons)
            {
                p.Draw(g);
            }
        }
    }
}
