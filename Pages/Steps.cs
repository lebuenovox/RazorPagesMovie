using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RazorPagesMovie.Pages
{
    public class Steps
    {     
        public string Step1 { get; private set; }
        public string Step2 { get; private set; }
        public string Step3 { get; private set; }

        public Steps(bool exibirStep1, bool exibirStep2, bool exibirStep3)
        {
            Step1 = exibirStep1 ? "block": "none";
            Step2 = exibirStep2 ? "block" : "none";
            Step3 = exibirStep3 ? "block" : "none";
        }
    }
}
