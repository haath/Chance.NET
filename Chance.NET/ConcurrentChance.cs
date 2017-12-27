using System;
using System.Threading;

namespace ChanceNET
{
	/// <summary>
	/// Represents an instance of Chance where the underlying generator has been made thread-safe.
	/// </summary>
	public class ConcurrentChance : Chance
	{
		int concurrentSeed;
		ThreadLocal<Random> concurrentRand;

		protected override Random rand {
			get { return concurrentRand.Value; }
		}

		/// <summary>
		/// The default seed value is derived from the system clock and has finite resolution. As a result, different Chance objects that are created in close succession
		/// by a call to the default constructor will have identical default seed values and, therefore, will produce identical sets of random numbers. 
		/// <para>To create multiple Chance objects without a seed, it is recommended that you use the Chance.New() method.</para>
		/// </summary>
		public ConcurrentChance() : this(Environment.TickCount) { }

		public ConcurrentChance(int seed) : base(seed)
		{
			concurrentSeed = seed;
			concurrentRand = new ThreadLocal<Random>(() => new Random(Interlocked.Increment(ref concurrentSeed)));
		}

		public ConcurrentChance(string seed) : base(seed)
		{
			concurrentSeed = this.seed;
			concurrentRand = new ThreadLocal<Random>(() => new Random(Interlocked.Increment(ref concurrentSeed)));
		}
	}
}
