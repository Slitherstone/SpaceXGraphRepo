using System;
using SpaceX.Interface;

namespace SpaceX.Service;

public class ApplicationService : IApplicationService
{
    private readonly IConfiguration _config;

    public ApplicationService(IConfiguration config)
    {
        _config = config;
    }


    public async Task ApplicationRun()
    {
        

    }

}
