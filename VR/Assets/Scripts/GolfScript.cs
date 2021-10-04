using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GolfScript : MonoBehaviour
{
    public int score = 0;
    public Text text;

    // Start is called before the first frame update
    void Start()
    {
        text.text = score.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        text.text = score.ToString();
    }

    private void OnTriggerEnter(Collider other)
    {
        score = score + 1;
        Destroy(other.gameObject);
    }
}
