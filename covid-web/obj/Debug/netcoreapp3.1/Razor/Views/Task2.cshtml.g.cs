#pragma checksum "/home/codio/workspace/covid-web/Views/Task2.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3f8b24cbec18e621b03fcb39ac140ea1439570e8"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(program.Pages.Views_Task2), @"mvc.1.0.razor-page", @"/Views/Task2.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3f8b24cbec18e621b03fcb39ac140ea1439570e8", @"/Views/Task2.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"65a87352ab55936b7625448d2e9155e1658af919", @"/Views/_ViewImports.cshtml")]
    public class Views_Task2 : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "/home/codio/workspace/covid-web/Views/Task2.cshtml"
  
  var hospitalizationDataset = Newtonsoft.Json.JsonConvert.SerializeObject(Model.hospitalizationDataset);
  var deathsDataset = Newtonsoft.Json.JsonConvert.SerializeObject(Model.deathsDataset);
  var datesDataset = Newtonsoft.Json.JsonConvert.SerializeObject(Model.datesDataset);
  var stateName = Newtonsoft.Json.JsonConvert.SerializeObject(Model.stateName);
  ViewData["Title"] = "State Information";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<h2>Task 2</h2>  
<br />
<p>2. Your second taskis to implement a graph displayingthe total number of hospitalizations and(hospitalized) and total number of deaths (death) over the dates availablefor a state which mustbe provided via a text box. Use us_states_covid19_daily table for this purpose. The graph must enable users to hover over the line and show the raw data for that date. Proper legends are to be present. </p>
<br />
Your search string: """);
#nullable restore
#line 15 "/home/codio/workspace/covid-web/Views/Task2.cshtml"
                Write(Model.Input);

#line default
#line hidden
#nullable disable
            WriteLiteral("\"\n<br />\n# of entries found: ");
#nullable restore
#line 17 "/home/codio/workspace/covid-web/Views/Task2.cshtml"
               Write(Model.Count);

#line default
#line hidden
#nullable disable
            WriteLiteral("\n<br />\n<br />\n");
#nullable restore
#line 20 "/home/codio/workspace/covid-web/Views/Task2.cshtml"
  
   if (@Model.EX != null)
	 {

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t <h3>**ERROR: ");
#nullable restore
#line 23 "/home/codio/workspace/covid-web/Views/Task2.cshtml"
                 Write(Model.EX.Message);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\n\t\t <br />\n\t\t <hr />\n\t\t <br />\n\t\t <br />\n");
#nullable restore
#line 28 "/home/codio/workspace/covid-web/Views/Task2.cshtml"
	 }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
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
#line 44 "/home/codio/workspace/covid-web/Views/Task2.cshtml"
           Write(Html.Raw(datesDataset));

#line default
#line hidden
#nullable disable
            WriteLiteral(",\n        datasets: [\n        {\n            label: \'Hospitalizations\',  \n            data: ");
#nullable restore
#line 48 "/home/codio/workspace/covid-web/Views/Task2.cshtml"
             Write(Html.Raw(hospitalizationDataset));

#line default
#line hidden
#nullable disable
            WriteLiteral(",\n            borderColor: \"blue\",\n            pointBackgroundColor: \"black\",\n\n            borderWidth: 1\n        }, \n        {\n            label: \'Deaths\',  \n            data: ");
#nullable restore
#line 56 "/home/codio/workspace/covid-web/Views/Task2.cshtml"
             Write(Html.Raw(deathsDataset));

#line default
#line hidden
#nullable disable
            WriteLiteral(@",
            borderColor: ""red"",
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
                  labelString: 'Dates',
                  beginAtZero:true
                }
            }],
            yAxes: [{
                scaleLabel: {
                  display: true,
                  labelString: 'Hospitalizations/Deaths',
                  beginAtZero:true
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Task2Model> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Task2Model> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Task2Model>)PageContext?.ViewData;
        public Task2Model Model => ViewData.Model;
    }
}
#pragma warning restore 1591
