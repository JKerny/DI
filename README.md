# DI

A really easy way to visualise the differences between scoped, transient and singleton objects.

Explanation of different types of service registration 

 - Transient objects are always different; a new instance is provided to every controller and every service.
 - Scoped objects are the same within a request, but different across different requests.
 - Singleton objects are the same for every object and every request.
 
## Instructions

 - Project runs normally. Press start in visual studio or type "dotnet run" in command line
 - Counter Service is registered as a singleton by default and the program behaves as expected in this mode. Click the button and the count increments
 - Change registration to scoped or transient (in Startup.cs) and see how the behvior changes 