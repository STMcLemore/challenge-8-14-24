using System;
using DotnetChallenge.lib;




namespace DotnetChallenge
{
    public class HandleChallenge{
    
       
        public void EnterTheChallenge() {
            
            Challenge0();
            Challenge1();
            Challenge2();
            Challenge3();
            Challenge4();
            Challenge5();
        }

        void Challenge0() {
            Console.WriteLine("Hello There"); 
        }


         List<string> Challenge1() 
         {

            string encryptedString = "c64bd807291151fae7b7cd0c5ede51761f165b231da7bceac64fd90e041344d4";

            List<string> listOfEncryptedStrings = new List<string>() ;
            
            listOfEncryptedStrings.Add(encryptedString);

            return listOfEncryptedStrings;
         }

        void Challenge2() 
        {


            string[] encodedStrings = {
                "R2V0IGtpcm9zaGkgZXllcyBxdWljayE=",
                "TmV1cm9tYW5jZXIgY29udHJvbHMgYWxs",
                "WWVzLCBJIGFtIGEgY3JpbWluYWwuIE15IGNyaW1lIGlzIHRoYXQgb2YgY3VyaW9zaXR5LiBJIGFtIGEgaGFja2VyLCBhbmQgdGhpcyBpcyBteSBtYW5pZmVzdG8u"
            };

            foreach(string encodedStr in encodedStrings) 
            {
                byte[] data = Convert.FromBase64String(encodedStr);
                string decodedString = System.Text.Encoding.UTF8.GetString(data);
                
                Console.WriteLine(decodedString);
            }
        }

        void Challenge3()
        {



            string[] secretStrings = 
            {
                "VGhlIHNreSBhYm92ZSB0aGUgcG9ydCB3YXMgdGhlIGNvbG9yIG9mIHRlbGV2aXNpb24sIHR1bmVkIHRvIGEgZGVhZCBjaGFubmVsLg==",
                "Q3liZXJzcGFjZS4gQSBjb25zZW5zdWFsIGhhbGx1Y2luYXRpb24gZXhwZXJpZW5jZWQgZGFpbHkgYnkgYmlsbGlvbnMgb2YgbGVnaXRpbWF0ZSBvcGVyYXRvcnMsIGluIGV2ZXJ5IG5hdGlvbiwgYnkgY2hpbGRyZW4gYmVpbmcgdGF1Z2h0IG1hdGhlbWF0aWNhbCBjb25jZXB0cw==",
                "V2hlbiB0aGUgcGFzdCBpcyBhbHdheXMgd2l0aCB5b3UsIGl0IG1heSBhcyB3ZWxsIGJlIHByZXNlbnQ7IGFuZCBpZiBpdCBpcyBwcmVzZW50LCBpdCB3aWxsIGJlIGZ1dHVyZSBhcyB3ZWxsLg=="
            };

            for (int i = 0; i < 3; i++) {
                string secret = secretStrings[i];
                byte[] data = Convert.FromBase64String(secret);
                string decodedString = System.Text.Encoding.UTF8.GetString(data);
                
                Console.WriteLine(decodedString);
            }
        }

        void Challenge4() 
        {


            string[] iceLocations = {
                "0x01547832",
                "0x01489AE4",
                "0x04A4B334",
                "0x04EA2314"
            };

            int index = 0;
            while( index< iceLocations.Length) {
                string iceLocation = iceLocations[index];
                IceBreaker.BreakIce(iceLocation);
                
                index++;
            }
        }

        void Challenge5() {



            string[] vulnerableUsers = {
                "Jim Smith",
                "James Frank",
                "William Gibson",
                "Alice the Cool",
                "Christina Speakeasy"
            };

            foreach (string name in vulnerableUsers)
            {
                Console.WriteLine(name);
            }

        }
    }
}