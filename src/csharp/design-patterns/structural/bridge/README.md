---
title: Bridge
description: Separates an abstraction from its implementation so both can vary independently.
---

# Bridge

## Intent

Decouple an abstraction from its implementation so each can change independently.

## Use when

Two independent dimensions of variation would otherwise produce a growing inheritance hierarchy.

## Avoid when

The abstraction and implementation are stable and have no independent variation.

See [NotificationChannel.cs](NotificationChannel.cs) and [IMessageSender.cs](IMessageSender.cs).
