using DesafioProjetoMinialAPI.Dominio.Entidades;
using Microsoft.EntityFrameworkCore;

namespace DesafioProjetoMinialAPI.Infraesturura.Db;

public class DbContexto : DbContext
{
    private readonly IConfiguration _configuracaoAppSettings;
    public DbContexto(IConfiguration _configuracaoAppSettings)
    {
        this._configuracaoAppSettings = _configuracaoAppSettings;
    }
    public DbSet<Administrador> Administradores {get; set;} = default!;

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Administrador>().HasData(
            new Administrador {
                Id = 1,
                Email = "admin@admin.com",
                Senha = "123456",
                Perfil = "Adm"
            }
        );
    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        if(!optionsBuilder.IsConfigured){
            var stringConexao = _configuracaoAppSettings.GetConnectionString("mysql")?.ToString();
            if (!string.IsNullOrEmpty(stringConexao)){
                optionsBuilder.UseMySql(
                    stringConexao, 
                    ServerVersion.AutoDetect(stringConexao)
                );
            }        
        }
    }
}