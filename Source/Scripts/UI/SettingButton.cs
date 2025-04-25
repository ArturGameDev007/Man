using System;
using UnityEngine;

public class SettingButton :ButtonClickSound
{
    [SerializeField] private OpenPanel _panel;

    public event Action Click;

    private void Update()
    {
        _button.onClick.AddListener(OnClick);
    }

    protected override void OnClick()
    {
        base.OnClick();

        _button.onClick.RemoveListener(OnClick);
        _panel.Open();

        Click?.Invoke();
    }
}
