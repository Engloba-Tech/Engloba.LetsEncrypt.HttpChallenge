# Engloba Let's Encrypt HttpChallenge
\
\
This middleware maps an endpoint in our asp.net application for resolving the HttpChallenge required to set up an SSL Certificate in your asp.net application host.
[Let's Encrypt Challenge Types](https://letsencrypt.org/es/docs/challenge-types/)


## Install

`Install-Package Engloba.LetsEncrypt.HttpChallenge`


## Usage


```
public void ConfigureServices(IServiceCollection services)
{
    services.AddLetsEncryptHttpChallenge();
    ...
}
```

```
public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
{
      app.UseLetsEncryptChallange();
    ...
}
```

## Settings

This middleware is expecting that your appsettings to have this section.


```
"LetsEncrypt": {
    "HttpChallengeEndpoint": "Endpoint",
    "HttpChallengeKey": "Key"
 }
```


