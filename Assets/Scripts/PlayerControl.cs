using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEditor.SceneManagement;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PlayerControl : MonoBehaviour
{

    public float speed = 10f;
    private int lives;
    private double spawnX, spawnY;
    public Text livesText;

    // Start is called before the first frame update
    void Start()
    {
        GetComponent<CircleCollider2D>();
        lives = 3;
        spawnX = transform.position.x;
        spawnY = transform.position.y;
        SetLivesText();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("rejump collided");
    }

    void SetLivesText()
    {
        livesText.text = "Lives: " + lives.ToString();
    }

    void Respawn()
    {
        lives -= 1;
        SetLivesText();
        transform.position = new Vector3((float)spawnX, (float)spawnY, 0);

        if (lives < 1)
        {
            Scene scene = SceneManager.GetActiveScene();
            SceneManager.LoadScene(scene.name);
        }

    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Enemy"))
        {
            Respawn();
        }
    }

    // Update is called once per frame
    void Update()
    {
        float x = Input.GetAxis("Horizontal");
        float y = Input.GetAxis("Vertical");

        transform.position = transform.position + new Vector3(x * speed * Time.deltaTime, y * speed * Time.deltaTime,0);
    }
}
