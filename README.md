# Selenium C#
Projekt zaliczeniowy na przedmiot Testy i kontrola jakości oprogramowania.

This repository contains a collection of Selenium C# automating web testing.

## Project Structure

The project is organized as follows:

- `TestClass.cs`: The test performs actions such as accepting cookie consent, entering an email, and clicking the registration button on a webpage.

- `SeleniumCSharpTutorial04.cs`: This test initializes a Chrome driver, opens a webpage (e.g., Facebook), enters an email, and closes the driver. The test is parameterized with a single URL: "https://www.facebook.com/".

- `ParallelTesting.cs`: Similar to the previous test, it initializes a driver, opens a webpage, enters an email, and closes the driver. The test is also parameterized with the same URL: "https://www.facebook.com/". Additionally, it captures a screenshot if an exception occurs during execution.

- `OrderSkipAttribute.cs`: These tests demonstrate different browsers (Chrome, Firefox, and Internet Explorer) and their execution order. `TestMethod3` is ignored due to the end of support for Internet Explorer.

## Requirements

* Set up your Selenium environment (install webdriver, etc.).
