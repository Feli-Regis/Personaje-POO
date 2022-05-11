using EjercicioPersonaje;

PersonajeDeFuerza deFuerza = new("Hulk", 10, 15);
PersonajeDeAgilidad deAgilidad = new("SpiderMan", 20, 15, 5);
PersonajeDeMagia deMagia = new("Doctor Strange", 30, 10);

List<Personaje> personajes = new() {deFuerza, deAgilidad, deMagia};

Turno.Atacarse(personajes);

List<IMoverse> listPersonajeEnemgio = new();

listPersonajeEnemgio.AddRange(personajes);
listPersonajeEnemgio.Add(new Enemigo());

foreach(IMoverse item in listPersonajeEnemgio)
{
    Turno.MoverFichas(item);
}
