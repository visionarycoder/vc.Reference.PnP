using Snippets.DesignPatterns.Creational.Builder;
using Spectre.Console;

AnsiConsole.Write(new Rule("[cornflowerblue]Creational pattern samples[/]") { Justification = Justify.Left });

// WHAT: Build a complex computer configuration one deliberate step at a time.
// WHERE: ComputerBuilder and Computer live in the creational pattern library.
// WHY: The caller can select a configuration without coupling to construction details.
var computer = new ComputerBuilder()
    .SetCpu("Ryzen 9")
    .SetGpu("RTX 5090")
    .SetRam(64)
    .SetStorage(2_000)
    .SetConnectivity()
    .SetOperatingSystem("Windows 11")
    .Build();

var configuration = new Table().Border(TableBorder.Rounded).Title("[bold]Builder result[/]");
configuration.AddColumn("Part");
configuration.AddColumn("Selection");
configuration.AddRow("CPU", computer.Cpu);
configuration.AddRow("GPU", computer.Gpu);
configuration.AddRow("Memory", $"{computer.Ram} GB");
configuration.AddRow("Storage", $"{computer.Storage} GB {computer.StorageType}");
configuration.AddRow("Operating system", computer.OperatingSystem);
AnsiConsole.Write(configuration);
