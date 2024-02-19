﻿namespace iterator;

public interface IIterator<T>
{
    bool HasNext();
    T Next();
    void Reset();
}
