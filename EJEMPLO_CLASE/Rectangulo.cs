using System;

namespace Classes{
     public class Rectangulo:Figura{
        public Rectangulo(int b, int a){
            this.Lado1 = b;
            this.Lado2 = a;
        }

        private int Lado1{get;set;}
         private int Lado2{get;set;}

        public override int getPerimetro() => this.Lado1 * 2 + this.Lado2 * 2;

        public override int getArea() => this.Lado1 * this.Lado2;

    }
}