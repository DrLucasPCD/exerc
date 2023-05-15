using Exo.WebApi. Models;


using Microsoft. EntityFrameworkCore;
using System.Data. SqlClient;
using Microsoft. Data. SqlClient;



namespace Exo .WebApi. Contexts
{{


    public class ExoContext: DbContext
    {
        public ExoContext()
    {   
    public ExoContext(DbContextOptions<ExoContext>options):base(options)
    {
    }
    protected override void OnConfiguring(DbContext0ptionsBuilder optionsBuilder)
        if(!optionsBuilder. IsConfigured)
        {
            // Essa string de conexão foi depende da SUA máquina. optionsBuilder.UseSalServer("Server=localhost\\SOLEXPRESS;"
            optionsBuilder.UseSalServer("Server=localhost\\SOLEXPRESS;"
                            + "Database-ExoApi;Trusted_Connection=True:");

    }
    }
    }
}}