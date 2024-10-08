using System.Data.Common;
using DesafioProjetoMinimalAPI.Dominio.Entidades;
using DesafioProjetoMinimalAPI.Dominio.Interfaces;
using DesafioProjetoMinimalAPI.DTOs;
using DesafioProjetoMinimalAPI.Infraesturura.Db;

namespace DesafioProjetoMinimalApi.Dominio.Servicos;

public class AdministradorServico : IAdministradorServico
{
    private readonly DbContexto _contexto;
    public AdministradorServico(DbContexto contexto)
    {
        _contexto = contexto;
    }
    public Administrador? Login(LoginDTO loginDTO)
    {
        var adm = _contexto.Administradores.Where(a => a.Email == loginDTO.Email && a.Senha == loginDTO.Senha).FirstOrDefault();
        return adm;
    }
}