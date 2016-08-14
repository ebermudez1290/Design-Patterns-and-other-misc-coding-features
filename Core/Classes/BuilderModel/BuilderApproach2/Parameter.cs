using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Classes.BuilderModel.BuilderApproach2
{
    public class Parameter
    {
        public string A { get; private set; }
        public string B { get; private set; }
        public string C { get; private set; }
        public class Builder
        {
            private string a;
            private string b;
            private string c;
            public Builder WithA(string value)
            {
                a = value;
                return this;
            }
            public Builder WithB(string value)
            {
                b = value;
                return this;
            }
            public Builder WithC(string value)
            {
                c = value;
                return this;
            }
            public Parameter Build()
            {
                return new Parameter { A = a, B = b, C = c };
            }
        }
    }
}
