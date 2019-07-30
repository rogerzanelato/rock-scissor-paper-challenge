const RockScissorPaper = (function() {
  const rps_game_winner = arr => {
    if (arr.length > 2) {
      console.error("There must be just two players per game");
      return;
    }

    const validMoves = ["R", "P", "S"];
    const player1 = arr[0];
    const player2 = arr[1];
    const [name1, move1] = player1;
    const [name2, move2] = player2;

    if (!validMoves.includes(move1) || !validMoves.includes(move2)) {
      console.error("The strategy must be: " + validMoves.join(", "));
      return;
    }

    if (move1 === move2) {
      console.log(`Same moves, ${name1} wins..`);
      return player1;
    }

    const combinationToWin = {};
    combinationToWin.R = "S";
    combinationToWin.S = "P";
    combinationToWin.P = "R";

    const moveToWin = combinationToWin[[move1]];
    const winner = moveToWin === move2 ? player1 : player2;

    console.log(
      `${name1} (${move1}) x ${name2} (${move2}): %c${winner[0]} won!`,
      "color: green"
    );

    return winner;
  };

  const rps_tournament_winner = tournament => {
    const winnersMatch = [];
    let match = [];
    let indice = 0;

    tournament.forEach(it => {
      // If it's not an array, we're on the last level of the JSON
      if (!Array.isArray(it)) {
        return;
      }

      // If we are not at the match level, we're gonna execute the function again until we find a winner
      const isMatchLevel = typeof it[0][0] === "string";
      if (isMatchLevel) {
        winner = rps_game_winner(it);
      } else {
        winner = rps_tournament_winner(it);
        if (!winner) {
          return;
        }
      }

      match.push(winner);
      indice++;

      if (indice === 2) {
        winnersMatch.push(match);

        indice = 0;
        match = [];
      }
    });

    if (winnersMatch.length > 1) {
      return rps_tournament_winner(winnersMatch);
    }

    return rps_game_winner(winnersMatch[0]);
  };

  return { rps_tournament_winner };
})();

let jsonSample = [
  [[["Armando", "P"], ["Dave", "S"]], [["Richard", "R"], ["Michael", "S"]]],
  [[["Allen", "S"], ["Omer", "P"]], [["David E.", "R"], ["Richard X.", "P"]]]
];

const [nameWinner, move] = RockScissorPaper.rps_tournament_winner(jsonSample);

console.log(
  `%c${nameWinner} is the great champion!`,
  "color: green; background-color: Lightgreen; padding: 3px 5px;"
);
