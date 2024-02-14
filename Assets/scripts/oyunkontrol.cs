using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class oyunkontrol : MonoBehaviour
{
    public GameObject[] Olusacakobje;
    public GameObject OlusacakNokta;
    int sira_numarasi=0;
    // Start is called before the first frame update
    void Start()
    {
       
       /* Olusacakobje[0].SetActive(true);
        Olusacakobje[0].transform.position = OlusacakNokta.transform.position;*/
               StartCoroutine(objeolustur());
    }

   

    IEnumerator objeolustur()
    {

        while(true)
        {

            if (sira_numarasi<=8)
            {
                Olusacakobje[sira_numarasi].SetActive(true);
                Olusacakobje[sira_numarasi].transform.position = OlusacakNokta.transform.position;

               
                sira_numarasi++;

            }
            else
            {
                sira_numarasi = 0;
                Olusacakobje[sira_numarasi].SetActive(true);
                Olusacakobje[sira_numarasi].transform.position = OlusacakNokta.transform.position;
            }
           
            yield return new WaitForSeconds(.5f);

        }
       

    }
}
