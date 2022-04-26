using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NematodeSchool : MonoBehaviour
{
    public GameObject prefab;

    private Constrain constrain;
    GameObject nematode;


    [Range (1, 5000)]
    public int radius = 50;
    
    public int count = 10;

    // Start is called before the first frame update
    void Awake()
    {
        // Put your code here
        for (int i = 0; i < count; i ++)
        {
            nematode = Instantiate(prefab);
            constrain = nematode.transform.GetChild(0).GetComponent<Constrain>();
            constrain.radius = radius;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
