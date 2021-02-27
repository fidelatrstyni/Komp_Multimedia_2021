using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerInventoryDisplay : MonoBehaviour
{
    // Start is called before the first frame update
    public Text starText;
    public void OnChangeCarryingStar(bool carryingStar)
    {
        string starMessage = "Tidak Bawa Bintang :-(";
        if(carryingStar) starMessage = "Bawa Bintang :-)";
        starText.text = starMessage;
    }
}
