using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EBolten_Project2_GasMileage
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            string input = TxtBoxInput.Text;
            int numInput = System.Convert.ToInt32(input);
            int zodiac = numInput % 12;
            string result;

            switch (zodiac)
            {
                case 0:
                    result = "Monkey";
                    pictureMonkey.Visible = true;

                    pictureRooster.Visible = false;
                    pictureDog.Visible = false;
                    picturePig.Visible = false;
                    pictureRat.Visible = false;
                    pictureOx.Visible = false;
                    pictureTiger.Visible = false;
                    pictureRabbit.Visible = false;
                    pictureDragon.Visible = false;
                    pictureSnake.Visible = false;
                    pictureHorse.Visible = false;
                    pictureSheep.Visible = false;

                    break;
                case 1:
                    result = "Rooster";
                    pictureRooster.Visible = true;

                    pictureMonkey.Visible = false;
                    pictureDog.Visible = false;
                    picturePig.Visible = false;
                    pictureRat.Visible = false;
                    pictureOx.Visible = false;
                    pictureTiger.Visible = false;
                    pictureRabbit.Visible = false;
                    pictureDragon.Visible = false;
                    pictureSnake.Visible = false;
                    pictureHorse.Visible = false;
                    pictureSheep.Visible = false;
                    break;
                case 2:
                    result = "Dog";
                    pictureDog.Visible = true;

                    pictureMonkey.Visible = false;
                    pictureRooster.Visible = false;
                    picturePig.Visible = false;
                    pictureRat.Visible = false;
                    pictureOx.Visible = false;
                    pictureTiger.Visible = false;
                    pictureRabbit.Visible = false;
                    pictureDragon.Visible = false;
                    pictureSnake.Visible = false;
                    pictureHorse.Visible = false;
                    pictureSheep.Visible = false;
                    break;
                case 3:
                    result = "Pig";
                    picturePig.Visible = true;

                    pictureMonkey.Visible = false;
                    pictureRooster.Visible = false;
                    pictureDog.Visible = false;
                    pictureRat.Visible = false;
                    pictureOx.Visible = false;
                    pictureTiger.Visible = false;
                    pictureRabbit.Visible = false;
                    pictureDragon.Visible = false;
                    pictureSnake.Visible = false;
                    pictureHorse.Visible = false;
                    pictureSheep.Visible = false;
                    break;
                case 4:
                    result = "Rat";
                    pictureRat.Visible = true;

                    pictureMonkey.Visible = false;
                    pictureRooster.Visible = false;
                    pictureDog.Visible = false;
                    picturePig.Visible = false;
                    pictureOx.Visible = false;
                    pictureTiger.Visible = false;
                    pictureRabbit.Visible = false;
                    pictureDragon.Visible = false;
                    pictureSnake.Visible = false;
                    pictureHorse.Visible = false;
                    pictureSheep.Visible = false;
                    break;
                case 5:
                    result = "Ox";
                    pictureOx.Visible = true;

                    pictureMonkey.Visible = false;
                    pictureRooster.Visible = false;
                    pictureDog.Visible = false;
                    picturePig.Visible = false;
                    pictureRat.Visible = false;
                    pictureTiger.Visible = false;
                    pictureRabbit.Visible = false;
                    pictureDragon.Visible = false;
                    pictureSnake.Visible = false;
                    pictureHorse.Visible = false;
                    pictureSheep.Visible = false;
                    break;
                case 6:
                    result = "Tiger";
                    pictureTiger.Visible = true;

                    pictureMonkey.Visible = false;
                    pictureRooster.Visible = false;
                    pictureDog.Visible = false;
                    picturePig.Visible = false;
                    pictureRat.Visible = false;
                    pictureOx.Visible = false;
                    pictureRabbit.Visible = false;
                    pictureDragon.Visible = false;
                    pictureSnake.Visible = false;
                    pictureHorse.Visible = false;
                    pictureSheep.Visible = false;
                    break;
                case 7:
                    result = "Rabbit";
                    pictureRabbit.Visible = true;

                    pictureMonkey.Visible = false;
                    pictureRooster.Visible = false;
                    pictureDog.Visible = false;
                    picturePig.Visible = false;
                    pictureRat.Visible = false;
                    pictureOx.Visible = false;
                    pictureTiger.Visible = false;
                    pictureDragon.Visible = false;
                    pictureSnake.Visible = false;
                    pictureHorse.Visible = false;
                    pictureSheep.Visible = false;
                    break;
                case 8:
                    result = "Dragon";
                    pictureDragon.Visible = true;

                    pictureMonkey.Visible = false;
                    pictureRooster.Visible = false;
                    pictureDog.Visible = false;
                    picturePig.Visible = false;
                    pictureRat.Visible = false;
                    pictureOx.Visible = false;
                    pictureTiger.Visible = false;
                    pictureRabbit.Visible = false;
                    pictureSnake.Visible = false;
                    pictureHorse.Visible = false;
                    pictureSheep.Visible = false;
                    break;
                case 9:
                    result = "Snake";
                    pictureSnake.Visible = true;

                    pictureMonkey.Visible = false;
                    pictureRooster.Visible = false;
                    pictureDog.Visible = false;
                    picturePig.Visible = false;
                    pictureRat.Visible = false;
                    pictureOx.Visible = false;
                    pictureTiger.Visible = false;
                    pictureRabbit.Visible = false;
                    pictureDragon.Visible = false;
                    pictureHorse.Visible = false;
                    pictureSheep.Visible = false;
                    break;
                case 10:
                    result = "Horse";
                    pictureHorse.Visible = true;

                    pictureMonkey.Visible = false;
                    pictureRooster.Visible = false;
                    pictureDog.Visible = false;
                    picturePig.Visible = false;
                    pictureRat.Visible = false;
                    pictureOx.Visible = false;
                    pictureTiger.Visible = false;
                    pictureRabbit.Visible = false;
                    pictureDragon.Visible = false;
                    pictureSnake.Visible = false;
                    pictureSheep.Visible = false;
                    break;
                case 11:
                    result = "Sheep";
                    pictureSheep.Visible = true;

                    pictureMonkey.Visible = false;
                    pictureRooster.Visible = false;
                    pictureDog.Visible = false;
                    picturePig.Visible = false;
                    pictureRat.Visible = false;
                    pictureOx.Visible = false;
                    pictureTiger.Visible = false;
                    pictureRabbit.Visible = false;
                    pictureDragon.Visible = false;
                    pictureSnake.Visible = false;
                    pictureHorse.Visible = false;
                    break;
                default:
                    result = "Invalid Year";
                    break;
            }

            lblResult.Text = result + "!";
        }

        private void pictureZodiac_Click(object sender, EventArgs e)
        {

        }
    }
}
