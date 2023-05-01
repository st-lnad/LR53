using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Encounters
{
    /*  public struct Option
      {
          public string button_text;
          public int option_id;
      }
      public struct Finale
      {
          public int finale_id;
          public string finale_text;
          public int money_change;
          public int[] inventory_change;
          public int security_change;
      }
      public struct Enc
      {
         public string name;
         public string flavor;
         public Option[] options;
         public Finale[] end;
          public Enc init(Option[] options, Finale[] end, string name = "", string flavor = "", ) 
          {
              Enc init = new Enc();
              init.name = name;
              init.flavor = flavor;
              init.options = options;
              init.end = end;
              return init;
          }

      }

      public static Enc[] good_encounters = new Enc[3];
      public static Enc[] bad_encounters = new Enc[3];*/


    static string[] Encounter;
    static string[,] options;
    static int[,] option_ids;
    static Encounters() {
        Encounter[0] = "Вы замечаете, что в коробке с едой завелась плесень! Вы не уверены, насколько далеко распространилось заражение.";
        Encounter[1] = "Перед вами внезапно появляется группа вооружённых людей. \"Мы с друзьями - сборщики налогов, поэтому вынуждены попросить вас оплатить проезд по этой дороге\"";
        Encounter[2] = "На обочине дороги лежит поломанная телега. Хотя большая часть товаров уничтожена, что-то  всё ещё имеет ценность";
        options[0, 0] = "Выкинуть заражённую коробку";
        options[0, 1] = "Выкинуть все потенциально заражённые коробки.";

    }

    public static void GetEncounter(int Encounter_id) {
    
    }
}
