using ApplicationCore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static ApplicationCore.Models.RequestModel;

namespace ApplicationCore.Entities
{
    public class Elevator
    {
        public int currFloor;
        public Direction elevatorDirection;
        public bool isIdle;
        public Queue<RequestModel>? upQueue;
        public Queue<RequestModel>? downQueue;
    }
}
