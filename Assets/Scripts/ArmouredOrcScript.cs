using UnityEngine;

public class ArmouredOrcScript : OrcScript
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        AttackPlayer();
    }

    public override void AttackPlayer()
    {
        print("Armoured orc is attacking player");
    }
}
