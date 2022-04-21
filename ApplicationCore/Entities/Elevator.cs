using ApplicationCore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationCore.Entities
{
    public class Elevator
    {
        int currFloor;
        bool isIdle;
        Queue<RequestModel> upQueue;
        Queue<RequestModel> downQueue;
    }
}
