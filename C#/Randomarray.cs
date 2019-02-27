6

Generate 3 * 1..100 numbers
Shuffle them
Iterate shuffled collection
Sample:

var random = new Random();
var maxRepetitionsCount = 3;
var numbers = Enumerable.Range(1,100)
       .SelectMany(i => Enumerable.Repeat(i, maxRepetitionsCount))
       .OrderBy(i => random.Next())
       .ToList();
NOTE: There is no option to keep tracking on occurrences count without tracking occurrences count. It's like "I want to do X without doing X"
