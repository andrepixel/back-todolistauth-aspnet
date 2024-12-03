using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("/api/[controller]")]
class ListController : ControllerBase
{
    private readonly ListApplicationService service;

    public ListController(ListApplicationService service)
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
    public async Task<ActionResult<ListEntity?>> CreateList()
    {
        ListEntity? listEntity = await service.CreateList();

        if (listEntity == null) return NotFound();

        return Created("", listEntity);
    }

    [HttpPatch("[id]")]
    public async Task<ActionResult<ListEntity?>> UpdateList([FromQuery] Guid id, [FromBody] ListsResquestDTO dto)
    {
        try
        {
            ListEntity? listEntity = await service.UpdateList(id, dto);

            if (listEntity == null) return NotFound();

            return Ok(listEntity);
        }
        catch (PropertiesEqualsException exception)
        {
            return Ok(exception.Message);
        }
    }

    [HttpDelete("[id]")]
    public async Task<ActionResult<ListEntity?>> DeleteList([FromQuery] Guid id)
    {
        await service.DeleteListById(id);

        return NoContent();
    }
}
