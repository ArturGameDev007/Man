using UnityEngine;

public class BoxWithCoin :MonoBehaviour
{
    [SerializeField] private GameObject _effect;

    private void OnTriggerEnter(Collider other)
    {
        if (other.TryGetComponent(out CoinManager player))
        {
            player.BonusCoin();

            Disable();
            Instantiate(_effect, transform.position, transform.rotation);
        }
    }

    private void Disable()
    {
        gameObject.SetActive(false);
    }
}
