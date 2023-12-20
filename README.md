# 8_Queens_GA

## Purpose

Hand-crafting a genetic algorithm from scratch to solve the classic [8 Queens problem ](https://en.wikipedia.org/wiki/Eight_queens_puzzle) was a very enjoyable experience and I left with a deep intuition of how the algorithm works with the ability to know how to apply this to any practial application. More than merely understand the nuances of the algorithm I more importantly learned how to approach problems with creative problem solving and was given a new toolset to work with.

## The Board

The board and the “Clashes” are the best value from all iterations / generations. The board simply displays what that configuration would look like if the queens were placed on a board.

## Algorithm Explained

![genetic algorithm](https://github.com/williammcintosh/8_Queens_GA/blob/main/images/Screen%20Shot%202021-06-26%20at%2011.44.19%20PM.png)

### Initial Population
Each parent / child / being is simply a string of characters, each element representing a position of a queen on the board. Since no two Queens have the same column or row, this works out well.

The initial population is how many of those strings we use. Though we call it “initial” the population will never increase nor decrease throughout the algorithm. This is selected from the user in the simulation.

### Fitness Function

We calculate the amount of clashes that represents each configuration, and the lower value is better. The lesser number of Queen clashes, the more valuable the string is. Its value is calculated as a percentage of the total number of all clashes from all strings in the entire population. We want to have a higher percentage for the strings that have the optimal configuration of Queens. To do this, we take the highest possible number of clashes for eight Queens on an eight by eight board (which is 28) and subtract the number of clashes of any given string. Each string is also assigned (by sharing the same element location through the different arrays) a fitness value, and a fitness percentage in contrast to its peers.

![equation one](https://github.com/williammcintosh/8_Queens_GA/blob/main/images/Screen%20Shot%202021-06-26%20at%2011.46.29%20PM.png)

### Selection

Each string is selected to be a parent for reproduction based on random chance, with the higher percentage going to the strings with the highest fitness percentage.

### Crossover

We go through the entire array of selected parents in pairs of two. To each pair, a random location is selected from 1-7 which divides the two parents in half, then one parent of the pair gets the first half of that division while the other parent gets the other half.

### Mutation

Then, each child gets to “roll the die” based on the mutation percentage set by the user in the simulation. If mutation percent is for example as 0.05, some simple arithmetic is completed to make it into a whole number and also the decimal locations are stored. Then a random number is selected 0-100 and if the number is 5 is randomly selected, then that string gets chosen for mutation.

Once a string is chosen for mutation a random number 0-7 is created which represents the element in the string which states where the random number swap will take place. Lastly, another random number is generated 1-8 which then replaces the old number only if it’s not the same number as the previous one.

### Iterations

This whole cycle repeats by the number of iterations selected by the user. Since the optimal values are given a higher percentage and are more likely to be randomly selected as parents for reproduction, then running this algorithm in more iterations increases the chances of that taking place.

## Testing

The optimal settings for this is determined by how quickly the algorithm finds the optimal solution, which speed in this situation will be determined by the number of iterations. Did the settings reach the optimal solution? How many iterations did it take to reach its optimal solution? I call this the “Generation Peak Reached” meaning which generation first arrived to the peak.

![results](https://github.com/williammcintosh/8_Queens_GA/blob/main/images/Screen%20Shot%202021-06-26%20at%2011.42.41%20PM.png)
