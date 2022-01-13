using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Threading.Tasks;

public class NeoManager : MonoBehaviour
{
    Color32 color0 = new Color32(255, 91, 91, 130);
    Color32 color1 = new Color32(20, 170, 250, 130);
    Color32 color2 = new Color32(20, 250, 70, 130);
    Color32 color3 = new Color32(250, 200, 20, 130);
    Color32 color4 = new Color32(250, 20, 70, 130);

    [Range(0f, 100f)]
    private float timer;
    
    public AnimationCurve curve;
    
    // Start is called before the first frame update
    void Start()
    {
        //Debug.Log("Color0");
        GetComponent<Renderer>().material.color = color0;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    
    void Timer()
    {
        //Debug.Log("Test");
    }
    
    public async void Change(int cmd)
    {
    /*
        カラーネームを使うならば：
        black, blue, cyan, gray, green, magenta, red, white, yellow
        もしRGBAを用いるならば：
        GetComponent<Renderer>().material.color = new Color32(255, 255, 255, 1);
    */
        timer = 0.0f;
        switch (cmd)
        {
            case 0:

                break;
            case 1:
                //Debug.Log("Color1");
                if (GetComponent<Renderer>().material.color == color0)
                {
                    while (timer <= 1f)
                    {
                        GetComponent<Renderer>().material.color = Color32.Lerp(color0, color1, timer);
                        await Task.Delay(50);
                        timer += 0.1f;
                    }
                    GetComponent<Renderer>().material.color = color1;
                }
                else if (GetComponent<Renderer>().material.color == color2)
                {
                    while (timer <= 1f)
                    {
                        GetComponent<Renderer>().material.color = Color32.Lerp(color2, color1, timer);
                        await Task.Delay(50);
                        timer += 0.1f;
                    }
                    GetComponent<Renderer>().material.color = color1;
                }
                else if (GetComponent<Renderer>().material.color == color3)
                {
                    while (timer <= 1f)
                    {
                        GetComponent<Renderer>().material.color = Color32.Lerp(color3, color1, timer);
                        await Task.Delay(50);
                        timer += 0.1f;
                    }
                    GetComponent<Renderer>().material.color = color1;
                }
                else if (GetComponent<Renderer>().material.color == color4)
                {
                    while (timer <= 1f)
                    {
                        GetComponent<Renderer>().material.color = Color32.Lerp(color4, color1, timer);
                        await Task.Delay(50);
                        timer += 0.1f;
                    }
                    GetComponent<Renderer>().material.color = color1;
                }
                break;
            case 2:
                //Debug.Log("Color2");
                if (GetComponent<Renderer>().material.color == color0)
                {
                    while (timer <= 1f)
                    {
                        GetComponent<Renderer>().material.color = Color32.Lerp(color0, color2, timer);
                        await Task.Delay(50);
                        timer += 0.1f;
                    }
                    GetComponent<Renderer>().material.color = color2;
                }
                else if (GetComponent<Renderer>().material.color == color1)
                {
                    while (timer <= 1f)
                    {
                        GetComponent<Renderer>().material.color = Color32.Lerp(color1, color2, timer);
                        await Task.Delay(50);
                        timer += 0.1f;
                    }
                    GetComponent<Renderer>().material.color = color2;
                }
                else if (GetComponent<Renderer>().material.color == color3)
                {
                    while (timer <= 1f)
                    {
                        GetComponent<Renderer>().material.color = Color32.Lerp(color3, color2, timer);
                        await Task.Delay(50);
                        timer += 0.1f;
                    }
                    GetComponent<Renderer>().material.color = color2;
                }
                else if (GetComponent<Renderer>().material.color == color4)
                {
                    while (timer <= 1f)
                    {
                        GetComponent<Renderer>().material.color = Color32.Lerp(color4, color2, timer);
                        await Task.Delay(50);
                        timer += 0.1f;
                    }
                    GetComponent<Renderer>().material.color = color2;
                }
                break;
            case 3:
                //Debug.Log("Color3");
                if (GetComponent<Renderer>().material.color == color0)
                {
                    while (timer <= 1f)
                    {
                        GetComponent<Renderer>().material.color = Color32.Lerp(color0, color3, timer);
                        await Task.Delay(50);
                        timer += 0.1f;
                    }
                    GetComponent<Renderer>().material.color = color3;
                }
                else if (GetComponent<Renderer>().material.color == color1)
                {
                    while (timer <= 1f)
                    {
                        GetComponent<Renderer>().material.color = Color32.Lerp(color1, color3, timer);
                        await Task.Delay(50);
                        timer += 0.1f;
                    }
                    GetComponent<Renderer>().material.color = color3;
                }
                else if (GetComponent<Renderer>().material.color == color2)
                {
                    while (timer <= 1f)
                    {
                        GetComponent<Renderer>().material.color = Color32.Lerp(color2, color3, timer);
                        await Task.Delay(50);
                        timer += 0.1f;
                    }
                    GetComponent<Renderer>().material.color = color3;
                }
                else if (GetComponent<Renderer>().material.color == color4)
                {
                    while (timer <= 1f)
                    {
                        GetComponent<Renderer>().material.color = Color32.Lerp(color4, color3, timer);
                        await Task.Delay(50);
                        timer += 0.1f;
                    }
                    GetComponent<Renderer>().material.color = color3;
                }
                break;
            case 4:
                //Debug.Log("Color4");
                if (GetComponent<Renderer>().material.color == color0)
                {
                    while (timer <= 1f)
                    {
                        GetComponent<Renderer>().material.color = Color32.Lerp(color0, color4, timer);
                        await Task.Delay(50);
                        timer += 0.1f;
                    }
                    GetComponent<Renderer>().material.color = color4;
                }
                else if (GetComponent<Renderer>().material.color == color1)
                {
                    while (timer <= 1f)
                    {
                        GetComponent<Renderer>().material.color = Color32.Lerp(color1, color4, timer);
                        await Task.Delay(50);
                        timer += 0.1f;
                    }
                    GetComponent<Renderer>().material.color = color4;
                }
                else if (GetComponent<Renderer>().material.color == color2)
                {
                    while (timer <= 1f)
                    {
                        GetComponent<Renderer>().material.color = Color32.Lerp(color2, color4, timer);
                        await Task.Delay(50);
                        timer += 0.1f;
                    }
                    GetComponent<Renderer>().material.color = color4;
                }
                else if (GetComponent<Renderer>().material.color == color3)
                {
                    while (timer <= 1f)
                    {
                        GetComponent<Renderer>().material.color = Color32.Lerp(color3, color4, timer);
                        await Task.Delay(50);
                        timer += 0.1f;
                    }
                    GetComponent<Renderer>().material.color = color4;
                }
                break;
        }
    }
}
