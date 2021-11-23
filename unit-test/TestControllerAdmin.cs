using FitnessCenter;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using Xunit.Abstractions;

namespace unit_test
{
    public class TestControllerAdmin
    {

        private ControllerAdmin control;

        private readonly ITestOutputHelper output;

        public TestControllerAdmin(ITestOutputHelper output)
        {
            control = new ControllerAdmin();

            this.output = output;
        }

        [Fact]
        public void testPozitie()
        {
            control.load();

            Assert.Equal(0, control.pozitiedupaid(1));
        }
        [Fact]
        public void testUpdate()
        {
            control.load();

            control.updateNume(1, "adminnou");

            Assert.Equal("adminnou", control.admin(1).getNumeAdmin());
        }
        [Fact]
        public void testDelete()
        {
            control.load();
            control.delete(1);
            Assert.Equal(0, control.pozitiedupaid(2));

        }
        [Fact]
        public void testAdd()
        {
            control.load();

            Admin a = new Admin(3, "addadmin", 21382, "addadminusername", "addparola", true);

            control.add(a);

            Assert.Equal(3, control.admin(3).getIdAdmin());

        }
    }
}
