---
title: Memento
description: Capture and restore an object's state without exposing its representation.
---

# Memento

## Intent

Capture and externalize an object's internal state so it can be restored later without violating encapsulation.

## Use when

You need snapshots, checkpoints, or undo while preserving the originator's implementation details.

## Avoid when

State is large, frequent snapshots are costly, or a command history better describes the changes.

## Required files

- [Memento.cs](Memento.cs) — originator, immutable memento, and caretaker roles.
