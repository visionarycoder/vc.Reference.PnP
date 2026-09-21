---
title: Structural Pattern Samples
description: Spectre.Console demonstrations that exercise the pure structural pattern library.
---

# Structural Pattern Samples

This executable is the presentation edge for structural examples. It references `../../structural/DesignPatterns.Structural.csproj`; the pattern contracts and collaborators remain in that library.

The preserved richer scenarios are grouped under:

- `adapter/` for media and legacy-database adaptation.
- `bridge/` for notification channels and senders.
- `composite/` for file-system and organization trees.
- `decorator/` for text pipelines and beverages.
- `facade/` for user management.
- `flyweight/` for characters, text, and sprites.
- `proxy/` for documents and images.

Run it with:

```powershell
dotnet run --project src/csharp/design-patterns/samples/structural --configuration Release
```

The source comments identify what each demonstration shows, where the pattern boundary lives, and why the interaction matters.
