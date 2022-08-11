﻿using Microsoft.UI.Xaml;

using WinUI_TS1.Contracts.Services;
using WinUI_TS1.ViewModels;

namespace WinUI_TS1.Activation;

public class DefaultActivationHandler : ActivationHandler<LaunchActivatedEventArgs>
{
    private readonly INavigationService _navigationService;

    public DefaultActivationHandler(INavigationService navigationService)
    {
        _navigationService = navigationService;
    }

    protected override bool CanHandleInternal(LaunchActivatedEventArgs args)
    {
        // None of the ActivationHandlers has handled the activation.
        return _navigationService.Frame?.Content == null;
    }

    protected async override Task HandleInternalAsync(LaunchActivatedEventArgs args)
    {
        _navigationService.NavigateTo(typeof(ListDetailsViewModel).FullName!, args.Arguments);

        await Task.CompletedTask;
    }
}
