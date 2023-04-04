using System;
					
public class Program
{
	public static void Main()
	{
		Usuario usu = new(777,"Best Jr. Programmer #1 In the World","Exercício de exemplo p/ P1","MVC");
        UsuarioDAO usuDAO = new();
        Controller ct = new(usuDAO);
        Console.WriteLine(ct.CadastrarUsuario(usu));
	}
}

public class Usuario
{
	int UsuarioId { get; set; }
	string Nome { get; set; }
	string Login { get; set; }
	string Senha { get; set; }
	
	public Usuario(int usuId, string nome, string login, string senha)
    {
        UsuarioId = usuId;
        Nome = nome;
        Login = login;
        Senha = senha;
    }
}

public class Controller
{
    UsuarioDAO UsuarioDAO;

    public Controller(UsuarioDAO usu)
    {
        UsuarioDAO = usu;
    }

    public string CadastrarUsuario(Usuario usu)
    {
        return UsuarioDAO.CadastrarUsuario(usu);
    }
}

public class UsuarioDAO
{

    public string CadastrarUsuario(Usuario usu)
	{
		// código de acesso ao bd
		return $"Código em UsuarioDAO sendo ativado \nId: {usu.UsuarioId}\nNome: {usu.Nome}\nLogin: {usu.Login}\nSenha: {usu.Senha}";
	}
}