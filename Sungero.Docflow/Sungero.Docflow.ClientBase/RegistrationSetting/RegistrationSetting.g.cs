
// ==================================================================
// RegistrationSettingEventArgs.g.cs
// ==================================================================

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sungero.Docflow.Client
{ 
  public class RegistrationSettingDocumentRegisterValueInputEventArgs : global::Sungero.Presentation.ValueInputEventArgs<global::Sungero.Docflow.IDocumentRegister>
  {
    public RegistrationSettingDocumentRegisterValueInputEventArgs(global::Sungero.Docflow.IDocumentRegister oldValue, global::Sungero.Docflow.IDocumentRegister newValue, global::Sungero.Domain.Shared.IEntity entity, global::Sungero.Domain.Shared.IPropertyInfo propertyInfo): base(oldValue, newValue, entity, propertyInfo) { }
  }



}

// ==================================================================
// RegistrationSettingHandlers.g.cs
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

  public partial class RegistrationSettingFilteringClientHandler
    : global::Sungero.Domain.EntityFilteringClientHandler
  {
    [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
    protected global::Sungero.Docflow.IRegistrationSettingFilterState Filter { get; private set; }

    private global::Sungero.Docflow.IRegistrationSettingFilterState _filter
    {
      get
      {
        return this.Filter;
      }
    }

    public RegistrationSettingFilteringClientHandler(global::Sungero.Docflow.IRegistrationSettingFilterState filter)
    : base()
    {
      this.Filter = filter;
    }

    protected RegistrationSettingFilteringClientHandler()
    {
    }

    public override void ValidateFilterPanel(global::Sungero.Domain.Client.ValidateFilterPanelEventArgs e)
    {
    }
  }


  public partial class RegistrationSettingClientHandlers : global::Sungero.CoreEntities.DatabookEntryClientHandlers
  {
    private global::Sungero.Docflow.IRegistrationSetting _obj
    {
      get { return (global::Sungero.Docflow.IRegistrationSetting)this.Entity; }
    }

    public virtual void NameValueInput(global::Sungero.Presentation.StringValueInputEventArgs e) { }


    public virtual void DocumentFlowValueInput(global::Sungero.Presentation.EnumerationValueInputEventArgs e) { }





    public virtual void DocumentRegisterValueInput(global::Sungero.Docflow.Client.RegistrationSettingDocumentRegisterValueInputEventArgs e) { }


    public virtual void PriorityValueInput(global::Sungero.Presentation.IntegerValueInputEventArgs e) { }


    public virtual void SettingTypeValueInput(global::Sungero.Presentation.EnumerationValueInputEventArgs e) { }


    public virtual global::System.Collections.Generic.IEnumerable<global::Sungero.Core.Enumeration> SettingTypeFiltering(
      global::System.Collections.Generic.IEnumerable<global::Sungero.Core.Enumeration> query) 
    { 
      return query; 
    }


    public RegistrationSettingClientHandlers(global::Sungero.Docflow.IRegistrationSetting entity) : base(entity)
    {
    }
  }

  public partial class RegistrationSettingDocumentKindsClientHandlers : global::Sungero.Domain.Shared.ChildEntityClientHandlers
  {
    private global::Sungero.Docflow.IRegistrationSettingDocumentKinds _obj
    {
      get { return (global::Sungero.Docflow.IRegistrationSettingDocumentKinds)this.Entity; }
    }
    public virtual void DocumentKindsDocumentKindValueInput(global::Sungero.Docflow.Client.RegistrationSettingDocumentKindsDocumentKindValueInputEventArgs e) { }


    public RegistrationSettingDocumentKindsClientHandlers(global::Sungero.Docflow.IRegistrationSettingDocumentKinds entity) : base(entity)
    {
    }
  }

  public partial class RegistrationSettingBusinessUnitsClientHandlers : global::Sungero.Domain.Shared.ChildEntityClientHandlers
  {
    private global::Sungero.Docflow.IRegistrationSettingBusinessUnits _obj
    {
      get { return (global::Sungero.Docflow.IRegistrationSettingBusinessUnits)this.Entity; }
    }
    public virtual void BusinessUnitsBusinessUnitValueInput(global::Sungero.Docflow.Client.RegistrationSettingBusinessUnitsBusinessUnitValueInputEventArgs e) { }


    public RegistrationSettingBusinessUnitsClientHandlers(global::Sungero.Docflow.IRegistrationSettingBusinessUnits entity) : base(entity)
    {
    }
  }

  public partial class RegistrationSettingDepartmentsClientHandlers : global::Sungero.Domain.Shared.ChildEntityClientHandlers
  {
    private global::Sungero.Docflow.IRegistrationSettingDepartments _obj
    {
      get { return (global::Sungero.Docflow.IRegistrationSettingDepartments)this.Entity; }
    }
    public virtual void DepartmentsDepartmentValueInput(global::Sungero.Docflow.Client.RegistrationSettingDepartmentsDepartmentValueInputEventArgs e) { }


    public RegistrationSettingDepartmentsClientHandlers(global::Sungero.Docflow.IRegistrationSettingDepartments entity) : base(entity)
    {
    }
  }

}

// ==================================================================
// RegistrationSettingClientFunctions.g.cs
// ==================================================================

namespace Sungero.Docflow.Client
{
  public partial class RegistrationSettingFunctions : global::Sungero.CoreEntities.Client.DatabookEntryFunctions
  {
    private global::Sungero.Docflow.IRegistrationSetting _obj
    {
      get { return (global::Sungero.Docflow.IRegistrationSetting)this.Entity; }
    }

    public RegistrationSettingFunctions(global::Sungero.Docflow.IRegistrationSetting entity) : base(entity) { }
  }
}

// ==================================================================
// RegistrationSettingFunctions.g.cs
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
  internal static class RegistrationSetting
  {
    /// <redirect project="Sungero.Docflow.Shared" type="Sungero.Docflow.Shared.RegistrationSettingFunctions" />
    internal static  global::System.Collections.Generic.List<global::Sungero.Docflow.IRegistrationSetting> GetByDocumentRegister(global::Sungero.Docflow.IDocumentRegister documentRegister)
    {
      var __funcType = Sungero.Metadata.Services.AppliedTypesManager.Instance.Resolve("Sungero.Docflow.Shared.RegistrationSettingFunctions");
      if (__funcType != null)
      {    
        var __funcMethod = __funcType.GetMethod("GetByDocumentRegister",
          System.Reflection.BindingFlags.Static | System.Reflection.BindingFlags.Public | System.Reflection.BindingFlags.NonPublic,
          null, new System.Type[] { typeof(global::Sungero.Docflow.IDocumentRegister) }, null);
        return (global::System.Collections.Generic.List<global::Sungero.Docflow.IRegistrationSetting>)global::CommonLibrary.ReflectionExtensions.ReflectionInvoke(__funcMethod, null, new object[] { documentRegister });
      }
      else
      {
        return global::Sungero.Docflow.Shared.RegistrationSettingFunctions.GetByDocumentRegister(documentRegister);
      }
    }
    /// <redirect project="Sungero.Docflow.Shared" type="Sungero.Docflow.Shared.RegistrationSettingFunctions" />
    internal static  global::Sungero.Docflow.IRegistrationSetting GetSettingByDocument(global::Sungero.Docflow.IOfficialDocument document, global::System.Nullable<global::Sungero.Core.Enumeration> settingType)
    {
      var __funcType = Sungero.Metadata.Services.AppliedTypesManager.Instance.Resolve("Sungero.Docflow.Shared.RegistrationSettingFunctions");
      if (__funcType != null)
      {    
        var __funcMethod = __funcType.GetMethod("GetSettingByDocument",
          System.Reflection.BindingFlags.Static | System.Reflection.BindingFlags.Public | System.Reflection.BindingFlags.NonPublic,
          null, new System.Type[] { typeof(global::Sungero.Docflow.IOfficialDocument), typeof(global::System.Nullable<global::Sungero.Core.Enumeration>) }, null);
        return (global::Sungero.Docflow.IRegistrationSetting)global::CommonLibrary.ReflectionExtensions.ReflectionInvoke(__funcMethod, null, new object[] { document, settingType });
      }
      else
      {
        return global::Sungero.Docflow.Shared.RegistrationSettingFunctions.GetSettingByDocument(document, settingType);
      }
    }
    /// <redirect project="Sungero.Docflow.Shared" type="Sungero.Docflow.Shared.RegistrationSettingFunctions" />
    internal static  global::Sungero.Docflow.IRegistrationSetting GetSettingForKind(global::Sungero.Docflow.IOfficialDocument document, global::System.Nullable<global::Sungero.Core.Enumeration> settingType, global::Sungero.Docflow.IDocumentKind documentKind)
    {
      var __funcType = Sungero.Metadata.Services.AppliedTypesManager.Instance.Resolve("Sungero.Docflow.Shared.RegistrationSettingFunctions");
      if (__funcType != null)
      {    
        var __funcMethod = __funcType.GetMethod("GetSettingForKind",
          System.Reflection.BindingFlags.Static | System.Reflection.BindingFlags.Public | System.Reflection.BindingFlags.NonPublic,
          null, new System.Type[] { typeof(global::Sungero.Docflow.IOfficialDocument), typeof(global::System.Nullable<global::Sungero.Core.Enumeration>), typeof(global::Sungero.Docflow.IDocumentKind) }, null);
        return (global::Sungero.Docflow.IRegistrationSetting)global::CommonLibrary.ReflectionExtensions.ReflectionInvoke(__funcMethod, null, new object[] { document, settingType, documentKind });
      }
      else
      {
        return global::Sungero.Docflow.Shared.RegistrationSettingFunctions.GetSettingForKind(document, settingType, documentKind);
      }
    }
    /// <redirect project="Sungero.Docflow.Shared" type="Sungero.Docflow.Shared.RegistrationSettingFunctions" />
    internal static  global::Sungero.Docflow.IRegistrationSetting GetSettingByParams(global::System.Nullable<global::Sungero.Core.Enumeration> settingType, global::Sungero.Company.IBusinessUnit businessUnit, global::Sungero.Docflow.IDocumentKind documentKind, global::Sungero.Company.IDepartment department)
    {
      var __funcType = Sungero.Metadata.Services.AppliedTypesManager.Instance.Resolve("Sungero.Docflow.Shared.RegistrationSettingFunctions");
      if (__funcType != null)
      {    
        var __funcMethod = __funcType.GetMethod("GetSettingByParams",
          System.Reflection.BindingFlags.Static | System.Reflection.BindingFlags.Public | System.Reflection.BindingFlags.NonPublic,
          null, new System.Type[] { typeof(global::System.Nullable<global::Sungero.Core.Enumeration>), typeof(global::Sungero.Company.IBusinessUnit), typeof(global::Sungero.Docflow.IDocumentKind), typeof(global::Sungero.Company.IDepartment) }, null);
        return (global::Sungero.Docflow.IRegistrationSetting)global::CommonLibrary.ReflectionExtensions.ReflectionInvoke(__funcMethod, null, new object[] { settingType, businessUnit, documentKind, department });
      }
      else
      {
        return global::Sungero.Docflow.Shared.RegistrationSettingFunctions.GetSettingByParams(settingType, businessUnit, documentKind, department);
      }
    }
    /// <redirect project="Sungero.Docflow.Shared" type="Sungero.Docflow.Shared.RegistrationSettingFunctions" />
    internal static  global::System.Linq.IQueryable<global::Sungero.Docflow.IRegistrationSetting> GetAvailableSettingsByParams(global::System.Nullable<global::Sungero.Core.Enumeration> settingType, global::Sungero.Company.IBusinessUnit businessUnit, global::Sungero.Docflow.IDocumentKind documentKind, global::Sungero.Company.IDepartment department)
    {
      var __funcType = Sungero.Metadata.Services.AppliedTypesManager.Instance.Resolve("Sungero.Docflow.Shared.RegistrationSettingFunctions");
      if (__funcType != null)
      {    
        var __funcMethod = __funcType.GetMethod("GetAvailableSettingsByParams",
          System.Reflection.BindingFlags.Static | System.Reflection.BindingFlags.Public | System.Reflection.BindingFlags.NonPublic,
          null, new System.Type[] { typeof(global::System.Nullable<global::Sungero.Core.Enumeration>), typeof(global::Sungero.Company.IBusinessUnit), typeof(global::Sungero.Docflow.IDocumentKind), typeof(global::Sungero.Company.IDepartment) }, null);
        return (global::System.Linq.IQueryable<global::Sungero.Docflow.IRegistrationSetting>)global::CommonLibrary.ReflectionExtensions.ReflectionInvoke(__funcMethod, null, new object[] { settingType, businessUnit, documentKind, department });
      }
      else
      {
        return global::Sungero.Docflow.Shared.RegistrationSettingFunctions.GetAvailableSettingsByParams(settingType, businessUnit, documentKind, department);
      }
    }
    /// <redirect project="Sungero.Docflow.Shared" type="Sungero.Docflow.Shared.RegistrationSettingFunctions" />
    internal static  global::Sungero.Docflow.IRegistrationSetting GetSettingByParamsIds(global::System.Collections.Generic.List<global::Sungero.Docflow.IRegistrationSetting> activeSettings, global::System.Nullable<global::Sungero.Core.Enumeration> settingType, global::System.Int64 businessUnitId, global::System.Int64 documentKindId, global::System.Int64 departmentId)
    {
      var __funcType = Sungero.Metadata.Services.AppliedTypesManager.Instance.Resolve("Sungero.Docflow.Shared.RegistrationSettingFunctions");
      if (__funcType != null)
      {    
        var __funcMethod = __funcType.GetMethod("GetSettingByParamsIds",
          System.Reflection.BindingFlags.Static | System.Reflection.BindingFlags.Public | System.Reflection.BindingFlags.NonPublic,
          null, new System.Type[] { typeof(global::System.Collections.Generic.List<global::Sungero.Docflow.IRegistrationSetting>), typeof(global::System.Nullable<global::Sungero.Core.Enumeration>), typeof(global::System.Int64), typeof(global::System.Int64), typeof(global::System.Int64) }, null);
        return (global::Sungero.Docflow.IRegistrationSetting)global::CommonLibrary.ReflectionExtensions.ReflectionInvoke(__funcMethod, null, new object[] { activeSettings, settingType, businessUnitId, documentKindId, departmentId });
      }
      else
      {
        return global::Sungero.Docflow.Shared.RegistrationSettingFunctions.GetSettingByParamsIds(activeSettings, settingType, businessUnitId, documentKindId, departmentId);
      }
    }

    internal static class Remote
    {
      /// <redirect project="Sungero.Docflow.Server" type="Sungero.Docflow.Server.RegistrationSettingFunctions" />
      internal static  global::System.Collections.Generic.List<global::Sungero.Docflow.IRegistrationSetting> GetDoubleSettings(global::Sungero.Docflow.IRegistrationSetting setting)
      {
        return global::Sungero.Domain.Shared.RemoteFunctionExecutor.ExecuteWithResult<global::System.Collections.Generic.List<global::Sungero.Docflow.IRegistrationSetting>>(
          global::System.Guid.Parse("ff9c10ff-2c62-43cd-8bcf-d6184359b5b6"),
          "GetDoubleSettings(global::Sungero.Docflow.IRegistrationSetting)"
      , setting);
      }

    }
  }
}

// ==================================================================
// RegistrationSettingClientPublicFunctions.g.cs
// ==================================================================

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sungero.Docflow.Client
{
  public class RegistrationSettingClientPublicFunctions : global::Sungero.Docflow.Client.IRegistrationSettingClientPublicFunctions
  {
  }
}

// ==================================================================
// RegistrationSettingActions.g.cs
// ==================================================================

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sungero.Docflow.Client
{
  public partial class RegistrationSettingActions : global::Sungero.CoreEntities.Client.DatabookEntryActions
  {
    private global::Sungero.Docflow.IRegistrationSetting _obj { get { return (global::Sungero.Docflow.IRegistrationSetting)this.Entity; } }
    public RegistrationSettingActions(global::Sungero.Docflow.IRegistrationSetting entity) : base(entity) { }
  }

  public partial class RegistrationSettingCollectionActions : global::Sungero.CoreEntities.Client.DatabookEntryCollectionActions
  {
    private global::System.Collections.Generic.IEnumerable<global::Sungero.Docflow.IRegistrationSetting> _objs
    {
      get { return global::System.Linq.Enumerable.Cast<global::Sungero.Docflow.IRegistrationSetting>(this.Entities); }
    }
  }

  public partial class RegistrationSettingCollectionBulkActions : global::Sungero.CoreEntities.Client.DatabookEntryCollectionBulkActions
  {
    private global::System.Collections.Generic.IEnumerable<global::System.Int64> _objIds
    {
      get { return this.EntityIds; }
    }
  }


  public partial class RegistrationSettingAnyChildEntityActions : global::Sungero.CoreEntities.Client.DatabookEntryAnyChildEntityActions
  {
  }

  public partial class RegistrationSettingAnyChildEntityCollectionActions : global::Sungero.CoreEntities.Client.DatabookEntryAnyChildEntityCollectionActions
  {
  }



}
