using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tageting : MonoBehaviour {

    public PlayerHp player_re;
    public GameObject player1;
    public float speed = 10.0f;
    float startpoint;
    private Vector3 dif;
    private Vector3 diff;

    void Start()
    {
        player1 = GameObject.Find("player");
        player_re = player1.GetComponent<PlayerHp>();
        startpoint = Time.time;


         diff = player1.transform.position - transform.position;
         dif = diff.normalized;
        speed *= Random.Range(0.1f, 2.0f);

    }

        void Update() {

        if (player_re.Dead())
        { }
        else
        {
            transform.Translate(dif * speed * Time.deltaTime);

            if (Time.time - startpoint > 7.0f)
            {
                Destroy(gameObject);
            }
        }

      

        }
    }
