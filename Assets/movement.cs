using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class movement : MonoBehaviour
{
    public float speed = 6.0f;
    Rigidbody rigidbody;
    [SerializeField] Text ScoreText;
    [SerializeField] Text CoinText;
    int score = 0;
    // Start is called before the first frame update
    void Start()
    {
        rigidbody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        ScoreText.text = ("Score: ") + score;
        CoinText.text = ("Coins Collected: ") + score;
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");
        rigidbody.velocity = new Vector3(horizontal * speed, rigidbody.velocity.y, vertical * speed);
        
    }
    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Coin")
        {
            Destroy(other.gameObject);
            score++;
        }
    }
}
