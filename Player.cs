using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    PlayerInteractionScript interactionScript;
    // Start is called before the first frame update
    void Start()
    {
        interactionScript = new PlayerInteractionScript();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
