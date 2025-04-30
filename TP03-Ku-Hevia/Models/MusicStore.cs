static class MusicStore 
{
    public static List<Disco> Discos {get; private set;}

    public static void inicializarDisco() 
    {
        var disco1 = new Disco("Angels Cry","Angra","55:59","Charlie Bauerfeind y Sascha Paeth", "Power Metal", "/imagenes/Angra.jpg");
        disco1.canciones.Add(1, "Unfinished Allegro");
        disco1.canciones.Add(2, "Carry On");
        disco1.canciones.Add(3, "Time");
        disco1.canciones.Add(4, "Angels Cry");
        disco1.canciones.Add(5, "Stand Away");
        disco1.canciones.Add(6, "Never Understand");
        disco1.canciones.Add(7, "Wuthering Heights");
        disco1.canciones.Add(8, "Streets of Tomorrow");
        disco1.canciones.Add(9, "Evil Warning");
        disco1.canciones.Add(10, "Lasting Child");

        var disco2 = new Disco("play with earth! 0.03", "Wave to earth", "25:04","Kim Daniel", "K Rock", "/imagenes/0.03.jpg");
        disco2.canciones.Add(1, "are you bored?");
        disco2.canciones.Add(2, "play with earth!");
        disco2.canciones.Add(3, "annie.");
        disco2.canciones.Add(4, "pueblo - Remastered 2024");
        disco2.canciones.Add(5, "beck.");
        disco2.canciones.Add(6, "slow dive");
        disco2.canciones.Add(7, "holyland");
        
        var disco3 = new Disco("Master of Puppets","Metallica","54:49","Flemming Rasmussen", "Thrash Metal", "/imagenes/Metallica.jpg");
        disco3.canciones.Add(1, "Battery");
        disco3.canciones.Add(2, "Master of Puppets");
        disco3.canciones.Add(3, "The Thing That Should Not Be");
        disco3.canciones.Add(4, "Welcome Home (Sanitarium)");
        disco3.canciones.Add(5, "Disposable Heroes");
        disco3.canciones.Add(6, "Leper Messiah");
        disco3.canciones.Add(7, "Orion");
        disco3.canciones.Add(8, "Damage Inc.");
            
        var disco4 = new Disco("übermensch","G-dragon","23:24","G-dragon", "K-pop", "/imagenes/ubermemsch.jpg");
        disco4.canciones.Add(1, "HOME SWEET HOME");
        disco4.canciones.Add(2, "TOO BAD");
        disco4.canciones.Add(3, "IBELONGIIU");
        disco4.canciones.Add(4, "GYRO-DROP");
        disco4.canciones.Add(5, "POWER");
        disco4.canciones.Add(6, "DRAMA");
        disco4.canciones.Add(7, "TAKE ME");

        var disco5 = new Disco("Rust In Peace","Megadeth", "44:06", "Max Norman", "Thrash Metal", "/imagenes/Megadeth_Rust_in_Peace.jpg");
        disco5.canciones.Add(1, "Holy Wars... The Punishment Due");
        disco5.canciones.Add(2, "Hangar 18");
        disco5.canciones.Add(3, "Take No Prisoners");
        disco5.canciones.Add(4, "Five Magics");
        disco5.canciones.Add(5, "Poison Was the Cure");
        disco5.canciones.Add(6, "Lucretia");
        disco5.canciones.Add(7, "Tornado of Souls");
        disco5.canciones.Add(8, "Dawn Patrol");
        disco5.canciones.Add(9, "Rust in Peace... Polaris");
        disco5.canciones.Add(10, "My Creation");

        var disco6 = new Disco("Peace Sells... But Who's Buying?","Megadeth", "42:43", "Paul Lani", "Thrash Metal", "/imagenes/Megadeth_Peace_Sells.jpeg");
        disco6.canciones.Add(1, "Wake Up Dead");
        disco6.canciones.Add(2, "The Conjuring");
        disco6.canciones.Add(3, "Peace Sells");
        disco6.canciones.Add(4, "Devil's Island");
        disco6.canciones.Add(5, "Good Mourning/Black Friday");
        disco6.canciones.Add(6, "Bad Omen");
        disco6.canciones.Add(7, "I Ain't Superstitious");
        disco6.canciones.Add(8, "My Last Words");

        var disco7 = new Disco("Vulgar Display of Power","Pantera", "58:30", "Phil Anselmo y Terry Date", "Groove Metal", "/imagenes/Pantera_Vulgar_Display_of_Power.jpg");
        disco7.canciones.Add(1, "Mouth for War");
        disco7.canciones.Add(2, "A New Level");
        disco7.canciones.Add(3, "Walk");
        disco7.canciones.Add(4, "Fucking Hostile");
        disco7.canciones.Add(5, "This Love");
        disco7.canciones.Add(6, "Rise");
        disco7.canciones.Add(7, "No Good (Attack the Radical)");
        disco7.canciones.Add(8, "Live in a Hole");
        disco7.canciones.Add(9, "Regular People (Conceit)");
        disco7.canciones.Add(10, "By Demons Be Driven");
        disco7.canciones.Add(11, "Hollow");

        var disco8 = new Disco("Drama", "aespa", "22:10", "SM Entertainment", "K-pop", "/imagenes/aespa_drama.jpg");
        disco8.canciones.Add(1, "Drama");
        disco8.canciones.Add(2, "Trick or Trick");
        disco8.canciones.Add(3, "Don't Blink");
        disco8.canciones.Add(4, "Hot Air Balloon");
        disco8.canciones.Add(5, "YOLO");
        disco8.canciones.Add(6, "You");

        var disco9 = new Disco("Unorthodox Jukebox", "Bruno Mars", "34:28", "The Smeezingtons", "Pop", "/imagenes/bruno_mars_unorthodox.jpg");
        disco9.canciones.Add(1, "Young Girls");
        disco9.canciones.Add(2, "Locked Out of Heaven");
        disco9.canciones.Add(3, "Gorilla");
        disco9.canciones.Add(4, "Treasure");
        disco9.canciones.Add(5, "Moonshine");
        disco9.canciones.Add(6, "When I Was Your Man");
        disco9.canciones.Add(7, "Natalie");
        disco9.canciones.Add(8, "Show Me");
        disco9.canciones.Add(9, "Money Make Her Smile");
        disco9.canciones.Add(10, "If I Knew");

        var disco10 = new Disco("Get Up", "NewJeans", "12:51", "ADOR", "K-pop", "/imagenes/newjeans_getup.jpg");
        disco10.canciones.Add(1, "New Jeans");
        disco10.canciones.Add(2, "Super Shy");
        disco10.canciones.Add(3, "ETA");
        disco10.canciones.Add(4, "Cool With You");
        disco10.canciones.Add(5, "Get Up");
        disco10.canciones.Add(6, "ASAP");

        Discos.Add(disco1);
        Discos.Add(disco2);
        Discos.Add(disco3);
        Discos.Add(disco4);
        Discos.Add(disco5);
        Discos.Add(disco6);
        Discos.Add(disco7);
        Discos.Add(disco8);
        Discos.Add(disco9);
        Discos.Add(disco10);
    }
}