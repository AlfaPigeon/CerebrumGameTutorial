using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour
{
    public float speed = 10f;
    private void Update()
    {
        UpdateMovement();
    }


    void UpdateMovement()
    {
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.position = Vector2.Lerp(transform.position, new Vector2(transform.position.x - 1, transform.position.y), Time.deltaTime * speed);
        }
        else if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.position = Vector2.Lerp(transform.position, new Vector2(transform.position.x + 1, transform.position.y), Time.deltaTime * speed);
        }
    }
    public void Die()
    {
        StartCoroutine(IE_Die());
    }

    private IEnumerator IE_Die()
    {
        yield return new WaitForSeconds(1f);
        SceneManager.LoadScene("GameScene");
    }
}
