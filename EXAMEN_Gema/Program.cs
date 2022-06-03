using System;
class Program
    {
        static void Main(string[] args)
        {
            estudianteprimaria Eprimaria = new estudianteprimaria(150,"natasha", "mero","escuela", 123456789);
            estudianteprimaria.mostrar();
            estudianteprimaria.calcular_mat();

            Esecundaria Estusecundaria = new Esecundaria(8,20);
            Esecundaria.mostrar();
            Esecundaria.Calcular_mat();
            
            Euniversitario estniversitario = new Euniversitario(12,7);
            Euniversitario.mostrar();
            Euniversitario.Calcular_mat();
        } 
    }
}
