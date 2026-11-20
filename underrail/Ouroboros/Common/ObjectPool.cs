using System;
using System.Collections.Generic;

namespace Ouroboros.Common
{
	// Token: 0x0200000F RID: 15
	public class ObjectPool<T> where T : new()
	{
		// Token: 0x06000013 RID: 19 RVA: 0x00002B0C File Offset: 0x00000D0C
		public int a()
		{
			return this.a.Count + this.b.Count;
		}

		// Token: 0x06000014 RID: 20 RVA: 0x00002B28 File Offset: 0x00000D28
		public ObjectPool(int A_0, int A_1)
		{
			for (int i = 0; i < A_0; i++)
			{
				this.a.Enqueue(Activator.CreateInstance<T>());
			}
			this.c = A_1;
		}

		// Token: 0x06000015 RID: 21 RVA: 0x00002B78 File Offset: 0x00000D78
		public T b()
		{
			T t;
			if (this.a.Count == 0)
			{
				if (this.c > 0 && this.a() >= this.c)
				{
					return default(T);
				}
				t = Activator.CreateInstance<T>();
			}
			else
			{
				t = this.a.Dequeue();
			}
			this.b.AddFirst(t);
			return t;
		}

		// Token: 0x06000016 RID: 22 RVA: 0x00002BE4 File Offset: 0x00000DE4
		public void a(T A_0)
		{
			if (this.b.Remove(A_0))
			{
				this.a.Enqueue(A_0);
			}
		}

		// Token: 0x04000071 RID: 113
		private Queue<T> a = new Queue<T>();

		// Token: 0x04000072 RID: 114
		private LinkedList<T> b = new LinkedList<T>();

		// Token: 0x04000073 RID: 115
		private int c;
	}
}
