﻿using Microsoft.AspNetCore.Authorization;
using Umbraco.Cms.Core;
using Umbraco.Cms.Web.Common.Authorization;

namespace Umbraco.Cms.Api.Management.ServerEvents.Authorizers;

public class RelationTypeEventAuthorizer : EventSourcePolicyAuthorizer
{
    public RelationTypeEventAuthorizer(IAuthorizationService authorizationService) : base(authorizationService)
    {
    }

    public override IEnumerable<string> AuthorizableEventSources => [Constants.ServerEvents.EventSource.RelationType];

    protected override string Policy => AuthorizationPolicies.TreeAccessRelationTypes;
}
