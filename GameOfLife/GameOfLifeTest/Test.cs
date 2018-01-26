using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GameOfLife;
using Xunit;

namespace GameOfLifeTest
{
    public class Test
    {

        [Fact]
        public void SecellaviavaritornaTrue()
        {
            Cell sut = new Cell().StartLife();
            Assert.True(sut.IsLive);
        }

        [Fact]
        public void Secellavivaconmenodiduevicinivivisaramorta()
        {
            //ARRANGE
            var matrix = Mother.CreateMatrix3x3();
            Cell sut = new Cell().StartLife();
            matrix[1][0] = sut.SetPosition(1, 0);

            matrix[0][0] = new Cell().SetPosition(0, 0);//top
            matrix[0][1] = new Cell().SetPosition(0, 1);//diagonal up left
            matrix[1][1] = new Cell().StartLife().SetPosition(1, 1);//left
            matrix[2][1] = new Cell().SetPosition(2, 1);//diagonal down left
            matrix[2][0] = new Cell().SetPosition(2, 0);//bottom
            sut.ControllaViciniVivi(matrix);

            //ACT
            var res = sut.Update();

            //ASSERT
            Assert.True(!res.IsLive);
        }

        //[Fact]
        //public void Secellavivaconpiuditrevicinivivisaramorta()
        //{
        //    Cell sut = new Cell();
        //    //sut.IsLive = true;
        //    //sut.viciniVivi = 4;
        //    var res = sut.Update();
        //    Assert.True(!res.IsLive);
        //}

        //[Fact]
        //public void Secellamortacontrevicinivivisaraviva()
        //{
        //    Cell sut = new Cell();
        //    //sut.IsLive = false;
        //    //sut.viciniVivi = 3;
        //    var res = sut.Update();
        //    Assert.True(res.IsLive);
        //}

        //[Fact]
        //public void Secellviavacon3celleviverimaneviva()
        //{
        //    Cell sut = new Cell();
        //    //sut.IsLive = true;
        //    //sut.viciniVivi = 3;
        //    var res = sut.Update();
        //    Assert.True(res.IsLive);
        //}

        [Fact]
        public void Secellviavacon2celleviverimaneviva()
        {
            //ARRANGE
            var matrix = Mother.CreateMatrix3x3();
            Cell sut = new Cell().StartLife();
            matrix[1][1] = sut.SetPosition(1, 1);
            matrix[0][0] = new Cell().SetPosition(0, 0);//diagonal up right
            matrix[0][1] = new Cell().SetPosition(0, 1);// top
            matrix[0][2] = new Cell().SetPosition(0, 2);//diagonal up left
            matrix[1][0] = new Cell().StartLife().SetPosition(1, 0);//right
            matrix[1][2] = new Cell().StartLife().SetPosition(1, 2);// left
            matrix[2][0] = new Cell().SetPosition(2, 0);//diagonal up right
            matrix[2][1] = new Cell().SetPosition(2, 1);//bottom
            matrix[2][2] = new Cell().SetPosition(2, 2);//diagonal bottom left
            sut.ControllaViciniVivi(matrix);

            //ACT
            var res = sut.Update();

            //ASSERT
            Assert.True(res.IsLive);
        }


        [Fact]
        public void TestVertical_ReturnOrizontal()
        {
            //ARRANGE
            var matrix = Mother.CreateMatrix3x3();

            //create cell and populate world
            matrix[0][0] = new Cell().SetPosition(0, 0);
            matrix[0][1] = new Cell().SetPosition(0, 1);
            matrix[0][2] = new Cell().SetPosition(0, 2);
            matrix[1][0] = new Cell().StartLife().SetPosition(1, 0);
            matrix[1][1] = new Cell().StartLife().SetPosition(1, 1);
            matrix[1][2] = new Cell().StartLife().SetPosition(1, 2);
            matrix[2][0] = new Cell().SetPosition(2, 0);
            matrix[2][1] = new Cell().SetPosition(2, 1);
            matrix[2][2] = new Cell().SetPosition(2, 2);

            //T
            for (int i = 0; i < matrix.Length; i++)
            {
                for (int j = 0; j < matrix[i].Length; j++)
                {
                    matrix[i][j].ControllaViciniVivi(matrix);
                }
            }

            //T+1
            for (int i = 0; i < matrix.Length; i++)
            {
                for (int j = 0; j < matrix[i].Length; j++)
                {
                    matrix[i][j] = matrix[i][j].Update();
                }
            }

            //ASSERT
            Assert.True(matrix[0][1].IsLive);
            Assert.True(matrix[1][1].IsLive);
            Assert.True(matrix[2][1].IsLive);

        }

        [Fact]
        public void TestOrizontal_ReturnVertical()
        {
            //ARRANGE
            var matrix = Mother.CreateMatrix3x3();

            //create cell and populate world
            matrix[0][0] = new Cell().SetPosition(0, 0);
            matrix[0][1] = new Cell().StartLife().SetPosition(0, 1);
            matrix[0][2] = new Cell().SetPosition(0, 2);
            matrix[1][0] = new Cell().SetPosition(1, 0);
            matrix[1][1] = new Cell().StartLife().SetPosition(1, 1);
            matrix[1][2] = new Cell().SetPosition(1, 2);
            matrix[2][0] = new Cell().SetPosition(2, 0);
            matrix[2][1] = new Cell().StartLife().SetPosition(2, 1);
            matrix[2][2] = new Cell().SetPosition(2, 2);

            //T
            for (int i = 0; i < matrix.Length; i++)
            {
                for (int j = 0; j < matrix[i].Length; j++)
                {
                    matrix[i][j].ControllaViciniVivi(matrix);
                }
            }

            //T+1
            for (int i = 0; i < matrix.Length; i++)
            {
                for (int j = 0; j < matrix[i].Length; j++)
                {
                    matrix[i][j] = matrix[i][j].Update();
                }
            }

            //ASSERT
            Assert.True(matrix[1][0].IsLive);
            Assert.True(matrix[1][1].IsLive);
            Assert.True(matrix[1][2].IsLive);

        }
    }
}
