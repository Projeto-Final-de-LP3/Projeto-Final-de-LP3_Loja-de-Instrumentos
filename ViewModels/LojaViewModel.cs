namespace ProjetoFinaldeLP3LojadeInstrumentos.ViewModels;

public class LojaViewModel
{
    public string? Nome { get; set; } 
    public string? Email { get; set; }
    public int Endereco { get; set; }
    public int? CPF { get; set; }
    public int? Pagamento { get; set; }
    public string? Tipo { get; set; }

    public LojaViewModel(string? nome, string? email, int endereco, int? cpf, int? pagamento, string? tipo)
    {
        Nome = nome;
        Email = email;
        Endereco = endereco;
        CPF = cpf;
        Pagamento = pagamento;
        Tipo = tipo;
    }
}