// using System;
using System.Collections;
// using System.Collections.Generic;

namespace Chpt18DictHash_TablesAndSets;

/// <summary>Implementation of <see cref="IDictionary" /> interface usaing a hash table. Collisions are resolved by chaining.</summary>
/// <typeparam name="K">Type of the keys. Keys are required to correctly implement Equals() and GetHashCode()</typeparam>
/// <typeparam name="V">Type of the values</typeparam>
public class HashDictionary<K, V> : IDictionary<K, V>, IEnumerable<KeyValuePair<K, V>>
{
    private const int DEFAULT_CAPACITY = 16;
    private const float DEFAULT_CAPACITY_FACTOR = 0.75f;
    private List<KeyValuePair<K, V>>[] table;
    private float loadFactor;
    private int threshold;
    private int size;
    private int initialCapacity;

    /// <summary>Creates an empty hash table with the default capacity and load factor</summary>
    public HashDictionary() : this(DEFAULT_CAPACITY, DEFAULT_CAPACITY_FACTOR)
    { }

    /// <summary>Creates an empty hash table with given capacity and load factor</summary>
    public HashDictionary(int capacity, float loadFactor)
    {
        this.initialCapacity = capacity;
        this.table = new List<KeyValuePair<K, V>>[capacity];
        this.loadFactor = loadFactor;
        this.threshold = (int)(capacity * this.loadFactor);
    }

    /// <summary>Finds the chain of elements corresponding to the givrn key (by its hash code)</summary>
    /// <param name="createIfMissing">creates an empty list of elements if the chain still does
    /// not exist</param>
    /// <returns>a list of elements in the chain or null</returns>
    private List<KeyValuePair<K, V>> FindChain(K key, bool createIfMissing)
    {
        int index = key.GetHashCode();
        index = index & 0x7FFFFFFF; // clear the negative bit
        index = index % this.table.Length;
        if (this.table[index] == null && createIfMissing)
        {
            this.table[index] = new List<KeyValuePair<K, V>>();
        }
        return this.table[index] as List<KeyValuePair<K, V>>;
    }

    /// <summary>Finds the value assigned to given key (works extremely fast)</summary>
    /// <returns>the value found or null when not found</returns>
    public V Get(K key)
    {
        List<KeyValuePair<K, V>> chain = this.FindChain(key, false);
        if (chain != null)
        {
            foreach (KeyValuePair<K, V> entry in chain)
            {
                if (entry.Key.Equals(key))
                {
                    return entry.Value;
                }
            }
        }
        return default(V);

    }

    /// <summary>Assigns a value to certain key. if the key exists, its value is replaced. If the key does not exist, it is first created. WWorks very fast</summary>
    /// <returns>the old (replaced) value or null</returns>
    public V Set(K key, V value)
    {
        if (this.size >= this.threshold)
        {
            this.Expand();
        }

        List<KeyValuePair<K, V>> chain = this.FindChain(key, true);
        for (int i = 0; i < chain.Count; i++)
        {

            KeyValuePair<K, V> entry = chain[i];
            if (entry.Key.Equals(key))
            {
                // Key found -> replaces its value with the new value
                KeyValuePair<K, V> newEntry = new KeyValuePair<K, V>(key, value);
                chain[i] = newEntry;
                return entry.Value;
            }
        }
        chain.Add(new KeyValuePair<K, V>(key, value));
        this.size++;

        return default(V);
    }

    /// <summary>Gets / sets the value by given key. Get returns n ull when the key is not found. Set replaces the existing value or creates a new key-value pair if the key does not exist. Works vary fast</summary>
    public V this[K key]
    {

        get
        {
            return this.Get(key);
        }
        set
        {
            this.Set(key, value);
        }
    }

    /// <summary>Removes a key-value pair specified by certain key from the has table</summary>
    /// <returns>true if the p[air was found removed or false if the key was not found</returns>
    public bool Remove(K key)
    {
        List<KeyValuePair<K, V>> chain = this.FindChain(key, false);
        if (chain != null)
        {
            for (int i = 0; i < chain.Count; i++)
            {
                KeyValuePair<K, V> entry = chain[i];
                if (entry.Key.Equals(key))
                {
                    // Key found -> remove it
                    chain.RemoveAt(i);
                    this.size--;
                    return true;
                }
            }
        }
        return false;
    }

    /// <summary>Returns the number of the key-vAlue pairs in the hash table</summary>
    public int Count
    {
        get { return this.size; }
    }

    /// <summary>Clears all elements of the hash table</summary>
    public void Clear()
    {
        this.table = new List<KeyValuePair<K, V>>[this.initialCapacity];
        this.size = 0;
    }

    /// <summary>Expands the underlying hash-table. Creates 2 times bigger table and transfers the old elements into it. This is a slow linear expression</summary>
    private void Expand()
    {
        int newCapacity = 2 * this.table.Length;
        List<KeyValuePair<K, V>>[] oldTable = this.table;
        this.table = new List<KeyValuePair<K, V>>[newCapacity];
        this.threshold = (int)(newCapacity * this.loadFactor);
        foreach (List<KeyValuePair<K, V>> oldChain in oldTable)
        {
            if (oldChain != null)
                foreach (KeyValuePair<K, V> keyValuePair in oldChain)
                {
                    List<KeyValuePair<K, V>> chain = FindChain(keyValuePair.Key, true);
                    chain.Add(keyValuePair);
                }
        }
    }
    /// <summary>Implements the IEnumerable<KeyValuePair<K. V>>to allow iterating over the key-value pairs in the hash table in foreach-loop</summary>
    IEnumerator<KeyValuePair<K, V>> IEnumerable<KeyValuePair<K, V>>.GetEnumerator()
    {
        foreach (List<KeyValuePair<K, V>> chain in this.table)
        {
            if (chain != null)
            {
                foreach (KeyValuePair<K, V> entry in chain)
                {
                    yield return entry;
                }
            }
        }
    }
    /// <summary>Implements IEnumerable (non-generic)as part of IEnumerable<KeyValuePair<K, V>> </summary>
    IEnumerator IEnumerable.GetEnumerator()
    {
        return ((IEnumerable<KeyValuePair<K, V>>)this).GetEnumerator();
    }

    public static void PrintHashDictionary()
    {
        {
            HashDictionary<Point3D, int> dict = new HashDictionary<Point3D, int>(3, 0.9f);
            dict[new Point3D(1, 2, 3)] = 1; // Put a key-value pair
            Console.WriteLine(dict[new Point3D(1, 2, 3)]);
            // Get value
            // Overwrite the previous value for the same key
            dict[new Point3D(1, 2, 3)] += 1;
            Console.WriteLine(dict[new Point3D(1, 2, 3)]);
            // Now this point will cause a collision with the
            // previous one and the elements will be chained
            dict[new Point3D(3, 2, 2)] = 42;
            Console.WriteLine(dict[new Point3D(3, 2, 2)]);
            // Test if the chaining works as expected, i.e.
            // elements with equal hash-codes are not overwritten
            Console.WriteLine(dict[new Point3D(1, 2, 3)]);
            // Creation of another entry in the internal table
            // This will cause the internal table to expand
            dict[new Point3D(4, 5, 6)] = 1111;
            Console.WriteLine(dict[new Point3D(4, 5, 6)]);
            // Delete an existing by its key
            dict.Remove(new Point3D(3, 2, 2));
            // Iterate through the dictionary entries and print them
            foreach (KeyValuePair<Point3D, int> entry in dict)
            {
                Console.WriteLine(
                "Key: " + entry.Key + "; Value: " + entry.Value);
            }
        }
    }
}
