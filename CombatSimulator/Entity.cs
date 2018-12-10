namespace CombatSimulator
{
    public class Entity
    {
        public int health;
        public int damage;
        public bool isAlive;
        public float chanceToHit;
        public float chanceToEvade;
        public float chanceToBlock;

        public Entity()
        {
            health = 0;
            damage = 0;
            isAlive = false;
            chanceToHit = 0.0f;
            chanceToEvade = 0.0f;
            chanceToBlock = 0.0f;
        }

        public Entity(int health, int damage, bool isAlive, float chanceToHit, float chanceToEvade, float chanceToBlock)
        {
            this.health = health;
            this.damage = damage;
            this.isAlive = isAlive;
            this.chanceToHit = chanceToHit;
            this.chanceToEvade = chanceToEvade;
            this.chanceToBlock = chanceToBlock;
        }

        public virtual void Update()
        {

        }

        public virtual void ReceiveDamage(int damage)
        {
            health -= damage;

            if (health <= 0)
                Kill();
        }

        public virtual void Kill()
        {
            health = -1;
            damage = -1;
            isAlive = false;
        }
    }
}