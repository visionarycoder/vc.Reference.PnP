using Snippets.DesignPatterns.Structural.Decorator;
using Spectre.Console;

AnsiConsole.Write(new Rule("[cornflowerblue]Structural pattern samples[/]") { Justification = Justify.Left });

// WHAT: Add upper-casing behavior to a text processor by wrapping it.
// WHERE: ITextProcessor, BasicTextProcessor, and UpperCaseDecorator live in the structural pattern library.
// WHY: The caller composes behavior at runtime without modifying the base processor or creating a subclass per combination.
ITextProcessor processor = new UpperCaseDecorator(new BasicTextProcessor());
const string input = "A composed behavior";

var result = new Table().Border(TableBorder.Rounded).Title("[bold]Decorator result[/]");
result.AddColumn("Property");
result.AddColumn("Value");
result.AddRow("Pipeline", Markup.Escape(processor.GetDescription()));
result.AddRow("Input", Markup.Escape(input));
result.AddRow("Output", Markup.Escape(processor.Process(input)));
result.AddRow("Cost", processor.GetProcessingCost().ToString());
AnsiConsole.Write(result);
