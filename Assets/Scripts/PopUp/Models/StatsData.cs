namespace PopUp
{
    public class StatsData
    {
        public float MoveSpeed { get; }
        public float Intelligence { get; }
        public float Stamina { get; }
        public float Damage { get; }
        public float Dexterity { get; }
        public float Regeneration { get; }

        public StatsData(
            float moveSpeed,
            float intelligence,
            float stamina,
            float damage,
            float dexterity,
            float regeneration
            )
        {
            MoveSpeed = moveSpeed;
            Intelligence = intelligence;
            Stamina = stamina;
            Damage = damage;
            Dexterity = dexterity;
            Regeneration = regeneration;
        }
    }
}