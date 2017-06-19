using System.Collections.Generic;
using System.Drawing;

namespace TriangleFinder.Models
{
    public class TriangleGrid
    {
        private readonly int _rows;
        private readonly int _columns;
        private readonly List<List<Triangle>> _grid;
        private readonly List<char> _letters = new List<char>() { 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z' };

        public long Id { get; set; }
        public List<List<Triangle>> Grid { get { return _grid; } }

        /// <summary>
        /// Initializes a new instance of the <see cref="T:TriangleFinder.Models.TriangleGrid"/> class.
        /// </summary>
        /// <param name="rows">Rows.</param>
        /// <param name="columns">Columns.</param>
        public TriangleGrid(int rows, int columns)
        {
            _rows = rows;
            _columns = columns;
            _grid = new List<List<Triangle>>();

            Init();

        }

        /// <summary>
        /// Finds the triangle in the grid at vertices: v1, v2 and v3.
        /// </summary>
        /// <returns>The <see cref="T:TriangleFinder.Models.Triangle"/>.</returns>
        /// <param name="v1">V1.</param>
        /// <param name="v2">V2.</param>
        /// <param name="v3">V3.</param>
        public Triangle FindAt(Point v1, Point v2, Point v3)
        {
            Triangle found = null;

            // make sure that all vertices are unique
            if(v1 == v2 || v1 == v3 || v2 == v3)
            {
                return found;
            }

            foreach(var row in Grid)
            {
                found = row.Find(t =>
                                 t.Vertices.Contains(v1)
                                 && t.Vertices.Contains(v2)
                                 && t.Vertices.Contains(v3));
                
                if (found != null)
                { 
                    break; 
                }
            }
            return found;
        }

        private void Init()
        {
            for (var r = 0; r < _rows; r++)
            {
                var row = new List<Triangle>();
                var k = 0; // used in incrementing the coordinates of the triangle vertices

                for (var c = 0; c < _columns; c++)
                {
                    Triangle t = null;
                    if(c % 2 == 0)
                    {
                        t = new Triangle(
                                new Point(k, r),
	                            new Point(k, r + 1),
	                            new Point(k + 1, r + 1),
                                GetLabel(r, c));
                    }
                    else
                    {
                        k++;
						t = new Triangle(
                                new Point(k - 1, r),
								new Point(k, r),
								new Point(k, r + 1),
                                GetLabel(r, c));
                    }

                    if(t != null)
                    {
                        row.Add(t);
                    }
                }
                Grid.Add(row);
            }
        }

        private string GetLabel(int row, int column)
        {
            // TODO: handle situation where there are more than 26 rows
            return $"{_letters[row]}{column + 1}";
        }
    }
}
