static void saludar(string nomsal)
{
    Console.WriteLine($"un gran saludo a {nomsal}");
}
static int calculo_año_nacimiento(int edad)
{
    int añon = 2023 - edad;
    return añon;
}
static void marque(string palabra)
{
    //int longitud = palabra.Length;
    //for(int i=4;i<longitud;i--)
    //{
    //    Console.SetCursorPosition(5-i, 10);
    //    Console.Write(palabra[i]);
    //    Thread.Sleep(1000);
    //}

    //int longitud = palabra.Length;
    //for (int i = longitud-1; i > 0; i--)
    //{
    //    Console.SetCursorPosition(5, 10);
    //    Console.Write(palabra[i]);
    //    Thread.Sleep(1000);
    //}

    int longitud = palabra.Length;
    string pal = "";
    for (int i = longitud-1; i >= 0; i--)
    {
        pal = pal + palabra[i];
    }
    Console.WriteLine(pal);

    //Console.WriteLine(palabra[2]);
}
static bool palindromo(string palabra)
{
    int longitud = palabra.Length;

    string pal = "";
    for (int i = longitud - 1; i >= 0; i--)
    {
        pal = pal + palabra[i].ToString().ToUpper();
    }
    //Equals para hacer igualdad en strings o cadenas
    if(palabra.Equals(pal))
    {
        return true;
    }
    return false;

}
string palabra;
palabra = "Maria";
marque(palabra);
bool esPalindromo = palindromo("anA".ToUpper());

if (esPalindromo)
{
    Console.WriteLine("Es palindromo");
}
else
{
    Console.WriteLine("nel");
}

//La diferencia es que la primera no devuelve valor pero la segunda si,
//cuando no devuelve valor es "metodo", "funcion" si devuelve valor
//string nombre;
//int edad;
////char letra = 'a';
////int año_nac;
//Console.Write("Cómo te llamas?: ");
//nombre = Console.ReadLine();
//saludar(nombre);
//Console.WriteLine($"Hola, gusto de saludarte {nombre}");
//Console.Write("Cuantos años tienes?: ");
//edad=Convert.ToInt32(Console.ReadLine());
////año_nac = calculo_año_nacimiento(edad);
//Console.WriteLine($"Bonita edad: {edad} \nNaciste en {calculo_año_nacimiento(edad)}");

