using System;
using System.Collections.Generic;

namespace AngularNetStore.Models
{
    public class Persona
    {
      public int Id { get; set; } 
       public string Nombre { get; set; }
       public DateTime FechaNacimiento { get; set; }   
      //  public List<Direccion> Direcciones { get; set; }
    }
}