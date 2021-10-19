using System;
using System.Collections.Generic;
using System.Text;
using FitnessCenter;
using Xunit;
using Xunit.Abstractions;

namespace unit_test
{
    public class TestControllerAntrenori
    {
        private ControllerAntrenori control;

        private readonly ITestOutputHelper output;

        public TestControllerAntrenori(ITestOutputHelper output)
        {
            control = new ControllerAntrenori();

            this.output = output;
        }

        [Fact]

        public void testPozitie()
        {


            control.load();

            Assert.Equal(0, control.pozitie(1));

            output.WriteLine("a");





        }
        [Fact]
        public void testPozitie1()
        {

            control.load();

            control.delete(2);

            Assert.Equal(1, control.pozitie(3));

            output.WriteLine("a");



        }
        [Fact]
        public void testPozitie2()
        {
            control.load();

            Antrenor antrenornou= new Antrenor(10,"numeantrenor", 028319213,"emailantrenor", "adresaantrenor","usernameantrenor","parolaantrenor");

            control.add(antrenornou);
            control.Save();
            control.load();

            Assert.Equal(3, control.pozitie(10));

        }
        [Fact]
        public void testUpdate()
        {
            control.load();

            control.updateNume(2, "Robert");

            Assert.Equal("Robert", control.antrenor(2).getNumeantrenor());

        }

    }
}
