namespace CS8_MessageAPI.Models;

/// <summary>
/// An Academic Block
/// </summary>
/// <param name="blockId">don't care</param>
/// <param name="name">name of the block</param>
/// <param name="schoolLevel">upper or lower school</param>
public record Block
(
    string blockId,
    string name,
    string schoolLevel);
 

/// <summary>
/// Time Period that you're free
/// </summary>
/// <param name="block">block info</param>
/// <param name="start">when free block starts</param>
/// <param name="end">when free block ends</param>
 public record FreeBlock(
    Block block,
    DateTime start,
    DateTime end);
    
/// <summary>
/// collection of FreeBlocks,
/// reponse to a request for free-blocks in a given range of dates
/// </summary>
/// <param name="freeblocks"></param>
/// <param name="inRange"></param>

 public record FreeBlockCollection(
    FreeBlock[] freeblocks,
    DateOnly[] inRange);