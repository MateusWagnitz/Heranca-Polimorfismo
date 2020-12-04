using Exercicio_Resolvido_Metodos_Abstratos.Entities.Enums;


namespace Exercicio_Resolvido_Metodos_Abstratos.Entities
{
    class Rectangle : Shape
    {
        public double Width { get; set; }
        public double Height { get; set; }

        public Rectangle(double width, double height, Color color) : base(color)
        {
            Width = width;
            Height = height;
        }

        public override double Area()               //no metodo abstrato ele tem o override obrigatoriamente, não precisando 
                                                    //do virtual para ser estanciado no abstract
        {
            return Width * Height;
        }
    }
}
