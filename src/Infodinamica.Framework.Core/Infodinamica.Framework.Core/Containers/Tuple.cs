namespace Infodinamica.Framework.Core.Containers
{
    /// <summary>
    /// Tuple para .NET 3.5
    /// </summary>
    /// <typeparam name="T1">Parámetro 1</typeparam>
    public class Tuple<T1>
    {
        /// <summary>
        /// Constructor
        /// </summary>
        public Tuple()
        {
        }

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="item1">Parámetro 1</param>
        public Tuple(T1 item1)
        {
            Item1 = item1;
        }

        /// <summary>
        /// Acceso al parámetro 1
        /// </summary>
        public T1 Item1 { get; set; }
    }

    /// <summary>
    /// Tuple para .NET 3.5
    /// </summary>
    /// <typeparam name="T1">Parámetro 1</typeparam>
    /// <typeparam name="T2">Parámetro 2</typeparam>
    public class Tuple<T1, T2> : Tuple<T1>
    {
        /// <summary>
        /// Constructor
        /// </summary>
        public Tuple()
        {
        }

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="item1">Parámetro 1</param>
        /// <param name="item2">Parámetro 2</param>
        public Tuple(T1 item1, T2 item2)
            : base(item1)
        {
            Item2 = item2;
        }

        /// <summary>
        /// Acceso al parámetro 2
        /// </summary>
        public T2 Item2 { get; set; }
    }

    /// <summary>
    /// Tuple para .NET 3.5
    /// </summary>
    /// <typeparam name="T1">Parámetro 1</typeparam>
    /// <typeparam name="T2">Parámetro 2</typeparam>
    /// <typeparam name="T3">Parámetro 3</typeparam>
    public class Tuple<T1, T2, T3> : Tuple<T1, T2>
    {
        /// <summary>
        /// Constructor
        /// </summary>
        public Tuple()
        {
        }

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="item1">Parámetro 1</param>
        /// <param name="item2">Parámetro 2</param>
        /// <param name="item3">Parámetro 3</param>
        public Tuple(T1 item1, T2 item2, T3 item3)
            : base(item1, item2)
        {
            Item3 = item3;
        }

        /// <summary>
        /// Acceso al parámetro 3
        /// </summary>
        public T3 Item3 { get; set; }
    }

    /// <summary>
    /// Tuple para .NET 3.5
    /// </summary>
    /// <typeparam name="T1">Parámetro 1</typeparam>
    /// <typeparam name="T2">Parámetro 2</typeparam>
    /// <typeparam name="T3">Parámetro 3</typeparam>
    /// <typeparam name="T4">Parámetro 4</typeparam>
    public class Tuple<T1, T2, T3, T4> : Tuple<T1, T2, T3>
    {
        /// <summary>
        /// Constructor
        /// </summary>
        public Tuple()
        {
        }

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="item1">Parámetro 1</param>
        /// <param name="item2">Parámetro 2</param>
        /// <param name="item3">Parámetro 3</param>
        /// <param name="item4">Parámetro 4</param>
        public Tuple(T1 item1, T2 item2, T3 item3, T4 item4)
            :base(item1, item2, item3)
        {
            Item4 = item4;
        }

        /// <summary>
        /// Acceso al parámetro 4
        /// </summary>
        public T4 Item4 { get; set; }
    }

    /// <summary>
    /// Tuple para .NET 3.5
    /// </summary>
    /// <typeparam name="T1">Parámetro 1</typeparam>
    /// <typeparam name="T2">Parámetro 2</typeparam>
    /// <typeparam name="T3">Parámetro 3</typeparam>
    /// <typeparam name="T4">Parámetro 4</typeparam>
    /// <typeparam name="T5">Parámetro 5</typeparam>
    public class Tuple<T1, T2, T3, T4, T5> : Tuple<T1, T2, T3, T4>
    {
        /// <summary>
        /// Constructor
        /// </summary>
        public Tuple()
        {
        }

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="item1">Parámetro 1</param>
        /// <param name="item2">Parámetro 2</param>
        /// <param name="item3">Parámetro 3</param>
        /// <param name="item4">Parámetro 4</param>
        /// <param name="item5">Parámetro 5</param>
        public Tuple(T1 item1, T2 item2, T3 item3, T4 item4, T5 item5)
            : base(item1, item2, item3, item4)
        {
            Item5 = item5;
        }

        /// <summary>
        /// Acceso al parámetro 5
        /// </summary>
        public T5 Item5 { get; set; }
    }

    /// <summary>
    /// Tuple para .NET 3.5
    /// </summary>
    /// <typeparam name="T1">Parámetro 1</typeparam>
    /// <typeparam name="T2">Parámetro 2</typeparam>
    /// <typeparam name="T3">Parámetro 3</typeparam>
    /// <typeparam name="T4">Parámetro 4</typeparam>
    /// <typeparam name="T5">Parámetro 5</typeparam>
    /// <typeparam name="T6">Parámetro 6</typeparam>
    public class Tuple<T1, T2, T3, T4, T5, T6> : Tuple<T1, T2, T3, T4, T5>
    {
        /// <summary>
        /// Constructor
        /// </summary>
        public Tuple()
        {
        }

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="item1">Parámetro 1</param>
        /// <param name="item2">Parámetro 2</param>
        /// <param name="item3">Parámetro 3</param>
        /// <param name="item4">Parámetro 4</param>
        /// <param name="item5">Parámetro 5</param>
        /// <param name="item6">Parámetro 6</param>
        public Tuple(T1 item1, T2 item2, T3 item3, T4 item4, T5 item5, T6 item6)
            : base(item1, item2, item3, item4, item5)
        {
            Item6 = item6;
        }

        /// <summary>
        /// Acceso al parámetro 6
        /// </summary>
        public T6 Item6 { get; set; }
    }

    /// <summary>
    /// Tuple para .NET 3.5
    /// </summary>
    /// <typeparam name="T1">Parámetro 1</typeparam>
    /// <typeparam name="T2">Parámetro 2</typeparam>
    /// <typeparam name="T3">Parámetro 3</typeparam>
    /// <typeparam name="T4">Parámetro 4</typeparam>
    /// <typeparam name="T5">Parámetro 5</typeparam>
    /// <typeparam name="T6">Parámetro 6</typeparam>
    /// <typeparam name="T7">Parámetro 7</typeparam>
    public class Tuple<T1, T2, T3, T4, T5, T6, T7> : Tuple<T1, T2, T3, T4, T5, T6>
    {
        /// <summary>
        /// Constructor
        /// </summary>
        public Tuple()
        {
        }

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="item1">Parámetro 1</param>
        /// <param name="item2">Parámetro 2</param>
        /// <param name="item3">Parámetro 3</param>
        /// <param name="item4">Parámetro 4</param>
        /// <param name="item5">Parámetro 5</param>
        /// <param name="item6">Parámetro 6</param>
        /// <param name="item7">Parámetro 7</param>
        public Tuple(T1 item1, T2 item2, T3 item3, T4 item4, T5 item5, T6 item6, T7 item7)
            : base(item1, item2, item3, item4, item5, item6)
        {
            Item7 = item7;
        }

        /// <summary>
        /// Acceso al parámetro 7
        /// </summary>
        public T7 Item7 { get; set; }
    }

    /// <summary>
    /// Tuple para .NET 3.5
    /// </summary>
    /// <typeparam name="T1">Parámetro 1</typeparam>
    /// <typeparam name="T2">Parámetro 2</typeparam>
    /// <typeparam name="T3">Parámetro 3</typeparam>
    /// <typeparam name="T4">Parámetro 4</typeparam>
    /// <typeparam name="T5">Parámetro 5</typeparam>
    /// <typeparam name="T6">Parámetro 6</typeparam>
    /// <typeparam name="T7">Parámetro 7</typeparam>
    /// <typeparam name="T8">Parámetro 8</typeparam>
    public class Tuple<T1, T2, T3, T4, T5, T6, T7, T8> : Tuple<T1, T2, T3, T4, T5, T6, T7>
    {
        /// <summary>
        /// Constructor
        /// </summary>
        public Tuple()
        {
        }

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="item1">Parámetro 1</param>
        /// <param name="item2">Parámetro 2</param>
        /// <param name="item3">Parámetro 3</param>
        /// <param name="item4">Parámetro 4</param>
        /// <param name="item5">Parámetro 5</param>
        /// <param name="item6">Parámetro 6</param>
        /// <param name="item7">Parámetro 7</param>
        /// <param name="item8">Parámetro 8</param>
        public Tuple(T1 item1, T2 item2, T3 item3, T4 item4, T5 item5, T6 item6, T7 item7, T8 item8)
            : base(item1, item2, item3, item4, item5, item6, item7)
        {
            Item8 = item8;
        }

        /// <summary>
        /// Acceso al parámetro 8
        /// </summary>
        public T8 Item8 { get; set; }
    }

    /// <summary>
    /// Tuple para .NET 3.5
    /// </summary>
    /// <typeparam name="T1">Parámetro 1</typeparam>
    /// <typeparam name="T2">Parámetro 2</typeparam>
    /// <typeparam name="T3">Parámetro 3</typeparam>
    /// <typeparam name="T4">Parámetro 4</typeparam>
    /// <typeparam name="T5">Parámetro 5</typeparam>
    /// <typeparam name="T6">Parámetro 6</typeparam>
    /// <typeparam name="T7">Parámetro 7</typeparam>
    /// <typeparam name="T8">Parámetro 8</typeparam>
    /// <typeparam name="T9">Parámetro 9</typeparam>
    public class Tuple<T1, T2, T3, T4, T5, T6, T7, T8, T9> : Tuple<T1, T2, T3, T4, T5, T6, T7, T8>
    {
        /// <summary>
        /// Constructor
        /// </summary>
        public Tuple()
        {
        }

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="item1">Parámetro 1</param>
        /// <param name="item2">Parámetro 2</param>
        /// <param name="item3">Parámetro 3</param>
        /// <param name="item4">Parámetro 4</param>
        /// <param name="item5">Parámetro 5</param>
        /// <param name="item6">Parámetro 6</param>
        /// <param name="item7">Parámetro 7</param>
        /// <param name="item8">Parámetro 8</param>
        /// <param name="item9">Parámetro 9</param>
        public Tuple(T1 item1, T2 item2, T3 item3, T4 item4, T5 item5, T6 item6, T7 item7, T8 item8, T9 item9)
            : base(item1, item2, item3, item4, item5, item6, item7, item8)
        {
            Item9 = item9;
        }

        /// <summary>
        /// Acceso al parámetro 9
        /// </summary>
        public T9 Item9 { get; set; }
    }

    /// <summary>
    /// Factory de tuplas
    /// </summary>
    public static class Tuple
    {
        /// <summary>
        /// Crea una tupla con 1 parámetro
        /// </summary>
        public static Tuple<T1> Create<T1>(T1 item1)
        {
            return new Tuple<T1>(item1);
        }

        /// <summary>
        /// Crea una tupla con 2 parámetro
        /// </summary>
        public static Tuple<T1, T2> Create<T1, T2>(T1 item1, T2 item2)
        {
            return new Tuple<T1, T2>(item1, item2);
        }

        /// <summary>
        /// Crea una tupla con 3 parámetro
        /// </summary>
        public static Tuple<T1, T2, T3> Create<T1, T2, T3>(T1 item1, T2 item2, T3 item3)
        {
            return new Tuple<T1, T2, T3>(item1, item2, item3);
        }

        /// <summary>
        /// Crea una tupla con 4 parámetro
        /// </summary>
        public static Tuple<T1, T2, T3, T4> Create<T1, T2, T3, T4>(T1 item1, T2 item2, T3 item3, T4 item4)
        {
            return new Tuple<T1, T2, T3, T4>(item1, item2, item3, item4);
        }

        /// <summary>
        /// Crea una tupla con 5 parámetro
        /// </summary>
        public static Tuple<T1, T2, T3, T4, T5> Create<T1, T2, T3, T4, T5>(T1 item1, T2 item2, T3 item3, T4 item4, T5 item5)
        {
            return new Tuple<T1, T2, T3, T4, T5>(item1, item2, item3, item4, item5);
        }

        /// <summary>
        /// Crea una tupla con 6 parámetro
        /// </summary>
        public static Tuple<T1, T2, T3, T4, T5, T6> Create<T1, T2, T3, T4, T5, T6>(T1 item1, T2 item2, T3 item3, T4 item4, T5 item5, T6 item6)
        {
            return new Tuple<T1, T2, T3, T4, T5, T6>(item1, item2, item3, item4, item5, item6);
        }

        /// <summary>
        /// Crea una tupla con 7 parámetro
        /// </summary>
        public static Tuple<T1, T2, T3, T4, T5, T6, T7> Create<T1, T2, T3, T4, T5, T6, T7>(T1 item1, T2 item2, T3 item3, T4 item4, T5 item5, T6 item6, T7 item7)
        {
            return new Tuple<T1, T2, T3, T4, T5, T6, T7>(item1, item2, item3, item4, item5, item6, item7);
        }

        /// <summary>
        /// Crea una tupla con 8 parámetro
        /// </summary>
        public static Tuple<T1, T2, T3, T4, T5, T6, T7, T8> Create<T1, T2, T3, T4, T5, T6, T7, T8>(T1 item1, T2 item2, T3 item3, T4 item4, T5 item5, T6 item6, T7 item7, T8 item8)
        {
            return new Tuple<T1, T2, T3, T4, T5, T6, T7, T8>(item1, item2, item3, item4, item5, item6, item7, item8);
        }

        /// <summary>
        /// Crea una tupla con 9 parámetro
        /// </summary>
        public static Tuple<T1, T2, T3, T4, T5, T6, T7, T8, T9> Create<T1, T2, T3, T4, T5, T6, T7, T8, T9>(T1 item1, T2 item2, T3 item3, T4 item4, T5 item5, T6 item6, T7 item7, T8 item8, T9 item9)
        {
            return new Tuple<T1, T2, T3, T4, T5, T6, T7, T8, T9>(item1, item2, item3, item4, item5, item6, item7, item8, item9);
        }
    }
}
