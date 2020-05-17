#pragma checksum "/home/codio/workspace/covid-web/Views/StateInfo.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4115c223cc0d5070c99bd242ef5fab0b48875f66"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(program.Pages.Views_StateInfo), @"mvc.1.0.razor-page", @"/Views/StateInfo.cshtml")]
namespace program.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "/home/codio/workspace/covid-web/Views/_ViewImports.cshtml"
using program;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4115c223cc0d5070c99bd242ef5fab0b48875f66", @"/Views/StateInfo.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"65a87352ab55936b7625448d2e9155e1658af919", @"/Views/_ViewImports.cshtml")]
    public class Views_StateInfo : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "/home/codio/workspace/covid-web/Views/StateInfo.cshtml"
  
  var populationDataset = Newtonsoft.Json.JsonConvert.SerializeObject(Model.populationDataset);
  var yearDataset = Newtonsoft.Json.JsonConvert.SerializeObject(Model.yearDataset);
  var stateName = Newtonsoft.Json.JsonConvert.SerializeObject(Model.stateName);
  ViewData["Title"] = "State Information";

#line default
#line hidden
#nullable disable
            WriteLiteral("\n<h2>State Information</h2>  \n\n<br />\nYour search string: \"");
#nullable restore
#line 13 "/home/codio/workspace/covid-web/Views/StateInfo.cshtml"
                Write(Model.Input);

#line default
#line hidden
#nullable disable
            WriteLiteral("\"\n<br />\n# of states found: ");
#nullable restore
#line 15 "/home/codio/workspace/covid-web/Views/StateInfo.cshtml"
              Write(Model.StateList.Count);

#line default
#line hidden
#nullable disable
            WriteLiteral("\n<br />\n<br />\n");
#nullable restore
#line 18 "/home/codio/workspace/covid-web/Views/StateInfo.cshtml"
  
   if (@Model.EX != null)
	 {

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t <h3>**ERROR: ");
#nullable restore
#line 21 "/home/codio/workspace/covid-web/Views/StateInfo.cshtml"
                 Write(Model.EX.Message);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\n\t\t <br />\n\t\t <hr />\n\t\t <br />\n\t\t <br />\n");
#nullable restore
#line 26 "/home/codio/workspace/covid-web/Views/StateInfo.cshtml"
	 }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<table class=""table"">  
    <thead>  
        <tr>   
            <th>  
                State
            </th>  
						<th>  
                Year
            </th>  
            <th>  
                Population
            </th>  
        </tr>  
    </thead>  
    <tbody>  
");
#nullable restore
#line 44 "/home/codio/workspace/covid-web/Views/StateInfo.cshtml"
         foreach (var item in Model.StateList)  
        {  

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>  \n                <td>  \n\t\t\t\t\t\t\t\t\t\t");
#nullable restore
#line 48 "/home/codio/workspace/covid-web/Views/StateInfo.cshtml"
                                   Write(item.StateName);

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                </td>  \n                <td>  \n                    ");
#nullable restore
#line 51 "/home/codio/workspace/covid-web/Views/StateInfo.cshtml"
               Write(item.Year);

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                </td> \n\t\t\t\t\t\t\t\t<td>  \n                    ");
#nullable restore
#line 54 "/home/codio/workspace/covid-web/Views/StateInfo.cshtml"
               Write(item.Population);

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                </td> \n            </tr>  \n");
#nullable restore
#line 57 "/home/codio/workspace/covid-web/Views/StateInfo.cshtml"
        }  

#line default
#line hidden
#nullable disable
            WriteLiteral(@"    </tbody>  
</table> 

<h2>Task 1</h2>  
<br/>
<p>1. Your first taskis to graph the tabular form of census datain the form of a line chart. </p>
<br/>

<div class=""box-body"">  
  <div class=""chart-container"">  
     <canvas id=""myChart""></canvas>  
  </div>  
</div>  

<script src=""https://cdnjs.cloudflare.com/ajax/libs/Chart.js/2.7.3/Chart.bundle.min.js""></script>

<script>
var ctx = document.getElementById(""myChart"");
var myChart = new Chart(ctx, {
    type: 'line',
    data: {
        labels: ");
#nullable restore
#line 79 "/home/codio/workspace/covid-web/Views/StateInfo.cshtml"
           Write(Html.Raw(yearDataset));

#line default
#line hidden
#nullable disable
            WriteLiteral(",\n        datasets: [\n        {\n            label: ");
#nullable restore
#line 82 "/home/codio/workspace/covid-web/Views/StateInfo.cshtml"
              Write(Html.Raw(stateName));

#line default
#line hidden
#nullable disable
            WriteLiteral(",  \n            data: ");
#nullable restore
#line 83 "/home/codio/workspace/covid-web/Views/StateInfo.cshtml"
             Write(Html.Raw(populationDataset));

#line default
#line hidden
#nullable disable
            WriteLiteral(@",
            borderColor: ""blue"",
            pointBackgroundColor: ""black"",

            borderWidth: 1
        }
        ]
    },
    options: {
        scales: {
            xAxes: [{
                scaleLabel: {
                  display: true,
                  labelString: 'Year'
                }
            }],
            yAxes: [{
                scaleLabel: {
                  display: true,
                  labelString: 'Population'
                }
            }]
        }
    }
});

</script>
");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<StateInfoModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<StateInfoModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<StateInfoModel>)PageContext?.ViewData;
        public StateInfoModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591