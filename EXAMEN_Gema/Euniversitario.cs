using System;
class Euniversitario:estudiante
{
int creditos {get;set;}
    int preciocreditos{get;set;}
    public Euniversitario(int creditos, int preciocreditos):base(nombre,apellidos,Ninstitucion,cedula)
    {
        Console.WriteLine("cantidad de creditos: "+creditos);
        Console.WriteLine("precio de creditos: "+preciocreditos);
    }

    public void calcular_mat(){
        int tot;
        tot=creditos*preciocreditos;
    }
}