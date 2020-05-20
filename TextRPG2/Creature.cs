namespace TextRPG2
{
    public enum CreatureType
    {
        None = 0,
        Player = 1,
        Monster = 2
    }
    public class Creature
    {
        CreatureType type;
        protected Creature(CreatureType type)
        {
            this.type = type;
        }

        protected int hp = 0;
        protected int attack = 0;
        public void SetInfo(int hp, int attack)
        {
            this.hp = hp;
            this.attack = attack;
        }
        public int GetHp()
        {
            return hp;
        }
        public int GetAttack()
        {
            return attack;
        }

        public bool IsDead()
        {
            return hp <= 0;
        }
        public void OnDamaged(int damage)
        {
            hp -= damage;
            if (hp < 0)
            {
                hp = 0;
            }
        }
    }
}