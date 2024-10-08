using DesafioProjetoMinimalAPI.Dominio.Entidades;
using DesafioProjetoMinimalAPI.DTOs;

namespace DesafioProjetoMinimalAPI.Dominio.Interfaces;

public interface IAdministradorServico
{
    Administrador? Login(LoginDTO loginDTO);
}