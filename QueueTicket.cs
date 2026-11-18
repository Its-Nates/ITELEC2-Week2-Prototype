namespace Week2_Prototype;

public class QueueTicket
{
    public string TicketNumber { get; }
    public string StudentNumber { get; }
    public string StudentName { get; }
    public DateTime CreatedAt { get; }
    public string Status { get; private set; }

    public QueueTicket(string ticketNumber, string studentNumber, string studentName)
    {
        TicketNumber = ticketNumber;
        StudentNumber = studentNumber;
        StudentName = studentName;
        CreatedAt = DateTime.Now;
        Status = "Waiting";
    }

    // A ticket can only be called while it is waiting.
    public bool Call()
    {
        if (Status != "Waiting")
            return false;

        Status = "Called";
        return true;
    }

    // A ticket can only enter service after it has been called.
    public bool StartService()
    {
        if (Status != "Called")
            return false;

        Status = "In Service";
        return true;
    }

    // A ticket can only be completed while it is being served.
    public bool Complete()
    {
        if (Status != "In Service")
            return false;

        Status = "Completed";
        return true;
    }

    public bool PutOnHold()
    {
        if (Status != "Waiting" && Status != "Called")
            return false;

        Status = "On Hold";
        return true;
    }

    public string GetTicketInfo()
    {
        return $"Ticket: {TicketNumber} | Student: {StudentName} ({StudentNumber}) | Status: {Status}";
    }
}
