using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationCore.Models
{
    public class RequestModel
    {
        int currFloor;
        int nextFloor;
        Direction requestDirection;

        public RequestModel(int currFloor, int nextFloor, Direction direction)
        {
            this.currFloor = currFloor;
            this.nextFloor = nextFloor;
            this.requestDirection = direction;
        }
    }

    public enum Direction
    {
        up,
        down
    }

    public enum RequestLocation
    {
        inside,
        outside
    }
}