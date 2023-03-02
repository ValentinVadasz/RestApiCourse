﻿using Movies.Application.Models;

namespace Movies.Application.Services;

public interface IMovieService
{
    public Task<bool> CreateAsync(Movie movie);
    public Task<Movie?> GetByIdAsync(Guid id);
    public Task<Movie?> GetBySlugAsync(string slug);
    public Task<IEnumerable<Movie>> GetAllAsync();
    public Task<Movie?> UpdateAsync(Movie movie);
    public Task<bool> DeleteByIdAsync(Guid id);
}