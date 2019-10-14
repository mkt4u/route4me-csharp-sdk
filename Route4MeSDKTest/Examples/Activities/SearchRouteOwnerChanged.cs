﻿using Route4MeSDK.DataTypes;
using Route4MeSDK.QueryTypes;
using System;

namespace Route4MeSDK.Examples
{
    public sealed partial class Route4MeExamples
    {
        /// <summary>
        /// Get Activities Route Owner Changed
        /// </summary>
        public void SearchRouteOwnerChanged()
        {
            // Create the manager with the api key
            Route4MeManager route4Me = new Route4MeManager(c_ApiKey);

            ActivityParameters activityParameters = new ActivityParameters
            {
                ActivityType = "route-owner-changed",
                RouteId = "5C15E83A4BE005BCD1537955D28D51D7"
            };

            // Run the query
            string errorString = "";
            Activity[] activities = route4Me.GetActivityFeed(activityParameters, out errorString);

            Console.WriteLine("");

            if (activities != null)
            {
                Console.WriteLine("SearchRouteOwnerChanged executed successfully, {0} activities returned", activities.Length);
                Console.WriteLine("");

                foreach (Activity Activity in activities)
                {
                    Console.WriteLine("Activity ID: {0}", Activity.ActivityId);
                }
                Console.WriteLine("");
            }
            else
            {
                Console.WriteLine("SearchRouteOwnerChanged error: {0}", errorString);
            }

        }
    }
}
