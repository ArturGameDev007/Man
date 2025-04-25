using UnityEngine;

public class Obstacle :MonoBehaviour
{
    [SerializeField] private BoxCollider _collider;

    private void Awake()
    {
        _collider = GetComponent<BoxCollider>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.TryGetComponent(out Player player))
        {
            player.Die();
            Enable();
        }
    }

    private void Enable()
    {
        _collider.enabled = false;
    }
}
