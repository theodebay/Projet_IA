namespace ProjetIA
{
    class Player
    {
        public int health;
        public string name;
        private int armor;
        private int baseDmgMelee;
        private int attack;
        private int baseDmgDst;
        private int agility;

        public Player(string name,int health, int attack, int armor, int agility, int baseDmgMelee, int baseDmgDst)
        {
            this.name = name;
            this.health = health;
            this.armor = armor;
            this.baseDmgMelee = baseDmgMelee;
            this.attack = attack;
            this.baseDmgDst = baseDmgDst;
            this.agility = agility;
        }

        public string ToFact()
        {
            string fact = ("monster " + name + " " + health + " " + armor + " " + attack + " " + baseDmgMelee + " " + "2d8 " + agility + " " + baseDmgDst + " " + "2d4");
            return fact;
        }

        public string GetName()
        {
            return name;
        }

        public override string ToString()
        {
            return "Player " + name;
        }
    }
}
