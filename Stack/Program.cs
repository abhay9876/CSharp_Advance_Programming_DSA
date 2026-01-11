using System;
namespace Stack
{
    class Program
    {
        public static void Main(string[] args)
        {
            //// Web Browser Navigator
            //DesktopNavigation dn = new DesktopNavigation("Zeno");
            //dn.VisitTab("Google");
            //dn.VisitTab("Github");
            //dn.VisitTab("DotNet");
            //dn.VisitTab("C#");
            //Console.WriteLine($"{dn.BackWard()}  is Opened ....");
            //Console.WriteLine($"{dn.BackWard()}  is Opened ....");
            //Console.WriteLine($"{dn.ForWard()}  is Opened ....");
            //Console.WriteLine($"{dn.Current()}  is Current Tab ....");



            //// Code Editor
            //CodeEditor ce = new CodeEditor("{([])}");
            //ce.SyntaxCheck();
            //CodeEditor ce1 = new CodeEditor("{([)}");
            //ce1.SyntaxCheck();


            // Drawing App
            DrawingAction da = new Line();
            DrawingAction da1 = new Circle();
            DrawingAction da2 = new Line();
            DrawingAction da3 = new Circle();

            DrawingApp daa = new DrawingApp();
            daa.ActionPerform(da);
            daa.ActionPerform(da1);
            daa.Undo();
            daa.ActionPerform(da2);
            daa.Undo();



            // Expression Evaluation Engine 


        }
    }
}