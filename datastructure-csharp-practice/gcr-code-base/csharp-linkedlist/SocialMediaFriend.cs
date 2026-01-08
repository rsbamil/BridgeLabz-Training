using System;

// This class represents one user in social media
class UserNode
{
    public int UserId;
    public string Name;
    public int FriendCount;   // number of friends
    public UserNode Next;     // link to next user

    public UserNode(int id, string name)
    {
        UserId = id;
        Name = name;
        FriendCount = 0;
        Next = null;
    }
}

// This class manages all users
class SocialMedia
{
    private UserNode head = null;

    // Add a new user
    public void AddUser(int id, string name)
    {
        UserNode node = new UserNode(id, name);
        node.Next = head;
        head = node;
    }

    // Add friend connection (increase count)
    public void AddFriend(int userId)
    {
        UserNode temp = head;

        while (temp != null)
        {
            if (temp.UserId == userId)
            {
                temp.FriendCount++;
                return;
            }
            temp = temp.Next;
        }
    }

    // Display all users and their friend count
    public void DisplayUsers()
    {
        UserNode temp = head;

        while (temp != null)
        {
            Console.WriteLine("User: " + temp.Name + ", Friends: " + temp.FriendCount);
            temp = temp.Next;
        }
    }
}

// Main class
class SocialMediaFriend
{
    static void Main()
    {
        SocialMedia sm = new SocialMedia();

        sm.AddUser(1, "RK");
        sm.AddUser(2, "Bhanu");

        sm.AddFriend(1);
        sm.AddFriend(1);
        sm.AddFriend(2);

        sm.DisplayUsers();
    }
}