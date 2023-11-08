# EngineBay.Telemetry

[![NuGet version](https://badge.fury.io/nu/EngineBay.Telemetry.svg)](https://badge.fury.io/nu/EngineBay.Telemetry)
[![Maintainability](https://api.codeclimate.com/v1/badges/3c3fbae6f050680fd3aa/maintainability)](https://codeclimate.com/github/engine-bay/telemetry/maintainability)
[![Test Coverage](https://api.codeclimate.com/v1/badges/3c3fbae6f050680fd3aa/test_coverage)](https://codeclimate.com/github/engine-bay/telemetry/test_coverage)

Telemetry module for EngineBay published to [EngineBay.Telemetry](https://www.nuget.org/packages/EngineBay.Telemetry/) on NuGet.

## About

This module will register services and middleware to expose telemetry and metrics sources, building on the [Open Telemetry ecosystem](https://opentelemetry.io/).

## Usage

Registering this module is sufficient to enable telemetry. It will automatically scrape endpoints and expose metrics.

### Registration

See the [Demo API registration guide](https://github.com/engine-bay/demo-api).

## Dependencies

* [EngineBay.Core](https://github.com/engine-bay/core)