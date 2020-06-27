using System;

namespace Senac
{
    public class CalcularVolume
        {
            public String Calcular(double pri, double seg, double tre){
                double resultado;
                try{
                    resultado = ((pri*seg)*tre);
                    return ($"Resultado: {resultado}");
                }catch(Exception e){
                    return ($"Erro{e}");
                }
                
            }
        }
}