using System.Collections;
using System.Collections.Generic;
using UnityEditorInternal;
using UnityEngine;

public class Pontuacao
{
   public enum TiposPontuacao
    {
        GENERAL,
        POKER,
        FULA,
        SEQUENCIA,
        NADA,
        ERRO
    };

    public int pontos;
      
    public Pontuacao()
    {
        pontos = 0;
    }

    public void addPontuacao(int tipo)
    {
        switch (tipo)
        {
            case (int) TiposPontuacao.GENERAL:
                pontos += 50;
                Debug.LogWarning("DEU General");
                break;
            case (int)TiposPontuacao.POKER:
                pontos += 40;
                Debug.LogWarning("DEU Poker");
                break;
            case (int)TiposPontuacao.FULA:
                pontos += 30;
                Debug.LogWarning("Deu fula");
                break;
            case (int)TiposPontuacao.SEQUENCIA:
                pontos += 20;
                Debug.LogWarning("Deu Sequencia");
                break;
            case (int)TiposPontuacao.NADA:
                Debug.LogWarning("nada");
                break;
            default:
                Debug.LogError("Pontuação invalida");
                break;

        }
    }

    public void resetPontuacao()
    {
        pontos = 0;
    }


}
