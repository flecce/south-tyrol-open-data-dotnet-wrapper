# Simple South Tyrol Open Data .NET wrapper (draft)

Simple library to use the South Tyrol open data (V2) with .NET framework.
Below the official site of open data.
https://opendatahub.readthedocs.io/en/latest/index.html

## Abstract
South Tyrol open data offers a single access point to all (Open) Data from the region of South Tyrol,
Italy, that are relevant for the economy sector and its actors.
The main domains are:

- Mobility: this domain contains data about public transportation, parkings, charging station, and so on
- Tourism (**not implemented**): data about events, accomodations, points of interest, and so on

### Mobility

#### Traffic stations
- EnvironmentStation
- LinkStation
- ParkingStation
- ParkingSensor
- RWISstation
- Streetstation
- BluetoothStation
- MeteoStation

#### Mobility stations
- CarpoolingHub
- CarpoolingService
- CarpoolingUser
- Bicycle
- BikesharingStation
- Bicyclestationbay
- CarSharingStation
- EChargingPlug
- EChargingStation

## How to build
Clone the repository and build the solution.

## JSON response schema
The overall structure of the JSON is the following:
```json
    {
        "data": [],
        "offset": 0,
        "limit": 200
    }
```

## Make a request
Below some request examples:

Getting Charging Stations:
```csharp
    var mobilityService = new MobilityService();
    var result = mobilityService.Get<MobilityStationTypeResponse<ChargingStation>>(RequestBase.Create(RepresentationType.Flat, new string[] { StationType.EChargingStation, StationType.ECharingPlug })).Result;
```

Getting filtered Environment Data:
```csharp
    var mobilityService = new MobilityService();
    var result = mobilityService.Get<MobilityDataTypeResponse<NullMetadata>>(
        RequestBase.Create(
            RepresentationType.Flat,
            new string[] { StationType.EnvironmentStation },
            new string[] { DataType.EnvironmentStation.All },
            null,
            new WhereClause(new OrElse(
                new FilterTriple("scode", OperatorType.Eq, "BZ5"),
                new FilterTriple("scode", OperatorType.Eq, "BZ6"))
            )
        )).Result;
```

## Contributing
- Report any issues
- Implementing some any other data domains
- Adding unit tests
