using UnityEngine;
using UnityEngine.UI;

public class Source :MonoBehaviour
{
    [Header("Icons")]
    [SerializeField] private GameObject _onIcon;
    [SerializeField] private GameObject _offIcon;

    [Space(10)]

    [Header("Slider")]
    [SerializeField] private Slider _slider;

    private float _maxValue = 1f;
    private float _minValue = 0f;

    private void Start()
    {
        _slider = GetComponent<Slider>();
        _slider.value = _maxValue;
    }

    private void Update()
    {
        CurrentValue();

        if (_maxValue == _minValue)
        {
            OnIcon(false);
            OffIcon(true);
        }
        else if (_maxValue > _minValue)
        {
            OnIcon(true);
            OffIcon(false);
        }
    }

    private void CurrentValue()
    {
        float currentValue = _slider.value;
        _maxValue = currentValue;
    }

    private void OnIcon(bool value)
    {
        _onIcon.SetActive(value);
    }

    private void OffIcon(bool value)
    {
        _offIcon.SetActive(value);
    }
}
