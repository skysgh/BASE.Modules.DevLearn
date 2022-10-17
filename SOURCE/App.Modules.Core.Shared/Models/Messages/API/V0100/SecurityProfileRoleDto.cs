namespace App.Base.Shared.Models.Messages.API.V0100
{
    using System;
    using System.Collections.Generic;
    using System.Collections.ObjectModel;
    using App.Base.Shared.Factories;
    using App.Base.Shared.Models;

    /// <summary>
    /// DTO for <c>SecurityProfileRole</c>
    /// </summary>
    public class SecurityProfileRoleDto  /* Avoid CONTRACTS on DTOs: UNDUE RISK OF INADVERTENT CHANGE */ : IHasGuidId
    {
        private Guid id;
        private string? title=String.Empty;
        private string? description=String.Empty;
        private ICollection<SecurityProfilePermissionDto> permissions = new Collection<SecurityProfilePermissionDto>();

        /// <summary>
        /// Constructor
        /// </summary>
        public SecurityProfileRoleDto()
        {
            this.Id = GuidFactory.NewGuid();

        }
        /// <summary>
        /// The Id
        /// </summary>
        public Guid Id { get => id; set => id = value; }

        /// <summary>
        /// The Title
        /// </summary>
        public string Title { get => title??String.Empty; set => title = value; }

        /// <summary>
        /// The Description
        /// </summary>
        public string Description { get => description??String.Empty; set => description = value; }

        /// <summary>
        /// 
        /// </summary>
        public ICollection<SecurityProfilePermissionDto> Permissions { get => permissions; set => permissions = value; }

    }
}

