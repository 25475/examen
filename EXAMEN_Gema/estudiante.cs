using System;
class estudiante{
    public string nombre{get;set;}
    public string apellidos{get;set;}
    public string Ninstitucion {get;set;}
    public int cedula{get;set;}

    public  estudiante(string nombre, string apellidos, string Ninstitucion, int cedula){
        this.nombre=nombre;
        this.apellidos=apellidos;
        this.Ninstitucion=Ninstitucion;
        this.cedula=cedula;
    }
}