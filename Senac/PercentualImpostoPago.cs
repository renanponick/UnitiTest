using System;

namespace PercentualImpostoPago
{
    public class Program
        {
            static public String PercentualImpostoPago(double faturamento, double imposto){
                double resultado;
                try{
                    resultado = (faturamento*imposto);
                    return ($"Resultado: {resultado}");
                }catch(Exception e){
                    return ($"Erro{e}");
                }
                
            }
        }
}