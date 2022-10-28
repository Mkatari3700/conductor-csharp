/*
 * Conductor API Server
 *
 * Conductor API Server
 *
 * The version of the OpenAPI document: v0
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using System;
using System.Collections.Generic;
using Conductor;
using Conductor.Client;
using EventHandler = Conductor.Models.EventHandler;

namespace Conductor.Api
{

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IEventResourceApiSync : Conductor.Client.IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// Add a new event handler.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="eventHandler"></param>
        /// <returns></returns>
        void AddEventHandler(EventHandler eventHandler);
        /// <summary>
        /// Get all the event handlers
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <returns>List&lt;EventHandler&gt;</returns>
        List<EventHandler> GetEventHandlers();

        /// <summary>
        /// Get event handlers for a given event
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="_event"></param>
        /// <param name="activeOnly"> (optional, default to true)</param>
        /// <returns>List&lt;EventHandler&gt;</returns>
        List<EventHandler> GetEventHandlersForEvent(string _event, bool? activeOnly = default(bool?));

        /// <summary>
        /// Remove an event handler
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="name"></param>
        /// <returns></returns>
        void RemoveEventHandlerStatus(string name);

        /// <summary>
        /// Update an existing event handler.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="eventHandler"></param>
        /// <returns></returns>
        void UpdateEventHandler(EventHandler eventHandler);

        #endregion Synchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IEventResourceApi : IEventResourceApiSync
    {

    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class EventResourceApi : IEventResourceApi
    {
        private ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="EventResourceApi"/> class.
        /// </summary>
        /// <returns></returns>
        public EventResourceApi() : this((string)null)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="EventResourceApi"/> class.
        /// </summary>
        /// <returns></returns>
        public EventResourceApi(string basePath)
        {
            this.Configuration = Configuration.MergeConfigurations(
                GlobalConfiguration.Instance,
                new Configuration { BasePath = basePath }
            );
            this.Client = new ApiClient(this.Configuration.BasePath);
            this.ExceptionFactory = Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="EventResourceApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public EventResourceApi(Configuration configuration)
        {
            if (configuration == null) throw new ArgumentNullException("configuration");

            this.Configuration = Configuration.MergeConfigurations(
                GlobalConfiguration.Instance,
                configuration
            );
            this.Client = new ApiClient(this.Configuration.BasePath);
            ExceptionFactory = Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="EventResourceApi"/> class
        /// using a Configuration object and client instance.
        /// </summary>
        /// <param name="client">The client interface for synchronous API access.</param>
        /// <param name="configuration">The configuration object.</param>
        public EventResourceApi(ISynchronousClient client, Configuration configuration)
        {
            if (client == null) throw new ArgumentNullException("client");
            if (configuration == null) throw new ArgumentNullException("configuration");

            this.Client = client;
            this.Configuration = configuration;
            this.ExceptionFactory = Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// The client for accessing this underlying API synchronously.
        /// </summary>
        public ISynchronousClient Client { get; set; }

        /// <summary>
        /// Gets the base path of the API client.
        /// </summary>
        /// <value>The base path</value>
        public string GetBasePath()
        {
            return this.Configuration.BasePath;
        }

        /// <summary>
        /// Gets or sets the configuration object
        /// </summary>
        /// <value>An instance of the Configuration</value>
        public Configuration Configuration { get; set; }

        /// <summary>
        /// Provides a factory method hook for the creation of exceptions.
        /// </summary>
        public ExceptionFactory ExceptionFactory
        {
            get
            {
                if (_exceptionFactory != null && _exceptionFactory.GetInvocationList().Length > 1)
                {
                    throw new InvalidOperationException("Multicast delegate for ExceptionFactory is unsupported.");
                }
                return _exceptionFactory;
            }
            set { _exceptionFactory = value; }
        }

        Configuration IApiAccessor.Configuration { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        ExceptionFactory IApiAccessor.ExceptionFactory { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        /// <summary>
        /// Add a new event handler. 
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="eventHandler"></param>
        /// <returns></returns>
        public void AddEventHandler(EventHandler eventHandler)
        {
            AddEventHandlerWithHttpInfo(eventHandler);
        }

        /// <summary>
        /// Add a new event handler. 
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="eventHandler"></param>
        /// <returns>ApiResponse of Object(void)</returns>
        private ApiResponse<object> AddEventHandlerWithHttpInfo(EventHandler eventHandler)
        {
            // verify the required parameter 'eventHandler' is set
            if (eventHandler == null)
            {
                throw new ApiException(400, "Missing required parameter 'eventHandler' when calling EventResourceApi->AddEventHandler");
            }

            RequestOptions localVarRequestOptions = new RequestOptions();

            string[] _contentTypes = new string[] {
                "application/json"
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
            };

            var localVarContentType = ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);
            }

            var localVarAccept = ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);
            }

            localVarRequestOptions.Data = eventHandler;



            // make the HTTP request
            var localVarResponse = this.Client.Post<Object>("/api/event", localVarRequestOptions, this.Configuration);
            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("AddEventHandler", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Get all the event handlers 
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <returns>List&lt;EventHandler&gt;</returns>
        public List<EventHandler> GetEventHandlers()
        {
            ApiResponse<List<EventHandler>> localVarResponse = GetEventHandlersWithHttpInfo();
            return localVarResponse.Data;
        }

        /// <summary>
        /// Get all the event handlers 
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of List&lt;EventHandler&gt;</returns>
        private ApiResponse<List<EventHandler>> GetEventHandlersWithHttpInfo()
        {
            RequestOptions localVarRequestOptions = new RequestOptions();

            string[] _contentTypes = new string[] {
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "*/*"
            };

            var localVarContentType = ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);
            }

            var localVarAccept = ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);
            }




            // make the HTTP request
            var localVarResponse = this.Client.Get<List<EventHandler>>("/api/event", localVarRequestOptions, this.Configuration);
            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("GetEventHandlers", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Get event handlers for a given event 
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="_event"></param>
        /// <param name="activeOnly"> (optional, default to true)</param>
        /// <returns>List&lt;EventHandler&gt;</returns>
        public List<EventHandler> GetEventHandlersForEvent(string _event, bool? activeOnly = default(bool?))
        {
            ApiResponse<List<EventHandler>> localVarResponse = GetEventHandlersForEventWithHttpInfo(_event, activeOnly);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Get event handlers for a given event 
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="_event"></param>
        /// <param name="activeOnly"> (optional, default to true)</param>
        /// <returns>ApiResponse of List&lt;EventHandler&gt;</returns>
        private ApiResponse<List<EventHandler>> GetEventHandlersForEventWithHttpInfo(string _event, bool? activeOnly = default(bool?))
        {
            // verify the required parameter '_event' is set
            if (_event == null)
            {
                throw new ApiException(400, "Missing required parameter '_event' when calling EventResourceApi->GetEventHandlersForEvent");
            }

            RequestOptions localVarRequestOptions = new RequestOptions();

            string[] _contentTypes = new string[] {
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "*/*"
            };

            var localVarContentType = ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);
            }

            var localVarAccept = ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);
            }

            localVarRequestOptions.PathParameters.Add("event", ClientUtils.ParameterToString(_event)); // path parameter
            if (activeOnly != null)
            {
                localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "activeOnly", activeOnly));
            }



            // make the HTTP request
            var localVarResponse = this.Client.Get<List<EventHandler>>("/api/event/{event}", localVarRequestOptions, this.Configuration);
            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("GetEventHandlersForEvent", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Remove an event handler 
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="name"></param>
        /// <returns></returns>
        public void RemoveEventHandlerStatus(string name)
        {
            RemoveEventHandlerStatusWithHttpInfo(name);
        }

        /// <summary>
        /// Remove an event handler 
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="name"></param>
        /// <returns>ApiResponse of Object(void)</returns>
        private ApiResponse<object> RemoveEventHandlerStatusWithHttpInfo(string name)
        {
            // verify the required parameter 'name' is set
            if (name == null)
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling EventResourceApi->RemoveEventHandlerStatus");
            }

            RequestOptions localVarRequestOptions = new RequestOptions();

            string[] _contentTypes = new string[] {
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
            };

            var localVarContentType = ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);
            }

            var localVarAccept = ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);
            }

            localVarRequestOptions.PathParameters.Add("name", ClientUtils.ParameterToString(name)); // path parameter



            // make the HTTP request
            var localVarResponse = this.Client.Delete<Object>("/api/event/{name}", localVarRequestOptions, this.Configuration);
            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("RemoveEventHandlerStatus", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Update an existing event handler. 
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="eventHandler"></param>
        /// <returns></returns>
        public void UpdateEventHandler(EventHandler eventHandler)
        {
            UpdateEventHandlerWithHttpInfo(eventHandler);
        }

        /// <summary>
        /// Update an existing event handler. 
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="eventHandler"></param>
        /// <returns>ApiResponse of Object(void)</returns>
        private ApiResponse<object> UpdateEventHandlerWithHttpInfo(EventHandler eventHandler)
        {
            // verify the required parameter 'eventHandler' is set
            if (eventHandler == null)
            {
                throw new ApiException(400, "Missing required parameter 'eventHandler' when calling EventResourceApi->UpdateEventHandler");
            }

            RequestOptions localVarRequestOptions = new RequestOptions();

            string[] _contentTypes = new string[] {
                "application/json"
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
            };

            var localVarContentType = ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);
            }

            var localVarAccept = ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);
            }

            localVarRequestOptions.Data = eventHandler;



            // make the HTTP request
            var localVarResponse = this.Client.Put<Object>("/api/event", localVarRequestOptions, this.Configuration);
            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("UpdateEventHandler", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }
    }
}
