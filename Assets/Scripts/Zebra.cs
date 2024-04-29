﻿using System;
using UnityEngine;

namespace Zoo
{
    internal class Zebra : Animal, IHerbivore
    {
        public string Name => "Marty";

        protected override string Text => "zebra zebra";

        public Herbivore Herbivore { get; }
        private void Start() => AddDiet(Herbivore);
        public string EatText => "munch munch zank yee bra";
    }
}