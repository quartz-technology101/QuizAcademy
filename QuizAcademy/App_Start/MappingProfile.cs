using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AutoMapper;
using QuizAcademy.Models;
using QuizAcademy.Dtos;

namespace QuizAcademy.App_Start
{
    public class MappingProfile:Profile
    {
        public MappingProfile()
        {
            Mapper.CreateMap<Question, QuestionDto>();
            Mapper.CreateMap<QuestionDto, Question>();
            Mapper.CreateMap<Topic, TopicDto>();
            Mapper.CreateMap<TopicDto, Topic>();
        }
    }
}