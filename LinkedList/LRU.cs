/*LRU (Least Recently Used) Cache System
Use Case: Design an LRU Cache system (as in browsers, OS, etc.) where the most
recently accessed item moves to the front.
Why LinkedList? Efficient removal from middle and addition to front when accessed.
OOP Concepts:
● Encapsulation: Key-value cache structure is hidden from user.
● Abstraction: Provides simple get() and put() interface.
● Composition: Uses LinkedList + HashMap internally.*/


using System;

public class Block
{
    public int Key;
    public int Value;
    public Block Next;

    public Block(int key, int value)
    {
        Key = key;
        Value = value;
        Next = null;
    }
}


// Abstraction
public abstract class Cache
{
    public abstract int Get(int key);
    public abstract void Put(int key, int value);
}



public class SimpleLRU : Cache
{
    private Block head;
    private Dictionary<int, Block> map = new Dictionary<int, Block>();
    private int capacity = 3;

    public override int Get(int key)
    {
        if (!map.ContainsKey(key))
            return -1;

        return map[key].Value;

    }
    public override void Put(int key, int value)
    {
        if (map.Count == capacity)
        {
            Console.WriteLine("Cache Full, Old Data Removed");
            head = head.Next; 
        }

        Block newBlock = new Block(key, value);
        newBlock.Next = head;
        head = newBlock;
        map[key] = newBlock;
    }
}