using System.Linq;
using System.Collections.Generic;
using dugout.WebApi.Models;

namespace dugout.WebApi.Extentions {

  public static class FieldListExtentions {
    public static List<FieldList> MergeFieldLists(this List<FieldList> fieldList, List<FieldList> source) {
          foreach(var fl in source) {
            try {
              var list = fieldList.Where(f => f.label == fl.label).First();
              list.value = list.value.Replace(".", "; ");
              list.value += fl.value;
            }
            catch {
              fieldList.Add(fl);
            }
          }
          return fieldList;
        }
  }
}