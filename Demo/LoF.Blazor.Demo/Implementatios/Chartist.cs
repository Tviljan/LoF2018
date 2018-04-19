using Microsoft.AspNetCore.Blazor.Browser.Interop;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LoF.Blazor.Demo.Implementatios
{
    public class Chartist : IChartist
    {
        public void Line(string element, ILineData data, ILineOptions options)
        {
            RegisteredFunction.Invoke<bool>(JsFunctionHelper.GetFunctionName(this), element, data, options);
        }
    }

    public class LineData : ILineData
    {
        public string[] labels { get; set; }
        public double[][] series { get; set; }
    }

    public class LineOptions : ILineOptions
    {
        public bool fullWidth { get; set; }
       
    }

}
