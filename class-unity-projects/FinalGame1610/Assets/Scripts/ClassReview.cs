using UnityEngine;
[RequireComponent(typeof(CharacterController))]
public class ClassReview : MonoBehaviour
{
    public int score;
    public float health;
    public string playerName;
    public bool canPlay;
    public GameObject playerArt;
    public Transform playerTransform;

    private CharacterController controller;
    private Vector3 movement;
    
    // Start is called before the first frame update
    void Start()
    {
        controller = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        movement.x = 3f;
        controller.Move(movement);
    }
}
