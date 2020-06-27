using System;

namespace Senac
{
    public class CompararString
        {
            public bool Comparar(String a, String b){
                try{
                    if(String.Compare(a,b)==0){
                       return true;
                    }else{
                       return false;
                    }
                }catch{
                    return false;
                }
                
            }
        }
}