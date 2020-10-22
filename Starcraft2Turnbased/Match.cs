using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Starcraft2Turnbased
{
    public class Match
    {
        List<Player> players;
        int timer;
        int turn;
        Player player;
        Map map;

        public Match()
        {
            players = new List<Player>();
            players.Add(new Terran());
            players.Add(new Terran());
            player = players[0];
            map = new Map(1000, 1000, new Map.StartLocation(50, 50), new Map.StartLocation(950, 950));
            map.StartLocations.Shuffle();
            for (int i =0; i < players.Count(); i++)
            {
                var player = players[i];
                var startpos = map.StartLocations[i];
                player.Structures.First().Position = new Vector3(startpos.x, startpos.y, 0);
            }
        }
    }
}
