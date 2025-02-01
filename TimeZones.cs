using System;
class TimeZones{
    static void Main(string[] args){
        //get the current UTC time
        DateTimeOffset utcNow = DateTimeOffset.UtcNow;
        Console.WriteLine("UTC Time: {0 :yyyy-MM-dd HH:mm:ss zzz}",utcNow);

        //convert to GMT
        DateTimeOffset gmtTime = TimeZoneInfo.ConvertTimeBySystemTimeZoneId(utcNow, "UTC");
        Console.WriteLine("GMT Time: {0 :yyyy-MM-dd HH:mm:ss zzz}",gmtTime);

        //convert to IST
        TimeZoneInfo istZone = TimeZoneInfo.FindSystemTimeZoneById("India Standard Time");
        DateTimeOffset istTime = TimeZoneInfo.ConvertTime(utcNow, istZone);
        Console.WriteLine("IST Time: {0 :yyyy-MM-dd HH:mm:ss zzz}",istTime);

        //convert to PST
        TimeZoneInfo pstZone = TimeZoneInfo.FindSystemTimeZoneById("Pacific Standard Time");
        DateTimeOffset pstTime = TimeZoneInfo.ConvertTime(utcNow, pstZone);
        Console.WriteLine("PST Time: {0 :yyyy-MM-dd HH:mm:ss zzz}",pstTime);
    }
}


