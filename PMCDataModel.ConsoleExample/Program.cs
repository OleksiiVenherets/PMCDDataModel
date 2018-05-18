using System;

namespace PMCDataModel.ConsoleExample
{
    class Program
    {
        static void Main(string[] args)
        {
            var containerCollection = CreateContainerCollections();
            PrintResult(containerCollection);
            Console.ReadKey();
        }

        public static IDataCollection<Container<Matrix<Position<IPoint<int>>>>> CreateContainerCollections()
        {
            var positionCreator = new PositionCreator<int, IPoint<int>>();
            var firstPosition = positionCreator.Create();
            var secondPosition = positionCreator.Create();
            var thirdPosition = positionCreator.Create();
            var fourthPosition = positionCreator.Create();
            var fifthPosition = positionCreator.Create();
            for (var i = 0; i < 10; i++)
            {
                firstPosition.Add(new Point3D<int>(i, i, i));
                secondPosition.Add(new Point3D<int>(i, i, i));
                thirdPosition.Add(new Point3D<int>(i, i, i));
                fourthPosition.Add(new Point3D<int>(i, i, i));
                fifthPosition.Add(new Point3D<int>(i, i, i));
            }

            var matrixCreator = new MatrixCreator<int, Position<IPoint<int>>>();
            var firstMatrix = matrixCreator.Create();
            var secondMatrix = matrixCreator.Create();
            var thirdMatrix = matrixCreator.Create();

            firstMatrix.Add((Position<IPoint<int>>)firstPosition);
            firstMatrix.Add((Position<IPoint<int>>)secondPosition);
            firstMatrix.Add((Position<IPoint<int>>)thirdPosition);

            secondMatrix.Add((Position<IPoint<int>>)fifthPosition);
            secondMatrix.Add((Position<IPoint<int>>)fourthPosition);
            secondMatrix.Add((Position<IPoint<int>>)thirdPosition);

            thirdMatrix.Add((Position<IPoint<int>>)secondPosition);
            thirdMatrix.Add((Position<IPoint<int>>)fourthPosition);
            thirdMatrix.Add((Position<IPoint<int>>)thirdPosition);

            var containerCreator = new ContainerCreator<int, Matrix<Position<IPoint<int>>>>();
            var container = containerCreator.Create();
            container.Add((Matrix<Position<IPoint<int>>>)firstMatrix);
            container.Add((Matrix<Position<IPoint<int>>>)secondMatrix);
            container.Add((Matrix<Position<IPoint<int>>>)thirdMatrix);

            var containerColectionCreator = new ContainerCollectionCreator<int, Container<Matrix<Position<IPoint<int>>>>>();
            var containerCollection = containerColectionCreator.Create();
            containerCollection.Add((Container<Matrix<Position<IPoint<int>>>>)container);
            return containerCollection;
        }

        public static void PrintResult(IDataCollection<Container<Matrix<Position<IPoint<int>>>>> containerCollection)
        {
            foreach (var containerItem in containerCollection)
            {
                Console.WriteLine("Container");
                foreach (var matrix in containerItem)
                {
                    Console.WriteLine("Matrix");
                    foreach (var position in matrix)
                    {
                        Console.WriteLine("Position");
                        foreach (var point in position)
                        {
                            Console.Write(point.ToString() + "\t");
                        }
                        Console.WriteLine();
                    }
                }
            }
        }
    }
}
