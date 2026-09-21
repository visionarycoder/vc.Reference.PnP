using Snippets.DesignPatterns.Creational.AbstractFactory;
using Snippets.DesignPatterns.Creational.Builder;
using Snippets.DesignPatterns.Creational.Factory;
using Snippets.DesignPatterns.Creational.Prototype;
using Snippets.DesignPatterns.Creational.Singleton;
using Spectre.Console;

AnsiConsole.Write(new Rule("[cornflowerblue]Creational pattern samples[/]") { Justification = Justify.Left });

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

var factory = UiFactoryProvider.GetFactory(OsType.Windows);
var ui = new Application(factory);
ui.CreateUi();

AnsiConsole.MarkupLine($"[green]Abstract Factory:[/] {factory.GetType().Name} created a matching control family.");

new ConsoleLoggerFactory().LogMessage("Factory Method selected the console logger.");
AnsiConsole.MarkupLine("[green]Factory Method:[/] the creator selected a logger product.");

var documents = new DocumentFactory();
var report = documents.CreateReport();
AnsiConsole.MarkupLine($"[green]Prototype:[/] cloned [italic]{report.Title}[/] from a registered template.");

var configurationManager = ConfigurationManager.Instance;
configurationManager.LoadConfiguration();
AnsiConsole.MarkupLine($"[green]Singleton:[/] shared configuration is [italic]{configurationManager.ConnectionString}[/].");
