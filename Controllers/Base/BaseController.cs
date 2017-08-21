using System.Collections.Generic;
using System.Threading.Tasks;
using System.Web.Http;

namespace WebAPI.Controllers.Base
{
    [Authorize]
    public class BaseController<T> : ApiController where T : class
    {
        //public DatabaseManager<T> DatabaseManager { get; set; }

        public BaseController(string connectionResource)
        {
            //DatabaseManager = new DatabaseManager<T>(connectionResource);
        }

        ///// <summary>
        ///// Gets the list of all items.
        ///// GET api/{entity}
        ///// </summary>
        ///// <returns>IEnumerable items.</returns>
        //[HttpGet]
        //public async Task<IEnumerable<T>> Get()
        //{
        //    return await DatabaseManager.Get();
        //}

        ///// <summary>
        ///// Gets one item.
        ///// GET api/{entity}/{id}
        ///// </summary>
        ///// <param name="id">Item's id.</param>
        ///// <returns>IHttpActionResult item.</returns>
        //[HttpGet]
        //public async Task<IHttpActionResult> Get(int id)
        //{
        //    return Ok(await DatabaseManager.Get(id));
        //}

        ///// <summary>
        ///// Inserts a list of items.
        ///// POST api/values
        ///// </summary>
        ///// <param name="items">The list of items to insert.</param>
        ///// <returns>IHttpActionResult items.</returns>
        //[HttpPost]
        //public async Task<IHttpActionResult> Post(IEnumerable<T> items)
        //{
        //    return Ok(await DatabaseManager.Insert(items));
        //}

        ///// <summary>
        ///// Inserts one item.
        ///// POST api/values
        ///// </summary>
        ///// <param name="item">Item to insert.</param>
        ///// <returns>IHttpActionResult item.</returns>
        //[HttpPost]
        //public async Task<IHttpActionResult> Post(T item)
        //{
        //    await DatabaseManager.Insert(item);
        //    return Ok(item);
        //}

        ///// <summary>
        ///// Updates several items.
        ///// </summary>
        ///// <param name="items">List of items to update.</param>
        ///// <returns>IHttpActionResult items.</returns>
        //[HttpPut]
        //public async Task<IHttpActionResult> Put(IEnumerable<T> items)
        //{
        //    return Ok(await DatabaseManager.Update(items));
        //}

        ///// <summary>
        ///// Updates one item.
        ///// PUT api/values
        ///// </summary>
        ///// <param name="item">Item to update.</param>
        ///// <returns>IHttpActionResult item.</returns>
        //[HttpPut]
        //public async Task<IHttpActionResult> Put(T item)
        //{
        //    return Ok(await DatabaseManager.Update(item));
        //}

        ///// <summary>
        ///// Deletes several items.
        ///// </summary>
        ///// <param name="items">Items to delete.</param>
        ///// <returns>IHttpActionResult</returns>
        //[HttpDelete]
        //public async Task<IHttpActionResult> Delete(IEnumerable<T> items)
        //{
        //    return Ok(await DatabaseManager.Delete(items));
        //}

        ///// <summary>
        ///// Deletes one item.
        ///// DELETE api/values/{id}
        ///// </summary>
        ///// <param name="item">Item to delete.</param>
        ///// <returns>IHttpActionResult</returns>
        //[HttpDelete]
        //public async Task<IHttpActionResult> Delete(T item)
        //{
        //    return Ok(await DatabaseManager.Delete(item));
        //}
    }
}