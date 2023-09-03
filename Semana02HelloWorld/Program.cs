// See https://aka.ms/new-console-template for more information
using Semana02HelloWorld;

Console.WriteLine("Hello, World!");

string curso = "Desarrollo de Ambiente Web";
int edad = 20;
double salaria = 10000;

var alumno = "Joseph Valencia";
var notaFinal = 19.5;

var persona = new Persona();
persona.DNI = 20204040;
persona.telefono = "317-5200";
persona.NombreCompleto = "Paolo Guerrero";
persona.Estado = true;

var persona2 = new Persona() {
    DNI = 20205050,
    telefono = "317-5600",
    NombreCompleto = "Gianluca Lapadula",
    Estado = true
};

var persona3 = new Persona(20206060, "Alex Valera", "317-7500", false);

var personas = new List<Persona>();
personas.Add(persona);
personas.Add(persona2);
personas.Add(persona3);

// Personas activas
var busqueda2 = personas.Where(x=>x.Estado == true).ToList();

// Personas por DNI
var busqueda = personas.Where(z=>z.DNI == 20205050).FirstOrDefault();


var busquedaLINQ = (from p in personas
                    where p.DNI == 20205050
                    select p).FirstOrDefault();


