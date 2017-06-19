using System.Collections.Generic;

namespace TriangleFinder.Models
{
    public class InMemoryGridManager : IManageGrids
    {
        private readonly Dictionary<long, TriangleGrid> _store = new Dictionary<long, TriangleGrid>();
        private long _currentKeyToInsertNext = 1;
        private readonly object _lock = new object();

		public TriangleGrid Create(int rows, int columns)
        {
            TriangleGrid tg = new TriangleGrid(rows, columns);

            lock(_lock)
            {
                tg.Id = _currentKeyToInsertNext;
                _store.Add(_currentKeyToInsertNext, tg);
                _currentKeyToInsertNext++;
            }

            return tg;
        }

		public TriangleGrid Find(long id)
        {
            TriangleGrid tg = null;
            lock(_lock)
            {
                _store.TryGetValue(id, out tg);
            }
            return tg;
        }

    }
}
