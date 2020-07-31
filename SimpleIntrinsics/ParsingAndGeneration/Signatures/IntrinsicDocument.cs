using System.Collections.Generic;

namespace SimpleIntrinsics.ParsingAndGeneration
{
    public class IntrinsicDocument
    {
        public IEnumerable<CSharpToIntrinsicMethod> Methods;
        public string ClassName;
    }
}
