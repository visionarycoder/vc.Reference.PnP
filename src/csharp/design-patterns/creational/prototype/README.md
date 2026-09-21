---
title: Prototype
description: Create new objects by cloning configured prototype instances.
---

# Prototype

## Intent

Specify the kinds of objects to create using a prototype instance, then create new objects by copying that prototype.

## Use when

Constructing a configured object is expensive or callers need new instances that begin from known templates.

## Avoid when

The object graph cannot be copied safely or ordinary construction is simpler and less error-prone.

## Required files

- [Canonical.cs](Canonical.cs): a cloneable concrete prototype.
