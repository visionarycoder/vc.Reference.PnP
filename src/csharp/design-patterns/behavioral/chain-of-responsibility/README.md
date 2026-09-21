---
title: Chain of Responsibility
description: Pass a request through ordered handlers until one processes it.
---

# Chain of Responsibility

## Intent

Avoid coupling a request sender to a single receiver by passing the request along a chain of handlers.

## Use when

Requests need ordered, optional processing such as authentication, authorization, and support routing.

## Avoid when

Every request must have one fixed handler or the handler order would obscure required behavior.

## Source

See the [C# sample](.).
