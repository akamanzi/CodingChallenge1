// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

 class EventsClass
{
    public static void Main()
    {
        var numberFiveCounter = new CountToFive();
        numberFiveCounter.numberFiveReached += HandleEvent;
        numberFiveCounter.OnnumberFiveReached();
    }

    static void HandleEvent(object sender, EventArgs e)
    {
        Console.WriteLine("Counter has reached to number 5!!!!");
    }
}
class CountToFive
{
    public event EventHandler numberFiveReached;
    
    public void OnnumberFiveReached()
    {
        for(int i=0; i <= 10; i++)
        {
            if(i == 5)
            {
                numberFiveReached?.Invoke(this, EventArgs.Empty);
            }
        }
        
    }


}