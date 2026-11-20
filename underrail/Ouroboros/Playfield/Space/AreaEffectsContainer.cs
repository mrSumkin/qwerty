using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;

namespace Ouroboros.Playfield.Space
{
	// Token: 0x02000055 RID: 85
	[eiz("AEC")]
	[Serializable]
	public abstract class AreaEffectsContainer<T> : IEnumerable<T>, ISerializable where T : axv
	{
		// Token: 0x06000159 RID: 345 RVA: 0x00007E18 File Offset: 0x00006018
		protected AreaEffectsContainer(SerializationInfo A_0, StreamingContext A_1)
		{
			if (ell.b() != 0)
			{
				this.a = (aud)A_0.GetValue("AEC:A", typeof(aud));
				this.b = (List<T>)A_0.GetValue("AEC:I", typeof(List<T>));
				return;
			}
			if (base.GetType() == typeof(AreaEffectsContainer<T>))
			{
				this.a = (aud)A_0.GetValue("_Area", typeof(aud));
				this.b = (List<T>)A_0.GetValue("_Items", typeof(List<T>));
				return;
			}
			this.a = (aud)A_0.GetValue("AreaEffectsContainer`1+_Area", typeof(aud));
			this.b = (List<T>)A_0.GetValue("AreaEffectsContainer`1+_Items", typeof(List<T>));
		}

		// Token: 0x0600015A RID: 346 RVA: 0x00007F1C File Offset: 0x0000611C
		public virtual void GetObjectData(SerializationInfo info, StreamingContext context)
		{
			info.AddValue("AEC:A", this.a);
			info.AddValue("AEC:I", this.b);
		}

		// Token: 0x0600015B RID: 347 RVA: 0x00007F40 File Offset: 0x00006140
		public aud a()
		{
			return this.a;
		}

		// Token: 0x0600015C RID: 348 RVA: 0x00007F48 File Offset: 0x00006148
		public AreaEffectsContainer(aud A_0)
		{
			czh.a(A_0, "area");
			this.a = A_0;
		}

		// Token: 0x0600015D RID: 349 RVA: 0x00007F70 File Offset: 0x00006170
		public T c(string A_0)
		{
			T t = this.aid(A_0);
			this.b.Add(t);
			t.g();
			return t;
		}

		// Token: 0x0600015E RID: 350 RVA: 0x00007FA0 File Offset: 0x000061A0
		public T a(Guid A_0, string A_1)
		{
			T t = this.aic(A_0, A_1);
			this.b.Add(t);
			t.g();
			return t;
		}

		// Token: 0x0600015F RID: 351 RVA: 0x00007FD0 File Offset: 0x000061D0
		public bool b(T A_0)
		{
			czh.a(A_0, "item");
			if (!this.b.Contains(A_0))
			{
				A_0.a(this.a);
				this.b.Add(A_0);
				A_0.g();
				return true;
			}
			return false;
		}

		// Token: 0x06000160 RID: 352 RVA: 0x0000802C File Offset: 0x0000622C
		public T a(string A_0)
		{
			AreaEffectsContainer<T>.<>c__DisplayClass10_0 CS$<>8__locals1 = new AreaEffectsContainer<T>.<>c__DisplayClass10_0();
			CS$<>8__locals1.a = A_0;
			czh.a(CS$<>8__locals1.a, "name");
			return Enumerable.FirstOrDefault<T>(Enumerable.Where<T>(this.b, new Func<T, bool>(CS$<>8__locals1.a)));
		}

		// Token: 0x06000161 RID: 353 RVA: 0x00008074 File Offset: 0x00006274
		public T a(Guid A_0)
		{
			AreaEffectsContainer<T>.<>c__DisplayClass11_0 CS$<>8__locals1 = new AreaEffectsContainer<T>.<>c__DisplayClass11_0();
			CS$<>8__locals1.a = A_0;
			return Enumerable.FirstOrDefault<T>(Enumerable.Where<T>(this.b, new Func<T, bool>(CS$<>8__locals1.a)));
		}

		// Token: 0x06000162 RID: 354 RVA: 0x000080AC File Offset: 0x000062AC
		public bool c(T A_0)
		{
			czh.a(A_0, "item");
			if (this.b.Contains(A_0))
			{
				this.a(A_0);
				return true;
			}
			return false;
		}

		// Token: 0x06000163 RID: 355 RVA: 0x000080DC File Offset: 0x000062DC
		public bool b(string A_0)
		{
			czh.a(A_0, "name");
			T t = this.a(A_0);
			if (t != null)
			{
				this.a(t);
				return true;
			}
			return false;
		}

		// Token: 0x06000164 RID: 356 RVA: 0x00008114 File Offset: 0x00006314
		public bool b(Guid A_0)
		{
			T t = this.a(A_0);
			if (t != null)
			{
				this.a(t);
				return true;
			}
			return false;
		}

		// Token: 0x06000165 RID: 357 RVA: 0x00008140 File Offset: 0x00006340
		internal void a(aud A_0)
		{
			this.a = A_0;
			foreach (T t in this.b)
			{
				t.a(A_0);
			}
		}

		// Token: 0x06000166 RID: 358
		protected abstract T aid(string A_0);

		// Token: 0x06000167 RID: 359
		protected abstract T aic(Guid A_0, string A_1);

		// Token: 0x06000168 RID: 360 RVA: 0x000081A4 File Offset: 0x000063A4
		private void a(T A_0)
		{
			A_0.f();
			A_0.a(null);
			this.b.Remove(A_0);
		}

		// Token: 0x06000169 RID: 361 RVA: 0x000081CC File Offset: 0x000063CC
		public IEnumerator<T> GetEnumerator()
		{
			return this.b.GetEnumerator();
		}

		// Token: 0x0600016A RID: 362 RVA: 0x000081E0 File Offset: 0x000063E0
		IEnumerator IEnumerable.b()
		{
			return this.b.GetEnumerator();
		}

		// Token: 0x040002BB RID: 699
		private aud a;

		// Token: 0x040002BC RID: 700
		private List<T> b = new List<T>();
	}
}
