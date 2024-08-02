using DotNetAppSqlDb.Controllers;
using System;

namespace DotNetAppSqlDb.Views
{
    public abstract class ViewAbs : Views, ICloneable
    {
        //instance vaiables
        public static ControllerAbs controller;

        //Functions
        public abstract void input();

        object ICloneable.Clone()
        {
            return this.MemberwiseClone();
        }
    }

}