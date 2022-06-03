using System;
class Esecundaria:estudiante
{
    int nivel{set;get;}
    int precionivel{get;set;}
    int matricula;
    
    public Esecundaria(int nivel, int precionivel):base(nombre,apellidos, Ninstitucion, cedula)
    {
       this.precionivel=precionivel;
       this.nivel=nivel;
    }
    public  void mostrar()
    {
        Console.WriteLine("nivel cursado : "+nivel);
        Console.WriteLine("precio nivel : "+precionivel);
        Console.WriteLine("nombre de estudiante: "+nombre);
        Console.WriteLine("apellido de estudiante: "+apellidos);
        Console.WriteLine("cedula"+cedula);
        Console.WriteLine("nombre de institucion: "+Ninstitucion);}
    
    public void calcular_mat()
    {
        matricula=nivel*precionivel;
    }
}