using DotNetAppSqlDb.Models;
using System;

namespace DotNetAppSqlDb.Controllers
{
    public abstract class ControllerAbs : Controllers, ICloneable
    {
        //instance vaiables
        public static ModelAbs model;

        //Functions
        public abstract void updateModel();

        object ICloneable.Clone()
        {
            return this.MemberwiseClone();
        }
    }

}