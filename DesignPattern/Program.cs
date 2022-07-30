using System;

namespace DesignPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            var shap1 = ShapeFactory.GetShape(ShapeType.Cricle);
            shap1.Draw();

            var shap2 = ShapeFactory.GetShape(ShapeType.Recrangle);
            shap2.Draw();

            var shap3 = ShapeFactory.GetShape(ShapeType.Square);
            shap3.Draw();

            Console.ReadKey();
        }
    }
}