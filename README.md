WeatherLambda

An Amazon AWS Lambda Function which uses the openweathermap.org's Current Weather request to retreive details of the weather at a passed zip code.  This lambda function is intended to be called from a Amazon Connect Contact Flow.

You will need to register at openweathermap.org to get a free account App ID that you'll need to use with this code.

This Visual Studio 2017 solution contains three projects:
- WeatherLibrary
  A .NET Standard library written in C# that handles open weather map requests.
- WeatherLibraryForm
  A .NET Framework Forms application written in C# that acts as a simple test application for the WeatherLibrary.
- WeatherLambda
  A .NET Core library which provides the Lambda Function interface.

The Lambda function should be configured with one environment variable named OpenWeatherAppID containing an Open Weather App ID needed to authenticate the weather requests.

When using the Forms test application, you'll need to configure the WeatherForm.Properties.Settings.setting property named OpenWeatherAppID with the same Open Weather App ID.

This function is intended to be called from Amazon Connect it must be accept the standard JSON request data passed by Amazon Connect call flow when a Lambda function is invoked.

The function expects input in JSON format, at a minimum, as shown below.
{
   "Details": {
      "Parameters": {
         "ZipCode": "10118"
      }    
   }
}

The function returns a Connect compatible JSON formatted result containing a single property named message:
{
   "message": "\"The weather in New York is clear with a temperature of 57 degrees.\""
}

When used from an Amazon Connect Call Flow, the results would be accessed as the External Attribute "message".

Links
-----
Using AWS Lambda Functions with Amazon Connect:  https://docs.aws.amazon.com/connect/latest/adminguide/connect-lambda-functions.html

Open Weather Map:  https://openweathermap.org/

Open Weather Map Current Weather Data API used by this code:  https://openweathermap.org/current
