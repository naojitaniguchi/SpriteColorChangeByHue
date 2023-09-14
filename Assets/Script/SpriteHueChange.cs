using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SpriteHueChange : MonoBehaviour
{
    Color color;
    [SerializeField] SpriteRenderer spriteRenderer;
    [SerializeField] Slider slider;
    float h;
    float s;
    float v;
    // Start is called before the first frame update
    void Start()
    {
        Color.RGBToHSV(spriteRenderer.color, out h,out s,out v);

        Debug.Log(h);
        Debug.Log(s);
        Debug.Log(v);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void changeHue()
    {
        float currentH = h + slider.value;
        if (currentH > 1.0f)
        {
            currentH -= 1.0f;
        }
        color = Color.HSVToRGB(currentH , s, v );
        spriteRenderer.color = color;

    }
}
