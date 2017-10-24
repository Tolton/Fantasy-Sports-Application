using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FantasySportsApplication
{
    class Player
    {
        //Shared info and stats
        public string Name { get; set; }
        public string Team { get; set; }
        public string JerseyNumber { get; set; }
        public string Position { get; set; }
        public int GamesPlayed { get; set; }
        public int Goals { get; set; }
        public int Assists { get; set; }
        public int Points { get; set; }
        public int HatTricks { get; set; }
        public int Penalties { get; set; }
        public int PenaltyMinutes { get; set; }
        public int PowerplayGoals { get; set; }
        public int PowerplayAssists { get; set; }
        public int PowerplayPoints { get; set; }
        public int ShorthandedGoals { get; set; }
        public int ShorthandedAssists { get; set; }
        public int ShorthandedPoints { get; set; }
        public int GameWinningGoals { get; set; }
        public int GameTyingGoals { get; set; }

        //Player-exclusive stats
        public int PlusMinus { get; set; }
        public int Shots { get; set; }
        public float ShotPercentage { get; set; }
        public int Hits { get; set; }
        public int Faceoffs { get; set; }
        public int FaceoffWins { get; set; }
        public int FaceoffLosses { get; set; }
        public float FaceoffPercent { get; set; }

        //Goalie-exclusive stats
        public int Wins { get; set; }
        public int Losses { get; set; }
        public int OvertimeWins { get; set; }
        public int OvertimeLosses { get; set; }
        public int GoalsAgainst { get; set; }
        public int ShotsAgainst { get; set; }
        public int Saves { get; set; }
        public float GoalsAgainstAverage { get; set; }
        public float SavePercentage { get; set; }
        public int Shutouts { get; set; }
        public int GamesStarted { get; set; }
        public int CreditForGame { get; set; }
        public int MinutesPlayed { get; set; }



        //Constructor for Players
        public Player(string Name, string Team, string JerseyNumber, string Position, int GamesPlayed,
            int Goals, int Assists, int Points, int HatTricks, int Penalties, int PenaltyMinutes,
            int PowerplayGoals, int PowerplayAssists, int PowerplayPoints, int ShorthandedGoals,
            int ShorthandedAssists, int ShorthandedPoints, int GameWinningGoals, int GameTyingGoals,
            int PlusMinus, int Shots, float ShotPercentage, int Hits, int Faceoffs, int FaceoffWins,
            int FaceoffLosses, float FaceoffPercent)
        {
            this.Name = Name;
            this.Team = Team;
            this.JerseyNumber = JerseyNumber;
            this.Position = Position;
            this.GamesPlayed = GamesPlayed;
            this.Goals = Goals;
            this.Assists = Assists;
            this.Points = Points;
            this.HatTricks = HatTricks;
            this.Penalties = Penalties;
            this.PenaltyMinutes = PenaltyMinutes;
            this.PowerplayGoals = PowerplayGoals;
            this.PowerplayAssists = PowerplayAssists;
            this.PowerplayPoints = PowerplayPoints;
            this.ShorthandedGoals = ShorthandedGoals;
            this.ShorthandedAssists = ShorthandedAssists;
            this.ShorthandedPoints = ShorthandedPoints;
            this.GameWinningGoals = GameWinningGoals;
            this.GameTyingGoals = GameTyingGoals;
            this.PlusMinus = PlusMinus;
            this.Shots = Shots;
            this.ShotPercentage = ShotPercentage;
            this.Hits = Hits;
            this.Faceoffs = Faceoffs;
            this.FaceoffWins = FaceoffWins;
            this.FaceoffLosses = FaceoffLosses;
            this.FaceoffPercent = FaceoffPercent;
        }

        //Constructor for Goalies
        public Player(string Name, string Team, string JerseyNumber, string Position, int GamesPlayed,
            int Goals, int Assists, int Points, int HatTricks, int Penalties, int PenaltyMinutes,
            int PowerplayGoals, int PowerplayAssists, int PowerplayPoints, int ShorthandedGoals,
            int ShorthandedAssists, int ShorthandedPoints, int GameWinningGoals, int GameTyingGoals,
            int Wins, int Losses, int OvertimeWins, int OvertimeLosses, int GoalsAgainst, int ShotsAgainst,
            int Saves, float GoalsAgainstAverage, float SavePercentage, int Shutouts, int GamesStarted,
            int CreditForGame, int MinutesPlayed)
        {
            this.Name = Name;
            this.Team = Team;
            this.JerseyNumber = JerseyNumber;
            this.Position = Position;
            this.GamesPlayed = GamesPlayed;
            this.Goals = Goals;
            this.Assists = Assists;
            this.Points = Points;
            this.HatTricks = HatTricks;
            this.Penalties = Penalties;
            this.PenaltyMinutes = PenaltyMinutes;
            this.PowerplayGoals = PowerplayGoals;
            this.PowerplayAssists = PowerplayAssists;
            this.PowerplayPoints = PowerplayPoints;
            this.ShorthandedGoals = ShorthandedGoals;
            this.ShorthandedAssists = ShorthandedAssists;
            this.ShorthandedPoints = ShorthandedPoints;
            this.GameWinningGoals = GameWinningGoals;
            this.GameTyingGoals = GameTyingGoals;
            this.Wins = Wins;
            this.Losses = Losses;
            this.OvertimeWins = OvertimeWins;
            this.OvertimeLosses = OvertimeLosses;
            this.GoalsAgainst = GoalsAgainst;
            this.ShotsAgainst = ShotsAgainst;
            this.Saves = Saves;
            this.GoalsAgainstAverage = GoalsAgainstAverage;
            this.SavePercentage = SavePercentage;
            this.Shutouts = Shutouts;
            this.GamesStarted = GamesStarted;
            this.CreditForGame = CreditForGame;
            this.MinutesPlayed = MinutesPlayed;
        }
    }
}
