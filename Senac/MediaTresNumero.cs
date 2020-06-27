using System;

namespace Senac
{
    public class MediaTresNumeros
        {
            public String Calcular(int pri, int seg, int ter){
                double resultado;
                try{
                    resultado = (pri+seg+ter)/3;
                    return ($"Resultado: {resultado}");
                }catch(Exception e){
                    return ($"Erro{e}");
                }
                
            }
        }
}