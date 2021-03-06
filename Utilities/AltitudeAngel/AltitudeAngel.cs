﻿using System;
using System.Text;
using System.Windows.Forms;
using AltitudeAngelWings;
using AltitudeAngelWings.ApiClient.Client;
using AltitudeAngelWings.Service;
using AltitudeAngelWings.Service.FlightData;
using AltitudeAngelWings.Service.FlightData.Providers;
using AltitudeAngelWings.Service.Messaging;
using MissionPlanner.Controls;

namespace MissionPlanner.Utilities.AltitudeAngel
{
    public class AltitudeAngel
    {
        private static MissionPlanner MP = new MissionPlanner();
        private static MessagesService Message = new MessagesService();

        public static AltitudeAngelService service = null;

        static AltitudeAngel()
        {
            service = new AltitudeAngelService(Message, MP,
                new FlightDataService(new ObservableProperty<long>(), new MissionPlannerFlightDataProvider(null)));
        }
    }
}