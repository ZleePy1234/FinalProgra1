namespace Loot
{
    public class CreacionLoot
    {
        public struct LootData
        {
            public string lootName;
            public int lootValue;
            public int lootID;

            public LootData (string lootName, int lootValue, int lootID)
            {
                this.lootName = lootName;
                this.lootValue = lootValue;
                this.lootID = lootID;
            }
        }

        public static LootData Jarron = new LootData ("Jarron", 55, 0);
        public static LootData BolsaMonedas = new LootData ("Bolsa de monedas", 100, 1);
        public static LootData Rubi = new LootData ("Rubi Grande", 500,2);
        public static LootData Basura = new LootData ("Basura", 1, 3);

        public static LootData Estatua = new LootData ("Idolo Dorado", 300, 4);
        public static LootData PiedraLunar = new LootData("Piedra Lunar", 425, 5);
        public static LootData Vino = new LootData ("Vino Elfico", 610,6);
        public static LootData Esmeralda = new LootData ("Esmeralda Encantada", 350,7);

        public static List<LootData> ItemsLoot = new List<LootData> ();
        
        public static void ListaLoot()
        {
            ItemsLoot.Add (Jarron);
            ItemsLoot.Add (BolsaMonedas);
            ItemsLoot.Add (Rubi);
            ItemsLoot.Add (Basura);
            ItemsLoot.Add (Estatua);
            ItemsLoot.Add (PiedraLunar);
            ItemsLoot.Add (Vino);
            ItemsLoot.Add (Esmeralda);
        }
    }
}