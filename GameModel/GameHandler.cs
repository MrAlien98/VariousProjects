using System;
using System.Collections.Generic;
using System.Text;

namespace GameModel
{
    public class GameHandler
    {

        private Character player1;
        private Character player2;

        public GameHandler(string name1, string name2)
        {
            player1 = new Character(name1, "", 'D');
            player2 = new Character(name2, "", 'I');

            player1.setPosX(20);
            player1.setPosY(350);

            player2.setPosX(640);
            player2.setPosY(350);
        }

        public void setPlayer1(Character player1)
        {
            this.player1 = player1;
        }

        public void setPlayer2(Character player2)
        {
            this.player2 = player2;
        }

        public Character getPlayer1()
        {
            return player1;
        }

        public Character getPlayer2()
        {
            return player2;
        }

    }
}
