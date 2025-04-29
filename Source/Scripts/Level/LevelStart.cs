using UnityEngine;

public class LevelStart :MonoBehaviour
{
    [Header("StartButton")]
    [SerializeField] private StartButton _button;

    [Space(10)]

    [Header("Player")]
    [SerializeField] private Player _player;

    private void Start()
    {
        _button.Click += OnCLick;
    }

    private void OnCLick()
    {
        _player.StartLevel();
        _button.Click -= OnCLick;
    }
}
