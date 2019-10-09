namespace Tomagatchi.Models
{
    public class TomagatchiPlayer
    {
        public string Name{get;set;}
        public int FoodLevel {get;set;}
        public static TomagatchiPlayer Instance = new TomagatchiPlayer("Nikhil");
        public int SleepLevel {get;set;}
        // maybe set these too booleans insetad of ints and then set them to false when they need to be fed or what not and then set them to true after a set amount of time. 
        public int BoredomLevel {get;set;}
    public TomagatchiPlayer(string aName)
    {
        Name = aName;
        FoodLevel = 100;
        SleepLevel = 100;
        BoredomLevel = 100;
    }
    public void PlayWith()
    {
        BoredomLevel += 90;
    }
    public void Feed()
    {
        FoodLevel +=80;
    }
    public void PutToSleep()
    {
        SleepLevel+=40;
    }

    public void Decrement(string propertyName, int valueToDecrease)
    {
            int value = (int)this.GetType().GetProperty(propertyName).GetValue(this,null);
            value -= valueToDecrease;
            this.GetType().GetProperty(propertyName).SetValue(this,value);
    }
    }
}