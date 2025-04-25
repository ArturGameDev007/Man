using UnityEngine;

public class OpenPanel :MonoBehaviour
{
    [SerializeField] private GameObject _panel;

    public void Open()
    {
        _panel.SetActive(true);
    }

    public void Close()
    {
        _panel.SetActive(false);
        Time.timeScale = 0f;
    }
}