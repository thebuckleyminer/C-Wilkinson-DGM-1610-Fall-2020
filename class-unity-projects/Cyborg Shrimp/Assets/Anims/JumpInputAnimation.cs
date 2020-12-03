using UnityEngine;

[RequireComponent(typeof(Animator))]
public class JumpInputAnimation : MonoBehaviour
{
    private Animator anims;

    private void Start()
    {
        anims = GetComponent<Animator>();
    }

    private void Update()
    {
        if (Input.GetButtonDown("Jump"))
        {
            anims.SetTrigger("Jump");
        }
    }
}


