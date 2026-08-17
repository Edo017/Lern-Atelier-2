using System;
public class Player
{
    public string Name { get; set; }
    public int Hp { get; set; }
    public int AttackPower { get; set; }
    public Weapon EquippedWeapon { get; set;}

    public Player(string name, int hp, int AttackPower, Weapon EquipppedWeapon)
    {
        Name = name;
        Hp = hp;
        this.AttackPower = AttackPower;
        EquippedWeapon = EquippedWeapon;
    }

    

    private Random RandomGenerator { get; } = new Random();

    public int Attack()
    {
        return RandomGenerator.Next(1, AttackPower + 1);
    }
}