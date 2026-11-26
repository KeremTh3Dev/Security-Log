#region
// This file contains the violation user have done
#endregion

namespace SecurityLog.Models
{
    public class UserViolationsLog
    {
        public Dictionary<ViolationCategory, List<DateTime>> Violations { get; } = new();

        public void Record(ViolationCategory category, DateTime? timestamp = null)
        {
            if (category == ViolationCategory.None)
                return;

            if (!Violations.TryGetValue(category, out var timestamps))
            {
                timestamps = new List<DateTime>();
                Violations[category] = timestamps;
            }

            timestamps.Add(timestamp ?? DateTime.UtcNow);
        }
    }
}