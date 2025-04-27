using UnityEngine;

public class PausePanel :MonoBehaviour
{
    //[SerializeField] private GameObject _camera;
    [SerializeField] private PlayerMove _player;

    private float _stoppingTime = 0f;
    private float _playingTime = 1f;

    public void Pause()
    {
        Time.timeScale = _stoppingTime;
        _player.enabled = false;

        Activity(true);
    }

    public void Play()
    {
        Time.timeScale = _playingTime;
        Activity(false);
    }

    private void Activity(bool value)
    {
        if (Time.timeScale == _stoppingTime)
        {
            gameObject.SetActive(value);
            //_camera.SetActive(false);
        }
        else if (Time.timeScale == _playingTime)
        {
            gameObject.SetActive(value);
            _player.Enable();

            //_camera.SetActive(true);
        }
    }
}