using System;

namespace NServiceKit.ServiceHost
{
	/// <summary>
	/// If the Service also implements this interface,
	/// IRestPostService.Post() will be used instead of IService.Execute() for 
	/// EndpointAttributes.HttpPost requests
	/// </summary>
	/// <typeparam name="T"></typeparam>
    [Obsolete("Use IService - NServiceKit's New API for future services")]
    public interface IRestPostService<T>
	{
        /// <summary>Post this message.</summary>
        ///
        /// <param name="request">The request.</param>
        ///
        /// <returns>An object.</returns>
		object Post(T request);
	}
}