using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class zombieTriple : MonoBehaviour
{
    //cycle through the child objects and if they're all destroyed, delete this empty parent object

    public GameObject[] zombies = new GameObject[3];
    int nullCount;

    // Update is called once per frame
    void Update()
    {
        if (zombies[0] != null)
            return;
        else if (zombies[1] != null)
            return;
        else if (zombies[2] == null)
            Destroy(gameObject);
    }
}
