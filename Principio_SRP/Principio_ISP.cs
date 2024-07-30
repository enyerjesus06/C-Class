
/* El Principio de Segregación de Interfaces (ISP, por sus siglas en inglés) establece
  que las interfaces deben ser específicas para un cliente en lugar de generales. Es decir,
  una interfaz no debe obligar a las clases que la implementan a depender de métodos que no utilizan.

 */
interface IAve
{
    void PonerHuevos();
}

interface IAveVoladora : IAve
{
    void Volar();
}

interface IAveCantora : IAve
{
    void Cantar();
}

interface IAveNadadora : IAve
{
    void Nadar();
}

interface IAveCazadora : IAve
{
    void Cazar();
}


/* Ahora, las diferentes clases de aves pueden implementar solo las interfaces que representan las habilidades que tienen. Por ejemplo: */


public class Aguila : IAveVoladora, IAveCazadora
{
    public void Volar() { /* Implementación */ }
    public void Cazar() { /* Implementación */ }
    public void PonerHuevos() { /* Implementación */ }
}

public class Pinguino : IAveNadadora
{
    public void Nadar() { /* Implementación */ }
    public void PonerHuevos() { /* Implementación */ }
}


/* De esta manera, cada clase de ave implementa solo los métodos que son relevantes para sus habilidades, respetando así el principio ISP. */