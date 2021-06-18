using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Web;

/// <summary>
/// Summary description for Functions
/// </summary>
public static class Functions{
    public static string HashTexto(string texto){
        HashAlgorithm algoritmo = HashAlgorithm.Create("SHA-512");
        if (algoritmo == null){
            throw new ArgumentException("Nome de hash incorreto", "nomeHash");
        }
        byte[] hash = algoritmo.ComputeHash(Encoding.UTF8.GetBytes(texto));
        return Convert.ToBase64String(hash);
    }

    public static void Mensagem(string msg, string imagem, string title){
        //lblMensagem.Text = msg;
        //msgImagem.Url = imagem;
        //msgTitle = title;
    }
}