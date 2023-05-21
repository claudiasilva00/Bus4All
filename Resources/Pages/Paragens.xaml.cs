using System.Runtime.InteropServices;
using System;

namespace Bus4All;

public partial class Paragens : ContentPage
{

    private List<string> paragemList;
    public Paragens()
	{
		InitializeComponent();

        paragemList = new List<string>
        {
            "UTAD REITORIA",
            "UTAD ENGENHARIAS",
            "UTAD PEDAGÓGICO",
            "UTAD LIVRARIA",
            "PRAÇA GALIZA",
            "AV.UNIVERSIDADE",
            "CARREIRA LONGA ",
            "R.AUGUSTO CÉSAR",
            "R.MANUEL SANTOS",
            "ESCOLAS ARAUCÁRIA",
            "IGREJA STº ANTÓNIO",
            "C.SAÚDE MATEUS ",
            "R.GASPAR SAMEIRO (2)",
            "R.GASPAR SAMEIRO (1)",
            "MATEUS         ",
            "Bº DO ALEM     ",
            "ABAMBRES       ",
            "COOPERATIVA    ",
            "LUGAR DO BOQUE ",
            "Bº STªA MARIA  ",
            "RIO CORGO      ",
            "CURVA DA TIMPEIRA",
            "PR. 25 DE ABRIL",
            "CEMITÉRIO      ",
        };
        
    }
    
}