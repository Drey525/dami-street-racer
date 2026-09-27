using System;
using UnityEngine;

[System.Serializable]
public class PlayerProgress
{
    public string playerId;
    public string playerName;
    public int coins;
    public int xp;
    public int level;
    public string selectedCarId;
    public string[] ownedCars;
    public UpgradeData upgrades;
    public BestTimes bestTimes;

    [System.Serializable]
    public class UpgradeData
    {
        public string carId;
        public int engine;
        public int tires;
        public int nitro;
    }

    [System.Serializable]
    public class BestTimes
    {
        public string trackId;
        public float bestLapTime;
    }

    public static PlayerProgress CreateDefault()
    {
        return new PlayerProgress
        {
            playerId = "player_001",
            playerName = "Dami",
            coins = 500,
            xp = 0,
            level = 1,
            selectedCarId = "car_001",
            ownedCars = new[] { "car_001" },
            upgrades = new UpgradeData
            {
                carId = "car_001",
                engine = 1,
                tires = 1,
                nitro = 1
            },
            bestTimes = new BestTimes
            {
                trackId = "track_01",
                bestLapTime = 0f
            }
        };
    }
}
