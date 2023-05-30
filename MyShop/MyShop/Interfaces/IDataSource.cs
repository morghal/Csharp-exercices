using MyShop.Models;

namespace MyShop.Interfaces;

/// <summary> Represent a class holding objects that can be serialized/deserialized </summary>
/// <typeparam name="T"> The type of object implementer use. </typeparam>
public interface IDataSource<T> where T : BaseEntity
{
    /// <summary> Load all <see cref="T"/> objects </summary>
    /// <returns> Whether the method run as expected or not </returns>
    public IEnumerable<T> Load();

    /// <summary> Load <see cref="T"/> objects matching <paramref name="predicate"/> </summary>
    /// <returns> The item matching predicate or empty list if nothing is found </returns>
    public IEnumerable<T> Load(Func<T, bool> predicate);

    /// <summary> Load a specific <see cref="T"/> object based on its id </summary>
    /// <returns> The matching object or null if no item have the provided <paramref name="id"/> </returns>
    public T? Load(int id);

    /// <summary> Save the provided <paramref name="dataToSave"/> </summary>
    /// <returns> Whether the method run as expected or not </returns>
    public bool Save(IEnumerable<T> dataToSave);

    /// <summary> Save the provided <paramref name="itemToSave"/> </summary>
    /// <returns> Whether the method run as expected or not </returns>
    public bool Save(T itemToSave);
}
