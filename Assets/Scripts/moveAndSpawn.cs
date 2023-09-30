using System.Collections;
using System.Collections.Generic;

using UnityEngine;

public class moveAndSpawn : MonoBehaviour
{
    float timer;
    // Start is called before the first frame update
    void Start()
    {
        

    }

    // Update is called once per frame
    void Update()
    {
        
        if (transform.position.z < -15)
        {
            Destroy(this.gameObject);
        }
    
        

    }
    private void FixedUpdate()
    {
        transform.Translate(new Vector3(0, 0, -0.1f));

    }
}
