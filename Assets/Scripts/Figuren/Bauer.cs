using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bauer : Spielfiguren
{
    bool firstZug = true;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
     
    }

    new bool[,] möglicheZüge()
    {   
        bool [,] pZüge = new bool[8,8];
        if(Farbe == 0)
        {
            if(firstZug == true)
            {
                if (PosY >= 6)
                {
                    if (Spielfeld.FeldBesetzt(PosX, PosY + 1))
                    {
                        pZüge[PosX, PosY + 1] = true;
                        if (Spielfeld.FeldBesetzt(PosX, PosY + 2))
                        {
                            pZüge[PosX, PosY + 2] = true;
                        }
                    }
                }
            }
            else
            {
                if (PosY != 7)
                {
                    if (Spielfeld.FeldBesetzt(PosX, PosY + 1))
                    {
                        pZüge[PosX, PosY + 1] = true;
                    }
                }
            }
        }
        else
        {
            if(firstZug == true)
            {
                if (PosY <= 1)
                {
                    if (Spielfeld.FeldBesetzt(PosX, PosY - 1))
                    {
                        pZüge[PosX, PosY - 1] = true;
                        if (Spielfeld.FeldBesetzt(PosX, PosY - 2))
                        {
                            pZüge[PosX, PosY - 2] = true;
                        }
                    }
                }
            }
            else
            {
                if (PosY != 0)
                {
                    if (Spielfeld.FeldBesetzt(PosX, PosY - 1))
                    {
                        pZüge[PosX, PosY - 1] = true;
                    }
                }
            }
        }
        return pZüge;

    }
    
}
