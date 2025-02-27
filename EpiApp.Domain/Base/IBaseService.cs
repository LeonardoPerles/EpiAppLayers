using FluentValidation;

namespace EpiApp.Domain.Base
{
    public interface IBaseService<TEntity> where TEntity : IBaseEntity
    {
        void AttachObject(object obj);
        TOutputModel Create<TInputModel, TOutputModel, TValidator>(TInputModel inputModel)
            where TValidator : AbstractValidator<TEntity>
            where TInputModel : class
            where TOutputModel : class;
        TOutputModel Update<TInputModel, TOutputModel, TValidator>(TInputModel inputModel)
            where TValidator : AbstractValidator<TEntity>
            where TInputModel : class
            where TOutputModel : class;
        void Delete(int id);
        IEnumerable<TOutputModel> ListAll<TOutputModel>(bool tracking = true, IList<string>? includes = null)
            where TOutputModel : class;
        TOutputModel GetById<TOutputModel>(int id, bool tracking = true, IList<string>? includes = null)
            where TOutputModel : class;

    }
}
