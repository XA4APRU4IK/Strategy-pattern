using System;
using Strategy_Pattern;
public interface IWeapon
{
    void UseWeapon();
}
public class Program
{
    public static void Main(string[] args)
    {
        Game game = new Game();
        game.Start();
    }
}
