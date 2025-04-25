using UnityEngine;

public class SettingMenu :MonoBehaviour
{
    [SerializeField] private EndPanelAnimation _animation;

    protected internal virtual void Enable()
    {
        gameObject.SetActive(true);
        _animation.Play();
    }
}
