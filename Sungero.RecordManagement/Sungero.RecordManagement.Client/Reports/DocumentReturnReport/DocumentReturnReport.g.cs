
// ==================================================================
// DocumentReturnReport.g.cs
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
  public class DocumentReturnReport : global::Sungero.Reporting.Client.Report, global::Sungero.RecordManagement.IDocumentReturnReport
  {
    public static readonly new global::System.Guid ClassTypeGuid = new global::System.Guid("aaccef11-d184-4225-9861-2e6578ae54de");

    protected override global::System.Guid ReportTypeId
    {
      get { return ClassTypeGuid; }
    }



    public global::System.String AvailableIdsTableName
    {
      get
      {
          return this.GetParameterValue("AvailableIdsTableName") as global::System.String;
      }

      set
      {
        this.SetParameterValue("AvailableIdsTableName", value);
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

    public global::System.Nullable<global::System.DateTime> DeliveryDateFrom
    {
      get
      {
          return this.GetParameterValue("DeliveryDateFrom") as global::System.Nullable<global::System.DateTime>;
      }

      set
      {
        this.SetParameterValue("DeliveryDateFrom", value);
      }
    }

    public global::System.Nullable<global::System.DateTime> DeliveryDateTo
    {
      get
      {
          return this.GetParameterValue("DeliveryDateTo") as global::System.Nullable<global::System.DateTime>;
      }

      set
      {
        this.SetParameterValue("DeliveryDateTo", value);
      }
    }

    public global::System.Nullable<global::System.Boolean> NeedShowDialog
    {
      get
      {
          return this.GetParameterValue("NeedShowDialog") as global::System.Nullable<global::System.Boolean>;
      }

      set
      {
        this.SetParameterValue("NeedShowDialog", value);
      }
    }

    public global::System.Nullable<global::System.DateTime> MinDeliveryDate
    {
      get
      {
          return this.GetParameterValue("MinDeliveryDate") as global::System.Nullable<global::System.DateTime>;
      }

      set
      {
        this.SetParameterValue("MinDeliveryDate", value);
      }
    }

    public global::System.Nullable<global::System.DateTime> MaxDeliveryDate
    {
      get
      {
          return this.GetParameterValue("MaxDeliveryDate") as global::System.Nullable<global::System.DateTime>;
      }

      set
      {
        this.SetParameterValue("MaxDeliveryDate", value);
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


    public DocumentReturnReport()
    {
      var type = global::Sungero.Metadata.Services.AppliedTypesManager.Instance.Resolve("Sungero.RecordManagement.DocumentReturnReportClientHandlers");
      this.Handlers = type != null
        ? global::Sungero.Metadata.Services.AppliedTypesManager.CreateTypeInstance(type, new object[] { this })
        : new global::Sungero.RecordManagement.DocumentReturnReportClientHandlers(this);
    }
  }
}

// ==================================================================
// DocumentReturnReportRepositoryImplementer.g.cs
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
  public class DocumentReturnReportRepositoryImplementer<T> : 
      global::Sungero.Reporting.Client.ReportRepositoryImplementer<T>,
      global::Sungero.RecordManagement.IDocumentReturnReportRepositoryImplementer<T>
      where T : global::Sungero.RecordManagement.IDocumentReturnReport
    {
    }
}
