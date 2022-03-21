using RestSharp;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Net;
using System.Net.Http;
using System.Text;

namespace DS.GeoRef.DataStore.Migrations
{
    public class WebApiAsRepository<T>
    {

        protected List<string> warnings;
        protected List<string> errors;
        protected string segment;
        protected string api;
        protected string baseUrl;
        protected string autorizationValue;
        protected string autorizationKey = "X-API-KEY";
        protected HttpStatusCode statusCodeResponse = HttpStatusCode.InternalServerError;
        protected ResponseStatus ResponseStatus = ResponseStatus.Error;

        public WebApiAsRepository(string baseUrl, string segment, string autorizationValue, string api)
        {
            this.segment = segment;
            this.api = api;
            this.baseUrl = baseUrl;
            this.autorizationValue = autorizationValue;
        }

        protected virtual void DoInitialization()
        {

        }

        protected virtual void DoBeforeExecute(IRestRequest req)
        {

        }

        protected virtual void DoAfterRequest(HttpResponseMessage resp)
        {

        }

        protected virtual void DoBeforeDeserialization(IRestResponse resp)
        {

        }


        protected List<T> InternalAll(Method method = Method.GET)
        {
            var result = new List<T>();

            try
            {
                var client = new RestClient(this.baseUrl);
                var request = new RestRequest(this.segment, method);
                request.AddHeader(this.autorizationKey, this.autorizationValue);

                DoBeforeExecute(request);

                request.OnBeforeDeserialization =
                    resp =>
                    {
                        this.DoBeforeDeserialization(resp);
                    };

                var timeMeasure = new Stopwatch();
                timeMeasure.Start();

                var requestTask = client.ExecuteAsync<List<T>>(request, method);
                var responseTask = requestTask.ContinueWith((t) =>
                {
                    var statusCode = t.Result.StatusCode;
                    var responseStatus = t.Result.ResponseStatus;
                    timeMeasure.Stop();
                    var duration = Convert.ToInt32(timeMeasure.Elapsed.TotalMilliseconds);
                    try
                    {
                        var r = t.Result;
                        if (statusCode == HttpStatusCode.OK)
                        {
                            if (t.Result.ResponseStatus == ResponseStatus.Completed)
                            {
                                var datos = new List<T>();
                                if (r.Data != null)
                                    datos.AddRange(r.Data);

                                result.AddRange(datos);

                            }
                            else
                            {
                                var errMsg = string.Format("{0}: respuesta recibida,  {1}: {2}", api, r.ResponseStatus.ToString(), r.ErrorMessage);
                                this.errors.Add(string.Format("{0} | StatusCode:{1}", errMsg, (int)statusCode));
                            }
                        }
                        else
                        {
                            var errMsg = string.Format("{0}: respuesta con error {1} ({2})", api, r.Content, r.ErrorMessage);
                            this.errors.Add(string.Format("{0} | StatusCode:{1}", errMsg, (int)statusCode));
                        }
                    }
                    catch (Exception ex)
                    {
                        var msg = string.Format("error procesando respuesta {0}", api);
                        var exMsg = string.Format("{0} | {1}", msg, ex.Message);
                        this.errors.Add(exMsg);
                    }

                    this.statusCodeResponse = statusCode;
                    this.ResponseStatus = responseStatus;

                });

                responseTask.Wait();
            }
            catch (Exception ex)
            {
                var exMsg = string.Format("{0}: request error", api);
                this.errors.Add(exMsg);
                throw;
            }

            return result;
        }

    }
}
