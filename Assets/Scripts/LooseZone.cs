using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LooseZone : MonoBehaviour
{
    public GameObject player;
    public Transform StartingPoint;
  

    private void OnTriggerEnter(Collider collision)
    {
        Debug.Log("Ich bin erfolgreich kollidiert =)");


        if (collision.tag == "Player")

        {
            Scene scene = SceneManager.GetActiveScene();
            SceneManager.LoadScene("SampleScene");

          // player.transform.position = StartingPoint.transform.position + Vector3.up;
        }

      

    }
}
