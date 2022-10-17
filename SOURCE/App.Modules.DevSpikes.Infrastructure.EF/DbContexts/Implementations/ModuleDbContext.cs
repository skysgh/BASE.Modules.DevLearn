using App.Base.Infrastructure.Factories;
using App.Base.Infrastructure.Storage.Db.EF.DbContexts.Implementations.Base;
using App.Modules.DevSpikes.Shared.Constants;
using App.Modules.DevSpikes.Shared.Entities;
using Microsoft.EntityFrameworkCore;


namespace App.Modules.DevSpikes.Infrastructure.Data.Storage.Db.EF.DbContexts.Implementations
{

    /// <summary>
    /// The Module specific DbContext (notice is has it's own Schema).
    /// <para>
    /// Inherits from the common <see cref="ModuleDbContextBase"/> 
    /// where <c>AppDbContextBase.SaveChanges</c>
    /// and <c>AppDbContextBase.SaveChangesAsync</c>
    /// intercept the save operation, 
    /// to clean up new/updated objects
    /// </para>
    /// <para>
    /// Also (and very importantly) the base class' static Constructor 
    /// ensures its migration capabilities work from the commandline.
    /// </para>
    /// </summary>
    /// <seealso cref="ModuleDbContextBase" />

    //[Alias(Constants.Db.AppCoreDbContextNames.Core)]
    public class ModuleDbContext : ModuleDbContextBase
    {



        /// <summary>
        /// Expost the Types/Tables specific to this DbContext
        /// </summary>
        public DbSet<Example>? Example { get; set; }


        /// <summary>
        /// Constructor
        /// <para>
        /// Constructor invokes base with 
        /// Key ('AppCoreDbContext') used to find the 
        /// ConnectionString in web.config
        /// </para>
        /// </summary>
#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
        public ModuleDbContext() :
#pragma warning restore CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
            this(ModuleConstants.DbConnectionStringName)
        {
            //Note:
            //Constructor is calling this, not base.
            //Or else SchemaKey won't be set.
        }


        /// <summary>
        /// Constructor
        /// </summary>
        /// <para>
        /// Note how its using a ServiceLocator in the middle
        /// to build a <c>DbContextOptions</c> to pass down.
        /// </para>
        /// <param name="connectionStringOrName"></param>
        public ModuleDbContext(string connectionStringOrName)
            : base(
                   ServiceLocator
                  .Get<DbContextOptionsBuilder>()
                  .UseSqlServer(connectionStringOrName)
                  .Options)
        {
            // VERY IMPORTANT:
            // HAVE to set the base schema key in the constructor
            // or set it in an override of 'OnModelCreating(modelBuilder)'
            SchemaKey = ModuleConstants.DbSchemaKey;

        }

    }
}

