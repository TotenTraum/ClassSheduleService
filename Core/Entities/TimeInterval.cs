namespace Core.Entities;

/// <summary>
/// Временной интервал
/// </summary>
public class TimeInterval
{
    /// <summary>
    /// Идентификатор интервала
    /// </summary>
    public int Id { get; set; }

    /// <summary>
    /// Номер интервала по счету(1 пара)
    /// </summary>
    public int Number { get; set; }

    /// <summary>
    /// Начало временного интервала 
    /// </summary>
    public TimeOnly Beginning { get; set; }

    /// <summary>
    /// Длительность временного интервала в минутах
    /// </summary>
    public short DurationInMin { get; set; }
}