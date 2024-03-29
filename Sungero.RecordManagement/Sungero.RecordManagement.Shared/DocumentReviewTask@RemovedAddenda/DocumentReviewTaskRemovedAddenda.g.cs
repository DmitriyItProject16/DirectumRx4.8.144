
// ==================================================================
// DocumentReviewTaskRemovedAddendaState.g.cs
// ==================================================================

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sungero.RecordManagement.Shared
{
  public class DocumentReviewTaskRemovedAddendaState : 
    global::Sungero.Domain.Shared.ChildEntityState, global::Sungero.RecordManagement.IDocumentReviewTaskRemovedAddendaState
  {
    public DocumentReviewTaskRemovedAddendaState(global::Sungero.RecordManagement.IDocumentReviewTaskRemovedAddenda entity) : base(entity) { }

    public new global::Sungero.RecordManagement.IDocumentReviewTaskRemovedAddendaPropertyStates Properties
    {
      get { return (global::Sungero.RecordManagement.IDocumentReviewTaskRemovedAddendaPropertyStates)base.Properties; }
    }

    protected override global::Sungero.Domain.Shared.IEntityPropertyStates CreatePropertyStates(global::Sungero.Domain.Shared.IEntity entity)
    {
      return new global::Sungero.RecordManagement.Shared.DocumentReviewTaskRemovedAddendaPropertyStates(entity);
    }


  }


  public class DocumentReviewTaskRemovedAddendaPropertyStates : 
    global::Sungero.Domain.Shared.ChildEntityPropertyStates, global::Sungero.RecordManagement.IDocumentReviewTaskRemovedAddendaPropertyStates
  {
            public global::Sungero.Domain.Shared.IPropertyState<global::Sungero.RecordManagement.IDocumentReviewTask> DocumentReviewTask 
            {
              get { return this.InternalDocumentReviewTask; }
            }

            protected virtual global::Sungero.Domain.Shared.IPropertyState<global::Sungero.RecordManagement.IDocumentReviewTask> InternalDocumentReviewTask
            {
              get { return this.GetPropertyState<global::Sungero.RecordManagement.IDocumentReviewTask>("DocumentReviewTask"); }
            }
            public global::Sungero.Domain.Shared.IPropertyState<global::System.Int64?> AddendumId 
            {
              get { return this.GetPropertyState<global::System.Int64?>("AddendumId"); }
            }


    protected internal DocumentReviewTaskRemovedAddendaPropertyStates(global::Sungero.Domain.Shared.IEntity entity) : base(entity) { }
  }

  public class DocumentReviewTaskRemovedAddendaCollectionPropertyState<T> :
    global::Sungero.Domain.Shared.ChildEntityCollectionPropertyState<T>, global::Sungero.RecordManagement.IDocumentReviewTaskRemovedAddendaCollectionPropertyState<T>
    where T : global::Sungero.RecordManagement.IDocumentReviewTaskRemovedAddenda
  {
    public new global::Sungero.RecordManagement.IDocumentReviewTaskRemovedAddendaCollectionPropertyStates Properties
    {
      get { return (global::Sungero.RecordManagement.IDocumentReviewTaskRemovedAddendaCollectionPropertyStates)base.Properties; }
    }

    protected override global::Sungero.Domain.Shared.IChildEntityCollectionPropertyStates CreatePropertyStates()
    {
      return new global::Sungero.RecordManagement.Shared.DocumentReviewTaskRemovedAddendaCollectionPropertyStates(this.ChildEntityMetadata);
    }

    protected internal DocumentReviewTaskRemovedAddendaCollectionPropertyState(global::Sungero.Domain.Shared.IEntity entity, string propertyName) : base(entity, propertyName) { }
  }

  public class DocumentReviewTaskRemovedAddendaCollectionPropertyStates :
    global::Sungero.Domain.Shared.ChildEntityCollectionPropertyStates, global::Sungero.RecordManagement.IDocumentReviewTaskRemovedAddendaCollectionPropertyStates
  {
        public global::Sungero.Domain.Shared.IChildPropertySummaryState DocumentReviewTask
        {
          get { return this.GetChildPropertySummaryState("DocumentReviewTask"); }
        }
        public global::Sungero.Domain.Shared.IChildPropertySummaryState AddendumId
        {
          get { return this.GetChildPropertySummaryState("AddendumId"); }
        }


    protected internal DocumentReviewTaskRemovedAddendaCollectionPropertyStates(global::Sungero.Metadata.EntityMetadata childEntityMetadata) : base(childEntityMetadata) { }
  }
}

// ==================================================================
// DocumentReviewTaskRemovedAddendaInfo.g.cs
// ==================================================================

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sungero.RecordManagement.Shared
{
  public class DocumentReviewTaskRemovedAddendaInfo : 
    global::Sungero.Domain.Shared.ChildEntityInfo, global::Sungero.RecordManagement.IDocumentReviewTaskRemovedAddendaInfo
  {
    public DocumentReviewTaskRemovedAddendaInfo(global::System.Type entityType) : base(entityType) { }

    public new global::Sungero.RecordManagement.IDocumentReviewTaskRemovedAddendaPropertiesInfo Properties
    {
      get { return (global::Sungero.RecordManagement.IDocumentReviewTaskRemovedAddendaPropertiesInfo)base.Properties; }
    }

    protected override global::Sungero.Domain.Shared.IEntityPropertiesInfo CreateEntityPropertiesInfo(global::System.Type entityType)
    {
      return new global::Sungero.RecordManagement.Shared.DocumentReviewTaskRemovedAddendaPropertiesInfo(entityType);
    }

  }

  public class DocumentReviewTaskRemovedAddendaPropertiesInfo : 
    global::Sungero.Domain.Shared.ChildEntityPropertiesInfo, global::Sungero.RecordManagement.IDocumentReviewTaskRemovedAddendaPropertiesInfo
  {
        public global::Sungero.Domain.Shared.INavigationPropertyInfo<global::Sungero.RecordManagement.IDocumentReviewTaskInfo, global::Sungero.RecordManagement.IDocumentReviewTask> DocumentReviewTask 
        {
          get
          {
             var propertyMetadata = this.GetPropertyMetadata<global::Sungero.Metadata.NavigationPropertyMetadata>("DocumentReviewTask");
             return new global::Sungero.Domain.Shared.NavigationPropertyInfo<global::Sungero.RecordManagement.IDocumentReviewTaskInfo, global::Sungero.RecordManagement.IDocumentReviewTask>(propertyMetadata);
          }
        }
        public global::Sungero.Domain.Shared.ILongIntegerPropertyInfo AddendumId 
        {
          get
          {
             var propertyMetadata = this.GetPropertyMetadata<global::Sungero.Metadata.LongIntegerPropertyMetadata>("AddendumId");
             return new global::Sungero.Domain.Shared.LongIntegerPropertyInfo(propertyMetadata);
          }
        }


    protected internal DocumentReviewTaskRemovedAddendaPropertiesInfo(global::System.Type entityType) : base(entityType) { }
  }

}
