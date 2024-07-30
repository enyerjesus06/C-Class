
/*
 
Violación del Principio de Responsabilidad Única (SRP)

El principio de responsabilidad única (SRP) establece que una clase debe tener una única razón
para cambiar, es decir, debe tener una sola responsabilidad.
En el código, la clase Persona viola el SRP porque tiene múltiples
responsabilidades:
1. Gestionar datos de la persona (nombre, edad, dirección, correo electrónico).
2. Enviar correos electrónicos.
3. Imprimir datos.

*/

public class Persona
{
    private string nombre;
    private int edad;
    private string direccion;
    private string correoElectronico;

    public Persona(string nombre, int edad, string direccion, string correoElectronico)
    {
        this.nombre = nombre;
        this.edad = edad;
        this.direccion = direccion;
        this.correoElectronico = correoElectronico;
    }
    public string Nombre
    {
        get
        {
            return nombre;
        }
    }
    public int Edad
    {
        get
        {
            return edad;
        }
    }
    public string Direccion { get => direccion; }
    public string CorreoElectronico
    {
        get
        {
            return correoElectronico;
        }
    }
}


public class CorreoElectronicoService
{
    public void EnviarCorreoElectronico(Persona persona, string mensaje)
    {
       
        Console.WriteLine($"Enviando correo a {persona.CorreoElectronico} con el mensaje: {mensaje}");
    }
}


public class ImpresionService
{
    public void ImprimirDatos(Persona persona)
    {
        Console.WriteLine($"Nombre: {persona.Nombre}");
        Console.WriteLine($"Edad: {persona.Edad}");
        Console.WriteLine($"Dirección: {persona.Direccion}");
        Console.WriteLine($"Correo electrónico: {persona.CorreoElectronico}");
    }
}


