using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using System.Linq;
using System.Text;

//  Version 1.01
//  24.08.2022
//  Klasse dient als Schachbrett und ist noch im Aufbau.

public class Feld : MonoBehaviour
{
    public Spielfiguren[,] Spielfeld = new Spielfiguren[8, 8];
    public Spielfiguren BauerS1;
    public Spielfiguren BauerS2;
    public Spielfiguren BauerS3;
    public Spielfiguren BauerS4;
    public Spielfiguren BauerS5;
    public Spielfiguren BauerS6;
    public Spielfiguren BauerS7;
    public Spielfiguren BauerS8;
    public Spielfiguren BauerW1;
    public Spielfiguren BauerW2;
    public Spielfiguren BauerW3;
    public Spielfiguren BauerW4; 
    public Spielfiguren BauerW5;
    public Spielfiguren BauerW6;
    public Spielfiguren BauerW7;
    public Spielfiguren BauerW8; 
    public Spielfiguren LäuferW1;
    public Spielfiguren LäuferW2;
    public Spielfiguren LäuferS1;
    public Spielfiguren LäuferS2;
    public Spielfiguren SpringerS1;
    public Spielfiguren SpringerS2; 
    public Spielfiguren SpringerW1;
    public Spielfiguren SpringerW2; 
    public Spielfiguren TurmS1;
    public Spielfiguren TurmS2; 
    public Spielfiguren TurmW1; 
    public Spielfiguren TurmW2; 
    public Spielfiguren DameW; 
    public Spielfiguren DameS; 
    public Spielfiguren KönigW;
    public Spielfiguren KönigS;
    
    public GameObject Punkt;

    //  die beiden Variablen stellen fest, welches Feld momentan ausgesucht ist, 
    //  damit die Figuren ihre möglichen Züge anzeigen, falls sie ausgesucht sind.
    public int selectedFeldX = 0;
    public int selectedFeldY = 0;

    public PunktSelFel PunktSelFel;
    // Start is called before the first frame update
    void Start()
    {
        ErstelleFeld();
    }

    // Update is called once per frame
    void Update()
    {
        SelectedFeld();
    }

    void SelectedFeld()
    {
        if(Input.GetButtonDown("Up"))
        {   
            if(selectedFeldY != 7)
            {
                selectedFeldY ++;
                PunktSelFel.movement('u');
            }
        }
        else 
        if(Input.GetButtonDown("Down"))
        {   
            if(selectedFeldY != 0)
            {
                selectedFeldY --;
            }
        }
        else
        if(Input.GetButtonDown("Left"))
        {   
            if(selectedFeldX != 0)
            {
                selectedFeldX --;
            }
        }
        else 
        if(Input.GetButtonDown("Right"))
        {
            if(selectedFeldX != 7)
            {
                selectedFeldX ++;
            }
        }

    }

    void ErstelleFeld()
    {

        Instantiate(PunktSelFel);

        Spielfeld[0, 0] = TurmW1;
        aktPos(TurmW1);
        TurmW1.Farbe = 1;
        Spielfeld[1, 0] = SpringerW1;
        aktPos(SpringerW1);
        SpringerW1.Farbe = 1;
        Spielfeld[2, 0] = LäuferW1;
        aktPos(LäuferW1);
        LäuferW1.Farbe = 1;
        Spielfeld[3, 0] = DameW;
        aktPos(DameW);
        DameW.Farbe = 1;
        Spielfeld[4, 0] = KönigW;
        aktPos(KönigW);
        KönigW.Farbe = 1;
        Spielfeld[5, 0] = LäuferW2;
        aktPos(LäuferW2);
        LäuferW2.Farbe = 1;
        Spielfeld[6, 0] = SpringerW2;
        aktPos(SpringerW2);
        SpringerW2.Farbe = 1;
        Spielfeld[7, 0] = TurmW2;
        aktPos(TurmW2);
        TurmW2.Farbe = 1;
        Spielfeld[0, 1] = BauerW1;
        aktPos(BauerW1);
        BauerW1.Farbe = 1;
        Spielfeld[1, 1] = BauerW2;
        aktPos(BauerW2);
        BauerW2.Farbe = 1;
        Spielfeld[2, 1] = BauerW3;
        aktPos(BauerW3);
        BauerW3.Farbe = 1;
        Spielfeld[3, 1] = BauerW4;
        aktPos(BauerW4);
        BauerW4.Farbe = 1;
        Spielfeld[4, 1] = BauerW5;
        aktPos(BauerW5);
        BauerW5.Farbe = 1;
        Spielfeld[5, 1] = BauerW6;
        aktPos(BauerW6);
        BauerW6.Farbe = 1;
        Spielfeld[6, 1] = BauerW7;
        aktPos(BauerW7);
        BauerW7.Farbe = 1;
        Spielfeld[7, 1] = BauerW8;
        aktPos(BauerW8);
        BauerW8.Farbe = 1;

        //farbe ändern Schwarz = 0
        Spielfeld[0, 7] = TurmS1;
        aktPos(TurmS1);
        TurmS1.Farbe = 0;
        Spielfeld[1, 7] = SpringerS1;
        aktPos(SpringerS1);
        SpringerS1.Farbe = 0;
        Spielfeld[2, 7] = LäuferS1;
        aktPos(LäuferS1);
        LäuferS1.Farbe = 0;
        Spielfeld[3, 7] = DameS;
        aktPos(DameS);
        DameS.Farbe = 0;
        Spielfeld[4, 7] = KönigS;
        aktPos(KönigS);
        KönigS.Farbe = 0;
        Spielfeld[5, 7] = LäuferS2;
        aktPos(LäuferS2);
        LäuferS2.Farbe = 0;
        Spielfeld[6, 7] = SpringerS2;
        aktPos(SpringerS2);
        SpringerS2.Farbe = 0;
        Spielfeld[7, 7] = TurmS2;
        aktPos(TurmS2);
        TurmS2.Farbe = 0;
        Spielfeld[0, 6] = BauerS1;
        aktPos(BauerS1);
        BauerS1.Farbe = 0;
        Spielfeld[1, 6] = BauerS2;
        aktPos(BauerS2);
        BauerS2.Farbe = 0;
        Spielfeld[2, 6] = BauerS3;
        aktPos(BauerS3);
        BauerS3.Farbe = 0;
        Spielfeld[3, 6] = BauerS4;
        aktPos(BauerS4);
        BauerS4.Farbe = 0;
        Spielfeld[4, 6] = BauerS5;
        aktPos(BauerS5);
        BauerS5.Farbe = 0;
        Spielfeld[5, 6] = BauerS6;
        aktPos(BauerS6);
        BauerS6.Farbe = 0;
        Spielfeld[6, 6] = BauerS7;
        aktPos(BauerS7);
        BauerS7.Farbe = 0;
        Spielfeld[7, 6] = BauerS8;
        aktPos(BauerS8);
        BauerS8.Farbe = 0;
    }
    void aktualisiereFeld()
    { 
    
    }

    public bool FeldBesetzt(int x, int y) 
    {
        if (Spielfeld[x, y] == null)
        {
            return false;
        }
        else 
        {
            return true;
        }
    }

    void aktPos(Spielfiguren S)
    {
        if(S == null)
        {
            Console.WriteLine("Fehler 01");
        }
        else
        {
            for (int i = 0; i <= 8; i++)
            {
                for (int j = 0; j <= 8; j++)
                {
                    if (Spielfeld[i, j] == S)
                    {
                        S.PosX = i;
                        S.PosY = j;
                        break;
                    }
                }
            }        
        }
    }

}
