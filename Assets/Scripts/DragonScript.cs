using UnityEngine;

public class DragonScript : EnemyBase
{
    public override void AttackPlayer()
    {
        print("Dragon is attacking player");
    }

    private void Start()
    {
        AttackPlayer();
    }
}
