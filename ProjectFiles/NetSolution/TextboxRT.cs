#region Using directives
using System;
using UAManagedCore;
using FTOptix.HMIProject;
using FTOptix.Core;
using FTOptix.NetLogic;
using FTOptix.UI;
using FTOptix.NativeUI;
using FTOptix.WebUI;
using NetlogicTesting.shared;
#endregion

public class TextboxRT : BaseNetLogic
{
    [ExportMethod]
    public void generateProject()
    {
        // Generate Folders and base project objects
        ProjectCreation.generateBase();

        // Get project
        var projectRoot = Project.Current;
        var mainWindow = projectRoot.Get("UI").Get("MainWindow");

        // Insert code to be executed when the user-defined logic is started
        var textBox1 = InformationModel.MakeObject<TextBox>("TextBox1");
        textBox1.TopMargin = 50;
        textBox1.LeftMargin = 50;
        textBox1.Height = 20;
        textBox1.Width = 100;
        textBox1.HorizontalAlignment = HorizontalAlignment.Left;
        textBox1.VerticalAlignment = VerticalAlignment.Top;
        textBox1.TextVerticalAlignment = TextVerticalAlignment.Bottom;
        textBox1.ValueChangeBehaviour = ValueChangeBehaviour.ValueChangeWhileEditing;
        textBox1.PlaceholderText = "PlaceholderText";
        mainWindow.Add(textBox1);

        // Add second textbox to canvas
        var textBox2 = InformationModel.MakeObject<TextBox>("TextBox2");
        textBox2.TopMargin = 100;
        textBox2.LeftMargin = 50;
        textBox2.Height = 20;
        textBox2.Width = 100;
        textBox2.HorizontalAlignment = HorizontalAlignment.Left;
        textBox2.VerticalAlignment = VerticalAlignment.Top;
        textBox2.TextHorizontalAlignment = TextHorizontalAlignment.Right;
        textBox2.TextVerticalAlignment = TextVerticalAlignment.Top;
        textBox2.BorderColor = Colors.Blue;
        textBox2.ContentType = InputType.Password;
        mainWindow.Add(textBox2);

        // Add third textbox to canvas
        var textBox3 = InformationModel.MakeObject<TextBox>("TextBox3");
        textBox3.TopMargin = 150;
        textBox3.LeftMargin = 50;
        textBox3.Height = 20;
        textBox3.Width = 100;
        textBox3.HorizontalAlignment = HorizontalAlignment.Left;
        textBox3.VerticalAlignment = VerticalAlignment.Top;
        textBox3.TextHorizontalAlignment = TextHorizontalAlignment.Left;
        textBox3.ValueChangeBehaviour = ValueChangeBehaviour.ValueChangeWhileEditing;
        mainWindow.Add(textBox3);

        // Add fourth textbox to canvas
        var textBox4 = InformationModel.MakeObject<TextBox>("TextBox4");
        textBox4.TopMargin = 200;
        textBox4.LeftMargin = 50;
        textBox4.Height = 20;
        textBox4.Width = 100;
        textBox4.HorizontalAlignment = HorizontalAlignment.Left;
        textBox4.VerticalAlignment = VerticalAlignment.Top;
        textBox4.TextVerticalAlignment = TextVerticalAlignment.Center;
        textBox4.ReadOnly = true;
        mainWindow.Add(textBox4);

        // Add fifth textbox to canvas
        var textBox5 = InformationModel.MakeObject<TextBox>("TextBox5");
        textBox5.TopMargin = 250;
        textBox5.LeftMargin = 50;
        textBox5.Height = 20;
        textBox5.Width = 100;
        textBox5.HorizontalAlignment = HorizontalAlignment.Left;
        textBox5.VerticalAlignment = VerticalAlignment.Top;
        textBox5.TextHorizontalAlignment = TextHorizontalAlignment.Center;
        textBox5.TextVerticalAlignment = TextVerticalAlignment.Center;
        textBox5.ValueChangeBehaviour = ValueChangeBehaviour.ValueChangeWhileEditing;
        textBox5.PlaceholderText = "PlaceholderText";
        textBox5.ReadOnly = true;
        textBox5.ContentType = InputType.Password;
        mainWindow.Add(textBox5);

        var button1 = InformationModel.MakeObject<Button>("Button1");
        button1.TopMargin = 300;
        button1.LeftMargin = 50;
        button1.Height = 20;
        button1.Width = 20;
        button1.HorizontalAlignment = HorizontalAlignment.Left;
        button1.VerticalAlignment = VerticalAlignment.Top;
        button1.Text = "Button1";
        mainWindow.Add(button1);

        Log.Info("Project Generation Complete");
    }
}
