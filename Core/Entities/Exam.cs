namespace Core.Entities;

public class Exam
{
    /// <summary>
    /// Идентификатор экзамена
    /// </summary>
    public Guid Id { get; set; }

    /// <summary>
    /// Тип экзамена
    /// </summary>
    public ExamType Type { get; set; }

    /// <summary>
    /// Дата проведения
    /// </summary>
    public DateOnly DateOfExam { get; set; }
    
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
    /// TODO Добавить таблицу в диаграмму ER
    public Guid ScheduleId { get; set; }

    /// <summary>
    /// Идентификатор группы студентов
    /// </summary>
    public Guid GroupOfStudentsId { get; set; }

    #endregion
}