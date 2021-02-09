using UnityEngine;

public class HighJumpAlien : Alien
{
    public HighJumpAlien() : base("High Jump Alien") { }

    public override void ExecuteAbility(Rigidbody2D rigidbody2D)
    {
        rigidbody2D.AddForce(new Vector2(0, 5));
    }
}
