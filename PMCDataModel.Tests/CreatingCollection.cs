using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace PMCDataModel.Tests
{
    [TestClass]
    public class CreatingCollection
    {

        [TestMethod]
        public void CreatePosition()
        {
            DataCreator<int, IPoint<int>> dataCreator = new PositionCreator<int, IPoint<int>>();
            var position = dataCreator.Create();
            var expectedPosition = new Position<IPoint<int>>();

            var expectedType = expectedPosition.GetType();
            var realType = position.GetType();
            Assert.AreEqual(expectedType, realType);
        }

        [TestMethod]
        public void CreateMatrix()
        {
            DataCreator<int, Position<IPoint<int>>> dataCreator = new MatrixCreator<int, Position<IPoint<int>>>();
            var matrix = dataCreator.Create();
            var expectedMatrix = new Matrix<Position<IPoint<int>>>();

            var expectedType = expectedMatrix.GetType();
            var realType = matrix.GetType();
            Assert.AreEqual(expectedType, realType);
        }

        [TestMethod]
        public void CreateContainer()
        {
            DataCreator<int, Matrix<Position<IPoint<int>>>> dataCreator = new ContainerCreator<int, Matrix<Position<IPoint<int>>>>();
            var container = dataCreator.Create();
            var expectedContainer = new Container<Matrix<Position<IPoint<int>>>>();

            var expectedType = expectedContainer.GetType();
            var realType = container.GetType();
            Assert.AreEqual(expectedType, realType);
        }

        [TestMethod]
        public void CreateContainerCollection()
        {
            DataCreator<int, Container<Matrix<Position<IPoint<int>>>>> dataCreator = new ContainerCollectionCreator<int, Container<Matrix<Position<IPoint<int>>>>>();
            var containerCollection = dataCreator.Create();
            var expectedContainerCollection = new ContainerCollection<Container<Matrix<Position<IPoint<int>>>>>();

            var expectedType = expectedContainerCollection.GetType();
            var realType = containerCollection.GetType();
            Assert.AreEqual(expectedType, realType);
        }
    }
}
