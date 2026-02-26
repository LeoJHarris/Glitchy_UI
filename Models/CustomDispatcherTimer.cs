namespace Glitchy_UI.Models;

public class CustomDispatcherTimer(IDispatcherTimer? dispatcherTimer, TimeSpan timeSpan, Action callback)
{
    private readonly Action _callback = callback;
    private readonly CancellationTokenSource? _cancellationTokenSource = new();
    private readonly IDispatcherTimer? _dispatcherTimer = dispatcherTimer;
    private readonly TimeSpan _timespan = timeSpan;
    private EventHandler? _tickHandler;

    public void Restart()
    {
        Stop();
        Start();
    }

    public void Start(bool shouldRepeat = false)
    {
        if (_dispatcherTimer?.IsRunning == true)
        {
            return;
        }

        CancellationTokenSource cts = _cancellationTokenSource ?? new CancellationTokenSource();

        if (_dispatcherTimer is not null)
        {
            // Un-sub the previous event handler if it exists
            if (_tickHandler != null)
            {
                _dispatcherTimer.Tick -= _tickHandler;
            }

            // Create a new event handler
            _tickHandler = (s, e) => _callback.Invoke();

            _dispatcherTimer.Interval = _timespan;
            _dispatcherTimer.Tick += _tickHandler;
            _dispatcherTimer.IsRepeating = shouldRepeat;
            _dispatcherTimer.Start();
        }
    }

    public void Stop()
    {
        if (_dispatcherTimer is not null && _tickHandler != null)
        {
            _dispatcherTimer.Tick -= _tickHandler;
        }

        _dispatcherTimer?.Stop();
    }
}