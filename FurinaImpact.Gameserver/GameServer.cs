﻿using FurinaImpact.Gameserver.Network;
using Microsoft.Extensions.Hosting;

namespace FurinaImpact.Gameserver;
internal class GameServer : IHostedService
{
    private readonly IGateway _gateway;

    public GameServer(IGateway gateway)
    {
        _gateway = gateway;
    }

    public async Task StartAsync(CancellationToken cancellationToken)
    {
        await _gateway.Start();
    }

    public async Task StopAsync(CancellationToken cancellationToken)
    {
        await _gateway.Stop();
    }
}