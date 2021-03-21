using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paddle : MonoBehaviour
{
    // Start is called before the first frame update

    [SerializeField] float screenWidthInUnits = 16f;
    [SerializeField] float MinX = 1f;
    [SerializeField] float MaxX = 15f;


    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float mousePosInUnits = Input.mousePosition.x / Screen.width * screenWidthInUnits;
        Debug.Log(mousePosInUnits);      
        Vector2 paddlePos = new Vector2(transform.position.x, transform.position.y);
        paddlePos.x = Mathf.Clamp(mousePosInUnits, MinX, MaxX);
        transform.position = paddlePos;

    }
}
