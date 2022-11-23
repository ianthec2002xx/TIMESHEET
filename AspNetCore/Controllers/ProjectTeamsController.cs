using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace AspNetCore.Controllers
{
  [Route("api/[controller]")]
  [ApiController]
  public class ProjectTeamsController : ControllerBase
  {
    private readonly AppContext _dbContext;

    public ProjectTeamsController(AppContext dbContext)
    {
      _dbContext = dbContext;
    }

    // GET api/foodrecords
    [HttpGet]
    public async Task<ActionResult<List<ProjectTeam>>> Get()
    {
      return await _dbContext.ProjectTeams.ToListAsync();
    }

    // GET api/foodrecords/5
    [HttpGet("{id}")]
    public async Task<ActionResult<ProjectTeam>> Get(string id)
    {
      return await _dbContext.ProjectTeams.FindAsync(id);
    }

    // POST api/foodrecords
    [HttpPost]
    public async Task Post(ProjectTeam model)
    {
      await _dbContext.AddAsync(model);
      
      await _dbContext.SaveChangesAsync();
    }

    // PUT api/foodrecords/5
    [HttpPut("{id}")]
    public async Task<ActionResult> Put(int id, ProjectTeam model)
    {
      var exists = await _dbContext.ProjectTeams.AnyAsync(f => f.Id == id);
      if (!exists)
      {
        return NotFound();
      }

      _dbContext.ProjectTeams.Update(model);
      
      await _dbContext.SaveChangesAsync();

      return Ok();

    }
    // DELETE api/foodrecords/5
    [HttpDelete("{id}")]
    public async Task<ActionResult> Delete(int id)
    {
      var entity = await _dbContext.ProjectTeams.FindAsync(id);

      _dbContext.ProjectTeams.Remove(entity);
      
      await _dbContext.SaveChangesAsync();
      
      return Ok();
    }
  }
}