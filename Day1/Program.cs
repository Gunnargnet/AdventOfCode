using AocUtils;

var lines = Utils.GetImportedData("day1.txt");
var total2star = 0;
var total1star = 0;

foreach (var line in lines)
{
    var realString = line;

    realString = realString.Replace("one", "one1one");
    realString = realString.Replace("two", "two2two");
    realString = realString.Replace("three", "three3three");
    realString = realString.Replace("four", "four4four");
    realString = realString.Replace("five", "five5five");
    realString = realString.Replace("six", "six6six");
    realString = realString.Replace("seven", "seven7seven");
    realString = realString.Replace("eight", "eight8eight");
    realString = realString.Replace("nine", "nine9nine");

    var result1star = line.Where(x => char.IsDigit(x)).ToList();
    var stringNumber1star = result1star.First().ToString() + result1star.Last().ToString();

    var result2star = realString.Where(x => char.IsDigit(x)).ToList();
    var stringNumber2star = result2star.First().ToString() + result2star.Last().ToString();

    total1star += int.Parse(stringNumber1star);
    total2star += int.Parse(stringNumber2star);
}

Console.WriteLine(total1star);
Console.WriteLine(total2star);



