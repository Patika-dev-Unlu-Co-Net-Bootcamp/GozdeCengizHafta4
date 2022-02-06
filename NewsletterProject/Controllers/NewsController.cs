using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NewsletterProject.Extensions;
using NewsletterProject.Extensions.Interface;
using NewsletterProject.Services;
using System;
using System.Collections.Generic;
using System.Linq;

namespace NewsletterProject.Controllers
{
    [Route("api/[controller]")]
    [ApiController]

        public class NewsController : Controller
        {

            private IRuleService _ruleService;

            public NewsController(IRuleService ruleService)
            {
                _ruleService = ruleService;
            }

            //created new list for fake datas 
            List<News> newsList = new List<News>()
            {
                new News()
                {
                    Id=1,
                    CategoryID=1,
                    UserID=1,
                    Title="Dolar deger kaybediyor",
                    Content="inanilmaz bi sey oldu dolar 10 dan asagiya dustu",
                    Url="www.google.com",
                    Image="img url",
                    Video="video url",
                    CreatedDate = DateTime.Now,
                    Status=true
                },
                new News()
                {
                    Id=2,
                    CategoryID=2,
                    UserID=1,
                    Title="Kedi kopek bi seyler",
                    Content="inanilmaz bi sey oldu dolar 10 dan asagiya dustu",
                    Url="www.google.com",
                    Image="img url",
                    Video="video url",
                    CreatedDate = DateTime.Now,
                    Status=true
                },
                new News()
                {
                    Id=3,
                    CategoryID=1,
                    UserID=2,
                    Title="teknolojik bir haber",
                    Content="inanilmaz bi sey oldu dolar 10 dan asagiya dustu",
                    Url="www.google.com",
                    Image="img url",
                    Video="video url",
                    CreatedDate = DateTime.Now,
                    Status=false
                },
            };



            //GET: api/values
            // this method will get all news
            [HttpGet]
            public IActionResult Get()
            {
                if (newsList is not null)
                    return Ok(newsList);

                return BadRequest();
            }

            // GET api/values/5
            //this method will get the news selected with id 
            [HttpGet("{id}")]
            public IActionResult Get(int id)
            {
                var news = newsList.SingleOrDefault(x => x.Id == id);

                if (news is not null)
                    return Ok(news);

                return BadRequest();
                
            }


            [HttpGet("authors/{userid}")]
            public IActionResult GetByAuthor(int userid)
            {

                var _newsList = newsList.Where(x => x.UserID == userid).ToList<News>();

                if (_newsList is null)
                    return BadRequest();

                return Ok(_newsList);

            }

            // POST api/values
            //this method will insert the new data
            [HttpPost]
            public IActionResult Post([FromBody] News _news)
            {

                var titleRulesList = _ruleService.GetTitleRules();

                if(_news.Title.IsValidTitle(titleRulesList))
                {
                    var news = newsList.SingleOrDefault(x => x.Title == _news.Title);

                    if (news is not null)
                        return BadRequest();

                    newsList.Add(_news);
                }

                return Ok(newsList);

        }

            // PUT api/values/5
            //this method will update the data selected with id
            [HttpPut("{id}")]
            public IActionResult Put(int id, [FromQuery] News _news)
            {
                var news = newsList.SingleOrDefault(x => x.Id == id);

                if (news is null)
                    return BadRequest();

                news.CategoryID = _news.CategoryID != default ? _news.CategoryID : news.CategoryID;
                news.Content = _news.Content != default ? _news.Content : news.Content;
                news.Title = _news.Title != default ? _news.Title : news.Title;
                news.Image = _news.Image != default ? _news.Image : news.Image;
                news.Video = _news.Video != default ? _news.Video : news.Video;
                news.Status = _news.Status != default ? _news.Status : news.Status;
                news.Url = _news.Url != default ? _news.Url : news.Url;

                return Ok(newsList);
            }

            // DELETE api/values/5
            //this method will delete the data selected with id
            [HttpDelete("{id}")]
            public IActionResult Delete(int id)
            {
                var news = newsList.SingleOrDefault(x => x.Id == id);

                if (news is null)
                    return BadRequest();

                newsList.Remove(news);
                return Ok(newsList);
            }
        }
    }

