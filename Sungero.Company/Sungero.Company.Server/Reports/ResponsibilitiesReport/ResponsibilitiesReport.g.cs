
// ==================================================================
// ResponsibilitiesReport.g.cs
// ==================================================================

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sungero.Company.Server
{
  public class ResponsibilitiesReport : global::Sungero.Reporting.Server.Report, global::Sungero.Company.IResponsibilitiesReport
  {
    public static readonly new global::System.Guid ClassTypeGuid = new global::System.Guid("b8aa8f84-7488-43c7-9e0d-7050eb5ea6af");

    protected override global::System.Guid ReportTypeId
    {
      get { return ClassTypeGuid; }
    }


    protected override void FillDataSources(global::FastReport.Report report)
    {
      base.FillDataSources(report);
      var type = global::Sungero.Metadata.Services.AppliedTypesManager.Instance.Resolve("Sungero.Company.ResponsibilitiesReportServerHandlers");
      if (type != null)
      {
      }
      else
      {
      }
    }


    public global::Sungero.Company.IEmployee Employee
    {
      get
      {
          return this.GetParameterValue("Employee") as global::Sungero.Company.IEmployee;
      }

      set
      {
        this.SetParameterValue("Employee", value);
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

    public global::System.Nullable<global::System.DateTime> CurrentDate
    {
      get
      {
          return this.GetParameterValue("CurrentDate") as global::System.Nullable<global::System.DateTime>;
      }

      set
      {
        this.SetParameterValue("CurrentDate", value);
      }
    }


    public ResponsibilitiesReport()
    {
      var type = global::Sungero.Metadata.Services.AppliedTypesManager.Instance.Resolve("Sungero.Company.ResponsibilitiesReportServerHandlers");
      this.Handlers = type != null
        ? global::Sungero.Metadata.Services.AppliedTypesManager.CreateTypeInstance(type, new object[] { this })
        : new global::Sungero.Company.ResponsibilitiesReportServerHandlers(this);
    }
  }
}

// ==================================================================
// ResponsibilitiesReportHandlers.g.cs
// ==================================================================

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sungero.Company
{
  public partial class ResponsibilitiesReportServerHandlers : global::Sungero.Reporting.ReportServerHandlers
  {
    private global::Sungero.Company.IResponsibilitiesReport ResponsibilitiesReport
    {
      get { return (global::Sungero.Company.IResponsibilitiesReport)this._Report; }
    }

    public ResponsibilitiesReportServerHandlers(global::Sungero.Company.IResponsibilitiesReport report) : base(report) { }
  }
}

// ==================================================================
// ResponsibilitiesReportRepositoryImplementer.g.cs
// ==================================================================

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sungero.Company.Server
{
  public class ResponsibilitiesReportRepositoryImplementer<T> : 
    global::Sungero.Reporting.Server.ReportRepositoryImplementer<T>,
    global::Sungero.Company.IResponsibilitiesReportRepositoryImplementer<T>
    where T : global::Sungero.Company.IResponsibilitiesReport 
  {
  }
}

// ==================================================================
// ResponsibilitiesReportQueries.g.cs
// ==================================================================

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sungero.Company.Queries
{
  public class ResponsibilitiesReport
  {
    private static global::Sungero.Domain.SqlQueryResolver resolver = new global::Sungero.Domain.SqlQueryResolver("Sungero.Company.Server.Reports.ResponsibilitiesReport.ResponsibilitiesReportQueries.xml", System.Reflection.Assembly.GetExecutingAssembly());
    public static string CreateResponsibilitiesReportTable
    {
       get { return resolver.GetQuery("CreateResponsibilitiesReportTable"); }
    }
    public static string SelectDataFromTable
    {
       get { return resolver.GetQuery("SelectDataFromTable"); }
    }
  }
}