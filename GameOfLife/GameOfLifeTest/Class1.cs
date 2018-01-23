using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GameOfLife;
using Xunit;

namespace GameOfLifeTest
{
   public class Class1
    {
        [Fact]
        public void SecellaviavaritornaTrue()
        {
           Cell cell = new Cell();
           cell.IsLive = true;
           Assert.True(cell.IsLive);
        }

        [Fact]
        public void Secellavivaconmenodiduevicinivivisaramorta()
        {
            Cell cell = new Cell();
            cell.IsLive = true;
            cell.viciniVivi = 1;
            cell.update();
            Assert.True(!cell.IsLive);
        }

        [Fact]
        public void Secellavivaconpiuditrevicinivivisaramorta()
        {
            Cell cell = new Cell();
            cell.IsLive = true;
            cell.viciniVivi = 4;
            cell.update();
            Assert.True(!cell.IsLive);
        }

        [Fact]
        public void Secellamortacontrevicinivivisaraviva()
        {
            Cell cell = new Cell();
            cell.IsLive = false;
            cell.viciniVivi = 3;
            cell.update();
            Assert.True(cell.IsLive);
        }

        [Fact]
        public void Secellviavacon3celleviverimaneviva()
        {
            Cell cell = new Cell();
            cell.IsLive = true;
            cell.viciniVivi = 3;
            cell.update();
            Assert.True(cell.IsLive);
        }

        [Fact]
        public void Secellviavacon2celleviverimaneviva()
        {
            Cell cell = new Cell();
            cell.IsLive = true;
            cell.viciniVivi = 3;
            cell.update();
            Assert.True(cell.IsLive);
        }
    }

   
}
