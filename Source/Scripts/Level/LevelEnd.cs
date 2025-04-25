using UnityEngine;

public class LevelEnd :MonoBehaviour
{
    [Header("Player")]
    [SerializeField] private Player _player;

    [Space(10)]

    [Header("Windows")]
    [SerializeField] private WinView _winView;
    [SerializeField] private LoseView _loseView;

    private void Start()
    {
        _player.Finished += OnFinish;
        _player.Died += OnDie;
    }

    private void OnFinish()
    {
        _winView.Enable();
    }

    private void OnDie()
    {
        _loseView.Enable();
    }

    public void End()
    {
        _player.Finished -= OnFinish;
        _player.Died -= OnDie;
    }
}
