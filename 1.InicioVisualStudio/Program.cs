namespace _1InicioVisualStudio
{

    internal class Program
    {
        static void Main(string[] args)
        {
            //Esta es la dseclaración de una variable
            string nombre = "Isabela";
            const string IVA = "19%";
            Console.Write("Hola," + nombre + "\n");
            Console.Write("\tBienvenido(a) a la clase de Programación");
            nombre = "Eva";
            Console.Write("\n" + nombre);
            //IVA= "20%", no se puede cambiar el valor de una constante

            //Tipos de Datos
            byte dato1 = 255;
            int dato2 = 456;
            long dato3 = 827392240824;
            double dato4 = 365.99;
            char dato5 = 'a'; //Puede almacenar solo un dato
            bool dato6 = false;
            object data7 = new Program();
            string dato8 = "Carechimba";
            float dato9 = 4.444f;
        }

    }

}

