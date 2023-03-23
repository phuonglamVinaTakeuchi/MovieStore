using AutoMapper;
using MovieStore.Models.Entities;
using MovieStore.Models.ViewModels;

namespace MovieStore
{
  public class MappingProfile : Profile
  {
    public MappingProfile()
    {
      CreateMap<Actor, ActorViewModel>().ReverseMap();
      CreateMap<MovieCategory, MovieCategoryViewModel>().ReverseMap();
      CreateMap<Producer, ProducerViewModel>().ReverseMap();
      CreateMap<Cinema, CinemaViewModel>().ReverseMap();
      CreateMap<Movie, MovieViewModel>().ReverseMap();
    }
  }
}
