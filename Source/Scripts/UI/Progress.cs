using UnityEngine;

public class Progress :MonoBehaviour
{
    [SerializeField] private int _coin;

    public int Coin
    {
        get => _coin;
        set => _coin = value;
    }

    public static Progress Instance;

    private void Awake()
    {
        if (Instance == null)
        {
            transform.parent = null;

            DontDestroyOnLoad(gameObject);
            Instance = this;
        }
        else
        {
            gameObject.SetActive(false);
        }
    }
}
