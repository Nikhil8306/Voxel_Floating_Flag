using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Arrangment : MonoBehaviour
{
    public GameObject orange;
    public GameObject green;
    public GameObject white;
    public int length = 18;
    public Texture2D chakra;

    void Start()
    {
        int width = (length * 2) / 3;
        int portion = width / 3;

        int i = 1;
        int temp = i;
        for (; i <= (temp-1+portion); i++)
        {
            for (int j = 1; j <= length; j++)
            {
                GameObject gb = Instantiate(green, new Vector3(j, i, 0), Quaternion.identity);
                FloatingFlag sc = gb.GetComponent<FloatingFlag>();
                sc.yPosition = i;
                sc.initialPhase = j;

            }
        }

        temp = i;
        int left = (length / 2) - portion/2 +1;
        int right = (length / 2) + portion/2 +1;
        for (; i <= (temp-1+portion); i++)
        {
            for (int j = 1; j < left; j++)
            {
                GameObject gb = Instantiate(white, new Vector3(j, i, 0), Quaternion.identity);
                FloatingFlag sc = gb.GetComponent<FloatingFlag>();
                sc.yPosition = i;
                sc.initialPhase = j;
            }
            
            for (int j = left; j < right; j++)
            {
                GameObject gb = Instantiate(white, new Vector3(j, i, 0), Quaternion.identity);
                FloatingFlag sc = gb.GetComponent<FloatingFlag>();
                MeshRenderer renderer = gb.GetComponent<MeshRenderer>();
                renderer.material.mainTexture = chakra;
                
                renderer.material.mainTextureOffset = new Vector2(-((float)(j-left+1) / (portion)), -((float)(i-temp+1) / (portion)));
                
                renderer.material.mainTextureScale = new Vector2((1/(float)(portion)), (1/(float)(portion)));
                
                sc.yPosition = i;
                sc.initialPhase = j;
            }
            
            for (int j = right; j <= length; j++)
            {
                GameObject gb = Instantiate(white, new Vector3(j, i, 0), Quaternion.identity);
                FloatingFlag sc = gb.GetComponent<FloatingFlag>();
                sc.yPosition = i;
                sc.initialPhase = j;
            }
        }

        temp = i;
        for (; i <= (temp-1+portion); i++)
        {
            for (int j = 1; j <= length; j++)
            {
                GameObject gb = Instantiate(orange, new Vector3(j, i, 0), Quaternion.identity);
                FloatingFlag sc = gb.GetComponent<FloatingFlag>();
                sc.yPosition = i;
                sc.initialPhase = j;
            }
        }
    }


}
