using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Threading;
using Microsoft.Xna.Framework;

// Token: 0x02000211 RID: 529
public static class daw
{
	// Token: 0x06000EDE RID: 3806 RVA: 0x0003E488 File Offset: 0x0003C688
	static daw()
	{
		daw.a();
	}

	// Token: 0x06000EDF RID: 3807 RVA: 0x0003E4E8 File Offset: 0x0003C6E8
	public static chh b(int A_0)
	{
		daw.b.EnterWriteLock();
		chh result;
		try
		{
			ve ve = daw.a(A_0);
			Queue<chh> queue;
			daw.c.TryGetValue(ve, out queue);
			if (queue.Count > 0)
			{
				result = queue.Dequeue();
			}
			else
			{
				Trace.WriteLine("Pathfinding Matrix Create");
				result = new chh(daw.a(ve));
			}
		}
		finally
		{
			daw.b.ExitWriteLock();
		}
		return result;
	}

	// Token: 0x06000EE0 RID: 3808 RVA: 0x0003E564 File Offset: 0x0003C764
	public static void a(chh A_0)
	{
		daw.a a = new daw.a();
		a.a = A_0;
		ThreadPool.QueueUserWorkItem(new WaitCallback(a.a));
	}

	// Token: 0x06000EE1 RID: 3809 RVA: 0x0003E584 File Offset: 0x0003C784
	private static void a()
	{
		foreach (KeyValuePair<ve, Point> keyValuePair in daw.a)
		{
			daw.c[keyValuePair.Key] = new Queue<chh>();
			for (int i = 0; i < keyValuePair.Value.X; i++)
			{
				daw.c[keyValuePair.Key].Enqueue(new chh(daw.a(keyValuePair.Key)));
			}
		}
	}

	// Token: 0x06000EE2 RID: 3810 RVA: 0x0003E62C File Offset: 0x0003C82C
	private static int a(ve A_0)
	{
		if (A_0 == ve.a)
		{
			return 1;
		}
		if (A_0 == ve.b)
		{
			return 3;
		}
		return 7;
	}

	// Token: 0x06000EE3 RID: 3811 RVA: 0x0003E640 File Offset: 0x0003C840
	private static ve a(int A_0)
	{
		if (A_0 == 1)
		{
			return ve.a;
		}
		if (A_0 == 3)
		{
			return ve.b;
		}
		return ve.c;
	}

	// Token: 0x040008E7 RID: 2279
	private static readonly Dictionary<ve, Point> a = new Dictionary<ve, Point>
	{
		{
			ve.a,
			new Point(0, 20)
		},
		{
			ve.b,
			new Point(0, 15)
		},
		{
			ve.c,
			new Point(10, 20)
		}
	};

	// Token: 0x040008E8 RID: 2280
	private static ReaderWriterLockSlim b = new ReaderWriterLockSlim();

	// Token: 0x040008E9 RID: 2281
	private static Dictionary<ve, Queue<chh>> c = new Dictionary<ve, Queue<chh>>();

	// Token: 0x02000212 RID: 530
	[CompilerGenerated]
	private sealed class a
	{
		// Token: 0x06000EE5 RID: 3813 RVA: 0x0003E664 File Offset: 0x0003C864
		internal void a(object A_0)
		{
			this.a.a();
			daw.b.EnterWriteLock();
			try
			{
				ve key = daw.a(this.a.d);
				Queue<chh> queue;
				daw.c.TryGetValue(key, out queue);
				if (queue.Count < daw.a[key].Y)
				{
					queue.Enqueue(this.a);
				}
			}
			finally
			{
				daw.b.ExitWriteLock();
			}
		}

		// Token: 0x040008EA RID: 2282
		public chh a;
	}
}
