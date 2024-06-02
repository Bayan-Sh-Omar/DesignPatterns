using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartCity.Business.SmartBuilding
{
    public class AlarmControlClient
    {
        public static void Apply()
        {
            // Create notification methods
            INotification smsNotification = new SMSNotification();
            INotification emailNotification = new EmailNotification();

            // Create alarm controls
            IAlarmControl fireAlarmWithSMS = new FireAlarmControl(smsNotification);
            IAlarmControl fireAlarmWithEmail = new FireAlarmControl(emailNotification);
            IAlarmControl securityAlarmWithSMS = new SecurityAlarmControl(smsNotification);
            IAlarmControl securityAlarmWithEmail = new SecurityAlarmControl(emailNotification);

            // Control the alarms
            Console.WriteLine("Fire Alarm with SMS Notification:");
            fireAlarmWithSMS.Activate();
            fireAlarmWithSMS.Notify();
            fireAlarmWithSMS.Deactivate();

            Console.WriteLine("\nFire Alarm with Email Notification:");
            fireAlarmWithEmail.Activate();
            fireAlarmWithEmail.Notify();
            fireAlarmWithEmail.Deactivate();

            Console.WriteLine("\nSecurity Alarm with SMS Notification:");
            securityAlarmWithSMS.Activate();
            securityAlarmWithSMS.Notify();
            securityAlarmWithSMS.Deactivate();

            Console.WriteLine("\nSecurity Alarm with Email Notification:");
            securityAlarmWithEmail.Activate();
            securityAlarmWithEmail.Notify();
            securityAlarmWithEmail.Deactivate();
        }
    }
}

