/******************************************************************************************************/
/* ScrollUITexture.cs																				  */
/* Purpose:																							  */
/*																									  */
/******************************************************************************************************/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScrollUITexture : MonoBehaviour {
    public float scrollSpeed = 0.5f;
    public float scaleFactor = 100;

    private RawImage imageToMove;
    private float scrollTime = 0.0f;

    void Start()
    {
        imageToMove = gameObject.GetComponent<RawImage>();
    }

    void Update()
    {
        scrollTime = Time.time * scrollSpeed;
        imageToMove.uvRect = new Rect(
            scrollTime,
            scrollTime, 
            imageToMove.rectTransform.rect.width / scaleFactor,
            imageToMove.rectTransform.rect.height / scaleFactor
        );
    }
}
