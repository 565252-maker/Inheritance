using UnityEngine;

public class FriendlyOrc : OrcScript
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        AttackPlayer();
    }

    public override void AttackPlayer()
    {
        print("Friendly orc is attacking player");
    }
}
