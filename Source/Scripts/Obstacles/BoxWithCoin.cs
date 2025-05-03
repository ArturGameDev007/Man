using UnityEngine;

public class BoxWithCoin :MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.TryGetComponent(out CoinManager player))
        {
            player.BonusCoin();
            Disable();
        }
    }

    private void Disable()
    {
        gameObject.SetActive(false);
    }
}
