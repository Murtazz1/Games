using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; 
public class EnemyScript : MonoBehaviour
{
    public float speedx;
    public float speedy;

    public GameObject explosion;
    
    // Start is called before the first frame update
    void Start()
    {
        GetComponent<Rigidbody2D>().velocity = new Vector2(speedx, speedy);
        speedx = Random.Range(2f, 5f);
        speedy = Random.Range(-0.5f, -3f);
    }

    // Update is called once per frame
    void Update() {
        //private float X = transform.position.x;
        //end.position = (transform.position.x - 1, transform.position.y - 1);
        if (transform.position.x >= 13) {
            transform.position = new Vector2(transform.position.x - 0.1f, transform.position.y);
            speedx = -speedx;
            GetComponent<Rigidbody2D>().velocity = new Vector2(speedx, speedy);
        } else if (transform.position.x <= -13) {
            transform.position = new Vector2(transform.position.x + 0.1f, transform.position.y);
            speedx = -speedx;
            GetComponent<Rigidbody2D>().velocity = new Vector2(speedx, speedy);
        }
        if (transform.position.y <= -8) {
            Destroy(gameObject);
        }
    }
    
    private void OnBecameVisible() {
        GetComponent<ERandomshots>().enabled = true;
    }


    private void OnTriggerEnter2D(Collider2D other) {
        if (other.tag == "Player") {
            Destroy(other.gameObject);  // kills other object if player
            GameObject fire = (GameObject) Instantiate(explosion, other.gameObject.transform.position, Quaternion.identity);
            Destroy(fire, 0.4f);
            Destroy(gameObject);
            SceneManager.LoadScene(2);
        }
    }
}
