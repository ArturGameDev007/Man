using System;

public class NextLevelButton :ButtonClickSound
{
    public event Action Click;

    private void Update()
    {
        _button.onClick.AddListener(OnClick);
    }

    protected override void OnClick()
    {
        base.OnClick();

        _button.onClick.RemoveListener(OnClick);

        Click?.Invoke();
    }
}
