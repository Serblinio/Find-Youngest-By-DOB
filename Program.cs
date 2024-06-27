
using Find_Youngest_By_DOB;

DateTimeOffset[] datesOffset =
[
    DateTimeOffset.Parse("2022-10-31T08:30:45.123Z"),
    DateTimeOffset.Parse("2019-10-31T08:20:45.123Z"),
    DateTimeOffset.Parse("2021-09-19T08:40:45.123Z"),
    DateTimeOffset.Parse("2023-02-15T08:30:45.123Z"),
    DateTimeOffset.Parse("2023-01-15T08:30:45.123Z")
];

DateTime[] datesTime =
[
    DateTime.Parse("2022-10-31T08:30:45.123"),
    DateTime.Parse("2019-10-31T08:20:45.123"),
    DateTime.Parse("2021-09-19T08:40:45.123"),
    DateTime.Parse("2023-02-15T08:30:45.123"),
    DateTime.Parse("2023-01-15T08:30:45.123")
];

var resultOffset = FindYoungestBirthdays.FindTwoYoungestBirthdays(datesOffset);
var resultTime = FindYoungestBirthdays.FindTwoYoungestBirthdays(datesTime);

Console.WriteLine($"DateTimeOffset: [{resultOffset[0]:O}, {resultOffset[1]:O}]");
Console.WriteLine($"DateTime: [{resultTime[0]:O}, {resultTime[1]:O}]");