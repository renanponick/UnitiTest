using System;

namespace VerificaPrimo
{
    public class Program
        {
            static public String VerificaPrimo(double a){
                try{
                    if((a%2==0)||(a%3==0)){
                        if((a==2)||(a==3)){
                                return ($"Resultado: {a}, primo");
                        }
                    }else{
                        return ($"Resultado: {a}, é primo");
                    }
                     return ($"Resultado: {a}, não é primo");
                }catch(Exception e){
                    return ($"Erro{e}");
                }
                
            }
        }
}