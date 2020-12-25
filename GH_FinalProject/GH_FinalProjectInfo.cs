using System;
using System.Drawing;
using Grasshopper;
using Grasshopper.Kernel;

namespace GH_FinalProject
{
    public class GH_FinalProjectInfo : GH_AssemblyInfo
    {
        public override string Name => "GH_FinalProject Info";

        //Return a 24x24 pixel bitmap to represent this GHA library.
        public override Bitmap Icon => null;

        //Return a short string describing the purpose of this GHA library.
        public override string Description => "";

        public override Guid Id => new Guid("03867DC0-10C2-49F1-8EFB-66A7335C6D2D");

        //Return a string identifying you or your company.
        public override string AuthorName => "";

        //Return a string representing your preferred contact details.
        public override string AuthorContact => "";
    }
}