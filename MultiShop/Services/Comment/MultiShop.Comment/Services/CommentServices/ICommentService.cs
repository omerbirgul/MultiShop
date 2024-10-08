﻿using MultiShop.Comment.Dtos.UserCommentDtos;

namespace MultiShop.Comment.Services.CommentServices
{
    public interface ICommentService
    {
        Task<List<ResultUserCommentDto>> UserCommentListAsync();
        Task<GetByIdCommentDto> GetCommentByIdAsync(int id);
        Task CreateUserCommentAsync(CreateUserCommentDto createUserCommentDto);
        Task UpdateUserCommentAsync(UpdateUserCommentDto updateUserCommentDto);
        Task DeleteUserCommentAsync(int id);
        Task<List<ResultUserCommentDto>> GetUserCommentByProductIdAsync(string id);
    }
}
