---
title: Mediator
description: Centralize collaboration rules among objects that would otherwise communicate directly.
---

# Mediator

## Intent

Define an object that encapsulates how a set of objects interact.

## Use when

Peer objects are tightly coupled and their collaboration rules need one clear home.

## Avoid when

The mediator would become a large, opaque coordinator for unrelated workflows.

## Required files

- [Mediator.cs](Mediator.cs) — mediator contract and colleague base role.
