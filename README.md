# Rock-Paper-Scissors

Rock-Paper-Scissors game with some home-cooked machine learning where the computer tries different strategies and always picks the most winning one.

## Description

The game is a WinForm application pitting a human against a computer opponent. 

On startup, a game is started and the game log is displayed centrally. Using the three buttons, the player can make a Rock, Paper or Scissors move, and the computer will make a move too.

The computer is loaded with a variety of different strategies for making a move, and initially will randomly try each one for a set number of turns, to create a score for each strategy. After this setup time, the most winning strategy will be picked.

## Example of "learning"

To see the "learning" in action, start by playing moves until the full strategy-map is populated, then start playing always the same move (i.e. always paper). After some moves, the computer will pick the counter strategy correctly (in this case for instance, always scissors)

## Easter Egg

One strategy that lives in the code is the "psychic" strategy, which can cheat and can read the player move to return the perfect counter. This strategy is not added in the code, since given enough time, the computer will realise it's always the winning strategy.