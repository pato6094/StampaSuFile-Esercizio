using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace Exercise.WriteFile
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Persona> persona = new List<Persona>() {
            
            new Persona { nome = "Giovanni", cognome = "Serra" } };

            List<Account> accounts = new List<Account>()
            {
                new Account {iban="ITC2400048930248"}
            };

            StampaFunzione("C:\\Users\\cuffi\\Desktop\\Account.txt", accounts);
            StampaFunzione("C:\\Users\\cuffi\\Desktop\\NomeCognome.txt", persona);
        }
        public static void StampaFunzione<PA>(string path, List<PA> pa)
        {
            List<string> contenitore = new List<string>();
            if (pa is List<Persona>)
            {
                List<Persona> person = pa.Cast<Persona>().ToList();
                foreach (var item in person)
                {
                    contenitore.Add(item.nome);
                    contenitore.Add(item.cognome);

                }
            }
            else
            {
                List<Account> account = pa.Cast<Account>().ToList();
                foreach (var item in account)
                {
                    contenitore.Add(item.iban);
                }
            }
            File.WriteAllLines(path, contenitore);
        }
    }


}