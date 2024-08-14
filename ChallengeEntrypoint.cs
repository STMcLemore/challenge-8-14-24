using System;
using DotnetChallenge.lib;

/*
    Operative! We need you to help us get into Arasaka tower!
    Please complete the challenges to help us get in. Other operatives will
    be working on this at the same as you so some parts will be noted not to touch
    so you don't run into conflicts between each other.
*/

namespace DotnetChallenge
{
    public class HandleChallenge{
        public void EnterTheChallenge() {
            // DO NOT CHANGE! YOU'LL MESS UP THE OTHER OPERATIVES
            Challenge0();
            Challenge1();
            Challenge2();
            Challenge3();
            Challenge4();
            Challenge5();
        }

        void Challenge0() {
            Console.WriteLine(); // TODO part 1 - Add a string of your choice, whatever you want
        }


        /*TODO something is missing*/ Challenge1() {
   
            // objective: You've been tasked with taking an encrypted string that an operative discovered. We need to store it in
            // a List so it can be grabbed by another operative later but some pieces are missing. 
            // See if you can fix it!

            string encryptedString = "c64bd807291151fae7b7cd0c5ede51761f165b231da7bceac64fd90e041344d4";

            List<> listOfEncryptedStrings = ; // TODO part 1 - Make a list that is going to contain strings
            
            listOfEncryptedStrings.Add(); // TODO part 2 - We need to add the encrypted string to this list

            return listOfEncryptedStrings;
        }

        void Challenge2() {
            // objective: We have a series of encoded data someone ripped off a server. 
            // We have a loop that is supposed to process the data and print it out but
            // some pieces are missing. 
            // See if you can fix it!

            string[] encodedStrings = {
                "R2V0IGtpcm9zaGkgZXllcyBxdWljayE=",
                "TmV1cm9tYW5jZXIgY29udHJvbHMgYWxs",
                "WWVzLCBJIGFtIGEgY3JpbWluYWwuIE15IGNyaW1lIGlzIHRoYXQgb2YgY3VyaW9zaXR5LiBJIGFtIGEgaGFja2VyLCBhbmQgdGhpcyBpcyBteSBtYW5pZmVzdG8u"
            };

            foreach(int encodedStr in encodedStrings) {  // TODO - hmmm...something is wonky..
                byte[] data = Convert.FromBase64String(encodedStr);
                string decodedString = System.Text.Encoding.UTF8.GetString(data);
                
                Console.WriteLine("Is something missing?? Where's my data!?"); // TODO - You probably want to print out each decoded string
            }
        }

        void Challenge3() {
            // objective: The compiler is broken! Arasaka was able to blast parts of it
            // and break some of the functionality. We can't use the foreach anymore in
            // this challenge until it's fixed.
            // While an operative fixes this we need you to use the old for loop to process the data, hurry up!

            string[] secretStrings = {
                "VGhlIHNreSBhYm92ZSB0aGUgcG9ydCB3YXMgdGhlIGNvbG9yIG9mIHRlbGV2aXNpb24sIHR1bmVkIHRvIGEgZGVhZCBjaGFubmVsLg==",
                "Q3liZXJzcGFjZS4gQSBjb25zZW5zdWFsIGhhbGx1Y2luYXRpb24gZXhwZXJpZW5jZWQgZGFpbHkgYnkgYmlsbGlvbnMgb2YgbGVnaXRpbWF0ZSBvcGVyYXRvcnMsIGluIGV2ZXJ5IG5hdGlvbiwgYnkgY2hpbGRyZW4gYmVpbmcgdGF1Z2h0IG1hdGhlbWF0aWNhbCBjb25jZXB0cw==",
                "V2hlbiB0aGUgcGFzdCBpcyBhbHdheXMgd2l0aCB5b3UsIGl0IG1heSBhcyB3ZWxsIGJlIHByZXNlbnQ7IGFuZCBpZiBpdCBpcyBwcmVzZW50LCBpdCB3aWxsIGJlIGZ1dHVyZSBhcyB3ZWxsLg=="
            };

            for (int  = 0; index < 3; index++) {
                string secret = secretStrings[SOMETHING]; // TODO - I think SOMETHING is off *wink*
                byte[] data = Convert.FromBase64String(secret);
                string decodedString = System.Text.Encoding.UTF8.GetString(data);
                
                Console.WriteLine("Is something missing?? Where's my data!?"); // TODO - You probably want to print out each decoded string
            }
        }

        void Challenge4() {
            // objective: We have a list of ICE (Intrusion Countmeasure Electronics) locations that
            // are blocking the way for further intrusion.
            // Another operative is working to build out the ICE Breaker so don't worry about it.
            // We need you to fix the while loop so our ICE Breaker can work!

            string[] iceLocations = {
                "0x01547832",
                "0x01489AE4",
                "0x04A4B334",
                "0x04EA2314"
            };

            int index = 0;
            while( < iceLocations.Length) { // TODO: What's missing?
                string iceLocation = iceLocations[SOMETHING]; // TODO: SOMETHING is definitely off...
                IceBreaker.BreakIce(iceLocation);
                
                index--; // TODO: Something is off here? How many times is this loop going to iterate?
            }
        }

        void Challenge5() {
            // objective: We have a list of vulnerable users that we can use to pivot
            // and escalate our permissions but it needs processed (looped) and printed out.
            // Get to work!

            string[] vulnerableUsers = {
                "Jim Smith",
                "James Frank",
                "William Gibson",
                "Alice the Cool",
                "Christina Speakeasy"
            };

            // TODO: we have the data but it needs to be looped and printed...hmm....
        }
    }
}