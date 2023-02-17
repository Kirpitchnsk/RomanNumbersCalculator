using Avalonia.VisualTree;
using Avalonia.Controls;

namespace UITestsForRomanNumbersCalculator
{
    public class UnitTest1
    {
        [Fact]
        public async void Test1()
        {
            var app = AvaloniaApp.GetApp();
            var mainWindow = AvaloniaApp.GetMainWindow();

            await Task.Delay(100);

            var Screen = mainWindow.GetVisualDescendants().OfType<TextBox>().First(t => t.Name == "Screen");
            var I = mainWindow.GetVisualDescendants().OfType<Button>().First(b => b.Name == "I");
            var plus = mainWindow.GetVisualDescendants().OfType<Button>().First(b => b.Name == "plus");
            var V = mainWindow.GetVisualDescendants().OfType<Button>().First(b => b.Name == "V");
            var equals = mainWindow.GetVisualDescendants().OfType<Button>().First(b => b.Name == "equal");
            var CE = mainWindow.GetVisualDescendants().OfType<Button>().First(b => b.Name == "CE");

            I.Command.Execute(I.CommandParameter);
            plus.Command.Execute(plus.CommandParameter);
            V.Command.Execute(V.CommandParameter);
            equals.Command.Execute(equals.CommandParameter);

            await Task.Delay(50);
            string text = Screen.Text;
            CE.Command.Execute(CE.CommandParameter);
            Assert.True(text == "I + V = VI", "Screen != VI");
        }

        [Fact]
        public async void Test2()
        {
            var app = AvaloniaApp.GetApp();
            var mainWindow = AvaloniaApp.GetMainWindow();

            await Task.Delay(100);

            var Screen = mainWindow.GetVisualDescendants().OfType<TextBox>().First(t => t.Name == "Screen");
            var I = mainWindow.GetVisualDescendants().OfType<Button>().First(b => b.Name == "I");
            var minus = mainWindow.GetVisualDescendants().OfType<Button>().First(b => b.Name == "multiply");
            var V = mainWindow.GetVisualDescendants().OfType<Button>().First(b => b.Name == "V");
            var equal = mainWindow.GetVisualDescendants().OfType<Button>().First(b => b.Name == "equal");
            var CE = mainWindow.GetVisualDescendants().OfType<Button>().First(b => b.Name == "CE");

            V.Command.Execute(V.CommandParameter);
            minus.Command.Execute(minus.CommandParameter);
            I.Command.Execute(I.CommandParameter);
            equal.Command.Execute(equal.CommandParameter);

            await Task.Delay(50);
            string text = Screen.Text;
            CE.Command.Execute(CE.CommandParameter);
            Assert.True(text == "V - I = IV", "Screen != IV");
        }

        [Fact]
        public async void Test3()
        {
            var app = AvaloniaApp.GetApp();
            var mainWindow = AvaloniaApp.GetMainWindow();

            await Task.Delay(100);

            var screen = mainWindow.GetVisualDescendants().OfType<TextBox>().First(t => t.Name == "Screen");
            var X = mainWindow.GetVisualDescendants().OfType<Button>().First(b => b.Name == "X");
            var multiply = mainWindow.GetVisualDescendants().OfType<Button>().First(b => b.Name == "multiply");
            var V = mainWindow.GetVisualDescendants().OfType<Button>().First(b => b.Name == "V");
            var equal = mainWindow.GetVisualDescendants().OfType<Button>().First(b => b.Name == "equal");
            var CE = mainWindow.GetVisualDescendants().OfType<Button>().First(b => b.Name == "CE");

            V.Command.Execute(V.CommandParameter);
            multiply.Command.Execute(multiply.CommandParameter);
            X.Command.Execute(X.CommandParameter);
            equal.Command.Execute(equal.CommandParameter);

            await Task.Delay(50);
            string text = screen.Text;
            CE.Command.Execute(CE.CommandParameter);
            Assert.True(text == "V * X = L", "Screen != L");
        }

        [Fact]
        public async void Test4()
        {
            var app = AvaloniaApp.GetApp();
            var mainWindow = AvaloniaApp.GetMainWindow();

            await Task.Delay(100);

            var result = mainWindow.GetVisualDescendants().OfType<TextBox>().First(t => t.Name == "Screen");
            var L = mainWindow.GetVisualDescendants().OfType<Button>().First(b => b.Name == "L");
            var dividion = mainWindow.GetVisualDescendants().OfType<Button>().First(b => b.Name == "dividion");
            var V = mainWindow.GetVisualDescendants().OfType<Button>().First(b => b.Name == "V");
            var equal = mainWindow.GetVisualDescendants().OfType<Button>().First(b => b.Name == "equal");
            var CE = mainWindow.GetVisualDescendants().OfType<Button>().First(b => b.Name == "CE");

            L.Command.Execute(L.CommandParameter);
            dividion.Command.Execute(dividion.CommandParameter);
            V.Command.Execute(V.CommandParameter);
            equal.Command.Execute(equal.CommandParameter);

            await Task.Delay(50);
            string text = result.Text;
            CE.Command.Execute(CE.CommandParameter);
            Assert.True(text == "L / V = X", "Screen != X");
        }

        [Fact]
        public async void Test5()
        {
            var app = AvaloniaApp.GetApp();
            var mainWindow = AvaloniaApp.GetMainWindow();

            await Task.Delay(100);

            var result = mainWindow.GetVisualDescendants().OfType<TextBox>().First(t => t.Name == "Screen");
            var I = mainWindow.GetVisualDescendants().OfType<Button>().First(b => b.Name == "I");
            var Plus = mainWindow.GetVisualDescendants().OfType<Button>().First(b => b.Name == "plus");
            var Minus = mainWindow.GetVisualDescendants().OfType<Button>().First(b => b.Name == "multiply");
            var V = mainWindow.GetVisualDescendants().OfType<Button>().First(b => b.Name == "V");
            var L = mainWindow.GetVisualDescendants().OfType<Button>().First(b => b.Name == "L");
            var C = mainWindow.GetVisualDescendants().OfType<Button>().First(b => b.Name == "C");
            var equal = mainWindow.GetVisualDescendants().OfType<Button>().First(b => b.Name == "equal");
            var CE = mainWindow.GetVisualDescendants().OfType<Button>().First(b => b.Name == "CE");

            I.Command.Execute(I.CommandParameter);
            Plus.Command.Execute(Plus.CommandParameter);
            V.Command.Execute(V.CommandParameter);
            Plus.Command.Execute(Plus.CommandParameter);
            C.Command.Execute(C.CommandParameter);
            Minus.Command.Execute(Minus.CommandParameter);
            L.Command.Execute(L.CommandParameter);
            equal.Command.Execute(equal.CommandParameter);

            await Task.Delay(50);
            string text = result.Text;
            CE.Command.Execute(CE.CommandParameter);
            Assert.True(text == "I + V + C - L = LVI", "Screen != LVI");
        }

        [Fact]
        public async void Test6()
        {
            var app = AvaloniaApp.GetApp();
            var mainWindow = AvaloniaApp.GetMainWindow();

            await Task.Delay(100);

            var screen = mainWindow.GetVisualDescendants().OfType<TextBox>().First(t => t.Name == "Screen");
            var I = mainWindow.GetVisualDescendants().OfType<Button>().First(b => b.Name == "I");
            var dividion = mainWindow.GetVisualDescendants().OfType<Button>().First(b => b.Name == "dividion");
            var V = mainWindow.GetVisualDescendants().OfType<Button>().First(b => b.Name == "V");
            var equal = mainWindow.GetVisualDescendants().OfType<Button>().First(b => b.Name == "equal");
            var CE = mainWindow.GetVisualDescendants().OfType<Button>().First(b => b.Name == "CE");

            I.Command.Execute(I.CommandParameter);
            dividion.Command.Execute(dividion.CommandParameter);
            V.Command.Execute(V.CommandParameter);

            equal.Command.Execute(equal.CommandParameter);

            await Task.Delay(50);
            string text = screen.Text;
            CE.Command.Execute(CE.CommandParameter);
            Assert.True(text == "ERROR", "Screen != ERROR");
        }

        [Fact]
        public async void Test7()
        {
            var app = AvaloniaApp.GetApp();
            var mainWindow = AvaloniaApp.GetMainWindow();

            await Task.Delay(100);

            var result = mainWindow.GetVisualDescendants().OfType<TextBox>().First(t => t.Name == "Screen");
            var M = mainWindow.GetVisualDescendants().OfType<Button>().First(b => b.Name == "M");
            var Screen = mainWindow.GetVisualDescendants().OfType<Button>().First(b => b.Name == "equal");
            var multiply = mainWindow.GetVisualDescendants().OfType<Button>().First(b => b.Name == "multiply");
            var CE = mainWindow.GetVisualDescendants().OfType<Button>().First(b => b.Name == "CE");

            M.Command.Execute(M.CommandParameter);
            M.Command.Execute(M.CommandParameter);
            M.Command.Execute(M.CommandParameter);
            M.Command.Execute(M.CommandParameter);
            multiply.Command.Execute(multiply.CommandParameter);

            Screen.Command.Execute(Screen.CommandParameter);

            await Task.Delay(50);
            string text = result.Text;
            CE.Command.Execute(CE.CommandParameter);
            Assert.True(text == "ERROR", "Screen != ERROR");
        }

        [Fact]
        public async void Test8()
        {
            var app = AvaloniaApp.GetApp();
            var mainWindow = AvaloniaApp.GetMainWindow();

            await Task.Delay(100);

            var result = mainWindow.GetVisualDescendants().OfType<TextBox>().First(t => t.Name == "Screen");
            var L = mainWindow.GetVisualDescendants().OfType<Button>().First(b => b.Name == "L");
            var X = mainWindow.GetVisualDescendants().OfType<Button>().First(b => b.Name == "X");
            var equal = mainWindow.GetVisualDescendants().OfType<Button>().First(b => b.Name == "equal");
            var minus = mainWindow.GetVisualDescendants().OfType<Button>().First(b => b.Name == "multiply");
            var CE = mainWindow.GetVisualDescendants().OfType<Button>().First(b => b.Name == "CE");

            L.Command.Execute(L.CommandParameter);
            minus.Command.Execute(minus.CommandParameter);
            X.Command.Execute(X.CommandParameter);
            X.Command.Execute(X.CommandParameter);
            equal.Command.Execute(equal.CommandParameter);

            await Task.Delay(50);
            string text = result.Text;
            CE.Command.Execute(CE.CommandParameter);
            Assert.True(text == "L - XX = XXX", "Screen != XXX");
        }

        [Fact]
        public async void Test9()
        {
            var app = AvaloniaApp.GetApp();
            var mainWindow = AvaloniaApp.GetMainWindow();

            await Task.Delay(100);

            var result = mainWindow.GetVisualDescendants().OfType<TextBox>().First(t => t.Name == "Screen");
            var buttonM = mainWindow.GetVisualDescendants().OfType<Button>().First(b => b.Name == "M");
            var buttonResult = mainWindow.GetVisualDescendants().OfType<Button>().First(b => b.Name == "equal");
            var minus = mainWindow.GetVisualDescendants().OfType<Button>().First(b => b.Name == "minus");
            var CE = mainWindow.GetVisualDescendants().OfType<Button>().First(b => b.Name == "CE");

            buttonM.Command.Execute(buttonM.CommandParameter);
            minus.Command.Execute(minus.CommandParameter);
            buttonM.Command.Execute(buttonM.CommandParameter);

            buttonResult.Command.Execute(buttonResult.CommandParameter);

            await Task.Delay(50);
            string text = result.Text;
            CE.Command.Execute(CE.CommandParameter);
            Assert.True(text == "ERROR", "Screen != ERROR");
        }

        [Fact]
        public async void Test10()
        {
            var app = AvaloniaApp.GetApp();
            var mainWindow = AvaloniaApp.GetMainWindow();

            await Task.Delay(100);

            var screen = mainWindow.GetVisualDescendants().OfType<TextBox>().First(t => t.Name == "Screen");
            var M = mainWindow.GetVisualDescendants().OfType<Button>().First(b => b.Name == "M");
            var CE = mainWindow.GetVisualDescendants().OfType<Button>().First(b => b.Name == "CE");

            M.Command.Execute(M.CommandParameter);
            M.Command.Execute(M.CommandParameter);
            M.Command.Execute(M.CommandParameter);
            M.Command.Execute(M.CommandParameter);
            CE.Command.Execute(CE.CommandParameter);

            await Task.Delay(50);
            string text = screen.Text;
            CE.Command.Execute(CE.CommandParameter);
            Assert.True(text == "", "Screen != '");
        }
    }
}