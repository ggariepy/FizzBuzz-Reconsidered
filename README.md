# FizzBuzz-Reconsidered
A rethinking of FizzBuzz using C# 9.0 records and an extensible design

This code was inspired after I watched Tom Scott's "FizzBuzz: One Simple Interview Question" (https://www.youtube.com/watch?v=QPZ0pIK_wsc) and wondered how I would approach a 
solution to a hypothetical hiring manager's question of how to make a simple FizzBuzz program more extensible, easily maintained, and well documented.

This thinking led me to utilize C# 9.0's new record type to create a series of conditions under which the FizzBuzz outputs would be rendered to the screen.  I also accomplished
Mr. Scott's objectives of making it easy to switch up the divisors by only having them listed in one place in the program.  In addition, I made it simple to 
extend the range of integers to be tested by creating static readonly min and max integers, also stored only in one place.

Is this overkill for FizzBuzz?  Yes.  Undoubtedly.  Personally my go-to approach is usually the simplest one that gets the job done.  That being said, code can be written
for a variety of reasons, not the least of which is to maximize future modification, which this code attempts to do.  Sometimes you gotta just get it done, other times
you know things are going to change and you want to make it as easy as possoble for your future self (or team members) to roll with the punches.

