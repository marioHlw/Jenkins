set BUILD_OUTPUT_PATH="%WORKSPACE%"/test.apk
function unity_build()
{
"C:\Program Files\Unity\Editor\Unity.exe" -quit -batchmode -logFile "D:\jenkinsLog.txt" -buildTarget android -projectPath "E:\UnityProject\JenkinsTest" set BUILD_OUTPUT_PATH="$WORKSPACE"/test.apk -executeMethod AutoBuild.Build
}