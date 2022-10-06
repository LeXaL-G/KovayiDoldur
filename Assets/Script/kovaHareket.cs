using UnityEngine;

public class kovaHareket : MonoBehaviour
{
    private randomWaterScript water;
    private float x;
    private float hiz = 10f;
    private int sayac = 1;
    void FixedUpdate()
    {
        x = Input.GetAxis("Horizontal")*Time.fixedDeltaTime*hiz;
        gameObject.transform.position += new Vector3(x,0,0);
    }

    private void OnTriggerEnter2D(Collider2D col)
    {
        if(col.gameObject.tag=="water")
            Destroy(water._waterSpawn.gameObject);
    }
}
