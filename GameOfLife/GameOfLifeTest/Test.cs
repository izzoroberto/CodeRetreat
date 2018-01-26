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
            var matrix = Mother.CreateMatrix3x3();
            Cell sut = new Cell().StartLife(); 
            matrix[1][0] = sut.SetPosition(1, 0);
            matrix[0][0] = new Cell().SetPosition(0, 0);//top
            matrix[0][1] = new Cell().SetPosition(0, 1);//diagonal up left
            matrix[1][1] = new Cell().StartLife().SetPosition(1,1);//left
            matrix[2][1] = new Cell().SetPosition(2,1);//diagonal down left
            matrix[2][0] = new Cell().SetPosition(2,0);//bottom
            sut.ControllaVicini(matrix);
            var res = sut.Update();
            Assert.True(!res.IsLive);
        }

        [Fact]
        public void Secellavivaconpiuditrevicinivivisaramorta()
        {
            Cell sut = new Cell();
            //sut.IsLive = true;
            //sut.viciniVivi = 4;
            var res = sut.Update();
            Assert.True(!res.IsLive);
        }

        [Fact]
        public void Secellamortacontrevicinivivisaraviva()
        {
            Cell sut = new Cell();
            //sut.IsLive = false;
            //sut.viciniVivi = 3;
            var res = sut.Update();
            Assert.True(res.IsLive);
        }

        [Fact]
        public void Secellviavacon3celleviverimaneviva()
        {
            Cell sut = new Cell();
            //sut.IsLive = true;
            //sut.viciniVivi = 3;
            var res = sut.Update();
            Assert.True(res.IsLive);
        }

        [Fact]
        public void Secellviavacon2celleviverimaneviva()
        {
            var matrix = Mother.CreateMatrix3x3();
            Cell sut = new Cell().StartLife();
            matrix[1][1] = sut.SetPosition(1, 1);

            matrix[0][0] = new Cell().SetPosition(0, 0);//diagonal up right
            matrix[0][1] = new Cell().SetPosition(0,1);// top
            matrix[0][2] = new Cell().SetPosition(0,2);//diagonal up left
            matrix[1][0] = new Cell().StartLife().SetPosition(1, 0);//right
            matrix[1][2] = new Cell().StartLife().SetPosition(1, 2);// left
            matrix[2][0] = new Cell().SetPosition(2, 0);//diagonal up right
            matrix[2][1] = new Cell().SetPosition(2,1);//bottom
            matrix[2][2] = new Cell().SetPosition(2,2);//diagonal bottom left
            sut.ControllaVicini(matrix);
            var res = sut.Update();
            Assert.True(res.IsLive);
        }
    }

   
}
