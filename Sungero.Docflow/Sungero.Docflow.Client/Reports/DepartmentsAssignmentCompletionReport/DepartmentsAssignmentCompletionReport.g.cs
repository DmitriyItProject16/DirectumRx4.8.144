
// ==================================================================
// DepartmentsAssignmentCompletionReport.g.cs
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
  public class DepartmentsAssignmentCompletionReport : global::Sungero.Reporting.Client.Report, global::Sungero.Docflow.IDepartmentsAssignmentCompletionReport
  {
    public static readonly new global::System.Guid ClassTypeGuid = new global::System.Guid("23fc035e-72bf-4bd9-9659-a21ad2378f43");

    protected override global::System.Guid ReportTypeId
    {
      get { return ClassTypeGuid; }
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

    public global::System.Nullable<global::System.DateTime> ReportDate
    {
      get
      {
          return this.GetParameterValue("ReportDate") as global::System.Nullable<global::System.DateTime>;
      }

      set
      {
        this.SetParameterValue("ReportDate", value);
      }
    }

    public global::System.String ParamsDescription
    {
      get
      {
          return this.GetParameterValue("ParamsDescription") as global::System.String;
      }

      set
      {
        this.SetParameterValue("ParamsDescription", value);
      }
    }

    public global::System.Nullable<global::System.DateTime> PeriodBegin
    {
      get
      {
          return this.GetParameterValue("PeriodBegin") as global::System.Nullable<global::System.DateTime>;
      }

      set
      {
        this.SetParameterValue("PeriodBegin", value);
      }
    }

    public global::System.Nullable<global::System.DateTime> PeriodEnd
    {
      get
      {
          return this.GetParameterValue("PeriodEnd") as global::System.Nullable<global::System.DateTime>;
      }

      set
      {
        this.SetParameterValue("PeriodEnd", value);
      }
    }

    public global::Sungero.Company.IBusinessUnit BusinessUnit
    {
      get
      {
          return this.GetParameterValue("BusinessUnit") as global::Sungero.Company.IBusinessUnit;
      }

      set
      {
        this.SetParameterValue("BusinessUnit", value);
      }
    }

    public global::System.String DetailedReportLink
    {
      get
      {
          return this.GetParameterValue("DetailedReportLink") as global::System.String;
      }

      set
      {
        this.SetParameterValue("DetailedReportLink", value);
      }
    }

      private Sungero.Reporting.Shared.CollectionAdapter<global::System.Nullable<global::System.Int64>> _DepartmentIdsAdapter;

    public Sungero.Reporting.Shared.CollectionAdapter<global::System.Nullable<global::System.Int64>> DepartmentIds
    {
      get
      {
          if(this._DepartmentIdsAdapter == null)
            this._DepartmentIdsAdapter = new Sungero.Reporting.Shared.CollectionAdapter<global::System.Nullable<global::System.Int64>>(this, "DepartmentIds");
          return this._DepartmentIdsAdapter;
      }

    }

    public global::System.Nullable<global::System.Boolean> WithSubstitution
    {
      get
      {
          return this.GetParameterValue("WithSubstitution") as global::System.Nullable<global::System.Boolean>;
      }

      set
      {
        this.SetParameterValue("WithSubstitution", value);
      }
    }

    public global::System.Nullable<global::System.Boolean> Unwrap
    {
      get
      {
          return this.GetParameterValue("Unwrap") as global::System.Nullable<global::System.Boolean>;
      }

      set
      {
        this.SetParameterValue("Unwrap", value);
      }
    }

    public global::System.String WidgetParameter
    {
      get
      {
          return this.GetParameterValue("WidgetParameter") as global::System.String;
      }

      set
      {
        this.SetParameterValue("WidgetParameter", value);
      }
    }

    public global::Sungero.Company.IDepartment Department
    {
      get
      {
          return this.GetParameterValue("Department") as global::Sungero.Company.IDepartment;
      }

      set
      {
        this.SetParameterValue("Department", value);
      }
    }

      private Sungero.Reporting.Shared.CollectionAdapter<global::System.Nullable<global::System.Int64>> _BusinessUnitIdsAdapter;

    public Sungero.Reporting.Shared.CollectionAdapter<global::System.Nullable<global::System.Int64>> BusinessUnitIds
    {
      get
      {
          if(this._BusinessUnitIdsAdapter == null)
            this._BusinessUnitIdsAdapter = new Sungero.Reporting.Shared.CollectionAdapter<global::System.Nullable<global::System.Int64>>(this, "BusinessUnitIds");
          return this._BusinessUnitIdsAdapter;
      }

    }


    public DepartmentsAssignmentCompletionReport()
    {
      var type = global::Sungero.Metadata.Services.AppliedTypesManager.Instance.Resolve("Sungero.Docflow.DepartmentsAssignmentCompletionReportClientHandlers");
      this.Handlers = type != null
        ? global::Sungero.Metadata.Services.AppliedTypesManager.CreateTypeInstance(type, new object[] { this })
        : new global::Sungero.Docflow.DepartmentsAssignmentCompletionReportClientHandlers(this);
    }
  }
}

// ==================================================================
// DepartmentsAssignmentCompletionReportRepositoryImplementer.g.cs
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
  public class DepartmentsAssignmentCompletionReportRepositoryImplementer<T> : 
      global::Sungero.Reporting.Client.ReportRepositoryImplementer<T>,
      global::Sungero.Docflow.IDepartmentsAssignmentCompletionReportRepositoryImplementer<T>
      where T : global::Sungero.Docflow.IDepartmentsAssignmentCompletionReport
    {
    }
}
