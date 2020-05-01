using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace RefactoringApp.MovingFeaturesBetweenObjects.IntroduceLocalExtesion
{
    class Example
    {
        public List<DataTable> Table { get; set; }
        void GetTotalLine()
        {
            var totalLine = Table.Where(r => r.TableName == "TotalLine").ToList();
        }
    }

    class UsingSubClass
    {
        public SpecialDataTable SpecialDataTable { get; set; }
        void GetTotalLine()
        {
            var totalLine = SpecialDataTable.TotalLine;
        }
    }


    class SpecialDataTable : DataTable
    {
        public List<DataTable> TotalLine => TotalLine.Where(r => r.TableName == "TotalLine").ToList();
    }

}

