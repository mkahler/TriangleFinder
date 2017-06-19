using System.Collections.Generic;
using System.Drawing;
using NUnit.Framework;
using TriangleFinder.Models;

namespace TriangleFinder.Tests
{
    [TestFixture]
    public class TriangleGridTests
    {
		// given
		private const int _rows = 6;
        private const int _columns = 12;
        private TriangleGrid _grid;

        [TestFixtureSetUp]
        public void Setup()
        {
			// when 
			_grid = new TriangleGrid(_rows, _columns);
        }

        [Test]
        public void Grid_Is_Iinitialized_With_Proper_Shape()
        {
            // then
            Assert.AreEqual(_rows, _grid.Grid.Count, "_grid _rows Not Equal");
            Assert.AreEqual(_columns, _grid.Grid[0].Count, "_grid row 0 does not have correct number of _columns");
            Assert.AreEqual(_columns, _grid.Grid[1].Count, "_grid row 1 does not have correct number of _columns");
            Assert.AreEqual(_columns, _grid.Grid[2].Count, "_grid row 2 does not have correct number of _columns");
            Assert.AreEqual(_columns, _grid.Grid[3].Count, "_grid row 3 does not have correct number of _columns");
            Assert.AreEqual(_columns, _grid.Grid[4].Count, "_grid row 4 does not have correct number of _columns");
            Assert.AreEqual(_columns, _grid.Grid[5].Count, "_grid row 5 does not have correct number of _columns");
        }

        [Test]
        public void Grid_Row_0_Coordinates_Match()
        {
            // then
            CollectionAssert.AreEquivalent(new List<Point>() { new Point(0, 0), new Point(0, 1), new Point(1, 1) }, _grid.Grid[0][0].Vertices, "Row 0, Col 0 Does not match");
            CollectionAssert.AreEquivalent(new List<Point>() { new Point(0, 0), new Point(1, 0), new Point(1, 1) }, _grid.Grid[0][1].Vertices, "Row 0, Col 1 Does not match");
            CollectionAssert.AreEquivalent(new List<Point>() { new Point(1, 0), new Point(2, 1), new Point(1, 1) }, _grid.Grid[0][2].Vertices, "Row 0, Col 2 Does not match");
            CollectionAssert.AreEquivalent(new List<Point>() { new Point(1, 0), new Point(2, 0), new Point(2, 1) }, _grid.Grid[0][3].Vertices, "Row 0, Col 3 Does not match");
            CollectionAssert.AreEquivalent(new List<Point>() { new Point(2, 0), new Point(2, 1), new Point(3, 1) }, _grid.Grid[0][4].Vertices, "Row 0, Col 4 Does not match");
            CollectionAssert.AreEquivalent(new List<Point>() { new Point(2, 0), new Point(3, 0), new Point(3, 1) }, _grid.Grid[0][5].Vertices, "Row 0, Col 5 Does not match");
            CollectionAssert.AreEquivalent(new List<Point>() { new Point(3, 0), new Point(3, 1), new Point(4, 1) }, _grid.Grid[0][6].Vertices, "Row 0, Col 6 Does not match");
            CollectionAssert.AreEquivalent(new List<Point>() { new Point(3, 0), new Point(4, 0), new Point(4, 1) }, _grid.Grid[0][7].Vertices, "Row 0, Col 7 Does not match");
            CollectionAssert.AreEquivalent(new List<Point>() { new Point(4, 0), new Point(4, 1), new Point(5, 1) }, _grid.Grid[0][8].Vertices, "Row 0, Col 8 Does not match");
            CollectionAssert.AreEquivalent(new List<Point>() { new Point(4, 0), new Point(5, 0), new Point(5, 1) }, _grid.Grid[0][9].Vertices, "Row 0, Col 9 Does not match");
            CollectionAssert.AreEquivalent(new List<Point>() { new Point(5, 0), new Point(5, 1), new Point(6, 1) }, _grid.Grid[0][10].Vertices, "Row 0, Col 10 Does not match");
            CollectionAssert.AreEquivalent(new List<Point>() { new Point(5, 0), new Point(6, 0), new Point(6, 1) }, _grid.Grid[0][11].Vertices, "Row 0, Col 11 Does not match");
        }

		[Test]
		public void Grid_Row_1_Coordinates_Match()
		{
			// then
			CollectionAssert.AreEquivalent(new List<Point>() { new Point(0, 1), new Point(0, 2), new Point(1, 2) }, _grid.Grid[1][0].Vertices, "Row 1, Col 0 Does not match");
			CollectionAssert.AreEquivalent(new List<Point>() { new Point(0, 1), new Point(1, 1), new Point(1, 2) }, _grid.Grid[1][1].Vertices, "Row 1, Col 1 Does not match");
			CollectionAssert.AreEquivalent(new List<Point>() { new Point(1, 1), new Point(2, 2), new Point(1, 2) }, _grid.Grid[1][2].Vertices, "Row 1, Col 2 Does not match");
			CollectionAssert.AreEquivalent(new List<Point>() { new Point(1, 1), new Point(2, 1), new Point(2, 2) }, _grid.Grid[1][3].Vertices, "Row 1, Col 3 Does not match");
			CollectionAssert.AreEquivalent(new List<Point>() { new Point(2, 1), new Point(2, 2), new Point(3, 2) }, _grid.Grid[1][4].Vertices, "Row 1, Col 4 Does not match");
			CollectionAssert.AreEquivalent(new List<Point>() { new Point(2, 1), new Point(3, 1), new Point(3, 2) }, _grid.Grid[1][5].Vertices, "Row 1, Col 5 Does not match");
			CollectionAssert.AreEquivalent(new List<Point>() { new Point(3, 1), new Point(3, 2), new Point(4, 2) }, _grid.Grid[1][6].Vertices, "Row 1, Col 6 Does not match");
			CollectionAssert.AreEquivalent(new List<Point>() { new Point(3, 1), new Point(4, 1), new Point(4, 2) }, _grid.Grid[1][7].Vertices, "Row 1, Col 7 Does not match");
			CollectionAssert.AreEquivalent(new List<Point>() { new Point(4, 1), new Point(4, 2), new Point(5, 2) }, _grid.Grid[1][8].Vertices, "Row 1, Col 8 Does not match");
			CollectionAssert.AreEquivalent(new List<Point>() { new Point(4, 1), new Point(5, 1), new Point(5, 2) }, _grid.Grid[1][9].Vertices, "Row 1, Col 9 Does not match");
			CollectionAssert.AreEquivalent(new List<Point>() { new Point(5, 1), new Point(5, 2), new Point(6, 2) }, _grid.Grid[1][10].Vertices, "Row 1, Col 10 Does not match");
			CollectionAssert.AreEquivalent(new List<Point>() { new Point(5, 1), new Point(6, 1), new Point(6, 2) }, _grid.Grid[1][11].Vertices, "Row 1, Col 11 Does not match");
		}

		[Test]
		public void Grid_Row_2_Coordinates_Match()
		{
			// then
			CollectionAssert.AreEquivalent(new List<Point>() { new Point(0, 2), new Point(0, 3), new Point(1, 3) }, _grid.Grid[2][0].Vertices, "Row 2, Col 0 Does not match");
			CollectionAssert.AreEquivalent(new List<Point>() { new Point(0, 2), new Point(1, 2), new Point(1, 3) }, _grid.Grid[2][1].Vertices, "Row 2, Col 1 Does not match");
			CollectionAssert.AreEquivalent(new List<Point>() { new Point(1, 2), new Point(2, 3), new Point(1, 3) }, _grid.Grid[2][2].Vertices, "Row 2, Col 2 Does not match");
			CollectionAssert.AreEquivalent(new List<Point>() { new Point(1, 2), new Point(2, 2), new Point(2, 3) }, _grid.Grid[2][3].Vertices, "Row 2, Col 3 Does not match");
			CollectionAssert.AreEquivalent(new List<Point>() { new Point(2, 2), new Point(2, 3), new Point(3, 3) }, _grid.Grid[2][4].Vertices, "Row 2, Col 4 Does not match");
			CollectionAssert.AreEquivalent(new List<Point>() { new Point(2, 2), new Point(3, 2), new Point(3, 3) }, _grid.Grid[2][5].Vertices, "Row 2, Col 5 Does not match");
			CollectionAssert.AreEquivalent(new List<Point>() { new Point(3, 2), new Point(3, 3), new Point(4, 3) }, _grid.Grid[2][6].Vertices, "Row 2, Col 6 Does not match");
			CollectionAssert.AreEquivalent(new List<Point>() { new Point(3, 2), new Point(4, 2), new Point(4, 3) }, _grid.Grid[2][7].Vertices, "Row 2, Col 7 Does not match");
			CollectionAssert.AreEquivalent(new List<Point>() { new Point(4, 2), new Point(4, 3), new Point(5, 3) }, _grid.Grid[2][8].Vertices, "Row 2, Col 8 Does not match");
			CollectionAssert.AreEquivalent(new List<Point>() { new Point(4, 2), new Point(5, 2), new Point(5, 3) }, _grid.Grid[2][9].Vertices, "Row 2, Col 9 Does not match");
			CollectionAssert.AreEquivalent(new List<Point>() { new Point(5, 2), new Point(5, 3), new Point(6, 3) }, _grid.Grid[2][10].Vertices, "Row 2, Col 10 Does not match");
			CollectionAssert.AreEquivalent(new List<Point>() { new Point(5, 2), new Point(6, 2), new Point(6, 3) }, _grid.Grid[2][11].Vertices, "Row 2, Col 11 Does not match");
		}

		[Test]
		public void Grid_Row_3_Coordinates_Match()
		{
			// then
			CollectionAssert.AreEquivalent(new List<Point>() { new Point(0, 3), new Point(0, 4), new Point(1, 4) }, _grid.Grid[3][0].Vertices, "Row 3, Col 0 Does not match");
			CollectionAssert.AreEquivalent(new List<Point>() { new Point(0, 3), new Point(1, 3), new Point(1, 4) }, _grid.Grid[3][1].Vertices, "Row 3, Col 1 Does not match");
			CollectionAssert.AreEquivalent(new List<Point>() { new Point(1, 3), new Point(2, 4), new Point(1, 4) }, _grid.Grid[3][2].Vertices, "Row 3, Col 2 Does not match");
			CollectionAssert.AreEquivalent(new List<Point>() { new Point(1, 3), new Point(2, 3), new Point(2, 4) }, _grid.Grid[3][3].Vertices, "Row 3, Col 3 Does not match");
			CollectionAssert.AreEquivalent(new List<Point>() { new Point(2, 3), new Point(2, 4), new Point(3, 4) }, _grid.Grid[3][4].Vertices, "Row 3, Col 4 Does not match");
			CollectionAssert.AreEquivalent(new List<Point>() { new Point(2, 3), new Point(3, 3), new Point(3, 4) }, _grid.Grid[3][5].Vertices, "Row 3, Col 5 Does not match");
			CollectionAssert.AreEquivalent(new List<Point>() { new Point(3, 3), new Point(3, 4), new Point(4, 4) }, _grid.Grid[3][6].Vertices, "Row 3, Col 6 Does not match");
			CollectionAssert.AreEquivalent(new List<Point>() { new Point(3, 3), new Point(4, 3), new Point(4, 4) }, _grid.Grid[3][7].Vertices, "Row 3, Col 7 Does not match");
			CollectionAssert.AreEquivalent(new List<Point>() { new Point(4, 3), new Point(4, 4), new Point(5, 4) }, _grid.Grid[3][8].Vertices, "Row 3, Col 8 Does not match");
			CollectionAssert.AreEquivalent(new List<Point>() { new Point(4, 3), new Point(5, 3), new Point(5, 4) }, _grid.Grid[3][9].Vertices, "Row 3, Col 9 Does not match");
			CollectionAssert.AreEquivalent(new List<Point>() { new Point(5, 3), new Point(5, 4), new Point(6, 4) }, _grid.Grid[3][10].Vertices, "Row 3, Col 10 Does not match");
			CollectionAssert.AreEquivalent(new List<Point>() { new Point(5, 3), new Point(6, 3), new Point(6, 4) }, _grid.Grid[3][11].Vertices, "Row 3, Col 11 Does not match");
		}

		[Test]
		public void Grid_Row_4_Coordinates_Match()
		{
			// then
			CollectionAssert.AreEquivalent(new List<Point>() { new Point(0, 4), new Point(0, 5), new Point(1, 5) }, _grid.Grid[4][0].Vertices, "Row 4, Col 0 Does not match");
			CollectionAssert.AreEquivalent(new List<Point>() { new Point(0, 4), new Point(1, 4), new Point(1, 5) }, _grid.Grid[4][1].Vertices, "Row 4, Col 1 Does not match");
			CollectionAssert.AreEquivalent(new List<Point>() { new Point(1, 4), new Point(2, 5), new Point(1, 5) }, _grid.Grid[4][2].Vertices, "Row 4, Col 2 Does not match");
			CollectionAssert.AreEquivalent(new List<Point>() { new Point(1, 4), new Point(2, 4), new Point(2, 5) }, _grid.Grid[4][3].Vertices, "Row 4, Col 3 Does not match");
			CollectionAssert.AreEquivalent(new List<Point>() { new Point(2, 4), new Point(2, 5), new Point(3, 5) }, _grid.Grid[4][4].Vertices, "Row 4, Col 4 Does not match");
			CollectionAssert.AreEquivalent(new List<Point>() { new Point(2, 4), new Point(3, 4), new Point(3, 5) }, _grid.Grid[4][5].Vertices, "Row 4, Col 5 Does not match");
			CollectionAssert.AreEquivalent(new List<Point>() { new Point(3, 4), new Point(3, 5), new Point(4, 5) }, _grid.Grid[4][6].Vertices, "Row 4, Col 6 Does not match");
			CollectionAssert.AreEquivalent(new List<Point>() { new Point(3, 4), new Point(4, 4), new Point(4, 5) }, _grid.Grid[4][7].Vertices, "Row 4, Col 7 Does not match");
			CollectionAssert.AreEquivalent(new List<Point>() { new Point(4, 4), new Point(4, 5), new Point(5, 5) }, _grid.Grid[4][8].Vertices, "Row 4, Col 8 Does not match");
			CollectionAssert.AreEquivalent(new List<Point>() { new Point(4, 4), new Point(5, 4), new Point(5, 5) }, _grid.Grid[4][9].Vertices, "Row 4, Col 9 Does not match");
			CollectionAssert.AreEquivalent(new List<Point>() { new Point(5, 4), new Point(5, 5), new Point(6, 5) }, _grid.Grid[4][10].Vertices, "Row 4, Col 10 Does not match");
			CollectionAssert.AreEquivalent(new List<Point>() { new Point(5, 4), new Point(6, 4), new Point(6, 5) }, _grid.Grid[4][11].Vertices, "Row 4, Col 11 Does not match");
		}

		[Test]
		public void Grid_Row_5_Coordinates_Match()
		{
			// then
			CollectionAssert.AreEquivalent(new List<Point>() { new Point(0, 5), new Point(0, 6), new Point(1, 6) }, _grid.Grid[5][0].Vertices, "Row 5, Col 0 Does not match");
			CollectionAssert.AreEquivalent(new List<Point>() { new Point(0, 5), new Point(1, 5), new Point(1, 6) }, _grid.Grid[5][1].Vertices, "Row 5, Col 1 Does not match");
			CollectionAssert.AreEquivalent(new List<Point>() { new Point(1, 5), new Point(2, 6), new Point(1, 6) }, _grid.Grid[5][2].Vertices, "Row 5, Col 2 Does not match");
			CollectionAssert.AreEquivalent(new List<Point>() { new Point(1, 5), new Point(2, 5), new Point(2, 6) }, _grid.Grid[5][3].Vertices, "Row 5, Col 3 Does not match");
			CollectionAssert.AreEquivalent(new List<Point>() { new Point(2, 5), new Point(2, 6), new Point(3, 6) }, _grid.Grid[5][4].Vertices, "Row 5, Col 4 Does not match");
			CollectionAssert.AreEquivalent(new List<Point>() { new Point(2, 5), new Point(3, 5), new Point(3, 6) }, _grid.Grid[5][5].Vertices, "Row 5, Col 5 Does not match");
			CollectionAssert.AreEquivalent(new List<Point>() { new Point(3, 5), new Point(3, 6), new Point(4, 6) }, _grid.Grid[5][6].Vertices, "Row 5, Col 6 Does not match");
			CollectionAssert.AreEquivalent(new List<Point>() { new Point(3, 5), new Point(4, 5), new Point(4, 6) }, _grid.Grid[5][7].Vertices, "Row 5, Col 7 Does not match");
			CollectionAssert.AreEquivalent(new List<Point>() { new Point(4, 5), new Point(4, 6), new Point(5, 6) }, _grid.Grid[5][8].Vertices, "Row 5, Col 8 Does not match");
			CollectionAssert.AreEquivalent(new List<Point>() { new Point(4, 5), new Point(5, 5), new Point(5, 6) }, _grid.Grid[5][9].Vertices, "Row 5, Col 9 Does not match");
			CollectionAssert.AreEquivalent(new List<Point>() { new Point(5, 5), new Point(5, 6), new Point(6, 6) }, _grid.Grid[5][10].Vertices, "Row 5, Col 10 Does not match");
			CollectionAssert.AreEquivalent(new List<Point>() { new Point(5, 5), new Point(6, 5), new Point(6, 6) }, _grid.Grid[5][11].Vertices, "Row 5, Col 11 Does not match");
		}

		[Test]
		public void Grid_Row_0_Labels_Match()
		{
			// then
            Assert.AreEqual("A1", _grid.Grid[0][0].Label, "Row 0, Col 0 Does not match");
            Assert.AreEqual("A2", _grid.Grid[0][1].Label, "Row 0, Col 1 Does not match");
			Assert.AreEqual("A3", _grid.Grid[0][2].Label, "Row 0, Col 2 Does not match");
			Assert.AreEqual("A4", _grid.Grid[0][3].Label, "Row 0, Col 3 Does not match");
			Assert.AreEqual("A5", _grid.Grid[0][4].Label, "Row 0, Col 4 Does not match");
			Assert.AreEqual("A6", _grid.Grid[0][5].Label, "Row 0, Col 5 Does not match");
			Assert.AreEqual("A7", _grid.Grid[0][6].Label, "Row 0, Col 6 Does not match");
			Assert.AreEqual("A8", _grid.Grid[0][7].Label, "Row 0, Col 7 Does not match");
			Assert.AreEqual("A9", _grid.Grid[0][8].Label, "Row 0, Col 8 Does not match");
			Assert.AreEqual("A10", _grid.Grid[0][9].Label, "Row 0, Col 9 Does not match");
			Assert.AreEqual("A11", _grid.Grid[0][10].Label, "Row 0, Col 10 Does not match");
			Assert.AreEqual("A12", _grid.Grid[0][11].Label, "Row 0, Col 11 Does not match");
		}

		[Test]
		public void Grid_Row_1_Labels_Match()
		{
			// then
			Assert.AreEqual("B1", _grid.Grid[1][0].Label, "Row 1, Col 0 Does not match");
			Assert.AreEqual("B2", _grid.Grid[1][1].Label, "Row 1, Col 1 Does not match");
			Assert.AreEqual("B3", _grid.Grid[1][2].Label, "Row 1, Col 2 Does not match");
			Assert.AreEqual("B4", _grid.Grid[1][3].Label, "Row 1, Col 3 Does not match");
			Assert.AreEqual("B5", _grid.Grid[1][4].Label, "Row 1, Col 4 Does not match");
			Assert.AreEqual("B6", _grid.Grid[1][5].Label, "Row 1, Col 5 Does not match");
			Assert.AreEqual("B7", _grid.Grid[1][6].Label, "Row 1, Col 6 Does not match");
			Assert.AreEqual("B8", _grid.Grid[1][7].Label, "Row 1, Col 7 Does not match");
			Assert.AreEqual("B9", _grid.Grid[1][8].Label, "Row 1, Col 8 Does not match");
			Assert.AreEqual("B10", _grid.Grid[1][9].Label, "Row 1, Col 9 Does not match");
			Assert.AreEqual("B11", _grid.Grid[1][10].Label, "Row 1, Col 10 Does not match");
			Assert.AreEqual("B12", _grid.Grid[1][11].Label, "Row 1, Col 11 Does not match");
		}

		[Test]
		public void Grid_Row_2_Labels_Match()
		{
			// then
			Assert.AreEqual("C1", _grid.Grid[2][0].Label, "Row 2, Col 0 Does not match");
			Assert.AreEqual("C2", _grid.Grid[2][1].Label, "Row 2, Col 1 Does not match");
			Assert.AreEqual("C3", _grid.Grid[2][2].Label, "Row 2, Col 2 Does not match");
			Assert.AreEqual("C4", _grid.Grid[2][3].Label, "Row 2, Col 3 Does not match");
			Assert.AreEqual("C5", _grid.Grid[2][4].Label, "Row 2, Col 4 Does not match");
			Assert.AreEqual("C6", _grid.Grid[2][5].Label, "Row 2, Col 5 Does not match");
			Assert.AreEqual("C7", _grid.Grid[2][6].Label, "Row 2, Col 6 Does not match");
			Assert.AreEqual("C8", _grid.Grid[2][7].Label, "Row 2, Col 7 Does not match");
			Assert.AreEqual("C9", _grid.Grid[2][8].Label, "Row 2, Col 8 Does not match");
			Assert.AreEqual("C10", _grid.Grid[2][9].Label, "Row 2, Col 9 Does not match");
			Assert.AreEqual("C11", _grid.Grid[2][10].Label, "Row 2, Col 10 Does not match");
			Assert.AreEqual("C12", _grid.Grid[2][11].Label, "Row 2, Col 11 Does not match");
		}

		[Test]
		public void Grid_Row_3_Labels_Match()
		{
			// then
			Assert.AreEqual("D1", _grid.Grid[3][0].Label, "Row 3, Col 0 Does not match");
			Assert.AreEqual("D2", _grid.Grid[3][1].Label, "Row 3, Col 1 Does not match");
			Assert.AreEqual("D3", _grid.Grid[3][2].Label, "Row 3, Col 2 Does not match");
			Assert.AreEqual("D4", _grid.Grid[3][3].Label, "Row 3, Col 3 Does not match");
			Assert.AreEqual("D5", _grid.Grid[3][4].Label, "Row 3, Col 4 Does not match");
			Assert.AreEqual("D6", _grid.Grid[3][5].Label, "Row 3, Col 5 Does not match");
			Assert.AreEqual("D7", _grid.Grid[3][6].Label, "Row 3, Col 6 Does not match");
			Assert.AreEqual("D8", _grid.Grid[3][7].Label, "Row 3, Col 7 Does not match");
			Assert.AreEqual("D9", _grid.Grid[3][8].Label, "Row 3, Col 8 Does not match");
			Assert.AreEqual("D10", _grid.Grid[3][9].Label, "Row 3, Col 9 Does not match");
			Assert.AreEqual("D11", _grid.Grid[3][10].Label, "Row 3, Col 10 Does not match");
			Assert.AreEqual("D12", _grid.Grid[3][11].Label, "Row 3, Col 11 Does not match");
		}

		[Test]
		public void Grid_Row_4_Labels_Match()
		{
			// then
			Assert.AreEqual("E1", _grid.Grid[4][0].Label, "Row 4, Col 0 Does not match");
			Assert.AreEqual("E2", _grid.Grid[4][1].Label, "Row 4, Col 1 Does not match");
			Assert.AreEqual("E3", _grid.Grid[4][2].Label, "Row 4, Col 2 Does not match");
			Assert.AreEqual("E4", _grid.Grid[4][3].Label, "Row 4, Col 3 Does not match");
			Assert.AreEqual("E5", _grid.Grid[4][4].Label, "Row 4, Col 4 Does not match");
			Assert.AreEqual("E6", _grid.Grid[4][5].Label, "Row 4, Col 5 Does not match");
			Assert.AreEqual("E7", _grid.Grid[4][6].Label, "Row 4, Col 6 Does not match");
			Assert.AreEqual("E8", _grid.Grid[4][7].Label, "Row 4, Col 7 Does not match");
			Assert.AreEqual("E9", _grid.Grid[4][8].Label, "Row 4, Col 8 Does not match");
			Assert.AreEqual("E10", _grid.Grid[4][9].Label, "Row 4, Col 9 Does not match");
			Assert.AreEqual("E11", _grid.Grid[4][10].Label, "Row 4, Col 10 Does not match");
			Assert.AreEqual("E12", _grid.Grid[4][11].Label, "Row 4, Col 11 Does not match");
		}

		[Test]
		public void Grid_Row_5_Labels_Match()
		{
			// then
			Assert.AreEqual("F1", _grid.Grid[5][0].Label, "Row 5, Col 0 Does not match");
			Assert.AreEqual("F2", _grid.Grid[5][1].Label, "Row 5, Col 1 Does not match");
			Assert.AreEqual("F3", _grid.Grid[5][2].Label, "Row 5, Col 2 Does not match");
			Assert.AreEqual("F4", _grid.Grid[5][3].Label, "Row 5, Col 3 Does not match");
			Assert.AreEqual("F5", _grid.Grid[5][4].Label, "Row 5, Col 4 Does not match");
			Assert.AreEqual("F6", _grid.Grid[5][5].Label, "Row 5, Col 5 Does not match");
			Assert.AreEqual("F7", _grid.Grid[5][6].Label, "Row 5, Col 6 Does not match");
			Assert.AreEqual("F8", _grid.Grid[5][7].Label, "Row 5, Col 7 Does not match");
			Assert.AreEqual("F9", _grid.Grid[5][8].Label, "Row 5, Col 8 Does not match");
			Assert.AreEqual("F10", _grid.Grid[5][9].Label, "Row 5, Col 9 Does not match");
			Assert.AreEqual("F11", _grid.Grid[5][10].Label, "Row 5, Col 10 Does not match");
			Assert.AreEqual("F12", _grid.Grid[5][11].Label, "Row 5, Col 11 Does not match");
		}

        [Test]
        public void Grid_Find_Triangle_At_Coordinates_For_A3()
        {
            // given
            var v1 = new Point(1, 1);
            var v2 = new Point(1, 0);
            var v3 = new Point(2, 1);

            // when
            var t = _grid.FindAt(v1, v2, v3);

            // then
            Assert.IsNotNull(t);
            Assert.AreEqual("A3", t.Label, "Did not find A3 triangle");
        }

		[Test]
		public void Grid_Find_Triangle_At_Coordinates_For_F7()
		{
            // given
            var v1 = new Point(3, 5);
            var v2 = new Point(3, 6);
            var v3 = new Point(4, 6);

			// when
			var t = _grid.FindAt(v1, v2, v3);

			// then
			Assert.IsNotNull(t);
			Assert.AreEqual("F7", t.Label, "Did not find F7 triangle");
		}

        [Test]
        public void Grid_Find_Fails_When_Bad_Coordinates_Provided()
        {
			// given
			var v1 = new Point(52, 3);
			var v2 = new Point(44, 3);
			var v3 = new Point(6, 54);

			// when
			var t = _grid.FindAt(v1, v2, v3);

			// then
            Assert.IsNull(t);
        }

        [Test]
        public void Grid_Find_Fails_When_Same_Coordinates_Provided()
        {
			// given
			var v1 = new Point(0, 0);
			var v2 = new Point(0, 0);
			var v3 = new Point(0, 0);

			// when
			var t = _grid.FindAt(v1, v2, v3);

			// then
			Assert.IsNull(t);
        }
    }
}
