using System;
using System.Collections;
using System.Collections.Generic;
using System.Numerics;

namespace SequencesTask
{
    /// <summary>
    /// Generator of the sequences.
    /// </summary>
    public static class SequenceGenerator
    {
        /// <summary>
        /// Generates the Fibonacci sequence.
        /// </summary>
        /// <param name="count">Sequence length.</param>
        /// <returns>The Fibonacci sequence of <paramref name="count"/> first numbers.</returns>
        /// <exception cref="ArgumentException">Thrown when <paramref name="count"/> is less than 1.</exception>
        public static IEnumerable<BigInteger> GetFibonacciNumbers(int count)
        {
            if (count < 1)
            {
                throw new ArgumentException("Count is less than 1.");
            }

            return Core(count);

            static IEnumerable<BigInteger> Core(int count)
            {
                BigInteger v1 = 0;
                BigInteger v2 = 1;

                for (int i = 0; i < count; ++i)
                {
                    yield return v1;
                    var tmp = v2;
                    v2 = v1 + v2;
                    v1 = tmp;
                }
            }
        }

        /// <summary>
        /// Generates the sequence of prime numbers.
        /// </summary>
        /// <param name="count">Sequence length.</param>
        /// <returns>A sequence of <paramref name="count"/> first prime numbers.</returns>
        /// <exception cref="ArgumentException">Thrown when <paramref name="count"/> is less than 1.</exception>
        public static IEnumerable<int> GetPrimeNumbers(int count)
        {
            if (count < 1)
            {
                throw new ArgumentException("Count is less than 1.");
            }

            return Core(count);

            static IEnumerable<int> Core(int count)
            {
                int n = 2;

                for (int i = 0; i < count;)
                {
                    if (IsPrime(n))
                    {
                        yield return n;
                        i++;
                    }
                    n++;
                }

                static bool IsPrime(int n)
                {
                    bool isPrime = true;

                    for (int i = 2; i < n; i++)
                    {
                        if (n % i == 0)
                        {
                            isPrime = false;
                        }
                    }

                    return isPrime;
                }
            }
        }

    }
}