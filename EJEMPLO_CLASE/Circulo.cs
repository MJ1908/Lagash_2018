using System;

namespace Classes{
     public class Circulo: Figura{
        public Circulo(int r) => this.Radio = r;

        private int Radio{get;set;}

        public override int getPerimetro() => this.Radio * 3; 
        public override int getArea() => this.Radio * this.Radio * 3 ;


    }
}