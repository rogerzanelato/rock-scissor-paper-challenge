using RockPaperScissor.Game;
using RockPaperScissor.Interfaces;
using System;
using System.Collections.Generic;

namespace RockPaperScissor
{
    class Program
    {
        static void Main(string[] args)
        {
            Tournament Tournament = new Tournament();
            TournamentKey TournamentKey1 = CreateTournamentKey1();
            TournamentKey TournamentKey2 = CreateTournamentKey2();
            TournamentKey TournamentKey3 = CreateTournamentKey3();
            TournamentKey TournamentKey4 = CreateTournamentKey4();

            IList<ITournamentKey> tournamentKeys = new List<ITournamentKey>();
            tournamentKeys.Add(TournamentKey1);
            tournamentKeys.Add(TournamentKey2);
            // Uncomment to test the game with more nested braces
            //tournamentKeys.Add(TournamentKey3);
            //tournamentKeys.Add(TournamentKey4);

            Tournament.TournamentKeys = tournamentKeys;

            Tournament.CalculateTournamentWinner();
        }

        static TournamentKey CreateTournamentKey1()
        {
            IList<IPlayer> players1 = new List<IPlayer>();
            players1.Add(new Player()
                {
                    Name = "Armando",
                    Strategy = new Strategy
                    {
                        Move = "P"
                    }
                });
            players1.Add(new Player()
                {
                    Name = "Dave",
                    Strategy = new Strategy
                    {
                        Move = "S"
                    }
                });

            Match match1 = new Match();
            match1.Rule = new Rule();
            match1.Players = players1;

            IList<IPlayer> players2 = new List<IPlayer>();
            players2.Add(new Player()
            {
                Name = "Richard",
                Strategy = new Strategy
                {
                    Move = "R"
                }
            });
            players2.Add(new Player()
            {
                Name = "Michael",
                Strategy = new Strategy
                {
                    Move = "S"
                }
            });

            Match match2 = new Match();
            match2.Rule = new Rule();
            match2.Players = players2;

            TournamentKey TournamentKey1 = new TournamentKey();

            IList<IMatch> matches = new List<IMatch>();
            matches.Add(match1);
            matches.Add(match2);

            TournamentKey1.Matches = matches;

            return TournamentKey1;
        }

        static TournamentKey CreateTournamentKey2()
        {
            IList<IPlayer> players1 = new List<IPlayer>();
            players1.Add(new Player()
                {
                    Name = "Allen",
                    Strategy = new Strategy
                    {
                        Move = "S"
                    }
                });
            players1.Add(new Player()
                {
                    Name = "Omer",
                    Strategy = new Strategy
                    {
                        Move = "P"
                    }
                });

            Match match1 = new Match();
            match1.Rule = new Rule();
            match1.Players = players1;

            IList<IPlayer> players2 = new List<IPlayer>();
            players2.Add(new Player()
            {
                Name = "David E.",
                Strategy = new Strategy
                {
                    Move = "R"
                }
            });
            players2.Add(new Player()
            {
                Name = "Richard X.",
                Strategy = new Strategy
                {
                    Move = "P"
                }
            });

            Match match2 = new Match();
            match2.Rule = new Rule();
            match2.Players = players2;

            TournamentKey TournamentKey1 = new TournamentKey();

            IList<IMatch> matches = new List<IMatch>();
            matches.Add(match1);
            matches.Add(match2);

            TournamentKey1.Matches = matches;

            return TournamentKey1;
        }

        static TournamentKey CreateTournamentKey4()
        {
            IList<IPlayer> players1 = new List<IPlayer>();
            players1.Add(new Player()
                {
                    Name = "John Bi.",
                    Strategy = new Strategy
                    {
                        Move = "S"
                    }
                });
            players1.Add(new Player()
                {
                    Name = "Osmar X.",
                    Strategy = new Strategy
                    {
                        Move = "R"
                    }
                });

            Match match1 = new Match();
            match1.Rule = new Rule();
            match1.Players = players1;

            IList<IPlayer> players2 = new List<IPlayer>();
            players2.Add(new Player()
            {
                Name = "Charles Boolean",
                Strategy = new Strategy
                {
                    Move = "R"
                }
            });
            players2.Add(new Player()
            {
                Name = "Uncle Bob",
                Strategy = new Strategy
                {
                    Move = "S"
                }
            });

            Match match2 = new Match();
            match2.Rule = new Rule();
            match2.Players = players2;

            TournamentKey TournamentKey1 = new TournamentKey();

            IList<IMatch> matches = new List<IMatch>();
            matches.Add(match1);
            matches.Add(match2);

            TournamentKey1.Matches = matches;

            return TournamentKey1;
        }
        static TournamentKey CreateTournamentKey3()
        {
            IList<IPlayer> players1 = new List<IPlayer>();
            players1.Add(new Player()
                {
                    Name = "John",
                    Strategy = new Strategy
                    {
                        Move = "R"
                    }
                });
            players1.Add(new Player()
                {
                    Name = "Osmar",
                    Strategy = new Strategy
                    {
                        Move = "S"
                    }
                });

            Match match1 = new Match();
            match1.Rule = new Rule();
            match1.Players = players1;

            IList<IPlayer> players2 = new List<IPlayer>();
            players2.Add(new Player()
            {
                Name = "David Bool.",
                Strategy = new Strategy
                {
                    Move = "S"
                }
            });
            players2.Add(new Player()
            {
                Name = "Richard Weber.",
                Strategy = new Strategy
                {
                    Move = "R"
                }
            });

            Match match2 = new Match();
            match2.Rule = new Rule();
            match2.Players = players2;

            TournamentKey TournamentKey1 = new TournamentKey();

            IList<IMatch> matches = new List<IMatch>();
            matches.Add(match1);
            matches.Add(match2);

            TournamentKey1.Matches = matches;

            return TournamentKey1;
        }
    }
}
