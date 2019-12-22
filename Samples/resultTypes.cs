// 1) return value

public int Sum(int first, int second) 
    => first + second;

int result = Sum(12, 23);

Assert.Equal(result, 35);

// 2) change a state

public class StringBuilder
{
    private List<char> _buffer;

    public string Text => new string(_buffer);

    public void AppendText(string text)
        =>  _buffer.AddRange(text.ToCharArray());
}

StringBuilder builder = new StringBuilder()
    .Append("abc")
    .Append("def");

string result = builder.Text;

Assert.Equal(result, "abcdef");

// 3) call external service or library

public class CpuMonitor
{
    private readonly ICpuDriver _cpuDriver;

    public CpuMonitor(ICpuDriver cpuDriver)
    {
        _cpuDriver = cpuDriver;
    }

    public void CheckTemperature(int temperature)
    {
        if (temperature > 60)
        {
            _cpuDriver.SlowDownByPercent(10);
        }
        else (temperature > 80)
        {
            _cpuDriver.Stop();
        }
    }
}

ICpuDriver cpuDriver = Mock<ICpuDriver>();

new CpuMonitor(cpuDriver)
    .CheckTemperature(70);

cpuDriver.SlowDownByPercent(10).Received(1);
cpuDriver.Stop().NotReceived();