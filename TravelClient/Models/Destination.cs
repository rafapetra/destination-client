using System.Collections.Generic;
using System;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace TravelClient.Models
{
  public class Destination
  {
    public int DestinationId { get; set; }
    public string City { get; set; }
    public string Country { get; set; }
    public string Review { get; set; }
    public double Rating { get; set; }
  

  public static List<Destination> GetDestinations()
  {
    var apiCallTask = ApiHelper.GetAll();
    var result = apiCallTask.Result;

    JArray jsonResponse = JsonConvert.DeserializeObject<JArray>(result);
    List<Destination> destinationList = JsonConvert.DeserializeObject<List<Destination>>(jsonResponse.ToString());

    return destinationList;
    }
  }
}