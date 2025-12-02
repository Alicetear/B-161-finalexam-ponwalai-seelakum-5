using UnityEngine;

public class SpeedBoost : PowerUpBase
{
    public float SetfasterSpeed;
    public override void ApplyEffect(Player player)
    {
        SetfasterSpeed += 10f;
    }
}
