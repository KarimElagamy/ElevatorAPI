using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ApplicationCore.Models;

namespace ApplicationCore.Contracts.Services
{
    public interface IPersonService
    {
        public void requestElevator(int currFloor);
        public void requestFloor(int currFloor, int nextFloor);

    }
}
