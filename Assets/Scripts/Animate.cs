using UnityEngine;
using DG.Tweening;
using System.Collections;

public class Animate : MonoBehaviour
{
    [SerializeField] private RectTransform _target;
    [SerializeField] private float _time;
    [SerializeField] private float _timeDelay;
    [SerializeField] private Vector2 _finishPosition;

    private IEnumerator Start()
    {
        yield return new WaitForSeconds(_timeDelay);
        _target.DOAnchorPos(_finishPosition, _time)
            .SetEase(Ease.OutBack);
    }
}