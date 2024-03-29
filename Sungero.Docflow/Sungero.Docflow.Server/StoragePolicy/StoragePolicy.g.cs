
// ==================================================================
// StoragePolicy.g.cs
// ==================================================================

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sungero.Docflow.Server
{
    public class StoragePolicyFilter<T> :
      global::Sungero.Docflow.Server.StoragePolicyBaseFilter<T>
      where T : class, global::Sungero.Docflow.IStoragePolicy
    {
      private global::Sungero.Docflow.IStoragePolicyFilterState filter
      {
        get
        {
          return (Sungero.Docflow.IStoragePolicyFilterState)this.Filter;
        }
      }

      protected override global::System.Linq.IQueryable<T> ApplyAppliedFilter(global::System.Linq.IQueryable<T> query)
      {
        return base.ApplyAppliedFilter(query);
      }

      public StoragePolicyFilter(global::Sungero.Docflow.IStoragePolicyFilterState filter)
      : base(filter)
      {
      }

      protected StoragePolicyFilter()
      {
      }
    }
      public class StoragePolicyUiFilter<T> :
        global::Sungero.Docflow.Server.StoragePolicyBaseUiFilter<T>
        where T : class, global::Sungero.Docflow.IStoragePolicy
      {
        protected override global::System.Linq.IQueryable<T> ApplyAppliedFilter(global::System.Linq.IQueryable<T> query)
        {
          return base.ApplyAppliedFilter(query);
        }
      }

    public class StoragePolicySearchDialogModel : global::Sungero.Docflow.Server.StoragePolicyBaseSearchDialogModel
        {
                  public override global::System.Int64? Id { get; protected set; }
                  public override global::System.Int32? Priority { get; protected set; }
                  public override global::System.String Name { get; protected set; }
                  public override global::System.String Note { get; protected set; }


                  public override global::System.Collections.Generic.IEnumerable<Sungero.CoreEntities.IStorage> Storage { get; protected set; }




                   [Sungero.Domain.Shared.HideInDevStudio()]
                   public new StoragePolicyDocumentKindsModel DocumentKinds { get { return (StoragePolicyDocumentKindsModel)base.DocumentKinds; } protected set { base.DocumentKinds = value; } }

        }

      public class StoragePolicyDocumentKindsModel : global::Sungero.Docflow.Server.StoragePolicyBaseDocumentKindsModel
          {
                      [Sungero.Domain.Shared.HideInDevStudio()]
                      public override global::System.Int64? Id { get; protected set; }




         }





  [global::Sungero.Domain.Filter(typeof(global::Sungero.Docflow.Server.StoragePolicyFilter<global::Sungero.Docflow.IStoragePolicy>))]
  [global::Sungero.Domain.UiFilter(typeof(global::Sungero.Docflow.Server.StoragePolicyUiFilter<global::Sungero.Docflow.IStoragePolicy>))]

  public class StoragePolicy :
    global::Sungero.Docflow.Server.StoragePolicyBase, global::Sungero.Docflow.IStoragePolicy
  {
    public static new readonly global::System.Guid ClassTypeGuid = global::System.Guid.Parse("9fed5653-77e7-4543-b071-6586033907ef");

    public override global::System.Guid TypeGuid
    {
      get { return global::Sungero.Docflow.Server.StoragePolicy.ClassTypeGuid; }
    }

    public override string TypeName
    {
      get { return "Sungero.Docflow.IStoragePolicy, Sungero.Domain.Interfaces"; }
    }

    public override string DisplayValue
    {
      get { return this.Name; }
      set { this.Name = value; }
    }

    public new virtual global::Sungero.Docflow.IStoragePolicyState State
    {
      get { return (global::Sungero.Docflow.IStoragePolicyState)base.State; }
    }

    protected override global::Sungero.Domain.Shared.IEntityState CreateState()
    {
      return new global::Sungero.Docflow.Shared.StoragePolicyState(this);
    }

    public new virtual global::Sungero.Docflow.IStoragePolicyInfo Info
    {
      get { return (global::Sungero.Docflow.IStoragePolicyInfo)base.Info; }
    }

    public new virtual global::Sungero.Docflow.IStoragePolicyAccessRights AccessRights
    {
      get { return (global::Sungero.Docflow.IStoragePolicyAccessRights)base.AccessRights; }
    }

    protected override global::Sungero.Domain.Shared.IEntityAccessRights CreateAccessRights()
    {
      return new global::Sungero.Docflow.Server.StoragePolicyAccessRights(this);
    }

    protected override global::Sungero.Domain.EntityFunctions CreateServerFunctions()
    {
      return new global::Sungero.Docflow.Server.StoragePolicyFunctions(this);
    }

    protected override global::Sungero.Domain.Shared.EntityFunctions CreateSharedFunctions()
    {
      return new global::Sungero.Docflow.Shared.StoragePolicyFunctions(this);
    }

    protected override object CreateHandlers() {
      return new global::Sungero.Docflow.StoragePolicyServerHandlers(this);
    }

    protected override object CreateSharedHandlers() {
      return new global::Sungero.Docflow.StoragePolicySharedHandlers(this);
    }









    protected override global::Sungero.Domain.Shared.IChildEntityCollection<global::Sungero.Docflow.IStoragePolicyBaseDocumentKinds> CreateDocumentKindsCollection()
    {
      return new global::Sungero.Domain.ChildEntityCollection<global::Sungero.Docflow.IStoragePolicyDocumentKinds>() { RootEntity = this };
    }


    protected override global::Sungero.Domain.Shared.EntityCreatingFromServerHandler CreateCreatingFromServerHandler(
      global::Sungero.Domain.Shared.IEntity entitySource)
    {
      var instance = Sungero.Metadata.Services.AppliedTypesManager.CreateInstance("Sungero.Docflow.StoragePolicyCreatingFromServerHandler", new object[] { (global::Sungero.Docflow.IStoragePolicy)entitySource, this.Info });
      if (instance != null)
        return (global::Sungero.Domain.Shared.EntityCreatingFromServerHandler)instance;

      return new global::Sungero.Docflow.StoragePolicyCreatingFromServerHandler((global::Sungero.Docflow.IStoragePolicy)entitySource, this.Info);
    }

    #region Framework events




    #endregion


    public StoragePolicy()
    {
    }

  }
}

// ==================================================================
// StoragePolicyHandlers.g.cs
// ==================================================================

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sungero.Docflow
{

  public partial class StoragePolicyFilteringServerHandler<T>
    : global::Sungero.Docflow.StoragePolicyBaseFilteringServerHandler<T>  
    where T : class, global::Sungero.Docflow.IStoragePolicy
  {
    private global::Sungero.Docflow.IStoragePolicyFilterState _filter
    {
      get
      {
        return (Sungero.Docflow.IStoragePolicyFilterState)this.Filter;
      }
    }

    public StoragePolicyFilteringServerHandler(global::Sungero.Docflow.IStoragePolicyFilterState filter)
    : base(filter)
    {
    }

    protected StoragePolicyFilteringServerHandler()
    {
    }

    public override global::System.Linq.IQueryable<T> Filtering(global::System.Linq.IQueryable<T> query, global::Sungero.Domain.FilteringEventArgs e)
    {
      query = base.Filtering(query, e);
            return query;
    }


  }

  public partial class StoragePolicyUiFilteringServerHandler<T>
    : global::Sungero.Docflow.StoragePolicyBaseUiFilteringServerHandler<T>
    where T : class, global::Sungero.Docflow.IStoragePolicy
  {
    public override global::System.Linq.IQueryable<T> Filtering(global::System.Linq.IQueryable<T> query, global::Sungero.Domain.UiFilteringEventArgs e)
    {
      query = base.Filtering(query, e);
            return query;
    }
  }

  public partial class StoragePolicySearchDialogServerHandler : global::Sungero.Docflow.StoragePolicyBaseSearchDialogServerHandler
   {
     private global::Sungero.Docflow.Server.StoragePolicySearchDialogModel _dialog
     {
       get
       {
         return (global::Sungero.Docflow.Server.StoragePolicySearchDialogModel)this.Dialog;
       }
     }

     public StoragePolicySearchDialogServerHandler(global::Sungero.Docflow.Server.StoragePolicySearchDialogModel dialog)
       : base(dialog)
     {
     }
   }

  public partial class StoragePolicyServerHandlers : global::Sungero.Docflow.StoragePolicyBaseServerHandlers
  {
    private global::Sungero.Docflow.IStoragePolicy _obj
    {
      get { return (global::Sungero.Docflow.IStoragePolicy)this.Entity; }
    }

    public StoragePolicyServerHandlers(global::Sungero.Docflow.IStoragePolicy entity)
      : base(entity)
    {
    }
  }

  public partial class StoragePolicyCreatingFromServerHandler : global::Sungero.Docflow.StoragePolicyBaseCreatingFromServerHandler
  {
    private global::Sungero.Docflow.IStoragePolicy _source
    {
      get { return (global::Sungero.Docflow.IStoragePolicy)this.Source; }
    }

    private global::Sungero.Docflow.IStoragePolicyInfo _info
    {
      get { return (global::Sungero.Docflow.IStoragePolicyInfo)this._Info; }
    }

    public StoragePolicyCreatingFromServerHandler(global::Sungero.Docflow.IStoragePolicy source, global::Sungero.Docflow.IStoragePolicyInfo info)
      : base(source, info)
    {
    }
  }

}

// ==================================================================
// StoragePolicyEventArgs.g.cs
// ==================================================================

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sungero.Docflow.Server
{
}

// ==================================================================
// StoragePolicyAccessRights.g.cs
// ==================================================================

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sungero.Docflow.Server
{
  public class StoragePolicyAccessRights : 
    Sungero.Docflow.Server.StoragePolicyBaseAccessRights, Sungero.Docflow.IStoragePolicyAccessRights
  {

    public StoragePolicyAccessRights(global::Sungero.Domain.Shared.IEntity entity) : base(entity)
    {
    }
  }

  public class StoragePolicyTypeAccessRights : 
    Sungero.Docflow.Server.StoragePolicyBaseTypeAccessRights, Sungero.Docflow.IStoragePolicyAccessRights
  {

    public StoragePolicyTypeAccessRights(global::System.Type entityType) : base(entityType)
    {
    }
  }
}

// ==================================================================
// StoragePolicyRepositoryImplementer.g.cs
// ==================================================================

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sungero.Docflow.Server
{
    public class StoragePolicyRepositoryImplementer<T> : 
      global::Sungero.Docflow.Server.StoragePolicyBaseRepositoryImplementer<T>,
      global::Sungero.Docflow.IStoragePolicyRepositoryImplementer<T>
      where T : global::Sungero.Docflow.IStoragePolicy 
    {
       public new global::Sungero.Docflow.IStoragePolicyAccessRights AccessRights
       {
          get { return (global::Sungero.Docflow.IStoragePolicyAccessRights)base.AccessRights; }
       }

       public new global::Sungero.Docflow.IStoragePolicyInfo Info
       {
          get { return (global::Sungero.Docflow.IStoragePolicyInfo)base.Info; }
       }

       protected override global::Sungero.Domain.Shared.IEntityAccessRights CreateAccessRights()
       {
         return new global::Sungero.Docflow.Server.StoragePolicyTypeAccessRights(typeof(T));
       }
    }
}

// ==================================================================
// StoragePolicyPanelNavigationFilters.g.cs
// ==================================================================

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sungero.Docflow.Server
{
}

// ==================================================================
// StoragePolicyServerFunctions.g.cs
// ==================================================================

namespace Sungero.Docflow.Server
{
  public partial class StoragePolicyFunctions : global::Sungero.Docflow.Server.StoragePolicyBaseFunctions
  {
    private global::Sungero.Docflow.IStoragePolicy _obj
    {
      get { return (global::Sungero.Docflow.IStoragePolicy)this.Entity; }
    }

    public StoragePolicyFunctions(global::Sungero.Docflow.IStoragePolicy entity) : base(entity) { }
  }
}

// ==================================================================
// StoragePolicyFunctions.g.cs
// ==================================================================

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sungero.Docflow.Functions
{
  internal static class StoragePolicy
  {
    /// <redirect project="Sungero.Docflow.Server" type="Sungero.Docflow.Server.StoragePolicyFunctions" />
    internal static  global::System.Boolean HasSamePriorityPolicies(global::Sungero.Docflow.IStoragePolicy storagePolicy)
    {
      var __functions = ((global::Sungero.Domain.Shared.IEntityFunctions)storagePolicy).FunctionsContainer.ServerFunctions;
      var __funcMethod = __functions.GetType().GetMethod("HasSamePriorityPolicies", new System.Type[] {  });
      return (global::System.Boolean)global::CommonLibrary.ReflectionExtensions.ReflectionInvoke(__funcMethod, __functions, new object[] {  });
    }

  }
}

// ==================================================================
// StoragePolicyServerPublicFunctions.g.cs
// ==================================================================

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sungero.Docflow.Server
{
  public class StoragePolicyServerPublicFunctions : global::Sungero.Docflow.Server.IStoragePolicyServerPublicFunctions
  {
  }
}

// ==================================================================
// StoragePolicyQueries.g.cs
// ==================================================================

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sungero.Docflow.Queries
{
  public class StoragePolicy
  {
    private static global::Sungero.Domain.SqlQueryResolver resolver = new global::Sungero.Domain.SqlQueryResolver("Sungero.Docflow.Server.StoragePolicy.StoragePolicyQueries.xml", System.Reflection.Assembly.GetExecutingAssembly());
  }
}
