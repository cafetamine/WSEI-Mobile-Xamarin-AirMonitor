namespace AirMonitor.Client.Airly.Mock
{
    public class AirlyApiMockedMeasurementJson
    {
        public static string Get(int id)
        {
            if (id == 8077)
            {
                return
@"
{
    ""current"":{
       ""fromDateTime"":""2020-06-20T12:01:45.245Z"",
       ""tillDateTime"":""2020-06-20T13:01:45.245Z"",
       ""values"":[
          {
             ""name"":""PM1"",
             ""value"":7.88
          },
          {
             ""name"":""PM25"",
             ""value"":11.36
          },
          {
             ""name"":""PM10"",
             ""value"":20.5
          },
          {
             ""name"":""PRESSURE"",
             ""value"":1011.44
          },
          {
             ""name"":""HUMIDITY"",
             ""value"":95.5
          },
          {
             ""name"":""TEMPERATURE"",
             ""value"":19.04
          }
       ],
       ""indexes"":[
          {
             ""name"":""AIRLY_CAQI"",
             ""value"":20.5,
             ""level"":""VERY_LOW"",
             ""description"":""Great air here today!"",
             ""advice"":""Great air!"",
             ""color"":""#6BC926""
          }
       ],
       ""standards"":[
          {
             ""name"":""WHO"",
             ""pollutant"":""PM25"",
             ""limit"":25,
             ""percent"":45.44,
             ""averaging"":""24h""
          },
          {
             ""name"":""WHO"",
             ""pollutant"":""PM10"",
             ""limit"":50,
             ""percent"":41.01,
             ""averaging"":""24h""
          }
       ]
    },
    ""history"":[
       {
          ""fromDateTime"":""2020-06-19T13:00:00.000Z"",
          ""tillDateTime"":""2020-06-19T14:00:00.000Z"",
          ""values"":[
             {
                ""name"":""PM1"",
                ""value"":8.05
             },
             {
                ""name"":""PM25"",
                ""value"":11.69
             },
             {
                ""name"":""PM10"",
                ""value"":21.5
             },
             {
                ""name"":""PRESSURE"",
                ""value"":1009.91
             },
             {
                ""name"":""HUMIDITY"",
                ""value"":89.91
             },
             {
                ""name"":""TEMPERATURE"",
                ""value"":20.77
             }
          ],
          ""indexes"":[
             {
                ""name"":""AIRLY_CAQI"",
                ""value"":21.5,
                ""level"":""VERY_LOW"",
                ""description"":""Great air here today!"",
                ""advice"":""Breathe as much as you can!"",
                ""color"":""#6BC926""
             }
          ],
          ""standards"":[
             {
                ""name"":""WHO"",
                ""pollutant"":""PM25"",
                ""limit"":25,
                ""percent"":46.76,
                ""averaging"":""24h""
             },
             {
                ""name"":""WHO"",
                ""pollutant"":""PM10"",
                ""limit"":50,
                ""percent"":43.01,
                ""averaging"":""24h""
             }
          ]
       },
       {
          ""fromDateTime"":""2020-06-19T14:00:00.000Z"",
          ""tillDateTime"":""2020-06-19T15:00:00.000Z"",
          ""values"":[
             {
                ""name"":""PM1"",
                ""value"":5.44
             },
             {
                ""name"":""PM25"",
                ""value"":7.73
             },
             {
                ""name"":""PM10"",
                ""value"":14.17
             },
             {
                ""name"":""PRESSURE"",
                ""value"":1009.91
             },
             {
                ""name"":""HUMIDITY"",
                ""value"":91.42
             },
             {
                ""name"":""TEMPERATURE"",
                ""value"":19.97
             }
          ],
          ""indexes"":[
             {
                ""name"":""AIRLY_CAQI"",
                ""value"":14.17,
                ""level"":""VERY_LOW"",
                ""description"":""Great air here today!"",
                ""advice"":""Perfect air for exercising! Go for it!"",
                ""color"":""#6BC926""
             }
          ],
          ""standards"":[
             {
                ""name"":""WHO"",
                ""pollutant"":""PM25"",
                ""limit"":25,
                ""percent"":30.92,
                ""averaging"":""24h""
             },
             {
                ""name"":""WHO"",
                ""pollutant"":""PM10"",
                ""limit"":50,
                ""percent"":28.33,
                ""averaging"":""24h""
             }
          ]
       },
       {
          ""fromDateTime"":""2020-06-19T15:00:00.000Z"",
          ""tillDateTime"":""2020-06-19T16:00:00.000Z"",
          ""values"":[
             {
                ""name"":""PM1"",
                ""value"":6.93
             },
             {
                ""name"":""PM25"",
                ""value"":9.72
             },
             {
                ""name"":""PM10"",
                ""value"":17.81
             },
             {
                ""name"":""PRESSURE"",
                ""value"":1010.25
             },
             {
                ""name"":""HUMIDITY"",
                ""value"":91.17
             },
             {
                ""name"":""TEMPERATURE"",
                ""value"":19.27
             }
          ],
          ""indexes"":[
             {
                ""name"":""AIRLY_CAQI"",
                ""value"":17.81,
                ""level"":""VERY_LOW"",
                ""description"":""Great air here today!"",
                ""advice"":""Green equals clean!"",
                ""color"":""#6BC926""
             }
          ],
          ""standards"":[
             {
                ""name"":""WHO"",
                ""pollutant"":""PM25"",
                ""limit"":25,
                ""percent"":38.88,
                ""averaging"":""24h""
             },
             {
                ""name"":""WHO"",
                ""pollutant"":""PM10"",
                ""limit"":50,
                ""percent"":35.62,
                ""averaging"":""24h""
             }
          ]
       },
       {
          ""fromDateTime"":""2020-06-19T16:00:00.000Z"",
          ""tillDateTime"":""2020-06-19T17:00:00.000Z"",
          ""values"":[
             {
                ""name"":""PM1"",
                ""value"":7.82
             },
             {
                ""name"":""PM25"",
                ""value"":11.1
             },
             {
                ""name"":""PM10"",
                ""value"":19.98
             },
             {
                ""name"":""PRESSURE"",
                ""value"":1010.56
             },
             {
                ""name"":""HUMIDITY"",
                ""value"":95.65
             },
             {
                ""name"":""TEMPERATURE"",
                ""value"":18.78
             }
          ],
          ""indexes"":[
             {
                ""name"":""AIRLY_CAQI"",
                ""value"":19.98,
                ""level"":""VERY_LOW"",
                ""description"":""Great air here today!"",
                ""advice"":""Breathe to fill your lungs!"",
                ""color"":""#6BC926""
             }
          ],
          ""standards"":[
             {
                ""name"":""WHO"",
                ""pollutant"":""PM25"",
                ""limit"":25,
                ""percent"":44.41,
                ""averaging"":""24h""
             },
             {
                ""name"":""WHO"",
                ""pollutant"":""PM10"",
                ""limit"":50,
                ""percent"":39.97,
                ""averaging"":""24h""
             }
          ]
       },
       {
          ""fromDateTime"":""2020-06-19T17:00:00.000Z"",
          ""tillDateTime"":""2020-06-19T18:00:00.000Z"",
          ""values"":[
             {
                ""name"":""PM1"",
                ""value"":8.02
             },
             {
                ""name"":""PM25"",
                ""value"":11.6
             },
             {
                ""name"":""PM10"",
                ""value"":20.98
             },
             {
                ""name"":""PRESSURE"",
                ""value"":1010.95
             },
             {
                ""name"":""HUMIDITY"",
                ""value"":98.14
             },
             {
                ""name"":""TEMPERATURE"",
                ""value"":18.07
             }
          ],
          ""indexes"":[
             {
                ""name"":""AIRLY_CAQI"",
                ""value"":20.98,
                ""level"":""VERY_LOW"",
                ""description"":""Great air here today!"",
                ""advice"":""Breathe as much as you can!"",
                ""color"":""#6BC926""
             }
          ],
          ""standards"":[
             {
                ""name"":""WHO"",
                ""pollutant"":""PM25"",
                ""limit"":25,
                ""percent"":46.39,
                ""averaging"":""24h""
             },
             {
                ""name"":""WHO"",
                ""pollutant"":""PM10"",
                ""limit"":50,
                ""percent"":41.97,
                ""averaging"":""24h""
             }
          ]
       },
       {
          ""fromDateTime"":""2020-06-19T18:00:00.000Z"",
          ""tillDateTime"":""2020-06-19T19:00:00.000Z"",
          ""values"":[
             {
                ""name"":""PM1"",
                ""value"":11.62
             },
             {
                ""name"":""PM25"",
                ""value"":17.03
             },
             {
                ""name"":""PM10"",
                ""value"":31.85
             },
             {
                ""name"":""PRESSURE"",
                ""value"":1011.33
             },
             {
                ""name"":""HUMIDITY"",
                ""value"":93.85
             },
             {
                ""name"":""TEMPERATURE"",
                ""value"":18.21
             }
          ],
          ""indexes"":[
             {
                ""name"":""AIRLY_CAQI"",
                ""value"":31.85,
                ""level"":""LOW"",
                ""description"":""Air is quite good."",
                ""advice"":""Enjoy the clean air."",
                ""color"":""#D1CF1E""
             }
          ],
          ""standards"":[
             {
                ""name"":""WHO"",
                ""pollutant"":""PM25"",
                ""limit"":25,
                ""percent"":68.14,
                ""averaging"":""24h""
             },
             {
                ""name"":""WHO"",
                ""pollutant"":""PM10"",
                ""limit"":50,
                ""percent"":63.7,
                ""averaging"":""24h""
             }
          ]
       },
       {
          ""fromDateTime"":""2020-06-19T19:00:00.000Z"",
          ""tillDateTime"":""2020-06-19T20:00:00.000Z"",
          ""values"":[
             {
                ""name"":""PM1"",
                ""value"":13.16
             },
             {
                ""name"":""PM25"",
                ""value"":19.74
             },
             {
                ""name"":""PM10"",
                ""value"":38.54
             },
             {
                ""name"":""PRESSURE"",
                ""value"":1011.89
             },
             {
                ""name"":""HUMIDITY"",
                ""value"":94.2
             },
             {
                ""name"":""TEMPERATURE"",
                ""value"":18.3
             }
          ],
          ""indexes"":[
             {
                ""name"":""AIRLY_CAQI"",
                ""value"":38.54,
                ""level"":""LOW"",
                ""description"":""Air is quite good."",
                ""advice"":""The air quality is good today!"",
                ""color"":""#D1CF1E""
             }
          ],
          ""standards"":[
             {
                ""name"":""WHO"",
                ""pollutant"":""PM25"",
                ""limit"":25,
                ""percent"":78.98,
                ""averaging"":""24h""
             },
             {
                ""name"":""WHO"",
                ""pollutant"":""PM10"",
                ""limit"":50,
                ""percent"":77.09,
                ""averaging"":""24h""
             }
          ]
       },
       {
          ""fromDateTime"":""2020-06-19T20:00:00.000Z"",
          ""tillDateTime"":""2020-06-19T21:00:00.000Z"",
          ""values"":[
             {
                ""name"":""PM1"",
                ""value"":12.63
             },
             {
                ""name"":""PM25"",
                ""value"":19.06
             },
             {
                ""name"":""PM10"",
                ""value"":36.21
             },
             {
                ""name"":""PRESSURE"",
                ""value"":1012.05
             },
             {
                ""name"":""HUMIDITY"",
                ""value"":96.97
             },
             {
                ""name"":""TEMPERATURE"",
                ""value"":17.88
             }
          ],
          ""indexes"":[
             {
                ""name"":""AIRLY_CAQI"",
                ""value"":36.21,
                ""level"":""LOW"",
                ""description"":""Air is quite good."",
                ""advice"":""Don't miss this day! The clean air calls!"",
                ""color"":""#D1CF1E""
             }
          ],
          ""standards"":[
             {
                ""name"":""WHO"",
                ""pollutant"":""PM25"",
                ""limit"":25,
                ""percent"":76.22,
                ""averaging"":""24h""
             },
             {
                ""name"":""WHO"",
                ""pollutant"":""PM10"",
                ""limit"":50,
                ""percent"":72.42,
                ""averaging"":""24h""
             }
          ]
       },
       {
          ""fromDateTime"":""2020-06-19T21:00:00.000Z"",
          ""tillDateTime"":""2020-06-19T22:00:00.000Z"",
          ""values"":[
             {
                ""name"":""PM1"",
                ""value"":13.83
             },
             {
                ""name"":""PM25"",
                ""value"":20.79
             },
             {
                ""name"":""PM10"",
                ""value"":41.58
             },
             {
                ""name"":""PRESSURE"",
                ""value"":1012.02
             },
             {
                ""name"":""HUMIDITY"",
                ""value"":99.4
             },
             {
                ""name"":""TEMPERATURE"",
                ""value"":17.59
             }
          ],
          ""indexes"":[
             {
                ""name"":""AIRLY_CAQI"",
                ""value"":41.58,
                ""level"":""LOW"",
                ""description"":""Air is quite good."",
                ""advice"":""Enjoy the clean air."",
                ""color"":""#D1CF1E""
             }
          ],
          ""standards"":[
             {
                ""name"":""WHO"",
                ""pollutant"":""PM25"",
                ""limit"":25,
                ""percent"":83.15,
                ""averaging"":""24h""
             },
             {
                ""name"":""WHO"",
                ""pollutant"":""PM10"",
                ""limit"":50,
                ""percent"":83.16,
                ""averaging"":""24h""
             }
          ]
       },
       {
          ""fromDateTime"":""2020-06-19T22:00:00.000Z"",
          ""tillDateTime"":""2020-06-19T23:00:00.000Z"",
          ""values"":[
             {
                ""name"":""PM1"",
                ""value"":13.2
             },
             {
                ""name"":""PM25"",
                ""value"":20.04
             },
             {
                ""name"":""PM10"",
                ""value"":39.42
             },
             {
                ""name"":""PRESSURE"",
                ""value"":1011.85
             },
             {
                ""name"":""HUMIDITY"",
                ""value"":100
             },
             {
                ""name"":""TEMPERATURE"",
                ""value"":17.34
             }
          ],
          ""indexes"":[
             {
                ""name"":""AIRLY_CAQI"",
                ""value"":39.42,
                ""level"":""LOW"",
                ""description"":""Air is quite good."",
                ""advice"":""The air is nice and clean today!"",
                ""color"":""#D1CF1E""
             }
          ],
          ""standards"":[
             {
                ""name"":""WHO"",
                ""pollutant"":""PM25"",
                ""limit"":25,
                ""percent"":80.17,
                ""averaging"":""24h""
             },
             {
                ""name"":""WHO"",
                ""pollutant"":""PM10"",
                ""limit"":50,
                ""percent"":78.84,
                ""averaging"":""24h""
             }
          ]
       },
       {
          ""fromDateTime"":""2020-06-19T23:00:00.000Z"",
          ""tillDateTime"":""2020-06-20T00:00:00.000Z"",
          ""values"":[
             {
                ""name"":""PM1"",
                ""value"":11.23
             },
             {
                ""name"":""PM25"",
                ""value"":16.72
             },
             {
                ""name"":""PM10"",
                ""value"":31.34
             },
             {
                ""name"":""PRESSURE"",
                ""value"":1011.82
             },
             {
                ""name"":""HUMIDITY"",
                ""value"":100
             },
             {
                ""name"":""TEMPERATURE"",
                ""value"":17.04
             }
          ],
          ""indexes"":[
             {
                ""name"":""AIRLY_CAQI"",
                ""value"":31.34,
                ""level"":""LOW"",
                ""description"":""Air is quite good."",
                ""advice"":""Take a deep breath. Today, you can. ;)"",
                ""color"":""#D1CF1E""
             }
          ],
          ""standards"":[
             {
                ""name"":""WHO"",
                ""pollutant"":""PM25"",
                ""limit"":25,
                ""percent"":66.89,
                ""averaging"":""24h""
             },
             {
                ""name"":""WHO"",
                ""pollutant"":""PM10"",
                ""limit"":50,
                ""percent"":62.68,
                ""averaging"":""24h""
             }
          ]
       },
       {
          ""fromDateTime"":""2020-06-20T00:00:00.000Z"",
          ""tillDateTime"":""2020-06-20T01:00:00.000Z"",
          ""values"":[
             {
                ""name"":""PM1"",
                ""value"":11.21
             },
             {
                ""name"":""PM25"",
                ""value"":16.56
             },
             {
                ""name"":""PM10"",
                ""value"":30.97
             },
             {
                ""name"":""PRESSURE"",
                ""value"":1011.68
             },
             {
                ""name"":""HUMIDITY"",
                ""value"":100
             },
             {
                ""name"":""TEMPERATURE"",
                ""value"":16.56
             }
          ],
          ""indexes"":[
             {
                ""name"":""AIRLY_CAQI"",
                ""value"":30.97,
                ""level"":""LOW"",
                ""description"":""Air is quite good."",
                ""advice"":""Enjoy the clean air."",
                ""color"":""#D1CF1E""
             }
          ],
          ""standards"":[
             {
                ""name"":""WHO"",
                ""pollutant"":""PM25"",
                ""limit"":25,
                ""percent"":66.24,
                ""averaging"":""24h""
             },
             {
                ""name"":""WHO"",
                ""pollutant"":""PM10"",
                ""limit"":50,
                ""percent"":61.93,
                ""averaging"":""24h""
             }
          ]
       },
       {
          ""fromDateTime"":""2020-06-20T01:00:00.000Z"",
          ""tillDateTime"":""2020-06-20T02:00:00.000Z"",
          ""values"":[
             {
                ""name"":""PM1"",
                ""value"":10.57
             },
             {
                ""name"":""PM25"",
                ""value"":15.83
             },
             {
                ""name"":""PM10"",
                ""value"":29.14
             },
             {
                ""name"":""PRESSURE"",
                ""value"":1011.51
             },
             {
                ""name"":""HUMIDITY"",
                ""value"":100
             },
             {
                ""name"":""TEMPERATURE"",
                ""value"":16.36
             }
          ],
          ""indexes"":[
             {
                ""name"":""AIRLY_CAQI"",
                ""value"":29.14,
                ""level"":""LOW"",
                ""description"":""Air is quite good."",
                ""advice"":""Enjoy the clean air."",
                ""color"":""#D1CF1E""
             }
          ],
          ""standards"":[
             {
                ""name"":""WHO"",
                ""pollutant"":""PM25"",
                ""limit"":25,
                ""percent"":63.32,
                ""averaging"":""24h""
             },
             {
                ""name"":""WHO"",
                ""pollutant"":""PM10"",
                ""limit"":50,
                ""percent"":58.27,
                ""averaging"":""24h""
             }
          ]
       },
       {
          ""fromDateTime"":""2020-06-20T02:00:00.000Z"",
          ""tillDateTime"":""2020-06-20T03:00:00.000Z"",
          ""values"":[
             {
                ""name"":""PM1"",
                ""value"":7.34
             },
             {
                ""name"":""PM25"",
                ""value"":10.84
             },
             {
                ""name"":""PM10"",
                ""value"":19.81
             },
             {
                ""name"":""PRESSURE"",
                ""value"":1011.48
             },
             {
                ""name"":""HUMIDITY"",
                ""value"":100
             },
             {
                ""name"":""TEMPERATURE"",
                ""value"":15.8
             }
          ],
          ""indexes"":[
             {
                ""name"":""AIRLY_CAQI"",
                ""value"":19.81,
                ""level"":""VERY_LOW"",
                ""description"":""Great air here today!"",
                ""advice"":""Dear me, how wonderful!"",
                ""color"":""#6BC926""
             }
          ],
          ""standards"":[
             {
                ""name"":""WHO"",
                ""pollutant"":""PM25"",
                ""limit"":25,
                ""percent"":43.36,
                ""averaging"":""24h""
             },
             {
                ""name"":""WHO"",
                ""pollutant"":""PM10"",
                ""limit"":50,
                ""percent"":39.61,
                ""averaging"":""24h""
             }
          ]
       },
       {
          ""fromDateTime"":""2020-06-20T03:00:00.000Z"",
          ""tillDateTime"":""2020-06-20T04:00:00.000Z"",
          ""values"":[
             {
                ""name"":""PM1"",
                ""value"":5.78
             },
             {
                ""name"":""PM25"",
                ""value"":8.18
             },
             {
                ""name"":""PM10"",
                ""value"":15.16
             },
             {
                ""name"":""PRESSURE"",
                ""value"":1011.61
             },
             {
                ""name"":""HUMIDITY"",
                ""value"":100
             },
             {
                ""name"":""TEMPERATURE"",
                ""value"":15.67
             }
          ],
          ""indexes"":[
             {
                ""name"":""AIRLY_CAQI"",
                ""value"":15.16,
                ""level"":""VERY_LOW"",
                ""description"":""Great air here today!"",
                ""advice"":""Breathe deeply!"",
                ""color"":""#6BC926""
             }
          ],
          ""standards"":[
             {
                ""name"":""WHO"",
                ""pollutant"":""PM25"",
                ""limit"":25,
                ""percent"":32.71,
                ""averaging"":""24h""
             },
             {
                ""name"":""WHO"",
                ""pollutant"":""PM10"",
                ""limit"":50,
                ""percent"":30.32,
                ""averaging"":""24h""
             }
          ]
       },
       {
          ""fromDateTime"":""2020-06-20T04:00:00.000Z"",
          ""tillDateTime"":""2020-06-20T05:00:00.000Z"",
          ""values"":[
             {
                ""name"":""PM1"",
                ""value"":5.41
             },
             {
                ""name"":""PM25"",
                ""value"":7.91
             },
             {
                ""name"":""PM10"",
                ""value"":14.59
             },
             {
                ""name"":""PRESSURE"",
                ""value"":1011.64
             },
             {
                ""name"":""HUMIDITY"",
                ""value"":100
             },
             {
                ""name"":""TEMPERATURE"",
                ""value"":15.9
             }
          ],
          ""indexes"":[
             {
                ""name"":""AIRLY_CAQI"",
                ""value"":14.59,
                ""level"":""VERY_LOW"",
                ""description"":""Great air here today!"",
                ""advice"":""Green equals clean!"",
                ""color"":""#6BC926""
             }
          ],
          ""standards"":[
             {
                ""name"":""WHO"",
                ""pollutant"":""PM25"",
                ""limit"":25,
                ""percent"":31.65,
                ""averaging"":""24h""
             },
             {
                ""name"":""WHO"",
                ""pollutant"":""PM10"",
                ""limit"":50,
                ""percent"":29.19,
                ""averaging"":""24h""
             }
          ]
       },
       {
          ""fromDateTime"":""2020-06-20T05:00:00.000Z"",
          ""tillDateTime"":""2020-06-20T06:00:00.000Z"",
          ""values"":[
             {
                ""name"":""PM1"",
                ""value"":3.88
             },
             {
                ""name"":""PM25"",
                ""value"":5.74
             },
             {
                ""name"":""PM10"",
                ""value"":10.81
             },
             {
                ""name"":""PRESSURE"",
                ""value"":1011.53
             },
             {
                ""name"":""HUMIDITY"",
                ""value"":98.96
             },
             {
                ""name"":""TEMPERATURE"",
                ""value"":16.22
             }
          ],
          ""indexes"":[
             {
                ""name"":""AIRLY_CAQI"",
                ""value"":10.81,
                ""level"":""VERY_LOW"",
                ""description"":""Great air here today!"",
                ""advice"":""Breathe deeply!"",
                ""color"":""#6BC926""
             }
          ],
          ""standards"":[
             {
                ""name"":""WHO"",
                ""pollutant"":""PM25"",
                ""limit"":25,
                ""percent"":22.97,
                ""averaging"":""24h""
             },
             {
                ""name"":""WHO"",
                ""pollutant"":""PM10"",
                ""limit"":50,
                ""percent"":21.62,
                ""averaging"":""24h""
             }
          ]
       },
       {
          ""fromDateTime"":""2020-06-20T06:00:00.000Z"",
          ""tillDateTime"":""2020-06-20T07:00:00.000Z"",
          ""values"":[
             {
                ""name"":""PM1"",
                ""value"":4.96
             },
             {
                ""name"":""PM25"",
                ""value"":7.08
             },
             {
                ""name"":""PM10"",
                ""value"":12.59
             },
             {
                ""name"":""PRESSURE"",
                ""value"":1011.47
             },
             {
                ""name"":""HUMIDITY"",
                ""value"":99.55
             },
             {
                ""name"":""TEMPERATURE"",
                ""value"":16.06
             }
          ],
          ""indexes"":[
             {
                ""name"":""AIRLY_CAQI"",
                ""value"":12.59,
                ""level"":""VERY_LOW"",
                ""description"":""Great air here today!"",
                ""advice"":""Breathe to fill your lungs!"",
                ""color"":""#6BC926""
             }
          ],
          ""standards"":[
             {
                ""name"":""WHO"",
                ""pollutant"":""PM25"",
                ""limit"":25,
                ""percent"":28.34,
                ""averaging"":""24h""
             },
             {
                ""name"":""WHO"",
                ""pollutant"":""PM10"",
                ""limit"":50,
                ""percent"":25.19,
                ""averaging"":""24h""
             }
          ]
       },
       {
          ""fromDateTime"":""2020-06-20T07:00:00.000Z"",
          ""tillDateTime"":""2020-06-20T08:00:00.000Z"",
          ""values"":[
             {
                ""name"":""PM1"",
                ""value"":3.93
             },
             {
                ""name"":""PM25"",
                ""value"":6.15
             },
             {
                ""name"":""PM10"",
                ""value"":11.25
             },
             {
                ""name"":""PRESSURE"",
                ""value"":1011.48
             },
             {
                ""name"":""HUMIDITY"",
                ""value"":99.48
             },
             {
                ""name"":""TEMPERATURE"",
                ""value"":16.4
             }
          ],
          ""indexes"":[
             {
                ""name"":""AIRLY_CAQI"",
                ""value"":11.25,
                ""level"":""VERY_LOW"",
                ""description"":""Great air here today!"",
                ""advice"":""Enjoy life!"",
                ""color"":""#6BC926""
             }
          ],
          ""standards"":[
             {
                ""name"":""WHO"",
                ""pollutant"":""PM25"",
                ""limit"":25,
                ""percent"":24.61,
                ""averaging"":""24h""
             },
             {
                ""name"":""WHO"",
                ""pollutant"":""PM10"",
                ""limit"":50,
                ""percent"":22.51,
                ""averaging"":""24h""
             }
          ]
       },
       {
          ""fromDateTime"":""2020-06-20T08:00:00.000Z"",
          ""tillDateTime"":""2020-06-20T09:00:00.000Z"",
          ""values"":[
             {
                ""name"":""PM1"",
                ""value"":4.21
             },
             {
                ""name"":""PM25"",
                ""value"":6.42
             },
             {
                ""name"":""PM10"",
                ""value"":11.79
             },
             {
                ""name"":""PRESSURE"",
                ""value"":1011.59
             },
             {
                ""name"":""HUMIDITY"",
                ""value"":98.21
             },
             {
                ""name"":""TEMPERATURE"",
                ""value"":17.06
             }
          ],
          ""indexes"":[
             {
                ""name"":""AIRLY_CAQI"",
                ""value"":11.79,
                ""level"":""VERY_LOW"",
                ""description"":""Great air here today!"",
                ""advice"":""Breathe deep! The air is clean!"",
                ""color"":""#6BC926""
             }
          ],
          ""standards"":[
             {
                ""name"":""WHO"",
                ""pollutant"":""PM25"",
                ""limit"":25,
                ""percent"":25.66,
                ""averaging"":""24h""
             },
             {
                ""name"":""WHO"",
                ""pollutant"":""PM10"",
                ""limit"":50,
                ""percent"":23.58,
                ""averaging"":""24h""
             }
          ]
       },
       {
          ""fromDateTime"":""2020-06-20T09:00:00.000Z"",
          ""tillDateTime"":""2020-06-20T10:00:00.000Z"",
          ""values"":[
             {
                ""name"":""PM1"",
                ""value"":4.98
             },
             {
                ""name"":""PM25"",
                ""value"":7.32
             },
             {
                ""name"":""PM10"",
                ""value"":13.25
             },
             {
                ""name"":""PRESSURE"",
                ""value"":1011.78
             },
             {
                ""name"":""HUMIDITY"",
                ""value"":96.73
             },
             {
                ""name"":""TEMPERATURE"",
                ""value"":17.62
             }
          ],
          ""indexes"":[
             {
                ""name"":""AIRLY_CAQI"",
                ""value"":13.25,
                ""level"":""VERY_LOW"",
                ""description"":""Great air here today!"",
                ""advice"":""Breathe to fill your lungs!"",
                ""color"":""#6BC926""
             }
          ],
          ""standards"":[
             {
                ""name"":""WHO"",
                ""pollutant"":""PM25"",
                ""limit"":25,
                ""percent"":29.27,
                ""averaging"":""24h""
             },
             {
                ""name"":""WHO"",
                ""pollutant"":""PM10"",
                ""limit"":50,
                ""percent"":26.49,
                ""averaging"":""24h""
             }
          ]
       },
       {
          ""fromDateTime"":""2020-06-20T10:00:00.000Z"",
          ""tillDateTime"":""2020-06-20T11:00:00.000Z"",
          ""values"":[
             {
                ""name"":""PM1"",
                ""value"":6.67
             },
             {
                ""name"":""PM25"",
                ""value"":9.56
             },
             {
                ""name"":""PM10"",
                ""value"":17.75
             },
             {
                ""name"":""PRESSURE"",
                ""value"":1011.75
             },
             {
                ""name"":""HUMIDITY"",
                ""value"":96.25
             },
             {
                ""name"":""TEMPERATURE"",
                ""value"":18
             }
          ],
          ""indexes"":[
             {
                ""name"":""AIRLY_CAQI"",
                ""value"":17.75,
                ""level"":""VERY_LOW"",
                ""description"":""Great air here today!"",
                ""advice"":""The air is grand today. ;)"",
                ""color"":""#6BC926""
             }
          ],
          ""standards"":[
             {
                ""name"":""WHO"",
                ""pollutant"":""PM25"",
                ""limit"":25,
                ""percent"":38.23,
                ""averaging"":""24h""
             },
             {
                ""name"":""WHO"",
                ""pollutant"":""PM10"",
                ""limit"":50,
                ""percent"":35.5,
                ""averaging"":""24h""
             }
          ]
       },
       {
          ""fromDateTime"":""2020-06-20T11:00:00.000Z"",
          ""tillDateTime"":""2020-06-20T12:00:00.000Z"",
          ""values"":[
             {
                ""name"":""PM1"",
                ""value"":8.04
             },
             {
                ""name"":""PM25"",
                ""value"":12.07
             },
             {
                ""name"":""PM10"",
                ""value"":22.01
             },
             {
                ""name"":""PRESSURE"",
                ""value"":1011.54
             },
             {
                ""name"":""HUMIDITY"",
                ""value"":95.74
             },
             {
                ""name"":""TEMPERATURE"",
                ""value"":18.65
             }
          ],
          ""indexes"":[
             {
                ""name"":""AIRLY_CAQI"",
                ""value"":22.01,
                ""level"":""VERY_LOW"",
                ""description"":""Great air here today!"",
                ""advice"":""It couldn't be better ;)"",
                ""color"":""#6BC926""
             }
          ],
          ""standards"":[
             {
                ""name"":""WHO"",
                ""pollutant"":""PM25"",
                ""limit"":25,
                ""percent"":48.29,
                ""averaging"":""24h""
             },
             {
                ""name"":""WHO"",
                ""pollutant"":""PM10"",
                ""limit"":50,
                ""percent"":44.02,
                ""averaging"":""24h""
             }
          ]
       },
       {
          ""fromDateTime"":""2020-06-20T12:00:00.000Z"",
          ""tillDateTime"":""2020-06-20T13:00:00.000Z"",
          ""values"":[
             {
                ""name"":""PM1"",
                ""value"":7.89
             },
             {
                ""name"":""PM25"",
                ""value"":11.38
             },
             {
                ""name"":""PM10"",
                ""value"":20.57
             },
             {
                ""name"":""PRESSURE"",
                ""value"":1011.44
             },
             {
                ""name"":""HUMIDITY"",
                ""value"":95.5
             },
             {
                ""name"":""TEMPERATURE"",
                ""value"":19.04
             }
          ],
          ""indexes"":[
             {
                ""name"":""AIRLY_CAQI"",
                ""value"":20.57,
                ""level"":""VERY_LOW"",
                ""description"":""Great air here today!"",
                ""advice"":""Dear me, how wonderful!"",
                ""color"":""#6BC926""
             }
          ],
          ""standards"":[
             {
                ""name"":""WHO"",
                ""pollutant"":""PM25"",
                ""limit"":25,
                ""percent"":45.51,
                ""averaging"":""24h""
             },
             {
                ""name"":""WHO"",
                ""pollutant"":""PM10"",
                ""limit"":50,
                ""percent"":41.14,
                ""averaging"":""24h""
             }
          ]
       }
    ],
    ""forecast"":[
       {
          ""fromDateTime"":""2020-06-20T13:00:00.000Z"",
          ""tillDateTime"":""2020-06-20T14:00:00.000Z"",
          ""values"":[
             {
                ""name"":""PM25"",
                ""value"":12.22
             },
             {
                ""name"":""PM10"",
                ""value"":19.2
             }
          ],
          ""indexes"":[
             {
                ""name"":""AIRLY_CAQI"",
                ""value"":20.37,
                ""level"":""VERY_LOW"",
                ""description"":""Great air here today!"",
                ""advice"":""Catch your breath!"",
                ""color"":""#6BC926""
             }
          ],
          ""standards"":[
             {
                ""name"":""WHO"",
                ""pollutant"":""PM25"",
                ""limit"":25,
                ""percent"":48.89,
                ""averaging"":""24h""
             },
             {
                ""name"":""WHO"",
                ""pollutant"":""PM10"",
                ""limit"":50,
                ""percent"":38.41,
                ""averaging"":""24h""
             }
          ]
       },
       {
          ""fromDateTime"":""2020-06-20T14:00:00.000Z"",
          ""tillDateTime"":""2020-06-20T15:00:00.000Z"",
          ""values"":[
             {
                ""name"":""PM25"",
                ""value"":11.88
             },
             {
                ""name"":""PM10"",
                ""value"":18.06
             }
          ],
          ""indexes"":[
             {
                ""name"":""AIRLY_CAQI"",
                ""value"":19.8,
                ""level"":""VERY_LOW"",
                ""description"":""Great air here today!"",
                ""advice"":""It couldn't be better ;)"",
                ""color"":""#6BC926""
             }
          ],
          ""standards"":[
             {
                ""name"":""WHO"",
                ""pollutant"":""PM25"",
                ""limit"":25,
                ""percent"":47.51,
                ""averaging"":""24h""
             },
             {
                ""name"":""WHO"",
                ""pollutant"":""PM10"",
                ""limit"":50,
                ""percent"":36.12,
                ""averaging"":""24h""
             }
          ]
       },
       {
          ""fromDateTime"":""2020-06-20T15:00:00.000Z"",
          ""tillDateTime"":""2020-06-20T16:00:00.000Z"",
          ""values"":[
             {
                ""name"":""PM25"",
                ""value"":11.67
             },
             {
                ""name"":""PM10"",
                ""value"":16.96
             }
          ],
          ""indexes"":[
             {
                ""name"":""AIRLY_CAQI"",
                ""value"":19.45,
                ""level"":""VERY_LOW"",
                ""description"":""Great air here today!"",
                ""advice"":""It couldn't be better ;)"",
                ""color"":""#6BC926""
             }
          ],
          ""standards"":[
             {
                ""name"":""WHO"",
                ""pollutant"":""PM25"",
                ""limit"":25,
                ""percent"":46.69,
                ""averaging"":""24h""
             },
             {
                ""name"":""WHO"",
                ""pollutant"":""PM10"",
                ""limit"":50,
                ""percent"":33.92,
                ""averaging"":""24h""
             }
          ]
       },
       {
          ""fromDateTime"":""2020-06-20T16:00:00.000Z"",
          ""tillDateTime"":""2020-06-20T17:00:00.000Z"",
          ""values"":[
             {
                ""name"":""PM25"",
                ""value"":11.14
             },
             {
                ""name"":""PM10"",
                ""value"":16.27
             }
          ],
          ""indexes"":[
             {
                ""name"":""AIRLY_CAQI"",
                ""value"":18.57,
                ""level"":""VERY_LOW"",
                ""description"":""Great air here today!"",
                ""advice"":""Breathe deeply!"",
                ""color"":""#6BC926""
             }
          ],
          ""standards"":[
             {
                ""name"":""WHO"",
                ""pollutant"":""PM25"",
                ""limit"":25,
                ""percent"":44.58,
                ""averaging"":""24h""
             },
             {
                ""name"":""WHO"",
                ""pollutant"":""PM10"",
                ""limit"":50,
                ""percent"":32.55,
                ""averaging"":""24h""
             }
          ]
       },
       {
          ""fromDateTime"":""2020-06-20T17:00:00.000Z"",
          ""tillDateTime"":""2020-06-20T18:00:00.000Z"",
          ""values"":[
             {
                ""name"":""PM25"",
                ""value"":10
             },
             {
                ""name"":""PM10"",
                ""value"":15.47
             }
          ],
          ""indexes"":[
             {
                ""name"":""AIRLY_CAQI"",
                ""value"":16.67,
                ""level"":""VERY_LOW"",
                ""description"":""Great air here today!"",
                ""advice"":""Zero dust - zero worries!"",
                ""color"":""#6BC926""
             }
          ],
          ""standards"":[
             {
                ""name"":""WHO"",
                ""pollutant"":""PM25"",
                ""limit"":25,
                ""percent"":40.01,
                ""averaging"":""24h""
             },
             {
                ""name"":""WHO"",
                ""pollutant"":""PM10"",
                ""limit"":50,
                ""percent"":30.94,
                ""averaging"":""24h""
             }
          ]
       },
       {
          ""fromDateTime"":""2020-06-20T18:00:00.000Z"",
          ""tillDateTime"":""2020-06-20T19:00:00.000Z"",
          ""values"":[
             {
                ""name"":""PM25"",
                ""value"":10.44
             },
             {
                ""name"":""PM10"",
                ""value"":15.02
             }
          ],
          ""indexes"":[
             {
                ""name"":""AIRLY_CAQI"",
                ""value"":17.4,
                ""level"":""VERY_LOW"",
                ""description"":""Great air here today!"",
                ""advice"":""Green equals clean!"",
                ""color"":""#6BC926""
             }
          ],
          ""standards"":[
             {
                ""name"":""WHO"",
                ""pollutant"":""PM25"",
                ""limit"":25,
                ""percent"":41.75,
                ""averaging"":""24h""
             },
             {
                ""name"":""WHO"",
                ""pollutant"":""PM10"",
                ""limit"":50,
                ""percent"":30.05,
                ""averaging"":""24h""
             }
          ]
       },
       {
          ""fromDateTime"":""2020-06-20T19:00:00.000Z"",
          ""tillDateTime"":""2020-06-20T20:00:00.000Z"",
          ""values"":[
             {
                ""name"":""PM25"",
                ""value"":10.38
             },
             {
                ""name"":""PM10"",
                ""value"":14.79
             }
          ],
          ""indexes"":[
             {
                ""name"":""AIRLY_CAQI"",
                ""value"":17.3,
                ""level"":""VERY_LOW"",
                ""description"":""Great air here today!"",
                ""advice"":""Great air!"",
                ""color"":""#6BC926""
             }
          ],
          ""standards"":[
             {
                ""name"":""WHO"",
                ""pollutant"":""PM25"",
                ""limit"":25,
                ""percent"":41.53,
                ""averaging"":""24h""
             },
             {
                ""name"":""WHO"",
                ""pollutant"":""PM10"",
                ""limit"":50,
                ""percent"":29.57,
                ""averaging"":""24h""
             }
          ]
       },
       {
          ""fromDateTime"":""2020-06-20T20:00:00.000Z"",
          ""tillDateTime"":""2020-06-20T21:00:00.000Z"",
          ""values"":[
             {
                ""name"":""PM25"",
                ""value"":9.52
             },
             {
                ""name"":""PM10"",
                ""value"":14.26
             }
          ],
          ""indexes"":[
             {
                ""name"":""AIRLY_CAQI"",
                ""value"":15.87,
                ""level"":""VERY_LOW"",
                ""description"":""Great air here today!"",
                ""advice"":""It couldn't be better ;)"",
                ""color"":""#6BC926""
             }
          ],
          ""standards"":[
             {
                ""name"":""WHO"",
                ""pollutant"":""PM25"",
                ""limit"":25,
                ""percent"":38.09,
                ""averaging"":""24h""
             },
             {
                ""name"":""WHO"",
                ""pollutant"":""PM10"",
                ""limit"":50,
                ""percent"":28.52,
                ""averaging"":""24h""
             }
          ]
       },
       {
          ""fromDateTime"":""2020-06-20T21:00:00.000Z"",
          ""tillDateTime"":""2020-06-20T22:00:00.000Z"",
          ""values"":[
             {
                ""name"":""PM25"",
                ""value"":9.08
             },
             {
                ""name"":""PM10"",
                ""value"":13.55
             }
          ],
          ""indexes"":[
             {
                ""name"":""AIRLY_CAQI"",
                ""value"":15.13,
                ""level"":""VERY_LOW"",
                ""description"":""Great air here today!"",
                ""advice"":""Breathe as much as you can!"",
                ""color"":""#6BC926""
             }
          ],
          ""standards"":[
             {
                ""name"":""WHO"",
                ""pollutant"":""PM25"",
                ""limit"":25,
                ""percent"":36.3,
                ""averaging"":""24h""
             },
             {
                ""name"":""WHO"",
                ""pollutant"":""PM10"",
                ""limit"":50,
                ""percent"":27.1,
                ""averaging"":""24h""
             }
          ]
       },
       {
          ""fromDateTime"":""2020-06-20T22:00:00.000Z"",
          ""tillDateTime"":""2020-06-20T23:00:00.000Z"",
          ""values"":[
             {
                ""name"":""PM25"",
                ""value"":9.08
             },
             {
                ""name"":""PM10"",
                ""value"":12.95
             }
          ],
          ""indexes"":[
             {
                ""name"":""AIRLY_CAQI"",
                ""value"":15.14,
                ""level"":""VERY_LOW"",
                ""description"":""Great air here today!"",
                ""advice"":""Enjoy life!"",
                ""color"":""#6BC926""
             }
          ],
          ""standards"":[
             {
                ""name"":""WHO"",
                ""pollutant"":""PM25"",
                ""limit"":25,
                ""percent"":36.33,
                ""averaging"":""24h""
             },
             {
                ""name"":""WHO"",
                ""pollutant"":""PM10"",
                ""limit"":50,
                ""percent"":25.9,
                ""averaging"":""24h""
             }
          ]
       },
       {
          ""fromDateTime"":""2020-06-20T23:00:00.000Z"",
          ""tillDateTime"":""2020-06-21T00:00:00.000Z"",
          ""values"":[
             {
                ""name"":""PM25"",
                ""value"":9
             },
             {
                ""name"":""PM10"",
                ""value"":12.55
             }
          ],
          ""indexes"":[
             {
                ""name"":""AIRLY_CAQI"",
                ""value"":15,
                ""level"":""VERY_LOW"",
                ""description"":""Great air here today!"",
                ""advice"":""The air is great!"",
                ""color"":""#6BC926""
             }
          ],
          ""standards"":[
             {
                ""name"":""WHO"",
                ""pollutant"":""PM25"",
                ""limit"":25,
                ""percent"":36.01,
                ""averaging"":""24h""
             },
             {
                ""name"":""WHO"",
                ""pollutant"":""PM10"",
                ""limit"":50,
                ""percent"":25.1,
                ""averaging"":""24h""
             }
          ]
       },
       {
          ""fromDateTime"":""2020-06-21T00:00:00.000Z"",
          ""tillDateTime"":""2020-06-21T01:00:00.000Z"",
          ""values"":[
             {
                ""name"":""PM25"",
                ""value"":8.86
             },
             {
                ""name"":""PM10"",
                ""value"":12.57
             }
          ],
          ""indexes"":[
             {
                ""name"":""AIRLY_CAQI"",
                ""value"":14.76,
                ""level"":""VERY_LOW"",
                ""description"":""Great air here today!"",
                ""advice"":""Catch your breath!"",
                ""color"":""#6BC926""
             }
          ],
          ""standards"":[
             {
                ""name"":""WHO"",
                ""pollutant"":""PM25"",
                ""limit"":25,
                ""percent"":35.42,
                ""averaging"":""24h""
             },
             {
                ""name"":""WHO"",
                ""pollutant"":""PM10"",
                ""limit"":50,
                ""percent"":25.15,
                ""averaging"":""24h""
             }
          ]
       },
       {
          ""fromDateTime"":""2020-06-21T01:00:00.000Z"",
          ""tillDateTime"":""2020-06-21T02:00:00.000Z"",
          ""values"":[
             {
                ""name"":""PM25"",
                ""value"":8.5
             },
             {
                ""name"":""PM10"",
                ""value"":12.07
             }
          ],
          ""indexes"":[
             {
                ""name"":""AIRLY_CAQI"",
                ""value"":14.17,
                ""level"":""VERY_LOW"",
                ""description"":""Great air here today!"",
                ""advice"":""Breathe to fill your lungs!"",
                ""color"":""#6BC926""
             }
          ],
          ""standards"":[
             {
                ""name"":""WHO"",
                ""pollutant"":""PM25"",
                ""limit"":25,
                ""percent"":34.01,
                ""averaging"":""24h""
             },
             {
                ""name"":""WHO"",
                ""pollutant"":""PM10"",
                ""limit"":50,
                ""percent"":24.14,
                ""averaging"":""24h""
             }
          ]
       },
       {
          ""fromDateTime"":""2020-06-21T02:00:00.000Z"",
          ""tillDateTime"":""2020-06-21T03:00:00.000Z"",
          ""values"":[
             {
                ""name"":""PM25"",
                ""value"":7.97
             },
             {
                ""name"":""PM10"",
                ""value"":11.35
             }
          ],
          ""indexes"":[
             {
                ""name"":""AIRLY_CAQI"",
                ""value"":13.28,
                ""level"":""VERY_LOW"",
                ""description"":""Great air here today!"",
                ""advice"":""Breathe to fill your lungs!"",
                ""color"":""#6BC926""
             }
          ],
          ""standards"":[
             {
                ""name"":""WHO"",
                ""pollutant"":""PM25"",
                ""limit"":25,
                ""percent"":31.88,
                ""averaging"":""24h""
             },
             {
                ""name"":""WHO"",
                ""pollutant"":""PM10"",
                ""limit"":50,
                ""percent"":22.7,
                ""averaging"":""24h""
             }
          ]
       },
       {
          ""fromDateTime"":""2020-06-21T03:00:00.000Z"",
          ""tillDateTime"":""2020-06-21T04:00:00.000Z"",
          ""values"":[
             {
                ""name"":""PM25"",
                ""value"":7.44
             },
             {
                ""name"":""PM10"",
                ""value"":10.49
             }
          ],
          ""indexes"":[
             {
                ""name"":""AIRLY_CAQI"",
                ""value"":12.4,
                ""level"":""VERY_LOW"",
                ""description"":""Great air here today!"",
                ""advice"":""Zero dust - zero worries!"",
                ""color"":""#6BC926""
             }
          ],
          ""standards"":[
             {
                ""name"":""WHO"",
                ""pollutant"":""PM25"",
                ""limit"":25,
                ""percent"":29.77,
                ""averaging"":""24h""
             },
             {
                ""name"":""WHO"",
                ""pollutant"":""PM10"",
                ""limit"":50,
                ""percent"":20.99,
                ""averaging"":""24h""
             }
          ]
       },
       {
          ""fromDateTime"":""2020-06-21T04:00:00.000Z"",
          ""tillDateTime"":""2020-06-21T05:00:00.000Z"",
          ""values"":[
             {
                ""name"":""PM25"",
                ""value"":7.63
             },
             {
                ""name"":""PM10"",
                ""value"":10.53
             }
          ],
          ""indexes"":[
             {
                ""name"":""AIRLY_CAQI"",
                ""value"":12.72,
                ""level"":""VERY_LOW"",
                ""description"":""Great air here today!"",
                ""advice"":""Breathe deep! The air is clean!"",
                ""color"":""#6BC926""
             }
          ],
          ""standards"":[
             {
                ""name"":""WHO"",
                ""pollutant"":""PM25"",
                ""limit"":25,
                ""percent"":30.52,
                ""averaging"":""24h""
             },
             {
                ""name"":""WHO"",
                ""pollutant"":""PM10"",
                ""limit"":50,
                ""percent"":21.06,
                ""averaging"":""24h""
             }
          ]
       },
       {
          ""fromDateTime"":""2020-06-21T05:00:00.000Z"",
          ""tillDateTime"":""2020-06-21T06:00:00.000Z"",
          ""values"":[
             {
                ""name"":""PM25"",
                ""value"":7.44
             },
             {
                ""name"":""PM10"",
                ""value"":11.1
             }
          ],
          ""indexes"":[
             {
                ""name"":""AIRLY_CAQI"",
                ""value"":12.41,
                ""level"":""VERY_LOW"",
                ""description"":""Great air here today!"",
                ""advice"":""Breathe to fill your lungs!"",
                ""color"":""#6BC926""
             }
          ],
          ""standards"":[
             {
                ""name"":""WHO"",
                ""pollutant"":""PM25"",
                ""limit"":25,
                ""percent"":29.77,
                ""averaging"":""24h""
             },
             {
                ""name"":""WHO"",
                ""pollutant"":""PM10"",
                ""limit"":50,
                ""percent"":22.2,
                ""averaging"":""24h""
             }
          ]
       },
       {
          ""fromDateTime"":""2020-06-21T06:00:00.000Z"",
          ""tillDateTime"":""2020-06-21T07:00:00.000Z"",
          ""values"":[
             {
                ""name"":""PM25"",
                ""value"":7.86
             },
             {
                ""name"":""PM10"",
                ""value"":11.37
             }
          ],
          ""indexes"":[
             {
                ""name"":""AIRLY_CAQI"",
                ""value"":13.1,
                ""level"":""VERY_LOW"",
                ""description"":""Great air here today!"",
                ""advice"":""Breathe deeply!"",
                ""color"":""#6BC926""
             }
          ],
          ""standards"":[
             {
                ""name"":""WHO"",
                ""pollutant"":""PM25"",
                ""limit"":25,
                ""percent"":31.44,
                ""averaging"":""24h""
             },
             {
                ""name"":""WHO"",
                ""pollutant"":""PM10"",
                ""limit"":50,
                ""percent"":22.75,
                ""averaging"":""24h""
             }
          ]
       },
       {
          ""fromDateTime"":""2020-06-21T07:00:00.000Z"",
          ""tillDateTime"":""2020-06-21T08:00:00.000Z"",
          ""values"":[
             {
                ""name"":""PM25"",
                ""value"":8.22
             },
             {
                ""name"":""PM10"",
                ""value"":11.9
             }
          ],
          ""indexes"":[
             {
                ""name"":""AIRLY_CAQI"",
                ""value"":13.7,
                ""level"":""VERY_LOW"",
                ""description"":""Great air here today!"",
                ""advice"":""Enjoy life!"",
                ""color"":""#6BC926""
             }
          ],
          ""standards"":[
             {
                ""name"":""WHO"",
                ""pollutant"":""PM25"",
                ""limit"":25,
                ""percent"":32.89,
                ""averaging"":""24h""
             },
             {
                ""name"":""WHO"",
                ""pollutant"":""PM10"",
                ""limit"":50,
                ""percent"":23.79,
                ""averaging"":""24h""
             }
          ]
       },
       {
          ""fromDateTime"":""2020-06-21T08:00:00.000Z"",
          ""tillDateTime"":""2020-06-21T09:00:00.000Z"",
          ""values"":[
             {
                ""name"":""PM25"",
                ""value"":8.51
             },
             {
                ""name"":""PM10"",
                ""value"":12.42
             }
          ],
          ""indexes"":[
             {
                ""name"":""AIRLY_CAQI"",
                ""value"":14.19,
                ""level"":""VERY_LOW"",
                ""description"":""Great air here today!"",
                ""advice"":""It couldn't be better ;)"",
                ""color"":""#6BC926""
             }
          ],
          ""standards"":[
             {
                ""name"":""WHO"",
                ""pollutant"":""PM25"",
                ""limit"":25,
                ""percent"":34.06,
                ""averaging"":""24h""
             },
             {
                ""name"":""WHO"",
                ""pollutant"":""PM10"",
                ""limit"":50,
                ""percent"":24.83,
                ""averaging"":""24h""
             }
          ]
       },
       {
          ""fromDateTime"":""2020-06-21T09:00:00.000Z"",
          ""tillDateTime"":""2020-06-21T10:00:00.000Z"",
          ""values"":[
             {
                ""name"":""PM25"",
                ""value"":9.03
             },
             {
                ""name"":""PM10"",
                ""value"":13.3
             }
          ],
          ""indexes"":[
             {
                ""name"":""AIRLY_CAQI"",
                ""value"":15.05,
                ""level"":""VERY_LOW"",
                ""description"":""Great air here today!"",
                ""advice"":""It couldn't be better ;)"",
                ""color"":""#6BC926""
             }
          ],
          ""standards"":[
             {
                ""name"":""WHO"",
                ""pollutant"":""PM25"",
                ""limit"":25,
                ""percent"":36.12,
                ""averaging"":""24h""
             },
             {
                ""name"":""WHO"",
                ""pollutant"":""PM10"",
                ""limit"":50,
                ""percent"":26.6,
                ""averaging"":""24h""
             }
          ]
       },
       {
          ""fromDateTime"":""2020-06-21T10:00:00.000Z"",
          ""tillDateTime"":""2020-06-21T11:00:00.000Z"",
          ""values"":[
             {
                ""name"":""PM25"",
                ""value"":9.21
             },
             {
                ""name"":""PM10"",
                ""value"":13.59
             }
          ],
          ""indexes"":[
             {
                ""name"":""AIRLY_CAQI"",
                ""value"":15.35,
                ""level"":""VERY_LOW"",
                ""description"":""Great air here today!"",
                ""advice"":""The air is great!"",
                ""color"":""#6BC926""
             }
          ],
          ""standards"":[
             {
                ""name"":""WHO"",
                ""pollutant"":""PM25"",
                ""limit"":25,
                ""percent"":36.83,
                ""averaging"":""24h""
             },
             {
                ""name"":""WHO"",
                ""pollutant"":""PM10"",
                ""limit"":50,
                ""percent"":27.17,
                ""averaging"":""24h""
             }
          ]
       },
       {
          ""fromDateTime"":""2020-06-21T11:00:00.000Z"",
          ""tillDateTime"":""2020-06-21T12:00:00.000Z"",
          ""values"":[
             {
                ""name"":""PM25"",
                ""value"":9.78
             },
             {
                ""name"":""PM10"",
                ""value"":13.91
             }
          ],
          ""indexes"":[
             {
                ""name"":""AIRLY_CAQI"",
                ""value"":16.3,
                ""level"":""VERY_LOW"",
                ""description"":""Great air here today!"",
                ""advice"":""The air is grand today. ;)"",
                ""color"":""#6BC926""
             }
          ],
          ""standards"":[
             {
                ""name"":""WHO"",
                ""pollutant"":""PM25"",
                ""limit"":25,
                ""percent"":39.11,
                ""averaging"":""24h""
             },
             {
                ""name"":""WHO"",
                ""pollutant"":""PM10"",
                ""limit"":50,
                ""percent"":27.82,
                ""averaging"":""24h""
             }
          ]
       },
       {
          ""fromDateTime"":""2020-06-21T12:00:00.000Z"",
          ""tillDateTime"":""2020-06-21T13:00:00.000Z"",
          ""values"":[
             {
                ""name"":""PM25"",
                ""value"":9.89
             },
             {
                ""name"":""PM10"",
                ""value"":14.19
             }
          ],
          ""indexes"":[
             {
                ""name"":""AIRLY_CAQI"",
                ""value"":16.48,
                ""level"":""VERY_LOW"",
                ""description"":""Great air here today!"",
                ""advice"":""The air is great!"",
                ""color"":""#6BC926""
             }
          ],
          ""standards"":[
             {
                ""name"":""WHO"",
                ""pollutant"":""PM25"",
                ""limit"":25,
                ""percent"":39.56,
                ""averaging"":""24h""
             },
             {
                ""name"":""WHO"",
                ""pollutant"":""PM10"",
                ""limit"":50,
                ""percent"":28.38,
                ""averaging"":""24h""
             }
          ]
       }
    ]
}
";
            }

            if (id == 10216)
            {
                return
@"
{
    ""current"": {
      ""fromDateTime"": ""2020-06-20T12:04:17.822Z"",
      ""tillDateTime"": ""2020-06-20T13:04:17.822Z"",
      ""values"": [
        {
          ""name"": ""PM1"",
          ""value"": 5.97
        },
        {
          ""name"": ""PM25"",
          ""value"": 9.92
        },
        {
          ""name"": ""PM10"",
          ""value"": 17.11
        },
        {
          ""name"": ""PRESSURE"",
          ""value"": 1011.51
        },
        {
          ""name"": ""HUMIDITY"",
          ""value"": 95.5
        },
        {
          ""name"": ""TEMPERATURE"",
          ""value"": 17.93
        }
      ],
      ""indexes"": [
        {
          ""name"": ""AIRLY_CAQI"",
          ""value"": 17.11,
          ""level"": ""VERY_LOW"",
          ""description"": ""Great air here today!"",
          ""advice"": ""It couldn't be better ;)"",
          ""color"": ""#6BC926""
        }
      ],
      ""standards"": [
        {
          ""name"": ""WHO"",
          ""pollutant"": ""PM25"",
          ""limit"": 25,
          ""percent"": 39.7,
          ""averaging"": ""24h""
        },
        {
          ""name"": ""WHO"",
          ""pollutant"": ""PM10"",
          ""limit"": 50,
          ""percent"": 34.21,
          ""averaging"": ""24h""
        }
      ]
    },
    ""history"": [
      {
        ""fromDateTime"": ""2020-06-19T13:00:00.000Z"",
        ""tillDateTime"": ""2020-06-19T14:00:00.000Z"",
        ""values"": [
          {
            ""name"": ""PM1"",
            ""value"": 7.41
          },
          {
            ""name"": ""PM25"",
            ""value"": 11.65
          },
          {
            ""name"": ""PM10"",
            ""value"": 21.19
          },
          {
            ""name"": ""PRESSURE"",
            ""value"": 1009.84
          },
          {
            ""name"": ""HUMIDITY"",
            ""value"": 73.23
          },
          {
            ""name"": ""TEMPERATURE"",
            ""value"": 19.34
          }
        ],
        ""indexes"": [
          {
            ""name"": ""AIRLY_CAQI"",
            ""value"": 21.19,
            ""level"": ""VERY_LOW"",
            ""description"": ""Great air here today!"",
            ""advice"": ""Enjoy life!"",
            ""color"": ""#6BC926""
          }
        ],
        ""standards"": [
          {
            ""name"": ""WHO"",
            ""pollutant"": ""PM25"",
            ""limit"": 25,
            ""percent"": 46.61,
            ""averaging"": ""24h""
          },
          {
            ""name"": ""WHO"",
            ""pollutant"": ""PM10"",
            ""limit"": 50,
            ""percent"": 42.38,
            ""averaging"": ""24h""
          }
        ]
      },
      {
        ""fromDateTime"": ""2020-06-19T14:00:00.000Z"",
        ""tillDateTime"": ""2020-06-19T15:00:00.000Z"",
        ""values"": [
          {
            ""name"": ""PM1"",
            ""value"": 4.73
          },
          {
            ""name"": ""PM25"",
            ""value"": 7.17
          },
          {
            ""name"": ""PM10"",
            ""value"": 12.84
          },
          {
            ""name"": ""PRESSURE"",
            ""value"": 1009.78
          },
          {
            ""name"": ""HUMIDITY"",
            ""value"": 79.86
          },
          {
            ""name"": ""TEMPERATURE"",
            ""value"": 18.65
          }
        ],
        ""indexes"": [
          {
            ""name"": ""AIRLY_CAQI"",
            ""value"": 12.84,
            ""level"": ""VERY_LOW"",
            ""description"": ""Great air here today!"",
            ""advice"": ""Perfect air for exercising! Go for it!"",
            ""color"": ""#6BC926""
          }
        ],
        ""standards"": [
          {
            ""name"": ""WHO"",
            ""pollutant"": ""PM25"",
            ""limit"": 25,
            ""percent"": 28.69,
            ""averaging"": ""24h""
          },
          {
            ""name"": ""WHO"",
            ""pollutant"": ""PM10"",
            ""limit"": 50,
            ""percent"": 25.68,
            ""averaging"": ""24h""
          }
        ]
      },
      {
        ""fromDateTime"": ""2020-06-19T15:00:00.000Z"",
        ""tillDateTime"": ""2020-06-19T16:00:00.000Z"",
        ""values"": [
          {
            ""name"": ""PM1"",
            ""value"": 7.6
          },
          {
            ""name"": ""PM25"",
            ""value"": 11.33
          },
          {
            ""name"": ""PM10"",
            ""value"": 20.16
          },
          {
            ""name"": ""PRESSURE"",
            ""value"": 1010.25
          },
          {
            ""name"": ""HUMIDITY"",
            ""value"": 85.28
          },
          {
            ""name"": ""TEMPERATURE"",
            ""value"": 18.17
          }
        ],
        ""indexes"": [
          {
            ""name"": ""AIRLY_CAQI"",
            ""value"": 20.16,
            ""level"": ""VERY_LOW"",
            ""description"": ""Great air here today!"",
            ""advice"": ""The air is great!"",
            ""color"": ""#6BC926""
          }
        ],
        ""standards"": [
          {
            ""name"": ""WHO"",
            ""pollutant"": ""PM25"",
            ""limit"": 25,
            ""percent"": 45.32,
            ""averaging"": ""24h""
          },
          {
            ""name"": ""WHO"",
            ""pollutant"": ""PM10"",
            ""limit"": 50,
            ""percent"": 40.32,
            ""averaging"": ""24h""
          }
        ]
      },
      {
        ""fromDateTime"": ""2020-06-19T16:00:00.000Z"",
        ""tillDateTime"": ""2020-06-19T17:00:00.000Z"",
        ""values"": [
          {
            ""name"": ""PM1"",
            ""value"": 7.86
          },
          {
            ""name"": ""PM25"",
            ""value"": 12.13
          },
          {
            ""name"": ""PM10"",
            ""value"": 21.19
          },
          {
            ""name"": ""PRESSURE"",
            ""value"": 1010.67
          },
          {
            ""name"": ""HUMIDITY"",
            ""value"": 94.91
          },
          {
            ""name"": ""TEMPERATURE"",
            ""value"": 17.63
          }
        ],
        ""indexes"": [
          {
            ""name"": ""AIRLY_CAQI"",
            ""value"": 21.19,
            ""level"": ""VERY_LOW"",
            ""description"": ""Great air here today!"",
            ""advice"": ""Dear me, how wonderful!"",
            ""color"": ""#6BC926""
          }
        ],
        ""standards"": [
          {
            ""name"": ""WHO"",
            ""pollutant"": ""PM25"",
            ""limit"": 25,
            ""percent"": 48.53,
            ""averaging"": ""24h""
          },
          {
            ""name"": ""WHO"",
            ""pollutant"": ""PM10"",
            ""limit"": 50,
            ""percent"": 42.38,
            ""averaging"": ""24h""
          }
        ]
      },
      {
        ""fromDateTime"": ""2020-06-19T17:00:00.000Z"",
        ""tillDateTime"": ""2020-06-19T18:00:00.000Z"",
        ""values"": [
          {
            ""name"": ""PM1"",
            ""value"": 9.31
          },
          {
            ""name"": ""PM25"",
            ""value"": 14.88
          },
          {
            ""name"": ""PM10"",
            ""value"": 26.67
          },
          {
            ""name"": ""PRESSURE"",
            ""value"": 1011.2
          },
          {
            ""name"": ""HUMIDITY"",
            ""value"": 96.78
          },
          {
            ""name"": ""TEMPERATURE"",
            ""value"": 16.83
          }
        ],
        ""indexes"": [
          {
            ""name"": ""AIRLY_CAQI"",
            ""value"": 26.67,
            ""level"": ""LOW"",
            ""description"": ""Air is quite good."",
            ""advice"": ""Don't miss this day! The clean air calls!"",
            ""color"": ""#D1CF1E""
          }
        ],
        ""standards"": [
          {
            ""name"": ""WHO"",
            ""pollutant"": ""PM25"",
            ""limit"": 25,
            ""percent"": 59.52,
            ""averaging"": ""24h""
          },
          {
            ""name"": ""WHO"",
            ""pollutant"": ""PM10"",
            ""limit"": 50,
            ""percent"": 53.33,
            ""averaging"": ""24h""
          }
        ]
      },
      {
        ""fromDateTime"": ""2020-06-19T18:00:00.000Z"",
        ""tillDateTime"": ""2020-06-19T19:00:00.000Z"",
        ""values"": [
          {
            ""name"": ""PM1"",
            ""value"": 12.25
          },
          {
            ""name"": ""PM25"",
            ""value"": 21.28
          },
          {
            ""name"": ""PM10"",
            ""value"": 41.44
          },
          {
            ""name"": ""PRESSURE"",
            ""value"": 1011.6
          },
          {
            ""name"": ""HUMIDITY"",
            ""value"": 92.55
          },
          {
            ""name"": ""TEMPERATURE"",
            ""value"": 16.67
          }
        ],
        ""indexes"": [
          {
            ""name"": ""AIRLY_CAQI"",
            ""value"": 41.44,
            ""level"": ""LOW"",
            ""description"": ""Air is quite good."",
            ""advice"": ""Don't miss this day! The clean air calls!"",
            ""color"": ""#D1CF1E""
          }
        ],
        ""standards"": [
          {
            ""name"": ""WHO"",
            ""pollutant"": ""PM25"",
            ""limit"": 25,
            ""percent"": 85.11,
            ""averaging"": ""24h""
          },
          {
            ""name"": ""WHO"",
            ""pollutant"": ""PM10"",
            ""limit"": 50,
            ""percent"": 82.88,
            ""averaging"": ""24h""
          }
        ]
      },
      {
        ""fromDateTime"": ""2020-06-19T19:00:00.000Z"",
        ""tillDateTime"": ""2020-06-19T20:00:00.000Z"",
        ""values"": [
          {
            ""name"": ""PM1"",
            ""value"": 13.46
          },
          {
            ""name"": ""PM25"",
            ""value"": 24.57
          },
          {
            ""name"": ""PM10"",
            ""value"": 47.53
          },
          {
            ""name"": ""PRESSURE"",
            ""value"": 1012.06
          },
          {
            ""name"": ""HUMIDITY"",
            ""value"": 91.82
          },
          {
            ""name"": ""TEMPERATURE"",
            ""value"": 16.37
          }
        ],
        ""indexes"": [
          {
            ""name"": ""AIRLY_CAQI"",
            ""value"": 47.53,
            ""level"": ""LOW"",
            ""description"": ""Air is quite good."",
            ""advice"": ""Take a deep breath. Today, you can. ;)"",
            ""color"": ""#D1CF1E""
          }
        ],
        ""standards"": [
          {
            ""name"": ""WHO"",
            ""pollutant"": ""PM25"",
            ""limit"": 25,
            ""percent"": 98.27,
            ""averaging"": ""24h""
          },
          {
            ""name"": ""WHO"",
            ""pollutant"": ""PM10"",
            ""limit"": 50,
            ""percent"": 95.06,
            ""averaging"": ""24h""
          }
        ]
      },
      {
        ""fromDateTime"": ""2020-06-19T20:00:00.000Z"",
        ""tillDateTime"": ""2020-06-19T21:00:00.000Z"",
        ""values"": [
          {
            ""name"": ""PM1"",
            ""value"": 12.74
          },
          {
            ""name"": ""PM25"",
            ""value"": 22.84
          },
          {
            ""name"": ""PM10"",
            ""value"": 44.64
          },
          {
            ""name"": ""PRESSURE"",
            ""value"": 1012.17
          },
          {
            ""name"": ""HUMIDITY"",
            ""value"": 96.08
          },
          {
            ""name"": ""TEMPERATURE"",
            ""value"": 15.77
          }
        ],
        ""indexes"": [
          {
            ""name"": ""AIRLY_CAQI"",
            ""value"": 44.64,
            ""level"": ""LOW"",
            ""description"": ""Air is quite good."",
            ""advice"": ""Enjoy the clean air."",
            ""color"": ""#D1CF1E""
          }
        ],
        ""standards"": [
          {
            ""name"": ""WHO"",
            ""pollutant"": ""PM25"",
            ""limit"": 25,
            ""percent"": 91.37,
            ""averaging"": ""24h""
          },
          {
            ""name"": ""WHO"",
            ""pollutant"": ""PM10"",
            ""limit"": 50,
            ""percent"": 89.29,
            ""averaging"": ""24h""
          }
        ]
      },
      {
        ""fromDateTime"": ""2020-06-19T21:00:00.000Z"",
        ""tillDateTime"": ""2020-06-19T22:00:00.000Z"",
        ""values"": [
          {
            ""name"": ""PM1"",
            ""value"": 13.93
          },
          {
            ""name"": ""PM25"",
            ""value"": 25.29
          },
          {
            ""name"": ""PM10"",
            ""value"": 48.54
          },
          {
            ""name"": ""PRESSURE"",
            ""value"": 1012.15
          },
          {
            ""name"": ""HUMIDITY"",
            ""value"": 98.68
          },
          {
            ""name"": ""TEMPERATURE"",
            ""value"": 15.51
          }
        ],
        ""indexes"": [
          {
            ""name"": ""AIRLY_CAQI"",
            ""value"": 48.54,
            ""level"": ""LOW"",
            ""description"": ""Air is quite good."",
            ""advice"": ""The air is nice and clean today!"",
            ""color"": ""#D1CF1E""
          }
        ],
        ""standards"": [
          {
            ""name"": ""WHO"",
            ""pollutant"": ""PM25"",
            ""limit"": 25,
            ""percent"": 101.17,
            ""averaging"": ""24h""
          },
          {
            ""name"": ""WHO"",
            ""pollutant"": ""PM10"",
            ""limit"": 50,
            ""percent"": 97.09,
            ""averaging"": ""24h""
          }
        ]
      },
      {
        ""fromDateTime"": ""2020-06-19T22:00:00.000Z"",
        ""tillDateTime"": ""2020-06-19T23:00:00.000Z"",
        ""values"": [
          {
            ""name"": ""PM1"",
            ""value"": 12.86
          },
          {
            ""name"": ""PM25"",
            ""value"": 23.37
          },
          {
            ""name"": ""PM10"",
            ""value"": 46.18
          },
          {
            ""name"": ""PRESSURE"",
            ""value"": 1011.99
          },
          {
            ""name"": ""HUMIDITY"",
            ""value"": 98.74
          },
          {
            ""name"": ""TEMPERATURE"",
            ""value"": 15.35
          }
        ],
        ""indexes"": [
          {
            ""name"": ""AIRLY_CAQI"",
            ""value"": 46.18,
            ""level"": ""LOW"",
            ""description"": ""Air is quite good."",
            ""advice"": ""Enjoy the clean air."",
            ""color"": ""#D1CF1E""
          }
        ],
        ""standards"": [
          {
            ""name"": ""WHO"",
            ""pollutant"": ""PM25"",
            ""limit"": 25,
            ""percent"": 93.49,
            ""averaging"": ""24h""
          },
          {
            ""name"": ""WHO"",
            ""pollutant"": ""PM10"",
            ""limit"": 50,
            ""percent"": 92.36,
            ""averaging"": ""24h""
          }
        ]
      },
      {
        ""fromDateTime"": ""2020-06-19T23:00:00.000Z"",
        ""tillDateTime"": ""2020-06-20T00:00:00.000Z"",
        ""values"": [
          {
            ""name"": ""PM1"",
            ""value"": 11.06
          },
          {
            ""name"": ""PM25"",
            ""value"": 19.95
          },
          {
            ""name"": ""PM10"",
            ""value"": 38.89
          },
          {
            ""name"": ""PRESSURE"",
            ""value"": 1012.04
          },
          {
            ""name"": ""HUMIDITY"",
            ""value"": 98.93
          },
          {
            ""name"": ""TEMPERATURE"",
            ""value"": 15.15
          }
        ],
        ""indexes"": [
          {
            ""name"": ""AIRLY_CAQI"",
            ""value"": 38.89,
            ""level"": ""LOW"",
            ""description"": ""Air is quite good."",
            ""advice"": ""Yes, yes - it's true. The air quality is good today!"",
            ""color"": ""#D1CF1E""
          }
        ],
        ""standards"": [
          {
            ""name"": ""WHO"",
            ""pollutant"": ""PM25"",
            ""limit"": 25,
            ""percent"": 79.79,
            ""averaging"": ""24h""
          },
          {
            ""name"": ""WHO"",
            ""pollutant"": ""PM10"",
            ""limit"": 50,
            ""percent"": 77.77,
            ""averaging"": ""24h""
          }
        ]
      },
      {
        ""fromDateTime"": ""2020-06-20T00:00:00.000Z"",
        ""tillDateTime"": ""2020-06-20T01:00:00.000Z"",
        ""values"": [
          {
            ""name"": ""PM1"",
            ""value"": 11.08
          },
          {
            ""name"": ""PM25"",
            ""value"": 19.48
          },
          {
            ""name"": ""PM10"",
            ""value"": 38.98
          },
          {
            ""name"": ""PRESSURE"",
            ""value"": 1011.93
          },
          {
            ""name"": ""HUMIDITY"",
            ""value"": 99.27
          },
          {
            ""name"": ""TEMPERATURE"",
            ""value"": 14.99
          }
        ],
        ""indexes"": [
          {
            ""name"": ""AIRLY_CAQI"",
            ""value"": 38.98,
            ""level"": ""LOW"",
            ""description"": ""Air is quite good."",
            ""advice"": ""Enjoy the clean air."",
            ""color"": ""#D1CF1E""
          }
        ],
        ""standards"": [
          {
            ""name"": ""WHO"",
            ""pollutant"": ""PM25"",
            ""limit"": 25,
            ""percent"": 77.9,
            ""averaging"": ""24h""
          },
          {
            ""name"": ""WHO"",
            ""pollutant"": ""PM10"",
            ""limit"": 50,
            ""percent"": 77.95,
            ""averaging"": ""24h""
          }
        ]
      },
      {
        ""fromDateTime"": ""2020-06-20T01:00:00.000Z"",
        ""tillDateTime"": ""2020-06-20T02:00:00.000Z"",
        ""values"": [
          {
            ""name"": ""PM1"",
            ""value"": 9.9
          },
          {
            ""name"": ""PM25"",
            ""value"": 18.54
          },
          {
            ""name"": ""PM10"",
            ""value"": 36.65
          },
          {
            ""name"": ""PRESSURE"",
            ""value"": 1011.76
          },
          {
            ""name"": ""HUMIDITY"",
            ""value"": 99.5
          },
          {
            ""name"": ""TEMPERATURE"",
            ""value"": 14.7
          }
        ],
        ""indexes"": [
          {
            ""name"": ""AIRLY_CAQI"",
            ""value"": 36.65,
            ""level"": ""LOW"",
            ""description"": ""Air is quite good."",
            ""advice"": ""Enjoy the clean air."",
            ""color"": ""#D1CF1E""
          }
        ],
        ""standards"": [
          {
            ""name"": ""WHO"",
            ""pollutant"": ""PM25"",
            ""limit"": 25,
            ""percent"": 74.17,
            ""averaging"": ""24h""
          },
          {
            ""name"": ""WHO"",
            ""pollutant"": ""PM10"",
            ""limit"": 50,
            ""percent"": 73.3,
            ""averaging"": ""24h""
          }
        ]
      },
      {
        ""fromDateTime"": ""2020-06-20T02:00:00.000Z"",
        ""tillDateTime"": ""2020-06-20T03:00:00.000Z"",
        ""values"": [
          {
            ""name"": ""PM1"",
            ""value"": 6.34
          },
          {
            ""name"": ""PM25"",
            ""value"": 12.3
          },
          {
            ""name"": ""PM10"",
            ""value"": 23.52
          },
          {
            ""name"": ""PRESSURE"",
            ""value"": 1011.86
          },
          {
            ""name"": ""HUMIDITY"",
            ""value"": 99.57
          },
          {
            ""name"": ""TEMPERATURE"",
            ""value"": 14.42
          }
        ],
        ""indexes"": [
          {
            ""name"": ""AIRLY_CAQI"",
            ""value"": 23.52,
            ""level"": ""VERY_LOW"",
            ""description"": ""Great air here today!"",
            ""advice"": ""Breathe deep! The air is clean!"",
            ""color"": ""#6BC926""
          }
        ],
        ""standards"": [
          {
            ""name"": ""WHO"",
            ""pollutant"": ""PM25"",
            ""limit"": 25,
            ""percent"": 49.22,
            ""averaging"": ""24h""
          },
          {
            ""name"": ""WHO"",
            ""pollutant"": ""PM10"",
            ""limit"": 50,
            ""percent"": 47.05,
            ""averaging"": ""24h""
          }
        ]
      },
      {
        ""fromDateTime"": ""2020-06-20T03:00:00.000Z"",
        ""tillDateTime"": ""2020-06-20T04:00:00.000Z"",
        ""values"": [
          {
            ""name"": ""PM1"",
            ""value"": 5.53
          },
          {
            ""name"": ""PM25"",
            ""value"": 10.46
          },
          {
            ""name"": ""PM10"",
            ""value"": 19.63
          },
          {
            ""name"": ""PRESSURE"",
            ""value"": 1012.01
          },
          {
            ""name"": ""HUMIDITY"",
            ""value"": 99.61
          },
          {
            ""name"": ""TEMPERATURE"",
            ""value"": 14.34
          }
        ],
        ""indexes"": [
          {
            ""name"": ""AIRLY_CAQI"",
            ""value"": 19.63,
            ""level"": ""VERY_LOW"",
            ""description"": ""Great air here today!"",
            ""advice"": ""Perfect air for exercising! Go for it!"",
            ""color"": ""#6BC926""
          }
        ],
        ""standards"": [
          {
            ""name"": ""WHO"",
            ""pollutant"": ""PM25"",
            ""limit"": 25,
            ""percent"": 41.83,
            ""averaging"": ""24h""
          },
          {
            ""name"": ""WHO"",
            ""pollutant"": ""PM10"",
            ""limit"": 50,
            ""percent"": 39.27,
            ""averaging"": ""24h""
          }
        ]
      },
      {
        ""fromDateTime"": ""2020-06-20T04:00:00.000Z"",
        ""tillDateTime"": ""2020-06-20T05:00:00.000Z"",
        ""values"": [
          {
            ""name"": ""PM1"",
            ""value"": 5.74
          },
          {
            ""name"": ""PM25"",
            ""value"": 10.05
          },
          {
            ""name"": ""PM10"",
            ""value"": 19.87
          },
          {
            ""name"": ""PRESSURE"",
            ""value"": 1012.1
          },
          {
            ""name"": ""HUMIDITY"",
            ""value"": 99.21
          },
          {
            ""name"": ""TEMPERATURE"",
            ""value"": 14.55
          }
        ],
        ""indexes"": [
          {
            ""name"": ""AIRLY_CAQI"",
            ""value"": 19.87,
            ""level"": ""VERY_LOW"",
            ""description"": ""Great air here today!"",
            ""advice"": ""Green, green, green!"",
            ""color"": ""#6BC926""
          }
        ],
        ""standards"": [
          {
            ""name"": ""WHO"",
            ""pollutant"": ""PM25"",
            ""limit"": 25,
            ""percent"": 40.21,
            ""averaging"": ""24h""
          },
          {
            ""name"": ""WHO"",
            ""pollutant"": ""PM10"",
            ""limit"": 50,
            ""percent"": 39.75,
            ""averaging"": ""24h""
          }
        ]
      },
      {
        ""fromDateTime"": ""2020-06-20T05:00:00.000Z"",
        ""tillDateTime"": ""2020-06-20T06:00:00.000Z"",
        ""values"": [
          {
            ""name"": ""PM1"",
            ""value"": 5.11
          },
          {
            ""name"": ""PM25"",
            ""value"": 8.41
          },
          {
            ""name"": ""PM10"",
            ""value"": 15.31
          },
          {
            ""name"": ""PRESSURE"",
            ""value"": 1011.91
          },
          {
            ""name"": ""HUMIDITY"",
            ""value"": 97.83
          },
          {
            ""name"": ""TEMPERATURE"",
            ""value"": 14.87
          }
        ],
        ""indexes"": [
          {
            ""name"": ""AIRLY_CAQI"",
            ""value"": 15.31,
            ""level"": ""VERY_LOW"",
            ""description"": ""Great air here today!"",
            ""advice"": ""Enjoy life!"",
            ""color"": ""#6BC926""
          }
        ],
        ""standards"": [
          {
            ""name"": ""WHO"",
            ""pollutant"": ""PM25"",
            ""limit"": 25,
            ""percent"": 33.65,
            ""averaging"": ""24h""
          },
          {
            ""name"": ""WHO"",
            ""pollutant"": ""PM10"",
            ""limit"": 50,
            ""percent"": 30.62,
            ""averaging"": ""24h""
          }
        ]
      },
      {
        ""fromDateTime"": ""2020-06-20T06:00:00.000Z"",
        ""tillDateTime"": ""2020-06-20T07:00:00.000Z"",
        ""values"": [
          {
            ""name"": ""PM1"",
            ""value"": 5.39
          },
          {
            ""name"": ""PM25"",
            ""value"": 8.95
          },
          {
            ""name"": ""PM10"",
            ""value"": 16.14
          },
          {
            ""name"": ""PRESSURE"",
            ""value"": 1011.79
          },
          {
            ""name"": ""HUMIDITY"",
            ""value"": 99.04
          },
          {
            ""name"": ""TEMPERATURE"",
            ""value"": 14.75
          }
        ],
        ""indexes"": [
          {
            ""name"": ""AIRLY_CAQI"",
            ""value"": 16.14,
            ""level"": ""VERY_LOW"",
            ""description"": ""Great air here today!"",
            ""advice"": ""Breathe as much as you can!"",
            ""color"": ""#6BC926""
          }
        ],
        ""standards"": [
          {
            ""name"": ""WHO"",
            ""pollutant"": ""PM25"",
            ""limit"": 25,
            ""percent"": 35.79,
            ""averaging"": ""24h""
          },
          {
            ""name"": ""WHO"",
            ""pollutant"": ""PM10"",
            ""limit"": 50,
            ""percent"": 32.29,
            ""averaging"": ""24h""
          }
        ]
      },
      {
        ""fromDateTime"": ""2020-06-20T07:00:00.000Z"",
        ""tillDateTime"": ""2020-06-20T08:00:00.000Z"",
        ""values"": [
          {
            ""name"": ""PM1"",
            ""value"": 4.48
          },
          {
            ""name"": ""PM25"",
            ""value"": 7.44
          },
          {
            ""name"": ""PM10"",
            ""value"": 12.41
          },
          {
            ""name"": ""PRESSURE"",
            ""value"": 1011.77
          },
          {
            ""name"": ""HUMIDITY"",
            ""value"": 99.5
          },
          {
            ""name"": ""TEMPERATURE"",
            ""value"": 15.12
          }
        ],
        ""indexes"": [
          {
            ""name"": ""AIRLY_CAQI"",
            ""value"": 12.41,
            ""level"": ""VERY_LOW"",
            ""description"": ""Great air here today!"",
            ""advice"": ""The air is grand today. ;)"",
            ""color"": ""#6BC926""
          }
        ],
        ""standards"": [
          {
            ""name"": ""WHO"",
            ""pollutant"": ""PM25"",
            ""limit"": 25,
            ""percent"": 29.74,
            ""averaging"": ""24h""
          },
          {
            ""name"": ""WHO"",
            ""pollutant"": ""PM10"",
            ""limit"": 50,
            ""percent"": 24.82,
            ""averaging"": ""24h""
          }
        ]
      },
      {
        ""fromDateTime"": ""2020-06-20T08:00:00.000Z"",
        ""tillDateTime"": ""2020-06-20T09:00:00.000Z"",
        ""values"": [
          {
            ""name"": ""PM1"",
            ""value"": 4.53
          },
          {
            ""name"": ""PM25"",
            ""value"": 7.5
          },
          {
            ""name"": ""PM10"",
            ""value"": 13.82
          },
          {
            ""name"": ""PRESSURE"",
            ""value"": 1011.76
          },
          {
            ""name"": ""HUMIDITY"",
            ""value"": 98.25
          },
          {
            ""name"": ""TEMPERATURE"",
            ""value"": 15.81
          }
        ],
        ""indexes"": [
          {
            ""name"": ""AIRLY_CAQI"",
            ""value"": 13.82,
            ""level"": ""VERY_LOW"",
            ""description"": ""Great air here today!"",
            ""advice"": ""It couldn't be better ;)"",
            ""color"": ""#6BC926""
          }
        ],
        ""standards"": [
          {
            ""name"": ""WHO"",
            ""pollutant"": ""PM25"",
            ""limit"": 25,
            ""percent"": 29.99,
            ""averaging"": ""24h""
          },
          {
            ""name"": ""WHO"",
            ""pollutant"": ""PM10"",
            ""limit"": 50,
            ""percent"": 27.64,
            ""averaging"": ""24h""
          }
        ]
      },
      {
        ""fromDateTime"": ""2020-06-20T09:00:00.000Z"",
        ""tillDateTime"": ""2020-06-20T10:00:00.000Z"",
        ""values"": [
          {
            ""name"": ""PM1"",
            ""value"": 4.73
          },
          {
            ""name"": ""PM25"",
            ""value"": 7.75
          },
          {
            ""name"": ""PM10"",
            ""value"": 14.54
          },
          {
            ""name"": ""PRESSURE"",
            ""value"": 1011.94
          },
          {
            ""name"": ""HUMIDITY"",
            ""value"": 96.7
          },
          {
            ""name"": ""TEMPERATURE"",
            ""value"": 16.36
          }
        ],
        ""indexes"": [
          {
            ""name"": ""AIRLY_CAQI"",
            ""value"": 14.54,
            ""level"": ""VERY_LOW"",
            ""description"": ""Great air here today!"",
            ""advice"": ""Great air!"",
            ""color"": ""#6BC926""
          }
        ],
        ""standards"": [
          {
            ""name"": ""WHO"",
            ""pollutant"": ""PM25"",
            ""limit"": 25,
            ""percent"": 31.01,
            ""averaging"": ""24h""
          },
          {
            ""name"": ""WHO"",
            ""pollutant"": ""PM10"",
            ""limit"": 50,
            ""percent"": 29.08,
            ""averaging"": ""24h""
          }
        ]
      },
      {
        ""fromDateTime"": ""2020-06-20T10:00:00.000Z"",
        ""tillDateTime"": ""2020-06-20T11:00:00.000Z"",
        ""values"": [
          {
            ""name"": ""PM1"",
            ""value"": 5.61
          },
          {
            ""name"": ""PM25"",
            ""value"": 9.71
          },
          {
            ""name"": ""PM10"",
            ""value"": 17.46
          },
          {
            ""name"": ""PRESSURE"",
            ""value"": 1011.99
          },
          {
            ""name"": ""HUMIDITY"",
            ""value"": 95.59
          },
          {
            ""name"": ""TEMPERATURE"",
            ""value"": 16.7
          }
        ],
        ""indexes"": [
          {
            ""name"": ""AIRLY_CAQI"",
            ""value"": 17.46,
            ""level"": ""VERY_LOW"",
            ""description"": ""Great air here today!"",
            ""advice"": ""Breathe deep! The air is clean!"",
            ""color"": ""#6BC926""
          }
        ],
        ""standards"": [
          {
            ""name"": ""WHO"",
            ""pollutant"": ""PM25"",
            ""limit"": 25,
            ""percent"": 38.86,
            ""averaging"": ""24h""
          },
          {
            ""name"": ""WHO"",
            ""pollutant"": ""PM10"",
            ""limit"": 50,
            ""percent"": 34.93,
            ""averaging"": ""24h""
          }
        ]
      },
      {
        ""fromDateTime"": ""2020-06-20T11:00:00.000Z"",
        ""tillDateTime"": ""2020-06-20T12:00:00.000Z"",
        ""values"": [
          {
            ""name"": ""PM1"",
            ""value"": 6.61
          },
          {
            ""name"": ""PM25"",
            ""value"": 11.15
          },
          {
            ""name"": ""PM10"",
            ""value"": 20.51
          },
          {
            ""name"": ""PRESSURE"",
            ""value"": 1011.67
          },
          {
            ""name"": ""HUMIDITY"",
            ""value"": 95.39
          },
          {
            ""name"": ""TEMPERATURE"",
            ""value"": 17.41
          }
        ],
        ""indexes"": [
          {
            ""name"": ""AIRLY_CAQI"",
            ""value"": 20.51,
            ""level"": ""VERY_LOW"",
            ""description"": ""Great air here today!"",
            ""advice"": ""Green, green, green!"",
            ""color"": ""#6BC926""
          }
        ],
        ""standards"": [
          {
            ""name"": ""WHO"",
            ""pollutant"": ""PM25"",
            ""limit"": 25,
            ""percent"": 44.6,
            ""averaging"": ""24h""
          },
          {
            ""name"": ""WHO"",
            ""pollutant"": ""PM10"",
            ""limit"": 50,
            ""percent"": 41.02,
            ""averaging"": ""24h""
          }
        ]
      },
      {
        ""fromDateTime"": ""2020-06-20T12:00:00.000Z"",
        ""tillDateTime"": ""2020-06-20T13:00:00.000Z"",
        ""values"": [
          {
            ""name"": ""PM1"",
            ""value"": 5.97
          },
          {
            ""name"": ""PM25"",
            ""value"": 9.92
          },
          {
            ""name"": ""PM10"",
            ""value"": 17.11
          },
          {
            ""name"": ""PRESSURE"",
            ""value"": 1011.51
          },
          {
            ""name"": ""HUMIDITY"",
            ""value"": 95.5
          },
          {
            ""name"": ""TEMPERATURE"",
            ""value"": 17.93
          }
        ],
        ""indexes"": [
          {
            ""name"": ""AIRLY_CAQI"",
            ""value"": 17.11,
            ""level"": ""VERY_LOW"",
            ""description"": ""Great air here today!"",
            ""advice"": ""Green, green, green!"",
            ""color"": ""#6BC926""
          }
        ],
        ""standards"": [
          {
            ""name"": ""WHO"",
            ""pollutant"": ""PM25"",
            ""limit"": 25,
            ""percent"": 39.7,
            ""averaging"": ""24h""
          },
          {
            ""name"": ""WHO"",
            ""pollutant"": ""PM10"",
            ""limit"": 50,
            ""percent"": 34.21,
            ""averaging"": ""24h""
          }
        ]
      }
    ],
    ""forecast"": [
      {
        ""fromDateTime"": ""2020-06-20T13:00:00.000Z"",
        ""tillDateTime"": ""2020-06-20T14:00:00.000Z"",
        ""values"": [
          {
            ""name"": ""PM25"",
            ""value"": 11.15
          },
          {
            ""name"": ""PM10"",
            ""value"": 16.56
          }
        ],
        ""indexes"": [
          {
            ""name"": ""AIRLY_CAQI"",
            ""value"": 18.58,
            ""level"": ""VERY_LOW"",
            ""description"": ""Great air here today!"",
            ""advice"": ""Green, green, green!"",
            ""color"": ""#6BC926""
          }
        ],
        ""standards"": [
          {
            ""name"": ""WHO"",
            ""pollutant"": ""PM25"",
            ""limit"": 25,
            ""percent"": 44.59,
            ""averaging"": ""24h""
          },
          {
            ""name"": ""WHO"",
            ""pollutant"": ""PM10"",
            ""limit"": 50,
            ""percent"": 33.11,
            ""averaging"": ""24h""
          }
        ]
      },
      {
        ""fromDateTime"": ""2020-06-20T14:00:00.000Z"",
        ""tillDateTime"": ""2020-06-20T15:00:00.000Z"",
        ""values"": [
          {
            ""name"": ""PM25"",
            ""value"": 10.63
          },
          {
            ""name"": ""PM10"",
            ""value"": 15.7
          }
        ],
        ""indexes"": [
          {
            ""name"": ""AIRLY_CAQI"",
            ""value"": 17.72,
            ""level"": ""VERY_LOW"",
            ""description"": ""Great air here today!"",
            ""advice"": ""Green equals clean!"",
            ""color"": ""#6BC926""
          }
        ],
        ""standards"": [
          {
            ""name"": ""WHO"",
            ""pollutant"": ""PM25"",
            ""limit"": 25,
            ""percent"": 42.52,
            ""averaging"": ""24h""
          },
          {
            ""name"": ""WHO"",
            ""pollutant"": ""PM10"",
            ""limit"": 50,
            ""percent"": 31.41,
            ""averaging"": ""24h""
          }
        ]
      },
      {
        ""fromDateTime"": ""2020-06-20T15:00:00.000Z"",
        ""tillDateTime"": ""2020-06-20T16:00:00.000Z"",
        ""values"": [
          {
            ""name"": ""PM25"",
            ""value"": 10.5
          },
          {
            ""name"": ""PM10"",
            ""value"": 15.31
          }
        ],
        ""indexes"": [
          {
            ""name"": ""AIRLY_CAQI"",
            ""value"": 17.51,
            ""level"": ""VERY_LOW"",
            ""description"": ""Great air here today!"",
            ""advice"": ""Breathe as much as you can!"",
            ""color"": ""#6BC926""
          }
        ],
        ""standards"": [
          {
            ""name"": ""WHO"",
            ""pollutant"": ""PM25"",
            ""limit"": 25,
            ""percent"": 42.02,
            ""averaging"": ""24h""
          },
          {
            ""name"": ""WHO"",
            ""pollutant"": ""PM10"",
            ""limit"": 50,
            ""percent"": 30.62,
            ""averaging"": ""24h""
          }
        ]
      },
      {
        ""fromDateTime"": ""2020-06-20T16:00:00.000Z"",
        ""tillDateTime"": ""2020-06-20T17:00:00.000Z"",
        ""values"": [
          {
            ""name"": ""PM25"",
            ""value"": 10.68
          },
          {
            ""name"": ""PM10"",
            ""value"": 15.91
          }
        ],
        ""indexes"": [
          {
            ""name"": ""AIRLY_CAQI"",
            ""value"": 17.8,
            ""level"": ""VERY_LOW"",
            ""description"": ""Great air here today!"",
            ""advice"": ""Breathe to fill your lungs!"",
            ""color"": ""#6BC926""
          }
        ],
        ""standards"": [
          {
            ""name"": ""WHO"",
            ""pollutant"": ""PM25"",
            ""limit"": 25,
            ""percent"": 42.73,
            ""averaging"": ""24h""
          },
          {
            ""name"": ""WHO"",
            ""pollutant"": ""PM10"",
            ""limit"": 50,
            ""percent"": 31.82,
            ""averaging"": ""24h""
          }
        ]
      },
      {
        ""fromDateTime"": ""2020-06-20T17:00:00.000Z"",
        ""tillDateTime"": ""2020-06-20T18:00:00.000Z"",
        ""values"": [
          {
            ""name"": ""PM25"",
            ""value"": 11.05
          },
          {
            ""name"": ""PM10"",
            ""value"": 16.57
          }
        ],
        ""indexes"": [
          {
            ""name"": ""AIRLY_CAQI"",
            ""value"": 18.41,
            ""level"": ""VERY_LOW"",
            ""description"": ""Great air here today!"",
            ""advice"": ""Dear me, how wonderful!"",
            ""color"": ""#6BC926""
          }
        ],
        ""standards"": [
          {
            ""name"": ""WHO"",
            ""pollutant"": ""PM25"",
            ""limit"": 25,
            ""percent"": 44.19,
            ""averaging"": ""24h""
          },
          {
            ""name"": ""WHO"",
            ""pollutant"": ""PM10"",
            ""limit"": 50,
            ""percent"": 33.14,
            ""averaging"": ""24h""
          }
        ]
      },
      {
        ""fromDateTime"": ""2020-06-20T18:00:00.000Z"",
        ""tillDateTime"": ""2020-06-20T19:00:00.000Z"",
        ""values"": [
          {
            ""name"": ""PM25"",
            ""value"": 12.01
          },
          {
            ""name"": ""PM10"",
            ""value"": 18.16
          }
        ],
        ""indexes"": [
          {
            ""name"": ""AIRLY_CAQI"",
            ""value"": 20.01,
            ""level"": ""VERY_LOW"",
            ""description"": ""Great air here today!"",
            ""advice"": ""Breathe deep! The air is clean!"",
            ""color"": ""#6BC926""
          }
        ],
        ""standards"": [
          {
            ""name"": ""WHO"",
            ""pollutant"": ""PM25"",
            ""limit"": 25,
            ""percent"": 48.02,
            ""averaging"": ""24h""
          },
          {
            ""name"": ""WHO"",
            ""pollutant"": ""PM10"",
            ""limit"": 50,
            ""percent"": 36.32,
            ""averaging"": ""24h""
          }
        ]
      },
      {
        ""fromDateTime"": ""2020-06-20T19:00:00.000Z"",
        ""tillDateTime"": ""2020-06-20T20:00:00.000Z"",
        ""values"": [
          {
            ""name"": ""PM25"",
            ""value"": 13.42
          },
          {
            ""name"": ""PM10"",
            ""value"": 19.41
          }
        ],
        ""indexes"": [
          {
            ""name"": ""AIRLY_CAQI"",
            ""value"": 22.37,
            ""level"": ""VERY_LOW"",
            ""description"": ""Great air here today!"",
            ""advice"": ""Green equals clean!"",
            ""color"": ""#6BC926""
          }
        ],
        ""standards"": [
          {
            ""name"": ""WHO"",
            ""pollutant"": ""PM25"",
            ""limit"": 25,
            ""percent"": 53.7,
            ""averaging"": ""24h""
          },
          {
            ""name"": ""WHO"",
            ""pollutant"": ""PM10"",
            ""limit"": 50,
            ""percent"": 38.82,
            ""averaging"": ""24h""
          }
        ]
      },
      {
        ""fromDateTime"": ""2020-06-20T20:00:00.000Z"",
        ""tillDateTime"": ""2020-06-20T21:00:00.000Z"",
        ""values"": [
          {
            ""name"": ""PM25"",
            ""value"": 13.29
          },
          {
            ""name"": ""PM10"",
            ""value"": 19.76
          }
        ],
        ""indexes"": [
          {
            ""name"": ""AIRLY_CAQI"",
            ""value"": 22.15,
            ""level"": ""VERY_LOW"",
            ""description"": ""Great air here today!"",
            ""advice"": ""Green equals clean!"",
            ""color"": ""#6BC926""
          }
        ],
        ""standards"": [
          {
            ""name"": ""WHO"",
            ""pollutant"": ""PM25"",
            ""limit"": 25,
            ""percent"": 53.16,
            ""averaging"": ""24h""
          },
          {
            ""name"": ""WHO"",
            ""pollutant"": ""PM10"",
            ""limit"": 50,
            ""percent"": 39.51,
            ""averaging"": ""24h""
          }
        ]
      },
      {
        ""fromDateTime"": ""2020-06-20T21:00:00.000Z"",
        ""tillDateTime"": ""2020-06-20T22:00:00.000Z"",
        ""values"": [
          {
            ""name"": ""PM25"",
            ""value"": 12.47
          },
          {
            ""name"": ""PM10"",
            ""value"": 18.73
          }
        ],
        ""indexes"": [
          {
            ""name"": ""AIRLY_CAQI"",
            ""value"": 20.79,
            ""level"": ""VERY_LOW"",
            ""description"": ""Great air here today!"",
            ""advice"": ""The air is grand today. ;)"",
            ""color"": ""#6BC926""
          }
        ],
        ""standards"": [
          {
            ""name"": ""WHO"",
            ""pollutant"": ""PM25"",
            ""limit"": 25,
            ""percent"": 49.9,
            ""averaging"": ""24h""
          },
          {
            ""name"": ""WHO"",
            ""pollutant"": ""PM10"",
            ""limit"": 50,
            ""percent"": 37.46,
            ""averaging"": ""24h""
          }
        ]
      },
      {
        ""fromDateTime"": ""2020-06-20T22:00:00.000Z"",
        ""tillDateTime"": ""2020-06-20T23:00:00.000Z"",
        ""values"": [
          {
            ""name"": ""PM25"",
            ""value"": 11.23
          },
          {
            ""name"": ""PM10"",
            ""value"": 16.94
          }
        ],
        ""indexes"": [
          {
            ""name"": ""AIRLY_CAQI"",
            ""value"": 18.72,
            ""level"": ""VERY_LOW"",
            ""description"": ""Great air here today!"",
            ""advice"": ""Breathe deep! The air is clean!"",
            ""color"": ""#6BC926""
          }
        ],
        ""standards"": [
          {
            ""name"": ""WHO"",
            ""pollutant"": ""PM25"",
            ""limit"": 25,
            ""percent"": 44.93,
            ""averaging"": ""24h""
          },
          {
            ""name"": ""WHO"",
            ""pollutant"": ""PM10"",
            ""limit"": 50,
            ""percent"": 33.89,
            ""averaging"": ""24h""
          }
        ]
      },
      {
        ""fromDateTime"": ""2020-06-20T23:00:00.000Z"",
        ""tillDateTime"": ""2020-06-21T00:00:00.000Z"",
        ""values"": [
          {
            ""name"": ""PM25"",
            ""value"": 10.46
          },
          {
            ""name"": ""PM10"",
            ""value"": 15.5
          }
        ],
        ""indexes"": [
          {
            ""name"": ""AIRLY_CAQI"",
            ""value"": 17.44,
            ""level"": ""VERY_LOW"",
            ""description"": ""Great air here today!"",
            ""advice"": ""Dear me, how wonderful!"",
            ""color"": ""#6BC926""
          }
        ],
        ""standards"": [
          {
            ""name"": ""WHO"",
            ""pollutant"": ""PM25"",
            ""limit"": 25,
            ""percent"": 41.86,
            ""averaging"": ""24h""
          },
          {
            ""name"": ""WHO"",
            ""pollutant"": ""PM10"",
            ""limit"": 50,
            ""percent"": 31,
            ""averaging"": ""24h""
          }
        ]
      },
      {
        ""fromDateTime"": ""2020-06-21T00:00:00.000Z"",
        ""tillDateTime"": ""2020-06-21T01:00:00.000Z"",
        ""values"": [
          {
            ""name"": ""PM25"",
            ""value"": 10.19
          },
          {
            ""name"": ""PM10"",
            ""value"": 15.05
          }
        ],
        ""indexes"": [
          {
            ""name"": ""AIRLY_CAQI"",
            ""value"": 16.99,
            ""level"": ""VERY_LOW"",
            ""description"": ""Great air here today!"",
            ""advice"": ""Breathe to fill your lungs!"",
            ""color"": ""#6BC926""
          }
        ],
        ""standards"": [
          {
            ""name"": ""WHO"",
            ""pollutant"": ""PM25"",
            ""limit"": 25,
            ""percent"": 40.78,
            ""averaging"": ""24h""
          },
          {
            ""name"": ""WHO"",
            ""pollutant"": ""PM10"",
            ""limit"": 50,
            ""percent"": 30.1,
            ""averaging"": ""24h""
          }
        ]
      },
      {
        ""fromDateTime"": ""2020-06-21T01:00:00.000Z"",
        ""tillDateTime"": ""2020-06-21T02:00:00.000Z"",
        ""values"": [
          {
            ""name"": ""PM25"",
            ""value"": 9.77
          },
          {
            ""name"": ""PM10"",
            ""value"": 14.82
          }
        ],
        ""indexes"": [
          {
            ""name"": ""AIRLY_CAQI"",
            ""value"": 16.29,
            ""level"": ""VERY_LOW"",
            ""description"": ""Great air here today!"",
            ""advice"": ""It couldn't be better ;)"",
            ""color"": ""#6BC926""
          }
        ],
        ""standards"": [
          {
            ""name"": ""WHO"",
            ""pollutant"": ""PM25"",
            ""limit"": 25,
            ""percent"": 39.1,
            ""averaging"": ""24h""
          },
          {
            ""name"": ""WHO"",
            ""pollutant"": ""PM10"",
            ""limit"": 50,
            ""percent"": 29.63,
            ""averaging"": ""24h""
          }
        ]
      },
      {
        ""fromDateTime"": ""2020-06-21T02:00:00.000Z"",
        ""tillDateTime"": ""2020-06-21T03:00:00.000Z"",
        ""values"": [
          {
            ""name"": ""PM25"",
            ""value"": 10.04
          },
          {
            ""name"": ""PM10"",
            ""value"": 14.73
          }
        ],
        ""indexes"": [
          {
            ""name"": ""AIRLY_CAQI"",
            ""value"": 16.74,
            ""level"": ""VERY_LOW"",
            ""description"": ""Great air here today!"",
            ""advice"": ""Catch your breath!"",
            ""color"": ""#6BC926""
          }
        ],
        ""standards"": [
          {
            ""name"": ""WHO"",
            ""pollutant"": ""PM25"",
            ""limit"": 25,
            ""percent"": 40.17,
            ""averaging"": ""24h""
          },
          {
            ""name"": ""WHO"",
            ""pollutant"": ""PM10"",
            ""limit"": 50,
            ""percent"": 29.46,
            ""averaging"": ""24h""
          }
        ]
      },
      {
        ""fromDateTime"": ""2020-06-21T03:00:00.000Z"",
        ""tillDateTime"": ""2020-06-21T04:00:00.000Z"",
        ""values"": [
          {
            ""name"": ""PM25"",
            ""value"": 9.63
          },
          {
            ""name"": ""PM10"",
            ""value"": 14.66
          }
        ],
        ""indexes"": [
          {
            ""name"": ""AIRLY_CAQI"",
            ""value"": 16.04,
            ""level"": ""VERY_LOW"",
            ""description"": ""Great air here today!"",
            ""advice"": ""It couldn't be better ;)"",
            ""color"": ""#6BC926""
          }
        ],
        ""standards"": [
          {
            ""name"": ""WHO"",
            ""pollutant"": ""PM25"",
            ""limit"": 25,
            ""percent"": 38.51,
            ""averaging"": ""24h""
          },
          {
            ""name"": ""WHO"",
            ""pollutant"": ""PM10"",
            ""limit"": 50,
            ""percent"": 29.32,
            ""averaging"": ""24h""
          }
        ]
      },
      {
        ""fromDateTime"": ""2020-06-21T04:00:00.000Z"",
        ""tillDateTime"": ""2020-06-21T05:00:00.000Z"",
        ""values"": [
          {
            ""name"": ""PM25"",
            ""value"": 10.35
          },
          {
            ""name"": ""PM10"",
            ""value"": 14.87
          }
        ],
        ""indexes"": [
          {
            ""name"": ""AIRLY_CAQI"",
            ""value"": 17.24,
            ""level"": ""VERY_LOW"",
            ""description"": ""Great air here today!"",
            ""advice"": ""Breathe as much as you can!"",
            ""color"": ""#6BC926""
          }
        ],
        ""standards"": [
          {
            ""name"": ""WHO"",
            ""pollutant"": ""PM25"",
            ""limit"": 25,
            ""percent"": 41.38,
            ""averaging"": ""24h""
          },
          {
            ""name"": ""WHO"",
            ""pollutant"": ""PM10"",
            ""limit"": 50,
            ""percent"": 29.74,
            ""averaging"": ""24h""
          }
        ]
      },
      {
        ""fromDateTime"": ""2020-06-21T05:00:00.000Z"",
        ""tillDateTime"": ""2020-06-21T06:00:00.000Z"",
        ""values"": [
          {
            ""name"": ""PM25"",
            ""value"": 10.11
          },
          {
            ""name"": ""PM10"",
            ""value"": 14.65
          }
        ],
        ""indexes"": [
          {
            ""name"": ""AIRLY_CAQI"",
            ""value"": 16.85,
            ""level"": ""VERY_LOW"",
            ""description"": ""Great air here today!"",
            ""advice"": ""Green, green, green!"",
            ""color"": ""#6BC926""
          }
        ],
        ""standards"": [
          {
            ""name"": ""WHO"",
            ""pollutant"": ""PM25"",
            ""limit"": 25,
            ""percent"": 40.43,
            ""averaging"": ""24h""
          },
          {
            ""name"": ""WHO"",
            ""pollutant"": ""PM10"",
            ""limit"": 50,
            ""percent"": 29.3,
            ""averaging"": ""24h""
          }
        ]
      },
      {
        ""fromDateTime"": ""2020-06-21T06:00:00.000Z"",
        ""tillDateTime"": ""2020-06-21T07:00:00.000Z"",
        ""values"": [
          {
            ""name"": ""PM25"",
            ""value"": 9.26
          },
          {
            ""name"": ""PM10"",
            ""value"": 14.2
          }
        ],
        ""indexes"": [
          {
            ""name"": ""AIRLY_CAQI"",
            ""value"": 15.43,
            ""level"": ""VERY_LOW"",
            ""description"": ""Great air here today!"",
            ""advice"": ""Perfect air for exercising! Go for it!"",
            ""color"": ""#6BC926""
          }
        ],
        ""standards"": [
          {
            ""name"": ""WHO"",
            ""pollutant"": ""PM25"",
            ""limit"": 25,
            ""percent"": 37.02,
            ""averaging"": ""24h""
          },
          {
            ""name"": ""WHO"",
            ""pollutant"": ""PM10"",
            ""limit"": 50,
            ""percent"": 28.39,
            ""averaging"": ""24h""
          }
        ]
      },
      {
        ""fromDateTime"": ""2020-06-21T07:00:00.000Z"",
        ""tillDateTime"": ""2020-06-21T08:00:00.000Z"",
        ""values"": [
          {
            ""name"": ""PM25"",
            ""value"": 9.99
          },
          {
            ""name"": ""PM10"",
            ""value"": 14.3
          }
        ],
        ""indexes"": [
          {
            ""name"": ""AIRLY_CAQI"",
            ""value"": 16.65,
            ""level"": ""VERY_LOW"",
            ""description"": ""Great air here today!"",
            ""advice"": ""Zero dust - zero worries!"",
            ""color"": ""#6BC926""
          }
        ],
        ""standards"": [
          {
            ""name"": ""WHO"",
            ""pollutant"": ""PM25"",
            ""limit"": 25,
            ""percent"": 39.95,
            ""averaging"": ""24h""
          },
          {
            ""name"": ""WHO"",
            ""pollutant"": ""PM10"",
            ""limit"": 50,
            ""percent"": 28.61,
            ""averaging"": ""24h""
          }
        ]
      },
      {
        ""fromDateTime"": ""2020-06-21T08:00:00.000Z"",
        ""tillDateTime"": ""2020-06-21T09:00:00.000Z"",
        ""values"": [
          {
            ""name"": ""PM25"",
            ""value"": 9.55
          },
          {
            ""name"": ""PM10"",
            ""value"": 14.48
          }
        ],
        ""indexes"": [
          {
            ""name"": ""AIRLY_CAQI"",
            ""value"": 15.92,
            ""level"": ""VERY_LOW"",
            ""description"": ""Great air here today!"",
            ""advice"": ""It couldn't be better ;)"",
            ""color"": ""#6BC926""
          }
        ],
        ""standards"": [
          {
            ""name"": ""WHO"",
            ""pollutant"": ""PM25"",
            ""limit"": 25,
            ""percent"": 38.2,
            ""averaging"": ""24h""
          },
          {
            ""name"": ""WHO"",
            ""pollutant"": ""PM10"",
            ""limit"": 50,
            ""percent"": 28.95,
            ""averaging"": ""24h""
          }
        ]
      },
      {
        ""fromDateTime"": ""2020-06-21T09:00:00.000Z"",
        ""tillDateTime"": ""2020-06-21T10:00:00.000Z"",
        ""values"": [
          {
            ""name"": ""PM25"",
            ""value"": 10.21
          },
          {
            ""name"": ""PM10"",
            ""value"": 14.75
          }
        ],
        ""indexes"": [
          {
            ""name"": ""AIRLY_CAQI"",
            ""value"": 17.02,
            ""level"": ""VERY_LOW"",
            ""description"": ""Great air here today!"",
            ""advice"": ""The air is grand today. ;)"",
            ""color"": ""#6BC926""
          }
        ],
        ""standards"": [
          {
            ""name"": ""WHO"",
            ""pollutant"": ""PM25"",
            ""limit"": 25,
            ""percent"": 40.84,
            ""averaging"": ""24h""
          },
          {
            ""name"": ""WHO"",
            ""pollutant"": ""PM10"",
            ""limit"": 50,
            ""percent"": 29.49,
            ""averaging"": ""24h""
          }
        ]
      },
      {
        ""fromDateTime"": ""2020-06-21T10:00:00.000Z"",
        ""tillDateTime"": ""2020-06-21T11:00:00.000Z"",
        ""values"": [
          {
            ""name"": ""PM25"",
            ""value"": 10.09
          },
          {
            ""name"": ""PM10"",
            ""value"": 14.8
          }
        ],
        ""indexes"": [
          {
            ""name"": ""AIRLY_CAQI"",
            ""value"": 16.82,
            ""level"": ""VERY_LOW"",
            ""description"": ""Great air here today!"",
            ""advice"": ""Perfect air for exercising! Go for it!"",
            ""color"": ""#6BC926""
          }
        ],
        ""standards"": [
          {
            ""name"": ""WHO"",
            ""pollutant"": ""PM25"",
            ""limit"": 25,
            ""percent"": 40.38,
            ""averaging"": ""24h""
          },
          {
            ""name"": ""WHO"",
            ""pollutant"": ""PM10"",
            ""limit"": 50,
            ""percent"": 29.6,
            ""averaging"": ""24h""
          }
        ]
      },
      {
        ""fromDateTime"": ""2020-06-21T11:00:00.000Z"",
        ""tillDateTime"": ""2020-06-21T12:00:00.000Z"",
        ""values"": [
          {
            ""name"": ""PM25"",
            ""value"": 9.66
          },
          {
            ""name"": ""PM10"",
            ""value"": 14.65
          }
        ],
        ""indexes"": [
          {
            ""name"": ""AIRLY_CAQI"",
            ""value"": 16.1,
            ""level"": ""VERY_LOW"",
            ""description"": ""Great air here today!"",
            ""advice"": ""Green, green, green!"",
            ""color"": ""#6BC926""
          }
        ],
        ""standards"": [
          {
            ""name"": ""WHO"",
            ""pollutant"": ""PM25"",
            ""limit"": 25,
            ""percent"": 38.65,
            ""averaging"": ""24h""
          },
          {
            ""name"": ""WHO"",
            ""pollutant"": ""PM10"",
            ""limit"": 50,
            ""percent"": 29.3,
            ""averaging"": ""24h""
          }
        ]
      },
      {
        ""fromDateTime"": ""2020-06-21T12:00:00.000Z"",
        ""tillDateTime"": ""2020-06-21T13:00:00.000Z"",
        ""values"": [
          {
            ""name"": ""PM25"",
            ""value"": 9.79
          },
          {
            ""name"": ""PM10"",
            ""value"": 14.37
          }
        ],
        ""indexes"": [
          {
            ""name"": ""AIRLY_CAQI"",
            ""value"": 16.32,
            ""level"": ""VERY_LOW"",
            ""description"": ""Great air here today!"",
            ""advice"": ""It couldn't be better ;)"",
            ""color"": ""#6BC926""
          }
        ],
        ""standards"": [
          {
            ""name"": ""WHO"",
            ""pollutant"": ""PM25"",
            ""limit"": 25,
            ""percent"": 39.17,
            ""averaging"": ""24h""
          },
          {
            ""name"": ""WHO"",
            ""pollutant"": ""PM10"",
            ""limit"": 50,
            ""percent"": 28.73,
            ""averaging"": ""24h""
          }
        ]
      }
    ]
}
";
            }

            if (id == 10213)
            {
                return
@"
{
    ""current"": {
      ""fromDateTime"": ""2020-06-20T12:05:52.965Z"",
      ""tillDateTime"": ""2020-06-20T13:05:52.965Z"",
      ""values"": [
        {
          ""name"": ""PM1"",
          ""value"": 5.4
        },
        {
          ""name"": ""PM25"",
          ""value"": 10.04
        },
        {
          ""name"": ""PM10"",
          ""value"": 17.22
        },
        {
          ""name"": ""PRESSURE"",
          ""value"": 1012.81
        },
        {
          ""name"": ""HUMIDITY"",
          ""value"": 95.5
        },
        {
          ""name"": ""TEMPERATURE"",
          ""value"": 18.23
        }
      ],
      ""indexes"": [
        {
          ""name"": ""AIRLY_CAQI"",
          ""value"": 17.22,
          ""level"": ""VERY_LOW"",
          ""description"": ""Great air here today!"",
          ""advice"": ""Catch your breath!"",
          ""color"": ""#6BC926""
        }
      ],
      ""standards"": [
        {
          ""name"": ""WHO"",
          ""pollutant"": ""PM25"",
          ""limit"": 25,
          ""percent"": 40.15,
          ""averaging"": ""24h""
        },
        {
          ""name"": ""WHO"",
          ""pollutant"": ""PM10"",
          ""limit"": 50,
          ""percent"": 34.44,
          ""averaging"": ""24h""
        }
      ]
    },
    ""history"": [
      {
        ""fromDateTime"": ""2020-06-19T13:00:00.000Z"",
        ""tillDateTime"": ""2020-06-19T14:00:00.000Z"",
        ""values"": [
          {
            ""name"": ""PM1"",
            ""value"": 5.12
          },
          {
            ""name"": ""PM25"",
            ""value"": 8.59
          },
          {
            ""name"": ""PM10"",
            ""value"": 16.36
          },
          {
            ""name"": ""PRESSURE"",
            ""value"": 1011.05
          },
          {
            ""name"": ""HUMIDITY"",
            ""value"": 89.75
          },
          {
            ""name"": ""TEMPERATURE"",
            ""value"": 19.96
          }
        ],
        ""indexes"": [
          {
            ""name"": ""AIRLY_CAQI"",
            ""value"": 16.36,
            ""level"": ""VERY_LOW"",
            ""description"": ""Great air here today!"",
            ""advice"": ""Breathe deeply!"",
            ""color"": ""#6BC926""
          }
        ],
        ""standards"": [
          {
            ""name"": ""WHO"",
            ""pollutant"": ""PM25"",
            ""limit"": 25,
            ""percent"": 34.38,
            ""averaging"": ""24h""
          },
          {
            ""name"": ""WHO"",
            ""pollutant"": ""PM10"",
            ""limit"": 50,
            ""percent"": 32.73,
            ""averaging"": ""24h""
          }
        ]
      },
      {
        ""fromDateTime"": ""2020-06-19T14:00:00.000Z"",
        ""tillDateTime"": ""2020-06-19T15:00:00.000Z"",
        ""values"": [
          {
            ""name"": ""PM1"",
            ""value"": 5.1
          },
          {
            ""name"": ""PM25"",
            ""value"": 7.49
          },
          {
            ""name"": ""PM10"",
            ""value"": 14.27
          },
          {
            ""name"": ""PRESSURE"",
            ""value"": 1011.13
          },
          {
            ""name"": ""HUMIDITY"",
            ""value"": 91.25
          },
          {
            ""name"": ""TEMPERATURE"",
            ""value"": 19.06
          }
        ],
        ""indexes"": [
          {
            ""name"": ""AIRLY_CAQI"",
            ""value"": 14.27,
            ""level"": ""VERY_LOW"",
            ""description"": ""Great air here today!"",
            ""advice"": ""Breathe deeply!"",
            ""color"": ""#6BC926""
          }
        ],
        ""standards"": [
          {
            ""name"": ""WHO"",
            ""pollutant"": ""PM25"",
            ""limit"": 25,
            ""percent"": 29.97,
            ""averaging"": ""24h""
          },
          {
            ""name"": ""WHO"",
            ""pollutant"": ""PM10"",
            ""limit"": 50,
            ""percent"": 28.54,
            ""averaging"": ""24h""
          }
        ]
      },
      {
        ""fromDateTime"": ""2020-06-19T15:00:00.000Z"",
        ""tillDateTime"": ""2020-06-19T16:00:00.000Z"",
        ""values"": [
          {
            ""name"": ""PM1"",
            ""value"": 5.35
          },
          {
            ""name"": ""PM25"",
            ""value"": 9.41
          },
          {
            ""name"": ""PM10"",
            ""value"": 16.23
          },
          {
            ""name"": ""PRESSURE"",
            ""value"": 1011.51
          },
          {
            ""name"": ""HUMIDITY"",
            ""value"": 91.25
          },
          {
            ""name"": ""TEMPERATURE"",
            ""value"": 18.45
          }
        ],
        ""indexes"": [
          {
            ""name"": ""AIRLY_CAQI"",
            ""value"": 16.23,
            ""level"": ""VERY_LOW"",
            ""description"": ""Great air here today!"",
            ""advice"": ""Green, green, green!"",
            ""color"": ""#6BC926""
          }
        ],
        ""standards"": [
          {
            ""name"": ""WHO"",
            ""pollutant"": ""PM25"",
            ""limit"": 25,
            ""percent"": 37.64,
            ""averaging"": ""24h""
          },
          {
            ""name"": ""WHO"",
            ""pollutant"": ""PM10"",
            ""limit"": 50,
            ""percent"": 32.45,
            ""averaging"": ""24h""
          }
        ]
      },
      {
        ""fromDateTime"": ""2020-06-19T16:00:00.000Z"",
        ""tillDateTime"": ""2020-06-19T17:00:00.000Z"",
        ""values"": [
          {
            ""name"": ""PM1"",
            ""value"": 6.78
          },
          {
            ""name"": ""PM25"",
            ""value"": 11.57
          },
          {
            ""name"": ""PM10"",
            ""value"": 19.27
          },
          {
            ""name"": ""PRESSURE"",
            ""value"": 1011.92
          },
          {
            ""name"": ""HUMIDITY"",
            ""value"": 95
          },
          {
            ""name"": ""TEMPERATURE"",
            ""value"": 17.91
          }
        ],
        ""indexes"": [
          {
            ""name"": ""AIRLY_CAQI"",
            ""value"": 19.29,
            ""level"": ""VERY_LOW"",
            ""description"": ""Great air here today!"",
            ""advice"": ""Catch your breath!"",
            ""color"": ""#6BC926""
          }
        ],
        ""standards"": [
          {
            ""name"": ""WHO"",
            ""pollutant"": ""PM25"",
            ""limit"": 25,
            ""percent"": 46.29,
            ""averaging"": ""24h""
          },
          {
            ""name"": ""WHO"",
            ""pollutant"": ""PM10"",
            ""limit"": 50,
            ""percent"": 38.55,
            ""averaging"": ""24h""
          }
        ]
      },
      {
        ""fromDateTime"": ""2020-06-19T17:00:00.000Z"",
        ""tillDateTime"": ""2020-06-19T18:00:00.000Z"",
        ""values"": [
          {
            ""name"": ""PM1"",
            ""value"": 8.33
          },
          {
            ""name"": ""PM25"",
            ""value"": 14.77
          },
          {
            ""name"": ""PM10"",
            ""value"": 26.17
          },
          {
            ""name"": ""PRESSURE"",
            ""value"": 1012.53
          },
          {
            ""name"": ""HUMIDITY"",
            ""value"": 96.72
          },
          {
            ""name"": ""TEMPERATURE"",
            ""value"": 16.82
          }
        ],
        ""indexes"": [
          {
            ""name"": ""AIRLY_CAQI"",
            ""value"": 26.17,
            ""level"": ""LOW"",
            ""description"": ""Air is quite good."",
            ""advice"": ""Enjoy the clean air."",
            ""color"": ""#D1CF1E""
          }
        ],
        ""standards"": [
          {
            ""name"": ""WHO"",
            ""pollutant"": ""PM25"",
            ""limit"": 25,
            ""percent"": 59.08,
            ""averaging"": ""24h""
          },
          {
            ""name"": ""WHO"",
            ""pollutant"": ""PM10"",
            ""limit"": 50,
            ""percent"": 52.35,
            ""averaging"": ""24h""
          }
        ]
      },
      {
        ""fromDateTime"": ""2020-06-19T18:00:00.000Z"",
        ""tillDateTime"": ""2020-06-19T19:00:00.000Z"",
        ""values"": [
          {
            ""name"": ""PM1"",
            ""value"": 12.14
          },
          {
            ""name"": ""PM25"",
            ""value"": 23.55
          },
          {
            ""name"": ""PM10"",
            ""value"": 44.63
          },
          {
            ""name"": ""PRESSURE"",
            ""value"": 1012.94
          },
          {
            ""name"": ""HUMIDITY"",
            ""value"": 92.58
          },
          {
            ""name"": ""TEMPERATURE"",
            ""value"": 16.67
          }
        ],
        ""indexes"": [
          {
            ""name"": ""AIRLY_CAQI"",
            ""value"": 44.63,
            ""level"": ""LOW"",
            ""description"": ""Air is quite good."",
            ""advice"": ""Take a deep breath. Today, you can. ;)"",
            ""color"": ""#D1CF1E""
          }
        ],
        ""standards"": [
          {
            ""name"": ""WHO"",
            ""pollutant"": ""PM25"",
            ""limit"": 25,
            ""percent"": 94.21,
            ""averaging"": ""24h""
          },
          {
            ""name"": ""WHO"",
            ""pollutant"": ""PM10"",
            ""limit"": 50,
            ""percent"": 89.26,
            ""averaging"": ""24h""
          }
        ]
      },
      {
        ""fromDateTime"": ""2020-06-19T19:00:00.000Z"",
        ""tillDateTime"": ""2020-06-19T20:00:00.000Z"",
        ""values"": [
          {
            ""name"": ""PM1"",
            ""value"": 12.79
          },
          {
            ""name"": ""PM25"",
            ""value"": 25.32
          },
          {
            ""name"": ""PM10"",
            ""value"": 48.18
          },
          {
            ""name"": ""PRESSURE"",
            ""value"": 1013.41
          },
          {
            ""name"": ""HUMIDITY"",
            ""value"": 92.86
          },
          {
            ""name"": ""TEMPERATURE"",
            ""value"": 16.26
          }
        ],
        ""indexes"": [
          {
            ""name"": ""AIRLY_CAQI"",
            ""value"": 48.18,
            ""level"": ""LOW"",
            ""description"": ""Air is quite good."",
            ""advice"": ""Take a deep breath. Today, you can. ;)"",
            ""color"": ""#D1CF1E""
          }
        ],
        ""standards"": [
          {
            ""name"": ""WHO"",
            ""pollutant"": ""PM25"",
            ""limit"": 25,
            ""percent"": 101.28,
            ""averaging"": ""24h""
          },
          {
            ""name"": ""WHO"",
            ""pollutant"": ""PM10"",
            ""limit"": 50,
            ""percent"": 96.36,
            ""averaging"": ""24h""
          }
        ]
      },
      {
        ""fromDateTime"": ""2020-06-19T20:00:00.000Z"",
        ""tillDateTime"": ""2020-06-19T21:00:00.000Z"",
        ""values"": [
          {
            ""name"": ""PM1"",
            ""value"": 11.58
          },
          {
            ""name"": ""PM25"",
            ""value"": 23.34
          },
          {
            ""name"": ""PM10"",
            ""value"": 45.14
          },
          {
            ""name"": ""PRESSURE"",
            ""value"": 1013.49
          },
          {
            ""name"": ""HUMIDITY"",
            ""value"": 96.34
          },
          {
            ""name"": ""TEMPERATURE"",
            ""value"": 15.83
          }
        ],
        ""indexes"": [
          {
            ""name"": ""AIRLY_CAQI"",
            ""value"": 45.14,
            ""level"": ""LOW"",
            ""description"": ""Air is quite good."",
            ""advice"": ""The air quality is good today!"",
            ""color"": ""#D1CF1E""
          }
        ],
        ""standards"": [
          {
            ""name"": ""WHO"",
            ""pollutant"": ""PM25"",
            ""limit"": 25,
            ""percent"": 93.34,
            ""averaging"": ""24h""
          },
          {
            ""name"": ""WHO"",
            ""pollutant"": ""PM10"",
            ""limit"": 50,
            ""percent"": 90.29,
            ""averaging"": ""24h""
          }
        ]
      },
      {
        ""fromDateTime"": ""2020-06-19T21:00:00.000Z"",
        ""tillDateTime"": ""2020-06-19T22:00:00.000Z"",
        ""values"": [
          {
            ""name"": ""PM1"",
            ""value"": 12.48
          },
          {
            ""name"": ""PM25"",
            ""value"": 25.14
          },
          {
            ""name"": ""PM10"",
            ""value"": 48.3
          },
          {
            ""name"": ""PRESSURE"",
            ""value"": 1013.53
          },
          {
            ""name"": ""HUMIDITY"",
            ""value"": 98
          },
          {
            ""name"": ""TEMPERATURE"",
            ""value"": 15.64
          }
        ],
        ""indexes"": [
          {
            ""name"": ""AIRLY_CAQI"",
            ""value"": 48.3,
            ""level"": ""LOW"",
            ""description"": ""Air is quite good."",
            ""advice"": ""Enjoy the clean air."",
            ""color"": ""#D1CF1E""
          }
        ],
        ""standards"": [
          {
            ""name"": ""WHO"",
            ""pollutant"": ""PM25"",
            ""limit"": 25,
            ""percent"": 100.55,
            ""averaging"": ""24h""
          },
          {
            ""name"": ""WHO"",
            ""pollutant"": ""PM10"",
            ""limit"": 50,
            ""percent"": 96.6,
            ""averaging"": ""24h""
          }
        ]
      },
      {
        ""fromDateTime"": ""2020-06-19T22:00:00.000Z"",
        ""tillDateTime"": ""2020-06-19T23:00:00.000Z"",
        ""values"": [
          {
            ""name"": ""PM1"",
            ""value"": 11.68
          },
          {
            ""name"": ""PM25"",
            ""value"": 23.22
          },
          {
            ""name"": ""PM10"",
            ""value"": 45.65
          },
          {
            ""name"": ""PRESSURE"",
            ""value"": 1013.35
          },
          {
            ""name"": ""HUMIDITY"",
            ""value"": 98.91
          },
          {
            ""name"": ""TEMPERATURE"",
            ""value"": 15.39
          }
        ],
        ""indexes"": [
          {
            ""name"": ""AIRLY_CAQI"",
            ""value"": 45.65,
            ""level"": ""LOW"",
            ""description"": ""Air is quite good."",
            ""advice"": ""Take a deep breath. Today, you can. ;)"",
            ""color"": ""#D1CF1E""
          }
        ],
        ""standards"": [
          {
            ""name"": ""WHO"",
            ""pollutant"": ""PM25"",
            ""limit"": 25,
            ""percent"": 92.88,
            ""averaging"": ""24h""
          },
          {
            ""name"": ""WHO"",
            ""pollutant"": ""PM10"",
            ""limit"": 50,
            ""percent"": 91.3,
            ""averaging"": ""24h""
          }
        ]
      },
      {
        ""fromDateTime"": ""2020-06-19T23:00:00.000Z"",
        ""tillDateTime"": ""2020-06-20T00:00:00.000Z"",
        ""values"": [
          {
            ""name"": ""PM1"",
            ""value"": 9.64
          },
          {
            ""name"": ""PM25"",
            ""value"": 19.9
          },
          {
            ""name"": ""PM10"",
            ""value"": 37.19
          },
          {
            ""name"": ""PRESSURE"",
            ""value"": 1013.43
          },
          {
            ""name"": ""HUMIDITY"",
            ""value"": 99.13
          },
          {
            ""name"": ""TEMPERATURE"",
            ""value"": 15.19
          }
        ],
        ""indexes"": [
          {
            ""name"": ""AIRLY_CAQI"",
            ""value"": 37.19,
            ""level"": ""LOW"",
            ""description"": ""Air is quite good."",
            ""advice"": ""Don't miss this day! The clean air calls!"",
            ""color"": ""#D1CF1E""
          }
        ],
        ""standards"": [
          {
            ""name"": ""WHO"",
            ""pollutant"": ""PM25"",
            ""limit"": 25,
            ""percent"": 79.58,
            ""averaging"": ""24h""
          },
          {
            ""name"": ""WHO"",
            ""pollutant"": ""PM10"",
            ""limit"": 50,
            ""percent"": 74.38,
            ""averaging"": ""24h""
          }
        ]
      },
      {
        ""fromDateTime"": ""2020-06-20T00:00:00.000Z"",
        ""tillDateTime"": ""2020-06-20T01:00:00.000Z"",
        ""values"": [
          {
            ""name"": ""PM1"",
            ""value"": 9.49
          },
          {
            ""name"": ""PM25"",
            ""value"": 19.55
          },
          {
            ""name"": ""PM10"",
            ""value"": 38.02
          },
          {
            ""name"": ""PRESSURE"",
            ""value"": 1013.33
          },
          {
            ""name"": ""HUMIDITY"",
            ""value"": 99.45
          },
          {
            ""name"": ""TEMPERATURE"",
            ""value"": 15.03
          }
        ],
        ""indexes"": [
          {
            ""name"": ""AIRLY_CAQI"",
            ""value"": 38.02,
            ""level"": ""LOW"",
            ""description"": ""Air is quite good."",
            ""advice"": ""Take a deep breath. Today, you can. ;)"",
            ""color"": ""#D1CF1E""
          }
        ],
        ""standards"": [
          {
            ""name"": ""WHO"",
            ""pollutant"": ""PM25"",
            ""limit"": 25,
            ""percent"": 78.19,
            ""averaging"": ""24h""
          },
          {
            ""name"": ""WHO"",
            ""pollutant"": ""PM10"",
            ""limit"": 50,
            ""percent"": 76.04,
            ""averaging"": ""24h""
          }
        ]
      },
      {
        ""fromDateTime"": ""2020-06-20T01:00:00.000Z"",
        ""tillDateTime"": ""2020-06-20T02:00:00.000Z"",
        ""values"": [
          {
            ""name"": ""PM1"",
            ""value"": 8.52
          },
          {
            ""name"": ""PM25"",
            ""value"": 18.39
          },
          {
            ""name"": ""PM10"",
            ""value"": 36.56
          },
          {
            ""name"": ""PRESSURE"",
            ""value"": 1013.15
          },
          {
            ""name"": ""HUMIDITY"",
            ""value"": 99.7
          },
          {
            ""name"": ""TEMPERATURE"",
            ""value"": 14.74
          }
        ],
        ""indexes"": [
          {
            ""name"": ""AIRLY_CAQI"",
            ""value"": 36.56,
            ""level"": ""LOW"",
            ""description"": ""Air is quite good."",
            ""advice"": ""Do you smell it? That's the smell of clean air. :)"",
            ""color"": ""#D1CF1E""
          }
        ],
        ""standards"": [
          {
            ""name"": ""WHO"",
            ""pollutant"": ""PM25"",
            ""limit"": 25,
            ""percent"": 73.58,
            ""averaging"": ""24h""
          },
          {
            ""name"": ""WHO"",
            ""pollutant"": ""PM10"",
            ""limit"": 50,
            ""percent"": 73.12,
            ""averaging"": ""24h""
          }
        ]
      },
      {
        ""fromDateTime"": ""2020-06-20T02:00:00.000Z"",
        ""tillDateTime"": ""2020-06-20T03:00:00.000Z"",
        ""values"": [
          {
            ""name"": ""PM1"",
            ""value"": 5.95
          },
          {
            ""name"": ""PM25"",
            ""value"": 13.05
          },
          {
            ""name"": ""PM10"",
            ""value"": 24.58
          },
          {
            ""name"": ""PRESSURE"",
            ""value"": 1013.28
          },
          {
            ""name"": ""HUMIDITY"",
            ""value"": 99.77
          },
          {
            ""name"": ""TEMPERATURE"",
            ""value"": 14.46
          }
        ],
        ""indexes"": [
          {
            ""name"": ""AIRLY_CAQI"",
            ""value"": 24.58,
            ""level"": ""VERY_LOW"",
            ""description"": ""Great air here today!"",
            ""advice"": ""Breathe deep! The air is clean!"",
            ""color"": ""#6BC926""
          }
        ],
        ""standards"": [
          {
            ""name"": ""WHO"",
            ""pollutant"": ""PM25"",
            ""limit"": 25,
            ""percent"": 52.19,
            ""averaging"": ""24h""
          },
          {
            ""name"": ""WHO"",
            ""pollutant"": ""PM10"",
            ""limit"": 50,
            ""percent"": 49.15,
            ""averaging"": ""24h""
          }
        ]
      },
      {
        ""fromDateTime"": ""2020-06-20T03:00:00.000Z"",
        ""tillDateTime"": ""2020-06-20T04:00:00.000Z"",
        ""values"": [
          {
            ""name"": ""PM1"",
            ""value"": 4.88
          },
          {
            ""name"": ""PM25"",
            ""value"": 11.03
          },
          {
            ""name"": ""PM10"",
            ""value"": 21.36
          },
          {
            ""name"": ""PRESSURE"",
            ""value"": 1013.44
          },
          {
            ""name"": ""HUMIDITY"",
            ""value"": 99.72
          },
          {
            ""name"": ""TEMPERATURE"",
            ""value"": 14.36
          }
        ],
        ""indexes"": [
          {
            ""name"": ""AIRLY_CAQI"",
            ""value"": 21.36,
            ""level"": ""VERY_LOW"",
            ""description"": ""Great air here today!"",
            ""advice"": ""Breathe deeply!"",
            ""color"": ""#6BC926""
          }
        ],
        ""standards"": [
          {
            ""name"": ""WHO"",
            ""pollutant"": ""PM25"",
            ""limit"": 25,
            ""percent"": 44.13,
            ""averaging"": ""24h""
          },
          {
            ""name"": ""WHO"",
            ""pollutant"": ""PM10"",
            ""limit"": 50,
            ""percent"": 42.73,
            ""averaging"": ""24h""
          }
        ]
      },
      {
        ""fromDateTime"": ""2020-06-20T04:00:00.000Z"",
        ""tillDateTime"": ""2020-06-20T05:00:00.000Z"",
        ""values"": [
          {
            ""name"": ""PM1"",
            ""value"": 4.65
          },
          {
            ""name"": ""PM25"",
            ""value"": 10.36
          },
          {
            ""name"": ""PM10"",
            ""value"": 18.02
          },
          {
            ""name"": ""PRESSURE"",
            ""value"": 1013.49
          },
          {
            ""name"": ""HUMIDITY"",
            ""value"": 99.12
          },
          {
            ""name"": ""TEMPERATURE"",
            ""value"": 14.68
          }
        ],
        ""indexes"": [
          {
            ""name"": ""AIRLY_CAQI"",
            ""value"": 18.02,
            ""level"": ""VERY_LOW"",
            ""description"": ""Great air here today!"",
            ""advice"": ""Green, green, green!"",
            ""color"": ""#6BC926""
          }
        ],
        ""standards"": [
          {
            ""name"": ""WHO"",
            ""pollutant"": ""PM25"",
            ""limit"": 25,
            ""percent"": 41.44,
            ""averaging"": ""24h""
          },
          {
            ""name"": ""WHO"",
            ""pollutant"": ""PM10"",
            ""limit"": 50,
            ""percent"": 36.04,
            ""averaging"": ""24h""
          }
        ]
      },
      {
        ""fromDateTime"": ""2020-06-20T05:00:00.000Z"",
        ""tillDateTime"": ""2020-06-20T06:00:00.000Z"",
        ""values"": [
          {
            ""name"": ""PM1"",
            ""value"": 4.5
          },
          {
            ""name"": ""PM25"",
            ""value"": 8.68
          },
          {
            ""name"": ""PM10"",
            ""value"": 15.88
          },
          {
            ""name"": ""PRESSURE"",
            ""value"": 1013.31
          },
          {
            ""name"": ""HUMIDITY"",
            ""value"": 97.89
          },
          {
            ""name"": ""TEMPERATURE"",
            ""value"": 14.88
          }
        ],
        ""indexes"": [
          {
            ""name"": ""AIRLY_CAQI"",
            ""value"": 15.88,
            ""level"": ""VERY_LOW"",
            ""description"": ""Great air here today!"",
            ""advice"": ""Green equals clean!"",
            ""color"": ""#6BC926""
          }
        ],
        ""standards"": [
          {
            ""name"": ""WHO"",
            ""pollutant"": ""PM25"",
            ""limit"": 25,
            ""percent"": 34.71,
            ""averaging"": ""24h""
          },
          {
            ""name"": ""WHO"",
            ""pollutant"": ""PM10"",
            ""limit"": 50,
            ""percent"": 31.76,
            ""averaging"": ""24h""
          }
        ]
      },
      {
        ""fromDateTime"": ""2020-06-20T06:00:00.000Z"",
        ""tillDateTime"": ""2020-06-20T07:00:00.000Z"",
        ""values"": [
          {
            ""name"": ""PM1"",
            ""value"": 5.21
          },
          {
            ""name"": ""PM25"",
            ""value"": 9.49
          },
          {
            ""name"": ""PM10"",
            ""value"": 17.52
          },
          {
            ""name"": ""PRESSURE"",
            ""value"": 1013.22
          },
          {
            ""name"": ""HUMIDITY"",
            ""value"": 99.14
          },
          {
            ""name"": ""TEMPERATURE"",
            ""value"": 14.79
          }
        ],
        ""indexes"": [
          {
            ""name"": ""AIRLY_CAQI"",
            ""value"": 17.52,
            ""level"": ""VERY_LOW"",
            ""description"": ""Great air here today!"",
            ""advice"": ""Breathe deep! The air is clean!"",
            ""color"": ""#6BC926""
          }
        ],
        ""standards"": [
          {
            ""name"": ""WHO"",
            ""pollutant"": ""PM25"",
            ""limit"": 25,
            ""percent"": 37.96,
            ""averaging"": ""24h""
          },
          {
            ""name"": ""WHO"",
            ""pollutant"": ""PM10"",
            ""limit"": 50,
            ""percent"": 35.04,
            ""averaging"": ""24h""
          }
        ]
      },
      {
        ""fromDateTime"": ""2020-06-20T07:00:00.000Z"",
        ""tillDateTime"": ""2020-06-20T08:00:00.000Z"",
        ""values"": [
          {
            ""name"": ""PM1"",
            ""value"": 3.92
          },
          {
            ""name"": ""PM25"",
            ""value"": 6.99
          },
          {
            ""name"": ""PM10"",
            ""value"": 12.65
          },
          {
            ""name"": ""PRESSURE"",
            ""value"": 1013.14
          },
          {
            ""name"": ""HUMIDITY"",
            ""value"": 99.5
          },
          {
            ""name"": ""TEMPERATURE"",
            ""value"": 15.21
          }
        ],
        ""indexes"": [
          {
            ""name"": ""AIRLY_CAQI"",
            ""value"": 12.65,
            ""level"": ""VERY_LOW"",
            ""description"": ""Great air here today!"",
            ""advice"": ""Dear me, how wonderful!"",
            ""color"": ""#6BC926""
          }
        ],
        ""standards"": [
          {
            ""name"": ""WHO"",
            ""pollutant"": ""PM25"",
            ""limit"": 25,
            ""percent"": 27.95,
            ""averaging"": ""24h""
          },
          {
            ""name"": ""WHO"",
            ""pollutant"": ""PM10"",
            ""limit"": 50,
            ""percent"": 25.3,
            ""averaging"": ""24h""
          }
        ]
      },
      {
        ""fromDateTime"": ""2020-06-20T08:00:00.000Z"",
        ""tillDateTime"": ""2020-06-20T09:00:00.000Z"",
        ""values"": [
          {
            ""name"": ""PM1"",
            ""value"": 3.69
          },
          {
            ""name"": ""PM25"",
            ""value"": 6.81
          },
          {
            ""name"": ""PM10"",
            ""value"": 11.7
          },
          {
            ""name"": ""PRESSURE"",
            ""value"": 1013.13
          },
          {
            ""name"": ""HUMIDITY"",
            ""value"": 98.25
          },
          {
            ""name"": ""TEMPERATURE"",
            ""value"": 15.89
          }
        ],
        ""indexes"": [
          {
            ""name"": ""AIRLY_CAQI"",
            ""value"": 11.7,
            ""level"": ""VERY_LOW"",
            ""description"": ""Great air here today!"",
            ""advice"": ""Enjoy life!"",
            ""color"": ""#6BC926""
          }
        ],
        ""standards"": [
          {
            ""name"": ""WHO"",
            ""pollutant"": ""PM25"",
            ""limit"": 25,
            ""percent"": 27.25,
            ""averaging"": ""24h""
          },
          {
            ""name"": ""WHO"",
            ""pollutant"": ""PM10"",
            ""limit"": 50,
            ""percent"": 23.4,
            ""averaging"": ""24h""
          }
        ]
      },
      {
        ""fromDateTime"": ""2020-06-20T09:00:00.000Z"",
        ""tillDateTime"": ""2020-06-20T10:00:00.000Z"",
        ""values"": [
          {
            ""name"": ""PM1"",
            ""value"": 4.31
          },
          {
            ""name"": ""PM25"",
            ""value"": 8.7
          },
          {
            ""name"": ""PM10"",
            ""value"": 15.6
          },
          {
            ""name"": ""PRESSURE"",
            ""value"": 1013.28
          },
          {
            ""name"": ""HUMIDITY"",
            ""value"": 96.75
          },
          {
            ""name"": ""TEMPERATURE"",
            ""value"": 16.53
          }
        ],
        ""indexes"": [
          {
            ""name"": ""AIRLY_CAQI"",
            ""value"": 15.6,
            ""level"": ""VERY_LOW"",
            ""description"": ""Great air here today!"",
            ""advice"": ""Breathe deeply!"",
            ""color"": ""#6BC926""
          }
        ],
        ""standards"": [
          {
            ""name"": ""WHO"",
            ""pollutant"": ""PM25"",
            ""limit"": 25,
            ""percent"": 34.8,
            ""averaging"": ""24h""
          },
          {
            ""name"": ""WHO"",
            ""pollutant"": ""PM10"",
            ""limit"": 50,
            ""percent"": 31.19,
            ""averaging"": ""24h""
          }
        ]
      },
      {
        ""fromDateTime"": ""2020-06-20T10:00:00.000Z"",
        ""tillDateTime"": ""2020-06-20T11:00:00.000Z"",
        ""values"": [
          {
            ""name"": ""PM1"",
            ""value"": 4.86
          },
          {
            ""name"": ""PM25"",
            ""value"": 9.24
          },
          {
            ""name"": ""PM10"",
            ""value"": 16.74
          },
          {
            ""name"": ""PRESSURE"",
            ""value"": 1013.25
          },
          {
            ""name"": ""HUMIDITY"",
            ""value"": 96.05
          },
          {
            ""name"": ""TEMPERATURE"",
            ""value"": 16.88
          }
        ],
        ""indexes"": [
          {
            ""name"": ""AIRLY_CAQI"",
            ""value"": 16.74,
            ""level"": ""VERY_LOW"",
            ""description"": ""Great air here today!"",
            ""advice"": ""Green equals clean!"",
            ""color"": ""#6BC926""
          }
        ],
        ""standards"": [
          {
            ""name"": ""WHO"",
            ""pollutant"": ""PM25"",
            ""limit"": 25,
            ""percent"": 36.97,
            ""averaging"": ""24h""
          },
          {
            ""name"": ""WHO"",
            ""pollutant"": ""PM10"",
            ""limit"": 50,
            ""percent"": 33.49,
            ""averaging"": ""24h""
          }
        ]
      },
      {
        ""fromDateTime"": ""2020-06-20T11:00:00.000Z"",
        ""tillDateTime"": ""2020-06-20T12:00:00.000Z"",
        ""values"": [
          {
            ""name"": ""PM1"",
            ""value"": 5.38
          },
          {
            ""name"": ""PM25"",
            ""value"": 10.59
          },
          {
            ""name"": ""PM10"",
            ""value"": 19.85
          },
          {
            ""name"": ""PRESSURE"",
            ""value"": 1012.97
          },
          {
            ""name"": ""HUMIDITY"",
            ""value"": 95.75
          },
          {
            ""name"": ""TEMPERATURE"",
            ""value"": 17.86
          }
        ],
        ""indexes"": [
          {
            ""name"": ""AIRLY_CAQI"",
            ""value"": 19.85,
            ""level"": ""VERY_LOW"",
            ""description"": ""Great air here today!"",
            ""advice"": ""Green, green, green!"",
            ""color"": ""#6BC926""
          }
        ],
        ""standards"": [
          {
            ""name"": ""WHO"",
            ""pollutant"": ""PM25"",
            ""limit"": 25,
            ""percent"": 42.38,
            ""averaging"": ""24h""
          },
          {
            ""name"": ""WHO"",
            ""pollutant"": ""PM10"",
            ""limit"": 50,
            ""percent"": 39.7,
            ""averaging"": ""24h""
          }
        ]
      },
      {
        ""fromDateTime"": ""2020-06-20T12:00:00.000Z"",
        ""tillDateTime"": ""2020-06-20T13:00:00.000Z"",
        ""values"": [
          {
            ""name"": ""PM1"",
            ""value"": 5.4
          },
          {
            ""name"": ""PM25"",
            ""value"": 10.04
          },
          {
            ""name"": ""PM10"",
            ""value"": 17.22
          },
          {
            ""name"": ""PRESSURE"",
            ""value"": 1012.81
          },
          {
            ""name"": ""HUMIDITY"",
            ""value"": 95.5
          },
          {
            ""name"": ""TEMPERATURE"",
            ""value"": 18.23
          }
        ],
        ""indexes"": [
          {
            ""name"": ""AIRLY_CAQI"",
            ""value"": 17.22,
            ""level"": ""VERY_LOW"",
            ""description"": ""Great air here today!"",
            ""advice"": ""Great air!"",
            ""color"": ""#6BC926""
          }
        ],
        ""standards"": [
          {
            ""name"": ""WHO"",
            ""pollutant"": ""PM25"",
            ""limit"": 25,
            ""percent"": 40.15,
            ""averaging"": ""24h""
          },
          {
            ""name"": ""WHO"",
            ""pollutant"": ""PM10"",
            ""limit"": 50,
            ""percent"": 34.44,
            ""averaging"": ""24h""
          }
        ]
      }
    ],
    ""forecast"": [
      {
        ""fromDateTime"": ""2020-06-20T13:00:00.000Z"",
        ""tillDateTime"": ""2020-06-20T14:00:00.000Z"",
        ""values"": [
          {
            ""name"": ""PM25"",
            ""value"": 11.19
          },
          {
            ""name"": ""PM10"",
            ""value"": 16.15
          }
        ],
        ""indexes"": [
          {
            ""name"": ""AIRLY_CAQI"",
            ""value"": 18.66,
            ""level"": ""VERY_LOW"",
            ""description"": ""Great air here today!"",
            ""advice"": ""Catch your breath!"",
            ""color"": ""#6BC926""
          }
        ],
        ""standards"": [
          {
            ""name"": ""WHO"",
            ""pollutant"": ""PM25"",
            ""limit"": 25,
            ""percent"": 44.77,
            ""averaging"": ""24h""
          },
          {
            ""name"": ""WHO"",
            ""pollutant"": ""PM10"",
            ""limit"": 50,
            ""percent"": 32.3,
            ""averaging"": ""24h""
          }
        ]
      },
      {
        ""fromDateTime"": ""2020-06-20T14:00:00.000Z"",
        ""tillDateTime"": ""2020-06-20T15:00:00.000Z"",
        ""values"": [
          {
            ""name"": ""PM25"",
            ""value"": 10.72
          },
          {
            ""name"": ""PM10"",
            ""value"": 15.37
          }
        ],
        ""indexes"": [
          {
            ""name"": ""AIRLY_CAQI"",
            ""value"": 17.86,
            ""level"": ""VERY_LOW"",
            ""description"": ""Great air here today!"",
            ""advice"": ""Green, green, green!"",
            ""color"": ""#6BC926""
          }
        ],
        ""standards"": [
          {
            ""name"": ""WHO"",
            ""pollutant"": ""PM25"",
            ""limit"": 25,
            ""percent"": 42.86,
            ""averaging"": ""24h""
          },
          {
            ""name"": ""WHO"",
            ""pollutant"": ""PM10"",
            ""limit"": 50,
            ""percent"": 30.73,
            ""averaging"": ""24h""
          }
        ]
      },
      {
        ""fromDateTime"": ""2020-06-20T15:00:00.000Z"",
        ""tillDateTime"": ""2020-06-20T16:00:00.000Z"",
        ""values"": [
          {
            ""name"": ""PM25"",
            ""value"": 10.91
          },
          {
            ""name"": ""PM10"",
            ""value"": 15.5
          }
        ],
        ""indexes"": [
          {
            ""name"": ""AIRLY_CAQI"",
            ""value"": 18.18,
            ""level"": ""VERY_LOW"",
            ""description"": ""Great air here today!"",
            ""advice"": ""Breathe deep! The air is clean!"",
            ""color"": ""#6BC926""
          }
        ],
        ""standards"": [
          {
            ""name"": ""WHO"",
            ""pollutant"": ""PM25"",
            ""limit"": 25,
            ""percent"": 43.62,
            ""averaging"": ""24h""
          },
          {
            ""name"": ""WHO"",
            ""pollutant"": ""PM10"",
            ""limit"": 50,
            ""percent"": 31,
            ""averaging"": ""24h""
          }
        ]
      },
      {
        ""fromDateTime"": ""2020-06-20T16:00:00.000Z"",
        ""tillDateTime"": ""2020-06-20T17:00:00.000Z"",
        ""values"": [
          {
            ""name"": ""PM25"",
            ""value"": 12
          },
          {
            ""name"": ""PM10"",
            ""value"": 17.28
          }
        ],
        ""indexes"": [
          {
            ""name"": ""AIRLY_CAQI"",
            ""value"": 20,
            ""level"": ""VERY_LOW"",
            ""description"": ""Great air here today!"",
            ""advice"": ""Green, green, green!"",
            ""color"": ""#6BC926""
          }
        ],
        ""standards"": [
          {
            ""name"": ""WHO"",
            ""pollutant"": ""PM25"",
            ""limit"": 25,
            ""percent"": 48.01,
            ""averaging"": ""24h""
          },
          {
            ""name"": ""WHO"",
            ""pollutant"": ""PM10"",
            ""limit"": 50,
            ""percent"": 34.56,
            ""averaging"": ""24h""
          }
        ]
      },
      {
        ""fromDateTime"": ""2020-06-20T17:00:00.000Z"",
        ""tillDateTime"": ""2020-06-20T18:00:00.000Z"",
        ""values"": [
          {
            ""name"": ""PM25"",
            ""value"": 14.1
          },
          {
            ""name"": ""PM10"",
            ""value"": 20.64
          }
        ],
        ""indexes"": [
          {
            ""name"": ""AIRLY_CAQI"",
            ""value"": 23.49,
            ""level"": ""VERY_LOW"",
            ""description"": ""Great air here today!"",
            ""advice"": ""Breathe to fill your lungs!"",
            ""color"": ""#6BC926""
          }
        ],
        ""standards"": [
          {
            ""name"": ""WHO"",
            ""pollutant"": ""PM25"",
            ""limit"": 25,
            ""percent"": 56.39,
            ""averaging"": ""24h""
          },
          {
            ""name"": ""WHO"",
            ""pollutant"": ""PM10"",
            ""limit"": 50,
            ""percent"": 41.29,
            ""averaging"": ""24h""
          }
        ]
      },
      {
        ""fromDateTime"": ""2020-06-20T18:00:00.000Z"",
        ""tillDateTime"": ""2020-06-20T19:00:00.000Z"",
        ""values"": [
          {
            ""name"": ""PM25"",
            ""value"": 15.93
          },
          {
            ""name"": ""PM10"",
            ""value"": 23.94
          }
        ],
        ""indexes"": [
          {
            ""name"": ""AIRLY_CAQI"",
            ""value"": 26.55,
            ""level"": ""LOW"",
            ""description"": ""Air is quite good."",
            ""advice"": ""Don't miss this day! The clean air calls!"",
            ""color"": ""#D1CF1E""
          }
        ],
        ""standards"": [
          {
            ""name"": ""WHO"",
            ""pollutant"": ""PM25"",
            ""limit"": 25,
            ""percent"": 63.73,
            ""averaging"": ""24h""
          },
          {
            ""name"": ""WHO"",
            ""pollutant"": ""PM10"",
            ""limit"": 50,
            ""percent"": 47.87,
            ""averaging"": ""24h""
          }
        ]
      },
      {
        ""fromDateTime"": ""2020-06-20T19:00:00.000Z"",
        ""tillDateTime"": ""2020-06-20T20:00:00.000Z"",
        ""values"": [
          {
            ""name"": ""PM25"",
            ""value"": 17.84
          },
          {
            ""name"": ""PM10"",
            ""value"": 26.1
          }
        ],
        ""indexes"": [
          {
            ""name"": ""AIRLY_CAQI"",
            ""value"": 29.74,
            ""level"": ""LOW"",
            ""description"": ""Air is quite good."",
            ""advice"": ""Do you smell it? That's the smell of clean air. :)"",
            ""color"": ""#D1CF1E""
          }
        ],
        ""standards"": [
          {
            ""name"": ""WHO"",
            ""pollutant"": ""PM25"",
            ""limit"": 25,
            ""percent"": 71.37,
            ""averaging"": ""24h""
          },
          {
            ""name"": ""WHO"",
            ""pollutant"": ""PM10"",
            ""limit"": 50,
            ""percent"": 52.2,
            ""averaging"": ""24h""
          }
        ]
      },
      {
        ""fromDateTime"": ""2020-06-20T20:00:00.000Z"",
        ""tillDateTime"": ""2020-06-20T21:00:00.000Z"",
        ""values"": [
          {
            ""name"": ""PM25"",
            ""value"": 16.91
          },
          {
            ""name"": ""PM10"",
            ""value"": 26.89
          }
        ],
        ""indexes"": [
          {
            ""name"": ""AIRLY_CAQI"",
            ""value"": 28.18,
            ""level"": ""LOW"",
            ""description"": ""Air is quite good."",
            ""advice"": ""Yes, yes - it's true. The air quality is good today!"",
            ""color"": ""#D1CF1E""
          }
        ],
        ""standards"": [
          {
            ""name"": ""WHO"",
            ""pollutant"": ""PM25"",
            ""limit"": 25,
            ""percent"": 67.63,
            ""averaging"": ""24h""
          },
          {
            ""name"": ""WHO"",
            ""pollutant"": ""PM10"",
            ""limit"": 50,
            ""percent"": 53.77,
            ""averaging"": ""24h""
          }
        ]
      },
      {
        ""fromDateTime"": ""2020-06-20T21:00:00.000Z"",
        ""tillDateTime"": ""2020-06-20T22:00:00.000Z"",
        ""values"": [
          {
            ""name"": ""PM25"",
            ""value"": 17.82
          },
          {
            ""name"": ""PM10"",
            ""value"": 26.28
          }
        ],
        ""indexes"": [
          {
            ""name"": ""AIRLY_CAQI"",
            ""value"": 29.7,
            ""level"": ""LOW"",
            ""description"": ""Air is quite good."",
            ""advice"": ""Do you smell it? That's the smell of clean air. :)"",
            ""color"": ""#D1CF1E""
          }
        ],
        ""standards"": [
          {
            ""name"": ""WHO"",
            ""pollutant"": ""PM25"",
            ""limit"": 25,
            ""percent"": 71.29,
            ""averaging"": ""24h""
          },
          {
            ""name"": ""WHO"",
            ""pollutant"": ""PM10"",
            ""limit"": 50,
            ""percent"": 52.56,
            ""averaging"": ""24h""
          }
        ]
      },
      {
        ""fromDateTime"": ""2020-06-20T22:00:00.000Z"",
        ""tillDateTime"": ""2020-06-20T23:00:00.000Z"",
        ""values"": [
          {
            ""name"": ""PM25"",
            ""value"": 16.04
          },
          {
            ""name"": ""PM10"",
            ""value"": 24.71
          }
        ],
        ""indexes"": [
          {
            ""name"": ""AIRLY_CAQI"",
            ""value"": 26.73,
            ""level"": ""LOW"",
            ""description"": ""Air is quite good."",
            ""advice"": ""Yes, yes - it's true. The air quality is good today!"",
            ""color"": ""#D1CF1E""
          }
        ],
        ""standards"": [
          {
            ""name"": ""WHO"",
            ""pollutant"": ""PM25"",
            ""limit"": 25,
            ""percent"": 64.16,
            ""averaging"": ""24h""
          },
          {
            ""name"": ""WHO"",
            ""pollutant"": ""PM10"",
            ""limit"": 50,
            ""percent"": 49.42,
            ""averaging"": ""24h""
          }
        ]
      },
      {
        ""fromDateTime"": ""2020-06-20T23:00:00.000Z"",
        ""tillDateTime"": ""2020-06-21T00:00:00.000Z"",
        ""values"": [
          {
            ""name"": ""PM25"",
            ""value"": 15.64
          },
          {
            ""name"": ""PM10"",
            ""value"": 23.28
          }
        ],
        ""indexes"": [
          {
            ""name"": ""AIRLY_CAQI"",
            ""value"": 26.06,
            ""level"": ""LOW"",
            ""description"": ""Air is quite good."",
            ""advice"": ""Do you smell it? That's the smell of clean air. :)"",
            ""color"": ""#D1CF1E""
          }
        ],
        ""standards"": [
          {
            ""name"": ""WHO"",
            ""pollutant"": ""PM25"",
            ""limit"": 25,
            ""percent"": 62.54,
            ""averaging"": ""24h""
          },
          {
            ""name"": ""WHO"",
            ""pollutant"": ""PM10"",
            ""limit"": 50,
            ""percent"": 46.57,
            ""averaging"": ""24h""
          }
        ]
      },
      {
        ""fromDateTime"": ""2020-06-21T00:00:00.000Z"",
        ""tillDateTime"": ""2020-06-21T01:00:00.000Z"",
        ""values"": [
          {
            ""name"": ""PM25"",
            ""value"": 15.68
          },
          {
            ""name"": ""PM10"",
            ""value"": 22.72
          }
        ],
        ""indexes"": [
          {
            ""name"": ""AIRLY_CAQI"",
            ""value"": 26.14,
            ""level"": ""LOW"",
            ""description"": ""Air is quite good."",
            ""advice"": ""The air quality is good today!"",
            ""color"": ""#D1CF1E""
          }
        ],
        ""standards"": [
          {
            ""name"": ""WHO"",
            ""pollutant"": ""PM25"",
            ""limit"": 25,
            ""percent"": 62.74,
            ""averaging"": ""24h""
          },
          {
            ""name"": ""WHO"",
            ""pollutant"": ""PM10"",
            ""limit"": 50,
            ""percent"": 45.43,
            ""averaging"": ""24h""
          }
        ]
      },
      {
        ""fromDateTime"": ""2020-06-21T01:00:00.000Z"",
        ""tillDateTime"": ""2020-06-21T02:00:00.000Z"",
        ""values"": [
          {
            ""name"": ""PM25"",
            ""value"": 15.33
          },
          {
            ""name"": ""PM10"",
            ""value"": 23.07
          }
        ],
        ""indexes"": [
          {
            ""name"": ""AIRLY_CAQI"",
            ""value"": 25.56,
            ""level"": ""LOW"",
            ""description"": ""Air is quite good."",
            ""advice"": ""Do you smell it? That's the smell of clean air. :)"",
            ""color"": ""#D1CF1E""
          }
        ],
        ""standards"": [
          {
            ""name"": ""WHO"",
            ""pollutant"": ""PM25"",
            ""limit"": 25,
            ""percent"": 61.34,
            ""averaging"": ""24h""
          },
          {
            ""name"": ""WHO"",
            ""pollutant"": ""PM10"",
            ""limit"": 50,
            ""percent"": 46.15,
            ""averaging"": ""24h""
          }
        ]
      },
      {
        ""fromDateTime"": ""2020-06-21T02:00:00.000Z"",
        ""tillDateTime"": ""2020-06-21T03:00:00.000Z"",
        ""values"": [
          {
            ""name"": ""PM25"",
            ""value"": 15.13
          },
          {
            ""name"": ""PM10"",
            ""value"": 23.38
          }
        ],
        ""indexes"": [
          {
            ""name"": ""AIRLY_CAQI"",
            ""value"": 25.22,
            ""level"": ""LOW"",
            ""description"": ""Air is quite good."",
            ""advice"": ""Don't miss this day! The clean air calls!"",
            ""color"": ""#D1CF1E""
          }
        ],
        ""standards"": [
          {
            ""name"": ""WHO"",
            ""pollutant"": ""PM25"",
            ""limit"": 25,
            ""percent"": 60.52,
            ""averaging"": ""24h""
          },
          {
            ""name"": ""WHO"",
            ""pollutant"": ""PM10"",
            ""limit"": 50,
            ""percent"": 46.77,
            ""averaging"": ""24h""
          }
        ]
      },
      {
        ""fromDateTime"": ""2020-06-21T03:00:00.000Z"",
        ""tillDateTime"": ""2020-06-21T04:00:00.000Z"",
        ""values"": [
          {
            ""name"": ""PM25"",
            ""value"": 14.98
          },
          {
            ""name"": ""PM10"",
            ""value"": 23.41
          }
        ],
        ""indexes"": [
          {
            ""name"": ""AIRLY_CAQI"",
            ""value"": 24.97,
            ""level"": ""VERY_LOW"",
            ""description"": ""Great air here today!"",
            ""advice"": ""Enjoy life!"",
            ""color"": ""#6BC926""
          }
        ],
        ""standards"": [
          {
            ""name"": ""WHO"",
            ""pollutant"": ""PM25"",
            ""limit"": 25,
            ""percent"": 59.92,
            ""averaging"": ""24h""
          },
          {
            ""name"": ""WHO"",
            ""pollutant"": ""PM10"",
            ""limit"": 50,
            ""percent"": 46.82,
            ""averaging"": ""24h""
          }
        ]
      },
      {
        ""fromDateTime"": ""2020-06-21T04:00:00.000Z"",
        ""tillDateTime"": ""2020-06-21T05:00:00.000Z"",
        ""values"": [
          {
            ""name"": ""PM25"",
            ""value"": 15.27
          },
          {
            ""name"": ""PM10"",
            ""value"": 22.91
          }
        ],
        ""indexes"": [
          {
            ""name"": ""AIRLY_CAQI"",
            ""value"": 25.45,
            ""level"": ""LOW"",
            ""description"": ""Air is quite good."",
            ""advice"": ""The air is nice and clean today!"",
            ""color"": ""#D1CF1E""
          }
        ],
        ""standards"": [
          {
            ""name"": ""WHO"",
            ""pollutant"": ""PM25"",
            ""limit"": 25,
            ""percent"": 61.08,
            ""averaging"": ""24h""
          },
          {
            ""name"": ""WHO"",
            ""pollutant"": ""PM10"",
            ""limit"": 50,
            ""percent"": 45.82,
            ""averaging"": ""24h""
          }
        ]
      },
      {
        ""fromDateTime"": ""2020-06-21T05:00:00.000Z"",
        ""tillDateTime"": ""2020-06-21T06:00:00.000Z"",
        ""values"": [
          {
            ""name"": ""PM25"",
            ""value"": 14.45
          },
          {
            ""name"": ""PM10"",
            ""value"": 22.59
          }
        ],
        ""indexes"": [
          {
            ""name"": ""AIRLY_CAQI"",
            ""value"": 24.08,
            ""level"": ""VERY_LOW"",
            ""description"": ""Great air here today!"",
            ""advice"": ""Breathe to fill your lungs!"",
            ""color"": ""#6BC926""
          }
        ],
        ""standards"": [
          {
            ""name"": ""WHO"",
            ""pollutant"": ""PM25"",
            ""limit"": 25,
            ""percent"": 57.79,
            ""averaging"": ""24h""
          },
          {
            ""name"": ""WHO"",
            ""pollutant"": ""PM10"",
            ""limit"": 50,
            ""percent"": 45.17,
            ""averaging"": ""24h""
          }
        ]
      },
      {
        ""fromDateTime"": ""2020-06-21T06:00:00.000Z"",
        ""tillDateTime"": ""2020-06-21T07:00:00.000Z"",
        ""values"": [
          {
            ""name"": ""PM25"",
            ""value"": 14.57
          },
          {
            ""name"": ""PM10"",
            ""value"": 21.65
          }
        ],
        ""indexes"": [
          {
            ""name"": ""AIRLY_CAQI"",
            ""value"": 24.29,
            ""level"": ""VERY_LOW"",
            ""description"": ""Great air here today!"",
            ""advice"": ""The air is grand today. ;)"",
            ""color"": ""#6BC926""
          }
        ],
        ""standards"": [
          {
            ""name"": ""WHO"",
            ""pollutant"": ""PM25"",
            ""limit"": 25,
            ""percent"": 58.29,
            ""averaging"": ""24h""
          },
          {
            ""name"": ""WHO"",
            ""pollutant"": ""PM10"",
            ""limit"": 50,
            ""percent"": 43.29,
            ""averaging"": ""24h""
          }
        ]
      },
      {
        ""fromDateTime"": ""2020-06-21T07:00:00.000Z"",
        ""tillDateTime"": ""2020-06-21T08:00:00.000Z"",
        ""values"": [
          {
            ""name"": ""PM25"",
            ""value"": 14.18
          },
          {
            ""name"": ""PM10"",
            ""value"": 20.41
          }
        ],
        ""indexes"": [
          {
            ""name"": ""AIRLY_CAQI"",
            ""value"": 23.63,
            ""level"": ""VERY_LOW"",
            ""description"": ""Great air here today!"",
            ""advice"": ""Great air!"",
            ""color"": ""#6BC926""
          }
        ],
        ""standards"": [
          {
            ""name"": ""WHO"",
            ""pollutant"": ""PM25"",
            ""limit"": 25,
            ""percent"": 56.7,
            ""averaging"": ""24h""
          },
          {
            ""name"": ""WHO"",
            ""pollutant"": ""PM10"",
            ""limit"": 50,
            ""percent"": 40.82,
            ""averaging"": ""24h""
          }
        ]
      },
      {
        ""fromDateTime"": ""2020-06-21T08:00:00.000Z"",
        ""tillDateTime"": ""2020-06-21T09:00:00.000Z"",
        ""values"": [
          {
            ""name"": ""PM25"",
            ""value"": 13.04
          },
          {
            ""name"": ""PM10"",
            ""value"": 19.82
          }
        ],
        ""indexes"": [
          {
            ""name"": ""AIRLY_CAQI"",
            ""value"": 21.73,
            ""level"": ""VERY_LOW"",
            ""description"": ""Great air here today!"",
            ""advice"": ""Great air!"",
            ""color"": ""#6BC926""
          }
        ],
        ""standards"": [
          {
            ""name"": ""WHO"",
            ""pollutant"": ""PM25"",
            ""limit"": 25,
            ""percent"": 52.15,
            ""averaging"": ""24h""
          },
          {
            ""name"": ""WHO"",
            ""pollutant"": ""PM10"",
            ""limit"": 50,
            ""percent"": 39.64,
            ""averaging"": ""24h""
          }
        ]
      },
      {
        ""fromDateTime"": ""2020-06-21T09:00:00.000Z"",
        ""tillDateTime"": ""2020-06-21T10:00:00.000Z"",
        ""values"": [
          {
            ""name"": ""PM25"",
            ""value"": 13.33
          },
          {
            ""name"": ""PM10"",
            ""value"": 20
          }
        ],
        ""indexes"": [
          {
            ""name"": ""AIRLY_CAQI"",
            ""value"": 22.22,
            ""level"": ""VERY_LOW"",
            ""description"": ""Great air here today!"",
            ""advice"": ""Dear me, how wonderful!"",
            ""color"": ""#6BC926""
          }
        ],
        ""standards"": [
          {
            ""name"": ""WHO"",
            ""pollutant"": ""PM25"",
            ""limit"": 25,
            ""percent"": 53.32,
            ""averaging"": ""24h""
          },
          {
            ""name"": ""WHO"",
            ""pollutant"": ""PM10"",
            ""limit"": 50,
            ""percent"": 40,
            ""averaging"": ""24h""
          }
        ]
      },
      {
        ""fromDateTime"": ""2020-06-21T10:00:00.000Z"",
        ""tillDateTime"": ""2020-06-21T11:00:00.000Z"",
        ""values"": [
          {
            ""name"": ""PM25"",
            ""value"": 13.82
          },
          {
            ""name"": ""PM10"",
            ""value"": 20.2
          }
        ],
        ""indexes"": [
          {
            ""name"": ""AIRLY_CAQI"",
            ""value"": 23.03,
            ""level"": ""VERY_LOW"",
            ""description"": ""Great air here today!"",
            ""advice"": ""Catch your breath!"",
            ""color"": ""#6BC926""
          }
        ],
        ""standards"": [
          {
            ""name"": ""WHO"",
            ""pollutant"": ""PM25"",
            ""limit"": 25,
            ""percent"": 55.28,
            ""averaging"": ""24h""
          },
          {
            ""name"": ""WHO"",
            ""pollutant"": ""PM10"",
            ""limit"": 50,
            ""percent"": 40.4,
            ""averaging"": ""24h""
          }
        ]
      },
      {
        ""fromDateTime"": ""2020-06-21T11:00:00.000Z"",
        ""tillDateTime"": ""2020-06-21T12:00:00.000Z"",
        ""values"": [
          {
            ""name"": ""PM25"",
            ""value"": 13.01
          },
          {
            ""name"": ""PM10"",
            ""value"": 19.4
          }
        ],
        ""indexes"": [
          {
            ""name"": ""AIRLY_CAQI"",
            ""value"": 21.69,
            ""level"": ""VERY_LOW"",
            ""description"": ""Great air here today!"",
            ""advice"": ""Breathe to fill your lungs!"",
            ""color"": ""#6BC926""
          }
        ],
        ""standards"": [
          {
            ""name"": ""WHO"",
            ""pollutant"": ""PM25"",
            ""limit"": 25,
            ""percent"": 52.05,
            ""averaging"": ""24h""
          },
          {
            ""name"": ""WHO"",
            ""pollutant"": ""PM10"",
            ""limit"": 50,
            ""percent"": 38.8,
            ""averaging"": ""24h""
          }
        ]
      },
      {
        ""fromDateTime"": ""2020-06-21T12:00:00.000Z"",
        ""tillDateTime"": ""2020-06-21T13:00:00.000Z"",
        ""values"": [
          {
            ""name"": ""PM25"",
            ""value"": 11.76
          },
          {
            ""name"": ""PM10"",
            ""value"": 18.14
          }
        ],
        ""indexes"": [
          {
            ""name"": ""AIRLY_CAQI"",
            ""value"": 19.61,
            ""level"": ""VERY_LOW"",
            ""description"": ""Great air here today!"",
            ""advice"": ""Breathe as much as you can!"",
            ""color"": ""#6BC926""
          }
        ],
        ""standards"": [
          {
            ""name"": ""WHO"",
            ""pollutant"": ""PM25"",
            ""limit"": 25,
            ""percent"": 47.06,
            ""averaging"": ""24h""
          },
          {
            ""name"": ""WHO"",
            ""pollutant"": ""PM10"",
            ""limit"": 50,
            ""percent"": 36.29,
            ""averaging"": ""24h""
          }
        ]
      }
    ]
}
";
            }

            return null;
        }
    }
}
