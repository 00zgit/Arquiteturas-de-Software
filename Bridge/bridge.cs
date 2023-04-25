// client code
using ConsoleApp1;

Ar ar = new Ar();
TemperatureRemoteControl temperatureControl = new(ar);
temperatureControl.TurnOn(18);

Luz luz = new Luz();
RemoteControl control = new(luz);
control.TurnON();
//$end

internal class Ar : Device
{
    public Ar() { }

    
    public void TurnON(int value)
    {
        ///
    }
    public void TurnOFF()
    {
        ///
    }
    public void TurnON()
    {
        throw new NotImplementedException();
    }
}


internal interface Device
{
    void TurnON();
    void TurnON(int value);
    void TurnOFF();
}

internal class Luz : Device
{
    public void TurnOFF()
    {
        ///
    }

    public void TurnON()
    {
        ///
    }

    public void TurnON(int value)
    {
        throw new NotImplementedException();
    }
}

internal class RemoteControl
{
    protected Device Device;
    public RemoteControl(Device iDevice)
    {
        Device = iDevice;
    }

    internal void TurnON()
    {
        Device.TurnON();
    }
    internal void TurnOFF()
    {
        Device.TurnOFF();
    }
}

internal class TemperatureRemoteControl : RemoteControl
{
    public TemperatureRemoteControl(Device iDevice) : base(iDevice) { }

    public void TurnOn(int value)
    {
        Device.TurnON(value);
    }
}