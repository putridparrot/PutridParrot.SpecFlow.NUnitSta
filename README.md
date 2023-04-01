# PutridParrot.SpecFlow.NUnitSta


[![Build PutridParrot.SpecFlow.NUnitSta](https://github.com/putridparrot/PutridParrot.SpecFlow.NUnitSta/actions/workflows/dotnet-core.yml/badge.svg)](https://github.com/putridparrot/PutridParrot.SpecFlow.NUnitSta/actions/workflows/build.yml)
[![NuGet version (PutridParrot.SpecFlow.NUnitSta)](https://img.shields.io/nuget/v/PutridParrot.SpecFlow.NUnitSta.svg?style=flat-square)](https://www.nuget.org/packages/PutridParrot.SpecFlow.NUnitSta/)
[![GitHub license](https://img.shields.io/badge/license-MIT-blue.svg)](https://github.com/putridparrot/PutridParrot.SpecFlow.NUnitSta/blob/master/LICENSE.md)
[![GitHub Releases](https://img.shields.io/github/release/putridparrot/PutridParrot.SpecFlow.NUnitSta.svg)](https://github.com/putridparrot/PutridParrot.SpecFlow.NUnitSta/releases)
[![GitHub Issues](https://img.shields.io/github/issues/putridparrot/PutridParrot.SpecFlow.NUnitSta.svg)](https://github.com/putridparrot/PutridParrot.SpecFlow.NUnitSta/issues)


Whilst working with SpecFlow within a UI automation setup (using Appium/WinAppDriver) I found the need to paste strings into cells of a grid (for example) via the Clipboard. This requires an STA model and hence NUnit would complain.

This repository implements a very simple plugin for SpecFlow which simple adds the _NUnit.Framework.Apartment(ApartmentState.STA)_ attribute to test classes.

We could ofcourse create partial classes (as we did until this plugin was written) and add the attribute there, but using the plugin saves reminding developers and testers that they need to to do for each test class.
