﻿using NUnit.Framework;
using TauCode.Testing.Tests.Core;
using TauCode.Testing.Tests.Core.Features.Watchers.ChangeWatcherBasicCurrency;

namespace TauCode.Testing.Tests.Watchers;

[TestFixture]
public class ChangeWatcherBasicCurrencyCommandValidatorTests : ValidatorTestBase<
    ChangeWatcherBasicCurrencyCommand,
    ChangeWatcherBasicCurrencyCommandValidator>
{
    [SetUp]
    public void SetUp()
    {
        this.SetUpImpl();
        this.Validator.Parameters["watcherId"] = 100801L;
    }

    [Test]
    public void Command_IsValid_Ok()
    {
        // Arrange
        var command = this.CreateInstance();

        // Act
        var validationResult = this.ValidateInstance(command);

        // Assert
        validationResult.ShouldBeValid();
    }

    [Test]
    [TestCase(null)]
    [TestCase(0L)]
    [TestCase(-1L)]
    public void WatcherId_IsBad_Error(long? badId)
    {
        // Arrange
        var command = this.CreateInstance();
        this.Validator.Parameters["watcherId"] = badId;

        // Act
        var validationResult = this.ValidateInstance(command);

        // Assert
        validationResult
            .ShouldBeInvalid(1)
            .ShouldHaveError(
                0,
                nameof(ChangeWatcherBasicCurrencyCommand.WatcherId),
                "LongIdValidator",
                "'WatcherId' must be a valid long Id.");
    }

    [Test]
    public void WatcherId_IsOfDefaultSystemWatcher_Error()
    {
        // Arrange
        var command = this.CreateInstance();
        this.Validator.Parameters["watcherId"] = DataConstants.SystemWatcher.DefaultSystemWatcherId;

        // Act
        var validationResult = this.ValidateInstance(command);

        // Assert
        validationResult
            .ShouldBeInvalid(1)
            .ShouldHaveError(
                0,
                nameof(ChangeWatcherBasicCurrencyCommand.WatcherId),
                "NotEqualValidator",
                "'WatcherId' must not be equal to '1'.");
    }

    [Test]
    [TestCase(null)]
    [TestCase("")]
    [TestCase("RB", Description = "Not 3 symbols")]
    [TestCase("EURO", Description = "Not 3 symbols")]
    [TestCase("USd", Description = "Not all upper-case")]
    [TestCase("RB.", Description = "Not all letters")]
    public void CurrencyCode_IsBad_Error(string? badCurrencyCode)
    {
        // Arrange
        var command = this.CreateInstance();
        command.CurrencyCode = badCurrencyCode;

        // Act
        var validationResult = this.ValidateInstance(command);

        // Assert
        validationResult
            .ShouldBeInvalid(1)
            .ShouldHaveError(
                0,
                nameof(ChangeWatcherBasicCurrencyCommand.CurrencyCode),
                "CurrencyCodeValidator",
                "'Currency Code' must be a valid currency code.");
    }

    protected override ChangeWatcherBasicCurrencyCommand CreateInstance()
    {
        return new ChangeWatcherBasicCurrencyCommand
        {
            CurrencyCode = "EUR",
        };
    }
}