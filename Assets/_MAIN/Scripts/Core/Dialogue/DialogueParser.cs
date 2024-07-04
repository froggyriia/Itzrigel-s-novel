using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace DIALOGUE
{
    public class DialogueParser
    {
        public static DIALOGUE_LINE Parse(string rawLine)
        {

            Debug.Log($"Parsing line - '{rawLine}'");

            (string speaker, string dialogue, string commands) = RipContent(rawLine);

            return new DIALOGUE_LINE(speaker, dialogue, commands);
        }

        private static (string, string, string) RipContent(string rawline)
        {
            string speaker = "", dialogue = "", commands = "";

            int dialogueStart = -1;
            int dialogueEnd = -1;
            bool isEscaped = false;

            for(int i = 0; i < rawline.Length; i++)
            {
                char current = rawline[i];
                if (current == '\\')
                    isEscaped = !isEscaped;
                else if (current == '"' && !isEscaped)
                {
                    if (dialogueStart == -1)
                    {
                        dialogueStart = i;
                    }
                    else if (dialogueEnd == -1)
                    {
                        dialogueEnd = i;
                        //break;
                    }
                    else
                        isEscaped = false;
                }

                
                
            }
            Debug.Log($"dialogue start: {dialogueStart}, dialogueEnd: {dialogueEnd}");
            Debug.Log(rawline.Substring(dialogueStart + 1, dialogueEnd - dialogueStart - 1));
            return (speaker, dialogue, commands);
        }
    }

}
