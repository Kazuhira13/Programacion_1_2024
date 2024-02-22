using Creación_de_clases_Tarea;

class program
{
    static void Main(string[] args)
    {
        Persona oPersona = new Persona("Juan", "Perez", new DateTime(1990, 5, 20), "1234-5566", "Calle 123");
        Alumno oAlumno = new Alumno("Ana", "Lopez", new DateTime(2000, 2, 15), "4323-5565", "Avenida 456", "A12345", new DateTime(2023,3,2));
        Profesor oProfesro = new Profesor("Carlos", "Rene", new DateTime(1985, 10, 10), "4934-2100", "Plaza Principal", 3000);
        Console.WriteLine("Instancias creadas exitosamente!");
    }
}
    