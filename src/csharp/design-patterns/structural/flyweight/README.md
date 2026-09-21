---
title: Flyweight
description: Shares intrinsic state across many fine-grained objects to reduce memory use.
---

# Flyweight

## Intent

Share immutable intrinsic state among many objects and keep contextual state external.

## Use when

Large numbers of similar objects create measurable memory pressure.

## Avoid when

Object counts are modest or splitting state makes the model harder to use than it saves.

See [CharacterFlyweightFactory.cs](CharacterFlyweightFactory.cs) and [CharacterFlyweight.cs](CharacterFlyweight.cs).
