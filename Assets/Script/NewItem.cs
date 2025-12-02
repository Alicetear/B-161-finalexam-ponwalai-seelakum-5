using UnityEngine;

public class NewItem : PowerUpBase
{
    public int JumpBuff;
    public override void ApplyEffect(Player player)
    {
        JumpBuff = 10;
    }
}
