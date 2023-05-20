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
            "UTAD PEDAGOGICO",
            "UTAD LIVRARIA",
            "PRAÇA GALIZA",
            "AV.UNIVERSIDADE",
            "CARREIRA LONGA ",
            "R.AUGUSTO CÉSAR",
            "R.MANUEL SANTOS",
            "ESCOLAS ARAUCÁR",
            "IGREJA STº ANTÓ",
            "C.SAUDE MATEUS ",
            "R.GASPAR SAMEIR",
            "R.GASPAR SAMEIR",
            "MATEUS         ",
            "Bº DO ALEM     ",
            "ABAMBRES       ",
            "COOPERATIVA    ",
            "LUGAR DO BOQUE ",
            "Bº STªA MARIA  ",
            "RIO CORGO      ",
            "CURVA DA TIMPEI",
            "PR. 25 DE ABRIL",
            "CEMITÉRIO      ",
        };
        
    }
    
}