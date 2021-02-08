using UnityEngine;

public class Stimpack : Interactable
{
    // Start is called before the first frame update
    public float heal = 10;
    void Start()
    {
        MaxDistanceToPlayer = 10;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public override void Interact(Transform other)
    {
        if (CanInteract(other))
        {
            Player player = other.parent.GetComponent<Player>();
            player.ChangeHealth(heal);
        }
    }
}
