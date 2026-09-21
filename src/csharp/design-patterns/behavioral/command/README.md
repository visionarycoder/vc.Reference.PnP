---
title: Command
description: Encapsulate an operation as an object that can be queued, logged, or undone.
---

# Command

## Intent

Encapsulate a request as an object so callers can parameterize, queue, log, and undo operations.

## Use when

Actions need deferred execution, history, undo, or composition into macros.

## Avoid when

An operation is simple, immediate, and does not benefit from a separate command object.

## Source

See the [C# sample](.).
