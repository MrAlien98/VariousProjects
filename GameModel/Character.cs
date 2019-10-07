using System;

namespace GameModel
{
    public class Character
    {

        private String name;

        private string image;

        private char direction;

        private Boolean jumping;

        private int posX;
        private int posY;
        private int scoreStreak;

        public Character(String name, string image, char direction)
        {
            this.name = name;
            this.image = image;
            this.direction = direction;
            this.posX = 0;
            this.posY = 0;
            jumping = false;
            scoreStreak = 0;
        }
        
        public void jump()
        {
            setJumping(true);
            while (getPosY() > 260)
            {
                setPosY(getPosY() - 2);
            }
            /*else
            {
                jumpDown();
            }*/
            jumping = false;
        }

        public void jumpDown()
        {
            if (getPosY() < 350)
            {
                setPosY(getPosY() + 2);
            }
        }

        public void move()
        {
            if (getDirection().Equals('D'))
            {
                setPosX(getPosX() + 10);
            }else if (getDirection().Equals('I'))
            {
                setPosX(getPosX() - 10);
            }
        }

        public void setName(string name)
        {
            this.name = name;
        }

        public void setImage(string image)
        {
            this.image = image;
        }

        public void setDirection(char direction)
        {
            this.direction = direction;
        }

        public void setPosX(int posX)
        {
            this.posX = posX;
        }

        public void setPosY(int posY)
        {
            this.posY = posY;
        }

        public void setScoreStreak(int scoreStreak)
        {
            this.scoreStreak = scoreStreak;
        }

        public string getName()
        {
            return name;
        }

        public string getImage()
        {
            return image;
        }

        public char getDirection()
        {
            return direction;
        }

        public int getPosX()
        {
            return posX;
        }

        public int getPosY()
        {
            return posY;
        }

        public int getScoreStreak()
        {
            return scoreStreak;
        }

        public Boolean isJumping()
        {
            return jumping;
        }

        public void setJumping(Boolean jumping)
        {
            this.jumping = jumping;
        }

    }
}
