﻿namespace iterator;

public interface IIterable<T>
{
    IIterator<T> CreateIterator();
}
