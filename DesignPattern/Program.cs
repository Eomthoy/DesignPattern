using System;

namespace DesignPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            var shapeFactory = FactoryProducer.GetFactory(AbstractFactoryType.Shape);
            shapeFactory.GetShape(ShapeType.Cricle).Draw();
            shapeFactory.GetShape(ShapeType.Rectangle).Draw();
            shapeFactory.GetShape(ShapeType.Square).Draw();

            var colorFactory = FactoryProducer.GetFactory(AbstractFactoryType.Color);
            colorFactory.GetColor(ColorType.Red).Fill();
            colorFactory.GetColor(ColorType.Blue).Fill();
            colorFactory.GetColor(ColorType.Green).Fill();

            Console.ReadKey();
        }
    }
}