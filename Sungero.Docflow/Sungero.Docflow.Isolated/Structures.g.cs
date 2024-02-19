//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sungero.Docflow.Structures.Module
{
  public interface IMinutesActionItem
  {
    global::System.Collections.Generic.Dictionary<global::System.String, global::System.String> Properties { get; set; }

  }

  [global::System.Serializable]
  public class MinutesActionItem : IMinutesActionItem
  {
    public global::System.Collections.Generic.Dictionary<global::System.String, global::System.String> Properties { get; set; }


    public static IMinutesActionItem Create()
    {
      return new MinutesActionItem();
    }

    public static IMinutesActionItem Create(global::System.Collections.Generic.Dictionary<global::System.String, global::System.String> properties)
    {
      return new MinutesActionItem
      {
        Properties = properties
      };
    }

    public override int GetHashCode()
    {
      unchecked
      {
        return ((this.Properties != null ? this.Properties.GetHashCode() : 0) * 199);
      }
    }

    public override bool Equals(object obj)
    {
      if (ReferenceEquals(null, obj)) return false;
      if (ReferenceEquals(this, obj)) return true;
      if (obj.GetType() != this.GetType()) return false;
      return Equals((MinutesActionItem)obj);
    }

    public static bool operator ==(MinutesActionItem left, MinutesActionItem right)
    {
      if (ReferenceEquals(left, right))
        return true;

      if (((object)left) == null || ((object)right) == null)
        return false;

      return left.Equals(right);
    }

    public static bool operator !=(MinutesActionItem left, MinutesActionItem right)
    {
      return !(left == right);
    }

    protected bool Equals(MinutesActionItem other)
    {
      return object.Equals(this.Properties, other.Properties) ;
    }

  }

  public interface IPdfStringSearchResult
  {
    global::System.Double XIndent { get; set; }
    global::System.Double YIndent { get; set; }
    global::System.Int32 PageNumber { get; set; }
    global::System.Double PageWidth { get; set; }
    global::System.Double PageHeight { get; set; }
    global::System.Int32 PageCount { get; set; }

  }

  [global::System.Serializable]
  public class PdfStringSearchResult : IPdfStringSearchResult
  {
    public global::System.Double XIndent { get; set; }
    public global::System.Double YIndent { get; set; }
    public global::System.Int32 PageNumber { get; set; }
    public global::System.Double PageWidth { get; set; }
    public global::System.Double PageHeight { get; set; }
    public global::System.Int32 PageCount { get; set; }


    public static IPdfStringSearchResult Create()
    {
      return new PdfStringSearchResult();
    }

    public static IPdfStringSearchResult Create(global::System.Double xIndent, global::System.Double yIndent, global::System.Int32 pageNumber, global::System.Double pageWidth, global::System.Double pageHeight, global::System.Int32 pageCount)
    {
      return new PdfStringSearchResult
      {
        XIndent = xIndent,
        YIndent = yIndent,
        PageNumber = pageNumber,
        PageWidth = pageWidth,
        PageHeight = pageHeight,
        PageCount = pageCount
      };
    }

    public override int GetHashCode()
    {
      unchecked
      {
        return (this.XIndent.GetHashCode() * 199) ^ (this.YIndent.GetHashCode() * 199) ^ (this.PageNumber.GetHashCode() * 199) ^ (this.PageWidth.GetHashCode() * 199) ^ (this.PageHeight.GetHashCode() * 199) ^ (this.PageCount.GetHashCode() * 199);
      }
    }

    public override bool Equals(object obj)
    {
      if (ReferenceEquals(null, obj)) return false;
      if (ReferenceEquals(this, obj)) return true;
      if (obj.GetType() != this.GetType()) return false;
      return Equals((PdfStringSearchResult)obj);
    }

    public static bool operator ==(PdfStringSearchResult left, PdfStringSearchResult right)
    {
      if (ReferenceEquals(left, right))
        return true;

      if (((object)left) == null || ((object)right) == null)
        return false;

      return left.Equals(right);
    }

    public static bool operator !=(PdfStringSearchResult left, PdfStringSearchResult right)
    {
      return !(left == right);
    }

    protected bool Equals(PdfStringSearchResult other)
    {
      return this.XIndent == other.XIndent
             && this.YIndent == other.YIndent
             && this.PageNumber == other.PageNumber
             && this.PageWidth == other.PageWidth
             && this.PageHeight == other.PageHeight
             && this.PageCount == other.PageCount;
    }

  }

  public interface IDocumentComparisonResult
  {
    global::System.Int32 DifferencesCount { get; set; }
    global::System.Boolean DocumentsAreDifferent { get; set; }
    global::System.Byte[] ResultPdf { get; set; }

  }

  [global::System.Serializable]
  public class DocumentComparisonResult : IDocumentComparisonResult
  {
    public global::System.Int32 DifferencesCount { get; set; }
    public global::System.Boolean DocumentsAreDifferent { get; set; }
    public global::System.Byte[] ResultPdf { get; set; }


    public static IDocumentComparisonResult Create()
    {
      return new DocumentComparisonResult();
    }

    public static IDocumentComparisonResult Create(global::System.Int32 differencesCount, global::System.Boolean documentsAreDifferent, global::System.Byte[] resultPdf)
    {
      return new DocumentComparisonResult
      {
        DifferencesCount = differencesCount,
        DocumentsAreDifferent = documentsAreDifferent,
        ResultPdf = resultPdf
      };
    }

    public override int GetHashCode()
    {
      unchecked
      {
        return (this.DifferencesCount.GetHashCode() * 199) ^ (this.DocumentsAreDifferent.GetHashCode() * 199) ^ (this.ResultPdf.GetHashCode() * 199);
      }
    }

    public override bool Equals(object obj)
    {
      if (ReferenceEquals(null, obj)) return false;
      if (ReferenceEquals(this, obj)) return true;
      if (obj.GetType() != this.GetType()) return false;
      return Equals((DocumentComparisonResult)obj);
    }

    public static bool operator ==(DocumentComparisonResult left, DocumentComparisonResult right)
    {
      if (ReferenceEquals(left, right))
        return true;

      if (((object)left) == null || ((object)right) == null)
        return false;

      return left.Equals(right);
    }

    public static bool operator !=(DocumentComparisonResult left, DocumentComparisonResult right)
    {
      return !(left == right);
    }

    protected bool Equals(DocumentComparisonResult other)
    {
      return this.DifferencesCount == other.DifferencesCount
             && this.DocumentsAreDifferent == other.DocumentsAreDifferent
             && ArrayEqual(this.ResultPdf, other.ResultPdf);
    }

    private static bool ArrayEqual<TSource>(global::System.Collections.Generic.IEnumerable<TSource> left, global::System.Collections.Generic.IEnumerable<TSource> right)
    {
      if (ReferenceEquals(left, right))
        return true;
      if (ReferenceEquals(null, left))
        return false;
      if (ReferenceEquals(null, right))
        return false;
      if (global::System.Linq.Enumerable.Count(left) != global::System.Linq.Enumerable.Count(right))
        return false;

      return global::System.Linq.Enumerable.SequenceEqual(left, right);
    }
  }

}