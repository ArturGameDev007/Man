using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelGameTitle :MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI _text;

    private void Start()
    {
        _text.text = SceneManager.GetActiveScene().name;
    }
}
