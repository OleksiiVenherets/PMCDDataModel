using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace PMCDataModel.Tests
{
    [TestClass]
    public class AddingItemToCollection
    {
        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void AddNullToPositionExpectedException()
        {
            DataCreator<int, IPoint<int>> dataCreator = new PositionCreator<int, IPoint<int>>();
            var position = dataCreator.Create();
            position.Add(null);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void AddNullToMatrixExpectedException()
        {
            DataCreator<int, Position<IPoint<int>>> dataCreator = new MatrixCreator<int, Position<IPoint<int>>>();
            var matrix = dataCreator.Create();
            matrix.Add(null);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void AddNullToContainerExpectedException()
        {
            DataCreator<int, Matrix<Position<IPoint<int>>>> dataCreator = new ContainerCreator<int, Matrix<Position<IPoint<int>>>>();
            var container = dataCreator.Create();
            container.Add(null);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void AddNullToContainerCollectionExpectedException()
        {
            DataCreator<int, Container<Matrix<Position<IPoint<int>>>>> dataCreator = new ContainerCollectionCreator<int, Container<Matrix<Position<IPoint<int>>>>>();
            var containerCollection = dataCreator.Create();
            containerCollection.Add(null);
        }
    }
}
