public class AttendanceService
{
    private List<string> participants = new List<string>();

    public IReadOnlyList<string> Participants => participants.AsReadOnly();

    public void RegisterParticipant(string participant)
    {
        if (!participants.Contains(participant))
        {
            participants.Add(participant);
        }
    }
}
