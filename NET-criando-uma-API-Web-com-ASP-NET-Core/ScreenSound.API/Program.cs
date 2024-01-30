using ScreenSound.Banco;
using ScreenSound.Modelos;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => {
    var dal = new DAL<Artista>(new ScreenSoundContext());
    return dal.Listar();

});

app.Run();
