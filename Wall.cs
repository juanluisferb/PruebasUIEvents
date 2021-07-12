using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wall : MonoBehaviour {

    [SerializeField] float xScreenPercent = 0;


	void Start () {
        Camera mainCamera = Camera.main;
        Vector3 viewPortPosition = new Vector3(xScreenPercent, 0.5f, 10);
        Vector3 worldPosition = mainCamera.ViewportToWorldPoint(viewPortPosition);
        this.transform.position = worldPosition;

	}
	
}
