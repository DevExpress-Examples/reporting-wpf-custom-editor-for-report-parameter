using System.Collections.Generic;
using CustomParameterEditorsWPF.App_data;
// ...

namespace CustomParameterEditorsWPF {
    public class Categories : List<string> {
        public Categories() {
            nwindDataSet dataSet = new nwindDataSet();
            new CustomParameterEditorsWPF.App_data.nwindDataSetTableAdapters.CategoriesTableAdapter().Fill(dataSet.Categories);
            foreach(var category in dataSet.Categories) {
                Add(category.CategoryName);
            }
        }
    }
}
