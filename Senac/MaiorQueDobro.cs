using System;

namespace Senac
{
    public class MaiorQueDobro
        {
            public bool Validar(double pri, double seg){
                double resultado;
                try{
                    resultado = seg*2;
                    if (resultado > pri) {
                        return true;
                    }
                    else{
                        return false;
                    }
                }catch{
                    return false;
                }
                
            }
        }
}