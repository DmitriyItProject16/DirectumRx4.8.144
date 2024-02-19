
// ==================================================================
// RepackingSessionNewDocuments.g.cs
// ==================================================================

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sungero.SmartProcessing.Server
{


  public class RepackingSessionNewDocuments :
    global::Sungero.Domain.ChildEntity, global::Sungero.SmartProcessing.IRepackingSessionNewDocuments
  {
    public static new readonly global::System.Guid ClassTypeGuid = global::System.Guid.Parse("ea612a72-eaf6-4cf4-8190-8dafb657a0a8");

    public override global::System.Guid TypeGuid
    {
      get { return global::Sungero.SmartProcessing.Server.RepackingSessionNewDocuments.ClassTypeGuid; }
    }

    public override string TypeName
    {
      get { return "Sungero.SmartProcessing.IRepackingSessionNewDocuments, Sungero.Domain.Interfaces"; }
    }

    public new virtual global::Sungero.SmartProcessing.IRepackingSessionNewDocumentsState State
    {
      get { return (global::Sungero.SmartProcessing.IRepackingSessionNewDocumentsState)base.State; }
    }

    protected override global::Sungero.Domain.Shared.IEntityState CreateState()
    {
      return new global::Sungero.SmartProcessing.Shared.RepackingSessionNewDocumentsState(this);
    }

    public new virtual global::Sungero.SmartProcessing.IRepackingSessionNewDocumentsInfo Info
    {
      get { return (global::Sungero.SmartProcessing.IRepackingSessionNewDocumentsInfo)base.Info; }
    }


    public global::Sungero.SmartProcessing.IRepackingSession RepackingSession { get; set; }

    public override global::Sungero.Domain.Shared.IEntity RootEntity
    {
      get { return this.RepackingSession; }
      set { this.RepackingSession = (global::Sungero.SmartProcessing.IRepackingSession)value; }
    }

    protected override object CreateSharedHandlers() {
      return new global::Sungero.SmartProcessing.RepackingSessionNewDocumentsSharedHandlers(this);
    }

    private global::System.Int64? _DocumentId;
    public virtual global::System.Int64? DocumentId
    {
      get
      {
        return this._DocumentId;
      }

      set
      {
        this.SetPropertyValue("DocumentId", this._DocumentId, value, (propertyValue) => { this._DocumentId = propertyValue; }, this.DocumentIdChangedHandler);
      }
    }










    #region Framework events

    protected void DocumentIdChangedHandler()
    {
      var args = new global::Sungero.Domain.Shared.LongIntegerPropertyChangedEventArgs(this.State.Properties.DocumentId, this.DocumentId, this);
     ((global::Sungero.SmartProcessing.IRepackingSessionNewDocumentsSharedHandlers)this.SharedHandlers).NewDocumentsDocumentIdChanged(args);
    }



    #endregion


    public RepackingSessionNewDocuments()
    {
    }

  }
}

// ==================================================================
// RepackingSessionNewDocumentsHandlers.g.cs
// ==================================================================

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sungero.SmartProcessing
{

}

// ==================================================================
// RepackingSessionNewDocumentsEventArgs.g.cs
// ==================================================================

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sungero.SmartProcessing.Server
{
}
