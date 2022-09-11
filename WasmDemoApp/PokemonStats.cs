using System;
using System.Collections.Generic;

namespace WasmDemoApp
{
    public class PokemonStats
    {
        public List<Ability> abilities { get; set; }
        public int base_experience { get; set; }
        public List<Form> forms { get; set; }
        public int height { get; set; }
        public List<object> held_items { get; set; }
        public int id { get; set; }
        public List<Move> moves { get; set; }
        public string name { get; set; }
        public int order { get; set; }
        public List<Stat> stats { get; set; }
        public List<Type> types { get; set; }
        public int weight { get; set; }

    }

    public class Ability
    {
        public AbilityName ability { get; set; }
        public bool is_hidden { get; set; }
        public int slot { get; set; }
    }

    public class AbilityName
    {
        public string name { get; set; }
    }

    public class Form
    {
        public string name { get; set; }
        public string url { get; set; }
    }

    public class Move
    {
        public MoveName move { get; set; }
    }

    public class MoveName
    {
        public string name { get; set; }
    }

    public class Stat
    {
        public int base_stat { get; set; }
        public int effort { get; set; }
        public StatName stat { get; set; }
    }

    public class StatName
    {
        public string name { get; set; }
    }

    public class Type
    {
        public int slot { get; set; }
        public TypeName type { get; set; }
    }

    public class TypeName
    {
        public string name { get; set; }
    }

}


