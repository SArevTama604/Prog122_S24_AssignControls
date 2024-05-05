using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Prog122_S24_AssignControls
{
    // Hero class definition
    public class Hero
    {
        // Fields
        private string name;
        private int health;
        private int strength;
        private int agility;
        private int intelligence;

        // Constructor
        public Hero(string name, int health, int strength, int agility, int intelligence)
        {
            this.name = name;
            this.health = health;
            this.strength = strength;
            this.agility = agility;
            this.intelligence = intelligence;
        }

        // Properties
        public string Name { get { return name; } }
        public int Health { get { return health; } set { health = value; } }
        public int Strength { get { return strength; } }
        public int Agility { get { return agility; } }
        public int Intelligence { get { return intelligence; } }

        // Methods
        public void Attack(Hero target)
        {
            
        }

        public void Defend()
        {
            
        }

        public void UseSpecialAbility()
        {
            
        }
    }

    // Party class definition
    public class Party
    {
        // Collection
        private List<Hero> heroes;

        // Constructor
        public Party()
        {
            heroes = new List<Hero>();
        }

        // Methods
        public void AddHero(Hero hero)
        {
            heroes.Add(hero);
        }

        public void RemoveHero(Hero hero)
        {
            heroes.Remove(hero);
        }

        public Hero GetHero(int index)
        {
            if (index >= 0 && index < heroes.Count)
                return heroes[index];
            else
                return null;
        }

        public int CountHeroes()
        {
            return heroes.Count;
        }

        // Method to get all heroes in the party
        public List<Hero> GetHeroes()
        {
            return heroes;
        }
    }

    // MainWindow class
    public partial class MainWindow : Window
    {
        private Party party;

        public MainWindow()
        {
            InitializeComponent();
            party = new Party(); // Initialize the party
        }

        private void CreateHero_Click(object sender, RoutedEventArgs e)
        {
            // Retrieve hero information from textboxes
            string name = txtHeroName.Text;
            int health = int.Parse(txtHealth.Text);
            int strength = int.Parse(txtStrength.Text);
            int agility = int.Parse(txtAgility.Text);
            int intelligence = int.Parse(txtIntelligence.Text);

            // Create a new hero
            Hero newHero = new Hero(name, health, strength, agility, intelligence);

            // Add the hero to the party
            party.AddHero(newHero);

            // Update the listbox to display the party
            UpdatePartyListBox();
        }

        private void UpdatePartyListBox()
        {
            lstParty.Items.Clear(); // Clear the listbox

            // Add each hero in the party to the listbox
            foreach (Hero hero in party.GetHeroes())
            {
                lstParty.Items.Add(hero.Name);
            }
        }
    }
}