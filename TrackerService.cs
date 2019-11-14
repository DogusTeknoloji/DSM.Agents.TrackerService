using DSM.Controller.Tracker.Shared;

namespace DSM.Agents.TrackerService
{
    public class TrackerService : DSMAgent
    {
        public TrackerService() : base("DSM.Agents.TrackerService") { }

        public override void ActionMain(object authObj)
        {
            string apiKey = (string)authObj;

            TrackerEngine wcfTracker = new TrackerEngine(apiKey, TrackerType.Endpoint);
            wcfTracker.PostTrackerValues();

            TrackerEngine connectionStringTracker = new TrackerEngine(apiKey, TrackerType.ConnectionString);
            connectionStringTracker.PostTrackerValues();
        }
    }
}
