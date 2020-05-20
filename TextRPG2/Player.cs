namespace TextRPG2
{
    enum PlayerType { 
        None=0,
        Knight=1,
        Archer=2,
        Mage=3

    }
    class Player
    {
        protected PlayerType type;
        protected int hp;
        protected int attack;
    }
    class Knight : Player{
         Knight(){
                type = PlayerType.Knight;
        }
    }

    class Archer : Player{
         Archer(){
             type = PlayerType.Archer;
        }
    }

    class Mage : Player{
         Mage(){
             type = PlayerType.Mage;
         }
    }
}