using System;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class RestartButton :MonoBehaviour
{
    [SerializeField] private Button _button;

    public event Action Click;

    private void Start()
    {
        _button.onClick.AddListener(OnClick);
    }

    private void OnClick()
    {
        _button.onClick.RemoveListener(OnClick);

        Click?.Invoke();

        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
