using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Respone : MonoBehaviour {

    public GameObject player2;
    public GameObject player1;
   

    public float radius = 10.0f;
    private float lastlogTime;
    private float lastlongTime;

    

    void Start()
    {

        for (int i = 0; i < 30; i++)
        {
            var player_clone = Instantiate(player2, GetComponent<Transform>());
            var player_clone_tr = player_clone.GetComponent<Transform>();
            var theta = Random.Range(0, 2 * Mathf.PI);

            player_clone_tr.position = new Vector3(radius * Mathf.Cos(theta), 0, radius * Mathf.Sin(theta));

        }

    }

    private void Update()
    {
        var player_1 = player1.GetComponent<PlayerHp>();
        var player11 = player1.GetComponent<Transform>();
    
        if (player_1.Dead())
        { }
        else
        {

            if (Time.time - lastlogTime > 3.0f)
            {
                for (int i = 0; i < 30; i++)
                {

                    var player_clone = Instantiate(player2, GetComponent<Transform>());
                    var player_clone_tr = player_clone.GetComponent<Transform>();
                    var theta = Random.Range(0, 2 * Mathf.PI);

                    player_clone_tr.position = new Vector3( radius * Mathf.Cos(theta), 0, radius * Mathf.Sin(theta) );

                }
                lastlogTime = Time.time;
            }
        }
}
}
