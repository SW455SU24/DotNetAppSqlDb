using Controllers;
using DotNetAppSqlDb.Controllers;
using DotNetAppSqlDb.Models;
using Microsoft.IdentityModel.Clients.ActiveDirectory;
using System.Web.Mvc;

namespace Controllers.ApplicationControllers
{
    public class RoomController : ControllerAbs
    {
        //instance variables
        private Schedule scheduleModel = model as Schedule;
        private Room roomModel = model as Room;

   

        //Functions
        public override void updateModel()
        {
            
        }

        public void viewAvailability()
        {

        }

        public void createRoom()
        {

        }
    }
}