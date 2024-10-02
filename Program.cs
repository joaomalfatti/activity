namespace activity;

class Program
{
    static void Main()
    {
        ActiviOne myActivity = new ActiviOne();
        ActiviTwo myActivityTwo = new ActiviTwo();
        ActiviTree myActivityTree = new ActiviTree();
        ActiviFour myActivityFour = new ActiviFour();
        ActiviFive myActivityFive = new ActiviFive();
        ActiviSix myActivitySix = new ActiviSix();

        //myActivity.ActivityOne();
        //myActivityTwo.ActivityTwo();
        //myActivityTree.ActivityTree();
        //myActivityFour.RunActivityFour();
        //myActivityFive.ActivityFive();
        myActivitySix.ActivitySix();
    }
}