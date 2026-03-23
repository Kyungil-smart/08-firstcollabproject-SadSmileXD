public class EnemyBlackboard
{
    public EnemyData origin;
    public int currentHp;
    
    // state 변화를 위한 flagements
    public bool isAttacking;
    public bool isDead;
    public bool isFollowing;
    public bool isDamaged;

    public EnemyBlackboard(EnemyData origin)
    {
        this.origin = origin;
        currentHp = origin.maxHp;
    }
}