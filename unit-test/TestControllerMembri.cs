using System;
using System.Collections.Generic;
using System.Text;
using FitnessCenter;
using Xunit;
using Xunit.Abstractions;

namespace unit_test
{
    public class TestControllerMembri
    {
        private ControllerMembri control;

        private readonly ITestOutputHelper output;

        public TestControllerMembri(ITestOutputHelper output)
        {
            control = new ControllerMembri();

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

            Membru membru = new Membru(10, "numemembrunou", 28139132, "emailmembrunou", "adresamemebrunou", "usernamemembrunou", "parolausernou");

            control.add(membru);
            control.Save();
            control.load();

            Assert.Equal(4, control.pozitie(10));

        }
        [Fact]
        public void testUpdate()
        {
            control.load();

            control.updateNume(2, "Robert");

            Assert.Equal("Robert", control.membru(2).getNumemembru());

        }
        [Fact]
        public void testUpdate1()
        {
            control.load();

            control.updateEmail(2, "emailmembruupdate");

            Assert.Equal("emailmembruupdate", control.membru(2).getEmail());

        }
        [Fact]
        public void testUpdate2()
        {
            control.load();

            control.updateAdrsa(2, "updateadresanoua");

            Assert.Equal("updateadresanoua", control.membru(2).getAdresa());

        }

    }
}

