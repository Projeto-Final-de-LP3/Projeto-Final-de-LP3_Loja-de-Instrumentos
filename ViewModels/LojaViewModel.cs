namespace ProjetoFinalLP3.ViewModels;

public class LojaViewModel
{
    public string? Nome { get; set; } 
    public string? Email { get; set; }
    public int Id { get; set; }
    public string Endereco { get; set; }
    public int? CPF { get; set; }
    public int? Pagamento { get; set; }
    public string? Tipo { get; set; }

    public LojaViewModel(string? nome, string? email, int id, string endereco, int? cpf, int? pagamento, string? tipo)
    {
        Nome = nome;
        Email = email;
        Id = id;
        Endereco = endereco;
        CPF = cpf;
        Pagamento = pagamento;
        Tipo = tipo;
    }
}