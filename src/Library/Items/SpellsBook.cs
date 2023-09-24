using System.Collections.Generic;
using System.Collections;

namespace RoleplayGame
{
    public class SpellsBook : IAttack, IDefense, IMagic
    {
        public ArrayList Spells = new ArrayList();
        
        public int AttackValue
        {
            get
            {
                int value = 0;
                foreach (Spell spell in this.Spells)
                {
                    value += spell.AttackValue;
                }
                return value;
            }
        }

        public int DefenseValue
        {
            get
            {
                int value = 0;
                foreach (Spell spell in this.Spells)
                {
                    value += spell.DefenseValue;
                }
                return value;
            }
        }
        public bool Magic {
            get {
                return true;
        }
        }
        public ArrayList GetSpells(){
            return this.Spells;
        }

        public bool AddSpell(Spell sp) {
            if (sp != null) { 
                if (!(this.Spells.Contains(sp))) {
                    this.Spells.Add(sp);
                    return true;
                } else { return false; }
            } else { return false; }
        }
    }
}
