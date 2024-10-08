﻿using AutoMapper;
using MultiShop.Comment.Dtos.UserCommentDtos;
using MultiShop.Comment.Entities;

namespace MultiShop.Comment.Mapping
{
    public class GeneralMapping : Profile
    {
        public GeneralMapping()
        {
            CreateMap<UserComment, CreateUserCommentDto>().ReverseMap();
            CreateMap<UserComment, UpdateUserCommentDto>().ReverseMap();
            CreateMap<UserComment, ResultUserCommentDto>().ReverseMap();
            CreateMap<UserComment, GetByIdCommentDto>().ReverseMap();
        }
    }
}
