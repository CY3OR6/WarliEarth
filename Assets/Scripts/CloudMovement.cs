using UnityEngine;

public class CloudMovement : MonoBehaviour
{
    public float speed = 2f; // Speed of cloud movement
    private float screenLeftEdge;

    private void Start()
    {
        screenLeftEdge = Camera.main.ScreenToWorldPoint(Vector3.zero).x - 1f; // Calculate the left edge of the screen
    }

    void Update()
    {
        transform.Translate(Vector3.left * speed * Time.deltaTime); // Move cloud left

        // If the cloud moves off-screen, destroy it
        if (transform.position.x < screenLeftEdge)
        {
            Destroy(gameObject);
        }
    }
}