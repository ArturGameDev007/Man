using DG.Tweening;
using UnityEngine;
using UnityEngine.UI;

public abstract class MainButtons :MonoBehaviour
{
    [Header("Button")]
    [SerializeField] protected Button _button;

    [Header("ParametrsButtonBehavior")]
    [SerializeField] protected float _jumpHeight;
    [SerializeField] protected float _jumpDuration;
    [SerializeField] protected float _fallingPosition;
    [SerializeField] protected float _fallingDuration;

    protected virtual void OnClick()
    {
        RectTransform rectTransform = (RectTransform)transform;

        DOTween.Sequence()
            .Append(rectTransform.DOAnchorPosY(_jumpHeight, _jumpDuration))
            .Append(rectTransform.DOAnchorPosY(_fallingPosition, _fallingDuration))
            .onComplete += () => gameObject.SetActive(false);
    }
}
