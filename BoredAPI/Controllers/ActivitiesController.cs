using BoredAPI.Data;
using BoredAPI.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BoredAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ActivitiesController : ControllerBase
    {
        private readonly ApplicationDbContext _context;
        public ActivitiesController(ApplicationDbContext context)
        {
            _context = context;
        }

        List<string> Activities = new List<string>()
        {
            "Go for a walk","Listen to music","Take photographs","Read a newspaper or magazine","Take a bath","Sit in the sun","Watch a movie","Laugh","Write in a journal","Work on a puzzle","Recall a happy memory","Coloring","Gardening","Spend time with friends","Do yoga","Swimming","Singing","Dancing","Go to a flea market","Drawing or doodling","Painting","Buy fresh flowers","Join a book club","Go to a farmer’s market","Be affectionate with a loved one","Play a musical instrument","Crafting (crochet"," model building)","Get a manicure or pedicure","Cooking","Jogging or running","Play a sport","Go sightseeing in your own town","Read a book","Meditate","Watch a sunrise or sunset","Enjoy a cup of tea","Have a picnic","Visit a museum","Sudoku or a crossword puzzle","Play a board game","Look at old photos","Light a scented candle","Call a friend or family member","Hiking","Get a massage","Volunteer","Go to the library","Go to a park","Stargazing","Explore somewhere new"
        };

        [HttpGet]
        public string GetActivity()
        {

            var Rand = new Random();
            var num = Rand.Next(0, Activities.Count);

            return Activities[num];
        }
    }
}
