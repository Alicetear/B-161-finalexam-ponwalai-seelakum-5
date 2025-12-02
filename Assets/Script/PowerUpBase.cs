using UnityEngine;

public abstract class PowerUpBase : MonoBehaviour
{
    protected bool IsEffectActive = false;
    public abstract void ApplyEffect(Player player);

    public void UpdateEffect(Player player)
    {
        ApplyEffect(player);
        Destroy(this.gameObject);
    }
}
