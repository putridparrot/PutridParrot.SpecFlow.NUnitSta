# PutridParrot.SpecFlow.NUnitSta

Whilst working with SpecFlow within a UI automation setup (using Appium/WinAppDriver) I found the need to paste strings into cells of a grid (for example) via the Clipboard. This requires an STA model and hence NUnit would complain.

This repository implements a very simple plugin for SpecFlow which simple adds the _NUnit.Framework.Apartment(ApartmentState.STA)_ attribute to test classes.

We could ofcourse create partial classes (as we did until this plugin was written) and add the attribute there, but using the plugin saves reminding developers and testers that they need to to do for each test class.
