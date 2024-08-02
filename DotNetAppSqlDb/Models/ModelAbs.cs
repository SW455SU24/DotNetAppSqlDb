using System;
using System.Web.Services.Description;
using DotNetAppSqlDb.Views;

namespace DotNetAppSqlDb.Models
{
    public abstract class ModelAbs : Model, ICloneable
    {
        //instance vaiables
        public static ViewAbs view;

        //Functions
        public abstract void updateView();

        object ICloneable.Clone()
        {
            return this.MemberwiseClone();
        }
    }

}