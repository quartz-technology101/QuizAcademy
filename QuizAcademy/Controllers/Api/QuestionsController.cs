using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using QuizAcademy.Models;
using QuizAcademy.Dtos;
using AutoMapper;
using System.Data.Entity;

namespace QuizAcademy.Controllers.Api
{
    public class QuestionsController : ApiController
    {
        private ApplicationDbContext _context;

        public QuestionsController()
        {
            _context = new ApplicationDbContext();
        }

        //GET /api/questions
        public IEnumerable<QuestionDto> GetQuestions()
        {
            return _context.Questions.Include(q => q.Topic).ToList().Select(Mapper.Map<Question, QuestionDto>);
        }

        //POST /api/questions
        [Authorize(Roles = "CanManageQuestions")]
        [HttpPost]
        public IHttpActionResult CreateQuestion(QuestionDto questionDto)
        {
            if (!ModelState.IsValid)
                return BadRequest();

            var question = Mapper.Map<QuestionDto, Question>(questionDto);
            _context.Questions.Add(question);
            _context.SaveChanges();

            questionDto.Id = question.Id;
            return Created(new Uri(Request.RequestUri + "/" + question.Id), questionDto);
        }


        //DELETE /api/questions/1
        [Authorize(Roles = "CanManageQuestions")]
        [HttpDelete]
        public IHttpActionResult DeleteQuestion(int id)
        {
            var questionInDb = _context.Questions.SingleOrDefault(q => q.Id == id);

            if (questionInDb == null)
                return NotFound();

            _context.Questions.Remove(questionInDb);
            _context.SaveChanges();
            return Ok();
        }
    }
}
