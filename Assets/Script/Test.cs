using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour {

    public PlayerHp playerhp1;
    public DirPa dirpa;

    public float speed = 5.0f;
  
	void Update () {
        
        var dx = Input.GetAxis("Horizontal");
        var dz = Input.GetAxis("Vertical");

        var InDir = new Vector3(dx, 0, dz).normalized;

        if (playerhp1.Dead())
        { }
        else {
            if (dirpa.dragging)
            {
                var dn = dirpa.dir.normalized * Time.deltaTime * speed;
                transform.Translate(new Vector3(dn.x, 0, dn.y));
            }
            else transform.Translate(new Vector3(InDir.x * Time.deltaTime * speed*1.2f, 0, InDir.z * Time.deltaTime * speed*1.2f)); }

        Vector3 movedPosition = transform.position;

        if (movedPosition.x < -15.0f)
        {
            movedPosition.x = -15.0f;
        }
        if (movedPosition.x > 15.0f)
        {
            movedPosition.x = 15.0f;
        }

        movedPosition.z = Mathf.Clamp(movedPosition.z, -15, 15);

        transform.position = movedPosition;

    }
}
