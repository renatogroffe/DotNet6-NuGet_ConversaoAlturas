namespace Groffe.Alturas;

public class ConversorAlturas
{
    /// <summary>
    /// Converte uma altura em pes para o equivalente em metros
    /// </summary>
    /// <param name="alturaPes">Altura em pes</param>
    /// <returns></returns>
    /// <exception cref="ArgumentException">Excecao lancada para uma altura em pes negativa ou igual a zero.</exception>
    public static double PesParaMetros(double alturaPes)
    {
        if (alturaPes <= 0)
            throw new ArgumentException("A altura em pes deve ser um valor maior do que zero!");
        
        return Math.Round(alturaPes * 0.3048, 4);
    }
}