
// ==================================================================
// ExchangeOrderReport.g.cs
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
  public class ExchangeOrderReport : global::Sungero.Reporting.Client.Report, global::Sungero.Docflow.IExchangeOrderReport
  {
    public static readonly new global::System.Guid ClassTypeGuid = new global::System.Guid("eb8f1b91-7142-42e7-8168-b90729df6459");

    protected override global::System.Guid ReportTypeId
    {
      get { return ClassTypeGuid; }
    }



    public global::Sungero.Docflow.IOfficialDocument Entity
    {
      get
      {
          return this.GetParameterValue("Entity") as global::Sungero.Docflow.IOfficialDocument;
      }

      set
      {
        this.SetParameterValue("Entity", value);
      }
    }

    public global::System.String SessionId
    {
      get
      {
          return this.GetParameterValue("SessionId") as global::System.String;
      }

      set
      {
        this.SetParameterValue("SessionId", value);
      }
    }

    public global::System.String CompletationString
    {
      get
      {
          return this.GetParameterValue("CompletationString") as global::System.String;
      }

      set
      {
        this.SetParameterValue("CompletationString", value);
      }
    }

    public global::System.String DocumentName
    {
      get
      {
          return this.GetParameterValue("DocumentName") as global::System.String;
      }

      set
      {
        this.SetParameterValue("DocumentName", value);
      }
    }


    public ExchangeOrderReport()
    {
      var type = global::Sungero.Metadata.Services.AppliedTypesManager.Instance.Resolve("Sungero.Docflow.ExchangeOrderReportClientHandlers");
      this.Handlers = type != null
        ? global::Sungero.Metadata.Services.AppliedTypesManager.CreateTypeInstance(type, new object[] { this })
        : new global::Sungero.Docflow.ExchangeOrderReportClientHandlers(this);
    }
  }
}

// ==================================================================
// ExchangeOrderReportRepositoryImplementer.g.cs
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
  public class ExchangeOrderReportRepositoryImplementer<T> : 
      global::Sungero.Reporting.Client.ReportRepositoryImplementer<T>,
      global::Sungero.Docflow.IExchangeOrderReportRepositoryImplementer<T>
      where T : global::Sungero.Docflow.IExchangeOrderReport
    {
    }
}
