using UnityEngine;

public class PauseGame :MonoBehaviour
{
    [SerializeField] private PauseButton _button;
    [SerializeField] private PausePanel _panel;

    private void Start()
    {
        _button.Click += ShowPanel;
    }

    private void ShowPanel()
    {
        _panel.Pause();
    }

    public void Close()
    {
        _button.Click -= ShowPanel;
    }
}
