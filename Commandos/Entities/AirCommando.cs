﻿using Commandos.Interfaces;

namespace Commandos.Entities;

internal class AirCommando : Commando, IParatrooper
{
    public AirCommando(string name, string codeName) : base(name, codeName) {}

    public override void Attack() => Console.WriteLine($"Air commando {CodeName} is attacking");

    public void Parachute() => Console.WriteLine("Air commando is parachuting.");
}
