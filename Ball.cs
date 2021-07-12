using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Ball : MonoBehaviour, IPointerDownHandler {

    Rigidbody2D _rigidbody;
    [SerializeField] float _throwVelocity = 5;
    [SerializeField] Vector2 _randomXVelocity = new Vector2(1, 4);
    [SerializeField] Vector2 _randomAngularVelocity = new Vector2(30, 180);
    InteractiveZone _interactiveZone;

    private void Awake()
    {
        _rigidbody = GetComponent<Rigidbody2D>();
        _interactiveZone = FindObjectOfType<InteractiveZone>();
    }
    

    public void OnPointerDown(PointerEventData eventData)
    {
        Vector2 clickPosition = eventData.position;
        Vector3 viewportClickPosition = Camera.main.ScreenToViewportPoint(clickPosition);
        if(viewportClickPosition.y < _interactiveZone.GetCurrentViewport())
        {
            Vector3 viewPortPosition = Camera.main.WorldToViewportPoint(this.transform.position);
            float xVelocitySign = viewPortPosition.x < 0.5f ? 1 : -1;
            _rigidbody.velocity = Vector2.up * _throwVelocity +
                                  Vector2.right * xVelocitySign * Random.Range(_randomXVelocity.x, _randomXVelocity.y);

            _rigidbody.angularVelocity = xVelocitySign * Random.Range(_randomAngularVelocity.x, _randomAngularVelocity.y);

            _interactiveZone.DecreaseViewPort();
        }

        
        
    }
}
