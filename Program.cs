/*
  El Principio de Abierto/Cerrado (OCP) establece que el software debe estar
  abierto para extensión, pero cerrado para modificación. Es decir,
  se debe permitir agregar nuevas funcionalidades sin cambiar el código existente.



      Refactorización del Código

                 Primero, creamos una interfaz `ITaxCalculator` que define el método `CalculateTax`.

*/
public interface ITaxCalculator
{
}                //Luego, creamos implementaciones específicas para cada país:


public class IndiaTaxCalculator : ITaxCalculator
{
    public decimal CalculateTax(decimal income, decimal deduction)
    {
        decimal taxableIncome = income - deduction;
        // Lógica de cálculo de impuestos para India
        return;
    }
}

public class USATaxCalculator : ITaxCalculator
{
    public decimal CalculateTax(decimal income, decimal deduction)
    {
        decimal taxableIncome = income - deduction;
        // Lógica de cálculo de impuestos para USA
        return;
    }
}

public class UKTaxCalculator : ITaxCalculator
{
    public decimal CalculateTax(decimal income, decimal deduction)
    {
        decimal taxableIncome = income - deduction;
        // Lógica de cálculo de impuestos para UK
        return;
    }
}                  //Finalmente, modificamos la clase `TaxCalculator` para usar estas implementaciones:


public class TaxCalculator
{
    private readonly Dictionary<string, ITaxCalculator> taxCalculators;

    public TaxCalculator()
    {
        taxCalculators = new Dictionary<string, ITaxCalculator>
        {
            { "India", new IndiaTaxCalculator() },
            { "USA", new USATaxCalculator() },
            { "UK", new UKTaxCalculator() }
        };
    }

    public decimal Calculate(decimal income, decimal deduction, string country)
    {
        if (taxCalculators.ContainsKey(country))
        {
            return taxCalculators[country].CalculateTax(income, deduction);
        }
        else
        {
            throw new NotSupportedException($"El cálculo de impuestos para {country} no está soportado.");
        }
    }
}



//1. Interfaz ITaxCalculator: Define el contrato para cualquier clase que implemente el cálculo de impuestos.
//2. Clases específicas por país: Cada clase implementa la interfaz `ITaxCalculator` y contiene la lógica específica para calcular los impuestos en ese país.
//3. Clase TaxCalculator: Contiene un diccionario de calculadoras de impuestos específicas por país y delega el cálculo a la clase correspondiente basada en el país proporcionado.