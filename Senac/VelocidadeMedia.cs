 using System;

namespace VelocidadeMedia
{
    public class Program
        {
            static public String VelocidadeMedia(double distancia, double tempo){
                double resultado;
                try{
                    resultado = distancia / tempo;
                    return ($"Resultado: {resultado}, não é o dobro");
                    
                }catch(Exception e){
                    return ($"Erro{e}");
                }
                
            }
        }
}
 