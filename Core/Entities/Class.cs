namespace Core.Entities;

public class Class
{
    /// <summary>
    /// Идентификатор занятия
    /// </summary>
    public Guid Id { get; set; }

    /// <summary>
    /// День недели
    /// </summary>
    public DayOfWeek DayOfWeek { get; set; }

    /// <summary>
    /// Тип занятия
    /// </summary>
    public ClassType Type { get; set; }

    /// <summary>
    /// Флаг четности недели
    /// </summary>
    public bool IsEvenWeek { get; set; }

    #region references
    
    /// <summary>
    /// Идентификатор временного интервала
    /// </summary>
    public int IntervalId { get; set; }

    /// <summary>
    /// Идентификатор преподавателя
    /// </summary>
    public Guid TeacherId { get; set; }

    /// <summary>
    /// Идентификатор дисциплины
    /// </summary>
    public Guid DisciplineId { get; set; }

    /// <summary>
    /// Идентификатор аудитории
    /// </summary>
    public Guid ClassRoomId { get; set; }

    /// <summary>
    /// Идентификатор расписания
    /// </summary>
    public Guid ScheduleId { get; set; }

    /// <summary>
    /// Идентификатор группы студентов
    /// </summary>
    public Guid GroupOfStudentsId { get; set; }

    #endregion
}