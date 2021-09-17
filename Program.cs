using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Collections;
using System.Collections.Generic;

/**
 * Auto-generated code below aims at helping you parse
 * the standard input according to the problem statement.
 **/
class Solution
{
    static void Main(string[] args)
    {
        string MESSAGE = Console.ReadLine();
        string message_binaire = "";
        string message_unaire = "";

        foreach (char m in MESSAGE)
        {
            // Determination de la longueur du message et transformation en entier de chaque caractère.
            string _longueur = Convert.ToString((int)m, 2);
            if (_longueur.Length < 7)
            {
                _longueur = new string('0', 7 - _longueur.Length) + _longueur;
            }
            message_binaire += _longueur; 
        }

        message_unaire = traductionBinaireAUnaire(message_binaire);

        Console.WriteLine(message_unaire.Trim()); // .Trim => méthode qui supprime des caractères spécifiques.
        Console.ReadLine();
    }

    public static string traductionBinaireAUnaire(string StringBinaire)
    {
        char[] binaryArray = StringBinaire.ToArray(); 

        string reponseEnUnaire = "";
        char dernierCharactere = '\0';
        for (int i = 0; i < binaryArray.Length; i++) // Conversion int en binaire pour chaque caractere.
        {
            char CharactereActuel = binaryArray[i]; // Remplace chaque caractère en code unaire
            if (dernierCharactere != '1' && CharactereActuel == '1')
            {
                reponseEnUnaire += " 0 0";
                dernierCharactere = '1';
            }
            else if (dernierCharactere == '1' && CharactereActuel == '1')
            {
                reponseEnUnaire += "0";
            }
            else if (dernierCharactere != '0' && CharactereActuel == '0')
            {
                reponseEnUnaire += " 00 0";
                dernierCharactere = '0';
            }
            else if (dernierCharactere == '0' && CharactereActuel == '0')
            {
                reponseEnUnaire += "0";
            }
            else
            {
                reponseEnUnaire += "erreur";
            }
        }
        return reponseEnUnaire;
    }
}