namespace CS02POO.DomainExamples;

public class RichTask
{
    #region Properties

    public int Id { get; private set; }
    public string Name { get; private set; }
    public DateTime AppointmentDate { get; private set; }
    public SituationEnum Situation { get; private set; }
    public DateTime ConclusionDate { get; private set; }

    #endregion

    #region Constructors

    public RichTask()
    {
        AppointmentDate = DateTime.Now;
        Situation = SituationEnum.NotStated;
    }

    public RichTask(int id, string name) : this()
    {
         Id = id;
        Name = name;
    }

    #endregion

    #region Methods

    public void ChangeAppointmetDate(DateTime newDate)
    {
        AppointmentDate = newDate;
    }

    public void ProcessTask()
    {
        Situation = SituationEnum.InProgress;
    }

    public void StopTask()
    {
        Situation = SituationEnum.Pending;
    }

    public void FinishTask()
    {
        Situation = SituationEnum.Done;
        ConclusionDate = DateTime.Now;
    }

    #endregion
}