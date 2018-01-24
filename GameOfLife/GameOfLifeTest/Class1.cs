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
           Cell sut = new Cell();
           sut.IsLive = true;
           Assert.True(sut.IsLive);
        }

        [Fact]
        public void Secellavivaconmenodiduevicinivivisaramorta()
        {
            Cell sut = new Cell();
            sut.IsLive = true;
            sut.viciniVivi = 1;
            var res = sut.update();
            Assert.True(!res.IsLive);
        }

        [Fact]
        public void Secellavivaconpiuditrevicinivivisaramorta()
        {
            Cell sut = new Cell();
            sut.IsLive = true;
            sut.viciniVivi = 4;
            var res = sut.update();
            Assert.True(!res.IsLive);
        }

        [Fact]
        public void Secellamortacontrevicinivivisaraviva()
        {
            Cell sut = new Cell();
            sut.IsLive = false;
            sut.viciniVivi = 3;
            var res = sut.update();
            Assert.True(res.IsLive);
        }

        [Fact]
        public void Secellviavacon3celleviverimaneviva()
        {
            Cell sut = new Cell();
            sut.IsLive = true;
            sut.viciniVivi = 3;
            var res = sut.update();
            Assert.True(res.IsLive);
        }

        [Fact]
        public void Secellviavacon2celleviverimaneviva()
        {
            Cell sut = new Cell();
            sut.IsLive = true;
            sut.viciniVivi = 3;
            var res = sut.update();
            Assert.True(res.IsLive);
        }
    }

   
}
