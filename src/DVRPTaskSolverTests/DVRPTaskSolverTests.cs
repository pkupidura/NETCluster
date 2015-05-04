﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.IO;
using System.Text;
using DVRPTaskSolver;

namespace DVRPTaskSolverTests
{
    [TestClass]
    public class DVRPTaskSolverTests
    {
        [TestMethod]
        [DeploymentItem("test_of_size_1.vrp")]
        public void DivideProblemOfSize1Test()
        {
            var file = File.ReadAllText("test_of_size_1.vrp");
            var problemBytes = Encoding.UTF8.GetBytes(file);

            DVRPTaskSolver.DVRPTaskSolver dvrpTaskSolver = new DVRPTaskSolver.DVRPTaskSolver(problemBytes);

            byte[][] partialProblemsBytes = dvrpTaskSolver.DivideProblem(0);

            int[][] partialProblems = new int[partialProblemsBytes.Length][];
            for (int i = 0; i < partialProblemsBytes.Length; i++)
                partialProblems[i] = DVRPTaskSolver.DVRPLocationsSubset.GetFromByteArray(partialProblemsBytes[i]).Locations;

            int[][] expected = new int[2][];
            expected[0] = new int[0];
            expected[1] = new int[1] { 1 };

            Assert.AreEqual(expected.Length, partialProblemsBytes.Length);
            for (int i = 0; i < expected.Length; i++)
                CollectionAssert.AreEqual(expected[i], partialProblems[i]);
        }

        [TestMethod]
        [DeploymentItem("test_of_size_2.vrp")]
        public void DivideProblemOfSize2Test()
        {
            var file = File.ReadAllText("test_of_size_2.vrp");
            var problemBytes = Encoding.UTF8.GetBytes(file);

            DVRPTaskSolver.DVRPTaskSolver dvrpTaskSolver = new DVRPTaskSolver.DVRPTaskSolver(problemBytes);

            byte[][] partialProblemsBytes = dvrpTaskSolver.DivideProblem(0);

            int[][] partialProblems = new int[partialProblemsBytes.Length][];
            for (int i = 0; i < partialProblemsBytes.Length; i++)
                partialProblems[i] = DVRPTaskSolver.DVRPLocationsSubset.GetFromByteArray(partialProblemsBytes[i]).Locations;

            int[][] expected = new int[4][];
            expected[0] = new int[0];
            expected[1] = new int[1] { 1 };
            expected[2] = new int[2] { 1, 2 };
            expected[3] = new int[1] { 2 };

            Assert.AreEqual(expected.Length, partialProblemsBytes.Length);
            for (int i = 0; i < expected.Length; i++)
                CollectionAssert.AreEqual(expected[i], partialProblems[i]);
        }

        [TestMethod]
        [DeploymentItem("test_of_size_3.vrp")]
        public void DivideProblemOfSize3Test()
        {
            var file = File.ReadAllText("test_of_size_3.vrp");
            var problemBytes = Encoding.UTF8.GetBytes(file);

            DVRPTaskSolver.DVRPTaskSolver dvrpTaskSolver = new DVRPTaskSolver.DVRPTaskSolver(problemBytes);

            byte[][] partialProblemsBytes = dvrpTaskSolver.DivideProblem(0);

            int[][] partialProblems = new int[partialProblemsBytes.Length][];
            for (int i = 0; i < partialProblemsBytes.Length; i++)
                partialProblems[i] = DVRPTaskSolver.DVRPLocationsSubset.GetFromByteArray(partialProblemsBytes[i]).Locations;

            int[][] expected = new int[8][];
            expected[0] = new int[0];
            expected[1] = new int[1] { 1 };
            expected[2] = new int[2] { 1, 2 };
            expected[3] = new int[3] { 1, 2, 3 };
            expected[4] = new int[2] { 1, 3 };
            expected[5] = new int[1] { 2 };
            expected[6] = new int[2] { 2, 3 };
            expected[7] = new int[1] { 3 };

            Assert.AreEqual(expected.Length, partialProblemsBytes.Length);
            for (int i = 0; i < expected.Length; i++)
                CollectionAssert.AreEqual(expected[i], partialProblems[i]);
        }

        [TestMethod]
        [DeploymentItem("test_of_size_5.vrp")]
        public void DivideProblemOfSize5Test()
        {
            var file = File.ReadAllText("test_of_size_5.vrp");
            var problemBytes = Encoding.UTF8.GetBytes(file);

            DVRPTaskSolver.DVRPTaskSolver dvrpTaskSolver = new DVRPTaskSolver.DVRPTaskSolver(problemBytes);

            byte[][] partialProblemsBytes = dvrpTaskSolver.DivideProblem(0);

            Assert.AreEqual(32, partialProblemsBytes.Length);
        }

        [TestMethod]
        [DeploymentItem("test_of_size_15.vrp")]
        public void DivideProblemOfSize15Test()
        {
            var file = File.ReadAllText("test_of_size_15.vrp");
            var problemBytes = Encoding.UTF8.GetBytes(file);

            DVRPTaskSolver.DVRPTaskSolver dvrpTaskSolver = new DVRPTaskSolver.DVRPTaskSolver(problemBytes);

            byte[][] partialProblemsBytes = dvrpTaskSolver.DivideProblem(0);

            Assert.AreEqual(32768, partialProblemsBytes.Length);
        }
    }
}