/* This content is licensed under the terms of the Creative Commons Attribution 4.0 International License.
 * When using this content, you must:
 * �    Acknowledge that the content is from the Sansar Knowledge Base.
 * �    Include our copyright notice: "� 2017 Linden Research, Inc."
 * �    Indicate that the content is licensed under the Creative Commons Attribution-Share Alike 4.0 International License.
 * �    Include the URL for, or link to, the license summary at https://creativecommons.org/licenses/by-sa/4.0/deed.hi (and, if possible, to the complete license terms at https://creativecommons.org/licenses/by-sa/4.0/legalcode.
 * For example:
 * "This work uses content from the Sansar Knowledge Base. � 2017 Linden Research, Inc. Licensed under the Creative Commons Attribution 4.0 International License (license summary available at https://creativecommons.org/licenses/by/4.0/ and complete license terms available at https://creativecommons.org/licenses/by/4.0/legalcode)."
 
 
 
    SurrealProducts Notes:
    Allows user to set current frame of the object animation through experience edit. Created by Surreal Products, collaboration with OldVamp. Main body of code provided by OldVamp.
    Created on 3/18/2019.
 
 
 
 
 */

using Sansar.Script;
using Sansar.Simulation;
using System;

// A small starter script.
public class DisplayText : SceneObjectScript
{
    #region EditorProperties
    // This interaction will have a default prompt of "Click Me!"
    // Public fields show in the object properties after being added to a script.
    // An Interaction public property makes the script clickable.
    [DefaultValue("100")]
    public int SetAnimationFrame;

    int AnimFrame = 100; //default


    #endregion



    // Init() is where the script is setup and is run when the script starts.
    public override void Init()
    {
    AnimFrame = SetAnimationFrame;


        //code here provided by OldVamp
        AnimationComponent anicomp = null;
        Animation ani;
        if (!ObjectPrivate.TryGetFirstComponent(out anicomp))
        {
            Log.Write("No animation component");
            return;
        }
        ani = anicomp.DefaultAnimation;
        if (ani == null)
        {
            Log.Write("This animation component has no default animation");
            return;
        }
        ani.JumpToFrame(AnimFrame);



    }

}