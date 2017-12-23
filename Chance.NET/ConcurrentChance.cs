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

		public ConcurrentChance() : this(Environment.TickCount)
		{
			concurrentSeed = seed;
			concurrentRand = new ThreadLocal<Random>(() => new Random(Interlocked.Increment(ref concurrentSeed)));
		}

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
