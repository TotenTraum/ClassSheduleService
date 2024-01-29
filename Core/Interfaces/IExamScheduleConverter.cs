using Core.Entities;

namespace Core.Interfaces;

public interface IExamScheduleConverter
{
    public Stream ConvertAsStream(ExamSchedule schedule);
    public byte[] ConvertAsByteArray(ExamSchedule schedule);
}