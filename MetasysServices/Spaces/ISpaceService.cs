﻿using System;
using System.Collections.Generic;
using System.Globalization;
using System.Threading.Tasks;
using JohnsonControls.Metasys.BasicServices;

namespace JohnsonControls.Metasys.BasicServices
{
    /// <summary>
    /// Defines method to provide space infos for endpoints of the Metasys Spaces API.
    /// </summary>
    public interface ISpaceService : IBasicService
    {
        // FindById ----------------------------------------------------------------------------------------------------------------
        /// <summary>
        /// Retrieves the specified space.
        /// </summary>
        /// <param name="spaceId">The identifier of the space.</param>
        /// <returns>The specified alarm details.</returns>
        MetasysObject FindById(Guid spaceId);
        /// <inheritdoc cref="ISpaceService.FindById(Guid)"/>
        Task<MetasysObject> FindByIdAsync(Guid spaceId);

        // Get ---------------------------------------------------------------------------------------------------------------------
        /// <summary>
        /// Retrieves a collection of spaces.
        /// </summary>
        /// <param name="type">Optional, type ID (numeric for v2, v3 - enumset key string for v4).</param>
        /// <exception cref="MetasysHttpException"></exception>
        /// <exception cref="MetasysHttpParsingException"></exception>
        IEnumerable<MetasysObject> Get(SpaceTypeEnum? type = null);
        /// <inheritdoc cref="ISpaceService.Get(SpaceTypeEnum?)"/>
        Task<IEnumerable<MetasysObject>> GetAsync(SpaceTypeEnum? type = null);


        // Get ---------------------------------------------------------------------------------------------------------------------
        /// <summary>
        /// Retrieves a collection of spaces.
        /// </summary>
        /// <param name="type">Optional, type ID (numeric for v2, v3 - enumset key string for v4).</param>
        IEnumerable<MetasysObject> Get(string type);
        /// <inheritdoc cref="ISpaceService.Get(string)"/>
        Task<IEnumerable<MetasysObject>> GetAsync(string type);

        // GetSpaceChildren ---------------------------------------------------------------------------------------------------------------
        /// <summary>
        /// Retrieves the collection of spaces that are located within the specified space.
        /// </summary>
        /// <param name="spaceId">The GUID of the parent space.</param>
        IEnumerable<MetasysObject> GetChildren(Guid spaceId);
        /// <inheritdoc cref="ISpaceService.GetChildren(Guid)"/>
        Task<IEnumerable<MetasysObject>> GetChildrenAsync(Guid spaceId);

        // GetSpaceTypes -----------------------------------------------------------------------------------------------------------------
        /// <summary>
        /// Retrieves the collection of all spaces types.
        /// </summary>
        IEnumerable<MetasysObjectType> GetTypes();
        /// <inheritdoc cref="ISpaceService.GetTypes()"/>
        Task<IEnumerable<MetasysObjectType>> GetTypesAsync();

        // GetServedByNetworkDevice -------------------------------------------------------------------------------------------------------
        /// <summary>
        /// Retrieves the collection of spaces served by the specified network device.
        /// </summary>
        IEnumerable<MetasysObject> GetServedByNetworkDevice(Guid networkDeviceId);
        /// <inheritdoc cref="ISpaceService.GetServedByNetworkDevice(Guid)"/>
        Task<IEnumerable<MetasysObject>> GetServedByNetworkDeviceAsync(Guid networkDeviceId);

        // GetServedByEquipment ----------------------------------------------------------------------------------------------------------
        /// <summary>
        /// Retrieves the collection of spaces served by the specified network device.
        /// </summary>
        IEnumerable<MetasysObject> GetServedByEquipment(Guid equipmentId);
        /// <inheritdoc cref="ISpaceService.GetServedByEquipment(Guid)"/>
        Task<IEnumerable<MetasysObject>> GetServedByEquipmentAsync(Guid equipmentId);

    }
}
