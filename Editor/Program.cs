using Lab06;
using Lab06.Editor;
using System.Threading;

Thread t = Thread.CurrentThread;
t.SetApartmentState(ApartmentState.Unknown);
t.SetApartmentState(ApartmentState.STA);

FormEditor editor = new FormEditor();
editor.Game = new GameEditor(editor);
editor.Show();
editor.Game.Run();



//using var game = new Lab03.GameEditor();
//game.Run();
