using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractiveZone : MonoBehaviour {

    [SerializeField] float _maxScreenViewPortY = 0.6f;
    [SerializeField] float _minScreenViewPortY = 0.3f;

    float _currentScreenViewport;
    float _desiredScreenViewport;

    RectTransform _rectTransform;

    private void Awake()
    {
        _rectTransform = GetComponent <RectTransform>();
    }

    private void Start()
    {
        _desiredScreenViewport = _maxScreenViewPortY;
        _currentScreenViewport = _maxScreenViewPortY;
        _rectTransform.anchorMax = new Vector2(_rectTransform.anchorMax.x, _currentScreenViewport);
    }

    public float GetCurrentViewport()
    {
        return _currentScreenViewport;
    }

    public void DecreaseViewPort()
    {
        _desiredScreenViewport -= 0.05f;
        _desiredScreenViewport = Mathf.Max(_desiredScreenViewport, _minScreenViewPortY);
    }

    private void Update()
    {
        _currentScreenViewport = Mathf.Lerp(_currentScreenViewport, _desiredScreenViewport, Time.deltaTime);
        _rectTransform.anchorMax = new Vector2(_rectTransform.anchorMax.x, _currentScreenViewport);
    }
}

