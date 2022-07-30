using GigHub.Core.Models;

namespace GigHub.Core.Repositories
{
    public interface IFollowingRepository
    {
        void Add(Following following);
        Following GetFollowing(string followerId, string followeeId);
        void Remove(Following following);
    }
}
