﻿using BBRAPIModules;
using System;

namespace BattleBitExamples;

public class ExampleModuleIntegration : BattleBitModule {

    // Per-server configuration
    public ExampleConfiguration ExampleModuleConfig { get; set; }

    public bool Test(string text) {
        Console.WriteLine($"{this.ExampleModuleConfig.Text} {text}");

        return Random.Shared.Next(0, 2) == 1;
    }
}

public class ExampleConfiguration : ModuleConfiguration {
    public string Text { get; set; } = "Test";
}