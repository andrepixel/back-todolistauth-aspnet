using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("/api/lists")]
public class ItensListController : ControllerBase
{
    private readonly ItensListApplicationService service;

    public ItensListController(ItensListApplicationService service)
    {
        this.service = service;
    }

    [HttpGet("[[listId]]/items")]
    public async Task<ActionResult<List<ItemListEntity>?>> GetItensList([FromQuery] Guid listId)
    {
        List<ItemListEntity>? itemListEntities = await service.GetItensList(listId);

        if (itemListEntities == null || itemListEntities.Count == 0) return NotFound();

        return Ok(itemListEntities);
    }

    [HttpPost("[[listId]]")]
    public async Task<ActionResult<ItemListEntity?>> CreateItemList([FromQuery]Guid listId)
    {
        ItemListEntity? listEntity = await service.CreateItemList(listId);

        if (listEntity == null) return NotFound();

        return Created("", listEntity);
    }

    [HttpPatch("[[listId]]/item/[[itemId]]")]
    public async Task<ActionResult<ItemListEntity?>> UpdateList([FromQuery] Guid listId, [FromQuery] Guid itemId, [FromBody] ItensListsResquestDTO dto)
    {
        try
        {
            ItemListEntity? listEntity = await service.UpdateItemList(listId, itemId, dto);

            if (listEntity == null) return NotFound();

            return Ok(listEntity);
        }
        catch (PropertiesEqualsException exception)
        {
            return Ok(exception.Message);
        }
    }

    [HttpDelete("[[listId]]/item/[[itemId]]")]
    public async Task<ActionResult<ItemListEntity?>> DeleteItemList([FromQuery] Guid listId, [FromQuery] Guid itemId)
    {
        await service.DeleteItemListById(listId, itemId);

        return NoContent();
    }
}
