﻿using ParkingLotApi.Models;

namespace ParkingLotApi.Repositories
{
    public interface IParkingLotsReposity
    {
        public Task<ParkingLot> CreateParkingLot(ParkingLot parkingLot);

    }
}