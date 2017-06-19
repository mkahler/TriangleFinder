namespace TriangleFinder.Models
{
    public interface IManageGrids
    {
        /// <summary>
        /// Creates an instance of a TriangelGrid based on the rows and columns provided. The Instance is stored for future use.
        /// </summary>
        /// <returns>The created TriangleGrid instance.</returns>
        /// <param name="rows">Rows.</param>
        /// <param name="columns">Columns.</param>
        TriangleGrid Create(int rows, int columns);

        /// <summary>
        ///  Finds a previously created triangleGid instance.
        /// </summary>
        /// <returns>The found TriangleGrid.</returns>
        /// <param name="id">Identifier.</param>
        TriangleGrid Find(long id);
    }
}
