using System;


public interface IAbstractCollection

{
    Iterator CreateIterator();
}


public sealed class Collection : IAbstractCollection

{
    private Object[,] _items;


    public Iterator CreateIterator()

    {
        return new(this);
    }

    public ReverseIterator CreateReverseIterator()

    {
        return new(this);
    }

    public void InitializeItems(Object[,] items)
    {
        _items = items;
    }


    public (Int32, Int32) Count => (_items.GetLength(0), _items.GetLength(0));


    public Object this[Int32 i, Int32 j]

    {
        get => _items[i, j];

        set => _items[i, j] = value;
    }
}


public interface IAbstractIterator

{
    Object First();

    Object Next();

    Boolean IsDone { get; }

    Object CurrentItem { get; }
}


public sealed class Iterator : IAbstractIterator

{
    private readonly Collection _matrix;

    private Int32 _current = 0;

    private Int32 _step = 1;


    public Iterator(Collection matrix)

    {
        _matrix = matrix;
    }


    public Object First()

    {
        _current = 0;

        return _matrix[_current, _current];
    }


    public Object Next()

    {
        _current += _step;

        return !IsDone ? _matrix[_current, _current] : null;
    }


    public Int32 Step

    {
        get => _step;

        set => _step = value;
    }


    public Object CurrentItem => _matrix[_current, _current];


    public Boolean IsDone => (_current >= _matrix.Count.Item1 || _current >= _matrix.Count.Item2);
}

public sealed class ReverseIterator : IAbstractIterator

{
    private readonly Collection _matrix;

    private Int32 _current;

    private Int32 _step = 1;


    public ReverseIterator(Collection matrix)

    {
        _matrix = matrix;
        _current = matrix.Count.Item1;
    }


    public Object First()

    {
        _current = _matrix.Count.Item1 - 1;

        return _matrix[_current, _current];
    }


    public Object Next()

    {
        _current -= _step;

        return !IsDone ? _matrix[_current, _current] : null;
    }


    public Int32 Step

    {
        get => _step;

        set => _step = value;
    }


    public Object CurrentItem => _matrix[_current, _current];


    public Boolean IsDone => (_current < 0);
}