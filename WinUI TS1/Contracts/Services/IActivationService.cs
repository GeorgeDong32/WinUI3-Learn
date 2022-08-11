namespace WinUI_TS1.Contracts.Services;

public interface IActivationService
{
    Task ActivateAsync(object activationArgs);
}
