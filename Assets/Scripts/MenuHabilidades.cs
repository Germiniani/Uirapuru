using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MenuHabilidades : MonoBehaviour
{
    [SerializeField]
    GameObject PanelHab,PanelJogo,Machado;
    [SerializeField]
    Text PontosHab, Info, Title;

    public int AP = 1;
    

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.H))
        {
            if (PanelHab.activeSelf == true)
            {
                PanelHab.SetActive(false);
                PanelJogo.SetActive(true);
            }
            else
            {
                PanelHab.SetActive(true);
                PanelJogo.SetActive(false);
            }
        }

        PontosHab.text = "Pontos de Habilidade: " + AP;

        if (Machado.activeSelf == true)
        {
            TextoCaixa(1);
        }
    }

    public void DecrementaAP()
    {
        if (AP > 0)
        {
            AP--;
        }
    }

    void TextoCaixa(int numHab)
    {
        if (numHab == 1)
        {
            Title.text = "Machado I";
            Info.text = "Todos os ataques com machado causam 10% de dano adicional aos inimigos";
        }
    }
}
