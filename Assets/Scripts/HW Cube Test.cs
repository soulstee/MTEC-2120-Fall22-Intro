using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        public GameObject Cube;
        void Start()
        {
            for (var i = 0; i < 10; i++)
            {
                Instantiate(Cube, new Vector3(i * 5.0f, 0, 0), Quaternion.identity);
            }
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
