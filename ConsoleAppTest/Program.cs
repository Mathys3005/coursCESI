using System.Linq.Expressions;

class Program
{ 
    static void Main(string[] args) {
        Dragon dragon = new Dragon("Dragon");
        Griffin griffin = new Griffin("Griffin");
        dragon.move();
        dragon.sleep();
        griffin.move();
        griffin.sleep();

    }
}
