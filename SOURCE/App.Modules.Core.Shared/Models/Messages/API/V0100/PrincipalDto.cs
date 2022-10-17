namespace App.Base.Shared.Models.Messages.API.V0100
{
    using System;
    using System.Collections.Generic;
    using System.Collections.ObjectModel;


    /// <summary>
    /// An API DTO
    /// for a Principal
    /// </summary>
    public class PrincipalDto  /* Avoid CONTRACTS on DTOs: UNDUE RISK OF INADVERTENT CHANGE */ : IHasGuidId, IHasEnabled
    {
#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
        private ICollection<PrincipalClaimDto> _claims;
        private ICollection<PrincipalPropertyDto> _properties;
        private ICollection<PrincipalTagDto> _tags;
        private ICollection<PrincipalLoginDto> _logins;
        private ICollection<RoleDto> _roles;
#pragma warning restore CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.

        /// <summary>
        /// The full name of the Pricipal
        /// <para>
        /// TODO: This is PI that may be best moved to a detachable Element...but that might lead to needing more Joins.
        /// </para>
        /// </summary>
        public string? FullName { get; set; }

        /// <summary>
        /// The display name of the principal.
        /// <para>
        /// TODO: This is PI that may be best moved to a detachable Element...but that might lead to needing more Joins.
        /// </para>
        /// </summary>
        public virtual string? DisplayName { get; set; }

        /// <summary>
        /// The Data Classification of the Principal
        /// </summary>
        public DataClassificationDto? DataClassification { get; set; }

        /// <summary>
        /// The Category of the Principal.
        /// </summary>
        public PrincipalCategoryDto? Category { get; set; }


        /// <summary>
        /// Collection of Security Roles the Principal has.
        /// <para>
        /// TODO: Should probably be only in the Security Profile.
        /// </para>
        /// </summary>
        public ICollection<RoleDto> Roles
        {
            get
            {
                if (this._roles == null)
                {
                    this._roles = new Collection<RoleDto>();
                }
                return this._roles;
            }
            set => this._roles = value;
        }

        /// <summary>
        /// Collection of Digital Identities associated to a Principal.
        /// </summary>
        public ICollection<PrincipalLoginDto> Logins
        {
            get
            {
                if (this._logins == null)
                {
                    this._logins = new Collection<PrincipalLoginDto>();
                }
                return this._logins;
            }
            set => this._logins = value;
        }

        /// <summary>
        /// Collection of Tags describing a Principal
        /// </summary>
        public virtual ICollection<PrincipalTagDto> Tags
        {
            get
            {
                if (this._tags == null)
                {
                    this._tags = new Collection<PrincipalTagDto>();
                }
                return this._tags;
            }
            set => this._tags = value;
        }
        
        /// <summary>
        /// Collection of properties describing a Principal
        /// </summary>
        public virtual ICollection<PrincipalPropertyDto> Properties
        {
            get
            {
                if (this._properties == null)
                {
                    this._properties = new Collection<PrincipalPropertyDto>();
                }
                return this._properties;
            }
            set => this._properties = value;
        }
        
        /// <summary>
        /// The collection of claims associated to the Principal.
        /// </summary>
        public virtual ICollection<PrincipalClaimDto> Claims
        {
            get
            {
                if (this._claims == null)
                {
                    this._claims = new Collection<PrincipalClaimDto>();
                }
                return this._claims;
            }
            set => this._claims = value;
        }
      
        /// <summary>
        /// Whether The Principal is enabled or not.
        /// </summary>
        public virtual bool Enabled { get; set; }

        /// <summary>
        /// The Id of the Record
        /// </summary>
        public virtual Guid Id { get; set; }
    }
}