// Create the creature scrips
// movment speed
// make i wander around
// detect the player 
// give it personality and reactions

using UnityEngine;

public class CreatureBehaviour : MonoBehaviour
{
    public float moveSpeed = 2f;
    
    private Vector3 moveDirection = Vector3.forward;
    private float directionTimer = 3f;
    

    void Update()
    {
        transform.position += moveDirection * moveSpeed * Time.deltaTime;
    }
public void Start()
    {
        Vector2 randomPoint= Random.insideUnitCircle;
        moveDirection = new Vector3(
        randomPoint.x,
        0f,
        randomPoint.y
        ).normalized;
    }
}