namespace exercicios_alunos;
class Alunos
{
    public string nome="";
    public double nota1,  nota2;
    
    //MEDIA -> retorna um double (por exemplo um número com 8.3)
     public double obterMedia (){
        double media = (nota1=nota2)/2;
        return media;
     }

    //SITUAÇAO -> retorna uma string ("Aprovado" ou "Reprovado")
    public string obterSituacao(double media){
        string situacao="";
        if (media>=6){
            situacao="Aprovado";
        }else{
            situacao="Reprovado";
        }
        return situacao;
    }
    // MENSAGEM -> não retorna nada. só mostra na tela os detalhes (nome, media e situação) 
    public void mensagem(){
        double mediaCalculada = obterMedia();
        string resultadoSituacao = obterSituacao(mediaCalculada);
        Console.WriteLine(nome+" está "+resultadoSituacao+" com média: "+mediaCalculada);
    }
}
