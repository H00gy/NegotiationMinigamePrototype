using UnityEngine;

public class ArrowMovement : MonoBehaviour
{
    private RectTransform rectTransform;
    private Vector2 startPos;

    public float distance; // How far it moves in pixels
    public float speed = 2f;      // How fast it moves

    void Start()
    {
        rectTransform = GetComponent<RectTransform>();
        startPos = rectTransform.anchoredPosition;
    }

    
    void Update()
    {
        // PingPong creates a smooth looping value between 0 and distance * 2
        float movement = Mathf.PingPong(Time.time * speed * distance, distance * 2) - distance;

        // Apply movment
        rectTransform.anchoredPosition = new Vector2(startPos.x + movement, startPos.y);
    }
    
}
