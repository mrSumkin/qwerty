using System;
using System.Collections.Generic;

namespace Ouroboros.Common.Data
{
	// Token: 0x02002218 RID: 8728
	public class BinaryHeap<T>
	{
		// Token: 0x0600CA94 RID: 51860 RVA: 0x0047C544 File Offset: 0x0047A744
		public int a()
		{
			return this.c;
		}

		// Token: 0x0600CA95 RID: 51861 RVA: 0x0047C54C File Offset: 0x0047A74C
		public BinaryHeap(bool A_0, IComparer<T> A_1, int A_2, IEnumerable<T> A_3)
		{
			this.a(A_0, A_1, A_2, A_3);
		}

		// Token: 0x0600CA96 RID: 51862 RVA: 0x0047C560 File Offset: 0x0047A760
		public BinaryHeap(bool A_0, IComparer<T> A_1, int A_2) : this(A_0, A_1, A_2, null)
		{
		}

		// Token: 0x0600CA97 RID: 51863 RVA: 0x0047C56C File Offset: 0x0047A76C
		public BinaryHeap(bool A_0, IComparer<T> A_1, IEnumerable<T> A_2) : this(A_0, A_1, 16, A_2)
		{
		}

		// Token: 0x0600CA98 RID: 51864 RVA: 0x0047C57C File Offset: 0x0047A77C
		public BinaryHeap(bool A_0, IComparer<T> A_1) : this(A_0, A_1, 16, null)
		{
		}

		// Token: 0x0600CA99 RID: 51865 RVA: 0x0047C58C File Offset: 0x0047A78C
		public BinaryHeap(bool A_0, IEnumerable<T> A_1) : this(A_0, Comparer<T>.Default, 16, A_1)
		{
		}

		// Token: 0x0600CA9A RID: 51866 RVA: 0x0047C5A0 File Offset: 0x0047A7A0
		public BinaryHeap(bool A_0) : this(A_0, Comparer<T>.Default, 16, null)
		{
		}

		// Token: 0x0600CA9B RID: 51867 RVA: 0x0047C5B4 File Offset: 0x0047A7B4
		public BinaryHeap() : this(false, Comparer<T>.Default, 16, null)
		{
		}

		// Token: 0x0600CA9C RID: 51868 RVA: 0x0047C5C8 File Offset: 0x0047A7C8
		public void a(T A_0)
		{
			czh.a(A_0, "item");
			if (this.c == this.d)
			{
				this.a(this.d * 2, true);
			}
			T[] array = this.b;
			int num = this.c + 1;
			this.c = num;
			array[num] = A_0;
			this.b(this.c);
		}

		// Token: 0x0600CA9D RID: 51869 RVA: 0x0047C630 File Offset: 0x0047A830
		public void a(IEnumerable<T> A_0)
		{
			czh.a(A_0, "source");
			foreach (T a_ in A_0)
			{
				this.a(a_);
			}
		}

		// Token: 0x0600CA9E RID: 51870 RVA: 0x0047C68C File Offset: 0x0047A88C
		public int b(T A_0)
		{
			czh.a(A_0, "item");
			for (int i = 1; i <= this.c; i++)
			{
				if (this.b[i].Equals(A_0))
				{
					return i;
				}
			}
			return -1;
		}

		// Token: 0x0600CA9F RID: 51871 RVA: 0x0047C6E4 File Offset: 0x0047A8E4
		public T d(int A_0)
		{
			if (A_0 < 1 || A_0 > this.c)
			{
				throw new IndexOutOfRangeException();
			}
			return this.b[A_0];
		}

		// Token: 0x0600CAA0 RID: 51872 RVA: 0x0047C70C File Offset: 0x0047A90C
		public T b()
		{
			if (this.c == 0)
			{
				throw new IndexOutOfRangeException("Heap is empty.");
			}
			T result = this.b[1];
			this.c--;
			if (this.c > 0)
			{
				this.b[1] = this.b[this.c + 1];
				if (this.c > 1)
				{
					this.a(1);
				}
			}
			return result;
		}

		// Token: 0x0600CAA1 RID: 51873 RVA: 0x0047C788 File Offset: 0x0047A988
		public T c()
		{
			if (this.c == 0)
			{
				throw new IndexOutOfRangeException("Heap is empty.");
			}
			return this.b[1];
		}

		// Token: 0x0600CAA2 RID: 51874 RVA: 0x0047C7AC File Offset: 0x0047A9AC
		public void e(int A_0)
		{
			if (A_0 < 1 || A_0 > this.c)
			{
				throw new IndexOutOfRangeException();
			}
			this.b(A_0);
		}

		// Token: 0x0600CAA3 RID: 51875 RVA: 0x0047C7D0 File Offset: 0x0047A9D0
		public void c(int A_0)
		{
			if (A_0 < 1 || A_0 > this.c)
			{
				throw new IndexOutOfRangeException();
			}
			this.a(A_0);
		}

		// Token: 0x0600CAA4 RID: 51876 RVA: 0x0047C7F4 File Offset: 0x0047A9F4
		public override string ToString()
		{
			string text = "Count: " + this.c.ToString();
			if (this.c > 0)
			{
				string str = text;
				string str2 = ". Topmost: ";
				T t = this.b[1];
				text = str + str2 + ((t != null) ? t.ToString() : null);
			}
			return text;
		}

		// Token: 0x0600CAA5 RID: 51877 RVA: 0x0047C85C File Offset: 0x0047AA5C
		private void a(bool A_0, IComparer<T> A_1, int A_2, IEnumerable<T> A_3)
		{
			this.e = A_0;
			this.f = (A_1 ?? Comparer<T>.Default);
			this.a(A_2, false);
			if (A_3 != null)
			{
				this.a(A_3);
			}
		}

		// Token: 0x0600CAA6 RID: 51878 RVA: 0x0047C894 File Offset: 0x0047AA94
		private void a(int A_0, bool A_1)
		{
			T[] array = new T[A_0 + 1];
			if (A_1)
			{
				for (int i = 1; i <= this.c; i++)
				{
					array[i] = this.b[i];
				}
			}
			this.d = A_0;
			this.b = array;
		}

		// Token: 0x0600CAA7 RID: 51879 RVA: 0x0047C8E8 File Offset: 0x0047AAE8
		private void b(int A_0)
		{
			int num2;
			for (int num = A_0; num != 1; num = num2)
			{
				num2 = num / 2;
				if (!this.b(num, num2))
				{
					break;
				}
				this.a(num, num2);
			}
		}

		// Token: 0x0600CAA8 RID: 51880 RVA: 0x0047C91C File Offset: 0x0047AB1C
		private void a(int A_0)
		{
			int num4;
			for (int num = A_0; num != this.c; num = num4)
			{
				int num2 = num * 2;
				int num3 = num * 2 + 1;
				bool flag = num2 <= this.c;
				bool flag2 = num3 <= this.c;
				if (flag)
				{
					if (flag2)
					{
						if (this.b(num2, num3))
						{
							num4 = num2;
						}
						else
						{
							num4 = num3;
						}
					}
					else
					{
						num4 = num2;
					}
				}
				else
				{
					if (!flag2)
					{
						break;
					}
					num4 = num3;
				}
				if (!this.b(num4, num))
				{
					break;
				}
				this.a(num, num4);
			}
		}

		// Token: 0x0600CAA9 RID: 51881 RVA: 0x0047C9B0 File Offset: 0x0047ABB0
		private bool b(int A_0, int A_1)
		{
			int num = this.f.Compare(this.b[A_0], this.b[A_1]);
			if (this.e)
			{
				return num > 0;
			}
			return num < 0;
		}

		// Token: 0x0600CAAA RID: 51882 RVA: 0x0047C9F8 File Offset: 0x0047ABF8
		private void a(int A_0, int A_1)
		{
			T t = this.b[A_0];
			this.b[A_0] = this.b[A_1];
			this.b[A_1] = t;
		}

		// Token: 0x04004A19 RID: 18969
		private const int a = 16;

		// Token: 0x04004A1A RID: 18970
		private T[] b;

		// Token: 0x04004A1B RID: 18971
		private int c;

		// Token: 0x04004A1C RID: 18972
		private int d;

		// Token: 0x04004A1D RID: 18973
		private bool e;

		// Token: 0x04004A1E RID: 18974
		private IComparer<T> f;
	}
}
