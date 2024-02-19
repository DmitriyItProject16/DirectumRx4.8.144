
// ==================================================================
// ApprovalRoleState.g.cs
// ==================================================================

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sungero.Docflow.Shared
{
  public class ApprovalRoleState : 
    global::Sungero.Docflow.Shared.ApprovalRoleBaseState, global::Sungero.Docflow.IApprovalRoleState
  {
    public ApprovalRoleState(global::Sungero.Docflow.IApprovalRole entity) : base(entity) { }

    public new global::Sungero.Docflow.IApprovalRolePropertyStates Properties
    {
      get { return (global::Sungero.Docflow.IApprovalRolePropertyStates)base.Properties; }
    }

    protected override global::Sungero.Domain.Shared.IEntityPropertyStates CreatePropertyStates(global::Sungero.Domain.Shared.IEntity entity)
    {
      return new global::Sungero.Docflow.Shared.ApprovalRolePropertyStates(entity);
    }


    public new global::Sungero.Docflow.IApprovalRoleControlStates Controls
    {
      get { return (global::Sungero.Docflow.IApprovalRoleControlStates)base.Controls; }
    }

    protected override global::Sungero.Domain.Shared.IEntityControlStates CreateControlStates(global::Sungero.Domain.Shared.IEntity entity)
    {
      return new global::Sungero.Docflow.Shared.ApprovalRoleControlStates(entity);
    }

    public new global::Sungero.Docflow.IApprovalRolePageStates Pages
    {
      get { return (global::Sungero.Docflow.IApprovalRolePageStates)base.Pages; }
    }

    protected override global::Sungero.Domain.Shared.IEntityPageStates CreatePageStates(global::Sungero.Domain.Shared.IEntity entity)
    {
      return new global::Sungero.Docflow.Shared.ApprovalRolePageStates(entity);
    }

  }


  public class ApprovalRoleControlStates : 
    global::Sungero.Docflow.Shared.ApprovalRoleBaseControlStates, global::Sungero.Docflow.IApprovalRoleControlStates
  {

    protected internal ApprovalRoleControlStates(global::Sungero.Domain.Shared.IEntity entity) : base(entity) { }
  }
  public class ApprovalRolePageStates : 
    global::Sungero.Docflow.Shared.ApprovalRoleBasePageStates, global::Sungero.Docflow.IApprovalRolePageStates
  {

    protected internal ApprovalRolePageStates(global::Sungero.Domain.Shared.IEntity entity) : base(entity) { }
  }

  public class ApprovalRolePropertyStates : 
    global::Sungero.Docflow.Shared.ApprovalRoleBasePropertyStates, global::Sungero.Docflow.IApprovalRolePropertyStates
  {

    protected internal ApprovalRolePropertyStates(global::Sungero.Domain.Shared.IEntity entity) : base(entity) { }
  }

}

// ==================================================================
// ApprovalRoleInfo.g.cs
// ==================================================================

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sungero.Docflow.Shared
{
  public class ApprovalRoleInfo : 
    global::Sungero.Docflow.Shared.ApprovalRoleBaseInfo, global::Sungero.Docflow.IApprovalRoleInfo
  {
    public ApprovalRoleInfo(global::System.Type entityType) : base(entityType) { }

    public new global::Sungero.Docflow.IApprovalRolePropertiesInfo Properties
    {
      get { return (global::Sungero.Docflow.IApprovalRolePropertiesInfo)base.Properties; }
    }

    protected override global::Sungero.Domain.Shared.IEntityPropertiesInfo CreateEntityPropertiesInfo(global::System.Type entityType)
    {
      return new global::Sungero.Docflow.Shared.ApprovalRolePropertiesInfo(entityType);
    }

  }

  public class ApprovalRolePropertiesInfo : 
    global::Sungero.Docflow.Shared.ApprovalRoleBasePropertiesInfo, global::Sungero.Docflow.IApprovalRolePropertiesInfo
  {

    protected internal ApprovalRolePropertiesInfo(global::System.Type entityType) : base(entityType) { }
  }

}

// ==================================================================
// ApprovalRoleHandlers.g.cs
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
  public partial class ApprovalRoleSharedHandlers : global::Sungero.Docflow.ApprovalRoleBaseSharedHandlers, IApprovalRoleSharedHandlers
  {
    private global::Sungero.Docflow.IApprovalRole _obj
    {
      get { return (global::Sungero.Docflow.IApprovalRole)this.Entity; }
    }


    public ApprovalRoleSharedHandlers(global::Sungero.Docflow.IApprovalRole entity) : base(entity)
    {
    }
  }

}

// ==================================================================
// ApprovalRoleResources.g.cs
// ==================================================================

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sungero.Docflow.Shared.ApprovalRole
{
  /// <summary>
  /// Represents ApprovalRole resources.
  /// </summary>
  public class ApprovalRoleResources : global::Sungero.Docflow.Shared.ApprovalRoleBase.ApprovalRoleBaseResources, global::Sungero.Docflow.ApprovalRole.IApprovalRoleResources
  {
  }
}

// ==================================================================
// ApprovalRoleSharedFunctions.g.cs
// ==================================================================

namespace Sungero.Docflow.Shared
{
  public partial class ApprovalRoleFunctions : global::Sungero.Docflow.Shared.ApprovalRoleBaseFunctions
  {
    private global::Sungero.Docflow.IApprovalRole _obj
    {
      get { return (global::Sungero.Docflow.IApprovalRole)this.Entity; }
    }

    public ApprovalRoleFunctions(global::Sungero.Docflow.IApprovalRole entity) : base(entity) { }
  }
}

// ==================================================================
// ApprovalRoleFunctions.g.cs
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
  internal static class ApprovalRole
  {
  }
}

// ==================================================================
// ApprovalRoleFilterState.g.cs
// ==================================================================

namespace Sungero.Docflow.Shared.ApprovalRole
{

  public class ApprovalRoleFilterInfo : global::Sungero.Docflow.Shared.ApprovalRoleBase.ApprovalRoleBaseFilterInfo,
    global::Sungero.Docflow.IApprovalRoleFilterInfo
  {
  }

  public class ApprovalRoleFilterState : global::Sungero.Docflow.Shared.ApprovalRoleBase.ApprovalRoleBaseFilterState,
    global::Sungero.Docflow.IApprovalRoleFilterState
  {



    public new Sungero.Docflow.IApprovalRoleFilterInfo Info
    {
      get
      {
        return (Sungero.Docflow.IApprovalRoleFilterInfo) base.Info;
      }
    }
    protected override global::Sungero.Domain.Shared.IFilterInfo CreateFilterInfo()
    {
      return new Sungero.Docflow.Shared.ApprovalRole.ApprovalRoleFilterInfo();
    }

  }
}

// ==================================================================
// ApprovalRoleSharedPublicFunctions.g.cs
// ==================================================================

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sungero.Docflow.Shared
{
  public class ApprovalRoleSharedPublicFunctions : global::Sungero.Docflow.Shared.IApprovalRoleSharedPublicFunctions
  {
  }
}
