namespace Core.Entities;

/// <summary>
/// Семестр 
/// </summary>
public class Term
{
    /// <summary>
    /// Идентификатор семестра
    /// </summary>
    public Guid Id { get; set; }

    /// <summary>
    /// Год, в котором проходит семестр
    /// </summary>
    public short Year { get; set; }

    /// <summary>
    /// Флаг полугодия
    /// </summary>
    public bool IsFirstHalfOfYear { get; set; }

    /// <summary>
    /// Идентификаторы расписаний занятий
    /// </summary>
    public List<ClassSchedule> IdsOfClassSchedules { get; set; } = [];

    /// <summary>
    /// Идентификаторы расписаний экзаменов
    /// </summary>
    public List<ExamSchedule> IdsOfExamSchedules { get; set; } = [];
}