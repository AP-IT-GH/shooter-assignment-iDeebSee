using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Disappear : MonoBehaviour
{
    // Start is called before the first frame update

    [SerializeField] private Text score;
    void Start()
    {
     

    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            score.text = (int.Parse(score.text) + 1).ToString();
            Destroy(gameObject);
        }
    }
}
