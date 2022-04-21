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
        Direction direction;
        RequestLocation requestFrom;

        public RequestModel(int currFloor, int nextFloor, Direction direction, RequestLocation requestFrom)
        {
            this.currFloor = currFloor;
            this.nextFloor = nextFloor;
            this.direction = direction;
            this.requestFrom = requestFrom;
        }
    }

    public enum Direction
    {
        up,
        down,
        stay
    }

    public enum RequestLocation
    {
        inside,
        outside
    }
}