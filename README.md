# TimerApp-WinForms-
An UI Application that capable of stopper and timer functionalities.

Starts at the timer screen.

View:
  About 85% of the window dedicated for the stopper/timer while 15% dedicated for alternating between them.
  
  Timer screen:
    Has 2 buttons (start and finish) and a text box for entering the time to count.
      Buttons:
        Start:
          starts the timer count down or pause it if it is counting.
        Reset:
          Resets the counting and allow us to enter another amout of time to count.
      UI: Circular progress bar and text view
        Circular rogress bar:
          Appears when the counting starts, slowly disappears with circular motion, changes its color after 70% of the timer has past.
        Text view:
          A lable that shows us the time left to the accuracy of 0.01 seconds.
          
    Stopper screen:
      Has 3 buttons (start/pause/continue, lap, reset)
        Buttons:
          Start:
            Starts to count, pause it if the program is counting, resume it if paused.
          Lap:
            Creats a lap and shows it in a lap counter on the right side of the screen.
          Reset:
            Resets the counting as well as the lap counting.
      UI: A text view and a lap counter.
        Text view:
          Shows the time goes by with accuracy of 0.01 seconds.
        Lap counter:
          Shows the laps that the user created in a well orgenized list on the right side of the screen.
          
    Navigation bar: occupies the lower screen strap. (about 15% of the screen)
      Has 2 buttons (timer and stopper)
        Buttons:
          Timer: 
            Enters to the 'Timer' screen.
          Stopper: 
            Enters the 'Stopper'screen.
