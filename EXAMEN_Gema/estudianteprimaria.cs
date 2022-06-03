using System;
class estudianteprimaria:estudiante{
    int valorA{get;set;}
    public estudianteprimaria(int valorA, string nombre, string apellidos,string Ninstitucion,int cedula):base(nombre,apellidos,Ninstitucion,cedula)
{
    this.valorA=valorA;
}
    public  void mostrar()
    {
        Console.WriteLine("valor fijo anual : "+valorA);
        Console.WriteLine("nombre de estudiante: "+nombre);
        Console.WriteLine("apellido de estudiante: "+apellidos);
        Console.WriteLine("cedula"+cedula);
        Console.WriteLine("nombre de institucion: "+Ninstitucion);
    }
    public  void calcular_mat(){
        Console.WriteLine("Valor de la matricula anual: $"+valorA);
    }

    
}