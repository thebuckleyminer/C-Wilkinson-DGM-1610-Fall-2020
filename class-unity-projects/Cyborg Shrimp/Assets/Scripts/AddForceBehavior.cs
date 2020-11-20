using System.Collections;
using UnityEngine;
[RequireComponent(typeof(Rigidbody))]
public class AddForceBehavior : MonoBehaviour
{
    private Rigidbody rigid;
    public Vector3 forces;
    public float holdTime = 1.0f;
    public int counter = 10;

    private IEnumerator Start()
    {
        rigid = GetComponent<Rigidbody>();

        while (counter > 0)
        {
            yield return new WaitForSeconds(holdTime);
            rigid.AddForce(forces);
            counter--;
        }

    }

}
