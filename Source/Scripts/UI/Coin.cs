using UnityEngine;

public class Coin :MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.TryGetComponent(out CoinManager player))
        {
            player.Add();
            Disable();
        }
    }

    private void Disable()
    {
        gameObject.SetActive(false);
    }
}
