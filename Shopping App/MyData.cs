﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shopping_App
{
    public class MyData
    {
        private DataTable plants;
        public DataTable Plants { get => plants; set => plants = value; }

        public MyData() {
            Plants = new DataTable();
            Plants.Columns.Add("id");
            Plants.Columns.Add("name");
            Plants.Columns.Add("price");
            Plants.Columns.Add("common name");
            Plants.Columns.Add("descript");

            Plants.Rows.Add("01", "Aeschynanthus Radicans", 22.99, "Black Pagoda", "The black pagoda plant has a mottled, camouflage like foliage that runs along it's cascading stems, making this a great plant for hanging pots. This plant will bloom beautiful orange flowers around late winter to spring but has been known to bloom year-round");
            Plants.Rows.Add("02", "Aeschynanthus", 22.99, "Lipstick Curly", "The name Curly Lipstick Plant comes from the scarlet flowers that open from buds that resemble lipstick tubes. With cascading stems and bright orange blooms will brighten any room. The mottled foliage and shiny leaves add interest to its form. Flowers arise in clusters at the growing tips with each blossom having a coloration of deep orange-red to orange to yellow and green.");
            Plants.Rows.Add("03", "Alocasia Azlanii", 75.99, "Jewel Alocasia", "This rare Alocasia features glossy dark green leaves with vibrant pink/red veining. New leaves will slowly unfurl and are green with red veins. As the leaves mature they will turn deep iridescent green with dark purple or red veins, bright green outlines, and a purple backside. This plant is toxic to pets.");
            Plants.Rows.Add("04", "Alocasia Hybrid", 33.99, "Alocasia Serendipity", "Alocasia Serendipity is a tall plant with large, heart-shaped purplish-green leaves with very dark purple undersides. The stems and veins on the leaf undersides are lime green. Being a jungle plant, it prefers shady conditions and rich consistently moist soils and protection from drying or damaging winds and harsh afternoon sunlight. These conditions can be achieved in a pot placed in a sheltered location, or as part of a moist understory planting or shady border.");
            Plants.Rows.Add("05", "Alocasia Infernalis", 45.99, "Black Magic Alocasia", "Often referred to as “Black Magic” due to the beautiful black sheen that comes from the leaves. The Alocasia Infernalis needs fast-draining soil to prevent over-watering and under-watering. It also needs bright indirect sunlight and moist soil. Toxic to pets.");
            Plants.Rows.Add("06", "Alocasia Reginula", 24.99, "Black Velvet", "The Alocasia Reginula also known as the African Mask or Elephant Ear is all about the unusual and unique alien looking leaves. The Alocasia Reginula is a unique houseplant but beware that it is on the harder side to care for. It requires bright, indirect sunlight as well as soil that is constantly moist from watering. Toxic to pets.");
            Plants.Rows.Add("07", "Alocasia Rugosa", 62.99, "Alocasia Melo", "The jade green to greenish-blue leaves of this plant grows on erect terrestrial petioles. These leaves are thick enough to look like cardboard and confuse you with an artificial plant. These terrestrial growers can beautify any corner in your house to add the necessary oomph to the decor. Let us get to know about the thick-leaf, Jewel Melo Alocasia along with its care and propagation.");
            Plants.Rows.Add("08", "Aloe Barbadensis Mill", 24.99, "Chinese Aloe", "The Aloe Vera is a stemless succulent with thick and fleshy leaves that are lined with small teeth making it a great ornamental, low maintenance indoor plant which blooms a yellow tubular flower in the summertime. Native to the Arabian Peninsula, this plant is widely used around the world as its leaves are considered to be antimicrobial and has been used to treat burns as a topical medication.");
            Plants.Rows.Add("09", "Begonia Bowerae", 27.99, " Begonia Tiger Paws", "Striking foliage of small, chocolate to bronze-red leaves, adorned with bright green, paw-like markings. The leaves have white eyelash-like hairs on their edges, hence the common name. Great as an indoor plant and outdoor plant, thanks to its rich colors and relatively rapid growth.");
            Plants.Rows.Add("10", "Begonia Brevirimosa Subsp", 44.99, "Exotica", "The Exotica Begonia is an exciting rarity from the rain forests of New Guinea. It's large, metallic-looking leaves sport bright-pink variegation that demands attention. This is a naturally-occurring form, not a cultivated hybrid. If you can meet its basic needs (some warmth & humidity) it is surprisingly easy to grow!");
            Plants.Rows.Add("11", "Begonia Rex", 49.99, "Rex Begonia", "Rex begonia offers colorful foliage and is one of the most interesting indoor plants around. Despite its exotic looks, Rex begonia is actually easy to grow. Because it's a relatively short houseplant, Rex begonia is perfect for desks and tabletops where its wildly colorful, variegated foliage makes it a perfect contrast against other houseplants.");
            Plants.Rows.Add("12", "Calathea 'Ornata'", 26.99, "Peacock Plant", "Calathea Plants, native to tropical South and Central America, Africa, and the West Indies, are grown primarily for their beautiful, brightly colored, upright, oval leaves. The various Calathea varieties have leaves with purple undersides and various vibrant colorful patterns on the top side.");
            Plants.Rows.Add("13", "Chlorophytum Comosum", 39.99, "Spider Plant", "The Spider plant is a flowering perennial native tropical South Africa. The leaves of the spider plant are thin ribbon like strands which end in a point and grow upward and bend downward giving it the look of a spider. The Spider plant produces small white flowers that grow along a long stalk independent to the leaves of the spider plant. Also known for their air purifying qualities, the spider plant is a great companion to any household of office.");
            Plants.Rows.Add("14", "Cryptanthus 'Pink Star'", 19.99, "Pink Star", "Earth Stars are unusual houseplants perfect for adding a dash of color and texture to your spaces. Small indoor plants, they're perfect for growing on bright tabletops -- and make excellent living centerpieces for special gatherings. Because they're easy to grow, earth stars are also ideal additions to your desk at work. They don't need constant nurturing, so you can enjoy their beauty without a lot of maintenance.");
            Plants.Rows.Add("15", "Dracaena Fragans", 39.99, "Lime Light", "With glossy, electric lime-green leaves, this tropical foliage plant thrives as a low-light interior plant. Dracaenas grow well at average room temperatures but don't like cold drafts. Give plants medium to bright light to maintain the best leaf color. Allow the soil to dry to the touch between waterings.");
            Plants.Rows.Add("16", "Dracaena 'Marginata Magenta'", 19.99, "Dragon Tree", "A member of the Dracaena family, this durable plant can easily be mistaken for a palm plant. This care-free plant has head of narrow, bright green leaves edged with red or pink stripes. It thrives in a large range of environments and is great for adding a tropical appearance to any room.");
            Plants.Rows.Add("17", "Fatsia Japonica", 44.99, "Japanese Aralia", "An unusual new variety of Fatisia, is primarily grown for its handsome foliage. Fatsia Spider's Web has wonderfully variegated white and medium green foliage which appears as though it has been dusted with icing sugar. Fatsia's are superb evergreens providing interest in shady areas where other plants may struggle to grow. They make a wonderful specimen, particularly when planted near white-flowering plants that complement the leaf variegations. It can also be used to help add light and color to secluded shady patio areas.");
            Plants.Rows.Add("18", "Ficus Elastica", 22.99, "Rubber Plant", "Native to India and Southeast Asia, the Ficus elastica 'Burgundy' is perfect for those looking for a small indoor tree with thick, leathery, glossy, dark green leaves and pink to purplish stipules. In the wild, it grows up to around 200ft tall, and its roots are used in India to form living bridges. It won't do well in low light spaces, so place in bright indirect light. Water to keep soil moist at all times. Ficus elastica is a source of latex that is toxic to the skin, and poisonous if taken internally, so pet-owners and those allergic to latex should be cautious.");
            Plants.Rows.Add("19", "Fittonia Albivenis", 22.99, "Nerve Plant", "The Fittionia is a spreading evergreen perennial with delicately veined, deep-green leaves. Although the most popular vein color is silvery-white, you can also readily find varieties with veins in red, pink, white, and green. Small buds may appear after a time where the stem splits into leaves. Flowers are small with a white to off-white color.");
            Plants.Rows.Add("20", "Maranta", 22.99, "Prayer Plant", "The Maranta is a evergreen perennial native to Central and South America. This plant flat oval leaves with a line pattern that runs symmetrically across the leaves.");
            Plants.Rows.Add("21", "Microsorum Diversifolium", 19.99, "Kangaroo Foot", "This Australian fern grows long indented leaves with a dark green color and glossy shine. Versatile and adaptable, Kangaroo ferns are suitable for any indoor environment. Care is similar to most other ferns, preferring indirect light and moisture.");
            Plants.Rows.Add("22", "Monstera adansonii", 20.99, "Adanson's Monstera", "The Swiss Cheese plant, gets its name from its large, heart-shaped leaves, which become covered with holes that resemble swiss cheese as it gets older. Part of the Araceae family that's native to South and Central America, this Monstera is easy to grow and loves to climb and grow upwards.");
            Plants.Rows.Add("23", "Nematanthus", 19.99, "Brazilian Firecracker", "The Nematanthus has small waxy leaves with a distinctive curl at the tips of each leaf. This plant will grow in a trailing, vine-like fashion and is a great choice for filling up empty space in a room.");
            Plants.Rows.Add("24", "Nepenthes", 29.99, "Monkey Cup", "From its tendrils, you'll see globe- or tube-shaped protrusions that act as traps. In the tropics, monkeys are often seen drinking rainwater from these “pitchers” which is how it got its most popular nicknames.");
            Plants.Rows.Add("25", "Peperomia", 13.99, "Peperomia", "The Peperomia is a perennial epiphyte native to the tropical regions of Central and South America. It's short and sturdy stems wield thick, circular leaves which are a deep burgundy color and retains most of its water. The Peperomia is very easy to care for and requires similar care habits to most succulents making it a great addition to any desk or shelf.");
            Plants.Rows.Add("26", "Peperomia Caperata", 13.99, "Napoli Nights", "This stout Hybrid plant is a cross between the Peperomia Rosso and the Peperomia peruviana. It has dark green and grey, compacted leaves growing in a mound like form from the base of the roots. Its ridged leaves and grey coloration makes this plant a very unique addition to any plant collection. ");
            Plants.Rows.Add("27", "Philodendron", 22.99, "Prince of Orange", "The Philodendron Prince of Orange is named from its uniquely hued leaves, which change color over time. New growth starts a vibrant yellow when it first emerges, transitioning first to copper tones, and finally settling into darker shades of green. This plant is a self-heading Philodendron hybrid.");
            Plants.Rows.Add("28", "Philodendron Micans", 13.99, "Velvet Philodendron", "Philodendron micans is also known by the names Heart-Leaf Philodendron and Sweetheart Plant. This species originates from Central America and parts of the Caribbean and is a commonly grown houseplant in many places, including the UK. This type of philodendron plant has velvet-textured heart-shaped leaves that are greenish bronze with reddish brown undersides. It produces long vining stems.");
            Plants.Rows.Add("29", "Sansevieria Cylindrica", 24.99, "Stuckii", "This Sansevieria has thin pointed spears which grow outward from its base. Like many Snake plants, this plant can thrive with very little care and extremely moderate watering.");
            Plants.Rows.Add("30", "Scindapsus Pictus 'Argyraeus'", 24.99, "Pothos", " This striking tropical plant is fairly new to house plant nurseries, and is garnering a lot of attention. Big, heart-shaped leaves are dark-green and splashed with silvery gray, giving them a satin sheen. Its compact growth habit makes Scindapsus pictus 'Argyraeus' a beautiful hanging basket plant. You'll see the best leaf color and variegation by keeping it in bright, indirect light. You'll also keep the plant healthy by boosting the humidity around it. In fact, its variegated foliage makes Satin Pothos a beautiful addition to a terrarium.");
            Plants.Rows.Add("31", "Zamioculcas Zamiifolia 'Black Raven'", 59.99, "ZZ Plant", "Zamioculcas raven will survive in very low light conditions. That’s why it is suitable for use in the office or even in poorly lit rooms like bathrooms. However, for it to thrive and grow, put it in a very well-lit place while avoiding direct sunlight. Time is what makes the black ZZ plant turn dark. Fresh leaves start out bright green and gradually turn black with time.");
        }

    }
}
