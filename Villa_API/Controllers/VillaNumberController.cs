using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using System.Net;
using Villa_API.logging;
using Villa_API.Models.API;
using Villa_API.Repository.IRepository;
using Villa_API.Models.VillaNumberModel;
using Microsoft.AspNetCore.Http.HttpResults;

namespace Villa_API.Controllers
{
    [Route( "API_VillaNumber")]
    [ApiController]
    public class VillaNumberController : ControllerBase
    {
        #region ПОЛЯ и КОНСТРУКТОР

        private readonly ILogging _logger;

        private readonly APIResponse _response;

        private readonly IVillaNumberRepository _db;
        private readonly IVillaRepository _dbVilla;

        private readonly IMapper _mapper;
        public VillaNumberController(ILogging logger, IVillaNumberRepository db, IMapper mapper, IVillaRepository dbVilla)
        {
            _logger = logger;
            _db = db;
            _dbVilla = dbVilla;
            _mapper = mapper;
            this._response = new();
        }

        #endregion

        #region POST
        
        // Добавление НОМЕРА виллы POST
        [HttpPost("CreateVillaNumberNew")]

        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<ActionResult<APIResponse>> CreateVillaNumberNew([FromBody] VillaNumberCreateDTO createDto)
        {
            try
            {
                if (createDto == null) { return BadRequest(createDto); } // Проверка на null должна быть первой

                var isVillaIdValid = await _dbVilla.GetAsync(u => u.Id == createDto.VillaId) != null;
                if (!isVillaIdValid)
                {
                    ModelState.AddModelError("CustomError", "Villa number already Exist!");
                    return BadRequest(ModelState);
                }
                // валидация id из таблицы Villas
                if (await _dbVilla.GetAsync(u=>u.Id==createDto.VillaId)==null)
                {
                    ModelState.AddModelError("CustomError", "Villa ID is Invalid!");
                    return BadRequest(ModelState);
                }
                
                VillaNumber model = _mapper.Map<VillaNumber>(createDto);

                await _db.CreateAsync(model);
                _response.Result = _mapper.Map<VillaNumberCreateDTO>(model);
                _response.StatusCode = HttpStatusCode.Created;
                return CreatedAtRoute("GetVilla_Number", new { id = model.VillaNo }, _response);
            }
            catch (Exception ex)
            {
                _response.IsSuccess = false;
                _response.ErrorMessages = new List<string>() { ex.ToString() };
            }

            return _response;
        }

        #endregion

        #region DELETE 
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]

        [HttpDelete("DeleteVillaNumberById{id:int}")]
        public async Task<ActionResult<APIResponse>> DeleteVillaNumberById(int id)
        {
            if (id == 0) { return BadRequest(); }

            var model = await _db.GetAsync(u => u.VillaNo == id);

            if (model == null) { return NotFound(); }

            await _db.RemoveAsync(model);

            _response.StatusCode = HttpStatusCode.NoContent;

            _response.IsSuccess = true;

            return Ok(_response);

        }

        #endregion

        #region GET ALL

        [HttpGet("GetVillaNumbers")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<ActionResult<APIResponse>> GetVillaNumbers()
        {
            try
            {
                var items = await _db.GetAllAsync();
                _response.Result = _mapper.Map<List<VillaNumberDTO>>(items);
                _response.StatusCode = HttpStatusCode.OK;
                return Ok(_response);
            }
            catch (Exception ex)
            {
                _response.IsSuccess = false;
                _response.ErrorMessages = new List<string>() { ex.ToString() };
            }

            return _response;
        }

        #endregion

        # region GET ID

        [HttpGet("GetVillaNumberById{id:int}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<ActionResult<APIResponse>> GetVillaNumberById(int id)
        {
            try
            {
                if (id == 0)
                {
                    _response.StatusCode = HttpStatusCode.BadRequest;
                    return BadRequest(_response);
                }

                var item = await _db.GetAsync(u => u.VillaNo == id);

                if (item == null)
                {
                    _response.StatusCode = HttpStatusCode.NotFound;
                    return NotFound(_response);
                }
                _response.Result = _mapper.Map<VillaNumberDTO>(item);
                _response.StatusCode = HttpStatusCode.OK;
                return Ok(_response);
            }
            catch (Exception ex)
            {
                _response.IsSuccess = false;
                _response.ErrorMessages = new List<string>() { ex.ToString() };
            }
            return _response;

        }
        #endregion

        #region UPDATE]

        [HttpPut("UpdateVillaNumberById{id:int}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)] // Добавлено для обработки исключений
        public async Task<ActionResult<APIResponse>> UpdateVillaNumberById(int id, [FromBody] VillaNumberUpdateDTO updateDTO)
        {
            try
            {
                if (updateDTO == null || id != updateDTO.VillaNo)
                {
                    return BadRequest();
                }
                // валидация id из таблицы Villas
                if (await _dbVilla.GetAsync(u => u.Id == updateDTO.VillaId) == null)
                {
                    ModelState.AddModelError("CustomError", "Villa ID is Invalid!");
                    return BadRequest(ModelState);
                }
                VillaNumber model = _mapper.Map<VillaNumber>(updateDTO);

                await _db.UpdateAsync(model);
                _response.StatusCode = HttpStatusCode.NoContent;
                _response.IsSuccess = true;

                return Ok(_response);
            }
            catch (Exception ex)
            {
                _response.IsSuccess = false;
                _response.ErrorMessages = new List<string>() { ex.ToString() };
            }

            return _response;
        }
        #endregion

    }
}
