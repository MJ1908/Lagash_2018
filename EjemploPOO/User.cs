using Interfaces;
using System;

namespace Classes{
     public class User: IUser{
         private string Name{get;set;}
         private string LastName{get;set;}

         public void setName(string name){
            this.Name = name;
         }
        public void setLastName(string lastname){
            this.LastName = lastname;
        }

        public string getFullName(){
            return ("Nombre: "+ this.Name+", Apellido: "+this.LastName);
        }
         
     }
}