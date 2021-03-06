﻿using System;
using BenchmarkDotNet.Running;
using Consolator.UI;
using Consolator.UI.Theming;
using Console = Consolator.Console;

namespace Benchmarks {
	public static class Program {
		internal readonly static KeyChoiceSet MenuChoices = new KeyChoiceSet(" Enter Choice: ",
			new KeyChoice(ConsoleKey.D1, nameof(ExtensionsBenchmarks), () => BenchmarkRunner.Run<ExtensionsBenchmarks>()),
			new BackKeyChoice(ConsoleKey.Q, "Quit", () => Environment.Exit(0)));

		public static void Main() {
			Theme.DefaultDark.Apply();
			while (true) {
				Console.WriteChoices(MenuChoices);
				Console.ReadChoice(MenuChoices);
			}
		}
	}
}
