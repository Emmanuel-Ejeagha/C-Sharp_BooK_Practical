using System;

namespace Chpt18DictHash_TablesAndSets;
/// <summary>Interface that defines basic methods needed for a "dictionary" class which maps keys to values</summary>
/// <typeparam name="K">Key type</typeparam>
/// <typeparam name="V">Value type</typeparam>

public interface IDictionary<K, V> : IEnumerable<KeyValuePair<K, V>>
{
    /// <summary>Finds the value mapped to the given key</summary>
    /// <param name="key">the key to searchedn</param>
    /// <returns>value for the specified key if it is present or null if there is no value with the key</returns>
    V Get(K key);

    /// <summary>Assigns the specified value to the sp[ecified key in the dictionary. If the value already existd, its value is replaced with the new value and the old value is returned</summary>
    /// <param name="key">Key for the new value</param>
    /// <param name="value">Value mapped to the key</param>
    /// <returns>the old (replaced) value for the specified key or null if the key does not exist</returns>
    V Set(K key, V value);

    /// <summary>Gets or sets the value of the entry in the dictionary identified by the key specified</summary>
    /// <remarks>A new entry will be created if the value is set for a key not currently in the dictionary</remarks>
    /// <param name="key">the key to identify the entry</param>
    /// <returns>the value of the entry in the dictionary identified by the provided key</returns>
    V this[K key] { get; set; }

    /// <summary>Removes an element in the dictionary identified by a specified key</summary>
    /// <param name="key">The key identifying the element to be removed</param>
    /// <returns>whether the element was removed or not</returns>
    bool Remove(K key);

    /// <summary>Returns the number of entries in the dictionary</summary>
    int Count { get; }

    /// <summary>Removes all the elements from the dictionary</summary>
    void Clear();
}
