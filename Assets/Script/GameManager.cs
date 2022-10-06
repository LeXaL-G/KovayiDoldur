using UnityEngine;

public class GameManager : MonoBehaviour
{
    private randomWaterScript water;
    private void OnTriggerEnter2D(Collider2D col)
    {
        if(col.gameObject.tag=="water")
            Destroy(water._waterSpawn.gameObject);
    }
}