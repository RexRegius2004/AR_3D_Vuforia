using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scale_script : MonoBehaviour { 

    GameObject Paladin3D;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void scale_up()
    {
        gameObject.transform.localScale += new Vector3(1, 0, 1);
    }

    public void scale_down()
    {
        gameObject.transform.localScale -= new Vector3(1, 0, 1);
    }
}
