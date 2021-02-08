using UnityEngine;

public class Spear : Interactable
{
    // Start is called before the first frame update
    public float damage = 5;
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        MaxDistanceToPlayer = 5;
    }

    public override void Interact(Transform other)
    {
        if (CanInteract(other))
        {
            Player player = other.parent.GetComponent<Player>();
            player.ChangeHealth(-damage);
        }
    }
}
