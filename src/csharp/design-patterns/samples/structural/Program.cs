using Snippets.DesignPatterns.Structural.Adapter;
using Spectre.Console;

AnsiConsole.Write(new Rule("[cornflowerblue]Structural pattern samples[/]") { Justification = Justify.Left });

// WHAT: Translate Target.Request into the adaptee's SpecificRequest.
// WHERE: Target, Adaptee, and Adapter live in the structural pattern library.
// WHY: A client depends on Target while the adapter preserves the existing Adaptee API.
Target target = new Adapter(new Adaptee());

var result = new Table().Border(TableBorder.Rounded).Title("[bold]Adapter result[/]");
result.AddColumn("Property");
result.AddColumn("Value");
result.AddRow("Client contract", nameof(Target));
result.AddRow("Adaptee API", nameof(Adaptee.SpecificRequest));
result.AddRow("Adapted result", Markup.Escape(target.Request()));
AnsiConsole.Write(result);
