using Exercicio_Resolvido_Metodos_Abstratos.Entities.Enums;

namespace Exercicio_Resolvido_Metodos_Abstratos.Entities
{
    abstract class Shape  //para implementar a classe abstrata também precisa estar definido na classe
    {
        public Color color { get; set; }

        //public Shape()  //tira a obrigação de informar a cor, instanciando apenas um construtor padrão
        //{
        //
        //}

        public Shape(Color color)
        {
            this.color = color;
        }

        public abstract double Area();   //declarando que a operação vai ser abstrata a classe precisa ser abstrata também

    }    
}
