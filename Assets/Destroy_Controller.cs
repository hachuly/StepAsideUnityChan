using UnityEngine;
using System.Collections;

public class Destroy_Controller : MonoBehaviour {

    private GameObject unitychan;
    private float difference;

    // Use this for initialization
    void Start () {
       this.unitychan = GameObject.Find("unitychan");
       this.difference = unitychan.transform.position.z - this.transform.position.z;
    }

    // Update is called once per frame
    void Update () {
       this.transform.position = new Vector3(0, this.transform.position.y, this.unitychan.transform.position.z - difference);
    }

    void OnTriggerEnter(Collider other){
        if(other.gameObject.tag == "CarTag" || other.gameObject.tag == "ConeTag" || other.gameObject.tag == "CoinTag"){
            Destroy(other.gameObject);
        }
    }
}
