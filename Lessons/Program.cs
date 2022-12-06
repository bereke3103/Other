using System;
using lessons.Domain;
using lessons.Domain.Factories;

class Program
{
    static void Main()
    {
        Console.WriteLine("Здравствуйте, выберите Зал, в котором вы хотите заниматься");
        Console.WriteLine("g - Gym, p - Gym and Pool, t - personal Trainings");

        string membershipType = Console.ReadLine();

        MembershipFactory factory = GetFactory(membershipType);
        IMembership membership = factory.GetMembership();

        Console.WriteLine(
            
            $"{membership.Name}"+
            $"{membership.Description}"+
            $"{membership.GetPrice()}"
            );
    }

    private static MembershipFactory GetFactory(string membershipType) =>
        membershipType.ToLower() switch
        {
            "g" => new GymMembershipFactory(100, "Basic Membership"),
            "p" => new GymPlusPoolFactory(200, "Pool Membership"),
            "t" => new PersonalTrainingsFactory(100, "Personal trainings Membership"),
            _ => null
        };
}