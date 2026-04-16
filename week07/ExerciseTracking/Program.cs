// Hi, the screenshot of the program output is included in this project folder. Thank you.

List<Activity> activities = new List<Activity>();

activities.Add(new Running("03 Nov 2022", 30, 5.0));
activities.Add(new Cycling("03 Nov 2022", 45, 20.0));
activities.Add(new Swimming("03 Nov 2022", 30, 40));

foreach (Activity activity in activities)
{
    Console.WriteLine(activity.GetSummary());
}