using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("/api/[controller]")]
class ListsController : ControllerBase
{
    private readonly ListsService service;

    public ListsController(ListsService service)
    {
        this.service = service;
    }

    [HttpGet]
    public async Task<ActionResult<List<ListEntity>?>> GetLists()
    {
        List<ListEntity>? listEntities = await service.GetLists();

        if (listEntities == null || listEntities.Count == 0) return NotFound();

        return Ok(listEntities);
    }

    [HttpPost]
    public async Task<ActionResult<ListEntity?>> CreatList()
    {
        ListEntity? listEntity = await service.CreateList();

        if (listEntity == null) return NotFound();

        return Created("", listEntity);
    }
}
