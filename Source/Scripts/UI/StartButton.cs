using System;

public class StartButton :MainButtons
{
    public event Action Click;

    private void Start()
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
