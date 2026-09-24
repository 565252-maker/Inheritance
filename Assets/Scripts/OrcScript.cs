using UnityEngine;

public class OrcScript : EnemyBase
{
    public override void AttackPlayer()
    {
        print("Orc is attacking player");
    }

    private void Start()
    {
        AttackPlayer();
    }
}
