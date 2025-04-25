using System;
using UnityEngine;

public class ButtonClose :ButtonClickSound
{
    [SerializeField] private OpenPanel _panel;

    public event Action ClickClose;

    private void Update()
    {
        _button.onClick.AddListener(OnClick);
    }

    protected override void OnClick()
    {
        base.OnClick();

        _button.onClick.RemoveListener(OnClick);
        _panel.Close();

        ClickClose?.Invoke();
    }
}
