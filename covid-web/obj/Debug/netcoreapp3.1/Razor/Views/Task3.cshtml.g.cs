#pragma checksum "/home/codio/workspace/covid-web/Views/Task3.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ba64e26a6ee73ae37bad23417cb9c7b1eec53bd0"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(program.Pages.Views_Task3), @"mvc.1.0.razor-page", @"/Views/Task3.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ba64e26a6ee73ae37bad23417cb9c7b1eec53bd0", @"/Views/Task3.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"65a87352ab55936b7625448d2e9155e1658af919", @"/Views/_ViewImports.cshtml")]
    public class Views_Task3 : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "/home/codio/workspace/covid-web/Views/Task3.cshtml"
  
  var positiveIncreaseDataset1 = Newtonsoft.Json.JsonConvert.SerializeObject(Model.positiveIncreaseDataset1);
  var negativeIncreaseDataset1 = Newtonsoft.Json.JsonConvert.SerializeObject(Model.negativeIncreaseDataset1);
  var datesDataset1 = Newtonsoft.Json.JsonConvert.SerializeObject(Model.datesDataset1);
  var stateName1 = Newtonsoft.Json.JsonConvert.SerializeObject(Model.stateName1);
  
  var positiveIncreaseDataset2 = Newtonsoft.Json.JsonConvert.SerializeObject(Model.positiveIncreaseDataset2);
  var negativeIncreaseDataset2 = Newtonsoft.Json.JsonConvert.SerializeObject(Model.negativeIncreaseDataset2);
  var datesDataset2 = Newtonsoft.Json.JsonConvert.SerializeObject(Model.datesDataset2);
  var stateName2 = Newtonsoft.Json.JsonConvert.SerializeObject(Model.stateName2);
  
  var positiveIncreaseDataset3 = Newtonsoft.Json.JsonConvert.SerializeObject(Model.positiveIncreaseDataset3);
  var negativeIncreaseDataset3 = Newtonsoft.Json.JsonConvert.SerializeObject(Model.negativeIncreaseDataset3);
  var datesDataset3 = Newtonsoft.Json.JsonConvert.SerializeObject(Model.datesDataset3);
  var stateName3 = Newtonsoft.Json.JsonConvert.SerializeObject(Model.stateName3);
  ViewData["Title"] = "State Information";

#line default
#line hidden
#nullable disable
            WriteLiteral("\n<h2>Task 3</h2>  \n\n<br />\nYour search string 1: \"");
#nullable restore
#line 24 "/home/codio/workspace/covid-web/Views/Task3.cshtml"
                  Write(Model.Input);

#line default
#line hidden
#nullable disable
            WriteLiteral("\"\n<br />\n# of entries found: ");
#nullable restore
#line 26 "/home/codio/workspace/covid-web/Views/Task3.cshtml"
               Write(Model.Count1);

#line default
#line hidden
#nullable disable
            WriteLiteral("\n<br />\nYour search string 2: \"");
#nullable restore
#line 28 "/home/codio/workspace/covid-web/Views/Task3.cshtml"
                  Write(Model.Input2);

#line default
#line hidden
#nullable disable
            WriteLiteral("\"\n<br />\n# of entries found: ");
#nullable restore
#line 30 "/home/codio/workspace/covid-web/Views/Task3.cshtml"
               Write(Model.Count2);

#line default
#line hidden
#nullable disable
            WriteLiteral("\n<br />\nYour search string 3: \"");
#nullable restore
#line 32 "/home/codio/workspace/covid-web/Views/Task3.cshtml"
                  Write(Model.Input3);

#line default
#line hidden
#nullable disable
            WriteLiteral("\"\n<br />\n# of entries found: ");
#nullable restore
#line 34 "/home/codio/workspace/covid-web/Views/Task3.cshtml"
               Write(Model.Count3);

#line default
#line hidden
#nullable disable
            WriteLiteral("\n<br />\n\n<br />\n");
#nullable restore
#line 38 "/home/codio/workspace/covid-web/Views/Task3.cshtml"
  
   if (@Model.EX != null)
	 {

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t <h3>**ERROR: ");
#nullable restore
#line 41 "/home/codio/workspace/covid-web/Views/Task3.cshtml"
                 Write(Model.EX.Message);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\n\t\t <br />\n\t\t <hr />\n\t\t <br />\n\t\t <br />\n");
#nullable restore
#line 46 "/home/codio/workspace/covid-web/Views/Task3.cshtml"
	 }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""box-body"">  
  <div class=""chart-container"">  
     <canvas id=""myChart""></canvas>  
  </div>
  <div class=""chart-container"">  
     <canvas id=""myChart2""></canvas>  
  </div>
  <div class=""chart-container"">  
     <canvas id=""myChart3""></canvas>  
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
#line 68 "/home/codio/workspace/covid-web/Views/Task3.cshtml"
           Write(Html.Raw(datesDataset1));

#line default
#line hidden
#nullable disable
            WriteLiteral(",\n        datasets: [\n        {\n            label: \'Positive Increases \' + ");
#nullable restore
#line 71 "/home/codio/workspace/covid-web/Views/Task3.cshtml"
                                      Write(Html.Raw(stateName1));

#line default
#line hidden
#nullable disable
            WriteLiteral(",  \n            data: ");
#nullable restore
#line 72 "/home/codio/workspace/covid-web/Views/Task3.cshtml"
             Write(Html.Raw(positiveIncreaseDataset1));

#line default
#line hidden
#nullable disable
            WriteLiteral(",\n            borderColor: \"blue\",\n            pointBackgroundColor: \"black\",\n\n            borderWidth: 1\n        }, \n        {\n            label: \'Negative Increase \' + ");
#nullable restore
#line 79 "/home/codio/workspace/covid-web/Views/Task3.cshtml"
                                     Write(Html.Raw(stateName1));

#line default
#line hidden
#nullable disable
            WriteLiteral(",  \n            data: ");
#nullable restore
#line 80 "/home/codio/workspace/covid-web/Views/Task3.cshtml"
             Write(Html.Raw(negativeIncreaseDataset1));

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
                  labelString: 'Positives/Negative Increases',
                  beginAtZero:true
                }
            }]
        }
    }
});

var ctx2 = document.getElementById(""myChart2"");
var myChart2 = new Chart(ctx2, {
    type: 'line',
    data: {
        labels: ");
#nullable restore
#line 112 "/home/codio/workspace/covid-web/Views/Task3.cshtml"
           Write(Html.Raw(datesDataset2));

#line default
#line hidden
#nullable disable
            WriteLiteral(",\n        datasets: [\n        {\n            label: \'Positive Increases \' + ");
#nullable restore
#line 115 "/home/codio/workspace/covid-web/Views/Task3.cshtml"
                                      Write(Html.Raw(stateName2));

#line default
#line hidden
#nullable disable
            WriteLiteral(",  \n            data: ");
#nullable restore
#line 116 "/home/codio/workspace/covid-web/Views/Task3.cshtml"
             Write(Html.Raw(positiveIncreaseDataset2));

#line default
#line hidden
#nullable disable
            WriteLiteral(",\n            borderColor: \"cyan\",\n            pointBackgroundColor: \"black\",\n\n            borderWidth: 1\n        }, \n        {\n            label: \'Negative Increase \' + ");
#nullable restore
#line 123 "/home/codio/workspace/covid-web/Views/Task3.cshtml"
                                     Write(Html.Raw(stateName2));

#line default
#line hidden
#nullable disable
            WriteLiteral(",  \n            data: ");
#nullable restore
#line 124 "/home/codio/workspace/covid-web/Views/Task3.cshtml"
             Write(Html.Raw(negativeIncreaseDataset2));

#line default
#line hidden
#nullable disable
            WriteLiteral(@",
            borderColor: ""purple"",
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
                  labelString: 'Positives/Negative Increases',
                  beginAtZero:true
                }
            }]
        }
    }
});

var ctx3 = document.getElementById(""myChart3"");
var myChart3 = new Chart(ctx3, {
    type: 'line',
    data: {
        labels: ");
#nullable restore
#line 156 "/home/codio/workspace/covid-web/Views/Task3.cshtml"
           Write(Html.Raw(datesDataset3));

#line default
#line hidden
#nullable disable
            WriteLiteral(",\n        datasets: [\n        {\n            label: \'Positive Increases \' + ");
#nullable restore
#line 159 "/home/codio/workspace/covid-web/Views/Task3.cshtml"
                                      Write(Html.Raw(stateName3));

#line default
#line hidden
#nullable disable
            WriteLiteral(",  \n            data: ");
#nullable restore
#line 160 "/home/codio/workspace/covid-web/Views/Task3.cshtml"
             Write(Html.Raw(positiveIncreaseDataset3));

#line default
#line hidden
#nullable disable
            WriteLiteral(",\n            borderColor: \"green\",\n            pointBackgroundColor: \"black\",\n\n            borderWidth: 1\n        }, \n        {\n            label: \'Negative Increase \' + ");
#nullable restore
#line 167 "/home/codio/workspace/covid-web/Views/Task3.cshtml"
                                     Write(Html.Raw(stateName3));

#line default
#line hidden
#nullable disable
            WriteLiteral(",  \n            data: ");
#nullable restore
#line 168 "/home/codio/workspace/covid-web/Views/Task3.cshtml"
             Write(Html.Raw(negativeIncreaseDataset3));

#line default
#line hidden
#nullable disable
            WriteLiteral(@",
            borderColor: ""yellow"",
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
                  labelString: 'Positives/Negative Increases',
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Task3Model> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Task3Model> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Task3Model>)PageContext?.ViewData;
        public Task3Model Model => ViewData.Model;
    }
}
#pragma warning restore 1591
