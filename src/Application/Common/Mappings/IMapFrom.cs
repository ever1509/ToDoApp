using AutoMapper;

namespace Application.Common.Mappings
{
    public interface IMapFrom<T>
    {   
        void Mapping(Profile profile);
    }
}