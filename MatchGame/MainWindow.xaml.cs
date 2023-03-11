using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace MatchGame
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            SetUpGame();
        }

        private void SetUpGame()
        {
            List<string> animalEmoji = new List<string>()
            {
                "😺", "😺",
                "🐵", "🐵",
                "🐶", "🐶",
                "🦁", "🦁",
                "🐮", "🐮",
                "🐷", "🐷",
                "🐴", "🐴",
                "🐔", "🐔",
            }; /* Criando uma lista de emojis */

            Random random = new Random(); /* Criando um gerador de número alteatório */

            foreach (TextBlock textBlock in mainGrid.Children.OfType<TextBlock>())
            { /* Procurando por todos os TextBlock presentes no mainGrid */
                int index = random.Next(animalEmoji.Count); /* Gerando um número de 0 até o tamanho da lista */
                string nextEmoji = animalEmoji[index]; /* pegando o emoji na posição do index gerado*/
                textBlock.Text = nextEmoji; /* atualizando o TextBlock com o emoji */
                animalEmoji.RemoveAt(index); /* removendo o emoji da lista */
            }

        }
    }
}
