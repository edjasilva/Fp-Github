public class Task{
    private static int next_id = 1;
    public int Id {set; get;}
    public string Description {set; get;}

    public Task(string description){
        Id = Task.next_id;
        Description = description;
        next_id++;
    }

}