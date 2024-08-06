using System;

    
class VerificacaoTurmasAlunos
{
    private string nome = "";
    private string sobrenome = "";
    private string cpf = "";
    private string idade = "";
    private string email = "";
    
    public VerificacaoTurmasAlunos(string nome, string sobrenome, string cpf, string idade, string email)
    {
        this.nome = nome;
        this.sobrenome = sobrenome;
        this.cpf = cpf;
        this.idade = idade;
        this.email = email;
    }
    
    public string VerificarCampos()
    {
        if (!string.IsNullOrEmpty(nome) &&
            !string.IsNullOrEmpty(sobrenome) &&
            !string.IsNullOrEmpty(cpf) &&
            !string.IsNullOrEmpty(idade) &&
            !string.IsNullOrEmpty(email)
           )
        {
        }
        else
        if (cpf.Length == 11| !email.Contains("@"))
        {
            return "CPF ou Email não preenchem os requisitos!";
        }
            return "Os campos foram preenchidos com sucesso!";
      
    }
   
}
