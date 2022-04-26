using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Nematode : MonoBehaviour
{
    public int length = 5;

    public Material material;

    private GameObject[] segments;


    void Awake()
    {
        // Put your code here!
        segments = new GameObject[length];
        float x = this.transform.position.x;
        float y = this.transform.position.y;
        float z = this.transform.position.z;
        for (int i = 0; i < length; i ++)
        {
            segments[i] = GameObject.CreatePrimitive(PrimitiveType.Sphere);
            //int colorValue = 255 / length;
            segments[i].GetComponent<Renderer>().material.color = new Color(255, 255, 0);
            segments[i].transform.position = new Vector3(x, y + i, z);
            if (i == 0 || i == length - 1)
            {
                segments[i].transform.localScale = new Vector3(0.5f, 0.5f, 1);
            }
            else
            {
                int midSeg = length / 2;
                if (i < midSeg)
                {
                    segments[i].transform.localScale = new Vector3(i * 0.1f + 1, i * 0.1f + 1, 1);
                }
                else
                {
                    segments[i].transform.localScale = new Vector3((length - 1 - i) * 0.1f + 1, (length - 1 - i) * 0.1f + 1, 1);
                }
            }
            segments[i].transform.parent = this.transform;
            segments[0].AddComponent<NoiseWander>();
            segments[0].AddComponent<ObstacleAvoidance>();
            segments[0].AddComponent<Constrain>();
        }
    }


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
