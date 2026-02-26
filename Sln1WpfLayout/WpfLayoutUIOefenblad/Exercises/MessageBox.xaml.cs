using System.Windows;
using System.Windows.Controls;
using WpfLayoutUIOefenblad.Helpers;

namespace WpfLayoutUIOefenblad.Exercises;

[NavPage(title: "MessageBox", description: "Dialoogvensters", order: 10)]
public partial class MessageBoxDialog : Page
{
    public MessageBoxDialog()
    {
        InitializeComponent();
    }

    private void btnOpslaan_Click(object sender, RoutedEventArgs e)
    {
        // ✅ Opdracht 1 : eerste MessageBox met bevestigingsvraag
        MessageBoxResult result = MessageBox.Show(
            "Ben je zeker dat je wilt opslaan?",
            "Bevestiging",
            MessageBoxButton.OKCancel,
            MessageBoxImage.Question
        );

        // ✅ Opdracht 2 : tweede MessageBox alleen als op "Ok" geklikt werd
        if (result == MessageBoxResult.OK)
        {
            MessageBox.Show(
                "Het bestand is succesvol opgeslagen.",
                "Opgeslagen",
                MessageBoxButton.OK,
                MessageBoxImage.Information
            );
        }
    }
}