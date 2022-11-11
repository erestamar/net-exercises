using Tasks.generics.Model;

namespace Tasks.generics.Repo
{
    public class GenericRepo<TModel> where TModel : BaseItem
    {
        private List<TModel> models = new();

        public TModel GetById(string id)
        {
            return models.Where(model => model.Id == id).FirstOrDefault();
        }

        public void Insert(TModel model)
        {
            models.Add(model);
        }

        public void Delete(string id)
        {
            var index = models.FindIndex(model => model.Id == id);
            models.RemoveAt(index);
        }
    }
}
