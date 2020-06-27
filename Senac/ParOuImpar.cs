using System;

namespace Senac
{
    public class ParOuImpar
        {
            public String Validar(double num){
                try{
                    if(num>=0){
                        if(num%2==0){
                            return ($"Resultado: {num} é par");
                           
                        }else{
                           return ($"Resultado: {num} é impar");
                        }
                    }else{
                       return ($"Resultado: {num} é negativo");
                    }
                }catch(Exception e){
                    return ($"Erro{e}");
                }
                
            }
        }
}