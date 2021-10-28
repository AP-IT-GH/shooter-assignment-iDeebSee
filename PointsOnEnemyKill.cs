using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PointsOnEnemyKill : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] private Text score;
    public GameObject enemy;
    public int points;
    void Start()
    {
        if (enemy == null)
        {
            enemy = GameObject.FindWithTag("Enemy");
        }

    }

    // Update is called once per frame
    void Update()
    {
       /* if (enemy.GetComponent<Health>().healthPoints <= 0)
        {
            score.text = (int.Parse(score.text) + points).ToString();
        }*/
    }

    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "Bullet")
        {
            
            score.text = (int.Parse(score.text) + points).ToString();
            //Destroy(gameObject);
        }
        
    }
}
