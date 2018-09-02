using Microsoft.CognitiveServices.SpeechRecognition;
using System;
using System.Linq;
using System.Threading;

namespace helloworld
{
    class Program
    {
        static AutoResetEvent fre = new AutoResetEvent(false);
        static MicrophoneRecognitionClient l;

        static void Main()
        {
            var speechRecogeMode = SpeechRecognitionMode.LongDictation;
            var lang = "en-us";
            var subkey = "c060c1c953504758ae24a0e6f17f7d71";
            var cur = string.Empty;
            var r = string.Empty;
            l = SpeechRecognitionServiceFactory.CreateMicrophoneClient(speechRecogeMode, lang, subkey);
            l.OnResponseReceived += (sender, e) =>
            {
                Console.Clear();

                if (e.PhraseResponse.Results.Count() > 0)
                {
                    var res = e.PhraseResponse.Results.Last().DisplayText;

                    if (res.Contains("학생"))
                        cur += res + '\n';
                    else
                        r += res + '\n';
                }
                Console.WriteLine(cur);
                Console.WriteLine();
                
                Console.WriteLine(r);
            };

            l.StartMicAndRecognition();
        }
    }
}