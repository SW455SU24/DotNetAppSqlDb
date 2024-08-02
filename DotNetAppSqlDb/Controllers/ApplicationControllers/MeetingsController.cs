using Controllers;
using DotNetAppSqlDb.Controllers;
using DotNetAppSqlDb.Models;
using Microsoft.IdentityModel.Clients.ActiveDirectory;
using System.Web.Mvc;

namespace Controllers.ApplicationControllers
{
    public class MeetingsController : ControllerAbs
    {
        //instance variables
        Meeting meetingModel = model as Meeting;
        Room roomModel = model as Room;
        Schedule scheduleModel = model as Schedule;

        //Functions
        public override void updateModel()
        {

        }

        public void createNewMeeting()
        {

        }
    }
}