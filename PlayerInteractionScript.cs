using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInteractionScript : MonoBehaviour
{
    public Interactable objectToInteract;
    Player player;
    private bool _isInteracting = false;

    // Start is called before the first frame update
    void Start()
    {
        player = transform.parent.GetComponent<Player>();
    }

    // Update is called once per frame
    void Update()
    {

        CheckIfIsInteracting();

        if (_isInteracting)
        {
            InteractWithInteractable();
        }
       
    }

    public void InteractWithInteractable()
    {
        objectToInteract.Interact();
    }

    public void SubscribeInteractable(Interactable interactable)
    {
        objectToInteract = interactable;
    }

    public void UnsubscribeInteractable()
    {
        objectToInteract = null;
    }

    private void CheckIfIsInteracting()
    {
        if (Input.GetKeyDown("space"))
        {
            _isInteracting = true;
        }
        else
        {
            _isInteracting = false;
        }
    }
}
