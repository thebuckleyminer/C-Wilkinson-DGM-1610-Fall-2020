using UnityEngine;

[CreateAssetMenu]
public class CollectibleItem : ScriptableObject
{
    //public float powerLevel = 1f;
    public int cashValue = 10;
    public Sprite art;
    public Color artColor = Color.blue;

    public virtual void Use()
    {
        
    }
}