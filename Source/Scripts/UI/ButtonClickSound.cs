using UnityEngine;
using UnityEngine.UI;

public abstract class ButtonClickSound :MonoBehaviour
{
    [SerializeField] protected Button _button;
    [SerializeField] protected AudioSource _sound;

    protected virtual void OnClick()
    {
        _sound.Play();
    }
}
