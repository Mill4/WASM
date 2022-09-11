using System;
using System.Collections.Generic;

namespace WasmDemoApp
{
    public class MyHelsinkiAPIData
    {
        public Meta meta { get; set; }
        public List<Data> data { get; set; }
    }

    public class Meta
    {
        public string count { get; set; }
        public string next { get; set; }
    }

    public class Name
    {
        public string fi { get; set; }
        public string en { get; set; }
        public string sv { get; set; }
        public string zh { get; set; }
    }

    public class SourceType
    {
        public int id { get; set; }
        public string name { get; set; }
    }

    public class Address
    {
        public string street_address { get; set; }
        public string postal_code { get; set; }
        public string locality { get; set; }
    }

    public class Location
    {
        public double lat { get; set; }
        public double lon { get; set; }
        public Address address { get; set; }
    }

    public class Description
    {
        public string intro { get; set; }
        public string body { get; set; }
    }


    public class EventDates
    {
        public DateTime starting_day { get; set; }
        public DateTime ending_day { get; set; }
        public object additional_description { get; set; }
    }

    public class Data
    {
        public string id { get; set; }
        public Name name { get; set; }
        public SourceType source_type { get; set; }
        public object info_url { get; set; }
        public DateTime modified_at { get; set; }
        public Location location { get; set; }
        public Description description { get; set; }
        public EventDates event_dates { get; set; }
    }

}
