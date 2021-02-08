using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interactable
{
    public float MaxDistanceToPlayer = 10;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public virtual void Interact(Transform interactableTransform, Transform other)
    {
        if (CanInteract(interactableTransform, other))
        {
            // DoSomething;
        }
    }
    public virtual bool CanInteract(Transform other)
    {
        return Vector3.Distance(other.transform.position, interactableTransform.position) <= MaxDistanceToPlayer;
    }

    void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "player")
        {
            GameObject player = collision.gameObject;
            PlayerInteractionScript playerInteractionSCript = player.GetComponent<PlayerInteractionScript>();
            
            // It would be better to check if different interactable object is closer than another one, then swap them

            if(playerInteractionSCript.objectToInteract == null) {
                playerInteractionSCript.objectToInteract = this;
            }  

        }
    }

    void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.tag == "player")
        {
            GameObject player = collision.gameObject;
            PlayerInteractionScript playerInteractionSCript = player.GetComponent<PlayerInteractionScript>();

            playerInteractionSCript.objectToInteract = null;
        }
    }
}
