using DG.Tweening;
using UnityEngine;

public abstract class AnimationObjects :MonoBehaviour
{
    private Vector3 _originalScale;
    private Vector3 _scaleTo;

    private float _maxScaleTo = 1.4f;

    private float _durationScale = 1.0f;
    private float _durationRotate = 3.0f;

    private float _rotationX;
    private float _rotationY;
    private float _rotationZ;

    protected virtual void Move()
    {
        float position = 2.5f;
        float duration = 3.0f;

        transform.DOMoveX(position, duration)
            .SetLoops(-1, LoopType.Yoyo)
            .SetEase(Ease.InOutSine);
    }

    protected virtual void ChangeToScale()
    {
        _originalScale = transform.localScale;
        _scaleTo = _originalScale * _maxScaleTo;

        transform.DOScale(_scaleTo, _durationScale)
            .SetLoops(-1, LoopType.Yoyo)
            .SetEase(Ease.InOutSine);
    }

    protected virtual void RotateByY()
    {
        _rotationX = 0f;
        _rotationY = 360.0f;
        _rotationZ = 0f;

        RotateByAxis(_rotationX, _rotationY, _rotationZ);
    }

    protected virtual void RotateByX()
    {
        _rotationX = 360.0f;
        _rotationY = 0f;
        _rotationZ = 0f;

        RotateByAxis(_rotationX, _rotationY, _rotationZ);
    }

    private void RotateByAxis(float rotationX, float rotationY, float rotationZ)
    {
        Vector3 rotation = new Vector3(rotationX, rotationY, rotationZ);

        transform.DORotate(rotation, _durationRotate, RotateMode.FastBeyond360)
            .SetLoops(-1, LoopType.Restart)
            .SetRelative()
            .SetEase(Ease.Linear);
    }
}
