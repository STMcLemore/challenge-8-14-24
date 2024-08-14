// See https://aka.ms/new-console-template for more information
using System;

namespace DotnetChallenge
{
    internal class Program
    {
        static void Main(string[] args)
        {
            HandleChallenge challenge = new HandleChallenge();
            challenge.EnterTheChallenge();
        }
    }
}