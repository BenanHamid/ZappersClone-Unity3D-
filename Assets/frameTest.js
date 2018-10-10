var updateInterval = 0.5;
// This is the number of FPS accumulated over the interval
private var accum : float = 0.0;
// This is the number of frames rendered over the interval
private var frames : int = 0;
// This is the time left time for current interval
private var timeleft : float;

function Start()
{
// Make sure a guiText exists on the game object
if(!GetComponent.<GUIText>())
{
print ("FrameCounter needs a GUIText component!");
enabled = false;
return;
}
// Set the time remaining equal to the interval time
timeleft = updateInterval;
}
function Update()
{
// Subtract deltaTime from the time left
timeleft = timeleft - Time.deltaTime;
// Accumulate the FPS over the interval
accum = accum + Time.timeScale/Time.deltaTime;
// Add one to the number of frames rendered
frames = frames + 1;
// The interval ended, display the FPS and reset the
// counters
if( timeleft<= 0.0 )
{
GetComponent.<GUIText>().text = (accum/frames).ToString("f2");
timeleft = updateInterval;
accum = 0.0;
frames = 0;
}
}