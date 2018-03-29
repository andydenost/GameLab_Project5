**Game Technologies Lab**

**Haoyun Li**

**Fifth Project – How to use mouse to drag an object?**

1.  **What is the line of inquiry of my first project?**

From last year I start to learn Unity3D, The only way for me to control the
object moving is using keyboard. For example, if I want to go front, I set when
key W is pressed, execute the code like translate(0,0, speed\*time.deltatime).
If I want to go left, listen whether key A is pressed. Although this way of
input is the most frequently input when moving a object, it still not enough for
me if I want to make various games.

For this reason, I am wonder could I realize other input method for moving an
object? I remembered one of my classmate made a game that when he clicked a
place on the “floor”, the object would move to that place. It is a turn-based
strategy game, just like the chess game.

However, I am thinking if I want to make a chess game, could I just use mouse to
drag the pieces all the way to the place where I want to place? Not click the
position but like a real move by player’s hand.

That’s why I want to do this project.

1.  **The process of exploration**

I will do it on Unity. Because for this project, it only has meaning to do it on
3D world. If it is 2D world, I could just get the mouse position, translate
mouse position to world position (because it is 2D, it is easy) and make the
object’s position equal to that position. But 3D world has another direction, so
I need to know how to deal with that.

I know how to use ray to get the position where the ray collides with the plane,
and how to move to that place. But there is a slight difference between the
effect I want to make. Because the position of ray get is always on the “face”,
what’s more if I drag the object, the ray is always collides with object first.
So this way is a little inconvenient.

After did research, I found I had to translate the mouse position from screen
position to world position. At first, I try to translate the mouse position to
world position at every frame and make the object position equal mouse’s world
position every frame. All of these write in the update() function. Like the
codes showing blow:

void Update() {

Vector3 screenPosition = 

Camera.main.WorldToScreenPoint(this.transform.position);  
     if (Input.GetMouseButtonDown (0)) {  
   this.transform.position = 

Camera.main.ScreenToWorldPoint (new Vector3 (Input.mousePosition.x, Input.mousePosition.y, screenPosition.z));  
        }  
    }

However, it not worked like what I wanted. It just like ray, where you click
where it locate, without any dragging effect.

Then I look Unity API, in the Input class, there is a function called
Input.GetMouseButton(0). It returns true when I hold left button. So I change
GetMouseButtonDown to GetMouseButton, and it work without any problem. I could
drag the cube to where I want. Although I need to judge whether I am press on
the object, or it will move to mouse position immediately.

However, when I was doing the research, I found nobody use this way. All of them
using something called StartCoroutine and IEnumerator. I never know these things
before. After searching on Internet, I think it just easy for the big project to
save resource. It like insert an update to an update. Perhaps I didn’t
understand it clearly, I would try to do more research in the future. Although
it’s not necessary to write like that in my project, I also like to use it for
further study.

1.  **The process of doing project.**

-   Create a plane and put two small planes on it

-   Set each small plane different color, one is red, the other is green.

-   Add red tag to red plane, green tag to green plane

-   Add a cube to the scene and give red color material to it.

-   Add UI text to the scene

-   Write “drag” code into script and attach it to the cube.

-   Notice:

    OnMouseDown() and OnMouseDrag() are very useful functions, because this
    function only run when the mouse press the object which is attached this
    script on. With the function, you don’t need to write Ray into the script.
    It automatically detects whether you press on the object.

    It’s better to calculate offset between the mouse position and cube
    position. Every time you drag the cube, the position should add offset. That
    avoids the “flash move”.

-   Write “Result” script and attach it to the cube.

-   When the cube touches on the same color plane, a “Correct” text show on
    screen, if it is wrong color plane, show “wrong”.

1.  **The result**

-   There are many ways to realize dragging object. I try 3 versions in my
    script. Finally, I believe the third version is better. Because it’s easy
    for people to understand. No matter which way I use, the most important for
    this project is how to translate between mouse screen position and world
    position.

1.  **Citation:**

<https://docs.unity3d.com/ScriptReference/MonoBehaviour.OnMouseDrag.html>

<https://docs.unity3d.com/ScriptReference/Camera.WorldToScreenPoint.html>

<https://docs.unity3d.com/ScriptReference/Coroutine.html>
