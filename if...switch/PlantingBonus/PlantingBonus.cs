/* PlantingBonus.cs Author: Lang
 * Describes the characteristics of a
 * tree plant bonus to include the minimum
 * number of sapling, actual number planted
 * and the bonus calculation amount.
 * The PlantingBonus class is used to set the
 * amount for the bonus.
 * **************************************/
using System;
namespace PlantingBonus
{
    class PlantingBonus
    {
        private const decimal BONUS_PER_5_OVER = 75.50M;
        private string foresterNumber;
        private char classif;
        private int minimumToPlant = 0;
        private int bonusSaplingsPlanted;

        public PlantingBonus()
        {
        }

        public PlantingBonus(string fNum
                           , char employmentLevel
                           , int minPlanted
                           , int actualPlanted)
        {
            foresterNumber = fNum;
            minimumToPlant = minPlanted;
            bonusSaplingsPlanted = actualPlanted - minPlanted;
            classif = employmentLevel;
        }

        public PlantingBonus(string fNum
                           , int minPlanted
                           , int actualPlanted)
        {
            foresterNumber = fNum;
            minimumToPlant = minPlanted;
            bonusSaplingsPlanted = actualPlanted - minPlanted;
        }

        public string ForesterNumber
        {
            get
            {
                return foresterNumber;
            }
            set
            {
                foresterNumber = value;
            }
        }

        public char Classif
        {
            get
            {
                return classif;
            }
            set
            {
                classif = value;
            }
        }

        public int MinimumToPlant
        {
            get
            {
                return minimumToPlant;
            }
            set
            {
                minimumToPlant = value;
            }
        }

        public int BonusSaplingsPlanted
        {
            get
            {
                return bonusSaplingsPlanted;
            }
            set
            {
                bonusSaplingsPlanted = value;
            }
        }

        public decimal SetBonus()
        {
            decimal bonusPayment = 0;

            if (bonusSaplingsPlanted > 0)
            {
                bonusPayment = (bonusSaplingsPlanted / 5 * BONUS_PER_5_OVER) + 75.00M;

                if (classif == '4')
                {
                    if (bonusSaplingsPlanted > 20)
                        bonusPayment += 200;
                    else
                        bonusPayment += 50;
                }
                else
                {
                    if (classif == '1')
                    {
                        if (bonusSaplingsPlanted < 20)
                            bonusPayment -= 50;
                        else
                            bonusPayment += 100;
                    }
                    else
                    {
                        if (bonusSaplingsPlanted > 19)
                            bonusPayment += 100;
                    }
                }
            }

            return bonusPayment;
        }

        public string ReturnNameOfClassification()
        {
            string classificationName;
            switch (classif)
            {
                case '1':
                    classificationName = "Trainee";
                    break;
                case '2':
                    classificationName = "Junior";
                    break;
                case '3':
                    classificationName = "Regular";
                    break;
                case '4':
                    classificationName = "Senior";
                    break;
                default:
                    classificationName = "Unspecified";
                    break;
            }
            return classificationName;
        }

        public override string ToString()
        {
            return "\tPay Bonus App" +
            "\n\nForester number: " + foresterNumber +
            "\nClassification: " + ReturnNameOfClassification() +
            "\nMinimum planted: " + minimumToPlant +
            "\nBonus Saplings planted: " + bonusSaplingsPlanted +
            "\n\nBonus: " + SetBonus().ToString("C");
        }
    }
}