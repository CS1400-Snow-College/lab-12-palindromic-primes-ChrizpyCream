# Lab-10-Pallindromic-Primes

Please read the write up available in canvas

Hints
Recall that we can use the modulus operator to see if a number is evenly divisible by another number. E.g. 104 % 7 != 0 so that means that 104 is not divisible by 7, but 104 % 4 == 0 so that means that 104 is divisible by 4.
Remember that the ToString() method will create a string that looks like a particular integer. In other words: 34.ToString() == "34".
Recognize that you don't necessarily need to store the palindromic primes in order to find the nth one. Instead, you can just keep track of how many you have found (e.g. with an integer counter). There are other things you can do to speed things up (or to practice), but those are optional (see below only if you are interested).