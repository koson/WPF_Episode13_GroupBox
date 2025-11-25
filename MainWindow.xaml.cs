using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace WPF_Episode13_GroupBox
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void ShowBasicGroupBox(object sender, RoutedEventArgs e)
        {
            var mainStack = CreateMainStack("Demo 1: Basic GroupBox");

            AddDescription(mainStack, "GroupBox groups related controls with a labeled border:");

            // Simple GroupBox
            var groupBox1 = new GroupBox
            {
                Header = "Personal Information",
                Padding = new Thickness(10),
                Margin = new Thickness(0, 10, 0, 0)
            };
            var stack1 = new StackPanel();
            stack1.Children.Add(new TextBlock { Text = "Name:" });
            stack1.Children.Add(new TextBox { Margin = new Thickness(0, 5, 0, 10) });
            stack1.Children.Add(new TextBlock { Text = "Email:" });
            stack1.Children.Add(new TextBox { Margin = new Thickness(0, 5, 0, 10) });
            stack1.Children.Add(new TextBlock { Text = "Phone:" });
            stack1.Children.Add(new TextBox { Margin = new Thickness(0, 5) });
            groupBox1.Content = stack1;
            mainStack.Children.Add(groupBox1);

            // GroupBox with checkboxes
            var groupBox2 = new GroupBox
            {
                Header = "Preferences",
                Padding = new Thickness(10),
                Margin = new Thickness(0, 10, 0, 0)
            };
            var stack2 = new StackPanel();
            stack2.Children.Add(new CheckBox { Content = "Enable notifications", Margin = new Thickness(0, 5) });
            stack2.Children.Add(new CheckBox { Content = "Auto-save", Margin = new Thickness(0, 5), IsChecked = true });
            stack2.Children.Add(new CheckBox { Content = "Dark mode", Margin = new Thickness(0, 5) });
            groupBox2.Content = stack2;
            mainStack.Children.Add(groupBox2);

            UpdateContent(mainStack);
        }

        private void ShowHeaderStyles(object sender, RoutedEventArgs e)
        {
            var mainStack = CreateMainStack("Demo 2: Header Customization");

            AddDescription(mainStack, "GroupBox headers can be customized in many ways:");

            // Simple text header
            var groupBox1 = new GroupBox
            {
                Header = "Simple Text Header",
                Padding = new Thickness(10),
                Margin = new Thickness(0, 10, 0, 0)
            };
            groupBox1.Content = new TextBlock { Text = "Content with simple header" };
            mainStack.Children.Add(groupBox1);

            // Header with icon
            var groupBox2 = new GroupBox
            {
                Padding = new Thickness(10),
                Margin = new Thickness(0, 10, 0, 0)
            };
            var iconHeader = new StackPanel { Orientation = Orientation.Horizontal };
            iconHeader.Children.Add(new TextBlock { Text = "📧", FontSize = 16, Margin = new Thickness(0, 0, 5, 0) });
            iconHeader.Children.Add(new TextBlock { Text = "Header with Icon", FontSize = 14, FontWeight = FontWeights.Bold });
            groupBox2.Header = iconHeader;
            groupBox2.Content = new TextBlock { Text = "Content with icon in header" };
            mainStack.Children.Add(groupBox2);

            // Custom styled header
            var groupBox3 = new GroupBox
            {
                Padding = new Thickness(10),
                Margin = new Thickness(0, 10, 0, 0)
            };
            var styledHeader = new Border
            {
                Background = (Brush)new BrushConverter().ConvertFrom("#4CAF50"),
                CornerRadius = new CornerRadius(3),
                Padding = new Thickness(8, 4)
            };
            styledHeader.Child = new TextBlock { Text = "Custom Styled Header", Foreground = Brushes.White, FontWeight = FontWeights.Bold, FontSize = 13 };
            groupBox3.Header = styledHeader;
            groupBox3.Content = new TextBlock { Text = "Content with custom styled header" };
            mainStack.Children.Add(groupBox3);

            // Multi-line header
            var groupBox4 = new GroupBox
            {
                Padding = new Thickness(10),
                Margin = new Thickness(0, 10, 0, 0)
            };
            var multiHeader = new StackPanel();
            multiHeader.Children.Add(new TextBlock { Text = "Advanced Options", FontSize = 14, FontWeight = FontWeights.Bold });
            multiHeader.Children.Add(new TextBlock { Text = "Configure expert-level settings", FontSize = 10, Foreground = Brushes.Gray });
            groupBox4.Header = multiHeader;
            groupBox4.Content = new TextBlock { Text = "Content with descriptive header" };
            mainStack.Children.Add(groupBox4);

            UpdateContent(mainStack);
        }

        private void ShowStyledGroupBox(object sender, RoutedEventArgs e)
        {
            var mainStack = CreateMainStack("Demo 3: Styled GroupBox");

            AddDescription(mainStack, "GroupBox can be styled with custom borders and backgrounds:");

            // Custom border and background
            var groupBox1 = new GroupBox
            {
                Header = "Blue Styled",
                BorderBrush = (Brush)new BrushConverter().ConvertFrom("#2196F3"),
                BorderThickness = new Thickness(2),
                Background = (Brush)new BrushConverter().ConvertFrom("#E3F2FD"),
                Padding = new Thickness(15),
                Margin = new Thickness(0, 10, 0, 0)
            };
            groupBox1.Content = new TextBlock { Text = "Custom blue theme" };
            mainStack.Children.Add(groupBox1);

            // Success theme
            var groupBox2 = new GroupBox
            {
                Header = "✓ Success",
                BorderBrush = (Brush)new BrushConverter().ConvertFrom("#4CAF50"),
                BorderThickness = new Thickness(2),
                Background = (Brush)new BrushConverter().ConvertFrom("#E8F5E9"),
                Padding = new Thickness(10),
                Margin = new Thickness(0, 10, 0, 0)
            };
            groupBox2.Content = new TextBlock { Text = "Operation completed successfully" };
            mainStack.Children.Add(groupBox2);

            // Warning theme
            var groupBox3 = new GroupBox
            {
                Header = "⚠ Warning",
                BorderBrush = (Brush)new BrushConverter().ConvertFrom("#FF9800"),
                BorderThickness = new Thickness(2),
                Background = (Brush)new BrushConverter().ConvertFrom("#FFF3E0"),
                Padding = new Thickness(10),
                Margin = new Thickness(0, 10, 0, 0)
            };
            groupBox3.Content = new TextBlock { Text = "Review required before proceeding" };
            mainStack.Children.Add(groupBox3);

            // Error theme
            var groupBox4 = new GroupBox
            {
                Header = "✗ Error",
                BorderBrush = (Brush)new BrushConverter().ConvertFrom("#F44336"),
                BorderThickness = new Thickness(2),
                Background = (Brush)new BrushConverter().ConvertFrom("#FFEBEE"),
                Padding = new Thickness(10),
                Margin = new Thickness(0, 10, 0, 0)
            };
            groupBox4.Content = new TextBlock { Text = "Action failed - please try again" };
            mainStack.Children.Add(groupBox4);

            UpdateContent(mainStack);
        }

        private void ShowRegistrationForm(object sender, RoutedEventArgs e)
        {
            var mainStack = CreateMainStack("Demo 4: Registration Form");

            AddDescription(mainStack, "Professional registration form with grouped sections:");

            var formStack = new StackPanel { MaxWidth = 500 };

            // Personal Information
            var personalGroup = new GroupBox
            {
                Header = "Personal Information",
                Padding = new Thickness(10),
                Margin = new Thickness(0, 0, 0, 10)
            };
            var personalStack = new StackPanel();
            personalStack.Children.Add(new TextBlock { Text = "First Name:" });
            personalStack.Children.Add(new TextBox { Margin = new Thickness(0, 5, 0, 10) });
            personalStack.Children.Add(new TextBlock { Text = "Last Name:" });
            personalStack.Children.Add(new TextBox { Margin = new Thickness(0, 5, 0, 10) });
            personalStack.Children.Add(new TextBlock { Text = "Date of Birth:" });
            personalStack.Children.Add(new DatePicker { Margin = new Thickness(0, 5) });
            personalGroup.Content = personalStack;
            formStack.Children.Add(personalGroup);

            // Contact Details
            var contactGroup = new GroupBox
            {
                Header = "Contact Details",
                Padding = new Thickness(10),
                Margin = new Thickness(0, 0, 0, 10)
            };
            var contactStack = new StackPanel();
            contactStack.Children.Add(new TextBlock { Text = "Email:" });
            contactStack.Children.Add(new TextBox { Margin = new Thickness(0, 5, 0, 10) });
            contactStack.Children.Add(new TextBlock { Text = "Phone:" });
            contactStack.Children.Add(new TextBox { Margin = new Thickness(0, 5) });
            contactGroup.Content = contactStack;
            formStack.Children.Add(contactGroup);

            // Account Security
            var securityGroup = new GroupBox
            {
                Header = "Account Security",
                Padding = new Thickness(10),
                Margin = new Thickness(0, 0, 0, 10)
            };
            var securityStack = new StackPanel();
            securityStack.Children.Add(new TextBlock { Text = "Password:" });
            securityStack.Children.Add(new PasswordBox { Margin = new Thickness(0, 5, 0, 10) });
            securityStack.Children.Add(new TextBlock { Text = "Confirm Password:" });
            securityStack.Children.Add(new PasswordBox { Margin = new Thickness(0, 5, 0, 10) });
            securityStack.Children.Add(new CheckBox { Content = "I agree to the Terms of Service", Margin = new Thickness(0, 5) });
            securityGroup.Content = securityStack;
            formStack.Children.Add(securityGroup);

            formStack.Children.Add(new Button { Content = "Create Account", Padding = new Thickness(15, 8), Background = Brushes.Green, Foreground = Brushes.White });

            mainStack.Children.Add(formStack);
            UpdateContent(mainStack);
        }

        private void ShowSettingsPanel(object sender, RoutedEventArgs e)
        {
            var mainStack = CreateMainStack("Demo 5: Application Settings");

            AddDescription(mainStack, "Settings organized into logical groups:");

            // General Settings
            var generalGroup = new GroupBox
            {
                Header = "🔧 General",
                Padding = new Thickness(10),
                Margin = new Thickness(0, 10, 0, 0)
            };
            var generalStack = new StackPanel();
            generalStack.Children.Add(new CheckBox { Content = "Start with Windows", Margin = new Thickness(0, 5) });
            generalStack.Children.Add(new CheckBox { Content = "Minimize to system tray", Margin = new Thickness(0, 5), IsChecked = true });
            generalStack.Children.Add(new CheckBox { Content = "Check for updates automatically", Margin = new Thickness(0, 5), IsChecked = true });
            generalGroup.Content = generalStack;
            mainStack.Children.Add(generalGroup);

            // Appearance
            var appearanceGroup = new GroupBox
            {
                Header = "🎨 Appearance",
                Padding = new Thickness(10),
                Margin = new Thickness(0, 10, 0, 0)
            };
            var appearanceStack = new StackPanel();
            appearanceStack.Children.Add(new TextBlock { Text = "Theme:", Margin = new Thickness(0, 0, 0, 5) });
            var themeStack = new StackPanel();
            themeStack.Children.Add(new RadioButton { Content = "Light", GroupName = "Theme", IsChecked = true, Margin = new Thickness(0, 5) });
            themeStack.Children.Add(new RadioButton { Content = "Dark", GroupName = "Theme", Margin = new Thickness(0, 5) });
            themeStack.Children.Add(new RadioButton { Content = "Auto (follow system)", GroupName = "Theme", Margin = new Thickness(0, 5) });
            appearanceStack.Children.Add(themeStack);
            appearanceGroup.Content = appearanceStack;
            mainStack.Children.Add(appearanceGroup);

            // Notifications
            var notifGroup = new GroupBox
            {
                Header = "🔔 Notifications",
                Padding = new Thickness(10),
                Margin = new Thickness(0, 10, 0, 0)
            };
            var notifStack = new StackPanel();
            notifStack.Children.Add(new CheckBox { Content = "Show desktop notifications", Margin = new Thickness(0, 5), IsChecked = true });
            notifStack.Children.Add(new CheckBox { Content = "Play sound", Margin = new Thickness(0, 5) });
            notifStack.Children.Add(new CheckBox { Content = "Show notification preview", Margin = new Thickness(0, 5), IsChecked = true });
            notifGroup.Content = notifStack;
            mainStack.Children.Add(notifGroup);

            UpdateContent(mainStack);
        }

        private void ShowSurveyForm(object sender, RoutedEventArgs e)
        {
            var mainStack = CreateMainStack("Demo 6: Survey Form");

            AddDescription(mainStack, "Survey with grouped questions:");

            var surveyStack = new StackPanel { MaxWidth = 500 };

            // Demographics
            var demoGroup = new GroupBox
            {
                Header = "Demographics",
                Padding = new Thickness(10),
                Margin = new Thickness(0, 0, 0, 10)
            };
            var demoStack = new StackPanel();
            demoStack.Children.Add(new TextBlock { Text = "Age Group:" });
            var ageCombo = new ComboBox { Margin = new Thickness(0, 5, 0, 10) };
            ageCombo.Items.Add(new ComboBoxItem { Content = "18-24" });
            ageCombo.Items.Add(new ComboBoxItem { Content = "25-34" });
            ageCombo.Items.Add(new ComboBoxItem { Content = "35-44" });
            demoStack.Children.Add(ageCombo);
            demoStack.Children.Add(new TextBlock { Text = "Gender:" });
            demoStack.Children.Add(new RadioButton { Content = "Male", GroupName = "Gender", Margin = new Thickness(0, 3) });
            demoStack.Children.Add(new RadioButton { Content = "Female", GroupName = "Gender", Margin = new Thickness(0, 3) });
            demoStack.Children.Add(new RadioButton { Content = "Prefer not to say", GroupName = "Gender", Margin = new Thickness(0, 3) });
            demoGroup.Content = demoStack;
            surveyStack.Children.Add(demoGroup);

            // Product Satisfaction
            var satisfactionGroup = new GroupBox
            {
                Header = "Product Satisfaction",
                Padding = new Thickness(10),
                Margin = new Thickness(0, 0, 0, 10)
            };
            var satisfactionStack = new StackPanel();
            satisfactionStack.Children.Add(new TextBlock { Text = "How satisfied are you?", Margin = new Thickness(0, 0, 0, 5) });
            satisfactionStack.Children.Add(new RadioButton { Content = "Very Satisfied", GroupName = "Satisfaction", Margin = new Thickness(0, 3) });
            satisfactionStack.Children.Add(new RadioButton { Content = "Satisfied", GroupName = "Satisfaction", Margin = new Thickness(0, 3) });
            satisfactionStack.Children.Add(new RadioButton { Content = "Neutral", GroupName = "Satisfaction", Margin = new Thickness(0, 3) });
            satisfactionStack.Children.Add(new RadioButton { Content = "Dissatisfied", GroupName = "Satisfaction", Margin = new Thickness(0, 3) });
            satisfactionGroup.Content = satisfactionStack;
            surveyStack.Children.Add(satisfactionGroup);

            surveyStack.Children.Add(new Button { Content = "Submit Survey", Padding = new Thickness(15, 8), Background = Brushes.Green, Foreground = Brushes.White });

            mainStack.Children.Add(surveyStack);
            UpdateContent(mainStack);
        }

        private void ShowRadioGroups(object sender, RoutedEventArgs e)
        {
            var mainStack = CreateMainStack("Demo 7: Radio Button Groups");

            AddDescription(mainStack, "GroupBox is perfect for organizing radio button groups:");

            // Shipping Method
            var shippingGroup = new GroupBox
            {
                Header = "Shipping Method",
                Padding = new Thickness(10),
                Margin = new Thickness(0, 10, 0, 0)
            };
            var shippingStack = new StackPanel();
            var standardRadio = new RadioButton { GroupName = "Shipping", Margin = new Thickness(0, 5) };
            var standardStack = new StackPanel();
            standardStack.Children.Add(new TextBlock { Text = "Standard Shipping", FontWeight = FontWeights.Bold });
            standardStack.Children.Add(new TextBlock { Text = "5-7 business days - Free", FontSize = 10, Foreground = Brushes.Gray });
            standardRadio.Content = standardStack;
            shippingStack.Children.Add(standardRadio);

            var expressRadio = new RadioButton { GroupName = "Shipping", Margin = new Thickness(0, 5), IsChecked = true };
            var expressStack = new StackPanel();
            expressStack.Children.Add(new TextBlock { Text = "Express Shipping", FontWeight = FontWeights.Bold });
            expressStack.Children.Add(new TextBlock { Text = "2-3 business days - $9.99", FontSize = 10, Foreground = Brushes.Gray });
            expressRadio.Content = expressStack;
            shippingStack.Children.Add(expressRadio);

            var overnightRadio = new RadioButton { GroupName = "Shipping", Margin = new Thickness(0, 5) };
            var overnightStack = new StackPanel();
            overnightStack.Children.Add(new TextBlock { Text = "Overnight", FontWeight = FontWeights.Bold });
            overnightStack.Children.Add(new TextBlock { Text = "Next business day - $24.99", FontSize = 10, Foreground = Brushes.Gray });
            overnightRadio.Content = overnightStack;
            shippingStack.Children.Add(overnightRadio);

            shippingGroup.Content = shippingStack;
            mainStack.Children.Add(shippingGroup);

            // Payment Method
            var paymentGroup = new GroupBox
            {
                Header = "Payment Method",
                Padding = new Thickness(10),
                Margin = new Thickness(0, 10, 0, 0)
            };
            var paymentStack = new StackPanel();
            paymentStack.Children.Add(new RadioButton { Content = "💳 Credit Card", GroupName = "Payment", Margin = new Thickness(0, 5), IsChecked = true });
            paymentStack.Children.Add(new RadioButton { Content = "🏦 PayPal", GroupName = "Payment", Margin = new Thickness(0, 5) });
            paymentStack.Children.Add(new RadioButton { Content = "🏪 Bank Transfer", GroupName = "Payment", Margin = new Thickness(0, 5) });
            paymentGroup.Content = paymentStack;
            mainStack.Children.Add(paymentGroup);

            UpdateContent(mainStack);
        }

        private void ShowComparison(object sender, RoutedEventArgs e)
        {
            var mainStack = CreateMainStack("Demo 8: GroupBox vs Expander vs Border");

            AddDescription(mainStack, "Understanding the differences:");

            var grid = new UniformGrid { Rows = 1, Columns = 3, Margin = new Thickness(0, 10, 0, 0) };

            // GroupBox
            var groupBox = new GroupBox
            {
                Header = "GroupBox",
                Margin = new Thickness(5),
                Padding = new Thickness(10)
            };
            var gbStack = new StackPanel();
            gbStack.Children.Add(new TextBlock { Text = "Always visible", Margin = new Thickness(0, 3) });
            gbStack.Children.Add(new TextBlock { Text = "Clear grouping", Margin = new Thickness(0, 3) });
            gbStack.Children.Add(new TextBlock { Text = "With header", Margin = new Thickness(0, 3) });
            gbStack.Children.Add(new TextBlock { Text = "Static content", Margin = new Thickness(0, 3) });
            groupBox.Content = gbStack;
            grid.Children.Add(groupBox);

            // Expander
            var expander = new System.Windows.Controls.Expander
            {
                Header = "Expander",
                Margin = new Thickness(5)
            };
            var expStack = new StackPanel { Padding = new Thickness(10) };
            expStack.Children.Add(new TextBlock { Text = "Can hide", Margin = new Thickness(0, 3) });
            expStack.Children.Add(new TextBlock { Text = "Saves space", Margin = new Thickness(0, 3) });
            expStack.Children.Add(new TextBlock { Text = "User controlled", Margin = new Thickness(0, 3) });
            expStack.Children.Add(new TextBlock { Text = "Collapsible", Margin = new Thickness(0, 3) });
            expander.Content = expStack;
            grid.Children.Add(expander);

            // Border
            var border = new Border
            {
                BorderBrush = Brushes.Gray,
                BorderThickness = new Thickness(1),
                Margin = new Thickness(5),
                Padding = new Thickness(10)
            };
            var borderStack = new StackPanel();
            borderStack.Children.Add(new TextBlock { Text = "Border", FontWeight = FontWeights.Bold, Margin = new Thickness(0, 0, 0, 5) });
            borderStack.Children.Add(new TextBlock { Text = "No header", Margin = new Thickness(0, 3) });
            borderStack.Children.Add(new TextBlock { Text = "Just decoration", Margin = new Thickness(0, 3) });
            borderStack.Children.Add(new TextBlock { Text = "Simple container", Margin = new Thickness(0, 3) });
            border.Child = borderStack;
            grid.Children.Add(border);

            mainStack.Children.Add(grid);
            UpdateContent(mainStack);
        }

        private void ShowNestedGroups(object sender, RoutedEventArgs e)
        {
            var mainStack = CreateMainStack("Demo 9: Nested GroupBoxes");

            AddDescription(mainStack, "GroupBox can be nested for hierarchical organization:");

            // Main configuration group
            var mainGroup = new GroupBox
            {
                Header = "System Configuration",
                Padding = new Thickness(10),
                Margin = new Thickness(0, 10, 0, 0)
            };
            var configStack = new StackPanel();

            // Nested: Display Settings
            var displayGroup = new GroupBox
            {
                Header = "Display",
                Margin = new Thickness(0, 5, 0, 0),
                Padding = new Thickness(5)
            };
            var displayStack = new StackPanel();
            displayStack.Children.Add(new TextBlock { Text = "Resolution:" });
            var resCombo = new ComboBox { Margin = new Thickness(0, 5) };
            resCombo.Items.Add(new ComboBoxItem { Content = "1920x1080" });
            resCombo.Items.Add(new ComboBoxItem { Content = "2560x1440" });
            displayStack.Children.Add(resCombo);
            displayStack.Children.Add(new CheckBox { Content = "Full screen", Margin = new Thickness(0, 5) });
            displayGroup.Content = displayStack;
            configStack.Children.Add(displayGroup);

            // Nested: Audio Settings
            var audioGroup = new GroupBox
            {
                Header = "Audio",
                Margin = new Thickness(0, 5, 0, 0),
                Padding = new Thickness(5)
            };
            var audioStack = new StackPanel();
            audioStack.Children.Add(new TextBlock { Text = "Volume:" });
            audioStack.Children.Add(new Slider { Minimum = 0, Maximum = 100, Value = 75, Margin = new Thickness(0, 5) });
            audioStack.Children.Add(new CheckBox { Content = "Mute", Margin = new Thickness(0, 5) });
            audioGroup.Content = audioStack;
            configStack.Children.Add(audioGroup);

            // Nested: Controls
            var controlsGroup = new GroupBox
            {
                Header = "Controls",
                Margin = new Thickness(0, 5, 0, 0),
                Padding = new Thickness(5)
            };
            var controlsStack = new StackPanel();
            controlsStack.Children.Add(new CheckBox { Content = "Enable gamepad", Margin = new Thickness(0, 5) });
            controlsStack.Children.Add(new CheckBox { Content = "Vibration", Margin = new Thickness(0, 5), IsChecked = true });
            controlsGroup.Content = controlsStack;
            configStack.Children.Add(controlsGroup);

            mainGroup.Content = configStack;
            mainStack.Children.Add(mainGroup);

            UpdateContent(mainStack);
        }

        // Helper methods
        private StackPanel CreateMainStack(string title)
        {
            var stack = new StackPanel();
            stack.Children.Add(new TextBlock
            {
                Text = title,
                FontSize = 24,
                FontWeight = FontWeights.Bold,
                Margin = new Thickness(0, 0, 0, 10)
            });
            return stack;
        }

        private void AddDescription(StackPanel parent, string text)
        {
            parent.Children.Add(new TextBlock
            {
                Text = text,
                FontSize = 14,
                TextWrapping = TextWrapping.Wrap,
                Margin = new Thickness(0, 0, 0, 10)
            });
        }

        private void UpdateContent(StackPanel content)
        {
            var container = new Border
            {
                Background = Brushes.White,
                Margin = new Thickness(20),
                Padding = new Thickness(30),
                CornerRadius = new CornerRadius(10)
            };
            container.Child = content;
            ContentPanel.Content = container;
        }
    }
}
