namespace NPCs
{
    public interface IEnemy : INPC
    {
        void Attack();
        void RegenerateLife();
        void Die();
    }
}