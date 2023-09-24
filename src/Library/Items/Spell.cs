namespace RoleplayGame
{
    public class Spell :IAttack, IDefense, IMagic
    {
        public Spell() {}

        public int AttackValue
        {
            get
            {
                return 70;
            }
        }

        public int DefenseValue
        {
            get
            {
                return 70;
            }
        }

        public bool Magic{
            get {
                return true;
            }
        }
    }
}