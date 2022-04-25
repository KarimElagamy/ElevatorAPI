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
        Task<int> RequestElevator(int currFloor);
        Task<int> RequestFloor(int currFloor, int nextFloor);

    }
}
