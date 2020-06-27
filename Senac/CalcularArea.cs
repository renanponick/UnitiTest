using System;

namespace Senac
{
    public class CalcularArea{
            public String Calcular(double pri, double seg){
                double resultado;
                try{
                    resultado = (pri*seg);
                    return ($"Resultado: {resultado}");
                }catch{
                    return "Envie Numeros";
                }
                
            }
        }
}