using UnityEngine;

public abstract class Window :MonoBehaviour
{
    [SerializeField] private EndPanelAnimation _animation;
    [SerializeField] private AudioSource _sound;
    [SerializeField] private AudioSource _gameplay;

    protected internal virtual void Enable()
    {
        ActiveWindow();
        DisableSoundGameplay();
        SoundPlay();
    }

    private void ActiveWindow()
    {
        gameObject.SetActive(true);
        _animation.Play();
    }

    private void DisableSoundGameplay()
    {
        _gameplay.enabled = false;
    }

    private void SoundPlay()
    {
        _sound.Play();
    }
}
