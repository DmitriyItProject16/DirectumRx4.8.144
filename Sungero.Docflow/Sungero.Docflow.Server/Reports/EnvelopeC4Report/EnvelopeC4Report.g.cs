
// ==================================================================
// EnvelopeC4Report.g.cs
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
  public class EnvelopeC4Report : global::Sungero.Reporting.Server.Report, global::Sungero.Docflow.IEnvelopeC4Report
  {
    public static readonly new global::System.Guid ClassTypeGuid = new global::System.Guid("23aa7537-6bb5-4538-8caa-ba9f8fa409bc");

    protected override global::System.Guid ReportTypeId
    {
      get { return ClassTypeGuid; }
    }


    protected override void FillDataSources(global::FastReport.Report report)
    {
      base.FillDataSources(report);
      var type = global::Sungero.Metadata.Services.AppliedTypesManager.Instance.Resolve("Sungero.Docflow.EnvelopeC4ReportServerHandlers");
      if (type != null)
      {
      }
      else
      {
      }
    }


    public global::System.String ReportSessionId
    {
      get
      {
          return this.GetParameterValue("ReportSessionId") as global::System.String;
      }

      set
      {
        this.SetParameterValue("ReportSessionId", value);
      }
    }

    public global::System.Nullable<global::System.Boolean> PrintSender
    {
      get
      {
          return this.GetParameterValue("PrintSender") as global::System.Nullable<global::System.Boolean>;
      }

      set
      {
        this.SetParameterValue("PrintSender", value);
      }
    }

      private  Sungero.Reporting.Shared.CollectionAdapter<global::Sungero.Docflow.IOutgoingDocumentBase>  _OutgoingDocumentsAdapter;

    public Sungero.Reporting.Shared.CollectionAdapter<global::Sungero.Docflow.IOutgoingDocumentBase> OutgoingDocuments
    {
      get
      {
          if(this._OutgoingDocumentsAdapter == null)
            this._OutgoingDocumentsAdapter = new Sungero.Reporting.Shared.CollectionAdapter<global::Sungero.Docflow.IOutgoingDocumentBase>(this, "OutgoingDocuments");
          return this._OutgoingDocumentsAdapter;
      }

    }

      private  Sungero.Reporting.Shared.CollectionAdapter<global::Sungero.Docflow.IContractualDocumentBase>  _ContractualDocumentsAdapter;

    public Sungero.Reporting.Shared.CollectionAdapter<global::Sungero.Docflow.IContractualDocumentBase> ContractualDocuments
    {
      get
      {
          if(this._ContractualDocumentsAdapter == null)
            this._ContractualDocumentsAdapter = new Sungero.Reporting.Shared.CollectionAdapter<global::Sungero.Docflow.IContractualDocumentBase>(this, "ContractualDocuments");
          return this._ContractualDocumentsAdapter;
      }

    }

      private  Sungero.Reporting.Shared.CollectionAdapter<global::Sungero.Docflow.IAccountingDocumentBase>  _AccountingDocumentsAdapter;

    public Sungero.Reporting.Shared.CollectionAdapter<global::Sungero.Docflow.IAccountingDocumentBase> AccountingDocuments
    {
      get
      {
          if(this._AccountingDocumentsAdapter == null)
            this._AccountingDocumentsAdapter = new Sungero.Reporting.Shared.CollectionAdapter<global::Sungero.Docflow.IAccountingDocumentBase>(this, "AccountingDocuments");
          return this._AccountingDocumentsAdapter;
      }

    }


    public EnvelopeC4Report()
    {
      var type = global::Sungero.Metadata.Services.AppliedTypesManager.Instance.Resolve("Sungero.Docflow.EnvelopeC4ReportServerHandlers");
      this.Handlers = type != null
        ? global::Sungero.Metadata.Services.AppliedTypesManager.CreateTypeInstance(type, new object[] { this })
        : new global::Sungero.Docflow.EnvelopeC4ReportServerHandlers(this);
    }
  }
}

// ==================================================================
// EnvelopeC4ReportHandlers.g.cs
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
  public partial class EnvelopeC4ReportServerHandlers : global::Sungero.Reporting.ReportServerHandlers
  {
    private global::Sungero.Docflow.IEnvelopeC4Report EnvelopeC4Report
    {
      get { return (global::Sungero.Docflow.IEnvelopeC4Report)this._Report; }
    }

    public EnvelopeC4ReportServerHandlers(global::Sungero.Docflow.IEnvelopeC4Report report) : base(report) { }
  }
}

// ==================================================================
// EnvelopeC4ReportRepositoryImplementer.g.cs
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
  public class EnvelopeC4ReportRepositoryImplementer<T> : 
    global::Sungero.Reporting.Server.ReportRepositoryImplementer<T>,
    global::Sungero.Docflow.IEnvelopeC4ReportRepositoryImplementer<T>
    where T : global::Sungero.Docflow.IEnvelopeC4Report 
  {
  }
}

// ==================================================================
// EnvelopeC4ReportQueries.g.cs
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
  public class EnvelopeC4Report
  {
    private static global::Sungero.Domain.SqlQueryResolver resolver = new global::Sungero.Domain.SqlQueryResolver("Sungero.Docflow.Server.Reports.EnvelopeC4Report.EnvelopeC4ReportQueries.xml", System.Reflection.Assembly.GetExecutingAssembly());
    public static string DataSource
    {
       get { return resolver.GetQuery("DataSource"); }
    }
    public static string CreateEnvelopesTable
    {
       get { return resolver.GetQuery("CreateEnvelopesTable"); }
    }
  }
}