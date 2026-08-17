using System;
public class Enemy
{
    public string Name { get; set; }
    public int Hp { get; set; }
    public int AttackPower { get; set; }

    private Random RandomGenerator { get; } = new Random();

    public int Attack()
    {
        return RandomGenerator.Next(1, AttackPower + 1);
    }
}