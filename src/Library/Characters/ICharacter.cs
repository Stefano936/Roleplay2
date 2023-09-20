namespace RoleplayGame
{
    public interface ICharacter
    {
        string Name { get; set; }
        
        Bow Bow { get; set; }

        Helmet Helmet { get; set; }

        int AttackValue{ get; }

        int DefenseValue{ get; }
        int Health {get;}
        void ReceiveAttack(int power) { }

        void Cure() { }
    }
}