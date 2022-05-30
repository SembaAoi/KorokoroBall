using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{
    public GameManager gameManager;
    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player")
        {
            Destroy(gameObject);
        }
        if(other.gameObject.tag=="Player")
        {
            gameManager.AddCoinCount();
            Destroy(gameObject);
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        GameObject managerObject = GameObject.Find("GameManager");
        gameManager = managerObject.GetComponent<GameManager>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
