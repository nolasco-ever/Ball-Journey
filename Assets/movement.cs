using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class movement : MonoBehaviour
{
    public Rigidbody rb;
    public float move = 200;
    public bool isGrounded = true;

    // Update is called once per frame
    void FixedUpdate()
    {
        if(Input.GetKey(KeyCode.RightArrow))
        {
            rb.AddForce(move * Time.deltaTime, 0, 0);
        }

        if(Input.GetKey(KeyCode.LeftArrow))
        {
            rb.AddForce(-move * Time.deltaTime, 0, 0);
        }

        if(Input.GetKey(KeyCode.UpArrow) && isGrounded == true)
        {
            rb.AddForce(new Vector3(0, 7, 0), ForceMode.Impulse);
            isGrounded = false;
        }
    }
    void OnCollisionEnter(Collision other)
    {
        if(other.gameObject.tag == "floor" || other.gameObject.tag == "platform")
        {
            isGrounded = true;
            Debug.Log("We can jump");
        }

        if(other.gameObject.tag == "end")
        {
            Invoke("NextLevel", 2);
        }

        if(other.gameObject.tag == "enemy")
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }

        if (other.gameObject.tag == "lose")
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }

    }

    public void NextLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
