using GameOfLife.Cl;
using System;
using Xunit;

namespace UnitTests
{
    public class GOLTests
    {
        [Fact]
        public void Update_CellLonelyLessThan2_False()
        {
            GOL gol = new GOL(3, 3);
            gol.SetCell(1, 1, true);
            gol.SetCell(1, 2, true);

            gol.Update();

            Assert.False(gol.GetCell(1, 1));
        }

        [Fact]
        public void Update_CellAliveEqual2Or3_True()
        {
            GOL gol = new GOL(3, 3);
            gol.SetCell(1, 1, true);
            gol.SetCell(1, 2, true);
            gol.SetCell(2, 2, true);

            gol.Update();

            Assert.True(gol.GetCell(1, 1));
        }

        [Fact]
        public void Update_CellBornEqual3_True()
        {
            GOL gol = new GOL(3, 3);
            gol.SetCell(1, 1, false);
            gol.SetCell(1, 2, true);
            gol.SetCell(2, 2, true);
            gol.SetCell(0, 2, true);

            gol.Update();

            Assert.True(gol.GetCell(1, 1));
        }

        [Fact]
        public void Update_CellOverPopulatedGreaterThan3_False()
        {
            GOL gol = new GOL(3, 3);
            gol.SetCell(1, 1, true);
            gol.SetCell(1, 2, true);
            gol.SetCell(2, 2, true);
            gol.SetCell(0, 2, true);
            gol.SetCell(0, 1, true);

            gol.Update();

            Assert.False(gol.GetCell(1, 1));
        }

        [Fact]
        public void GetCell_CoordinateOutOfBounds_False()
        {
            GOL gol = new GOL(1,1);
            gol.SetCell(1, 1, true);

            Assert.False(gol.GetCell(5, 5));
        }

        [Fact]
        public void GetCell_CoordinateNegative_False()
        {
            GOL gol = new GOL(1, 1);
            gol.SetCell(1, 1, true);

            Assert.False(gol.GetCell(-5, -5));
        }

    }
}
