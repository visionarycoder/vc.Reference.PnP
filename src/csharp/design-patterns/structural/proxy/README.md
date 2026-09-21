---
title: Proxy
description: Supplies a surrogate that controls access to another object.
---

# Proxy

## Intent

Provide a stand-in that preserves an object's interface while adding access control or deferred work.

## Use when

Access needs authorization, caching, logging, remote indirection, or lazy initialization.

## Avoid when

The added layer does not provide meaningful access control or lifecycle value.

See [SecureDocumentProxy.cs](SecureDocumentProxy.cs) and [CachingDocumentProxy.cs](CachingDocumentProxy.cs).
