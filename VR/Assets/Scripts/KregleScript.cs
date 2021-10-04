using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class KregleScript : MonoBehaviour
{
    public List<Transform> transformsKregle;
    Vector3 pin1;
    Vector3 pin2;
    Vector3 pin3;
    Vector3 pin4;
    Vector3 pin5;
    Vector3 pin6;
    Vector3 pin7;
    Vector3 pin8;

    public List<GameObject> Gameobjectpins;

    float timer = 0f;
     
    public int score = 0;
    public Text text;
    bool pin1destroy, pin2destroy, pin3destroy, pin4destroy, pin5destroy, pin6destroy, pin7destroy, pin8destroy, strike = false;

    // Start is called before the first frame update
    void Awake()
    {
        pin1 = transformsKregle[0].position;
        pin2 = transformsKregle[1].position;
        pin3 = transformsKregle[2].position;
        pin4 = transformsKregle[3].position;
        pin5 = transformsKregle[4].position;
        pin6 = transformsKregle[5].position;
        pin7 = transformsKregle[6].position;
        pin8 = transformsKregle[7].position;
        text.text = score.ToString();
    }

    // Update is called once per frame
   void Update()
   {
        timer = timer + Time.deltaTime;

        if(timer > 30)
        {
            timer = 0;
        }

        if (!strike)
        {
            if (transformsKregle[0].position != pin1 && !pin1destroy)
            {
                score += 1;
                text.text = score.ToString();
                pin1destroy = true;
                timer = 0f;
            }
            else if (transformsKregle[1].position != pin2 && !pin2destroy)
            {
                score += 1;
                text.text = score.ToString();
                pin2destroy = true;
                timer = 0f;
            }
            else if (transformsKregle[2].position != pin3 && !pin3destroy)
            {
                score += 1;
                text.text = score.ToString();
                pin3destroy = true;
                timer = 0f;
            }
            else if (transformsKregle[3].position != pin4 && !pin4destroy)
            {
                score += 1;
                text.text = score.ToString();
                pin4destroy = true;
                timer = 0f;
            }
            else if (transformsKregle[4].position != pin5 && !pin5destroy)
            {
                score += 1;
                text.text = score.ToString();
                pin5destroy = true;
                timer = 0f;
            }
            else if (transformsKregle[5].position != pin6 && !pin6destroy)
            {
                score += 1;
                text.text = score.ToString();
                pin6destroy = true;
                timer = 0f;
            }
            else if (transformsKregle[6].position != pin7 && !pin7destroy)
            {
                score += 1;
                text.text = score.ToString();
                pin7destroy = true;
                timer = 0f;
            }
            else if (transformsKregle[7].position != pin8 && !pin8destroy)
            {
                score += 1;
                text.text = score.ToString();
                pin8destroy = true;
                timer = 0f;
            }
            else
            {
                if (pin1destroy && pin2destroy && pin3destroy && pin4destroy && pin5destroy && pin6destroy && pin7destroy && pin8destroy)
                {
                    strike = true;
                    Debug.Log("Strike!");
                }
            }

            if (pin1destroy && Gameobjectpins[0].activeSelf)
            {
                if (timer > 4.0f)
                {
                    Gameobjectpins[0].SetActive(false);
                }
            }
            else if (pin2destroy && Gameobjectpins[1].activeSelf)
            {

                if (timer > 4.0f)
                {
                    Gameobjectpins[1].SetActive(false);
                }
            }
            else if (pin3destroy && Gameobjectpins[2].activeSelf)
            {

                if (timer > 4.0f)
                {
                    Gameobjectpins[2].SetActive(false);
                }
            }
            else if (pin4destroy && Gameobjectpins[3].activeSelf)
            {
                if (timer > 4.0f)
                {
                    Gameobjectpins[3].SetActive(false);
                }
            }
            else if (pin5destroy && Gameobjectpins[4].activeSelf)
            {
                if (timer > 4.0f)
                {
                    Gameobjectpins[4].SetActive(false);
                }
            }
            else if (pin6destroy && Gameobjectpins[5].activeSelf)
            {
                if (timer > 4.0f)
                {
                    Gameobjectpins[5].SetActive(false);
                }
            }
            else if (pin7destroy && Gameobjectpins[6].activeSelf)
            {
                if (timer > 4.0f)
                {
                    Gameobjectpins[6].SetActive(false);
                }
            }
            else if (pin8destroy && Gameobjectpins[7].activeSelf)
            {
                if (timer > 4.0f)
                {
                    Gameobjectpins[7].SetActive(false);
                }
            }
        }
   }
}
