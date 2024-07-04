using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace TESTING
{
    public class Testing_Architect : MonoBehaviour
    {
        DialogueSystem ds;
        TextArchitect architect;
        int testing_lines = 0;
        string[] lines = new string[5]
        {
            "Эта история началась давно... ",
            "Ещё в те времена, когда новый корпус АКПЛ не был построен... ",
            "Произошло великое событие! ",
            "Родилась ярчайшая звезда, которой было предначертано спасти Землю. ",
            "Имя ей было - Itzrigel. ",
        };

        // Start is called before the first frame update
        void Start()
        {
            ds = DialogueSystem.instance;
            architect = new TextArchitect(ds.dialogueContainer.dialogueText);
            architect.buildMethod = TextArchitect.BuildMethod.typewriter;
            architect.speed = 1f;
        }

        // Update is called once per frame
        void Update()
        {
            string longLine = "позвольте мне перед этим сделать небольшую историческую справку буквально пол минуточки. всё началось когда славяне призвали варягов на княжение";
            if (Input.GetKeyDown(KeyCode.Space))
            {
                if (architect.isBuilding)
                {
                    if (!architect.hurryUp)

                        architect.hurryUp = true;

                    else
                        architect.ForceComlete();
                }
                else
                {
                    //architect.Build(longLine);
                    if (testing_lines < lines.Length - 1)
                    {
                        testing_lines++;
                        architect.Build(lines[testing_lines]);
                    }
                }

                
            }
            else if (Input.GetKeyDown(KeyCode.RightArrow))
            {
                //architect.Append(longLine);
                if (testing_lines < lines.Length - 1)
                {
                    testing_lines++;
                    architect.Append(lines[testing_lines]);
                }


            }
        }
    }
}