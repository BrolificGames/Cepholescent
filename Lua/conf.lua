function love.conf(t)
    t.modules.joystick = true   	-- Enable the joystick module (boolean)
    t.modules.audio = true      	-- Enable the audio module (boolean)
    t.modules.keyboard = true   	-- Enable the keyboard module (boolean)
    t.modules.event = true      	-- Enable the event module (boolean) tell when we are dragging the window, or about ot exit
    t.modules.image = true      	-- Enable the image module (boolean)
    t.modules.graphics = true   	-- Enable the graphics module (boolean)
    t.modules.timer = true      	-- Enable the timer module (boolean) fps, time things, how long game running
    t.modules.mouse = true      	-- Enable the mouse module (boolean)
    t.modules.sound = true      	-- Enable the sound module (boolean) formating
	t.modules.thread = true
    t.modules.physics = true    	-- Enable the physics module (boolean)
    t.console = true           		-- Attach a console (boolean, Windows only)
    t.title = "Brick Breaker"			-- The title of the window the game is in (string) 
    t.author = "Jordan Buehler"		-- The author of the game (string)
    t.screen.fullscreen = false 	-- Enable fullscreen (boolean)
    t.screen.vsync = false      	-- Enable vertical sync (boolean)
    t.screen.fsaa = 0           	-- The number of FSAA-buffers (number)
    t.screen.height = 600       	-- The window height (number)
    t.screen.width = 800        	-- The window width (number)
end