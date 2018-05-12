// Copyright © Christopher Dorst. All rights reserved.
// Licensed under the GNU General Public License, Version 3.0. See the LICENSE document in the repository root for license information.

using Microsoft.WindowsAzure.Storage;

namespace Cloud.Azure.Storage.Services.Blobs.Interfaces.CloudBlobClientGetter
{
    /// <summary>Interface for service responsible for getting a cloud blob client reference</summary>
    public interface ICloudBlobClientGetter
    {
        /// <summary>Returns reference to the blob client</summary>
        CloudBlobClient BlobClient { get; }
    }
}
