using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using FitnessCenter;
using Xunit.Abstractions;

namespace unit_test
{

    public class TestControllerFitness
    {
        private ControllerFitness control;

        private readonly ITestOutputHelper output;

        public TestControllerFitness(ITestOutputHelper output)
        {
            control = new ControllerFitness();

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

        Fitness clasafitness = new Fitness(10,"descriereclasa","tipclasa", "numeclasa");

        control.add(clasafitness);
        control.Save();
        control.load();

        Assert.Equal(3, control.pozitie(10));

    }
    [Fact]
    public void testUpdate()
    {
        control.load();

        control.updateNume(2, "updatenume");

        Assert.Equal("updatenume", control.fitnesss(2).getNume());

    }

}
}
