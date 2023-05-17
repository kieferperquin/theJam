using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextColorScript : MonoBehaviour
{
    public bool rainbowColor = false;
    [SerializeField] Text textobj;

    public float speed = 1f; // Controls the speed of color transition

    private Color color; // Current color value

    private void Update()
    {
        if (rainbowColor)
        {
            // Update the color based on time and speed
            float t = Time.time * speed;
            color.r = Mathf.Sin(t) * 0.5f + 0.5f;
            color.g = Mathf.Sin(t + Mathf.PI * 2f / 3f) * 0.5f + 0.5f;
            color.b = Mathf.Sin(t + Mathf.PI * 4f / 3f) * 0.5f + 0.5f;
            color.a = 255;

            textobj.color = color;
        }
    }
}
