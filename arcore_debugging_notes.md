P1. 
* Unable to list target platforms. Please make sure the android sdk path is correct.
Error Messages:
CommandInvokationFailure: Unable to list target platforms. Please make sure the android sdk path is correct. 
C:/Program Files/Java/jdk-9.0.1\bin\java.exe -Xmx2048M -Dcom.android.sdkmanager.toolsdir="C:/Users/Ling/AppData/Local/Android/sdk\tools" -Dfile.encoding=UTF8 -jar "C:\Program Files\Unity 2017.3.0b5\Editor\Data\PlaybackEngines\AndroidPlayer/Tools\sdktools.jar" -

stderr[
Error:Invalid command android
]
stdout[

]
exit code: 64
UnityEditor.Android.Command.WaitForProgramToRun (UnityEditor.Utils.Program p, UnityEditor.Android.WaitingForProcessToExit waitingForProcessToExit, System.String errorMsg)
UnityEditor.Android.Command.Run (System.Diagnostics.ProcessStartInfo psi, UnityEditor.Android.WaitingForProcessToExit waitingForProcessToExit, System.String errorMsg)
UnityEditor.Android.AndroidSDKTools.RunCommandInternal (System.String javaExe, System.String sdkToolsDir, System.String[] sdkToolCommand, Int32 memoryMB, System.String workingdir, UnityEditor.Android.WaitingForProcessToExit waitingForProcessToExit, System.String errorMsg)
UnityEditor.Android.AndroidSDKTools.RunCommandSafe (System.String javaExe, System.String sdkToolsDir, System.String[] sdkToolCommand, Int32 memoryMB, System.String workingdir, UnityEditor.Android.WaitingForProcessToExit waitingForProcessToExit, System.String errorMsg)
UnityEngine.GUIUtility:ProcessEvent(Int32, IntPtr)

Solution:
Download the sdk-tools-windows from https://developer.android.com/studio/index.html, go to the android sdk directoy, extract it and run again
Reference:
http://answers.unity3d.com/questions/1323731/unable-to-list-target-platforms-please-make-sure-t.html

P2. Serialization issue
