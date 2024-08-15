// <copyright file="EntityBase.cs" company="CloudAIFusion.com">
// Copyright (c) CloudAIFusion.com. All rights reserved.
// </copyright>

namespace Fusion.SharedKernel.Base;

using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

/// <summary>
/// Base types for all Entities which track state using a given Id.
/// </summary>
/// <typeparam name="TId">The type of the identifier.</typeparam>
public abstract class EntityBase<TId>
{
    private readonly List<DomainEventBase> domainEvents = new();

    /// <summary>
    /// Gets or sets the identifier.
    /// </summary>
    /// <value>
    /// The identifier.
    /// </value>
    public TId? Id { get; set; }

    /// <summary>
    /// Gets the domain events.
    /// </summary>
    /// <value>
    /// The domain events.
    /// </value>
    [NotMapped]
    public IReadOnlyList<DomainEventBase> DomainEvents => (IReadOnlyList<DomainEventBase>)this.domainEvents;

    /// <summary>
    /// Clears the domain events.
    /// </summary>
    public void ClearDomainEvents() => this.domainEvents.Clear();

    /// <summary>
    /// Registers the domain event.
    /// </summary>
    /// <param name="domainEvent">The domain event.</param>
    protected void RegisterDomainEvent(DomainEventBase domainEvent) => this.domainEvents.Add(domainEvent);
}