using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Parallax : MonoBehaviour
{
    public float speed;
    private Renderer rend;
    private float offsetX = 0;
    void Start()
    {
        rend = GetComponent<Renderer>();
    }

    // Update is called once per frame
    void Update()
    {
        /*if (Input.GetKey(KeyCode.RightArrow))
        {
            offsetX += (speed * Time.deltaTime) / 10;
            rend.material.mainTextureOffset = new Vector2(offsetX, 0);
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            offsetX -= (speed * Time.deltaTime) / 10;
            rend.material.mainTextureOffset = new Vector2(offsetX, 0);
        }*/

        offsetX += (speed * Time.deltaTime) / 10;
        rend.material.mainTextureOffset = new Vector2(offsetX, 0);
    }
}
