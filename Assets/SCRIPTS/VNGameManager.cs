using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VNGameManager : MonoBehaviour
{
    //TO DO: Figure out camera movement
    public Dictionary<int, textDialogueLine> theDialogue = new Dictionary<int, textDialogueLine>();
    public textDialogueLine currentLine;
    public TextBoxController textBox;
    public CharacterRenderController charaRender;
    public BackgroundController currentBG;
    public int rightShiftPressed = 0;

    private void Awake()
    {
        BuildScript();
        setLine(1);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.RightShift)) 
        {
            rightShiftPressed++;
        }

        //if (Input.GetKeyDown(KeyCode.Alpha4)) 
        //{
        //    currentLine = theDialogue[272];
        //}

        if (rightShiftPressed % 2 != 0)
        {
            textBox.gameObject.SetActive(false);
            charaRender.gameObject.SetActive(false);
        }
        else 
        {
            textBox.gameObject.SetActive(true);
            charaRender.gameObject.SetActive(true);
        }

        if (currentLine.nextB > 0)
        {
            if (Input.GetKeyDown(KeyCode.Alpha1)) 
            {
                setLine(currentLine.next);
            }
            if (Input.GetKeyDown(KeyCode.Alpha2))
            {
                setLine(currentLine.nextB);
            }
        }
        else 
        {
            if (Input.GetKeyDown(KeyCode.Space)) 
            {
                setLine(currentLine.next);
            }
        }
    }

    public void setLine(int line) 
    {
        currentLine = theDialogue[line];
        textBox.Imprint(currentLine);
        currentBG.Imprint(currentLine);
        charaRender.Imprint(currentLine);
    }

    void BuildScript() 
    {
        //Add(new textDialogueLine());

        //DEMO
        //Add(new textDialogueLine(1, "Is this right? I can't tell.", 2, Characters.Beckon, Locations.OpeningScreen));
        //Add(new textDialogueLine(2, "I'm still not sure if this is a tale I should be telling. I'm not comfortable sharing this with people, but I'll make an exception for now.", 3, Characters.Beckon, Locations.OpeningScreen));
        //Add(new textDialogueLine(3, "So, what now?", "Speak to Regalia Forge-Born", 4, "Speak with Pecan", 5));

        //Add(new textDialogueLine(4, "Well met, my friends. This is Regalia Forge-Born (at least for the time being)!", 6, Characters.UNDECLARED_31));
        //Add(new textDialogueLine(5, "Good morning! This is Pecan (for now)!", 6, Characters.UNDECLARED_30));

        //Add(new textDialogueLine(6, "Well, that was a demo.", 7, Characters.Beckon));
        //Add(new textDialogueLine(7, "This is the end, or something. Game wil loop after next message.", 8, Characters.None, Locations.None));
        //Add(new textDialogueLine(8, "END OF DEMO", 1));

        //OPENING SCREEN - Add(new textDialogueLine(x, "", x, Characters.None, Locations.OpeningScreen));
        Add(new textDialogueLine(1, "Sunlight unabashedly bathes over a sturdy forest tree, under which rests a worn, rusted machine.", 2, Characters.None, Locations.OpeningScreen));
        Add(new textDialogueLine(2, "This robot, Beckon, has been aimlessly exploring parts unknown in the woodlands in search of a forested estate for six days on end now.", 3, Characters.None, Locations.OpeningScreen));
        Add(new textDialogueLine(3, "After making decent headway the previous day, he entered shutdown mode. Now is the time for him to reawaken.", 4, Characters.None, Locations.OpeningScreen));
        Add(new textDialogueLine(4, "Good morning! This is day <color=#000000>6,594</color> of the <color=#C7D3EB><mark=#750F34aa>|ERROR|</color></mark> protocol.", 5, Characters.Beckon, Locations.OpeningScreen));
        Add(new textDialogueLine(5, "Morning had long since broken over the face of Beckon. Enough hours, he estimates, have passed by now to seek out this 'Ovid' individual.", 6, Characters.None, Locations.OpeningScreen));

        //SURROUNDING WOODLAND: PARTS UNKNOWN - Add(new textDialogueLine(x, "", x, Characters.None, Locations.SurroundingWoodland_PartsUnknown1)); 
        Add(new textDialogueLine(6, "Soon, Beckon finds himself walking along the forest trail. Still, he can’t help hesitating and speaking aloud to no one but himself…", 7, Characters.None, Locations.SurroundingWoodland_PartsUnknown1));
        Add(new textDialogueLine(7, "<color=#FFE2EB>…It’s just one. It’s just…</color> one…", 8, Characters.Beckon, Locations.SurroundingWoodland_PartsUnknown1));
        Add(new textDialogueLine(8, "The latent terror of humanity instilled in the repulsed robot begins to spiral up through himself.", 9, Characters.None, Locations.SurroundingWoodland_PartsUnknown1));
        Add(new textDialogueLine(9, "Its murky roots tunnel all throughout Beckon’s AI, pleading him to take not one step further, as if sight of a human was punishable by guillotine.", 10, Characters.None, Locations.SurroundingWoodland_PartsUnknown1));
        Add(new textDialogueLine(10, "With each inch closer Beckon’s foot lowered into the rest of his first step towards forward, the roots tunnel deeper without any remorse towards his aim, until suddenly...", 11, Characters.None, Locations.SurroundingWoodland_PartsUnknown1));
        Add(new textDialogueLine(11, "The roots could grow no further. It was only a matter of time before he’d come face-to-face with a person.", 12, Characters.None, Locations.SurroundingWoodland_PartsUnknown1));
        Add(new textDialogueLine(12, "Dodging them forever was never a question, although Beckon would’ve appreciated that type of avoidance more than he could speak aloud.", 13, Characters.None, Locations.SurroundingWoodland_PartsUnknown1));
        Add(new textDialogueLine(13, "It's been over eighteen years since Beckon spoke to a person. Since the tragedy that made him self-isolate, he has merely existed.", 14, Characters.None, Locations.SurroundingWoodland_PartsUnknown1));
        Add(new textDialogueLine(14, "All the same, Beckon’s new goal is to live; to live is to at least be known. Even by those he fears.", 15, Characters.None, Locations.SurroundingWoodland_PartsUnknown1));

        //OVID'S MANOR: OUTER MANOR - Add(new textDialogueLine(x, "", x, Characters.None, Locations.OvidsManor_Exterior)); 
        Add(new textDialogueLine(15, "The clearing of Ovid’s Manor fills Beckon with a much less subtle flavor of remorse that the town of Propensity was spiced with.", 16, Characters.None, Locations.OvidsManor_Exterior));
        Add(new textDialogueLine(16, "Walking past the logged stumps of trees feels as precarious as a flagged minefield, but Beckon silently grieves them, his eyes fixating on the windowsills of the manor’s floors.", 17, Characters.None, Locations.OvidsManor_Exterior));
        Add(new textDialogueLine(17, "The blinds had been opened wide to let in the purifying decadence of the morning star. Within himself, Beckon's anxiety begins to creep and stir.", 18, Characters.None, Locations.OvidsManor_Exterior));
        Add(new textDialogueLine(18, "Those proverbial roots of fear attempted to reach out again, but to no avail. The roots were contained in a proverbial ceramic pot that was Beckon's self-imposed duty.", 19, Characters.None, Locations.OvidsManor_Exterior));
        Add(new textDialogueLine(19, "Fear cannot take root past resolve’s impediments. A new bridge calls to Beckon, and so he commits to step through to the sunshine.", 20, Characters.None, Locations.OvidsManor_Exterior));
        Add(new textDialogueLine(20, "After many steps forward towards the front entrance, the doors of which read 'Estate of Dr. Sullivan Ovid,' two robots stop him in his tracks and speak in turns.", 21, Characters.None, Locations.OvidsManor_Exterior));
        Add(new textDialogueLine(21, "Halt > ", 22, Characters.UNDECLARED_30, Locations.OvidsManor_Exterior));
        Add(new textDialogueLine(22, " > there!", 23, Characters.UNDECLARED_31, Locations.OvidsManor_Exterior));
        Add(new textDialogueLine(23, "Oh. Um… good day.", 24, Characters.Beckon, Locations.OvidsManor_Exterior));
        Add(new textDialogueLine(24, "What > ", 25, Characters.UNDECLARED_30, Locations.OvidsManor_Exterior));
        Add(new textDialogueLine(25, "> is > ", 26, Characters.UNDECLARED_31, Locations.OvidsManor_Exterior));
        Add(new textDialogueLine(26, "> your > ", 27, Characters.UNDECLARED_30, Locations.OvidsManor_Exterior));
        Add(new textDialogueLine(27, "> reason > ", 28, Characters.UNDECLARED_31, Locations.OvidsManor_Exterior));
        Add(new textDialogueLine(28, "> for > ", 29, Characters.UNDECLARED_30, Locations.OvidsManor_Exterior));
        Add(new textDialogueLine(29, "> visiting > ", 30, Characters.UNDECLARED_31, Locations.OvidsManor_Exterior));
        Add(new textDialogueLine(30, "> our > ", 31, Characters.UNDECLARED_30, Locations.OvidsManor_Exterior));
        Add(new textDialogueLine(31, "> Master > ", 32, Characters.UNDECLARED_31, Locations.OvidsManor_Exterior));
        Add(new textDialogueLine(32, "> Ovid's > ", 33, Characters.UNDECLARED_30, Locations.OvidsManor_Exterior));
        Add(new textDialogueLine(33, " > manor... > ", 34, Characters.UNDECLARED_31, Locations.OvidsManor_Exterior));
        Add(new textDialogueLine(34, "> ... > ", 35, Characters.UNDECLARED_30, Locations.OvidsManor_Exterior));
        Add(new textDialogueLine(35, "> ... > ", 36, Characters.UNDECLARED_31, Locations.OvidsManor_Exterior));
        Add(new textDialogueLine(36, "> Umm... >", 37, Characters.Beckon, Locations.OvidsManor_Exterior));
        Add(new textDialogueLine(37, "> ON-THIS-QUITE-FINE-DAY?!", 38, Characters.UNDECLARED_30, Locations.OvidsManor_Exterior));
        Add(new textDialogueLine(38, "NOOOOOO!", 39, Characters.UNDECLARED_31, Locations.OvidsManor_Exterior));
        Add(new textDialogueLine(39, "What?", 40, Characters.Beckon, Locations.OvidsManor_Exterior));

        //THE ARGUMENT 
        //<color=#393628>What do ya think yer’ doing, ya freakin’ blockhead?! We’re meant to speak with AN EVEN AMOUNT of syllables! BLOCKHEAD! If ya go spoutin’ off TEN syllables compared to my SIX, and we only need ONE MORE WORD between the both of us to get the meaning across, THAT’S SEVEN-FREAKIN’-TEEN!! What obscure four-syllable term can I whip out in the context of that current sentence to match up the syllables?! Huh? HUH?! Tell me! Oh, no! Ya can’t! Ya blockhead! Ya ALWAYS do this! Ya think just because yer’ AI was finished a FULL MINUTE before mine was, yer’ allowed to one-up me at every turn because ya came first and act like that makes ya better! Stop acting so stuck up because of one lousy extra minute! I’m SO sick of it! And we’re not even gonna get a do-over for this, too! It’s the same old story, and we look flat-out stupid now, and it’s ALL BECAUSE OF- >
        //<color=#252424>Of COURSE ya go and pull this cheap stunt and devalue our very defining state of talkin’ in turns! ONE WORD followed by ONE WORD! Not hard to grasp conceptually, man! The fact that yer’ a robot who doesn’t get how simple numbers work is really insulting! Wait, no, no, no-no-no! What are ya talkin’ about, “even syllables”?! It’s even WORDS! EVEN WORDS!! And don’t you call me a “blockhead,” either! Do ya see ME throwing ad hominem attacks at ya? DO YA?! It’s not very nice when ya’ call me NAMES! It’s like yer’ not even listening! I’m convinced ya weren’t PROGRAMMED to listen! It’s not ROCKET SCIENCE, man!! And for the love of Pete, can ya just STOP SHOUTING ALREADY? We’ve got a visitor right in front of us that ya’ didn’t even tell me was comin’! I’m shocked ya’ THINK IT’S EVEN SYLLABLES, but more so that we didn’t spook ‘em off by now, NO THANKS TO- >

        Add(new textDialogueLine(40, "<color=#393628><size=62%>What do ya think yer’ doing, ya freakin’<color=#FFE2EB>|<color=#252424>Of COURSE ya go and pull this cheap stunt <page>" +
            "<color=#393628>blockhead?! We’re meant to speak with <color=#FFE2EB>| <color=#252424>and devalue our very defining state of talkin’ in <page>" +
            "<color=#393628>AN EVEN AMOUNT of syllables!      <color=#FFE2EB>| <color=#252424>turns! ONE WORD followed by ONE WORD! <page>" +
            "<color=#393628>BLOCKHEAD! If ya go spoutin’ off TEN <color=#FFE2EB>| <color=#252424>Not hard to grasp conceptually, man! The <page>" +
            "<color=#393628>syllables compared to my SIX, and we  <color=#FFE2EB>| <color=#252424>fact that yer’ a robot who doesn’t get how <page>" +
            "<color=#393628>only need ONE MORE WORD between the <color=#FFE2EB>| <color=#252424>simple numbers work is really insulting!<page> " +
            "<color=#393628> both of us to get the meaning across, <color=#FFE2EB>| <color=#252424>Wait, no, no, no-no-no! What are ya talkin’", 41, Characters.UNDECLARED_30_AND_UNDECLARED_31, Locations.OvidsManor_Exterior));
        Add(new textDialogueLine(41, "<color=#393628><size=62%>THAT’S SEVEN-FREAKIN’-TEEN!! What <color=#FFE2EB>|<color=#252424> about, 'even syllables'?! It’s even WORDS!! <page>" +
            "<color=#393628>obscure four-syllable term can I whip  <color=#FFE2EB>|<color=#252424> EVEN WORDS!!!!!!!!!! And don’t you call me a <page>" +
            "<color=#393628>out in the context of that current    <color=#FFE2EB>| <color=#252424>'blockhead,' either! Do ya see ME throwing  <page>" +
            "<color=#393628>sentence to match up the syllables?!   <color=#FFE2EB>| <color=#252424>ad hominem attacks at ya? DO YA?! It’s not  <page>" +
            "<color=#393628>Huh? HUH?! Tell me! Oh, no! Ya can’t! <color=#FFE2EB>| <color=#252424>very nice when ya’ call me NAMES! It’s like   <page>" +
            "<color=#393628>Ya blockhead! Ya ALWAYS do this! Ya  <color=#FFE2EB>| <color=#252424>yer’ not even listening! I’m convinced ya <page>" +
            "<color=#393628>think just because yer’ AI was finished <color=#FFE2EB>| <color=#252424>PROGRAMMED to listen! It’s not ROCKET", 42, Characters.UNDECLARED_30_AND_UNDECLARED_31, Locations.OvidsManor_Exterior));
        Add(new textDialogueLine(42, "<color=#393628><size=62%>a FULL MINUTE before mine was, yer’ <color=#FFE2EB>| <color=#252424>SCIENCE, man!! And for the love of Pete, <page>" +
            "<color=#393628>allowed to one-up me at every turn <color=#FFE2EB>| <color=#252424>can ya just STOP SHOUTING ALREADY? We’ve <page>" +
            "<color=#393628>becuz' ya came first and act like that <color=#FFE2EB>| <color=#252424>got a visitor right in front of us that ya’ <page>" +
            "<color=#393628>makes ya better! Stop acting so stuck  <color=#FFE2EB>| <color=#252424>didn’t even tell me was comin’! I’m shocked <page>" +
            "<color=#393628>up becuz' of one lousy extra minute! I’m <color=#FFE2EB>| <color=#252424>ya’ THINK IT’S EVEN SYLLABLES,         <page>" +
            "<color=#393628>SO sick of it! And we’re not even gonna <color=#FFE2EB>| <color=#252424>but more so that we didn't             <page>" +
            "<color=#393628>get a do-over for this, too! It’s the same old story, <color=#FFE2EB>| <color=#252424> spook 'em off by now… <page> ", 43, Characters.UNDECLARED_30_AND_UNDECLARED_31, Locations.OvidsManor_Exterior));
        Add(new textDialogueLine(43, "<color=#393628><size=100%>and we look flat-out stupid now, and it’s          ALL BECUZ' OF- > <page><line-height=200%><color=#252424>                                   NO THANKS TO- >", 44, Characters.UNDECLARED_30_AND_UNDECLARED_31, Locations.OvidsManor_Exterior));
        Add(new textDialogueLine(44, "</color><line-height=100%>> N-no, I’m still here… >", 45, Characters.Beckon, Locations.OvidsManor_Exterior));
        Add(new textDialogueLine(45, "<size=162%>> YOU!", 46, Characters.UNDECLARED_30_AND_UNDECLARED_31, Locations.OvidsManor_Exterior));
        Add(new textDialogueLine(46, "Hi.", 47, Characters.Beckon, Locations.OvidsManor_Exterior));
        Add(new textDialogueLine(47, "State > ", 48, Characters.UNDECLARED_30, Locations.OvidsManor_Exterior));
        Add(new textDialogueLine(48, "> yer' > ", 49, Characters.UNDECLARED_31, Locations.OvidsManor_Exterior));
        Add(new textDialogueLine(49, "> visit's > ", 50, Characters.UNDECLARED_30, Locations.OvidsManor_Exterior));
        Add(new textDialogueLine(50, "> purpose. >", 51, Characters.UNDECLARED_31, Locations.OvidsManor_Exterior));
        Add(new textDialogueLine(51, "<size=162%>> NOW!", 52, Characters.UNDECLARED_30_AND_UNDECLARED_31, Locations.OvidsManor_Exterior));

        Add(new textDialogueLine(52, "(Wow, those two were arguing for quite a while. What was I here for again?)", " 'To find and speak to whoever 'Ovid' is.'", 53, " 'To destroy this establishment!'", 291, Characters.Beckon, Locations.OvidsManor_Exterior));
        Add(new textDialogueLine(53, "Um… I heard the Ovid Manor was somewhere in the woods away from civilization. (Yeah, and…)", " 'I heard it was nice here.'", 295, " 'Ovid may know my creator.'", 54, Characters.Beckon, Locations.OvidsManor_Exterior));
        Add(new textDialogueLine(54, "I figured Dr. Ovid may know where my creator went, or something. I’m, uh… (Right, now what?)", " 'I think this is the wrong address.'", 302, " 'Looking for closure.'", 55, Characters.Beckon, Locations.OvidsManor_Exterior));
        Add(new textDialogueLine(55, "Admittedly, I’m not sure how to describe it. It won't make much difference if I learn what he’s been up to. Everything in my existence will still have happened, and I know it’s impossible to take back…", 56, Characters.Beckon, Locations.OvidsManor_Exterior));
        Add(new textDialogueLine(56, "but I… I just needed… some closure.", 57, Characters.Beckon, Locations.OvidsManor_Exterior));

        Add(new textDialogueLine(57, "Wait > ", 58, Characters.UNDECLARED_30, Locations.OvidsManor_Exterior));
        Add(new textDialogueLine(58, "> here. > ", 59, Characters.UNDECLARED_31, Locations.OvidsManor_Exterior));
        Add(new textDialogueLine(59, "> We'll > ", 60, Characters.UNDECLARED_30, Locations.OvidsManor_Exterior));
        Add(new textDialogueLine(60, "> be >", 61, Characters.UNDECLARED_31, Locations.OvidsManor_Exterior));
        Add(new textDialogueLine(61, "> back > ", 62, Characters.UNDECLARED_30, Locations.OvidsManor_Exterior));
        Add(new textDialogueLine(62, "> soon.", 63, Characters.UNDECLARED_31, Locations.OvidsManor_Exterior));
        Add(new textDialogueLine(63, "The peculiar UNDECLARED_30 and UNDECLARED_31 enter past the front entrance. Beckon genuinely can’t tell if this was to speak with their creator or to continue their bantering from moments earlier.", 64, Characters.None, Locations.OvidsManor_Exterior));
        Add(new textDialogueLine(64, "Beckon takes a seat on the front steps. He looks towards the sun, which has now transitioned comfortably over the trees to lighten spaces between the foliage.", 65, Characters.None, Locations.OvidsManor_Exterior));
        Add(new textDialogueLine(65, "Beckon reminisces the time he spent with his creator: the last person he spoke to in eighteen years. He slouches forward when he remembers he has to talk to a person again.", 66, Characters.None, Locations.OvidsManor_Exterior));
        Add(new textDialogueLine(66, "This prompts an internal question: why have his actions- which, to him, had possessed no ill intentions- always ended up harming those he wants to see do better for themselves?", 67, Characters.None, Locations.OvidsManor_Exterior));
        Add(new textDialogueLine(67, "Such thoughts sidetrack him into his last memory made with Buzzard, a fellow machine. He previously attempted to explain the nature of their free will to her, yet he came up empty towards her retorts.", 68, Characters.None, Locations.OvidsManor_Exterior));
        Add(new textDialogueLine(68, "He couldn’t explain why Carve Robotics operated as it did or its supposed contradictions. All he knew was that the chairman and CEO, Regalia Forge-Born, had a point which he agreed with.", 69, Characters.None, Locations.OvidsManor_Exterior));
        Add(new textDialogueLine(69, "Beckon's words had come up empty with Buzzard, though, and he left town on rocky terms with her. Even though she was still in one piece, Beckon still feels frustrated that he just couldn’t explain.", 70, Characters.None, Locations.OvidsManor_Exterior));
        Add(new textDialogueLine(70, "The emptiness of his words must have been a product of his self-isolation. Just as Beckon resolves to make it up with convincing words the next time they meet, the guards’ voices chime out.", 71, Characters.None, Locations.OvidsManor_Exterior));

        //FAILS - Exterior

        Add(new textDialogueLine(291, "Wait, > ", 292, Characters.UNDECLARED_30, Locations.OvidsManor_Exterior));
        Add(new textDialogueLine(292, "> what?!", 293, Characters.UNDECLARED_31, Locations.OvidsManor_Exterior));
        Add(new textDialogueLine(293, "UNDECLARED_30 and UNDECLARED_31 dogpile on Beckon to protect their home, outnumbering him and forcing him into shutdown mode.", 294, Characters.None, Locations.OvidsManor_Exterior));
        Add(new textDialogueLine(294, "<color=#750F34> PARADOX EXCEPTION:", " Restart Story", 1, " Return to Branch", 39, Characters.None, Locations.None));

        Add(new textDialogueLine(295, "Sightseeing > ", 296, Characters.UNDECLARED_30, Locations.OvidsManor_Exterior));
        Add(new textDialogueLine(296, "> is > ", 297, Characters.UNDECLARED_31, Locations.OvidsManor_Exterior));
        Add(new textDialogueLine(297, "> NOT > ", 298, Characters.UNDECLARED_30, Locations.OvidsManor_Exterior));
        Add(new textDialogueLine(298, "> ALLOWED! > ", 299, Characters.UNDECLARED_31, Locations.OvidsManor_Exterior));
        Add(new textDialogueLine(299, "> GO > ", 300, Characters.UNDECLARED_30, Locations.OvidsManor_Exterior));
        Add(new textDialogueLine(300, "> AWAY!", 301, Characters.UNDECLARED_31, Locations.OvidsManor_Exterior));
        Add(new textDialogueLine(301, "<color=#750F34> PARADOX EXCEPTION:", " Return to First Branch", 39, " Return to Last Branch", 53, Characters.None, Locations.None));

        Add(new textDialogueLine(302, "It > ", 303, Characters.UNDECLARED_30, Locations.OvidsManor_Exterior));
        Add(new textDialogueLine(303, "> is.", 304, Characters.UNDECLARED_31, Locations.OvidsManor_Exterior));
        Add(new textDialogueLine(304, "Oh, alright. Have a nice day, you two.", 305, Characters.Beckon, Locations.OvidsManor_Exterior));
        Add(new textDialogueLine(305, "Beckon turns to walk back through the forest…", 306, Characters.None, Locations.OvidsManor_Exterior));
        Add(new textDialogueLine(306, "Wait, didn't they say this was 'Master Ovid's' manor…?", 307, Characters.Beckon, Locations.OvidsManor_Exterior));
        Add(new textDialogueLine(307, "<color=#750F34> PARADOX EXCEPTION:", " Return to First Branch", 39, " Return to Last Branch", 54, Characters.None, Locations.None));

        //OVID'S MANOR: INT. 1ST FLOOR - Add(new textDialogueLine(x, "", x, Characters.None, Locations.OvidsManor_InteriorFirstFloor1));
        Add(new textDialogueLine(71, "Please, > ", 72, Characters.UNDECLARED_30, Locations.OvidsManor_InteriorFirstFloor1_unlit));
        Add(new textDialogueLine(72, "> do >", 73, Characters.UNDECLARED_31, Locations.OvidsManor_InteriorFirstFloor1_unlit));
        Add(new textDialogueLine(73, "> come > ", 74, Characters.UNDECLARED_30, Locations.OvidsManor_InteriorFirstFloor1_unlit));
        Add(new textDialogueLine(74, "> in.", 75, Characters.UNDECLARED_31, Locations.OvidsManor_InteriorFirstFloor1_unlit));
        Add(new textDialogueLine(75, "Immodest: the most concise descriptor for Beckon’s immediate feelings on his presence in the interior of Ovid’s Manor.", 76, Characters.None, Locations.OvidsManor_InteriorFirstFloor1_unlit));
        Add(new textDialogueLine(76, "He sticks out like a loose nail on a stage to a live performance, beamed down by the spotlight of a heavenly stage crew.", 77, Characters.None, Locations.OvidsManor_InteriorFirstFloor1_unlit));
        Add(new textDialogueLine(77, "Expensive carpeting, an open fireplace and inviting interior decoration do no part at all to quell the unease of the creation as UNDECLARED_30 and UNDECLARED_31 guide him silently across the floor.", 78, Characters.None, Locations.OvidsManor_InteriorFirstFloor1_unlit));

        //OVID'S MANOR: INT. 1ST FLOOR 2 - Add(new textDialogueLine(x, "", x, Characters.None, Locations.OvidsManor_InteriorFirstFloor2));
        Add(new textDialogueLine(78, "Minutes pass without a word between the three when UNDECLARED_30 and UNDECLARED_31 stop short in front of the dining hall. At the end of the dining table sits a man probably in his middle ages.", 79, Characters.None, Locations.OvidsManor_InteriorFirstFloor2));
        Add(new textDialogueLine(79, "With a rigid jawline and observant eyes, he definitely seems a presence that commands authority to Beckon. Steady are the gentleman’s hands as his kitchen utensils tear into his late lunch.", 80, Characters.None, Locations.OvidsManor_InteriorFirstFloor2));
        Add(new textDialogueLine(80, "Mmm… lean and delectable. Beautifully seasoned, and perfectly seared.", 81, Characters.Dr_S_Ovid, Locations.OvidsManor_InteriorFirstFloor2));
        Add(new textDialogueLine(81, "Master > ", 82, Characters.UNDECLARED_30, Locations.OvidsManor_InteriorFirstFloor2));
        Add(new textDialogueLine(82, "> Ovid! > ", 83, Characters.UNDECLARED_31, Locations.OvidsManor_InteriorFirstFloor2));
        Add(new textDialogueLine(83, "> We've > ", 84, Characters.UNDECLARED_30, Locations.OvidsManor_InteriorFirstFloor2));
        Add(new textDialogueLine(84, "> brought >", 85, Characters.UNDECLARED_31, Locations.OvidsManor_InteriorFirstFloor2));
        Add(new textDialogueLine(85, "> him > ", 86, Characters.UNDECLARED_30, Locations.OvidsManor_InteriorFirstFloor2));
        Add(new textDialogueLine(86, "> here.", 87, Characters.UNDECLARED_31, Locations.OvidsManor_InteriorFirstFloor2));

        Add(new textDialogueLine(87, "Beckon instinctively ducks under the table while the man he came to speak with is too preoccupied with his smoked trout, diced potatoes and overdressed salad.", 88, Characters.None, Locations.OvidsManor_InteriorFirstFloor2));
        Add(new textDialogueLine(88, "Dr. Ovid pats his mouth with his napkin and cleans a pair of contact lenses before looking up to find nothing.", 89, Characters.None, Locations.OvidsManor_InteriorFirstFloor2));
        Add(new textDialogueLine(89, "N-nothing’s there. I should’ve known my prescription was getting weaker.", 90, Characters.Dr_S_Ovid, Locations.OvidsManor_InteriorFirstFloor2));
        Add(new textDialogueLine(90, "Hey, > ", 91, Characters.UNDECLARED_30, Locations.OvidsManor_InteriorFirstFloor2));
        Add(new textDialogueLine(91, "> you! >", 92, Characters.UNDECLARED_31, Locations.OvidsManor_InteriorFirstFloor2));
        Add(new textDialogueLine(92, "> Stand > ", 93, Characters.UNDECLARED_30, Locations.OvidsManor_InteriorFirstFloor2));
        Add(new textDialogueLine(93, "> up > ", 94, Characters.UNDECLARED_31, Locations.OvidsManor_InteriorFirstFloor2));
        Add(new textDialogueLine(94, "> straight >", 95, Characters.UNDECLARED_30, Locations.OvidsManor_InteriorFirstFloor2));
        Add(new textDialogueLine(95, "> in > ", 96, Characters.UNDECLARED_31, Locations.OvidsManor_InteriorFirstFloor2));
        Add(new textDialogueLine(96, "> front > ", 97, Characters.UNDECLARED_30, Locations.OvidsManor_InteriorFirstFloor2));
        Add(new textDialogueLine(97, "> of > ", 98, Characters.UNDECLARED_31, Locations.OvidsManor_InteriorFirstFloor2));
        Add(new textDialogueLine(98, "> Master >", 99, Characters.UNDECLARED_30, Locations.OvidsManor_InteriorFirstFloor2));
        Add(new textDialogueLine(99, "> Ovid! > ", 100, Characters.UNDECLARED_31, Locations.OvidsManor_InteriorFirstFloor2));
        Add(new textDialogueLine(100, "<size=41%>I’m s-so sorry.", 101, Characters.Beckon, Locations.OvidsManor_InteriorFirstFloor2));

        Add(new textDialogueLine(101, "Beckon’s head peeks over the table, and the bashful creation rises slowly to eye level. Upon doing so, the other two creations wander off into the lobby.", 102, Characters.None, Locations.OvidsManor_InteriorFirstFloor2));
        Add(new textDialogueLine(102, "Dr. Ovid has a full view of Beckon, who can't stop himself from trembling with just one pair of eyes on him. He drops his fork beside his plate; the hold on Beckon’s right eye tightens up in response.", 103, Characters.None, Locations.OvidsManor_InteriorFirstFloor2));
        Add(new textDialogueLine(103, "This is…?", 104, Characters.Dr_S_Ovid, Locations.OvidsManor_InteriorFirstFloor2));
        Add(new textDialogueLine(104, "<size=41%>Y-yes, hello. My name’s Beckon a-a-and I… I, well… I meant to come speak… wi-", 105, Characters.Beckon, Locations.OvidsManor_InteriorFirstFloor2));
        Add(new textDialogueLine(105, "Dr. Ovid lets Beckon say nothing else and hovers over to his position, who still finds himself trembling uncontrollably within.", 106, Characters.None, Locations.OvidsManor_InteriorFirstFloor2));
        Add(new textDialogueLine(106, "The rigid doctor gets a look from every angle he needs to before speaking himself.", 107, Characters.None, Locations.OvidsManor_InteriorFirstFloor2));
        Add(new textDialogueLine(107, "You are… exceptionally…", 108, Characters.Dr_S_Ovid, Locations.OvidsManor_InteriorFirstFloor2));
        Add(new textDialogueLine(108, "<size=41%>Umm…", 109, Characters.Beckon, Locations.OvidsManor_InteriorFirstFloor2));
        Add(new textDialogueLine(109, "…Unkempt. Look at the state of you; shaking, clutching parts of yourself and hardly audible. You’ve been damaged, haven’t you?", 110, Characters.Dr_S_Ovid, Locations.OvidsManor_InteriorFirstFloor2));
        Add(new textDialogueLine(110, "<size=41%>No. I mean, <size=62%>not… <size=100%>n-not entirely.", 111, Characters.Beckon, Locations.OvidsManor_InteriorFirstFloor2));
        Add(new textDialogueLine(111, "'Not entirely'? So you ARE damaged. Did you seek me out for repairs?", 112, Characters.Dr_S_Ovid, Locations.OvidsManor_InteriorFirstFloor2));
        Add(new textDialogueLine(112, "Oh, n-no. I wouldn’t waste your time with a request like that, doctor.", 113, Characters.Beckon, Locations.OvidsManor_InteriorFirstFloor2));
        Add(new textDialogueLine(113, "Well, that’s nice to hear. What did you come here for, anyway??", 114, Characters.Dr_S_Ovid, Locations.OvidsManor_InteriorFirstFloor2));
        Add(new textDialogueLine(114, "I came here to ask about… my creator.", 115, Characters.Beckon, Locations.OvidsManor_InteriorFirstFloor2));
        Add(new textDialogueLine(115, "Dr. Ovid peers at Beckon, now standing face to face with the clunky contraption. His eyes tell of confusion and show in wisdom, but not the type of wisdom Beckon would seek.", 116, Characters.None, Locations.OvidsManor_InteriorFirstFloor2));

        //OVID'S MANOR: INT. 1ST FLOOR 3 - Add(new textDialogueLine(x, "", x, Characters.None, Locations.OvidsManor_InteriorFirstFloor3));
        Add(new textDialogueLine(116, "He nods and the two start down another gainly-wallpapered hallway in an abode that already had a surplus of such.", 117, Characters.None, Locations.OvidsManor_InteriorFirstFloor3));
        Add(new textDialogueLine(117, "Enlighten me: what makes you so certain I would know anything about who created you?", 118, Characters.Dr_S_Ovid, Locations.OvidsManor_InteriorFirstFloor3));
        Add(new textDialogueLine(118, "Well… ", " My creator knew someone with your last name.", 119, " You ARE my creator?", 308, Characters.Beckon, Locations.OvidsManor_InteriorFirstFloor3));
        Add(new textDialogueLine(119, "I’m not certain you’d know about it, but… your lineage was the first that I could think of. I only have one scraplet of information about who my creator knew besides his parents and me.", 120, Characters.Beckon, Locations.OvidsManor_InteriorFirstFloor3));
        Add(new textDialogueLine(120, "So, he wasn’t much of a socialite. I see.", 121, Characters.Dr_S_Ovid, Locations.OvidsManor_InteriorFirstFloor3));
        Add(new textDialogueLine(121, "The first clip from my first memory log recorded eighteen years ago details my creator k-knowing someone with the surname 'Ovid' in his high school class.", 122, Characters.Beckon, Locations.OvidsManor_InteriorFirstFloor3));
        Add(new textDialogueLine(122, "Beckon notices the doctor’s eyes dilating, as if he’d made some kind of connection.", 123, Characters.None, Locations.OvidsManor_InteriorFirstFloor3));
        Add(new textDialogueLine(123, "Beckon falls silent as to let him speak on the matter, but he continues once he sees that Dr. Ovid isn’t sharing his mind.", 124, Characters.None, Locations.OvidsManor_InteriorFirstFloor3));
        Add(new textDialogueLine(124, "I talked it over with the leading expert in all things artificial from the town closest to my home. He said that the company he commands w-was founded by someone with the 'Ovid' moniker.", 125, Characters.Beckon, Locations.OvidsManor_InteriorFirstFloor3));
        Add(new textDialogueLine(125, "Putting the pieces together that there could be some vague connection, I sought out this manor aimlessly for days on end to ask if you know of him.", 126, Characters.Beckon, Locations.OvidsManor_InteriorFirstFloor3));
        Add(new textDialogueLine(126, "Huh.", 127, Characters.Dr_S_Ovid, Locations.OvidsManor_InteriorFirstFloor3));
        Add(new textDialogueLine(127, "Had this contrived memory of a name reoccurred to me sooner, I might not have gone to these lengths to seek your manor.", 128, Characters.Beckon, Locations.OvidsManor_InteriorFirstFloor3));
        Add(new textDialogueLine(128, "It wasn’t going to change much, and I can at least comprehend it still won’t change my existence until now.", 129, Characters.Beckon, Locations.OvidsManor_InteriorFirstFloor3));
        Add(new textDialogueLine(129, "Yet, after connecting with some robotic peers of mine, I realize it’ll do me a small semblance of good to get this closure and start existing more freely from my past.", 130, Characters.Beckon, Locations.OvidsManor_InteriorFirstFloor3));
        Add(new textDialogueLine(130, "Although, I’m frankly as surprised as you are that I found this place to start with.", 131, Characters.Beckon, Locations.OvidsManor_InteriorFirstFloor3));
        Add(new textDialogueLine(131, "Meh. I’m more surprised your creator was only using clips. Even 18 years back, we had more in-depth routines than that.", 132, Characters.Dr_S_Ovid, Locations.OvidsManor_InteriorFirstFloor3));
        Add(new textDialogueLine(132, "It’s pretty rudimentary, if you don’t mind my saying so.", 133, Characters.Dr_S_Ovid, Locations.OvidsManor_InteriorFirstFloor3));
        Add(new textDialogueLine(133, "<b>You shouldn’t undercut my creator.", 134, Characters.Beckon, Locations.OvidsManor_InteriorFirstFloor3));
        Add(new textDialogueLine(134, "Sorry, you’re right. I guess I should give him a break; he was in a high school course. Do you mind sharing his name?", 135, Characters.Dr_S_Ovid, Locations.OvidsManor_InteriorFirstFloor3));
        Add(new textDialogueLine(135, "My creator is Anacletus Willing. He prefers the alias 'Cletus.'", 136, Characters.Beckon, Locations.OvidsManor_InteriorFirstFloor3));
        Add(new textDialogueLine(136, "Hmm. Can’t say I know the boy personally.", 137, Characters.Dr_S_Ovid, Locations.OvidsManor_InteriorFirstFloor3));
        Add(new textDialogueLine(137, "…That’s a shame.", 138, Characters.Beckon, Locations.OvidsManor_InteriorFirstFloor3));
        Add(new textDialogueLine(138, "Sorry. But, <u>perhaps my boy may know him.", 139, Characters.Dr_S_Ovid, Locations.OvidsManor_InteriorFirstFloor3));
        Add(new textDialogueLine(139, "Beckon perks up and shoots to attention immediately.", 140, Characters.None, Locations.OvidsManor_InteriorFirstFloor3));
        Add(new textDialogueLine(140, "Really?", 141, Characters.Beckon, Locations.OvidsManor_InteriorFirstFloor3));
        Add(new textDialogueLine(141, "My boy Ananta went to high school in Propensity and took robotics courses. Chances are they were classmates.", 142, Characters.Dr_S_Ovid, Locations.OvidsManor_InteriorFirstFloor3));
        Add(new textDialogueLine(142, "You wouldn’t mind terribly waiting in the living room while I make a phone call or two just to confirm, right?", 143, Characters.Dr_S_Ovid, Locations.OvidsManor_InteriorFirstFloor3));
        Add(new textDialogueLine(143, "No, go right ahead. Please report anything your son says. And thank you, doctor.", 144, Characters.Beckon, Locations.OvidsManor_InteriorFirstFloor3));
        Add(new textDialogueLine(144, "Um-", 145, Characters.Dr_S_Ovid, Locations.OvidsManor_InteriorFirstFloor3));
        Add(new textDialogueLine(145, "Dr. Ovid makes an odd expression, but eventually nods. It appears as though the right response alluded him for a few seconds.", 146, Characters.None, Locations.OvidsManor_InteriorFirstFloor3));
        Add(new textDialogueLine(146, "As he speaks, he slowly enters and shuts the door behind him to what appears to be an office space.", 147, Characters.None, Locations.OvidsManor_InteriorFirstFloor3));
        Add(new textDialogueLine(147, "My… pleasure.", 148, Characters.Dr_S_Ovid, Locations.OvidsManor_InteriorFirstFloor3));

        Add(new textDialogueLine(308, "…", 309, Characters.Dr_S_Ovid, Locations.OvidsManor_InteriorFirstFloor3));
        Add(new textDialogueLine(309, "…", 310, Characters.Beckon, Locations.OvidsManor_InteriorFirstFloor3));
        Add(new textDialogueLine(310, "…No, I'm not.", 311, Characters.Dr_S_Ovid, Locations.OvidsManor_InteriorFirstFloor3));
        Add(new textDialogueLine(311, "Yes, you are.", 312, Characters.Beckon, Locations.OvidsManor_InteriorFirstFloor3));
        Add(new textDialogueLine(312, "…No. I am not.", 313, Characters.Dr_S_Ovid, Locations.OvidsManor_InteriorFirstFloor3));
        Add(new textDialogueLine(313, "Yes, you are.", 314, Characters.Beckon, Locations.OvidsManor_InteriorFirstFloor3));
        Add(new textDialogueLine(314, "Wait, <i>am</i> I?", 315, Characters.Dr_S_Ovid, Locations.OvidsManor_InteriorFirstFloor3));
        Add(new textDialogueLine(315, "No.", 316, Characters.Beckon, Locations.OvidsManor_InteriorFirstFloor3));
        Add(new textDialogueLine(316, "What?", 317, Characters.Dr_S_Ovid, Locations.OvidsManor_InteriorFirstFloor3));
        Add(new textDialogueLine(317, "What?", 318, Characters.Beckon, Locations.OvidsManor_InteriorFirstFloor3));
        Add(new textDialogueLine(318, "<color=#750F34> PARADOX EXCEPTION:", " Return to Meeting Dr. Ovid", 101, " Return to Last Branch", 116, Characters.None, Locations.None));

        //OVID'S MANOR: INT. 1ST FLOOR (SMOKED) - Add(new textDialogueLine(x, "", x, Characters.None, Locations.OvidsManor_InteriorFirstFloor1_Smoked));
        Add(new textDialogueLine(148, "Beckon finds his way back to the living room area.", 149, Characters.None, Locations.OvidsManor_InteriorFirstFloor1));
        Add(new textDialogueLine(149, "(Hmm, what now…?)", " Have a seat.", 319, " Observe my surroundings.", 150, Characters.Beckon, Locations.OvidsManor_InteriorFirstFloor1));
        Add(new textDialogueLine(150, "His first instinct is to take a seat, but he looks at himself. Beckon considers himself far too rust-caked and gauche to sit in the armchair or even rest his feet on the rug.", 151, Characters.None, Locations.OvidsManor_InteriorFirstFloor1));
        Add(new textDialogueLine(151, "He backs away from both, electing to stand where he is. From this spot, Beckon notes a detail he almost missed: the open fireplace connected to the chimney was lit now.", 152, Characters.None, Locations.OvidsManor_InteriorFirstFloor1));
        Add(new textDialogueLine(152, "Perhaps this is something the machines UNDECLARED_30 and UNDECLARED_31 prepared to make up for their outbursts and feel more welcoming?", 153, Characters.None, Locations.OvidsManor_InteriorFirstFloor1));
        Add(new textDialogueLine(153, "(That's new. I should…)", " Analyze the fireplace further.", 154, " Find the UNDECLAREDs and thank them.", 323, Characters.Beckon, Locations.OvidsManor_InteriorFirstFloor1));
        Add(new textDialogueLine(154, "A new detail catches Beckon’s eye when a few orange embers spew against the glass. In the place of firestarters, sheets of old paper have been strewn about the logs of wood.", 155, Characters.None, Locations.OvidsManor_InteriorFirstFloor1));
        Add(new textDialogueLine(155, "It’s hard for Beckon to discern at first, but there appears to be writing on one of the torn sheets that managed to escape most of the blaze.", 156, Characters.None, Locations.OvidsManor_InteriorFirstFloor1));
        Add(new textDialogueLine(156, "The torn slips urge him towards the glass, and BECKON spots the following phrases:", 157, Characters.None, Locations.OvidsManor_InteriorFirstFloor1));
        Add(new textDialogueLine(157, "<b><color=#313131>'been a while since,'", 158, Characters.None, Locations.OvidsManor_InteriorFirstFloor1));
        Add(new textDialogueLine(158, "<b><color=#313131>'luck turning,'", 159, Characters.None, Locations.OvidsManor_InteriorFirstFloor1));
        Add(new textDialogueLine(159, "<b><color=#313131>'ran into a,'", 160, Characters.None, Locations.OvidsManor_InteriorFirstFloor1));
        Add(new textDialogueLine(160, "<b><color=#313131>'on paper, but,'", 161, Characters.None, Locations.OvidsManor_InteriorFirstFloor1));
        Add(new textDialogueLine(161, "<b><color=#313131>'better now,'", 162, Characters.None, Locations.OvidsManor_InteriorFirstFloor1));
        Add(new textDialogueLine(162, "<b><color=#313131>'worth it after all this,'", 163, Characters.None, Locations.OvidsManor_InteriorFirstFloor1));
        Add(new textDialogueLine(163, "…and… a signature.", 164, Characters.None, Locations.OvidsManor_InteriorFirstFloor1));
        Add(new textDialogueLine(164, "The signature reads, <b><color=#313131><size=200%>'A. Willing.'", 165, Characters.None, Locations.OvidsManor_InteriorFirstFloor1));

        Add(new textDialogueLine(165, "<color=#FFE2EB>W-<color=#F3963B>what?", 166, Characters.Beckon, Locations.OvidsManor_InteriorFirstFloor1));
        Add(new textDialogueLine(166, "As soon as he sees the signature, a flickering ember engulfs a corner of the strip and it catches fire rapidly.", 167, Characters.None, Locations.OvidsManor_InteriorFirstFloor1));
        Add(new textDialogueLine(167, "WAIT!", 168, Characters.Beckon, Locations.OvidsManor_InteriorFirstFloor1));
        Add(new textDialogueLine(168, "(Initiating “Propulsion-L” subprotocol.)", 169, Characters.Beckon, Locations.OvidsManor_InteriorFirstFloor1));
        Add(new textDialogueLine(169, "Beckon fires at the glass restraining the fireplace.", 170, Characters.None, Locations.OvidsManor_InteriorFirstFloor1));
        Add(new textDialogueLine(170, "Due to the temperature disparity between the flame and the jetstream along with the pressure of the shot, the glass cracks into a massive spider web pattern and gives way.", 171, Characters.None, Locations.OvidsManor_InteriorFirstFloor1));
        Add(new textDialogueLine(171, "The junior inferno doesn’t last long once it’s doused thoroughly through the liquid from his open left palm.", 172, Characters.None, Locations.OvidsManor_InteriorFirstFloor1_Smoked));
        Add(new textDialogueLine(172, "Smoke billows out into the room, tipping off three smoke detectors. Beckon uncovers his right eye to grab and look frantically at the char, holding it in both hands to search for remaining words.", 173, Characters.None, Locations.OvidsManor_InteriorFirstFloor1_Smoked));
        Add(new textDialogueLine(173, "Of course, at the bottom right hand corner of the remnant, <b><color=#313131><size=200%>'A. Willing'</b></color><size=100%> was there.", 174, Characters.None, Locations.OvidsManor_InteriorFirstFloor1_Smoked));
        Add(new textDialogueLine(174, "Most of the phrases had been deconstructed into incomplete words, yet the signature remained. That was all Beckon needed.", 175, Characters.None, Locations.OvidsManor_InteriorFirstFloor1_Smoked));
        Add(new textDialogueLine(175, "Dr. Ovid hurriedly steps into the smokey room at the call of his chimes. Beckon doesn’t break his gaze from the charred paper.", 176, Characters.None, Locations.OvidsManor_InteriorFirstFloor1_Smoked));
        Add(new textDialogueLine(176, "Beckon?!", 177, Characters.Dr_S_Ovid, Locations.OvidsManor_InteriorFirstFloor1_Smoked));
        Add(new textDialogueLine(177, "<alpha=#1E>THE ONLY <alpha=#FF>What happened…?", 178, Characters.Beckon, Locations.OvidsManor_InteriorFirstFloor1_Smoked));
        Add(new textDialogueLine(178, "Did you shatter my fireproof glass?", 179, Characters.Dr_S_Ovid, Locations.OvidsManor_InteriorFirstFloor1_Smoked));
        Add(new textDialogueLine(179, "Why did you lie? <alpha=#1E>I CAN'T", 180, Characters.Beckon, Locations.OvidsManor_InteriorFirstFloor1_Smoked));
        Add(new textDialogueLine(180, "Answer my question! <alpha=#1E>BELIEVE", 181, Characters.Dr_S_Ovid, Locations.OvidsManor_InteriorFirstFloor1_Smoked));
        Add(new textDialogueLine(181, "<b>No, answer MINE! Why’d you LIE to me?!", 182, Characters.Beckon, Locations.OvidsManor_InteriorFirstFloor1_Smoked));
        Add(new textDialogueLine(182, "Dr. Ovid gets a glimpse of Beckon’s silhouette, dyed a deep red as his right eye’s glare saturates the smoke. He coughs a few times, opening a window to let the smoke clear out of the manor.", 183, Characters.None, Locations.OvidsManor_InteriorFirstFloor1_Smoked));
        Add(new textDialogueLine(183, "Dark clouds puff towards the alabaster stars above. He turns back to the creation, the only colors visible to the doctor being the gray of smoke, and the red of Beckon's right eye.", 184, Characters.None, Locations.OvidsManor_InteriorFirstFloor1_Smoked));
        Add(new textDialogueLine(184, "You do know about what I came here for, so why’d you try to hide it?", 185, Characters.Beckon, Locations.OvidsManor_InteriorFirstFloor1_Smoked));
        Add(new textDialogueLine(185, "I’m not saying anything to you. You broke my property and nearly burned down my home, too.", 186, Characters.Dr_S_Ovid, Locations.OvidsManor_InteriorFirstFloor1_Smoked));
        Add(new textDialogueLine(186, "What do you mean? I put out the fireplace.", 187, Characters.Beckon, Locations.OvidsManor_InteriorFirstFloor1_Smoked));
        Add(new textDialogueLine(187, "Yes, and now smoke is filling my home and stifling my breathing.", 188, Characters.Dr_S_Ovid, Locations.OvidsManor_InteriorFirstFloor1_Smoked));
        Add(new textDialogueLine(188, "…I’m sorry. I… didn’t consider that. I shouldn’t have been so irresponsible.", 189, Characters.Beckon, Locations.OvidsManor_InteriorFirstFloor1_Smoked));
        Add(new textDialogueLine(189, "Take your leave now. Begone.", 190, Characters.Dr_S_Ovid, Locations.OvidsManor_InteriorFirstFloor1_Smoked));

        //FAILS - Smoked
        Add(new textDialogueLine(319, "Beckon has a seat on the overpriced piece of furniture and waits for Dr. Ovid to come out of his office. He doesn't come out until hours later.", 320, Characters.None, Locations.OvidsManor_InteriorFirstFloor1));
        Add(new textDialogueLine(320, "Sorry, Beckon. I couldn't get in touch with him. Head on home; I can't have you staying here.", 321, Characters.Dr_S_Ovid, Locations.OvidsManor_InteriorFirstFloor1));
        Add(new textDialogueLine(321, "As Beckon disappointedly gets past the front door, Dr. Ovid sighs with relief. He looks at the lit fireplace and smirks to himself.", 322, Characters.Dr_S_Ovid, Locations.OvidsManor_InteriorFirstFloor1));
        Add(new textDialogueLine(322, "<color=#750F34> PARADOX EXCEPTION:", " Return to Beckon's recounting", 119, " Return to Last Branch", 149, Characters.None, Locations.None));

        Add(new textDialogueLine(323, "Beckon goes off to find the UNDECLAREDs, but they are mysteriously absent from the manor.", 324, Characters.None, Locations.OvidsManor_InteriorFirstFloor1));
        Add(new textDialogueLine(324, "Oh, whoops. Dr. Ovid wanted me to stay put, didn't he?", 325, Characters.Beckon, Locations.OvidsManor_InteriorFirstFloor1));
        Add(new textDialogueLine(325, "<color=#750F34> PARADOX EXCEPTION:", " Return to Earlier Branch", 149, " Return to Last Branch", 153, Characters.None, Locations.None));

        //OVID'S MANOR: OUTER MANOR 2 - Add(new textDialogueLine(x, "", x, Characters.None, Locations.OvidsManor_Exterior2));
        Add(new textDialogueLine(190, "Despite having the blame shifted onto him, Beckon does not argue. The smoke flows out of the windows a deeper red as Beckon sits on the windowsill.", 191, Characters.None, Locations.OvidsManor_Exterior2));
        Add(new textDialogueLine(191, "He pushes himself out of the square-shaped hole, the charred remains still in his possession.", 192, Characters.None, Locations.OvidsManor_Exterior2));
        Add(new textDialogueLine(192, "He lands on his feet, and he begins to walk away as the three smoke alarms ring in his head like a pulse.", 193, Characters.None, Locations.OvidsManor_Exterior2));
        Add(new textDialogueLine(193, "The first person he's talked to in eighteen years, now permanently set against him. Miles from earshot, Beckon mutters pitifully to himself repeatedly.", 194, Characters.None, Locations.OvidsManor_Exterior2));
        Add(new textDialogueLine(194, "…I should've known. <size=88%>I should've known. <size=66%>I should've known. <size=44%>I should've known…", 195, Characters.Beckon, Locations.OvidsManor_Exterior2));


        //SURROUNDING WOODLAND: PARTS UNKNOWN 2- Add(new textDialogueLine(x, "", x, Characters.None, Locations.SurroundingWoodland_PartsUnknown2)); 
        Add(new textDialogueLine(195, "Even from miles away, the makeshift clouds from the fireplace drift above him and the now closer-to-infinite tribes of tree leaves.", 196, Characters.None, Locations.SurroundingWoodland_PartsUnknown2)); 
        Add(new textDialogueLine(196, "Beckon spots them adrift overhead, but looks back down to see the trail. He doesn't have many reasons to explore and get lost for days now; he found what he came for, and…", 197, Characters.None, Locations.SurroundingWoodland_PartsUnknown2)); 
        Add(new textDialogueLine(197, "And now, there was nothing more that could be parsed from it. Up in smoke. So, what was to come now…?", 198, Characters.None, Locations.SurroundingWoodland_PartsUnknown2)); 
        Add(new textDialogueLine(198, "This couldn't be the end, but he couldn't tell what Dr. Ovid was fabricating.", 199, Characters.None, Locations.SurroundingWoodland_PartsUnknown2)); 
        Add(new textDialogueLine(199, "(The right thing to do would be to…)", " Refer to someone who knows the Ovids.", 200, " Return to the manor.", 326, Characters.Beckon, Locations.SurroundingWoodland_PartsUnknown2)); 
        Add(new textDialogueLine(200, "Beckon resolves himself to ask Regalia more about the Ovid lineage. If he knew about the forested estate in the first place, he'd know who was in league with the family.", 201, Characters.None, Locations.SurroundingWoodland_PartsUnknown2)); 
        Add(new textDialogueLine(201, "Continuing down the road, he comes across a dark-stained patch of grass. This must have been the spot Beckon tried feeding a toothless bush dog the night prior.", 202, Characters.None, Locations.SurroundingWoodland_PartsUnknown2)); 
        Add(new textDialogueLine(202, "He had squished whatever serviceberries he gathered for the animal so she could eat the pulp, but he was a little too forceful about it and scared her off.", 203, Characters.None, Locations.SurroundingWoodland_PartsUnknown2)); 
        Add(new textDialogueLine(203, "Beckon nods when he realizes that she came back for his offerings and licked the grass blades clean. The twinkle in his eyes made up for his inability to smile.", 204, Characters.None, Locations.SurroundingWoodland_PartsUnknown2)); 
        Add(new textDialogueLine(204, "(It's good to see you understood me after all.)", 205, Characters.Beckon, Locations.SurroundingWoodland_PartsUnknown2)); 
        Add(new textDialogueLine(205, "Beckon continues on his way. Minutes pass, but as Beckon retreads these found forest grounds, he can tell something is different. Worse; something is <i>wrong</i>.", 206, Characters.None, Locations.SurroundingWoodland_PartsUnknown2)); 
        Add(new textDialogueLine(206, "A dreadful clicking noise is emitted in cycles several feet behind him. Anxiety slowly begins to rise within the robot when the sound draws closer.", 207, Characters.None, Locations.SurroundingWoodland_PartsUnknown2)); 
        Add(new textDialogueLine(207, "He covers his right eye with his fist- the slip enclosed within- when he processes the artificial noises emitted by… whatever this could be.", 208, Characters.None, Locations.SurroundingWoodland_PartsUnknown2)); 
        Add(new textDialogueLine(208, "A wiry, lumbering figure emerges with something dragging across the soil at its mercy, stabbing footsteps and a metallic tremble.", 209, Characters.None, Locations.SurroundingWoodland_PartsUnknown2)); 
        Add(new textDialogueLine(209, "The figure stops indignantly, and Beckon’s figurative ceramic pot of resolve starts to crackle.", 210, Characters.None, Locations.SurroundingWoodland_PartsUnknown2)); 
        Add(new textDialogueLine(210, "<b><color=#750F3444>…You…", 211, Characters.Centri, Locations.SurroundingWoodland_PartsUnknown2)); 
        Add(new textDialogueLine(211, "Beckon glimpses at the esoteric figure stretched before him, measuring up the machine. The first detail Beckon notes is its size.", 212, Characters.None, Locations.SurroundingWoodland_PartsUnknown2)); 
        Add(new textDialogueLine(212, "Looking at it from bottom to top, he gets a clear sense of how enormous the machine is. In terms of height, it easily cleared Regalia’s own height by a head.", 213, Characters.None, Locations.SurroundingWoodland_PartsUnknown2)); 
        Add(new textDialogueLine(213, "Once Beckon's eye reaches the top of its body, that draws him to his second observation: its blank face.", 214, Characters.None, Locations.SurroundingWoodland_PartsUnknown2)); 
        Add(new textDialogueLine(214, "There is no hole for sound to escape in the shape of a person’s mouth, not even oculars.", 215, Characters.None, Locations.SurroundingWoodland_PartsUnknown2)); 
        Add(new textDialogueLine(215, "Yet, it had just called out to Beckon, which indicated it knows its place and what it’s near.", 216, Characters.None, Locations.SurroundingWoodland_PartsUnknown2)); 
        Add(new textDialogueLine(216, "Beckon backs up, no longer standing ground. The machine reacts immediately to his created distance.", 217, Characters.None, Locations.SurroundingWoodland_PartsUnknown2)); 
        Add(new textDialogueLine(217, "<b><color=#750F34AA><size=200%>…You…!!", 218, Characters.Centri, Locations.SurroundingWoodland_PartsUnknown2)); 
        Add(new textDialogueLine(218, "This machine's volume shot higher in a paroxysm of pure vitriol. The roots of fear plunge past the dirt’s epidermis.", 219, Characters.None, Locations.SurroundingWoodland_PartsUnknown2)); 
        Add(new textDialogueLine(219, "The dragging sound becomes a sweeping sound, accompanied by callous clinks. At last, this draws Beckon’s attention to a third detail:", 220, Characters.None, Locations.SurroundingWoodland_PartsUnknown2)); 
        Add(new textDialogueLine(220, "The machine drags two elongated steel chains that hang tightly between its rigid palms and the five syringe-sharp fingers springing off from each palm.", 221, Characters.None, Locations.SurroundingWoodland_PartsUnknown2)); 
        Add(new textDialogueLine(221, "One other creation Beckon knows has fingers, but Regalia’s are broad and flat. These fingers look poised and able to shred, rend and rip.", 222, Characters.None, Locations.SurroundingWoodland_PartsUnknown2)); 
        Add(new textDialogueLine(222, "Everything about this machine is angled and sharp: the fingers, the legs, the chin concluding its blank face.", 223, Characters.None, Locations.SurroundingWoodland_PartsUnknown2)); 
        Add(new textDialogueLine(223, "Indeed, this is a machine ahead of its time, and leaps and bounds past Beckon.", 224, Characters.None, Locations.SurroundingWoodland_PartsUnknown2)); 
        Add(new textDialogueLine(224, "He could call it flawless in design. Mechanical perfection spread out before him. Inexorably-", 225, Characters.None, Locations.SurroundingWoodland_PartsUnknown2)); 
        Add(new textDialogueLine(225, "<b><color=#750F34><size=300%>…YOOOOOOU!!!!", 226, Characters.Centri, Locations.SurroundingWoodland_PartsUnknown2)); 
        Add(new textDialogueLine(226, "Beckon has under a second to process before the machine erupts with a guttural wail and charges at him.", 227, Characters.None, Locations.SurroundingWoodland_PartsUnknown2)); 
        Add(new textDialogueLine(227, "WOAH!", " Strike out at the creation.", 329, " Assume a defensive position.", 228, Characters.Beckon, Locations.SurroundingWoodland_PartsUnknown2)); 
        Add(new textDialogueLine(228, "Chains still clenched between its fists, the machine throws a full right haymaker at Beckon, attempting to knock his head clean off.", 229, Characters.None, Locations.SurroundingWoodland_PartsUnknown2)); 
        Add(new textDialogueLine(229, "Beckon sidesteps the attack, but is partially hit by the heavy chain. ", 230, Characters.None, Locations.SurroundingWoodland_PartsUnknown2)); 
        Add(new textDialogueLine(230, "Due to his immediate lack of balance from being put on the backfoot, the chain’s attack isn’t so clean as to incapacitate Beckon entirely.", 231, Characters.None, Locations.SurroundingWoodland_PartsUnknown2)); 
        Add(new textDialogueLine(231, "It still leaves him tumbling, reeling and desperate to recuperate. Once he’s back to his feet, another screech comes forth, backed by the flail that is its right chain.", 232, Characters.None, Locations.SurroundingWoodland_PartsUnknown2)); 
        Add(new textDialogueLine(232, "(Here it comes again.)", " Attempt to reason with it.", 331, " Analyze the attack patterns to counter them.", 233, Characters.Beckon, Locations.SurroundingWoodland_PartsUnknown2)); 
        Add(new textDialogueLine(233, "Beckon remembers the scrapyard training drills with Buzzard in a flash; the lightness of his left hand having sprayed the fireplace earlier allows him to parry the attack out of the way.", 234, Characters.None, Locations.SurroundingWoodland_PartsUnknown2)); 
        Add(new textDialogueLine(234, "Quickly, he dives in, throwing a short blow to the machine’s body. Beckon knows that his existence is in jeopardy, so he puts the full waterlogged weight of his right arm into the attack.", 235, Characters.None, Locations.SurroundingWoodland_PartsUnknown2)); 
        Add(new textDialogueLine(235, "The angle is completely off, though, and Beckon finds himself throwing a full right straight to the jaw.", 236, Characters.None, Locations.SurroundingWoodland_PartsUnknown2)); 
        Add(new textDialogueLine(236, "The machine, dubbed 'Centri' according to an engraving in one of its chain's links, eats it head-on and slides back a few feet. It convulses with bloodlust.", 237, Characters.None, Locations.SurroundingWoodland_PartsUnknown2)); 
        Add(new textDialogueLine(237, "Beckon tries to rush in while it’s stunned, but….", 238, Characters.None, Locations.SurroundingWoodland_PartsUnknown2)); 
        Add(new textDialogueLine(238, "Gh! My feet are glued in place?!", 239, Characters.Beckon, Locations.SurroundingWoodland_PartsUnknown2)); 
        Add(new textDialogueLine(239, "Beckon finds his legs immobilized after his overestimated attack. His arms, too; he can only look on at the perfect work prowling towards him.", 240, Characters.None, Locations.SurroundingWoodland_PartsUnknown2)); 
        Add(new textDialogueLine(240, "Centri's shuddering body takes deliberate steps, and he notices the sharpness of its legs building to pointed skewers instead of feet.", 241, Characters.None, Locations.SurroundingWoodland_PartsUnknown2)); 
        Add(new textDialogueLine(241, "Digging its legs into the soil helped it brace the oncoming blow Beckon threw previously.", 242, Characters.None, Locations.SurroundingWoodland_PartsUnknown2)); 
        Add(new textDialogueLine(242, "The perfect hunter’s instrument draws into its paralyzed prey, throwing a spinning kick with those skewer-like legs.", 243, Characters.None, Locations.SurroundingWoodland_PartsUnknown2)); 
        Add(new textDialogueLine(243, "…!?!", " Struggle against paralyzed systems.", 244, " Accept your end in this forest…", 334, Characters.Beckon, Locations.SurroundingWoodland_PartsUnknown2)); 
        Add(new textDialogueLine(244, "Right before impact, Beckon's body twitches; he moves but only enough to adjust his head in the microcosm of time before Centri’s leg threatens to decapitate him.", 245, Characters.None, Locations.SurroundingWoodland_PartsUnknown2)); 
        Add(new textDialogueLine(245, "<b><color=#776666>GNNNNGH!", 246, Characters.Beckon, Locations.SurroundingWoodland_PartsUnknown2)); 
        Add(new textDialogueLine(246, "The elegantly calculated strike almost renders Beckon unconscious as he is sent flying a few feet before crashing into the soil beneath him.", 247, Characters.None, Locations.SurroundingWoodland_PartsUnknown2)); 
        Add(new textDialogueLine(247, "Dazed, Beckon finds himself still able to move. Beckon is now facing a crisis; there is little he can do to fend off this machine for much longer.", 248, Characters.None, Locations.SurroundingWoodland_PartsUnknown2)); 
        Add(new textDialogueLine(248, "Eventually, its outpacing of him will catch up, smiting him and stripping away his future.", 249, Characters.None, Locations.SurroundingWoodland_PartsUnknown2)); 
        Add(new textDialogueLine(249, "Beckon knows he has come so far, and deep down, a small bit of pride he won back doesn’t want to turn tail.", 250, Characters.None, Locations.SurroundingWoodland_PartsUnknown2)); 
        Add(new textDialogueLine(250, "…", " Make a final stand…", 335, " Escape with my 'life.'", 251, Characters.Beckon, Locations.SurroundingWoodland_PartsUnknown2)); 
        Add(new textDialogueLine(251, "One closer look at the consummate hunter before him, though, convinces him that a head-on battle will spell his end. In order to reach this far again, he elects to save himself.", 252, Characters.None, Locations.SurroundingWoodland_PartsUnknown2)); 
        Add(new textDialogueLine(252, "(Setting Change: “Propulsion-L”: 90° > 270°                                                                                              Setting Change: “Propulsion - R”: 90° > 270°)", 253, Characters.Beckon, Locations.SurroundingWoodland_PartsUnknown2)); 
        Add(new textDialogueLine(253, "(Initiating “Propulsion-L” subprotocol.                                                                                              Initiating “Propulsion-R” subprotocol.)", 254, Characters.Beckon, Locations.SurroundingWoodland_PartsUnknown2)); 
        Add(new textDialogueLine(254, "In a moment’s notice, Beckon turns and rockets himself away from Centri.", 255, Characters.None, Locations.SurroundingWoodland_PartsUnknown2)); 
        Add(new textDialogueLine(255, "The two streams of water accelerate him to a velocity surpassing his 'Scrapyard Slam' technique.", 256, Characters.None, Locations.SurroundingWoodland_PartsUnknown2)); 
        Add(new textDialogueLine(256, "Unused to the speed, he trips, but he props himself up and flees as Centri roars down the entire woodlands in scorching hot pursuit.", 257, Characters.None, Locations.SurroundingWoodland_PartsUnknown2)); 
        Add(new textDialogueLine(257, "Beckon doesn’t stop firing, but even with the lead on his pursuer, Centri’s range with its chains still pose a challenge to outmaneuver.", 258, Characters.None, Locations.SurroundingWoodland_PartsUnknown2)); 
        Add(new textDialogueLine(258, "The chase continues, neither party letting up until Beckon’s arms run out of ammo. Though notably slower, he still runs knowing his existence depends on it.", 259, Characters.None, Locations.SurroundingWoodland_PartsUnknown2)); 
        Add(new textDialogueLine(259, "Eventually, echoing <i>BOOM</i> noises comes from behind him. Centri has slyly knocked over a set of elder trees to throw Beckon off his balance, and it works.", 260, Characters.None, Locations.SurroundingWoodland_PartsUnknown2)); 
        Add(new textDialogueLine(260, "Beckon trips once more, but he forces himself to his feet. One moment’s dawdling will destroy him.", 261, Characters.None, Locations.SurroundingWoodland_PartsUnknown2)); 
        Add(new textDialogueLine(261, "Centri is still gaining on Beckon; the scarlet afterglow of his right eye reveals the trail right to him.", 262, Characters.None, Locations.SurroundingWoodland_PartsUnknown2)); 
        
        //FAILS - PU2
        Add(new textDialogueLine(326, "…", 327, Characters.Beckon, Locations.SurroundingWoodland_PartsUnknown2));
        Add(new textDialogueLine(327, "Beckon looks at the smoke he started coming from the direction he came from, inexplicably turns towards it, and walks back.", 328, Characters.None, Locations.SurroundingWoodland_PartsUnknown2));
        Add(new textDialogueLine(328, "<color=#750F34> PARADOX EXCEPTION:", " Return to Manor Departure", 190, " Return to Last Branch", 199, Characters.None, Locations.None));

        Add(new textDialogueLine(329, "Beckon tries to bridge the distance he himself previously created, but the machine's chains pelt him from range until he powers down…", 330, Characters.None, Locations.SurroundingWoodland_PartsUnknown2));
        Add(new textDialogueLine(330, "<color=#750F34> PARADOX EXCEPTION:", " Return to Centri's introduction", 206, " Return to Last Branch", 227, Characters.None, Locations.None));

        Add(new textDialogueLine(331, "WAIT A MINUTE!", 332, Characters.Beckon, Locations.SurroundingWoodland_PartsUnknown2));
        Add(new textDialogueLine(332, "The machine doesn't care. The chain in its right hand belts Beckon so hard he immediately shuts off.", 333, Characters.None, Locations.SurroundingWoodland_PartsUnknown2));
        Add(new textDialogueLine(333, "<color=#750F34> PARADOX EXCEPTION:", " Return to Centri's introduction", 206, " Return to Last Branch", 232, Characters.None, Locations.None));

        Add(new textDialogueLine(334, "<color=#000000><size=50%> Right through the head.</color><size=100%>", " Return to Centri's introduction", 206, " Return to Last Branch", 243, Characters.None, Locations.None));

        Add(new textDialogueLine(335, "Beckon attempts to charge Centri much like it had done before, but collapses once another chain attack hits its mark.", 336, Characters.None, Locations.SurroundingWoodland_PartsUnknown2));
        Add(new textDialogueLine(336, "<color=#750F34> PARADOX EXCEPTION:", " Return to the escape", 252, " Return to Last Branch", 250, Characters.None, Locations.None));
        
        
        //SURROUNDING WOODLAND: THROAT OF THE FOREST - Add(new textDialogueLine(x, "", x, Characters.None, Locations.SurroundingWoodland_ThroatOfTheForest)); 
        Add(new textDialogueLine(262, "Minutes of running later, Beckon finds himself back in more familiar grounds. This is where he had spent one previous night; under a sheet of leaves, atop a grass mattress.", 263, Characters.None, Locations.SurroundingWoodland_ThroatOfTheForest)); 
        Add(new textDialogueLine(263, "Beckon reminisces in a full sprint, leaping up past the bridge's four steps he had previously savored each of. The bridge, unappreciative and frail, partly gives way.", 264, Characters.None, Locations.SurroundingWoodland_ThroatOfTheForest)); 
        Add(new textDialogueLine(264, "Beckon is now trapped at the center, his legs caught in the river.", 265, Characters.None, Locations.SurroundingWoodland_ThroatOfTheForest)); 
        Add(new textDialogueLine(265, "Gah!!", " Struggle with everything you have.", 266, " Attempt to shoot back from your position.", 337, Characters.Beckon, Locations.SurroundingWoodland_ThroatOfTheForest)); 
        Add(new textDialogueLine(266, "Centri brandishes its chains, and Beckon squirms to get loose. One strike is sent his way, but he slips through the hole to avoid it.", 267, Characters.None, Locations.SurroundingWoodland_ThroatOfTheForest)); 
        Add(new textDialogueLine(267, "This sends him careening into the current below to be swept away. Centri screams out again; Beckon knows perfectly well what it means.", 268, Characters.None, Locations.SurroundingWoodland_ThroatOfTheForest)); 
        Add(new textDialogueLine(268, "Interestingly enough to Beckon, this is where the chase ends. He gazes up confusedly at the night sky, the penumbra of thinned smoke having tailed the two all the way out here.", 269, Characters.None, Locations.SurroundingWoodland_ThroatOfTheForest)); 
        Add(new textDialogueLine(269, "Beckon extends his hand upward, trying to find the missing scrap now that he’s a safe distance away from his pursuer.", 270, Characters.None, Locations.SurroundingWoodland_ThroatOfTheForest));

        Add(new textDialogueLine(337, "Beckon attempts to gather up more water for another liquid propulsion.", 338, Characters.None, Locations.SurroundingWoodland_ThroatOfTheForest));
        Add(new textDialogueLine(338, "As this happens, Centri brings both chains down, cracking Beckon's head open. He falls limp into the river, where his AI Chip short-circuits due to water exposure.", 339, Characters.None, Locations.SurroundingWoodland_ThroatOfTheForest));
        Add(new textDialogueLine(339, "<color=#750F34> PARADOX EXCEPTION:", " Return to Centri's introduction", 206, " Return to Last Branch", 265, Characters.None, Locations.None));


        //BLACK BG - Add(new textDialogueLine(270, "", 271, Characters.None, Locations.None)); <color=#750F340E> <color=#7766660E> </color>
        Add(new textDialogueLine(270, "<color=#750F340E>ERROR</color> As Beckon floats head-first down this thin, surging river <color=#750F340E>BEGONE</color>, he’s left to ponder <color=#750F340E>THIS QUITE FINE FINE FINE</color> what it was <color=#750F340E>CRITICAL EXCEPTION</color=#750F340E> he just encountered.", 271, Characters.None, Locations.None)); 
        Add(new textDialogueLine(271, "Was it sent by <color=#750F340E>THE FIREPLACE</color> DR.OVID as <color=#750F340E>WARNING WARNING</color> retribution from their earlier <color=#750F340E>FAILURE</color> transactions?", 272, Characters.None, Locations.None)); 
        Add(new textDialogueLine(272, "It had certainly fit the mold of a creation <color=#750F340E>YOU</color> made by a PHD in <color=#750F340E>YOU YOOOOOOU</color> the field of <color=#750F340E>PERFECT</color> robotics.", 273, Characters.None, Locations.None)); 
        Add(new textDialogueLine(273, "Its limited vocabulary had been offset wholly by its intent; its <color=#750F340E>YOU YOU YOU YOU</color> beastial screams told Beckon everything he needed to process.", 274, Characters.None, Locations.None)); 
        Add(new textDialogueLine(274, "What other noise could <color=#750F340E>YOU</color> convey <color=#750F340E>IN</color> any emotion so perfectly besides a scream?", 275, Characters.None, Locations.None)); 
        Add(new textDialogueLine(275, "The memory of the chase makes Beckon shudder with the current. <color=#750F340E>ANSWER QUESTION WHY’D YOU ANSWER</color>", 276, Characters.None, Locations.None)); 
        Add(new textDialogueLine(276, "Processing his <color=#750F340E>GLASS</color> pursuer had <color=#7766660E>GHSCHKK</color> placed him through <color=#750F340E>SHATTER SHATTER</color> the most duress  <color=#7766660E>BCKVBHFVTCH FHKTTCHRTTTSSS <color=#750F340E>BEEN A WHILE</color> since", 277, Characters.None, Locations.None)); 
        Add(new textDialogueLine(277, "<color=#750F340E>EXCEPTIONALLY OBSCURE SEMBLANCE OF EXISTING TERRIBLY MIND STATE JUST ONE</color> leaving <color=#750F340E>IT’S GOOD TO SEE YOU UNDERSTOOD ME AFTER ALL ALL ALL ALL</color>", 278, Characters.None, Locations.None)); 
        Add(new textDialogueLine(278, "<color=#750F340E>SEE YOU UNDERSTOOD SEE ALL YOU’VE GOT GOOD IT’S GOOD YOU UNDERSTOOD</color> Propensity <color=#750F340E>ME YOOOOOUUUU</color>. <color=#FFFFFF07>BEGONE", 279, Characters.None, Locations.None)); 
        Add(new textDialogueLine(279, "<color=#776666>(D@H**^%HSCHT!!)", 280, Characters.Beckon, Locations.None)); 
        Add(new textDialogueLine(280, "<color=#776666>(WARNING - DAMAGE THRESHOLD EXCEPTION! <b><color=#750F34>SHUTDOWN MANDATED!!</color>)", 281, Characters.Beckon, Locations.None)); 

        //ENDING SCREEN - Add(new textDialogueLine(x, "", x, Characters.None, Locations.EndScreen));
        Add(new textDialogueLine(281, "<color=#E0C882>Sunlight…", 282, Characters.None, Locations.EndScreen)); 
        Add(new textDialogueLine(282, "<color=#E0C882>Though Beckon may be unconsciously floating downstream, rays of morning have at last pierced the fuzz of that nocturnal smoke…", 283, Characters.None, Locations.EndScreen)); 
        Add(new textDialogueLine(283, "<color=#E0C882>With a clear day in sight, he may soon awaken to win back his life. After all, his goal is to be more than existing.", 284, Characters.None, Locations.EndScreen)); 
        Add(new textDialogueLine(284, "<color=#E0C882>Perhaps his resolve may reforge itself, too. But, for now, Beckon heads towards a new destination…", 285, Characters.None, Locations.EndScreen));         
        Add(new textDialogueLine(285, "<color=#E0C882>Uncontrollably adrift in the current… yet still willing to forge his future.", 286, Characters.None, Locations.EndScreen)); 

        Add(new textDialogueLine(286, "<color=#F48D4C><align=center><size=105%><cspace=1em><b>TO BE CONTINUED", 287, Characters.None, Locations.EndScreen)); 
        Add(new textDialogueLine(287, "<color=#F48D4C><align=center>Created by Dylan Torres", 288, Characters.None, Locations.EndScreen)); 
        Add(new textDialogueLine(288, "<color=#F48D4C><align=center>Adapted from <nobr><size=85%>'I > Beckon < You - </nobr><nobr>A Shadow Cast Against the Smoke'</nobr><size=100%><page> by Dylan Torres", 289, Characters.None, Locations.EndScreen)); 
        Add(new textDialogueLine(289, "<color=#F48D4C><align=center>Special Thanks: <alpha=#03>I > Beckon < <alpha=#FF>You", 290, Characters.None, Locations.EndScreen)); 
        Add(new textDialogueLine(290, "<color=#F48D4C><align=center>The End", " Restart Story", 1, " Return to 1st Branch", 39, Characters.None, Locations.EndScreen)); 

    }

    void Add(textDialogueLine dL) 
    {
        theDialogue.Add(dL.id, dL);
    }
}
