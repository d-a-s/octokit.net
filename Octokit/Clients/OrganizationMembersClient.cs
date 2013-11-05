﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Octokit.Clients
{
    public class OrganizationMembersClient : ApiClient, IOrganizationMembers
    {
        /// <summary>
        /// Initializes a new Organization Members API client.
        /// </summary>
        /// <param name="apiConnection">An API connection.</param>
        public OrganizationMembersClient(IApiConnection apiConnection) : base(apiConnection)
        {

        }

        /// <summary>
        /// List all users who are members of an organization. A member is a user that
        /// belongs to at least 1 team in the organization.
        /// 
        /// If the authenticated user is also an owner of this organization then both
        /// concealed and public member will be returned.
        /// 
        /// If the requester is not an owner of the organization the query will be redirected
        /// to the public members list.
        /// </summary>
        /// <remarks>
        /// See the <a href="http://developer.github.com/v3/orgs/members/#members-list">API documentation</a>
        /// for more information.
        /// </remarks>
        /// <param name="org"></param>
        /// <returns></returns>
        public Task<IReadOnlyList<User>> GetAll(string org)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// List all users who have publicized their membership of the organization.
        /// </summary>
        /// <remarks>http://developer.github.com/v3/orgs/members/#public-members-list</remarks>
        /// <param name="org"></param>
        /// <returns></returns>
        public Task<IReadOnlyList<User>> GetPublic(string org)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Check if a user is, publicly or privately, a member of the organization.
        /// </summary>
        /// <remarks>
        /// See the <a href="http://developer.github.com/v3/orgs/members/#check-membership">API documentation</a>
        /// for more information.
        /// </remarks>
        /// <param name="org"></param>
        /// <param name="user"></param>
        /// <returns></returns>
        public Task<bool> CheckMember(string org, string user)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Check is a user is publicly a member of the organization.
        /// </summary>
        /// <remarks>
        /// See the <a href="http://developer.github.com/v3/orgs/members/#check-public-membership">API documentation</a>
        /// for more information.
        /// </remarks>
        /// <param name="org"></param>
        /// <param name="user"></param>
        /// <returns></returns>
        public Task<bool> CheckMemberPublic(string org, string user)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Removes a user from the organization, this will also remove them from all teams
        /// within the organization and they will no longer have any access to the organization's
        /// repositories.
        /// </summary>
        /// <remarks>
        /// See the <a href="http://developer.github.com/v3/orgs/members/#remove-a-member">API documentation</a>
        /// for more information.
        /// </remarks>
        /// <param name="org"></param>
        /// <param name="user"></param>
        /// <returns></returns>
        public Task Delete(string org, string user)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Make the authenticated user's organization membership public.
        /// </summary>
        /// <remarks>
        /// This method requires authentication.
        /// See the <a href="http://developer.github.com/v3/orgs/members/#publicize-a-users-membership" API documentation</a> 
        /// for more information.
        /// </remarks>
        /// <param name="org"></param>
        /// <param name="user"></param>
        /// <returns></returns>
        public Task<bool> Publicize(string org, string user)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Make the authenticated user's organization membership private.
        /// </summary>
        /// <remarks>
        /// This method requries authentication.
        /// See the <a href="http://developer.github.com/v3/orgs/members/#conceal-a-users-membership">API documentation</a>
        /// for more information.
        /// </remarks>
        /// <param name="org"></param>
        /// <param name="user"></param>
        /// <returns></returns>
        public Task<bool> Conceal(string org, string user)
        {
            throw new NotImplementedException();
        }
    }
}
