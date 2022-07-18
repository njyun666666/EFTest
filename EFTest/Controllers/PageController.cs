using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using EFTest.Models;
using EFTest.ViewModels;
using AutoMapper;
using AutoMapper.QueryableExtensions;

namespace EFTest.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PageController : ControllerBase
    {
        private readonly EFTestDBContext _context;
        private readonly IMapper _mapper;

        public PageController(EFTestDBContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        // GET: api/Page
        [HttpGet]
        public async Task<ActionResult<List<PageViewModel>>> GetTbPage()
        {
            if (_context.TbPage == null)
            {
                return NotFound();
            }

            // ViewModel
            //return await _context.TbPage.Include(page => page.TbPageSection)
            //    .Select(page => new PageViewModel
            //    {
            //        PageId = page.PageId,
            //        Title = page.Title,
            //        TbPageSection = page.TbPageSection.Select(ps => new TbPageSection
            //        {
            //            Id = ps.Id,
            //            PageId = ps.Id,
            //            SectionId = ps.SectionId
            //        }).ToList(),
            //    }).ToListAsync();


            // AutoMapper
            //List<TbPage> pageList = await _context.TbPage.Include(page => page.TbPageSection).AsNoTracking().ToListAsync();
            //List<PageViewModel> result = _mapper.Map<List<PageViewModel>>(pageList);

            //return result;


            // AutoMapper Queryable Extensions
            // https://docs.automapper.org/en/latest/Queryable-Extensions.html
            //return await _context.TbPage.Include(page => page.TbPageSection).ProjectTo<PageViewModel>(_mapper.ConfigurationProvider).AsNoTracking().ToListAsync();


            return await _mapper.ProjectTo<PageViewModel>(_context.TbPage.Include(page => page.TbPageSection)).AsNoTracking().ToListAsync();



        }

    }
}
