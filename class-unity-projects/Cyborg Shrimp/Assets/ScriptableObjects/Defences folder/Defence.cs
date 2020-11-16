using UnityEngine;
[CreateAssetMenu]
public class Defence : CollectibleItem
{
    public float powerLevel = 0.5f;

    public override void Use()
    {
        //Use Defence
        Debug.Log(this.name);
    }
    
}
