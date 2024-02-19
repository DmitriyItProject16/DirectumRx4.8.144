
// ==================================================================
// AcquaintanceFormReport.g.cs
// ==================================================================

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sungero.RecordManagement.Client
{
  public class AcquaintanceFormReport : global::Sungero.Reporting.Client.Report, global::Sungero.RecordManagement.IAcquaintanceFormReport
  {
    public static readonly new global::System.Guid ClassTypeGuid = new global::System.Guid("4fb95eaa-eed1-4fcb-a601-e0b88ad0f5ae");

    protected override global::System.Guid ReportTypeId
    {
      get { return ClassTypeGuid; }
    }



    public global::Sungero.Docflow.IOfficialDocument Document
    {
      get
      {
          return this.GetParameterValue("Document") as global::Sungero.Docflow.IOfficialDocument;
      }

      set
      {
        this.SetParameterValue("Document", value);
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

    public global::System.String AddendaDescription
    {
      get
      {
          return this.GetParameterValue("AddendaDescription") as global::System.String;
      }

      set
      {
        this.SetParameterValue("AddendaDescription", value);
      }
    }

    public global::System.String Printed
    {
      get
      {
          return this.GetParameterValue("Printed") as global::System.String;
      }

      set
      {
        this.SetParameterValue("Printed", value);
      }
    }

    public global::Sungero.RecordManagement.IAcquaintanceTask Task
    {
      get
      {
          return this.GetParameterValue("Task") as global::Sungero.RecordManagement.IAcquaintanceTask;
      }

      set
      {
        this.SetParameterValue("Task", value);
      }
    }


    public AcquaintanceFormReport()
    {
      var type = global::Sungero.Metadata.Services.AppliedTypesManager.Instance.Resolve("Sungero.RecordManagement.AcquaintanceFormReportClientHandlers");
      this.Handlers = type != null
        ? global::Sungero.Metadata.Services.AppliedTypesManager.CreateTypeInstance(type, new object[] { this })
        : new global::Sungero.RecordManagement.AcquaintanceFormReportClientHandlers(this);
    }
  }
}

// ==================================================================
// AcquaintanceFormReportRepositoryImplementer.g.cs
// ==================================================================

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sungero.RecordManagement.Client
{ 
  public class AcquaintanceFormReportRepositoryImplementer<T> : 
      global::Sungero.Reporting.Client.ReportRepositoryImplementer<T>,
      global::Sungero.RecordManagement.IAcquaintanceFormReportRepositoryImplementer<T>
      where T : global::Sungero.RecordManagement.IAcquaintanceFormReport
    {
    }
}
