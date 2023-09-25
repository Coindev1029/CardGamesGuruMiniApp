using MediatR;
using Services.CardGamesGuruMiniApp.Services.GameService.Interfaces;
using Domain.CardGamesGuruMiniApp.Entities.Game.GameEntities;

namespace Services.CardGamesGuruMiniApp.Handlers.GameHandler;

public class GetGameInformationByIdQuery : IRequest<Game>
{
    public int Id { get; set; }
}

public class GetGameInformationByIdHandler : IRequestHandler<GetGameInformationByIdQuery, Game>
{

    private readonly IGameService _gameService;
    
    public GetGameInformationByIdHandler(IGameService gameService)
    {
        _gameService = gameService;
    }
    
    public async Task<Game> Handle(GetGameInformationByIdQuery request, CancellationToken cancellationToken)
    {
        var result = await _gameService.GetGameByIdAsync(request.Id);

        return result;
    }
}