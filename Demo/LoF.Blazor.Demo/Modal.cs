using Microsoft.AspNetCore.Blazor.Browser.Interop;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace LoF.Blazor.Demo
{
 
    public class Modal 
    {
        private string _elementId;
        private object _modalJsObjectId;
        public Modal(string elementId)
        {
            _elementId = elementId;
            _modalJsObjectId = RegisteredFunction.Invoke<bool>(JsFunctionHelper.GetFunctionName(this), elementId, null);

        }

        public void Show()
        {

            var s = typeof(Modal).FullName;

            RegisteredFunction.Invoke<string>(JsFunctionHelper.GetFunctionName(this));
        }


    }
}
