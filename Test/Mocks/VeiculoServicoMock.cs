using Microsoft.AspNetCore.Http.HttpResults;
using MinimalApi.Dominio.Entidades;
using MinimalApi.Dominio.Interfaces;
using MinimalApi.DTOs;

namespace Test.Mocks;

public class VeiculoServicoMock : IVeiculoServico
{
    private static List<Veiculo> veiculos = new List<Veiculo>();

    public void Apagar(Veiculo veiculo)
    {
        veiculos.Remove(veiculo);
    }

    public void Atualizar(Veiculo veiculo)
    {
        // TODO: Atualizar veiculo em veiculos
        int indice = veiculos.FindIndex(v => v.Id == veiculo.Id);
        veiculos[indice].Nome = veiculo.Nome;
        veiculos[indice].Marca = veiculo.Marca;
        veiculos[indice].Ano = veiculo.Ano;        
    }

    public Veiculo? BuscaPorId(int id)
    {
        return veiculos.Find(v => v.Id == id);
    }

    public void Incluir(Veiculo veiculo)
    {
        veiculo.Id = veiculos.Count() + 1;
        veiculos.Add(veiculo);

    }

    public List<Veiculo> Todos(int? pagina = 1, string? nome = null, string? marca = null)
    {
        return veiculos;
    }

}