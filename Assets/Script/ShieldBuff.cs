using UnityEngine;

public class ShieldBuff : PowerUpBase
{
    public bool SetIsInvulnerable = true;
    public override void ApplyEffect(Player player)
    {
        if (!IsEffectActive)
        {
            SetIsInvulnerable = true ;
            Debug.Log("Player Take a ShielBuff"); //Player ได้รับเกราะ
        }
    }
}
