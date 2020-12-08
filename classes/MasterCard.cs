namespace AulaPOO_Encapsulamento.classes
{
    public class MasterCard : Cartao
    {
        //Atributos
        private int parcelas;

        //get e set
        public int Parcelas{
             get {return parcelas;} //Pegar dados
             set { parcelas = value;} //inserir dados
        }

        //Métodos
        public string ComprarComDesconto(){
            
            return "";
        }
        public string visualizarParcelas(string senha){
            
            return "";
        }
    }
}