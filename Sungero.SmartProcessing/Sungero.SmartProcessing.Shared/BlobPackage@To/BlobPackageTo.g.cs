
// ==================================================================
// BlobPackageToState.g.cs
// ==================================================================

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sungero.SmartProcessing.Shared
{
  public class BlobPackageToState : 
    global::Sungero.Domain.Shared.ChildEntityState, global::Sungero.SmartProcessing.IBlobPackageToState
  {
    public BlobPackageToState(global::Sungero.SmartProcessing.IBlobPackageTo entity) : base(entity) { }

    public new global::Sungero.SmartProcessing.IBlobPackageToPropertyStates Properties
    {
      get { return (global::Sungero.SmartProcessing.IBlobPackageToPropertyStates)base.Properties; }
    }

    protected override global::Sungero.Domain.Shared.IEntityPropertyStates CreatePropertyStates(global::Sungero.Domain.Shared.IEntity entity)
    {
      return new global::Sungero.SmartProcessing.Shared.BlobPackageToPropertyStates(entity);
    }


  }


  public class BlobPackageToPropertyStates : 
    global::Sungero.Domain.Shared.ChildEntityPropertyStates, global::Sungero.SmartProcessing.IBlobPackageToPropertyStates
  {
            public global::Sungero.Domain.Shared.IPropertyState<global::Sungero.SmartProcessing.IBlobPackage> BlobPackage 
            {
              get { return this.InternalBlobPackage; }
            }

            protected virtual global::Sungero.Domain.Shared.IPropertyState<global::Sungero.SmartProcessing.IBlobPackage> InternalBlobPackage
            {
              get { return this.GetPropertyState<global::Sungero.SmartProcessing.IBlobPackage>("BlobPackage"); }
            }
            public global::Sungero.Domain.Shared.IPropertyState<global::System.String> Name 
            {
              get { return this.GetPropertyState<global::System.String>("Name"); }
            }
            public global::Sungero.Domain.Shared.IPropertyState<global::System.String> Address 
            {
              get { return this.GetPropertyState<global::System.String>("Address"); }
            }


    protected internal BlobPackageToPropertyStates(global::Sungero.Domain.Shared.IEntity entity) : base(entity) { }
  }

  public class BlobPackageToCollectionPropertyState<T> :
    global::Sungero.Domain.Shared.ChildEntityCollectionPropertyState<T>, global::Sungero.SmartProcessing.IBlobPackageToCollectionPropertyState<T>
    where T : global::Sungero.SmartProcessing.IBlobPackageTo
  {
    public new global::Sungero.SmartProcessing.IBlobPackageToCollectionPropertyStates Properties
    {
      get { return (global::Sungero.SmartProcessing.IBlobPackageToCollectionPropertyStates)base.Properties; }
    }

    protected override global::Sungero.Domain.Shared.IChildEntityCollectionPropertyStates CreatePropertyStates()
    {
      return new global::Sungero.SmartProcessing.Shared.BlobPackageToCollectionPropertyStates(this.ChildEntityMetadata);
    }

    protected internal BlobPackageToCollectionPropertyState(global::Sungero.Domain.Shared.IEntity entity, string propertyName) : base(entity, propertyName) { }
  }

  public class BlobPackageToCollectionPropertyStates :
    global::Sungero.Domain.Shared.ChildEntityCollectionPropertyStates, global::Sungero.SmartProcessing.IBlobPackageToCollectionPropertyStates
  {
        public global::Sungero.Domain.Shared.IChildPropertySummaryState BlobPackage
        {
          get { return this.GetChildPropertySummaryState("BlobPackage"); }
        }
        public global::Sungero.Domain.Shared.IChildPropertySummaryState Name
        {
          get { return this.GetChildPropertySummaryState("Name"); }
        }
        public global::Sungero.Domain.Shared.IChildPropertySummaryState Address
        {
          get { return this.GetChildPropertySummaryState("Address"); }
        }


    protected internal BlobPackageToCollectionPropertyStates(global::Sungero.Metadata.EntityMetadata childEntityMetadata) : base(childEntityMetadata) { }
  }
}

// ==================================================================
// BlobPackageToInfo.g.cs
// ==================================================================

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sungero.SmartProcessing.Shared
{
  public class BlobPackageToInfo : 
    global::Sungero.Domain.Shared.ChildEntityInfo, global::Sungero.SmartProcessing.IBlobPackageToInfo
  {
    public BlobPackageToInfo(global::System.Type entityType) : base(entityType) { }

    public new global::Sungero.SmartProcessing.IBlobPackageToPropertiesInfo Properties
    {
      get { return (global::Sungero.SmartProcessing.IBlobPackageToPropertiesInfo)base.Properties; }
    }

    protected override global::Sungero.Domain.Shared.IEntityPropertiesInfo CreateEntityPropertiesInfo(global::System.Type entityType)
    {
      return new global::Sungero.SmartProcessing.Shared.BlobPackageToPropertiesInfo(entityType);
    }

  }

  public class BlobPackageToPropertiesInfo : 
    global::Sungero.Domain.Shared.ChildEntityPropertiesInfo, global::Sungero.SmartProcessing.IBlobPackageToPropertiesInfo
  {
        public global::Sungero.Domain.Shared.INavigationPropertyInfo<global::Sungero.SmartProcessing.IBlobPackageInfo, global::Sungero.SmartProcessing.IBlobPackage> BlobPackage 
        {
          get
          {
             var propertyMetadata = this.GetPropertyMetadata<global::Sungero.Metadata.NavigationPropertyMetadata>("BlobPackage");
             return new global::Sungero.Domain.Shared.NavigationPropertyInfo<global::Sungero.SmartProcessing.IBlobPackageInfo, global::Sungero.SmartProcessing.IBlobPackage>(propertyMetadata);
          }
        }
        public global::Sungero.Domain.Shared.IStringPropertyInfo Name 
        {
          get
          {
             var propertyMetadata = this.GetPropertyMetadata<global::Sungero.Metadata.StringPropertyMetadata>("Name");
             return new global::Sungero.Domain.Shared.StringPropertyInfo(propertyMetadata);
          }
        }
        public global::Sungero.Domain.Shared.IStringPropertyInfo Address 
        {
          get
          {
             var propertyMetadata = this.GetPropertyMetadata<global::Sungero.Metadata.StringPropertyMetadata>("Address");
             return new global::Sungero.Domain.Shared.StringPropertyInfo(propertyMetadata);
          }
        }


    protected internal BlobPackageToPropertiesInfo(global::System.Type entityType) : base(entityType) { }
  }

}