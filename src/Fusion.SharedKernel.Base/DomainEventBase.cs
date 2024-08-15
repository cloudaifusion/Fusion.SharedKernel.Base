// <copyright file="DomainEventBase.cs" company="CloudAIFusion.com">
// Copyright (c) CloudAIFusion.com. All rights reserved.
// </copyright>

namespace Fusion.SharedKernel.Base;

using System;
using MediatR;

/// <summary>
/// BaseDomainEvent.
/// </summary>
/// <seealso cref="MediatR.INotification" />
public abstract class DomainEventBase : INotification
{
    /// <summary>
    /// Gets or sets the date occurred.
    /// </summary>
    /// <value>
    /// The date occurred.
    /// </value>
    public DateTimeOffset DateOccurred { get; protected set; } = DateTimeOffset.UtcNow;
}