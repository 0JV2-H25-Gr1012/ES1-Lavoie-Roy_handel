using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class byebye : MonoBehaviour
{
    
    [SerializeField] private GameObject _block;
    [SerializeField] private int _poidsBlock = 1;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    public void destroyBlock(){

        if(_poidsBlock == 1){
           
           Destroy(_block);
        }

    }

}
