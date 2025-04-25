using UnityEngine;

public class Finish :MonoBehaviour
{
    [SerializeField] private GameObject _effect;

    private void OnTriggerEnter(Collider other)
    {
        if (other.TryGetComponent(out Player player))
        {
            player.Finish();
            Instantiate(_effect, transform.position, transform.rotation);
        }
    }
}
