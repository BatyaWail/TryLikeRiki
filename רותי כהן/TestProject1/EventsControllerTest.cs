using API.Controllers;
using Microsoft.AspNetCore.Mvc;

namespace TestProject1
{
    public class EventsControllerTest
    {
        private readonly EventsController _eventsController;

        public EventsControllerTest()
        {
            var context = new DataContextFake();
            _eventsController = new EventsController(context);
        }

        [Fact]
        public void ReturnOk_Get()
        {
            var result = _eventsController.Get();
           // Assert.NotNull(result);
           Assert.IsType<OkObjectResult>(result);
        }

        [Fact]
        public void ReturnOk_GetByID()
        {
            int id = 9;
            var result = _eventsController.Get(id);
            // Assert.NotNull(result);
            Assert.IsType<NotFoundResult>(result);
        }
    }
}