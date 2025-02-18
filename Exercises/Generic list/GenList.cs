public class GenList<T> {
    private T[] data;
    public T this[int i] => data[i];
    public int Size => data.Length;

    public GenList() { data = new T[0]; }

    public void Add(T element) {
        T[] newData = new T[Size+1];
        System.Array.Copy(data, newData, Size);
        newData[Size] = element;
        data = newData;
    }

    public void Remove(int index) {
        T[] newData = new T[Size-1];
        System.Array.Copy(data, 0, newData, 0, index); // Copy all elements before the index to be removed
        System.Array.Copy(data, index+1, newData, index, Size-index-1); // Copy all elements after the index to be removed
        data = newData;
    }
}