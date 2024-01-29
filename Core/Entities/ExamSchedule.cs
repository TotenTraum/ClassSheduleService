namespace Core.Entities;

public class ExamSchedule
{
    /// <summary>
    /// Идентификатор расписания экзаменов
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
    /// Экзамены
    /// </summary>
    public List<Exam> IdsOfExams { get; set; } = [];
}