/*
 * Bitcasa.PCL
 *
 * This file was automatically generated by APIMATIC v2.0 ( https://apimatic.io ) on 07/19/2016
 */
using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bitcasa.PCL;
using Bitcasa.PCL.Http.Request;
using Bitcasa.PCL.Http.Response;
using Bitcasa.PCL.Http.Client;
using Bitcasa.PCL.Models;

namespace Bitcasa.PCL.Controllers
{
    public partial class TrashOperationsController: BaseController
    {
        #region Singleton Pattern

        //private static variables for the singleton pattern
        private static object syncObject = new object();
        private static TrashOperationsController instance = null;

        /// <summary>
        /// Singleton pattern implementation
        /// </summary>
        internal static TrashOperationsController Instance
        {
            get
            {
                lock (syncObject)
                {
                    if (null == instance)
                    {
                        instance = new TrashOperationsController();
                    }
                }
                return instance;
            }
        }

        #endregion Singleton Pattern

        /// <summary>
        /// TODO: type endpoint description here
        /// </summary>
        /// <param name="path">Required parameter: Example: </param>
        /// <return>Returns the BrowseTrashResponse response from the API call</return>
        public BrowseTrashResponse GetBrowseTrash(string path)
        {
            Task<BrowseTrashResponse> t = GetBrowseTrashAsync(path);
            Task.WaitAll(t);
            return t.Result;
        }

        /// <summary>
        /// TODO: type endpoint description here
        /// </summary>
        /// <param name="path">Required parameter: Example: </param>
        /// <return>Returns the BrowseTrashResponse response from the API call</return>
        public async Task<BrowseTrashResponse> GetBrowseTrashAsync(string path)
        {
            //the base uri for api requestss
            string _baseUri = string.Format(Configuration.BaseUri, Configuration.AccountId);

            //prepare query string for API call
            StringBuilder _queryBuilder = new StringBuilder(_baseUri);
            _queryBuilder.Append("/v2/trash/{path}");

            //process optional template parameters
            APIHelper.AppendUrlWithTemplateParameters(_queryBuilder, new Dictionary<string, object>()
            {
                { "path", path }
            });


            //validate and preprocess url
            string _queryUrl = APIHelper.CleanUrl(_queryBuilder);

            //append request with appropriate headers and parameters
            var _headers = new Dictionary<string,string>()
            {
                { "user-agent", "APIMATIC 2.0" },
                { "accept", "application/json" }
            };
            _headers.Add("Authorization", string.Format("Bearer {0}", Configuration.OAuthAccessToken));

            //prepare the API call request to fetch the response
            HttpRequest _request = ClientInstance.Get(_queryUrl,_headers);

            //invoke request and get response
            HttpStringResponse _response = (HttpStringResponse) await ClientInstance.ExecuteAsStringAsync(_request);
            HttpContext _context = new HttpContext(_request,_response);
            //handle errors defined at the API level
            base.ValidateResponse(_response, _context);

            try
            {
                return APIHelper.JsonDeserialize<BrowseTrashResponse>(_response.Body);
            }
            catch (Exception _ex)
            {
                throw new APIException("Failed to parse the response: " + _ex.Message, _context);
            }
        }

        /// <summary>
        /// TODO: type endpoint description here
        /// </summary>
        /// <param name="path">Required parameter: Example: </param>
        /// <return>Returns the void response from the API call</return>
        public void DeleteTrashItems(string path)
        {
            Task t = DeleteTrashItemsAsync(path);
            Task.WaitAll(t);
        }

        /// <summary>
        /// TODO: type endpoint description here
        /// </summary>
        /// <param name="path">Required parameter: Example: </param>
        /// <return>Returns the void response from the API call</return>
        public async Task DeleteTrashItemsAsync(string path)
        {
            //the base uri for api requestss
            string _baseUri = string.Format(Configuration.BaseUri, Configuration.AccountId);

            //prepare query string for API call
            StringBuilder _queryBuilder = new StringBuilder(_baseUri);
            _queryBuilder.Append("/v2/trash/{path}");

            //process optional template parameters
            APIHelper.AppendUrlWithTemplateParameters(_queryBuilder, new Dictionary<string, object>()
            {
                { "path", path }
            });


            //validate and preprocess url
            string _queryUrl = APIHelper.CleanUrl(_queryBuilder);

            //append request with appropriate headers and parameters
            var _headers = new Dictionary<string,string>()
            {
                { "user-agent", "APIMATIC 2.0" }
            };
            _headers.Add("Authorization", string.Format("Bearer {0}", Configuration.OAuthAccessToken));

            //prepare the API call request to fetch the response
            HttpRequest _request = ClientInstance.Delete(_queryUrl, _headers, null);

            //invoke request and get response
            HttpStringResponse _response = (HttpStringResponse) await ClientInstance.ExecuteAsStringAsync(_request);
            HttpContext _context = new HttpContext(_request,_response);
            //handle errors defined at the API level
            base.ValidateResponse(_response, _context);

        }

        /// <summary>
        /// TODO: type endpoint description here
        /// </summary>
        /// <param name="path">Required parameter: Example: </param>
        /// <param name="restore">Optional parameter: Example: </param>
        /// <param name="rescuePath">Optional parameter: Example: </param>
        /// <param name="recreatePath">Optional parameter: Example: </param>
        /// <return>Returns the void response from the API call</return>
        public void CreateRecoverTrashItems(
                string path,
                string restore = null,
                string rescuePath = null,
                string recreatePath = null)
        {
            Task t = CreateRecoverTrashItemsAsync(path, restore, rescuePath, recreatePath);
            Task.WaitAll(t);
        }

        /// <summary>
        /// TODO: type endpoint description here
        /// </summary>
        /// <param name="path">Required parameter: Example: </param>
        /// <param name="restore">Optional parameter: Example: </param>
        /// <param name="rescuePath">Optional parameter: Example: </param>
        /// <param name="recreatePath">Optional parameter: Example: </param>
        /// <return>Returns the void response from the API call</return>
        public async Task CreateRecoverTrashItemsAsync(
                string path,
                string restore = null,
                string rescuePath = null,
                string recreatePath = null)
        {
            //the base uri for api requestss
            string _baseUri = string.Format(Configuration.BaseUri, Configuration.AccountId);

            //prepare query string for API call
            StringBuilder _queryBuilder = new StringBuilder(_baseUri);
            _queryBuilder.Append("/v2/trash/{path}");

            //process optional template parameters
            APIHelper.AppendUrlWithTemplateParameters(_queryBuilder, new Dictionary<string, object>()
            {
                { "path", path }
            });


            //validate and preprocess url
            string _queryUrl = APIHelper.CleanUrl(_queryBuilder);

            //append request with appropriate headers and parameters
            var _headers = new Dictionary<string,string>()
            {
                { "user-agent", "APIMATIC 2.0" }
            };
            _headers.Add("Authorization", string.Format("Bearer {0}", Configuration.OAuthAccessToken));

            //append form/field parameters
            var _fields = new Dictionary<string,object>()
            {
                { "restore", restore },
                { "rescue-path", rescuePath },
                { "recreate-path", recreatePath }
            };

            //prepare the API call request to fetch the response
            HttpRequest _request = ClientInstance.Post(_queryUrl, _headers, _fields);

            //invoke request and get response
            HttpStringResponse _response = (HttpStringResponse) await ClientInstance.ExecuteAsStringAsync(_request);
            HttpContext _context = new HttpContext(_request,_response);
            //handle errors defined at the API level
            base.ValidateResponse(_response, _context);

        }

    }
} 