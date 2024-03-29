
// ==================================================================
// OutgoingDocumentBaseEventArgs.g.cs
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
  public class OutgoingDocumentBaseCorrespondentValueInputEventArgs : global::Sungero.Presentation.ValueInputEventArgs<global::Sungero.Parties.ICounterparty>
  {
    public OutgoingDocumentBaseCorrespondentValueInputEventArgs(global::Sungero.Parties.ICounterparty oldValue, global::Sungero.Parties.ICounterparty newValue, global::Sungero.Domain.Shared.IEntity entity, global::Sungero.Domain.Shared.IPropertyInfo propertyInfo): base(oldValue, newValue, entity, propertyInfo) { }
  }

  public class OutgoingDocumentBaseInResponseToValueInputEventArgs : global::Sungero.Presentation.ValueInputEventArgs<global::Sungero.Docflow.IIncomingDocumentBase>
  {
    public OutgoingDocumentBaseInResponseToValueInputEventArgs(global::Sungero.Docflow.IIncomingDocumentBase oldValue, global::Sungero.Docflow.IIncomingDocumentBase newValue, global::Sungero.Domain.Shared.IEntity entity, global::Sungero.Domain.Shared.IPropertyInfo propertyInfo): base(oldValue, newValue, entity, propertyInfo) { }
  }

  public class OutgoingDocumentBaseAddresseeValueInputEventArgs : global::Sungero.Presentation.ValueInputEventArgs<global::Sungero.Parties.IContact>
  {
    public OutgoingDocumentBaseAddresseeValueInputEventArgs(global::Sungero.Parties.IContact oldValue, global::Sungero.Parties.IContact newValue, global::Sungero.Domain.Shared.IEntity entity, global::Sungero.Domain.Shared.IPropertyInfo propertyInfo): base(oldValue, newValue, entity, propertyInfo) { }
  }






}

// ==================================================================
// OutgoingDocumentBaseHandlers.g.cs
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

  public partial class OutgoingDocumentBaseFilteringClientHandler
    : global::Sungero.Docflow.OfficialDocumentFilteringClientHandler
  {
    private global::Sungero.Docflow.IOutgoingDocumentBaseFilterState _filter
    {
      get
      {
        return (Sungero.Docflow.IOutgoingDocumentBaseFilterState)this.Filter;
      }
    }

    public OutgoingDocumentBaseFilteringClientHandler(global::Sungero.Docflow.IOutgoingDocumentBaseFilterState filter)
    : base(filter)
    {
    }

    protected OutgoingDocumentBaseFilteringClientHandler()
    {
    }

    public override void ValidateFilterPanel(global::Sungero.Domain.Client.ValidateFilterPanelEventArgs e)
    {
      base.ValidateFilterPanel(e);
    }
  }


  public partial class OutgoingDocumentBaseClientHandlers : global::Sungero.Docflow.OfficialDocumentClientHandlers
  {
    private global::Sungero.Docflow.IOutgoingDocumentBase _obj
    {
      get { return (global::Sungero.Docflow.IOutgoingDocumentBase)this.Entity; }
    }

    public virtual void CorrespondentValueInput(global::Sungero.Docflow.Client.OutgoingDocumentBaseCorrespondentValueInputEventArgs e) { }


    public virtual void InResponseToValueInput(global::Sungero.Docflow.Client.OutgoingDocumentBaseInResponseToValueInputEventArgs e) { }


    public virtual void AddresseeValueInput(global::Sungero.Docflow.Client.OutgoingDocumentBaseAddresseeValueInputEventArgs e) { }


    public virtual void IsManyAddresseesValueInput(global::Sungero.Presentation.BooleanValueInputEventArgs e) { }



    public virtual void DistributionCorrespondentValueInput(global::Sungero.Presentation.StringValueInputEventArgs e) { }


    public virtual void SentDateValueInput(global::Sungero.Presentation.DateTimeValueInputEventArgs e) { }



    public OutgoingDocumentBaseClientHandlers(global::Sungero.Docflow.IOutgoingDocumentBase entity) : base(entity)
    {
    }
  }

  public partial class OutgoingDocumentBaseAddresseesClientHandlers : global::Sungero.Domain.Shared.ChildEntityClientHandlers
  {
    private global::Sungero.Docflow.IOutgoingDocumentBaseAddressees _obj
    {
      get { return (global::Sungero.Docflow.IOutgoingDocumentBaseAddressees)this.Entity; }
    }
    public virtual void AddresseesCorrespondentValueInput(global::Sungero.Docflow.Client.OutgoingDocumentBaseAddresseesCorrespondentValueInputEventArgs e) { }


    public virtual void AddresseesAddresseeValueInput(global::Sungero.Docflow.Client.OutgoingDocumentBaseAddresseesAddresseeValueInputEventArgs e) { }


    public virtual void AddresseesDeliveryMethodValueInput(global::Sungero.Docflow.Client.OutgoingDocumentBaseAddresseesDeliveryMethodValueInputEventArgs e) { }



    public virtual void AddresseesSentDateValueInput(global::Sungero.Presentation.DateTimeValueInputEventArgs e) { }



    public OutgoingDocumentBaseAddresseesClientHandlers(global::Sungero.Docflow.IOutgoingDocumentBaseAddressees entity) : base(entity)
    {
    }
  }

}

// ==================================================================
// OutgoingDocumentBaseClientFunctions.g.cs
// ==================================================================

namespace Sungero.Docflow.Client
{
  public partial class OutgoingDocumentBaseFunctions : global::Sungero.Docflow.Client.OfficialDocumentFunctions
  {
    private global::Sungero.Docflow.IOutgoingDocumentBase _obj
    {
      get { return (global::Sungero.Docflow.IOutgoingDocumentBase)this.Entity; }
    }

    public OutgoingDocumentBaseFunctions(global::Sungero.Docflow.IOutgoingDocumentBase entity) : base(entity) { }
  }
}

// ==================================================================
// OutgoingDocumentBaseFunctions.g.cs
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
  internal static class OutgoingDocumentBase
  {
    /// <redirect project="Sungero.Docflow.Client" type="Sungero.Docflow.Client.OutgoingDocumentBaseFunctions" />
    internal static  void ShowSelectEnvelopeFormatDialog(global::System.Collections.Generic.List<global::Sungero.Docflow.IOutgoingDocumentBase> outgoingDocuments, global::System.Collections.Generic.List<global::Sungero.Docflow.IContractualDocumentBase> contractualDocuments)
    {
      var __funcType = Sungero.Metadata.Services.AppliedTypesManager.Instance.Resolve("Sungero.Docflow.Client.OutgoingDocumentBaseFunctions");
      if (__funcType != null)
      {    
        var __funcMethod = __funcType.GetMethod("ShowSelectEnvelopeFormatDialog",
          System.Reflection.BindingFlags.Static | System.Reflection.BindingFlags.Public | System.Reflection.BindingFlags.NonPublic,
          null, new System.Type[] { typeof(global::System.Collections.Generic.List<global::Sungero.Docflow.IOutgoingDocumentBase>), typeof(global::System.Collections.Generic.List<global::Sungero.Docflow.IContractualDocumentBase>) }, null);
    global::CommonLibrary.ReflectionExtensions.ReflectionInvoke(__funcMethod, null, new object[] { outgoingDocuments, contractualDocuments });
      }
      else
      {
    global::Sungero.Docflow.Client.OutgoingDocumentBaseFunctions.ShowSelectEnvelopeFormatDialog(outgoingDocuments, contractualDocuments);
      }
    }
    /// <redirect project="Sungero.Docflow.Client" type="Sungero.Docflow.Client.OutgoingDocumentBaseFunctions" />
    internal static  void ShowSelectEnvelopeFormatDialog(global::System.Collections.Generic.List<global::Sungero.Docflow.IOutgoingDocumentBase> outgoingDocuments, global::System.Collections.Generic.List<global::Sungero.Docflow.IContractualDocumentBase> contractualDocuments, global::System.Collections.Generic.List<global::Sungero.Docflow.IAccountingDocumentBase> accountingDocuments)
    {
      var __funcType = Sungero.Metadata.Services.AppliedTypesManager.Instance.Resolve("Sungero.Docflow.Client.OutgoingDocumentBaseFunctions");
      if (__funcType != null)
      {    
        var __funcMethod = __funcType.GetMethod("ShowSelectEnvelopeFormatDialog",
          System.Reflection.BindingFlags.Static | System.Reflection.BindingFlags.Public | System.Reflection.BindingFlags.NonPublic,
          null, new System.Type[] { typeof(global::System.Collections.Generic.List<global::Sungero.Docflow.IOutgoingDocumentBase>), typeof(global::System.Collections.Generic.List<global::Sungero.Docflow.IContractualDocumentBase>), typeof(global::System.Collections.Generic.List<global::Sungero.Docflow.IAccountingDocumentBase>) }, null);
    global::CommonLibrary.ReflectionExtensions.ReflectionInvoke(__funcMethod, null, new object[] { outgoingDocuments, contractualDocuments, accountingDocuments });
      }
      else
      {
    global::Sungero.Docflow.Client.OutgoingDocumentBaseFunctions.ShowSelectEnvelopeFormatDialog(outgoingDocuments, contractualDocuments, accountingDocuments);
      }
    }
    /// <redirect project="Sungero.Docflow.Client" type="Sungero.Docflow.Client.OutgoingDocumentBaseFunctions" />
    internal static  global::System.String GetTextToMarkDocumentAsObsolete(global::Sungero.Docflow.IOutgoingDocumentBase outgoingDocumentBase)
    {
      var __functions = ((global::Sungero.Domain.Shared.IEntityFunctions)outgoingDocumentBase).FunctionsContainer.ClientFunctions;
      var __funcMethod = __functions.GetType().GetMethod("GetTextToMarkDocumentAsObsolete", new System.Type[] {  });
      return (global::System.String)global::CommonLibrary.ReflectionExtensions.ReflectionInvoke(__funcMethod, __functions, new object[] {  });
    }
    /// <redirect project="Sungero.Docflow.Client" type="Sungero.Docflow.Client.OutgoingDocumentBaseFunctions" />
    internal static  global::System.Boolean DisableAddresseesOnRegistration(global::Sungero.Docflow.IOutgoingDocumentBase outgoingDocumentBase, Sungero.Domain.Shared.BaseEventArgs e)
    {
      var __functions = ((global::Sungero.Domain.Shared.IEntityFunctions)outgoingDocumentBase).FunctionsContainer.ClientFunctions;
      var __funcMethod = __functions.GetType().GetMethod("DisableAddresseesOnRegistration", new System.Type[] { typeof(Sungero.Domain.Shared.BaseEventArgs) });
      return (global::System.Boolean)global::CommonLibrary.ReflectionExtensions.ReflectionInvoke(__funcMethod, __functions, new object[] { e });
    }

    /// <redirect project="Sungero.Docflow.Shared" type="Sungero.Docflow.Shared.OutgoingDocumentBaseFunctions" />
    internal static  void ChangeRegistrationPaneVisibility(global::Sungero.Docflow.IOutgoingDocumentBase outgoingDocumentBase, global::System.Boolean needShow, global::System.Boolean repeatRegister)
    {
      var __functions = ((global::Sungero.Domain.Shared.IEntityFunctions)outgoingDocumentBase).FunctionsContainer.SharedFunctions;
      var __funcMethod = __functions.GetType().GetMethod("ChangeRegistrationPaneVisibility", new System.Type[] { typeof(global::System.Boolean), typeof(global::System.Boolean) });
    global::CommonLibrary.ReflectionExtensions.ReflectionInvoke(__funcMethod, __functions, new object[] { needShow, repeatRegister });
    }
    /// <redirect project="Sungero.Docflow.Shared" type="Sungero.Docflow.Shared.OutgoingDocumentBaseFunctions" />
    internal static  void AddRelatedDocumentsToAttachmentGroup(global::Sungero.Docflow.IOutgoingDocumentBase outgoingDocumentBase, Sungero.Workflow.Interfaces.IWorkflowEntityAttachmentGroup group)
    {
      var __functions = ((global::Sungero.Domain.Shared.IEntityFunctions)outgoingDocumentBase).FunctionsContainer.SharedFunctions;
      var __funcMethod = __functions.GetType().GetMethod("AddRelatedDocumentsToAttachmentGroup", new System.Type[] { typeof(Sungero.Workflow.Interfaces.IWorkflowEntityAttachmentGroup) });
    global::CommonLibrary.ReflectionExtensions.ReflectionInvoke(__funcMethod, __functions, new object[] { group });
    }
    /// <redirect project="Sungero.Docflow.Shared" type="Sungero.Docflow.Shared.OutgoingDocumentBaseFunctions" />
    internal static  global::System.Collections.Generic.List<global::Sungero.Parties.ICounterparty> GetCounterparties(global::Sungero.Docflow.IOutgoingDocumentBase outgoingDocumentBase)
    {
      var __functions = ((global::Sungero.Domain.Shared.IEntityFunctions)outgoingDocumentBase).FunctionsContainer.SharedFunctions;
      var __funcMethod = __functions.GetType().GetMethod("GetCounterparties", new System.Type[] {  });
      return (global::System.Collections.Generic.List<global::Sungero.Parties.ICounterparty>)global::CommonLibrary.ReflectionExtensions.ReflectionInvoke(__funcMethod, __functions, new object[] {  });
    }
    /// <redirect project="Sungero.Docflow.Shared" type="Sungero.Docflow.Shared.OutgoingDocumentBaseFunctions" />
    internal static  global::Sungero.Company.IEmployee GetDocumentResponsibleEmployee(global::Sungero.Docflow.IOutgoingDocumentBase outgoingDocumentBase)
    {
      var __functions = ((global::Sungero.Domain.Shared.IEntityFunctions)outgoingDocumentBase).FunctionsContainer.SharedFunctions;
      var __funcMethod = __functions.GetType().GetMethod("GetDocumentResponsibleEmployee", new System.Type[] {  });
      return (global::Sungero.Company.IEmployee)global::CommonLibrary.ReflectionExtensions.ReflectionInvoke(__funcMethod, __functions, new object[] {  });
    }
    /// <redirect project="Sungero.Docflow.Shared" type="Sungero.Docflow.Shared.OutgoingDocumentBaseFunctions" />
    internal static  void ClearAndFillFirstAddressee(global::Sungero.Docflow.IOutgoingDocumentBase outgoingDocumentBase)
    {
      var __functions = ((global::Sungero.Domain.Shared.IEntityFunctions)outgoingDocumentBase).FunctionsContainer.SharedFunctions;
      var __funcMethod = __functions.GetType().GetMethod("ClearAndFillFirstAddressee", new System.Type[] {  });
    global::CommonLibrary.ReflectionExtensions.ReflectionInvoke(__funcMethod, __functions, new object[] {  });
    }
    /// <redirect project="Sungero.Docflow.Shared" type="Sungero.Docflow.Shared.OutgoingDocumentBaseFunctions" />
    internal static  void ChangeCounterpartyPropertyAccess(global::Sungero.Docflow.IOutgoingDocumentBase outgoingDocumentBase, global::System.Boolean isEnabled, global::System.Boolean counterpartyCodeInNumber, global::System.Boolean enabledState)
    {
      var __functions = ((global::Sungero.Domain.Shared.IEntityFunctions)outgoingDocumentBase).FunctionsContainer.SharedFunctions;
      var __funcMethod = __functions.GetType().GetMethod("ChangeCounterpartyPropertyAccess", new System.Type[] { typeof(global::System.Boolean), typeof(global::System.Boolean), typeof(global::System.Boolean) });
    global::CommonLibrary.ReflectionExtensions.ReflectionInvoke(__funcMethod, __functions, new object[] { isEnabled, counterpartyCodeInNumber, enabledState });
    }
    /// <redirect project="Sungero.Docflow.Shared" type="Sungero.Docflow.Shared.OutgoingDocumentBaseFunctions" />
    internal static  global::System.String GetContactsInformation(global::Sungero.Docflow.IOutgoingDocumentBaseAddressees addresseesItem, global::Sungero.Docflow.IOutgoingDocumentBase document)
    {
      var __funcType = Sungero.Metadata.Services.AppliedTypesManager.Instance.Resolve("Sungero.Docflow.Shared.OutgoingDocumentBaseFunctions");
      if (__funcType != null)
      {    
        var __funcMethod = __funcType.GetMethod("GetContactsInformation",
          System.Reflection.BindingFlags.Static | System.Reflection.BindingFlags.Public | System.Reflection.BindingFlags.NonPublic,
          null, new System.Type[] { typeof(global::Sungero.Docflow.IOutgoingDocumentBaseAddressees), typeof(global::Sungero.Docflow.IOutgoingDocumentBase) }, null);
        return (global::System.String)global::CommonLibrary.ReflectionExtensions.ReflectionInvoke(__funcMethod, null, new object[] { addresseesItem, document });
      }
      else
      {
        return global::Sungero.Docflow.Shared.OutgoingDocumentBaseFunctions.GetContactsInformation(addresseesItem, document);
      }
    }
    /// <redirect project="Sungero.Docflow.Shared" type="Sungero.Docflow.Shared.OutgoingDocumentBaseFunctions" />
    internal static  void EnableRegistrationNumberAndDate(global::Sungero.Docflow.IOutgoingDocumentBase outgoingDocumentBase)
    {
      var __functions = ((global::Sungero.Domain.Shared.IEntityFunctions)outgoingDocumentBase).FunctionsContainer.SharedFunctions;
      var __funcMethod = __functions.GetType().GetMethod("EnableRegistrationNumberAndDate", new System.Type[] {  });
    global::CommonLibrary.ReflectionExtensions.ReflectionInvoke(__funcMethod, __functions, new object[] {  });
    }

    internal static class Remote
    {
      /// <redirect project="Sungero.Docflow.Server" type="Sungero.Docflow.Server.OutgoingDocumentBaseFunctions" />
      internal static  global::System.Boolean HasSpecifiedTypeRelations(global::Sungero.Docflow.IOutgoingDocumentBase outgoingDocumentBase)
      {
        return global::Sungero.Domain.Shared.RemoteFunctionExecutor.ExecuteWithResult<global::System.Boolean>(
          global::System.Guid.Parse("f5f104fb-52e4-422b-9de1-a36937d85a2d"),
          "HasSpecifiedTypeRelations(global::Sungero.Docflow.IOutgoingDocumentBase)"
          , outgoingDocumentBase);
      }

    }
  }
}

// ==================================================================
// OutgoingDocumentBaseClientPublicFunctions.g.cs
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
  public class OutgoingDocumentBaseClientPublicFunctions : global::Sungero.Docflow.Client.IOutgoingDocumentBaseClientPublicFunctions
  {
    public global::System.Boolean DisableAddresseesOnRegistration(global::Sungero.Docflow.IOutgoingDocumentBase outgoingDocumentBase, Sungero.Domain.Shared.BaseEventArgs e)
    {
      return global::Sungero.Docflow.Functions.OutgoingDocumentBase.DisableAddresseesOnRegistration(outgoingDocumentBase, e);
    }
  }
}

// ==================================================================
// OutgoingDocumentBaseActions.g.cs
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
  public partial class OutgoingDocumentBaseActions : global::Sungero.Docflow.Client.OfficialDocumentActions
  {
    private global::Sungero.Docflow.IOutgoingDocumentBase _obj { get { return (global::Sungero.Docflow.IOutgoingDocumentBase)this.Entity; } }
    public OutgoingDocumentBaseActions(global::Sungero.Docflow.IOutgoingDocumentBase entity) : base(entity) { }
  }

  public partial class OutgoingDocumentBaseCollectionActions : global::Sungero.Docflow.Client.OfficialDocumentCollectionActions
  {
    private global::System.Collections.Generic.IEnumerable<global::Sungero.Docflow.IOutgoingDocumentBase> _objs
    {
      get { return global::System.Linq.Enumerable.Cast<global::Sungero.Docflow.IOutgoingDocumentBase>(this.Entities); }
    }
  }

  public partial class OutgoingDocumentBaseCollectionBulkActions : global::Sungero.Docflow.Client.OfficialDocumentCollectionBulkActions
  {
    private global::System.Collections.Generic.IEnumerable<global::System.Int64> _objIds
    {
      get { return this.EntityIds; }
    }
  }


  public partial class OutgoingDocumentBaseAnyChildEntityActions : global::Sungero.Docflow.Client.OfficialDocumentAnyChildEntityActions
  {
  }

  public partial class OutgoingDocumentBaseAnyChildEntityCollectionActions : global::Sungero.Docflow.Client.OfficialDocumentAnyChildEntityCollectionActions
  {
  }



  public partial class OutgoingDocumentBaseAddresseesActions : global::Sungero.Domain.Client.ChildEntityActions
  {
    private global::Sungero.Docflow.IOutgoingDocumentBaseAddressees _obj { get { return (global::Sungero.Docflow.IOutgoingDocumentBaseAddressees)this.Entity; } }
    private global::Sungero.Domain.Shared.IChildEntityCollection<global::Sungero.Docflow.IOutgoingDocumentBaseAddressees> _all
    {
      get { return (global::Sungero.Domain.Shared.IChildEntityCollection<global::Sungero.Docflow.IOutgoingDocumentBaseAddressees>)this.AllEntities; }
    }
  }

  public partial class OutgoingDocumentBaseAddresseesCollectionActions : global::Sungero.Domain.Client.ChildEntityCollectionActions
  {
    private global::System.Collections.Generic.IEnumerable<global::Sungero.Docflow.IOutgoingDocumentBaseAddressees> _objs
    {
      get { return global::System.Linq.Enumerable.Cast<global::Sungero.Docflow.IOutgoingDocumentBaseAddressees>(this.Entities); }
    }
    private global::Sungero.Domain.Shared.IChildEntityCollection<global::Sungero.Docflow.IOutgoingDocumentBaseAddressees> _all
    {
      get { return (global::Sungero.Domain.Shared.IChildEntityCollection<global::Sungero.Docflow.IOutgoingDocumentBaseAddressees>)this.AllEntities; }
    }
  }



}
