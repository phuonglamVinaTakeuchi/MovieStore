using AutoMapper;
using MovieStore.Models.Entities;

namespace MovieStore
{
  public class MappingProfile : Profile
  {
    public MappingProfile()
    {
      CreateMap<Actor, Actor>();
    }
  }
}
