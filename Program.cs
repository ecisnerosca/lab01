
class Program
{
    static void Main(string[] args)
    {

        Console.Write("Hola, ¿cual es tu nombre?: ");
        string nombre = Console.ReadLine();

        Console.Write("¿Cual es tu edad?: ");
        //int edad = Convert.ToInt32(Console.ReadLine());

        Console.Write("¿Cual es tu estatura?: ");
        decimal estatura = Convert.ToDecimal(Console.ReadLine());


        Console.WriteLine($"mi nombre es {nombre}, mi edad es {edad} y mi estatura es {estatura:N2} ");


        /*Método Descripción
        
        Console.Write Imprime texto en la consola sin hacer salto de línea.
        Console.WriteLine Imprime texto en la consola con salto de línea al final.
        Console.ReadLine Lee la entrada del usuario como una cadena de texto.
        Console.ReadKey Detiene la ejecución y espera que el usuario presione una tecla.
       
         */


        //Bienvenida();

        //variables();
        //constantes();

        //ejercicios
        //potencia();
        //raiz_cuadrada();
        //redondearlo_cercano();
        //redondearlo_arriba();
        //redondearlo_abajo();
        //entero();
        //circunferencia();


        //Ejercicio1();
        //Ejercicio2();
        //Ejercicio3();
        Console.ReadKey();
    }



    static void Bienvenida()
    {
        // Usamos Console.Write para imprimir un mensaje sin saltar de línea
        Console.Write("¿Cuál es tu nombre? ");

        // Usamos Console.ReadLine para obtener la entrada del usuario
        string nombre = Console.ReadLine();

        // Imprimimos un saludo con el nombre usando Console.WriteLine
        Console.WriteLine("¡Hola, " + nombre + "! Bienvenido a C#.");

        Console.WriteLine($"Hola, { nombre }! Bienvenido a C# ");
    }

    static void variables()
    {

        float precio = 19.99f;
        double distancia = 123456789.987654321d;
        decimal salario = 85000.50m;

        byte edad = 25;
        short temperatura = -10;
        int poblacion = 1000000;
        long distanciaLuna = 384400000L;

        string nombre = "Juan";

        // Imprimir los valores
        Console.WriteLine("Precio: " + precio);
        Console.WriteLine("Distancia: " + distancia);
        Console.WriteLine("Salario: " + salario);

        Console.WriteLine("Edad: " + edad);
        Console.WriteLine("Temperatura: " + temperatura);
        Console.WriteLine("Población: " + poblacion);
        Console.WriteLine("Distancia a la Luna: " + distanciaLuna);

        Console.WriteLine("Nombre: " + nombre);
    }

    static void constantes()
    {
        const int diasEnSemana = 7;
        const double pi = 3.14159;
        const string mensajeBienvenida = "¡Bienvenido al programa!";
        const char simboloMoneda = '$';
        const bool esActivo = true;

        // Imprimir los valores

        Console.WriteLine(diasEnSemana);  // Imprime: 7
        Console.WriteLine(pi);  // Imprime: 3.14159
        Console.WriteLine(mensajeBienvenida);  // Imprime: ¡Bienvenido al programa!
        Console.WriteLine(simboloMoneda);  // Imprime: $
        Console.WriteLine(esActivo);  // Imprime: True

    }

    static void potencia()
    {
        double radio = 5;
        double area = Math.PI * Math.Pow(radio, 2);  // Pi * r^2
        Console.WriteLine("Área del círculo: " + area);
    }

    static void raiz_cuadrada()
    {
        double catetoA = 3;
        double catetoB = 4;
        double hipotenusa = Math.Sqrt(Math.Pow(catetoA, 2) + Math.Pow(catetoB, 2)); // h = sqrt(a^2 + b^2)
        Console.WriteLine("Longitud de la hipotenusa: " + hipotenusa);
    }

    static void redondearlo_cercano()
    {
        double medida = 5.678;
        double redondeado = Math.Round(medida);  // Redondea al número entero más cercano
        Console.WriteLine("Medida redondeada: " + redondeado);
    }

    static void redondearlo_arriba()
    {
        double precio = 4.2;
        double precioRedondeadoArriba = Math.Ceiling(precio);  // Redondea hacia arriba
        Console.WriteLine("Precio redondeado hacia arriba: " + precioRedondeadoArriba);
    }

    static void redondearlo_abajo()
    {
        double puntuacion = 8.9;
        double puntuacionRedondeadaAbajo = Math.Floor(puntuacion);  // Redondea hacia abajo
        Console.WriteLine("Puntuación redondeada hacia abajo: " + puntuacionRedondeadaAbajo);
    }

    static void entero()
    {
        double saldo = 5.99;
        double saldoTruncado = Math.Truncate(saldo);  // Elimina la parte decimal
        Console.WriteLine("Saldo truncado: " + saldoTruncado);
    }

    static void circunferencia()
    {
        double radio = 10;
        double circunferencia = 2 * Math.PI * radio;  // Fórmula de la circunferencia: 2 * Pi * r
        Console.WriteLine("Circunferencia del círculo: " + circunferencia);
    }

    static void Ejercicio1()
    {
        Console.Write("Ingrese el número de habitaciones: ");
        int habitaciones = int.Parse(Console.ReadLine());

        Console.Write("Ingrese el número de baños: ");
        int banos = int.Parse(Console.ReadLine());

        Console.Write("Ingrese el número de patios: ");
        int patios = int.Parse(Console.ReadLine());

        double total = (habitaciones * 30) + (banos * 10) + (patios * 15);

        Console.WriteLine($"El pago total por alquiler es: S/. {total:F2}");
        Console.ReadKey();
    }

    static void Ejercicio2()
    {
        Console.Write("Ingrese el precio de la casaca: ");
        double precio = double.Parse(Console.ReadLine());

        double descuento = precio * 0.25;
        double precioFinal = precio - descuento;

        Console.WriteLine($"Descuento: S/. {descuento:F2}");
        Console.WriteLine($"Precio final a pagar: S/. {precioFinal:F2}");
        Console.ReadKey();
    }

    static void Ejercicio3()
    {
        Console.Write("Ingrese el largo de la pared en metros: ");
        double metros = double.Parse(Console.ReadLine());

        double centimetros = metros * 100;

        Console.WriteLine($"El largo en centímetros es: {centimetros} cm");
        Console.ReadKey();
    }
}