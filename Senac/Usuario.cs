using System;

namespace Senac
{
    public class Usuario
    {
        public string Login(string pEmail, string pSenha){
            if(string.IsNullOrEmpty(pEmail) || string.IsNullOrEmpty(pSenha)){
                return "Preencha todos os dados";
            }
            if(pEmail == "teste@teste.com" && pSenha == "123"){
                return "entrou";
            }else{
                return "Email ou senha invalidos";
            }
        }

        public bool VerificarNome(string pNome){
            if(string.IsNullOrEmpty(pNome)){
                return false;
            }else{
                return true;
            }
        }
        
    }
}
