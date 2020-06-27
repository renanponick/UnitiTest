using System;

namespace SalarioInformaImposto
{
    public class Program
        {
            static public String SalarioInformaImposto(double salario){
                double resultado = 0;
                try{
                    if(salario<1903.98){
                         resultado = 0;
                    }else if(salario<=2826.65){
                             resultado = (salario/100)*7.5;
                        }else if(salario<=3751.05){
                                resultado = (salario/100)*15;
                            }else if(salario<= 4664.68){
                                 resultado = (salario/100)*22.5;
                                }else if(salario>4664.68){
                                     resultado = (salario/100)*27.5;
                                    }
                    return ($"Resultado: {resultado}");
                }catch(Exception e){
                    return ($"Erro{e}");
                }
                
            }
        }
}