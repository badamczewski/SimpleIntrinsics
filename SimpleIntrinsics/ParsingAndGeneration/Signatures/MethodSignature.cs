using System.Collections.Generic;

namespace SimpleIntrinsics.ParsingAndGeneration
{
    public class MethodSignature
    {
        public string ParentClass;
        public string Name;
        public string ReturnType;
        public bool IsUnsafe;
        public List<ArgumentSignature> Arguments;
    }
}
