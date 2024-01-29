namespace Core.Entities;

public class ClassSchedule
{
    /// <summary>
    /// Идентификатор расписания занятий
    /// </summary>
    public Guid Id { get; set; }
    
    /// <summary>
    /// Дата публикации расписания
    /// </summary>
    public DateTime DateOfPublication { get; set; }
    
    /// <summary>
    /// Идентификатор семестра
    /// </summary>
    public Guid TermId { get; set; }
    
    /// <summary>
    /// Занятия
    /// </summary>
    public List<Class> IdsOfClasses { get; set; } = [];
}