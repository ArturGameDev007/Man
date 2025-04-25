using UnityEngine;

public class Progress :MonoBehaviour
{
    public int Coin;

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
