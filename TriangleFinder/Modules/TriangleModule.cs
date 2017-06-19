using System.Drawing;
using Nancy;
using Nancy.ModelBinding;
using TriangleFinder.Models;

namespace TriangleFinder.Modules
{
    public class TriangleModule : NancyModule
    {
        private readonly IManageGrids _gridManager;
        
        public TriangleModule(IManageGrids gridManager)
            : base("/api")
        {
            _gridManager = gridManager;

            Post["/grid"] = CreateGrid;

            Get["/grid/{id}"] = GetGrid;

            Post["/grid/{id}/triangle"] = FindTriangle;
        }

        private dynamic CreateGrid(dynamic parms)
        {
            var p = this.Bind<CreateGridParameters>();

            if(p.Rows < 1 || p.Columns < 1)
            {
                return HttpStatusCode.BadRequest;
            }

            return _gridManager.Create(p.Rows, p.Columns);
        }

        private dynamic GetGrid(dynamic parms)
        {
            var tg = _gridManager.Find((long) parms.id);
            if (tg == null)
            {
                return HttpStatusCode.NotFound;
            }
            return tg;
        }

        private dynamic FindTriangle(dynamic parms)
        {
            var tg = _gridManager.Find((long)parms.id);
            if(tg == null)
            {
                return HttpStatusCode.NotFound;
            }

            var p = this.Bind<FindTriangleParameters>();
            var t = tg.FindAt(p.V1, p.V2, p.V3);
            if(t == null)
            {
                return HttpStatusCode.NotFound;
            }

            return t;
        }

        private class CreateGridParameters
        {
            public int Rows { get; set; }
            public int Columns { get; set; }
        }

        private class FindTriangleParameters
        {
            public Point V1 { get; set; }
            public Point V2 { get; set; }
            public Point V3 { get; set; }
        }
    }
}
