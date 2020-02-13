using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1.EnglishVersion
{
    public partial class Tips : UserControl
    {
        public Tips()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            switch (textBox1.Text)
            {
                case "Иглика": 
                    LocationAndSunlight.Visible = true; Temperature.Visible = true; Soil.Visible = true; Fertilization.Visible = true; Transplanting.Visible = true;
                    LocationAndSunlightText.Text = "Игликата харесва места с повече слънчева светлина през пролетта, но през лятото  преките лъчи могат да я убият. Ако я отглеждате на открито, изберете място с шарена сянка.";
                    TemperatureText.Text = "Предпочита умерената температура, но понася и топлината. През зимата градусите трябва да са в рамките на 5-10°C, а през лятото до 28°C, максимум 30°C.";
                    SoilText.Text = "Игликата харесва почва, богата на хумус. За да дава повече цвят, може 1-2 пъти в месеца да я подхранвате с минерални торове. Ако пък я гледате на открито, задължително я покрийте с торфен мъх, за да я предпазите през зимата.";
                    FertilizationText.Text = "Подхранването на игликите се прави с повишено внимание, защото са чувствителни към някои соли, както и към липсата на такива. Подходящи са торовете, съдържащи желязо.";
                    Transplanting.Text = "Пресаждане";
                    TransplantingText.Text = "Може да пресадите примулата след като приключи периода на активен цъфтеж, като първите 24 часа след присаждане е желателно да осигурите на растението по-сенчесто място, докато свикне с новия си дом.";
                    break;
                case "Primrose":
                    LocationAndSunlight.Visible = true; Temperature.Visible = true; Soil.Visible = true; Fertilization.Visible = true; Transplanting.Visible = true;
                    LocationAndSunlightText.Text = "Primrose like places with more sunlight in the spring, but in the summer direct rays can kill it. If you are growing it outdoors, choose a place with a changing shadow.";
                    TemperatureText.Text = "Prefers a moderate temperature but also tolerates heat. In winter, degrees should be within 41-50°F (5-10°C), and in summer up to 82.4°F (28°C), maximum 86°F (30°C) degrees.";
                    SoilText.Text = "Primrose likes soil rich in humus. To give more color, you can feed it 1-2 times a month with mineral fertilizers. If you are looking at it outdoors, be sure to cover it with peat moss to protect it in winter.";
                    FertilizationText.Text = "Fertilization of primrose is done with caution because they are sensitive to some salts and lack thereof. Fertilizers containing iron are suitable.";
                    Transplanting.Text = "Transplanting";
                    TransplantingText.Text = "You can transplant the primrose after the period of active flowering is over, and it is desirable to provide the plant with a more shady place during the first 24 hours after grafting until it becomes accustomed to your new home."; 
                    break;
                case "Каланхое":
                    LocationAndSunlight.Visible = true; Temperature.Visible = true; Soil.Visible = true; Fertilization.Visible = true; Transplanting.Visible = true;
                    LocationAndSunlightText.Text = "Каланхоето е светлолюбиво растение, затова е желателно да му осигурявате около 8 часа светлина дневно. Но тъй като е и растение на късия ден, то може да издържа и на по-сенчести места, само че няма да цъфти толкова обилно.";
                    TemperatureText.Text = "Каланхоето обича да му е топло. Хубаво е температурите да не падат по 17-20°C. Предпочита по-влажен климат, но вирее и на умерен.";
                    SoilText.Text = "Каланхоето не е капризно растение, затова го устройва обикновена почвена смес. Желателно е да се тори около 3 пъти месечно с минерални торове, тъй като понякога страда от недостиг на микроелементи като цинк или калций.";
                    FertilizationText.Text = "За да расте здраво, можете също да подхранвате почвата с черупки от яйце или като поливате растението с малко прясно мляко. След появата на цветни пъпки е добре да спрете торенето.";
                    Transplanting.Text = "Размножаване";
                    TransplantingText.Text = "Каланхоете се размножава с помощта на резници или семена, но навън трябва да е сравнително топло. Растението се пресажда на пролет."; 
                    break;
                case "Kalanchoe":
                    LocationAndSunlight.Visible = true; Temperature.Visible = true; Soil.Visible = true; Fertilization.Visible = true; Transplanting.Visible = true;
                    LocationAndSunlightText.Text = "Kalanchoe is a light-loving plant, so it is advisable to provide it with about 8 hours of sunlight a day. But because it is also a plant on a short day, it can withstand even more shady places, but it will not bloom as much.";
                    TemperatureText.Text = "Kalancho likes to keep him warm. It is nice that temperatures do not drop by 62-68.6°F (17-20°C). Prefers a humid climate, but thrives in temperate, too.";
                    SoilText.Text = "Kalanchoe is not a capricious plant, so it is made up of ordinary soil mix. It is desirable to fertilize about 3 times a month with mineral fertilizers as it sometimes suffers from a deficiency of trace elements such as zinc or calcium.";
                    FertilizationText.Text = "To grow well, you can also nourish the soil with egg shells or by watering the plant with some fresh milk. After the appearance of flower buds, it is good to stop fertilizing.";
                    Transplanting.Text = "Reproduction";
                    TransplantingText.Text = "Kalanchoea is propagated by cuttings or seeds, but outside it must be relatively warm. The plant is transplanted in spring.";
                    break;
                case "Теменуга":
                    LocationAndSunlight.Visible = true; Temperature.Visible = true; Soil.Visible = true; Fertilization.Visible = true; Transplanting.Visible = true;
                    LocationAndSunlightText.Text = "Мястото трябва да бъде избрано сравнително светло, но с лека сянка. Това означава, че непрекъснатият удар на слънчева светлина върху цветята може да доведе до тяхното изсъхване и смърт.";
                    TemperatureText.Text = "Тъй като теменугата е особено издръжлива, тя ще устои много добре на простудни студове, дори до -15°C и издържа до топлина 20°C.";
                    SoilText.Text = "Осигурете почва, която е добре изцедена и богата на минерали за красив цъфтеж. Но обикновената градинска почва също не е лош избор добре.";
                    FertilizationText.Text = "За да се хранят цветята е само компост, не се изисква повече тор. За по-дълъг цъфтеж избледнените пъпки трябва да бъдат отстранени незабавно.";
                    Transplanting.Text = "Вредители";
                    TransplantingText.Text = "Вредителите са охлюви и листни въшки. Листните въшки трябва да се отстранят веднага с подходящ препарат, в противен случай рискувате трицветната теменуга да се зарази, листата и да пожълтеят и цветчетата да растат с аномалии."; 
                    break;
                case "Viola":
                    LocationAndSunlight.Visible = true; Temperature.Visible = true; Soil.Visible = true; Fertilization.Visible = true; Transplanting.Visible = true;
                    LocationAndSunlightText.Text = "The location should be chosen relatively light but with a light shade. This means that the continuous impact of sunlight on the flowers can lead to their drying and death.";
                    TemperatureText.Text = "Since violet is particularly hardy, it will resist winder colds very well, even down to 5°F (-15°C) and max 68°F (20°C) .";
                    SoilText.Text = "Provide soil that is quite rich and well drained for beautiful blooming. But ordinary garden soil is fine, too.";
                    FertilizationText.Text = "To feed the flowers is just compost, no more fertilizer is required. For longer flowering, faded buds should be removed immediately.";
                    Transplanting.Text = "Pests";
                    TransplantingText.Text = "The pests are snails and aphids. Aphids should be removed immediately with an appropriate detergent, otherwise you risk the three-colored violet becoming infected, the leaves and yellowing and the flowers growing with anomalies."; 
                    break;
                case "Гербер":
                    LocationAndSunlight.Visible = true; Temperature.Visible = true; Soil.Visible = true; Fertilization.Visible = true; Transplanting.Visible = true;
                    LocationAndSunlightText.Text = "Това е най-важното условие на цветето. За да расте здраво и красиво, цветето се нуждае от място с пряка светлина, която да го огрява през целия ден. И най-малкото засенчване може да не му понесе. Растението обича топлите места и преките слънчеви лъчи, но се разболява, ако е на течение.";
                    TemperatureText.Text = "През зимата не оставяйте цветето в стая, където температурата пада под 15°C.";
                    SoilText.Text = "Гербер в саксия може да си отгледате в обикновена градинска пръст или в смес от пясък, торф и листовка. Важно е почвата да е добре дренирана, да е лека и задължително да няма компост.";
                    FertilizationText.Text = "През пролетта и лятото задължително наторявайте гербера редовно – за предпочитане с фосфорна тор или тор, богата на манган и желязо.";
                    Transplanting.Text = "Вредители";
                    TransplantingText.Text = "Герберите често са нападани от акари, белокрилка, гъсеници, листни въшки и трипс, разболяват се и от гъбички. Наблюдавайте листата на цветето – ако променят тъмния си цвят, значи нещо не достига на растението."; 
                    break;
                case "Gerbera":
                    LocationAndSunlight.Visible = true; Temperature.Visible = true; Soil.Visible = true; Fertilization.Visible = true; Transplanting.Visible = true;
                    LocationAndSunlightText.Text = "This is the most important condition of the flower. To grow healthy and beautiful, the flower needs a spot with direct light to keep it warm throughout the day. Even the slightest shading may not bear it. The plant loves warm places and direct sunlight, but becomes ill if it is flowing.";
                    TemperatureText.Text = "In winter, do not leave the flower in a room where the temperature drops below 15°C.";
                    SoilText.Text = "You can grow gerberas in a pot in ordinary garden soil or in a mixture of sand, peat and leaflet. It is important that the soil is well drained, light and must not have compost.";
                    FertilizationText.Text = "In the spring and summer, be sure to fertilize the gerbera regularly - preferably with phosphorous fertilizer or fertilizer rich in manganese and iron.";
                    Transplanting.Text = "Pests";
                    TransplantingText.Text = "Gerberas are often attacked by mites, whitefly, caterpillars, aphids and thrips, and are also affected by fungi. Watch the leaves of the flower - if they change their dark color, then something is missing from the plant. "; 
                    break;
                case "Циклама":
                    LocationAndSunlight.Visible = true; Temperature.Visible = true; Soil.Visible = true; Fertilization.Visible = true; Transplanting.Visible = true;
                    LocationAndSunlightText.Text = "Цикламата не обича прекалените слънчеви лъчи. Помещения с недостиг на слънчева светлина, със северно изложение са предпочитани от цветето.";
                    TemperatureText.Text = "Чувства се добре при температури 10-15°C. При температура над 20°C, растението е обречено на смърт.";
                    SoilText.Text = "Използвайте торфо-почвена смес с гарантиран произход.";
                    FertilizationText.Text = "Цикламата се подхранва с тор редовно. През май-септември не трябва да се наторява. При развита листна розетка и видими признаци на цъфтеж се използва фосфорен тор за подхранване.";
                    Transplanting.Text = "ВНИМАНИЕ";
                    TransplantingText.Text = "След появата на първите пъпки саксията не бива да се премества, защото те ще окапят. След като пожълтеят и окапят листата на цикламата, саксиите се поставят на тъмно и прохладно място."; 
                    break;
                case "Cyclamen":
                    LocationAndSunlight.Visible = true; Temperature.Visible = true; Soil.Visible = true; Fertilization.Visible = true; Transplanting.Visible = true;
                    LocationAndSunlightText.Text = "The cyclamen does not like too much sunlight. Premises with a lack of sunlight, facing north are preferred by the flower.";
                    TemperatureText.Text = "Feels good at 10-15°C Celsius. At temperatures above 20°C, the plant is doomed to die.";
                    SoilText.Text = "Use a peat-soil mixture of guaranteed origin.";
                    FertilizationText.Text = "Cyclamen feeds on fertilizer regularly. May-September should not be fertilized. When the leaf rosette is developed and visible signs of flowering are used, phosphorus fertilizer is used to feed";
                    Transplanting.Text = "WARNING";
                    TransplantingText.Text = "After the first buds appear, the pot should not be moved because they will drip.\n After yellowing and dropping the leaves of the cyclamen, the pots are placed in a dark and cool place."; 
                    break;
                case "Мушкато":
                    LocationAndSunlight.Visible = true; Temperature.Visible = true; Soil.Visible = true; Fertilization.Visible = true; Transplanting.Visible = true;
                    LocationAndSunlightText.Text = "Мушкатото обича много светлина, при хубаво осветление то ще се развива добре и ще ви радва с красиви и обилни цветове, а листата ще бъдат здрави и сочни. През зимата е добре да има и допълнителна светлина от изкуствени източници. ";
                    TemperatureText.Text = "В период на растеж и цъфтене мушкатото се чувства най-комфортно при температура 20-25 °C. Оптималната температура за зимния сезон е 12°C - 15°C.";
                    SoilText.Text = "Най-добре за мушкатото е да бъде посадено в смесена почва (градинска пръст, пясък и тор). Трябва добре да се оттича и да не задържа вода.";
                    FertilizationText.Text = "Мушкатото трябва да се подхранва два-три пъти месечно, да се очиства от прецъфтелите цветове и да получава много светлина.";
                    Transplanting.Text = "Размножаване";
                    TransplantingText.Text = "Пролетта е идеалното време за разсад на мушкато. За целта отделете няколко резници и ги оставете за няколко часа да завехнат преди да ги боднете на ново място."; 
                    break;
                case "Geranium":
                    LocationAndSunlight.Visible = true; Temperature.Visible = true; Soil.Visible = true; Fertilization.Visible = true; Transplanting.Visible = true;
                    LocationAndSunlightText.Text = "Geranium loves a lot of sunlight, in good light it will grow well and enjoy beautiful and abundant colors, and the leaves will be healthy and juicy. In winter, it is also good to have extra light from artificial sources";
                    TemperatureText.Text = "During the period of growth and flowering, the geranium feels most comfortable at 68-77°F (20-25°C). The optimum temperature for the winter season is 53.6-59°F (12-15°C)";
                    SoilText.Text = "It is best for the geranium to be planted in mixed soil (garden soil, sand and fertilizer). It must be well drained and not retain water.";
                    FertilizationText.Text = "The geranium should be nourished twice or thrice a month, cleaned from the blooms and received plenty of light";
                    Transplanting.Text = "Reproduction";
                    TransplantingText.Text = "Spring is the perfect time for seedling seedlings. To do this, take a few cuttings and let them wilt for a few hours before stitching them to a new place."; 
                    break;
                    
                    
                default:
                    break;
            }
        }
    }
}
