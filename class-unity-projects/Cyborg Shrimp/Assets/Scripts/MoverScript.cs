using UnityEngine;
public class MoverScript : MonoBehaviour
{
    public float speed = 3.0f;
    public float x, y, z;
    void Start()
    {
        Debug.Log("Hello World!");
    }
    void Update()
    {
        x = speed * Time.deltaTime * Input.GetAxis("Horizontal");
        y = speed * Time.deltaTime * Input.GetAxis("Vertical");
        transform.Translate(x, y, z);
    }
}
