using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common
{
    public interface IDbHandler
    {
        User GetUser(Guid userId);

        IEnumerable<Tag> GetTagsByUser(Guid userId);

        IEnumerable<Tag> GetAllTags();

        IEnumerable<User> GetUsersByTags(IEnumerable<Tag> tags);

        IEnumerable<User> GetUsersByString(string str);

        Tag GetTag(string tagText);

        IEnumerable<Tag> GetAllTagsInCategory(string categoryName);

        void AddNewTag(Tag newTag);
    }
}
