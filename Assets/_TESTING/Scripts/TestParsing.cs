using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DIALOGUE;

namespace TESTING
{
    public class TestParsing : MonoBehaviour
    {
        // Start is called before the first frame update
        void Start()
        {
            string line = "Speaker \" Dialogue passes you...\"";

            DialogueParser.Parse(line);
        }

        // Update is called once per frame
        void Update()
        {

        }
    }

}
