public class UserRepository : IUserRepository
{
    private readonly Dictionary<int, User> _users = new();
    private int _nextId = 1;

    public IEnumerable<User> GetAll() => _users.Values;

    public User? GetById(int id) => _users.TryGetValue(id, out var user) ? user : null;

    public void Add(User user)
    {
        user.Id = _nextId++;
        _users[user.Id] = user;
    }

    public void Update(User user)
    {
        if (_users.ContainsKey(user.Id))
        {
            _users[user.Id] = user;
        }
    }

    public void Delete(int id)
    {
        _users.Remove(id);
    }
}
